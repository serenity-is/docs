# 静态 LocalCache 类 

[**命名空间**: *Serenity*] - [**程序集**: *Serenity.Core*]

一个包含快捷访问注册 ILocalCache 提供者的静态类。

```cs
public static class LocalCache
{
    public static void Add(string key, object value, TimeSpan expiration);
    public static TItem Get<TItem>(string key, TimeSpan expiration,
        Func<TItem> loader) where TItem : class;
    public static void Remove(string key);
    public static void RemoveAll();
}
```

Add、 Remove 和 RemoveAll 方法是对应 ILocalCache 接口的快捷访问方法，但 Get 方法不同于 ILocalCache.Get。

## LocalCache.Get`<TItem>` 方法 

获取本地缓存指定键的值。

如果缓存中没有该键，使用加载（loader）函数产生值，并使用指定的键添加到缓存。

![LocalCache.Get Flow Diagram](img/local_cache_get_en.jpg)

* 如果缓存中的值是 DBNull.Value，返回 null（例如，使用这种方式，如果数据库中不存在该 ID 的用户，则阻止在数据库中重复查询该 ID）。

* 如果缓存中存在该值，但不是 TItem 类型，将抛出异常；否则返回该值。 

* 如果缓存中不存在该值，调用加载（loader）函数产生该值（如，从数据库加载）并……
	* 如果加载（loader）函数产生的值为 null，在缓存中存储为 DBNull.Value。  
	* 否则，对产生的值指定过期时间后添加到缓存。
