[@serenity-is/corelib](../README.md) / textColor

# Function: textColor()

> **textColor**(`color`): `string`

Defined in: [src/base/icons.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L37)

Returns the text utility class for a [TextColor](../type-aliases/TextColor.md).

## Parameters

### color

[`TextColor`](../type-aliases/TextColor.md)

Text color token.

## Returns

`string`

CSS class name such as `"text-primary"` or `"text-teal"`.

## Example

```ts
textColor("warning"); // "text-warning"
```
