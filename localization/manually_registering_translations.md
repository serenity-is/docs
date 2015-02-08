# Manually Registering Translations

You can add translations to local text registry from your application start method.

Sources for these translations might be a database table, xml file, embedded resources etc.

```cs
void Application_Start()
{
    // ...
    var registry = Dependency.Resolve<ILocalTextRegistry>();
    registry.Add("es", "Dialogs.YesButton", "Sí");
    registry.Add("fr", "Dialogs.YesButton", "Oui");
    // ..
}
```


