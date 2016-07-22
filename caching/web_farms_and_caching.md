# 网站群和缓存

现在假设我们有一个社交网站，有数以百万的用户简介，一些著名用户的简介页面每分钟有数百或数千人访问。

要生成一个用户简介，需要多个 SQL 查询（朋友、相册名称及照片总数、简介信息、最后状态等）。

只要用户没有更新个人资料，在个人资料页显示的信息几乎是静态的。因此，个人资料页的快照可以缓存 5 分钟或 1 小时等。

但这或许还不够。我们正在谈论数以百万的简介和用户。用户不会只查看一些简介页。我们需要将多台服务器分布在全球的各个位置（WEB 网站群）。

在特定的时间，所有服务器可能在本地缓存中缓存一个贵宾 (VIP) 简介。当 VIP 更改了简介，所有服务器应更新本地缓存简介，并且这要在几秒内发生。现在，我们有服务器（而不是用户）的负载问题。

实际上，一旦服务器从 SQL 数据库加载并缓存 VIP 简介，其他服务器可以使用相同的信息而不用访问数据库。但是，由于每个服务器在其本地内存中存储缓存信息，其他服务器要访问此信息可不是小事。

如果我们有所有服务器可以访问的共享内存：

Information key          |Value
-------------------------|--------------------------------------
Profile:VeryFamousOne    |(Cached information for VeryFamousOne)
Profile:SomeAnother      |...
...                      |...
...                      |...
Profile:JohnDoe          |...

我们称之为内存分布式缓存（memory the distributed cache）。如果所有服务器在尝试查询 DB 之前检索该公共内存，我们就可避免服务器的负载问题。


```cs
public CachedProfileInformation GetProfile(string profileID)
{
    var profile = HttpRuntime.Cache["Profil:" + profileID]
        as CachedProfileInformation;

    if (profile == null)
    {
        profile = DistributedCache.Get<CachedProfileInformation>(
            "Profil:" + profileID);

        if (profile == null)
        {
            using (var connection = new SqlConnection("......"))
            {
                profile = GetProfileFromDBWithSomeSQLQueries(profileID)
                    profile, TimeSpan.FromMinutes(5));

                DistributedCache.Set("Profil:" + profileID, profile,
	                TimeSpan.FromHours(1));
            }
        }
    }

    return news;
}
```

你可以找到许多不同的分布式缓存系统，包括 Memcached、 Couchbase 和 Redis。它们也被称为 NoSQL 数据库。你可以简单地认为它们只是一个远程字典（remote dictionary）。它们将键/值对存储在内存中以使你尽可能快地访问。

> 警告！当使用得当时，分布式缓存就像本地缓存那样可以提高应用程序的性能。而使用不当时，由于涉及网络传输和序列化成本，它可能有比使用本地缓存更糟糕的效果，所以 “如果使用分布式缓存，我们的网站将会跑得快” 将会是一个神话。

当缓存的数据变得越来越多时，计算机内存可能不足以存储所有的键/值对。在这种情况下， 服务器（如 memcached）可通过向集群分发数据。可以通过键的第一个字母完成：其中一台服务器存储以 A 开头的键值对，另一台以 B 开头，以此类推。事实上，为了实现该目的它们使用哈希值的键。
