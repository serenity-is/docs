[@serenity-is/corelib](../README.md) / Toastr

# Class: Toastr

## Table of contents

### Constructors

- [constructor](Toastr.md#constructor)

### Properties

- [listener](Toastr.md#listener)
- [notify](Toastr.md#notify)
- [options](Toastr.md#options)
- [previousToast](Toastr.md#previoustoast)
- [removeContainerIfEmpty](Toastr.md#removecontainerifempty)
- [toastId](Toastr.md#toastid)

### Methods

- [clear](Toastr.md#clear)
- [error](Toastr.md#error)
- [getContainer](Toastr.md#getcontainer)
- [info](Toastr.md#info)
- [publish](Toastr.md#publish)
- [removeToast](Toastr.md#removetoast)
- [subscribe](Toastr.md#subscribe)
- [success](Toastr.md#success)
- [warning](Toastr.md#warning)

## Constructors

### constructor

• **new Toastr**(`options?`): [`Toastr`](Toastr.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | [`ToastrOptions`](../README.md#toastroptions) |

#### Returns

[`Toastr`](Toastr.md)

#### Defined in

[../base/dist/index.d.ts:1348](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1348)

## Properties

### listener

• `Private` **listener**: `any`

#### Defined in

[../base/dist/index.d.ts:1344](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1344)

___

### notify

• `Private` **notify**: `any`

#### Defined in

[../base/dist/index.d.ts:1359](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1359)

___

### options

• **options**: [`ToastrOptions`](../README.md#toastroptions)

#### Defined in

[../base/dist/index.d.ts:1347](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1347)

___

### previousToast

• `Private` **previousToast**: `any`

#### Defined in

[../base/dist/index.d.ts:1346](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1346)

___

### removeContainerIfEmpty

• `Private` **removeContainerIfEmpty**: `any`

#### Defined in

[../base/dist/index.d.ts:1356](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1356)

___

### toastId

• `Private` **toastId**: `any`

#### Defined in

[../base/dist/index.d.ts:1345](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1345)

## Methods

### clear

▸ **clear**(`options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | [`ToastContainerOptions`](../README.md#toastcontaineroptions) |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1358](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1358)

___

### error

▸ **error**(`message?`, `title?`, `opt?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message?` | `string` |
| `title?` | `string` |
| `opt?` | [`ToastrOptions`](../README.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:1350](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1350)

___

### getContainer

▸ **getContainer**(`options?`, `create?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | [`ToastContainerOptions`](../README.md#toastcontaineroptions) |
| `create?` | `boolean` |

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:1349](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1349)

___

### info

▸ **info**(`message?`, `title?`, `opt?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message?` | `string` |
| `title?` | `string` |
| `opt?` | [`ToastrOptions`](../README.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:1353](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1353)

___

### publish

▸ **publish**(`args`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`Toastr`](Toastr.md) |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1355](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1355)

___

### removeToast

▸ **removeToast**(`toastElement`, `options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toastElement` | `HTMLElement` |
| `options?` | [`ToastContainerOptions`](../README.md#toastcontaineroptions) |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1357](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1357)

___

### subscribe

▸ **subscribe**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`Toastr`](Toastr.md)) => `void` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1354](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1354)

___

### success

▸ **success**(`message?`, `title?`, `opt?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message?` | `string` |
| `title?` | `string` |
| `opt?` | [`ToastrOptions`](../README.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:1352](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1352)

___

### warning

▸ **warning**(`message?`, `title?`, `opt?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message?` | `string` |
| `title?` | `string` |
| `opt?` | [`ToastrOptions`](../README.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:1351](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1351)
