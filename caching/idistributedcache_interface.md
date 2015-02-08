# IDistributedCache Interface

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

All NoSQL server types provide a similar interface like "store this value for this key", "give me value corresponding to this key" etc.

Serenity provides its distributed cache support through a common interface to not depend on a specific kind of NoSQL database:

```cs
public interface IDistributedCache
{
    long Increment(string key, int amount = 1);
    TValue Get<TValue>(string key);
    void Set<TValue>(string key, TValue value);
    void Set<TValue>(string key, TValue value, TimeSpan expiration);
}
```


First overload of Set method that takes key and value arguments is used to store a key/value pair in distributed cache.

```cs
IoC.Resolve<IDistributedCache>().Set("someKey", "someValue");
```

Later we could read back this value using Get method:

```cs
var value = IoC.Resolve<IDistrubutedCache().Get<string>("someKey") // someValue
```

If we wanted to keep some value for a predetermined duration, we could use the second overload of Get method:

```cs
IoC.Resolve<IDistributedCache>().Set("someKey", "someValue",
    TimeSpan.FromMinutes(10));
```

## IDistributedCache.Increment Method

Operation on distributed cache systems are usually not atomic and they provide no transactional systems at all.

Same key value can be changed by multiple servers at same time and override each others value in random order.

Let's say we needed a unique counter (to generate an ID for example) and synchronize it through distributed cache (to prevent using same ID twice):

```cs
int GetTheNextIDValue()
{
    var lastID = IoC.Resolve<IDistributedCache>().Get("LastID");
    IoC.Resolve<IDistributedCache>().Set("LastID", lastID + 1);
    return lastID;
}
```

Such a code block won't function as expected. Inside the duration between reading `LastID` value (get) and setting it to increment `LastID` value (set), another server might have read the same LastID value. Thus two servers could use same ID value.

For this purpose, you can use Increment method:

```cs
int GetTheNextIDValue()
{
    return IoC.Resolve<IDistributedCache>().Increment("LastID");
}
```

Increment function acts just like Interlocked.Increment method that is used in thread synchronization. It increases an identity value but blocks other requests while doing it, and returns the incremented value. So even if two WEB servers incremented same key in exact same moment, they end up with different ID values.
