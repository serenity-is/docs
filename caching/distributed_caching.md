# Distributed Caching

Web applications might require to serve hundreds, thousands or even more users simultaneously. If you didn't take required measures, under such a load, your site might crash or become unresponsive.

Let's say you are showing the last 10 news in your home page and in a minute, in average of a thousand users are visiting this page. For every page view you might be querying your database to display this information:

```sql
SELECT TOP 10 Title, NewsDate, Subject, Body FROM News ORDER BY NewsDate DESC
```

Even if we think that our home page contains only this information, a site, that gets 10000 visits a minute would run 150 SQL queries per second.

These queries, as their result doesn't differ from user to user (always the last 10 news), might be cached in SQL server side automatically.

But query results consumes some valuable network bandwidth while being transferred from SQL server to your WEB server. As this transfer takes some time (data size / bandwidth) and your connection is kept open during this time, even if your SQL server responded instantly, getting the results wouldn't be so fast. The time to transfer might vary with the size of the news content.

Also as SQL connections which can be kept open simultaneously has a upper limit (connection pool limit) and when you reach that number, the connections start to wait in the queue and block each other.

By taking into account that news don't change every second, we could cache them in our WEB server memory for 5 minutes.

Thus as soon as we transfer news list from SQL database, store them in local cache. For the next 5 minutes, for every user that visits the home page, news list is read from local cache instantly, without even hitting SQL:

```cs
public List<News> GetNews()
{
    var news = HttpRuntime.Cache["News"] as List<News>;
    if (news == null)
    {
        using (var connection = new SqlConnection("......"))
        {
            news = connection.Query<News>("
                   SELECT TOP 10 Title, NewsDate, Subject, Body
                   FROM News
                   ORDER BY NewsDate DESC")
               .ToList();

            HttpRuntime.Cache.Insert("News", ...,
                TimeSpan.FromMinutes(5), ....);
        }
    }

    return news;
}
```

This takes us from 150 queries per second down to 1/300 queries per second (a query per 300 sec).

> Also these news items should be converted to HTML for every visitor. By moving one step further, we could also cache the HTML converted state of the news.

All these cached information is stored in WEB server memory which is the fastest location to access them.

> Note that caching something doesn't always mean that your application will work faster. How effectively you use cache is more important than caching alone. It is even possible to slow down your application with caching, if not used properly.


