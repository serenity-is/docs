# Defining Configuration Settings

In Serenity platform, configuration settings are just simple classes like:

```cs
[SettingScope("Application"), SettingKey("Logging")]
private class LogSettings
{
    public LoggingLevel Level { get; set; }
    public string File { get; set; }
    public int FlushTimeout { get; set; }
}
```

> If required, default settings can be set in the class constructor.

## SettingScope Attribute

If specified, this attribute determines the scope of settings.

If not specified, default scope is *Application*.

## SettingKey Attribute

If specified, this attribute determines a key for settings (e.g. appSettings key for web.config) class.

If not specified, class name is used as the key.
