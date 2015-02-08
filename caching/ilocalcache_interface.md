# ILocalCache Interface

[**namespace**: *Serenity.Abstrations*] - [**assembly**: *Serenity.Core*]

Defines a basic interface to work with the local cache.

```cs
public interface ILocalCache
{
    void Add(string key, object value, TimeSpan expiration);
    TItem Get<TItem>(string key);
    object Remove(string key);
    void RemoveAll();
}
```

> A default implementation of ILocalCache (`Serenity.Caching.HttpRuntimeCache`) that uses `System.Web.Cache` exists in `Serenity.Web` assembly.

### ILocalCache.Add Method

Adds a value to cache with the specified key. If the key already exists in cache, its value is updated.

Items are hold in cache for `expiration` duration. You can specify `TimeSpan.Zero` for items that shouldn't expire automatically.

Values are added to cache with absolute expiration (thus they expire at a certain time, not sliding expiration).

```cs
Dependency.Resolve<ILocalCache>.Add("someKey", "someValue", TimeSpan.FromMinutes(5));
```

This method, in its default implementation, uses HttpRuntime.Cache.Insert method.
> Avoid HttpRuntime.Cache.Add method, as it doesn't update value if there is already a key with same key in the cache, and it doesn't even raise an error so you won't notice anything. A mere engineering gem from ASP.NET)

### ILocalCache.Get`<TItem>` Method

Gets the value corresponding to the specified key in local cache.

If there is no such key in cache, an error may be raised only if TItem is of value type. For reference types returned value is `null`.

If value is not of type `TItem`, an exception is thrown.

You may use `object` as `TItem` parameter to prevent errors in case a value doesn't exist, or not of requested type.

### ILocalCache.Remove Method

Removes the item with specified key from local cache and returns its value.

No errors thrown if there is no value in cache with the specified key, simply `null` is returned.

```cs
Dependency.Resolve<ILocalCache>.Remove("someKey");
```

### ILocalCache.RemoveAll Method

Removes all items from local cache. Avoid using this except for special situations like unit tests, otherwise performance might suffer.
