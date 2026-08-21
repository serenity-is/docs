[@serenity-is/corelib](../README.md) / proxyTexts

# Function: proxyTexts()

> **proxyTexts**\<`T`\>(`obj`, `pfx`, `tpl`, `mode?`): `Record`\<`string`, `any`\> & `object`

Defined in: [src/base/localtext.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L140)

Creates a typed proxy that resolves nested property access to localized strings.
The proxy lazily wraps each level of `tpl`; property access concatenates `pfx` with the property name and performs the lookup according to `mode`.

## Type Parameters

### T

`T` *extends* `Record`\<`string`, `any`\> = `Record`\<`string`, `any`\>

## Parameters

### obj

`T`

Target object to proxy (usually `{}`). Mutated in place with hidden symbols and returned as a `Proxy`.

### pfx

`string`

Prefix prepended to every key lookup (e.g. `"Db.Northwind."`). Pass `""` for no prefix.

### tpl

`Record`\<`string`, `any`\>

Template object whose shape defines the available text keys; leaf values determine nesting. `null`/`undefined` leaves resolve to string lookups, objects create nested sub-proxies.

### mode?

Lookup strategy: `undefined` uses [localText](localText.md) (returns key on miss), `"asTry"` uses [tryGetText](tryGetText.md) (returns `undefined` on miss), `"asKey"` returns the generated key without any lookup.

`"asTry"` | `"asKey"`

## Returns

`Record`\<`string`, `any`\> & `object`

A proxy over `obj` augmented with `asTry()` and `asKey()` mode-switchers. Access a leaf string like `proxy.foo.bar` to get the localized text for `"<pfx>foo.bar"`.

## Example

```ts
const texts = proxyTexts({}, "", { user: { name: {} } });
texts.user.name.first // localText("user.name.first")
texts.user.asTry().name.first // tryGetText("user.name.first")
texts.user.asKey().name.first // "user.name.first"
```
