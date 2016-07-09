# AppSettingsJsonConfigRepository

[**命名空间**: *Serenity.Configuration*, **程序集**: *Serenity.Data*]

大多数 Web 应用程序在 web.config 中的 appSettings 部分存储配置设置。 

Serenity 提供一个 IConfigurationRepository 接口的默认实现，可以使用 appSettings 作为配置存储。

```cs
public class AppSettingsJsonConfigRepository : IConfigurationRepository
{
    public void Save(Type settingType, object value)
    {
        throw new NotImplementedException();
    }

    public object Load(Type settingType)
    {
        return LocalCache.Get("ApplicationSetting:" + settingType.FullName,
            TimeSpan.Zero, delegate()
        {
            var keyAttr = settingType.GetCustomAttribute<SettingKeyAttribute>();
            var key = keyAttr == null ? settingType.Name : keyAttr.Value;
            return JSON.Parse(ConfigurationManager.AppSettings[key].TrimToNull() ??
                "{}", settingType);
        });
    }
}
```

要手动注册该提供者：

```cs
var registrar = Dependency.Resolve<IDependencyRegistrar>();
RegisterInstance<IConfigurationRepository>("Application",
    new AppSettingsJsonConfigRepository())
```

> 当调用 *Serenity.Web.CommonInitialization.Run()* 时，如果另一个尚未注册，它注册该类作为 IConfigurationRepository 的默认提供者(在 *Application* 作用域)。


该提供者希望在 web.config / app.config 文件以 JSON 格式定义设置：

```xml
  <appSettings>
    <add key="Logging" value="{  File: '~\\App_Data\\Log\\App_{0}_{1}.log',
        FlushTimeout: 0,  Level: 'Debug' }" />
  </appSettings>
```

Serenity 默认只包含此配置提供者。你可以它为例，编写另一个适合你的设置（从数据库加载）。

在实现中对返回对象进行缓存是一个好主意，以避免每次读取设置的反序列化成本。

