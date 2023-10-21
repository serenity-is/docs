# Filtering with Multiple Genre Lists

In the past, when we had just one genre per movie, it was simple to apply a quick filter by adding a [QuickFilter] attribute to the GenreId field.

Now, let's attempt something similar in MovieColumns.cs:

```cs
public class MovieColumns
{
    //...
    [Width(200), GenreListFormatter, QuickFilter]
    public List<int> GenreList { get set; }
}
```

The LinkingSetRelation will automatically handle equality filtering for its field, making it work seamlessly. We could conclude this topic here, but for the sake of providing a sample for defining custom list requests and handling filtering when there is no LinkingSetRelation behavior available, let's continue with the steps below.

## Declaring the MovieListRequest Type

As we're about to perform a non-standard action, such as filtering by values in a linking set table, we need to prevent the ListHandler from filtering itself on the GenreList property. To achieve this, let's create a subclass of the standard *ListRequest* object and add our Genres filter parameter to it. Create a *MovieListRequest.cs* file next to *MovieEndpoint.cs*:

```cs
using Serenity.Services;
using System.Collections.Generic;

namespace MovieTutorial.MovieDB
{
    public class MovieListRequest : ListRequest
    {
        public List<int> Genres { get; set; }
    }
}
```

In this file, we've introduced a *Genres* property within our list request object, which will hold the optional genres by which we want to filter movies.

## Modifying Request Handlers/Endpoint for the New Request Type

To ensure that our list handler and service can utilize our new list request type, we need to make changes in a few places. Let's start with *MovieDB/Movie/RequestHandlers/MovieListHandler.cs*, where we'll change the type for the `MyRequest` alias to our new `MovieListRequest` type:

```cs
using MyRequest = MovieTutorial.MovieDB.MovieListRequest;
```

Additionally, we need to make a minor adjustment in *MovieEndpoint.cs*, which represents the actual web service:

```cs
public class MovieEndpoint : ServiceEndpoint
{
    //...
    public ListResponse<MyRow> List(IDbConnection connection, MovieListRequest request,
        [FromServices] IMovieListHandler handler)
    {
        return handler.List(connection, request);
    }

    public FileContentResult ListExcel(IDbConnection connection, MovieListRequest request,
        [FromServices] IMovieListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
    //...
}
```

Now it's time to rebuild the project so that our MovieListRequest object and related service methods become available on the client side.

## Updating Quick Filter for the Genres Parameter

In this section, we'll be intercepting the quick filter item and moving the genre list to the *Genres* property of our *MovieListRequest*. To accomplish this, we'll make edits in the *MovieGrid.ts* file:

```typescript
import { Decorators, EntityGrid, first, localText, LookupEditor, QuickSearchField } from '@serenity-is/corelib';
import { MovieColumns, MovieRow, MovieService } from '@/ServerTypes/MovieDB';
import { MovieListRequest } from '@/ServerTypes/MovieDB/MovieListRequest';
import { MovieDialog } from './MovieDialog';

@Decorators.registerClass('MovieTutorial.MovieDB.MovieGrid')
export class MovieGrid extends EntityGrid<MovieRow, any> {
    // ...

    protected getQuickFilters() {
        let items = super.getQuickFilters();

        const genreListFilter = first(items, x =>
            x.field == MovieRow.Fields.GenreList);

        genreListFilter.handler = h => {
            const request = (h.request as MovieListRequest);
            const values = (h.widget as LookupEditor).values;
            request.Genres = values.map(x => parseInt(x, 10));
            h.handled = true;
        };

        return items;
    }
}
```

The `getQuickFilters` method is called to retrieve a list of quick filter objects for this grid type. By default, the grid enumerates properties with [QuickFilter] attributes in MovieColumns.cs and creates appropriate quick filter objects for them.

We start by obtaining a list of QuickFilter objects from the superclass:

```typescript
let items = super.getQuickFilters();
```

Then, we locate the quick filter object for the *GenreList* property:

```typescript
const genreListFilter = first(items, x =>
    x.field == MovieRow.Fields.GenreList);
```

Although currently, there's only one quick filter, it's a good practice to be cautious.

The next step is to set the *handler* method. This is where a quick filter object reads the editor value and applies it to the request's *Criteria* (if multiple values) or *EqualityFilter* (if a single value) parameters, just before it's submitted to the list service:

```typescript
genreListFilter.handler = h => {
```

We then obtain a reference to the current *ListRequest* being prepared:

```typescript
const request = (h.request as MovieListRequest);
```

Next, we read the current value in the lookup editor:

```typescript
const values = (h.widget as LookupEditor).values;
```

We set these values in the *request.Genres* property, converting them to integers as values are in string format:

```typescript
request.Genres = values.map(x => parseInt(x, 10));
```

The final step is to set *handled* to true, disabling the default behavior of the quick filter object, ensuring it won't set *Criteria* or *EqualityFilter* itself:

```typescript
h.handled = true;
```

With these changes, we've now handled quick filtering for genres in a custom manner. However, please note that the filter is not yet applied server-side.

## Implementing Genre Filtering in the Movie List Handler

In this section, we'll make modifications to the *MovieDB/Movie/RequestHandlers/MovieListHandler.cs* file to override the `ApplyFilters` method. This method is responsible for applying filters specified in the list request's *Criteria* and *EqualityFilter* parameters, making it an ideal place for our custom filter implementation.

Let's take a look at the changes in the code:

```csharp
public class MovieListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieListHandler
{
    //...

    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);

        if (!Request.Genres.IsEmptyOrNull())
        {
            var fld = MyRow.Fields;
            var mg = MovieGenresRow.Fields.As("mg");

            query.Where(Criteria.Exists(
                query.SubQuery()
                    .From(mg)
                    .Select("1")
                    .Where(
                        mg.MovieId == fld.MovieId &&
                        mg.GenreId.In(Request.Genres))));
        }
    }
}
```

The `ApplyFilters` method is called to apply the filters specified in the list request's *Criteria* and *EqualityFilter* parameters. It's an excellent place for us to implement our custom filter.

We start by checking whether *Request.Genres* is null or an empty list. If this is the case, there's no need for filtering.

Next, we obtain a reference to the fields of *MovieGenresRow* with the alias "mg":

```csharp
var mg = MovieGenresRow.Fields.As("mg");
```

This may require some explanation, as we haven't covered the Serenity entity system yet. Let's start without aliasing *MovieGenresRow.Fields*:

```csharp
var x = MovieGenresRow.Fields;
new SqlQuery()
  .From(x)
  .Select(x.MovieId)
  .Select(x.GenreId);
```

If we were to write a query as shown above, the resulting SQL would be something like this:

```sql
SELECT t0.MovieId, t0.GenreId FROM MovieGenres t0
```

By default, Serenity assigns "t0" to a row's primary table. Even if we named *MovieGenresRow.Fields* as the variable "x", its alias would still be "t0".

However, when using "x" as an alias, we would need to write it explicitly:

```csharp
var x = MovieGenresRow.Fields.As("x");
new SqlQuery()
  .From(x)
  .Select(x.MovieId)
  .Select(x.GenreId);
```

This would result in SQL like this:

```sql
SELECT x.MovieId, x.GenreId FROM MovieGenres x
```

In the *MovieListHandler*, "t0" is already used for *MovieRow* fields. To prevent clashes with *MovieGenresRow* fields (referred to as "fld"), I've assigned "MovieGenresRow" an alias, "mg":

```csharp
var mg = MovieGenresRow.Fields.As("mg");
```

What we're trying to achieve here is a query similar to what we'd write in plain SQL:

```sql
SELECT t0.MovieId, t0.Title, ... FROM Movies t0
WHERE EXISTS (
   SELECT 1 
   FROM MovieGenres mg 
   WHERE 
     mg.MovieId = t0.MovieId AND
     mg.GenreId IN (1, 3, 5, 7)
)
```

So, we're adding a WHERE filter to the main query using the `Where` method, which includes an `EXISTS` criteria:

```csharp
query.Where(Criteria.Exists(
```

We then proceed to build the subquery:

```csharp
query.SubQuery()
    .From(mg)
    .Select("1")
```

And add the WHERE statement for the subquery:

```csharp
.Where(
    mg.MovieId == fld.MovieId &&
    mg.GenreId.In(Request.Genres))
```

Here, "fld" actually contains the alias "t0" for MovieRow fields.

While it may appear a bit unusual at first, over time, you'll discover that the Serenity query system closely resembles SQL, matching it almost 99%. It can't be the exact SQL due to the use of a different language, C#.

With these modifications, filtering for the *GenreList* property now works perfectly. We've also demonstrated how to handle custom requirements when Serenity doesn't provide an out-of-the-box solution.