# IDistributedCache 接口

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

所有 NoSQL 服务器类型提供了一个类似的接口，像"使用该键存储此值"、"给我该键对应的值"等。

Serenity 通过一个没有依赖特定 NoSQL 数据库类型的通用接口提供分布式缓存的支持：

```cs
public interface IDistributedCache
{
    long Increment(string key, int amount = 1);
    TValue Get<TValue>(string key);
    void Set<TValue>(string key, TValue value);
    void Set<TValue>(string key, TValue value, TimeSpan expiration);
}
```


Set 方法的第一个重载使用参数 key 和 value 在分布式缓存中存储键/值对。

```cs
IoC.Resolve<IDistributedCache>().Set("someKey", "someValue");
```

然后我们可以通过 Get 方法读取该值：

```cs
var value = IoC.Resolve<IDistrubutedCache().Get<string>("someKey") // someValue
```

如果想要值保存预定的时间，可以使用 Get 方法的第二个重载：

```cs
IoC.Resolve<IDistributedCache>().Set("someKey", "someValue",
    TimeSpan.FromMinutes(10));
```

## IDistributedCache.Increment 方法

分布式缓存系统上的操作通常不是原子性的，并且没有提供任何事务性的系统。

相同的键值可以由多个服务器同时修改，并且按随机顺序重写各自的值。

假设我们需要一个独特的计数器（生成 ID） 并通过分布式缓存同步它（以防止使用相同的 ID）：

```cs
int GetTheNextIDValue()
{
    var lastID = IoC.Resolve<IDistributedCache>().Get("LastID");
    IoC.Resolve<IDistributedCache>().Set("LastID", lastID + 1);
    return lastID;
}
```

这个代码块不会像预期那样运行。在读取 `LastID` 值 (get) 和设置自增 LastID 值(set)的期间，另一台服务器可能读过相同的 LastID 值。因此两个服务器可能使用相同的 ID 值。

为了该目的，可以使用 Increment 方法：

```cs
int GetTheNextIDValue()
{
    return IoC.Resolve<IDistributedCache>().Increment("LastID");
}
```

 Increment 方法的行为就像在线程同步中使用的 Interlocked.Increment 方法。它增加标识值，但在增加的过程中会阻止其他请求，然后返回递增的值。所以即使两个 WEB 服务器在同一时刻递增相同的键，他们最终得到不同的 ID 值。
