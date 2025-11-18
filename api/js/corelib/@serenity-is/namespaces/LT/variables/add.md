[@serenity-is/corelib](../../../../README.md) / [LT](../README.md) / add

# ~~Variable: add()~~

> `const` **add**: (`obj`, `pre?`) => `void` = `addLocalText`

Defined in: [src/base/localtext.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L187)

Adds local text entries to the localization table.

## Parameters

### obj

The object containing key/value pairs to add. If a string is provided, it will be added as a key with the prefix (second argument) as its value.

`string` | `Record`\<`string`, `string` \| `Record`\<`string`, `any`\>\>

### pre?

`string`

The prefix to add to each key. If obj is a string, this will be the value for that key.

## Returns

`void`

## Deprecated

Use addLocalText
