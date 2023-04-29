[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / Toastr

# Class: Toastr

[corelib/q](../modules/corelib_q.md).Toastr

## Table of contents

### Constructors

- [constructor](corelib_q.Toastr.md#constructor)

### Properties

- [listener](corelib_q.Toastr.md#listener)
- [options](corelib_q.Toastr.md#options)
- [previousToast](corelib_q.Toastr.md#previoustoast)
- [toastId](corelib_q.Toastr.md#toastid)

### Methods

- [clear](corelib_q.Toastr.md#clear)
- [clearContainer](corelib_q.Toastr.md#clearcontainer)
- [clearToast](corelib_q.Toastr.md#cleartoast)
- [createContainer](corelib_q.Toastr.md#createcontainer)
- [error](corelib_q.Toastr.md#error)
- [getContainer](corelib_q.Toastr.md#getcontainer)
- [info](corelib_q.Toastr.md#info)
- [notify](corelib_q.Toastr.md#notify)
- [publish](corelib_q.Toastr.md#publish)
- [remove](corelib_q.Toastr.md#remove)
- [removeToast](corelib_q.Toastr.md#removetoast)
- [subscribe](corelib_q.Toastr.md#subscribe)
- [success](corelib_q.Toastr.md#success)
- [warning](corelib_q.Toastr.md#warning)

## Constructors

### constructor

• **new Toastr**(`options?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | [`ToastrOptions`](../modules/corelib_q.md#toastroptions) |

#### Defined in

[src/q/toastr2.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;88)

## Properties

### listener

• `Private` **listener**: `any`

#### Defined in

[src/q/toastr2.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;80)

___

### options

• **options**: [`ToastrOptions`](../modules/corelib_q.md#toastroptions)

#### Defined in

[src/q/toastr2.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;86)

___

### previousToast

• `Private` **previousToast**: `string` = `null`

#### Defined in

[src/q/toastr2.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;84)

___

### toastId

• `Private` **toastId**: `number` = `0`

#### Defined in

[src/q/toastr2.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;82)

## Methods

### clear

▸ **clear**(`toastElement?`, `clearOptions?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toastElement?` | `HTMLElement` |
| `clearOptions` | `Object` |
| `clearOptions.force?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/q/toastr2.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;185)

___

### clearContainer

▸ `Private` **clearContainer**(`options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | `Partial`<[`ToastrOptions`](../modules/corelib_q.md#toastroptions)\> |

#### Returns

`void`

#### Defined in

[src/q/toastr2.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;235)

___

### clearToast

▸ `Private` **clearToast**(`toastElement?`, `options?`, `clearOptions?`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toastElement?` | `HTMLElement` |
| `options?` | [`ToastContainerOptions`](../modules/corelib_q.md#toastcontaineroptions) |
| `clearOptions` | `Object` |
| `clearOptions.force?` | `boolean` |

#### Returns

`boolean`

#### Defined in

[src/q/toastr2.ts:247](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;247)

___

### createContainer

▸ `Private` **createContainer**(`options?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ToastContainerOptions`](../modules/corelib_q.md#toastcontaineroptions) |

#### Returns

`HTMLElement`

#### Defined in

[src/q/toastr2.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;93)

___

### error

▸ **error**(`message?`, `title?`, `opt?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message?` | `string` |
| `title?` | `string` |
| `opt?` | [`ToastrOptions`](../modules/corelib_q.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[src/q/toastr2.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;121)

___

### getContainer

▸ **getContainer**(`options?`, `create?`): `HTMLElement`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `options?` | [`ToastContainerOptions`](../modules/corelib_q.md#toastcontaineroptions) | `undefined` |
| `create` | `boolean` | `false` |

#### Returns

`HTMLElement`

#### Defined in

[src/q/toastr2.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;109)

___

### info

▸ **info**(`message?`, `title?`, `opt?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message?` | `string` |
| `title?` | `string` |
| `opt?` | [`ToastrOptions`](../modules/corelib_q.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[src/q/toastr2.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;160)

___

### notify

▸ `Private` **notify**(`map`, `opt`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `map` | [`NotifyMap`](../modules/corelib_q.md#notifymap) |
| `opt` | [`ToastrOptions`](../modules/corelib_q.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[src/q/toastr2.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;266)

___

### publish

▸ **publish**(`args`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`Toastr`](corelib_q.Toastr.md) |

#### Returns

`void`

#### Defined in

[src/q/toastr2.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;177)

___

### remove

▸ **remove**(`toastElement?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toastElement?` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[src/q/toastr2.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;191)

___

### removeToast

▸ **removeToast**(`toastElement`, `options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toastElement` | `HTMLElement` |
| `options` | [`ToastrOptions`](../modules/corelib_q.md#toastroptions) |

#### Returns

`void`

#### Defined in

[src/q/toastr2.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;211)

___

### subscribe

▸ **subscribe**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`Toastr`](corelib_q.Toastr.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/q/toastr2.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;173)

___

### success

▸ **success**(`message?`, `title?`, `opt?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message?` | `string` |
| `title?` | `string` |
| `opt?` | [`ToastrOptions`](../modules/corelib_q.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[src/q/toastr2.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;147)

___

### warning

▸ **warning**(`message?`, `title?`, `opt?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message?` | `string` |
| `title?` | `string` |
| `opt?` | [`ToastrOptions`](../modules/corelib_q.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[src/q/toastr2.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#line&#x3D;134)
