# RedisDistributedCache 类

[**命名空间**: *Serenity.Caching*, **程序集**: *Serenity.Caching.Couchbase*]

Redis 是另一种内存数据库，由于其优秀的性能和可靠性， StackOverflow 也在使用它，他们所有的 WEB 服务只用了一个 Redis 数据库。

你可以从 Serenity.Caching.Redis 的 NuGet 程序包获取该服务类型的 Serenity 实现。

它可以像基于云分布式缓存（CouchbaseDistributedCache）那样注册，并且配置非常类似（虽然没有大量的配置）：

```xml
<appSettings>
    <add key="DistributedCache" value="{
	    ServerAddress: 'someredisserver:6379',
	    KeyPrefix: ''
    }"/>
/>
```
