# JSON 本地化文本

Serenity 支持通过 JSON 文件注册包含键/值字典的本地化文本：

```json
{
  "Forms.Administration.User.DisplayName": "Display Name",
  "Forms.Administration.User.Email": "E-mail",
  "Forms.Administration.User.EntitySingular": "User",
  "Forms.Administration.User.EntityPlural": "Users"
}
```

要从某一文件夹中的 JSON 文件注册本地化文本键和翻译，可调用 *JsonLocalTextRegistration.AddFromFilesInFolder*: 

```cs
JsonLocalTextRegistration.AddFromFilesInFolder(@"C:\SomeFolder");
```

文件夹中的文件名称必须遵循如下约定：

`{Some Prefix You Choose}.{LanguageID}.json`

`{LanguageID}` 是两个或四个字母的语言代码。使用 *invariant* 作为固定语言的语言代码。

一些文件名称示例：

- `site.texts.en-US.json`
- `MyCoolTexts.es.json`
- `user.texts.invariant.json`

文件夹的文件被解析并按文件名称的顺序注册。因此，以上面的文件名称为例，注册顺序应为：

1. `MyCoolTexts.es.json`
2. `site.texts.en-US.json`
3. `user.texts.invariant.json`

> 因为添加具有相同健的翻译会覆盖先前的翻译，所以该顺序是很重要的。

## CommonInitialization 和 Predetermined 文件夹

*CommonInitialization.Run* 和 *CommonInitialization.InitializeLocalTexts* 方法将在 web 站点下的三个预定位置获得翻译文本：

1. `~/Scripts/serenity/texts` (serenity 翻译)
2. `~/Scripts/site/texts` (应用程序特定翻译)
3. `~/App_Data/texts` (用户通过翻译窗体的翻译)

开发者自己的翻译文件请放在第二个路径下，因为第一个路径下的文件是 Serenity 资源。

第三个路径包含用户的翻译文本。在发布之前，建议把这些文本转移到应用程序 ~/Scripts/site/texts 下的翻译文件。


