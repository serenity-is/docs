# TwoLevelCache 类

[**命名空间**: *Serenity*] - [**程序集**: *Serenity.Core*]

开箱即用，TwoLevelCache 提供了我们讨论的所有甚至更多的功能。

```cs
    public static class TwoLevelCache
    {
        public static TItem Get<TItem>(
            string cacheKey, TimeSpan expiration,
            string groupKey, Func<TItem> loader)
                where TItem : class;

        public static TItem Get<TItem>(
            string cacheKey, TimeSpan localExpiration, TimeSpan remoteExpiration,
            string groupKey, Func<TItem> loader)
                where TItem : class;

        public static TItem GetWithCustomSerializer<TItem, TSerialized>(
            string cacheKey, TimeSpan localExpiration, TimeSpan remoteExpiration,
            string groupKey, Func<TItem> loader,
            Func<TItem, TSerialized> serialize,
            Func<TSerialized, TItem> deserialize)
                where TItem : class
                where TSerialized : class;

        public static TItem GetLocalStoreOnly<TItem>(
            string cacheKey, TimeSpan localExpiration,
            string groupKey, Func<TItem> loader)
            where TItem : class;

        public static void ChangeGlobalGeneration(string globalGenerationKey);
        public static void Remove(string cacheKey);
    }
```

## TwoLevelCache.Get 方法

- 试图从本地缓存中读取值。如果在本地缓存中找不到值（或已过期的版本），则尝试从分布式缓存中读取值。

- 如果都不包含指定的键，通过调用加载函数生成值，并指定过期时间且将值添加到本地和分布式缓存。

- 这里有两个 Get 方法的重载：一个分别使用本地和分布式缓存过期时间；另一个让两种缓存方式都使用一个过期参数。

- 通过使用一个组键（group key），可以一次性让该组上的两种缓存类型的所有成员都过期 （这一组缓存信息都过期了）。

> 为了避免组代（group generation）每次都检查是否包含该项目，组代本身也缓存在本地缓存中。因此，当组成员改变时，本地缓存的项目会在 5 秒后过期。

> 这意味着，如果你在组织网站群中使用这种策略，当其中一台服务器的缓存发生更改时，其他服务器可能会继续使用旧的本地缓存的数据（有 5 秒的延迟）。

> 如果这是配置问题，应该直接使用 DistributedCache 方法而不是依赖于 TwoLevelCache。

![TwoLevelCache.Get Flow Diagram](img/two_level_cache_get_en.jpg)

```
CachedProfile GetCachedProfile(int userID)
{
    TwoLevelCache.Get("CachedProfile:" + userID, TimeSpan.FromDays(1), "SomeGroupKey",
        () =>
        {
            using (var connection = new SqlConnection("..."))
            {
                connection.Open();
                return LoadProfileFromDB(connection, userID);
            }
        });
}

CachedProfile LoadProfileFromDB(IDbConnection connection, int userID)
{
    // ...
}
```

## TwoLevelCache.GetWithCustomSerializer 方法

TwoLevelCache.Get 将缓存的数据存储在本地和分布式缓存。当在本地缓存存储缓存项目时，不需要序列化（在内存）。但是在项目发送到分布式缓存之前，必须执行（取决于提供者和数据类型）一些序列化（二进制、json 等）。 

有时该序列化/反序列化操作是昂贵的，所以你可能想自己实现数据类型序列化的功能。

GetWithCustomSerializer  有两个额外的序列化和反序列化委托参数。可以从序列化函数返回一个字符串或字节数组，并且在反序列化过程中使用此字符串或字节数组将其转换回原来的数据类型。

> 大多数提供者可有效地处理简单的类型，如 int、 string 或 byte[]，所以对于这种数据类型，你不需要自定义序列化。

## TwoLevelCache.GetLocalStoreOnly 方法

如果你只想在本地缓存中存储数据，可以使用 GetLocalStoreOnly 方法。

当缓存的数据由一台服务器存储时，该数据对其他服务器没有帮助（从服务器到服务器的更改），因此，在分布式缓存中存储大的或者慢的序列化/反序列化数据是没有意义的。

因此，在这种情况下，为什么不直接使用本地缓存呢？

可以这么做。但是如果想指定一组键（group key），而且当该组的源数据改变时，本地缓存项目可以很容易过期（就好像它们存储在分布式缓存），就不应该这么做。


## TwoLevelCache.ExpireGroupItems 方法

此方法允许使一个组键（group key）的所有成员的都过期。它只是从本地和分布式缓存中删除组键，因此在下一次查询时将会生成另一个版本的缓存数据。

```cs
TwoLevelCache.ExpireGroupItems("SomeGroupKey");
```

> 应该在修改数据的方法中调用此方法。

> 如果实体类有 *TwoLevelCached* 特性，*Create、Update、Delete 和 Undelete* 使用 *ConnectionKey.TableName*  作为组键自动做缓存过期处理。

## TwoLevelCache.Remove 方法

从本地和分布式缓存中移除项目和其版本。
