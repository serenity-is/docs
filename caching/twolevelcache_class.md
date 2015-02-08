# TwoLevelCache Class

[**namespace**: *Serenity*] - [**assembly**: *Serenity.Core*]

Out of the box, TwoLevelCache provides all functionality that we talked about so far and some more.

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

## TwoLevelCache.Get Method

- Tries to read a value from local cache. If it is not found in there (or has an expired version), tries the distributed cache.

- If neither contains the specified key, produces value by calling a loader function and adds the value to local and distributed cache for a given expiration time.

- There are two overloads of the Get method. One that takes expiration time for local and distributed caches separately, and another that has only one expiration parameter for both.

- By using a group key, all items on both cache types that are members of this group can be expired at once (this is generation based expiration, not time).

> To avoid checking group generation every time an item that belongs to group is requested, group generation itself is also cached in local cache. Thus, when a generation number changes, local cached items might expire after 5 seconds.

> This means that, if you use this strategy in a web farm setup, when a change occurs in one server, other servers might continue to use old local cached data for 5 seconds more.

> If this is a problem for your configuration, you should use DistributedCache methods directly instead of depending on TwoLevelCache.

![TwoLevelCache.Get Flow Diagram](https://raw.githubusercontent.com/volkanceylan/SerenityGuide/master/img/two_level_cache_get_en.png?v4)

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

## TwoLevelCache.GetWithCustomSerializer Method

TwoLevelCache.Get stores cached data in both local cache and distributed cache. While storing cached items in local cache, serialization is not required (in-memory). But before items are sent to distributed cache, some kind of serialization (binary, json etc.) must be performed (depends on provider and data type).

Sometimes this serialization / deserialization operation can be costly, so you might want to provide your own implementation of these functions for your data type.

GetWithCustomSerializer takes two extra delegate arguments to serialize and deserialize values. You might return a string or byte array from serialization function, and in deserialization take this string or byte array and turn it back into your original data type.

> Most providers handle simple types like int, string or byte[] effectively, so for such data types you don't need custom serialization.

## TwoLevelCache.GetLocalStoreOnly Method

If you only want to store items in local cache and not distributed cache, GetLocalStoreOnly can be useful.

When cached data by one server is not helpful for others (changes from server to server), so big or slow to serialize / deserialize, storing such data in distributed cache is not meaningful.

So, why shouldn't you use LocalCache directly in this case?

You could but not if you want to specify a group key, and expire local cached items easily when source data of that group changes (as if they are stored in distributed cache).


## TwoLevelCache.ExpireGroupItems Method

This method allows you to expire all items that are members of one group key. It simply removes group key from local cache and distributed cache, so another version will be generated next time it is queried.

```cs
TwoLevelCache.ExpireGroupItems("SomeGroupKey");
```

> You should call this from methods that change data.

> If your entity class has *TwoLevelCached* attribute on it, *Create, Update, Delete and Undelete* handlers do this automatically with *ConnectionKey.TableName* as group key.

## TwoLevelCache.Remove Method

Removes an item and its version from local and distributed cache.
