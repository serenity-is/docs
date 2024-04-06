[@serenity-is/corelib](../README.md) / ScriptData

# Namespace: ScriptData

## Table of contents

### Functions

- [bindToChange](ScriptData.md#bindtochange)
- [canLoad](ScriptData.md#canload)
- [ensure](ScriptData.md#ensure)
- [reload](ScriptData.md#reload)
- [reloadAsync](ScriptData.md#reloadasync)
- [set](ScriptData.md#set)

## Functions

### bindToChange

▸ **bindToChange**(`name`, `onChange`): `void` \| () => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `onChange` | () => `void` |

#### Returns

`void` \| () => `void`

#### Defined in

[src/q/scriptdata-compat.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L9)

___

### canLoad

▸ **canLoad**(`name`): `boolean`

Check if a dynamic script with provided name is available in the cache
or it is a registered script name

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` | Dynamic script name |

#### Returns

`boolean`

True if already available or registered

#### Defined in

[src/q/scriptdata-compat.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L20)

___

### ensure

▸ **ensure**\<`TData`\>(`name`, `dynJS?`): `TData`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `dynJS?` | `boolean` |

#### Returns

`TData`

#### Defined in

[src/q/scriptdata-compat.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L22)

___

### reload

▸ **reload**\<`TData`\>(`name`, `dynJS?`): `TData`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `dynJS?` | `boolean` |

#### Returns

`TData`

#### Defined in

[src/q/scriptdata-compat.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L59)

___

### reloadAsync

▸ **reloadAsync**\<`TData`\>(`name`): `Promise`\<`TData`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`Promise`\<`TData`\>

#### Defined in

[src/q/scriptdata-compat.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L65)

___

### set

▸ **set**(`name`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/q/scriptdata-compat.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata-compat.ts#L69)
