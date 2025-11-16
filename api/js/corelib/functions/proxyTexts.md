[corelib](../README.md) / proxyTexts

# Function: proxyTexts()

> **proxyTexts**\<`T`\>(`obj`, `pfx`, `tpl`, `mode?`): `Record`\<`string`, `any`\> & `object`

Defined in: [src/base/localtext.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L127)

Creates a proxy object for localized text retrieval.

## Type Parameters

### T

`T` *extends* `Record`\<`string`, `any`\> = `Record`\<`string`, `any`\>

## Parameters

### obj

`T`

The target object to proxy (usually an empty object {})

### pfx

`string`

The key prefix for all text lookups

### tpl

`Record`\<`string`, `any`\>

Template object defining the structure (object properties become nested proxies)

### mode?

The lookup mode: by default it uses localText, e.g. returns the localized text or the text key if not found,
"asTry"=tryGetText, e.g. returns undefined if not found, "asKey"=return the text key ("Forms.Something.Abc") as is (no lookup)

`"asTry"` | `"asKey"`

## Returns

`Record`\<`string`, `any`\> & `object`

A proxy object that provides localized text access

## Example

```ts
const texts = proxyTexts({}, '', { user: { name: {} } });
texts.user.name.first // looks up "user.name.first" key, returns "user.name.first" if not found
texts.user.asTry().name.first // returns undefined if not found
texts.user.asKey().name.first // returns "user.name.first"
```
