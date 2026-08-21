[@serenity-is/corelib](../README.md) / tryGetText

# Function: tryGetText()

> **tryGetText**(`key`): `string`

Defined in: [src/base/localtext.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L67)

Tries to retrieve a localized string without falling back to the key.

## Parameters

### key

`string`

Localization key to look up.

## Returns

`string`

The localized value if found, otherwise `undefined` (unlike [localText](localText.md) which returns the key).
