# AppSettingsJsonConfigRepository

[**namespace**: *Serenity.Configuration*, **assembly**: *Serenity.Data*]

Most web applications store configuration settings in web.config file, under appSettings section.

Serenity provides a default implementation of IConfigurationRepository that uses appSettings as configuration store.

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

To register this provider manually:

```cs
var registrar = Dependency.Resolve<IDependencyRegistrar>();
RegisterInstance<IConfigurationRepository>("Application",
    new AppSettingsJsonConfigRepository())
```

> When you call *Serenity.Web.CommonInitialization.Run()*, it registers this class as the default provider for IConfigurationRepository (in *Application* scope), if another one is not already registered.


This provider expects settings to be defined in web.config / app.config file in JSON format:

```xml
  <appSettings>
    <add key="Logging" value="{  File: '~\\App_Data\\Log\\App_{0}_{1}.log',
        FlushTimeout: 0,  Level: 'Debug' }" />
  </appSettings>
```

Out of the box, Serenity contains this configuration provider only. You may take it as a sample, and write another one for your setup (load from database etc.).

It is a good idea to cache returned objects in your implementation to avoid deserialization costs every time settings are read.

