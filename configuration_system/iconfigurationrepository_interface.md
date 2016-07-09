# IConfigurationRepository 接口

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

所有应用程序都有一些类型的配置。作用域（scope）、 存储介质和格式化器的设置在不同应用程序间都是不相同的，因此，Serenity 提供 IConfigurationRepository 接口对此配置进行访问。

```cs
public interface IConfigurationRepository
{
    object Load(Type settingType);
    void Save(Type settingType, object value);
}
```

## IConfigurationRepository.Load 方法

此方法返回一个设置类型（settingType）实例。提供者会检查 SettingKey 特性来决定设置类型的键（key）。

如果一些提供者被注册了多个作用域（scopes），提供者还应检查 SettingScope 特性。 

即使没有找到设置（设置类型的默认构造函数会创建一个对象），提供者应返回一个对象实例。

## IConfigurationRepository.Save 方法 

保存设置类型（settingType）实例。提供者会检查 SettingKey 特性来决定设置类型的键（key）。

如果一些提供者被注册了多个作用域（scopes），提供者还应检查 SettingScope 特性。

当你不想设置被改变时，此方法的实现是可选的。在这种情况下，只需抛出 *NotImplementedException* 异常。


