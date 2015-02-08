# IConfigurationRepository Interface

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

All applications have some kind of configuration. Scope, storage medium and format for these settings are different from application to application, so Serenity provides IConfigurationRepository interface to abstract access to this configuration.

```cs
public interface IConfigurationRepository
{
    object Load(Type settingType);
    void Save(Type settingType, object value);
}
```

## IConfigurationRepository.Load Method

This method returns an instance of settingType. Provider should check SettingKey attribute to determine key for the setting type.

If same provider is registered for multiple scopes, provider should also check for SettingScope attribute.

Provider should return an object instance, even if setting is not found (an object created with settingType's default constructor).

## IConfigurationRepository.Save Method

Saves an instance of settingType. Provider should check SettingKey attribute to determine key for the setting type.

If same provider is registered for multiple scopes, provider should also check for SettingScope attribute.

This method is optional to implement, as you may not want settings to be changed. In this case, just throw a *NotImplementedException*.


