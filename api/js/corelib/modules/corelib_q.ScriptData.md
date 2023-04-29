[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](corelib_q.md) / ScriptData

# Namespace: ScriptData

[corelib/q](corelib_q.md).ScriptData

## Table of contents

### Functions

- [bindToChange](corelib_q.ScriptData.md#bindtochange)
- [canLoad](corelib_q.ScriptData.md#canload)
- [ensure](corelib_q.ScriptData.md#ensure)
- [ensureAsync](corelib_q.ScriptData.md#ensureasync)
- [reload](corelib_q.ScriptData.md#reload)
- [reloadAsync](corelib_q.ScriptData.md#reloadasync)
- [set](corelib_q.ScriptData.md#set)
- [setRegisteredScripts](corelib_q.ScriptData.md#setregisteredscripts)
- [triggerChange](corelib_q.ScriptData.md#triggerchange)
- [unbindFromChange](corelib_q.ScriptData.md#unbindfromchange)

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

[src/q/scriptdata.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;50)

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

[src/q/scriptdata.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;189)

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

[src/q/scriptdata.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;151)

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

[src/q/scriptdata.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;165)

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

[src/q/scriptdata.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;176)

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

[src/q/scriptdata.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;183)

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

[src/q/scriptdata.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;200)

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

[src/q/scriptdata.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;193)

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

[src/q/scriptdata.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;58)

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

[src/q/scriptdata.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/scriptdata.ts#line&#x3D;62)
