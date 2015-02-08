# Localization

Most web applications must support a variety of languages. Sites like Youtube, Wikipedia, Facebook works in many languages.

First time a user visits such a site, a language for her is automatically chosen depending on the browser language (pre-determined by regional settings).

If automatic selection is not what they expect, users can set their preferred language and this selection is stored in a client-side cookie (or server side user profile table).

Once a language is chosen, all texts are displayed in the selected language.

Serenity platform is designed with localization in mind from the start.

If you are using *Serenity Basic Application Sample* you can see this yourself by setting your browser language or changing a web.config setting:

```xml
<system.web>
    <globalization culture="en-US" uiCulture="auto:en-US" />
</system.web>
```

Here, UI culture is set to automatic, and if automatic detection fails, en-US is used as a fallback.

![Customer Screen English](https://raw.githubusercontent.com/volkanceylan/SerenityGuide/master/localization/img/localization_customer_english.png?v1)

Change this configuration as below, refresh your browser and you will the site in Turkish:

```xml
<system.web>
    <globalization culture="en-US" uiCulture="tr" />
</system.web>
```

![Customer Screen Turkish](https://raw.githubusercontent.com/volkanceylan/SerenityGuide/master/localization/img/localization_customer_turkish.png?v1)

> Here, data is not translated but it is also possible to translate user entered data by some methods like culture extension tables.
