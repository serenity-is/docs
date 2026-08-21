[@serenity-is/corelib](../README.md) / faIcon

# Function: faIcon()

> **faIcon**(`key`, `color?`): `string`

Defined in: [src/base/icons.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L52)

Builds the CSS class string for a Font Awesome (solid/regular) icon.

## Parameters

### key

[`faIconKey`](../type-aliases/faIconKey.md)

Icon key from [faIconKey](../type-aliases/faIconKey.md) (without the `fa-` prefix).

### color?

[`TextColor`](../type-aliases/TextColor.md)

Optional [TextColor](../type-aliases/TextColor.md) appended as a `text-*` class.

## Returns

`string`

Class string such as `"fa fa-home"` or `"fa fa-home text-danger"`.

## Example

```ts
faIcon("home"); // "fa fa-home"
faIcon("home", "primary"); // "fa fa-home text-primary"
```
