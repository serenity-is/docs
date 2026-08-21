[@serenity-is/corelib](../README.md) / fabIcon

# Function: fabIcon()

> **fabIcon**(`key`, `color?`): `string`

Defined in: [src/base/icons.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L66)

Builds the CSS class string for a Font Awesome Brands icon.

## Parameters

### key

[`fabIconKey`](../type-aliases/fabIconKey.md)

Brand icon key from [fabIconKey](../type-aliases/fabIconKey.md) (without the `fa-` prefix).

### color?

[`TextColor`](../type-aliases/TextColor.md)

Optional [TextColor](../type-aliases/TextColor.md) appended as a `text-*` class.

## Returns

`string`

Class string such as `"fab fa-github"` or `"fab fa-github text-muted"`.

## Example

```ts
fabIcon("github"); // "fab fa-github"
```
