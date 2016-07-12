# ILocalCache 接口

[**命名空间**: *Serenity.Abstrations*] - [**程序集**: *Serenity.Core*]

定义一个基本的本地缓存接口。

```cs
public interface ILocalCache
{
    void Add(string key, object value, TimeSpan expiration);
    TItem Get<TItem>(string key);
    object Remove(string key);
    void RemoveAll();
}
```

> 使用 `Serenity.Web` 程序集中的 `System.Web.Cache` 默认实现  ILocalCache (`Serenity.Caching.HttpRuntimeCache`)。

### ILocalCache.Add 方法 

添加指定键的值到缓存。如果在缓存中存在该值，则更新该值。

项目保存在缓存中直至`到期(expiration)`期限。你可以指定项目的 `TimeSpan.Zero` 为不自动过期。

添加到缓存的值使用绝对过期时间（因此它们在特定时间过期，不会逾期）。

```cs
Dependency.Resolve<ILocalCache>.Add("someKey", "someValue", TimeSpan.FromMinutes(5));
```

此方法默认使用 HttpRuntime.Cache.Insert 方法实现。
> 避免使用 HttpRuntime.Cache.Add 方法，因为它不会更新缓存中相同键的值，甚至不会抛出错误，因此使用该方法你不会得到任何通知。

### ILocalCache.Get`<TItem>` 方法 

获取本地缓存中指定键的值。

如果缓存中没有该键，只有在值类型是 TItem 时才抛出错误。若 TItem 是引用类型，返回的值为 `null`。

如果值的类型不是 `TItem`，则抛出一个异常。 

你可以使用 `object` 作为 `TItem` 参数阻止不存在值或不是请求类型情况下的错误。

### ILocalCache.Remove 方法 

删除本地缓存中指定键的项目，并返回其值。

如果缓存中没有指定键的值，不会抛出错误，而是返回 `null`。

```cs
Dependency.Resolve<ILocalCache>.Remove("someKey");
```

### ILocalCache.RemoveAll 方法 

删除本地缓存中所有的项目。除了单元测试这种特殊情况，避免使用该方法，否则会影响性能。
