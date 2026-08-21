[@serenity-is/corelib](../README.md) / TranslateTextsResult

# Type Alias: TranslateTextsResult

> **TranslateTextsResult** = `object`

Defined in: [src/base/localtext.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L174)

Result returned by [TranslationConfig.translateTexts](../variables/TranslationConfig.md#translatetexts) containing translated entries.

## Properties

### Translations?

> `optional` **Translations**: `object`[]

Defined in: [src/base/localtext.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L176)

An array of resulting translations

#### TargetLanguageID?

> `optional` **TargetLanguageID**: `string`

The target language ID

#### TextKey?

> `optional` **TextKey**: `string`

The text key that was translated

#### TranslatedText?

> `optional` **TranslatedText**: `string`

The translated text
