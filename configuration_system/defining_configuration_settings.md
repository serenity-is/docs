# 定义配置设置

在 Serenity 平台，配置设置是只是简单的类，如：

```cs
[SettingScope("Application"), SettingKey("Logging")]
private class LogSettings
{
    public LoggingLevel Level { get; set; }
    public string File { get; set; }
    public int FlushTimeout { get; set; }
}
```

> 如果需要，可以在类构造函数中设置默认设置。

## SettingScope 特性

如果有指定该特性，由该特性确定作用域的设置。

如果未指定该特性，默认作用域是 *应用程序（Application）*。

## SettingKey 特性

如果有指定该特性，此特性确定设置类的键（如 web.config 的 appSettings 键）。

如果未指定该特性，将使用类名作为键（key）。
