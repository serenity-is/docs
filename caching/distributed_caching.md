# 分布式缓存

Web 应用程序可能需要为成百上千甚至更多的用户同时提供服务。如果你没有采取必要的措施，在这种负载下，你的网站可能会崩溃或变得没有响应。

假设在主页显示最后 10 条新闻，并且平均每分钟有上千名用户访问此页面。你可能为每个用户通过查询数据库来显示页面视图信息：

```sql
SELECT TOP 10 Title, NewsDate, Subject, Body FROM News ORDER BY NewsDate DESC
```

即使我们认为主页只包含这些信息，但网站每分钟有 10000 个访客，每秒运行 150 次 SQL 查询。

如果这些查询的结果在用户间没有太大的不同（总是最后 10 条新闻），可以自动缓存在 SQL 服务器端。

但查询结果从 SQL 服务器传输到 WEB 服务器会消耗一些宝贵的网络带宽。由于数据传输需要一些时间（数据大小/带宽），并且在此期间内保持连接处于打开状态，即使 SQL 服务器响应及时，得到的结果也不会太快。传输的时间与新闻内容的大小可能不同。

 况且 SQL 连接保持开启的数目也有上限（连接池限制），当达到这一上限，连接便开始在队列中等待并相互阻塞。

考虑到新闻不是每一秒都在改变，我们可以把它们缓存在 WEB 服务器内存 5 分钟。

因此，从 SQL 数据库传输得到新闻列表就立即将它们存储在本地缓存中。在接下来的 5 分钟内，每个用户访问的主页，其新闻列表都是从本地缓存中即时获取的，甚至不用使用 SQL：

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

这使我们从每秒 150 次查询下降到每秒 1/300 次查询（每 300 秒查询一次）。

> 此外，这些新闻项目应为每一位访客转换为 HTML。更进一步，我们还可以缓存转换为 HTML 状态的新闻。

所有这些缓存信息都存储在 WEB 服务器内存中，内存是访问这些信息的最快位置。

> 请注意，缓存信息并不总是意味着你的应用程序将工作得更快。如何有效地使用缓存比单独缓存更重要。如果没有正确使用缓存，它甚至有可能减慢你的应用程序。


