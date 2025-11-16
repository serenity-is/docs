[corelib](../README.md) / addLocalText

# Function: addLocalText()

> **addLocalText**(`obj`, `pre?`): `void`

Defined in: [src/base/localtext.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L16)

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
