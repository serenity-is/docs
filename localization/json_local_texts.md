# JSON Local Texts

Serenity supports local text registration through JSON files containing a simple key/value dictionary:

```json
{
  "Forms.Administration.User.DisplayName": "Display Name",
  "Forms.Administration.User.Email": "E-mail",
  "Forms.Administration.User.EntitySingular": "User",
  "Forms.Administration.User.EntityPlural": "Users"
}
```

To register all local text keys and translations from JSON files in a folder , call *JsonLocalTextRegistration.AddFromFilesInFolder* with the path:

```cs
JsonLocalTextRegistration.AddFromFilesInFolder(@"C:\SomeFolder");
```

File names in the folder must follow a convention:

`{Some Prefix You Choose}.{LanguageID}.json`

where `{LanguageID}` is two or four letter language code. Use *invariant* as language code for invariant language.

Some sample file names are:

- `site.texts.en-US.json`
- `MyCoolTexts.es.json`
- `user.texts.invariant.json`

Files in a folder are parsed and added to registry in their file name order. Thus for sample file names above, order would be:

1. `MyCoolTexts.es.json`
2. `site.texts.en-US.json`
3. `user.texts.invariant.json`

> This order is important as adding a translation in some language with same key overrides prior translation.

## CommonInitialization and Predetermined Folders

*CommonInitialization.Run* and *CommonInitialization.InitializeLocalTexts* calls this method for three predetermined locations under your web site:

- `~/Scripts/serenity/texts` (serenity translations)
- `~/Scripts/site/texts` (your application specific translations)
- `~/App_Data/texts` (user translations made through translation interface)

Prefer using second one for your own files as first one is for Serenity resources.

Third one contains user translated texts. It is recommended to transfer texts from these files to application translation files under `~/Scripts/site/texts` before publishing.


