[@serenity-is/corelib](../README.md) / text

# ~~Variable: text()~~

> `const` **text**: (`key`, `defaultText?`) => `string` = `localText`

Defined in: [src/base/localtext.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L183)

Retrieves a localized string from the localization table.

## Parameters

### key

`string`

The key of the localized string.

### defaultText?

`string`

The default text to return if the key is not found.

## Returns

`string`

The localized string or the default text.

## Deprecated

prefer localText for better discoverability
