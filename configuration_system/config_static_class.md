# 静态 Config 类

[**命名空间**: *Serenity*, **程序集**: *Serenity.Core*]

这是访问配置设置的主要位置。它包含注册 IConfigurationRepository 提供者的快捷方法。

```cs
public static class Config
{
    public static object Get(Type settingType);
    public static TSettings Get<TSettings>() where TSettings: class, new();
    public static object TryGet(Type settingType);
    public static TSettings TryGet<TSettings>() where TSettings : class, new();
}
```

## Config.Get 方法 Config.Get Method

用于读取指定类型的配置设置。

如果没有为设置类型的作用域注册提供者，将抛出 KeyNotFoundException 异常。

如果没有找到设置，提供者通常返回一个默认实例。

我更喜欢使用泛型重载，因为可以避免强制转换返回对象。

```cs
if (Config.Get<LogSettings>().LoggingLevel != LogginLevel.Off)
{
    // ..
}
```

## Config.TryGet 方法

用于读取指定类型的配置设置。

在功能上等效于 Get，但是如果没有为设置作用域注册配置提供者，Get 将引发异常，TryGet 则返回 *null*。

```cs
if ((Config.TryGet<LogSettings>() ?? new LogSettings()).LoggingLevel != LogginLevel.Off)
{
    // ..
}
```

我更喜欢使用该方法，而不是 Get，因为当配置系统还没有被初始化时，该方法可以避免异常。

> 从安全角度看，更推荐使用 Get 方法。
