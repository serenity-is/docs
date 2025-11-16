[serenity-is/corelib](../README.md) / TranslationConfig

# Variable: TranslationConfig

> `const` **TranslationConfig**: `object`

Defined in: [src/base/localtext.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L175)

Configuration for translation services.

## Type Declaration

### getLanguageList()

> **getLanguageList**: () => [`LanguageList`](../type-aliases/LanguageList.md)

Retrieves the list of available languages

#### Returns

[`LanguageList`](../type-aliases/LanguageList.md)

### translateTexts()

> **translateTexts**: (`opt`) => `PromiseLike`\<[`TranslateTextsResult`](../type-aliases/TranslateTextsResult.md)\>

A function to translate texts based on provided options

#### Parameters

##### opt

[`TranslateTextsOptions`](../type-aliases/TranslateTextsOptions.md)

#### Returns

`PromiseLike`\<[`TranslateTextsResult`](../type-aliases/TranslateTextsResult.md)\>
