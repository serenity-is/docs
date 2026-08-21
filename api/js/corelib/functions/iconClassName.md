[@serenity-is/corelib](../README.md) / iconClassName

# Function: iconClassName()

> **iconClassName**(`icon`): `string`

Defined in: [src/base/icons.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L98)

Normalizes an [IconClassName](../type-aliases/IconClassName.md) to a single space-joined class string, adding a missing `fa` prefix.

## Parameters

### icon

[`IconClassName`](../type-aliases/IconClassName.md)

Single icon class or array of classes. Falsy/empty values are returned as-is.

## Returns

`string`

Normalized CSS class string suitable for an `<i>` element.

## Remarks

If `icon` starts with `fa-` but lacks an explicit `fa` token, `"fa "` is prepended.

## Example

```ts
iconClassName("fa-home"); // "fa fa-home"
iconClassName(["fa fa-home", "text-primary"]); // "fa fa-home text-primary"
```
