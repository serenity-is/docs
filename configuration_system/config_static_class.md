# Config Static Class

[**namespace**: *Serenity*, **assembly**: *Serenity.Core*]

This is the central location to access your configuration settings. It contains shortcut methods to registered IConfigurationRepository provider.

```cs
public static class Config
{
    public static object Get(Type settingType);
    public static TSettings Get<TSettings>() where TSettings: class, new();
    public static object TryGet(Type settingType);
    public static TSettings TryGet<TSettings>() where TSettings : class, new();
}
```

## Config.Get Method

Used to read configuration settings for specified type.

If no provider is registered for setting type's scope, a *KeyNotFoundException* is raised.

If setting is not found, providers usually return a default instance.

Prefer generic overload to avoid having to cast the returned object.

```cs
if (Config.Get<LogSettings>().LoggingLevel != LogginLevel.Off)
{
    // ..
}
```

## Config.TryGet Method

Used to read configuration settings for specified type.

Functionally equivalent to Get, but while it throws an exception if no configuration provider is registered for the setting scope, TryGet returns *null*.

```cs
if ((Config.TryGet<LogSettings>() ?? new LogSettings()).LoggingLevel != LogginLevel.Off)
{
    // ..
}
```

Prefer this method over Get only to avoid exceptions when configuration system is not initialized yet.

> Get works on safe-side, and is the recommended method to use.
