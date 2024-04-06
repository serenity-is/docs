[@serenity-is/corelib](../README.md) / LT

# Namespace: LT

## Table of contents

### Functions

- [add](LT.md#add)
- [getDefault](LT.md#getdefault)

## Functions

### add

▸ **add**(`obj`, `pre?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `obj` | `string` \| `Record`\<`string`, `string` \| `Record`\<`string`, `any`\>\> |
| `pre?` | `string` |

#### Returns

`void`

**`Deprecated`**

Use addLocalText

#### Defined in

[src/q/localtext-compat.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext-compat.ts#L47)

___

### getDefault

▸ **getDefault**(`key`, `defaultText?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `defaultText?` | `string` |

#### Returns

`string`

**`Deprecated`**

Use localText

#### Defined in

[src/q/localtext-compat.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/localtext-compat.ts#L49)
