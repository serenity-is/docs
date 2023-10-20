[@serenity-is](../README.md) / [Modules](../modules.md) / [q](q.md) / ScriptData

# Namespace: ScriptData

[q](q.md).ScriptData

## Table of contents

### Functions

- [bindToChange](q.ScriptData.md#bindtochange)
- [canLoad](q.ScriptData.md#canload)
- [ensure](q.ScriptData.md#ensure)
- [ensureAsync](q.ScriptData.md#ensureasync)
- [reload](q.ScriptData.md#reload)
- [reloadAsync](q.ScriptData.md#reloadasync)
- [set](q.ScriptData.md#set)
- [setRegisteredScripts](q.ScriptData.md#setregisteredscripts)
- [triggerChange](q.ScriptData.md#triggerchange)
- [unbindFromChange](q.ScriptData.md#unbindfromchange)

## Functions

### bindToChange

▸ **bindToChange**(`name`, `regClass`, `onChange`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `regClass` | `string` |
| `onChange` | () => `void` |

#### Returns

`void`

#### Defined in

[src/q/scriptdata.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L50)

___

### canLoad

▸ **canLoad**(`name`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`boolean`

#### Defined in

[src/q/scriptdata.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L200)

___

### ensure

▸ **ensure**<`TData`\>(`name`): `TData`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`TData`

#### Defined in

[src/q/scriptdata.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L162)

___

### ensureAsync

▸ **ensureAsync**<`TData`\>(`name`): `Promise`<`TData`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`Promise`<`TData`\>

#### Defined in

[src/q/scriptdata.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L176)

___

### reload

▸ **reload**<`TData`\>(`name`): `TData`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`TData`

#### Defined in

[src/q/scriptdata.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L187)

___

### reloadAsync

▸ **reloadAsync**<`TData`\>(`name`): `Promise`<`TData`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TData` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`Promise`<`TData`\>

#### Defined in

[src/q/scriptdata.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L194)

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

[src/q/scriptdata.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L211)

___

### setRegisteredScripts

▸ **setRegisteredScripts**(`scripts`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `scripts` | `any`[] |

#### Returns

`void`

#### Defined in

[src/q/scriptdata.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L204)

___

### triggerChange

▸ **triggerChange**(`name`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

`void`

#### Defined in

[src/q/scriptdata.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L58)

___

### unbindFromChange

▸ **unbindFromChange**(`regClass`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `regClass` | `string` |

#### Returns

`void`

#### Defined in

[src/q/scriptdata.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#L62)
