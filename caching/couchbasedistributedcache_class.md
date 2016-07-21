# CouchbaseDistributedCache 类

[**命名空间**: *Serenity.Caching*, **程序集**: *Serenity.Caching.Couchbase*]

Couchbase 是一个分布式数据库，有像 Memcached 的访问接口。

可以从 NuGet 程序包 Serenity.Caching.Couchbase 获取 Serenity 对此服务类型的实现。

一旦你使用服务定位器注册它：

```cs
Dependency.Resolve<IDependencyRegistrar>()
    .RegisterInstance<IDistributedCache>(new CouchbaseDistributedCache())
```

就可以在应用程序配置文件（使用 JSON 格式）配置 CouchbaseDistributedCache：

```xml
<appSettings>
    <add key="DistributedCache" value='{
        ServerAddress: "http://111.22.111.97:8091/pools",
        BucketName: "primary-bucket",
        KeyPrefix: ""
    }' />
```

这里的 ServerAddress 是 Couchbase 服务器地址，BucketName 是 bucket 名称。

如果想为多个应用程序使用相同的 server / bucket，可以在 KeyPrefix 设置，如 `DEV:`、`TEST:`。
