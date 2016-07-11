# 语言标识符

LanguageID 是指定字母和数字的组合作为语言标识符或分类的代码。

LanguageID 遵循 RFC 1766 标准格式： `<languagecode2>-<country/regioncode2>`，其中 *languagecode2* 是来自 ISO 639-1 的两个小写字母代码，而 *country/regioncode2* 是来自 ISO 3166 的两个大写字母代码。 

这是一些 LanguageID 示例：

- `en` : 英语 English
- `en-US` : 美式英语（US 是 ISO 3166-1 国家代码） 
- `en-GB` : 英式英语（GB 是 ISO 3166-1 国家代码）
- `es` : 西班牙语 
- `es-AR` : 阿根廷式西班牙语 

## 固定语言（Invariant Language）

类似于 *CultureInfo.InvariantCulture*，固定语言是空标识符的默认语言。

除非另有指定，否则在程序集嵌入的文本被认为写在固定语言。

虽然通常固定语言认为是英语，但可以使用你的母语作为固定语言。
