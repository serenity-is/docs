[@serenity-is/corelib](../../../../README.md) / [LT](../README.md) / getDefault

# ~~Variable: getDefault()~~

> `const` **getDefault**: (`key`, `defaultText?`) => `string` = `localText`

Defined in: [src/base/localtext.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L217)

Alias for [localText](../../../../functions/localText.md).

Retrieves a localized string for a key, falling back gracefully.

## Parameters

### key

`string`

Localization key to look up (e.g. `"Dialogs.YesButton"`). If falsy, an empty string or `defaultText` is returned.

### defaultText?

`string`

Optional fallback returned when the key is not found. When omitted, the key itself is returned.

## Returns

`string`

The localized value, `defaultText` if provided, the key itself, or `""` for nullish keys.

## Example

```ts
localText("Dialogs.YesButton"); // "Yes" if registered, otherwise "Dialogs.YesButton"
localText("Missing.Key", "Fallback"); // "Fallback"
```

## Deprecated

Use [localText](../../../../functions/localText.md) directly.
