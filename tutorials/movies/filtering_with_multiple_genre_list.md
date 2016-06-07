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

Actually, LinkingSetRelation should be able to intercept this filter and convert it into an EXISTS subquery, but list behaviors can't do that yet. Maybe in a later version...

So, now we have to handle it somehow.


### Declaring MovieListRequest Type

As we are going to do something non-standard, e.g. filtering by values in a linking set table, we need to prevent ListHandler from filtering itself on GenreList property.

We could process the request *Criteria* object (which is similar to an expression tree) using a visitor and handle GenreList ourself, but it would be a bit too complex. So i'll take a simpler road for now.

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


