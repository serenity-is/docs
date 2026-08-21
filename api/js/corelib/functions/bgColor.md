[@serenity-is/corelib](../README.md) / bgColor

# Function: bgColor()

> **bgColor**(`color`): `string`

Defined in: [src/base/icons.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L24)

Returns the Bootstrap background utility class for a [UtilityColor](../type-aliases/UtilityColor.md).

## Parameters

### color

[`UtilityColor`](../type-aliases/UtilityColor.md)

Utility color token (e.g. `"primary"`, `"danger"`).

## Returns

`string`

CSS class name such as `"bg-primary"`.

## Example

```ts
bgColor("success"); // "bg-success"
```
