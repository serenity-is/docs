# RedisDistributedCache Class

[**namespace**: *Serenity.Caching*, **assembly**: *Serenity.Caching.Couchbase*]

Redis is another in memory database that is also used by StackOverflow for its performance and reliability. They use just one Redis database for all their WEB servers.

You can get Serenity implementation for this server type in Serenity.Caching.Redis NuGet package.

It can be registered just like CouchbaseDistributedCache and configuration is similar (though there is no bucket setting):

```xml
<appSettings>
    <add key="DistributedCache" value="{
	    ServerAddress: 'someredisserver:6379',
	    KeyPrefix: ''
    }"/>
/>
```
