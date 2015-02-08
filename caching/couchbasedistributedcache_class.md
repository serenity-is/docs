# CouchbaseDistributedCache Class

[**namespace**: *Serenity.Caching*, **assembly**: *Serenity.Caching.Couchbase*]

Couchbase is a distributed database that has Memcached like access interface.

You can get Serenity implementation for this server type in Serenity.Caching.Couchbase NuGet package.

Once you register it with the service locator:

```cs
Dependency.Resolve<IDependencyRegistrar>()
    .RegisterInstance<IDistributedCache>(new CouchbaseDistributedCache())
```

You can configure CouchbaseDistributedCache in application configuration file (with JSON format):

```xml
<appSettings>
    <add key="DistributedCache" value='{
        ServerAddress: "http://111.22.111.97:8091/pools",
        BucketName: "primary-bucket",
        KeyPrefix: ""
    }' />
```

Here ServerAddress is Couchbase server address and BucketName is the bucket name.

If you wanted to use same server / bucket for more than one application you can put something like `DEV:`, `TEST:` into KeyPrefix setting.
