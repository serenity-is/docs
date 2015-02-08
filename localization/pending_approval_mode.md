# Pending Approval Mode

LocalTextRegistry also supports an optional pending approval mode.

In some sites, translations might be needed to be approved by some moderators before they are published.

So you may add these unapproved texts to your local text registry but want them to be shown only to moderators for them to check how they will look in live site when approved.

LocalTextRegistry allows you to mark some texts as pending approval, and use these translations for only approval contexts (e.g. when a moderator is logged in).

## ILocalTextContext Interface

[**namespace**: *Serenity.Localization*, **assembly**: *Serenity.Core*]

```cs
public interface ILocalTextContext
{
    bool IsApprovalMode { get; }
}
```

Implement this interface and register it through the service locator (Dependency class).

IsApprovalMode property is used to determine if current context is in approval mode (e.g. used by a moderator).

```cs
public class MyLocalTextContext : ILocalTextContext
{
    public bool IsApprovalMode
    {
        get
        {
            // use some method to determine if current user is a moderator
            return Authorization.HasPermission("Moderation");
        }
    }
}

void ApplicationStart()
{
    Dependency.Resolve<IDependencyRegistrar>()
        .RegisterInstance<ILocalTextContext>(new MyLocalTextContext());
}
```

## LocalTextRegistry.AddPending Method

Adds a translation to local text table for pending approval texts. These texts are only used when current context is in pending approval mode.

## LocalTextRegistry.TryGet Overload With Language and Pending Arguments

```cs
public string TryGet(string languageID, string textKey, bool isApprovalMode);
```

This overload lets you to get a translation in specified language and optionally using unapproved texts (isApprovalMode = true).

Other TryGet overload returns unapproved texts only when ILocalTextContext provider returns true for IsApprovalMode property.

## LocalTextRegistry.GetAllAvailableTextsInLanguage Method

Returns a dictionary of all currently registered translations for all text keys in a language.

Dictionary keys are local text keys, while values are translations.

It also contains texts found from language fallbacks for if a translation is not available in requested language.

