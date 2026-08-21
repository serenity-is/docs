[@serenity-is/corelib](../README.md) / TranslationConfig

# Variable: TranslationConfig

> `const` **TranslationConfig**: `object`

Defined in: [src/base/localtext.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L190)

Global configuration hooks for the optional translation service integration.
Assign these before invoking translation features in the UI.

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
