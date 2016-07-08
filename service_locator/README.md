# 服务定位器(Service Locator) &amp; 初始化

Serenity 使用服务定位模式（service locator pattern）抽象其依赖，以使其可以与你选择的库（libraries）和服务提供者（service providers）一起工作。

例如，Serenity 并不关心你是如何存储用户，但是它可以通过抽象（IAuthorizationService、 IUserRetrieveService 等）查询当前用户。

与你在应用程序中使用 Redis、Couchbase、Memcached 或其他分布式缓存类似。只要实现 IDistributedCache 接口，并向其注册服务定位器，Serenity 便开始使用 NoSQL 数据库。 

> 有些人可能认为服务定位器是一种反模式，应该避免使用该模式，并把它替换为依赖注入模式。但没必要了解对象的每个依赖（及依赖的依赖……），就可以使用它（你不必知道移动运营商如何发送短信的细节）。也许 DI 是过度设计（over-engineering）的示例。

