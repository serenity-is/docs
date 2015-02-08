# Service Locator &amp; Initialization

Serenity uses the service locator pattern to abstract its dependencies and make it possible to work with your chosen libraries and service providers.

For example, Serenity doesn't care about how you store your users, but it can query current user through an abstraction (IAuthorizationService, IUserRetrieveService etc.)

Similarly you may use Redis, Couchbase, Memcached or any other as distributed cache in your application. Serenity doesn't have a direct dependency on any of their client libraries. As soon as you implement IDistributedCache interface and register it with the service locator, Serenity will start working with your NoSQL database.

> Some might argue that Service Locator is an anti-pattern that should be avoided. An alternative to it would be the Dependency Injection pattern. But it seems unlogical having to know about every dependency (and dependencies of dependencies...) of an object to just be able to use it (you shouldn't have to know about details of what your mobile operator uses to send a simple SMS). Maybe DI is a sample of over-engineering.

