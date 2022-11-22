# Listing Movies in Person Dialog

To show list of movies a person acted in, we'll add a tab to PersonDialog.

Serenity supports making tabs from form script. 

Make fallowing changes to *PersonForm.cs*:
```cs
namespace MovieTutorial.MovieDB.Forms
{
    //...
    public class PersonForm
    {
        [Tab("Person")]
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public int Height { get; set; }
        [Tab("Movies"), IgnoreName]
        public string MoviesGrid { get; set; }
    }
}
```

Serenity will open a tab named *Person* and adds the properties until it sees another tab or reaches end of the properties. It will create the tabs in order. So watch where you put properties and tabs. Don't forget to put *IgnoreName* attribute since MoviesGrid is not a property in PersonsRow.

Now, we have a tab in PersonDialog:

![Person With Tabs Initial](img/mdb_person_tabs.png)

### Creating PersonMovieGrid

Movie tab has an StringEditor for now. We need to define a grid with suitable columns and place it in that tab.

First, declare the columns we'll use with the grid, in file *PersonMovieColumns.cs* next to *PersonColumns.cs*:

```cs
using Serenity.ComponentModel;
using System;

namespace MovieTutorial.MovieDB.Columns
{
    [ColumnsScript("MovieDB.PersonMovie")]
    [BasedOnRow(typeof(MovieCastRow))]
    public class PersonMovieColumns
    {
        [Width(220)]
        public String MovieTitle { get; set; }
        [Width(100)]
        public Int32 MovieYear { get; set; }
        [Width(200)]
        public String Character { get; set; }
    }
}
```

Next define a *PersonMovieGrid* class, in file *PersonMovieGrid.ts* next to *PersonGrid.ts*:

```ts
import { Decorators, EntityGrid } from "@serenity-is/corelib";
import { MovieCastRow, MovieCastService } from "../../ServerTypes/MovieDB";

@Decorators.registerEditor("MovieTutorial.MovieDB.PersonMovieGrid")
export class PersonMovieGrid extends EntityGrid<MovieCastRow, any>
{
    protected getColumnsKey() { return "MovieDB.PersonMovie"; }
    protected getIdProperty() { return MovieCastRow.idProperty; }
    protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
    protected getService() { return MovieCastService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
```

After creating editor build the project so sergen can create an attribute for this editor.

Open *MovieFrom.cs* and add editor for MovieGrid field:

```cs
namespace MovieTutorial.MovieDB.Forms
{
    //...
    public class PersonForm
    {
        //...
        [Tab("Movies"), IgnoreName, PersonMovieGrid]
        public string MoviesGrid { get; set; }
    }
}
```


We'll actually use MovieCast service, to list movies a person acted in.

OK, now we can see list of movies in Movies tab, but something is strange:

![Person With Movies Unfiltered](img/mdb_person_cast3.png)

### Filtering Movies for the Person

No, Carrie-Anne Moss didn't act in three roles. This grid is showing all movie cast records for now, as we didn't tell what filter it should apply yet.

PersonMovieGrid should know the person it shows the movie cast records for. We need to add a *PersonID* property to this grid. This *PersonID* should be passed somehow to list service for filtering.

```ts
namespace MovieTutorial.MovieDB
{
    @Serenity.Decorators.registerClass()
    export class PersonMovieGrid extends Serenity.EntityGrid<MovieCastRow, any>
    {
        protected getColumnsKey() { return "MovieDB.PersonMovie"; }
        protected getIdProperty() { return MovieCastRow.idProperty; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getService() { return MovieCastService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            return null;
        }

        protected getInitialTitle() {
            return null;
        }

        protected usePager() {
            return false;
        }

        protected getGridCanLoad() {
            return this.personID != null;
        }

        private _personID: number;

        get personID() {
            return this._personID;
        }

        set personID(value: number) {
            if (this._personID != value) {
                this._personID = value;
                this.setEquality(MovieCastRow.Fields.PersonId, value);
                this.refresh();
            }
        }
    }
}
```

> We are using ES5 (EcmaScript 5) property (get/set) features. It's pretty similar to C# properties.

We store the person ID in a private variable. When it changes, we also set a equality filter for PersonId field using SetEquality method (which will be sent to list service),
and refresh to see changes.

> Equality filter is the list request parameter that is also used by quick filter items.

Overriding GetGridCanLoad method allows us to control when grid can call list service. If we didn't override it, while creating a new Person, grid would load all movie cast records, as there is not a PersonID yet (it is null).

> List handler ignores an equality filter parameter if its value is null. Just like when a quick filter dropdown is empty, all records are shown.

We also did three cosmetic changes, by overriding three methods, first to remove all buttons from toolbar (*getButtons*), second to remove title from the grid (*getInitialTitle*) as tab title is enough), and third to remove paging functionality (*usePager*), a person can't have a million movies right?). 

### Setting PersonID of PersonMovieGrid in PersonDialog

If nobody sets grid's PersonID property, it will always be null, and no records will be loaded. We should set it in afterLoadEntity method of Person dialog:

```ts
namespace MovieTutorial.MovieDB
{
    // ...
    export class PersonDialog extends Serenity.EntityDialog<PersonRow>
    {
        // ...
        protected afterLoadEntity()
        {
            super.afterLoadEntity();

            this.moviesGrid.personID = this.entityId;
        }
    }
}
```

*afterLoadEntity* is called after an entity or a new entity is loaded into dialog.

> Please note that entity is loaded in a later phase, so it won't be available in dialog constructor.

*this.EntityId* refers to the identity value of the currently loaded entity. In new record mode, it is null.

> AfterLoadEntity and LoadEntity might be called several times during dialog lifetime, so avoid creating some child objects in these events, otherwise you will have multiple instances of created objects. Thats why we created the grid in dialog constructor.

![Person With Movies Filtered](img/mdb_person_movies.png)

### Fixing Movies Tab Size

You might have noticed that when you switch to Movies tab, dialog gets a bit less in height. This is because dialog is set to auto height and grids are 200px by default. When you switch to movies tab, form gets hidden, so dialog adjusts to movies grid height.

Edit *s-MovieDB-PersonDialog* css in site.moviedb.less:

```css
.s-MovieDB-PersonDialog .s-PersonMovieGrid > .grid-container {
    height: 251px;
}
```


