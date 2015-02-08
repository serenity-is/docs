# LocalText Class

[**namespace**: *Serenity*, **assembly**: *Serenity.Core*]

At the core of string localization is LocalText class.

```cs
    public class LocalText
    {

        public LocalText(string key);
        public string Key { get; }
        public override string ToString();
        public static implicit operator string(LocalText localText);
        public static implicit operator LocalText(string key);
        public static string Get(string key);
        public static string TryGet(string key);

        public const string InvariantLanguageID = "";
        public static readonly LocalText Empty;
    }
```

Its constructor takes a key parameter, which defines the local text key that it will contain. Some of sample keys are:

- Enums.Month.January
- Enums.Month.December
- Db.Northwind.Customer.CustomerName
- Dialogs.YesButton

> Though it is not a rule, it is a good idea to follow this namespace like *dot* convention for local text keys.

At runtime, through ToString() function, the local text key is translated to its representation in the active language (which is *CultureInfo.CurrentUICulture*).

```cs
var text = new LocalText("Dialogs.YesButton");
Console.WriteLine(text.ToString());
```

```
> Yes
```

If a translation is not found in local text table (we will talk about this later), the key itself is returned.

```cs
var text = new LocalText("Unknown.Local.Text.Key");
Console.WriteLine(text.ToString());
```

```
> Unknown.Local.Text.Key
```

> This is by design, so that developer can determine which translations are missing.


## LocalText.Key Property

Gets the local text key that LocalText instance contains.

## Implicit Conversions From String

LocalText has implicit conversion from String type.

```cs
LocalText someText = "Dialogs.YesButton";
```

Here *someText* variable references a new LocalText instance with the key *Dialogs.YesButton*. So it is just a shortcut to LocalText constructor.

## Implicit Conversions To String

LocalText has implicit conversion to String type too, but it returns translation instead of the key (just like calling *ToString()* method):

```cs
var lt = new LocalText("Dialogs.NoButton");
string text = lt;
Console.WriteLine(text);
```

```
> No
```

## LocalText.Get Static Method

To access the translation for a local text key without creating a LocalText instance, use Get method:

```cs
Console.WriteLine(LocalText.Get("Dialogs.YesButton"));
```

```
> Yes
```

> *ToString()* method internally calls Get

## LocalText.TryGet Static Method

Unlike Get method which returns the local text key if no translation is found, TryGet returns null. Thus, coalesce operator can be used along with TryGet where required:

```cs
var translation = LocalText.TryGet("Looking.For.This.Key") ?? "Default Text";
Console.WriteLine(translation);
```

```
> Default Text
```

## LocalText.Empty Field

Similar to String.Empty, LocalText contains an empty local text object with empty key.


## LocalText.InvariantLanguageID Constant

This is just an empty string for invariant language ID which is the invariant culture language identifier (default language, usually English).

We will talk about language identifiers in the following section.
