# Two Level Caching

When you use local (in-memory) caching, one server can cache some information and retrieve it as fast as possible but as other servers can't access that cached data, they have to query for the same information from database.

If you prefer distributed caching to let other servers access cached data as it has some serialization / deserialization and network latency overhead, it may degrade performance in some cases.

There is also another problem with caching that needs to be handled: cache invalidation:

> There are only two hard things in Computer Science: cache invalidation and naming things.

> -- Phil Karlton

When you cache some information, you have to make sure that, when the source data changes, cached information is invalidated (regenerated or removed from cache).


