# Filtering with Multiple Genre List

Remember that when we had only one Genre per Movie, it was easy to quick filter, by adding a [QuickFilter] attribute to GenreId field.

Let's try to do similar in MovieColumns.cs:

```
[ColumnsScript("MovieDB.Movie")]
[BasedOnRow(typeof(Entities.MovieRow))]
public class MovieColumns
{
    //...
    [Width(200), GenreListFormatter, QuickFilter]
    public List<Int32> GenreList { get; set; }
}
```

As soon as you type a Genre into Genres you'll have this error:

![Invalid Column GenreList](img/mdb_genrelist_invalid.png)

ListHandler tried to filter by GenreList field, but as there is no such column in database, we got this error.

> Actually, LinkingSetRelation should be able to intercept this filter and convert it into an EXISTS subquery, but list behaviors can't do that yet. Maybe in a later version...

So, now we have to handle it somehow.


### Declaring MovieListRequest Type

As we are going to do something non-standard, e.g. filtering by values in a linking set table, we need to prevent ListHandler from filtering itself on GenreList property.

We could process the request *Criteria* object (which is similar to an expression tree) using a visitor and handle GenreList ourself, but it would be a bit complex. So i'll take a simpler road for now.

Let's take a subclass of standard *ListRequest* object and add our Genres filter parameter there. Add a *MovieListRequest.cs* file next to *MovieRepository.cs*:

```cs
namespace MovieTutorial.MovieDB
{
    using Serenity.Services;
    using System.Collections.Generic;

    public class MovieListRequest : ListRequest
    {
        public List<int> Genres { get; set; }
    }
}
```

We added a *Genres* property to our list request object, which will hold the optional *Genres* we want movies to be filtered on.


### Modifying Repository/Endpoint for New Request Type

For our list handler and service to use our new list request type, need to do changes in a few places.

Start with *MovieRepository.cs*:

```cs
public class MovieRepository
{
    //...
    public ListResponse<MyRow> List(IDbConnection connection, MovieListRequest request)
    {
        return new MyListHandler().Process(connection, request);
    }

    //...
    private class MyListHandler : ListRequestHandler<MyRow, MovieListRequest> { }
}
```

We changed ListRequest to MovieListRequest in List method and added a generic parameter to MyListHandler, to use our new type instead of ListRequest.

And another little change in *MovieEndpoint.cs*, which is the actual web service:

```cs
public class MovieController : ServiceEndpoint
{
    //...
    public ListResponse<MyRow> List(IDbConnection connection, MovieListRequest request)
    {
        return new MyRepository().List(connection, request);
    }
}
```

Now its time to build and transform templates, so our MovieListRequest object and related service methods will be available at client side.


### Moving Quick Filter to Genres Parameter

We still have the same error as quick filter is not aware of the parameter we just added to list request type and still uses the Criteria parameter.

Need to intercept quick filter item and move the genre list to *Genres* property of our *MovieListRequest*.

Edit *MovieGrid.ts*:

```ts
export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {

    //...
    protected getQuickFilters() {
        let items = super.getQuickFilters();

        var genreListFilter = Q.first(items, x =>
            x.field == MovieRow.Fields.GenreList);

        genreListFilter.handler = h => {
            var request = (h.request as MovieListRequest);
            var values = (h.widget as Serenity.LookupEditor).values;
            request.Genres = values.map(x => parseInt(x, 10));
            h.handled = true;
        };

        return items;
    }
}
```

getQuickFilters is a method that is called to get a list of quick filter objects for this grid type. 

By default grid enumerates properties with [QuickFilter] attributes in MovieColumns.cs and creates suitable quick filter objects for them.

We start by getting list of QuickFilter objects from super class.

```ts
let items = super.getQuickFilters();
```

Then locate the quick filter object for *GenreList* property:

```ts
var genreListFilter = Q.first(items, x =>
    x.field == MovieRow.Fields.GenreList);
```

Actually there is only one quick filter now, but we want to play safe.

Next step is to set the *handler* method. This is where a quick filter object reads the editor value and applies it to request's *Criteria* or *EqualityFilter* parameters, just before its submitted to list service.

```ts
genreListFilter.handler = h => {
```

Then we get a reference to current *ListRequest* being prepared:

```ts
var request = (h.request as MovieListRequest);
```

And read the current value in lookup editor:

```ts
var values = (h.widget as Serenity.LookupEditor).values;
```

Set it in *request.Genres* property:

```
request.Genres = values.map(x => parseInt(x, 10));
```

As values is a list of string, we needed to convert them to integer.

Last step is to set *handled* to true, to disable default behavior of quick filter object, so it won't set *Criteria* (if multiple) or *EqualityFilter* (if single value) itself:

```ts
h.handled = true;
```

Now we'll no longer have *Invalid Column Name GenreList* error but Genres filter is not applied server side.


### Handling Genre Filtering In Repository








