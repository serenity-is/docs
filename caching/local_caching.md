# Local Caching

Serenity provides some caching abstractions and utility functions to make it easier to work with local cache.

The term *local* means that cached items are hold in local memory (thus there is no serialization involved).

When your application is deployed on a web farm, local caching might not be enough or sometimes suitable. We will talk about this scenario in [Distributed Caching](distributed_caching.md) section.

