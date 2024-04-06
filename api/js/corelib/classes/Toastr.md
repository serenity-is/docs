[@serenity-is/corelib](../README.md) / Toastr

# Class: Toastr

## Table of contents

### Constructors

- [constructor](Toastr.md#constructor)

### Properties

- [options](Toastr.md#options)

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

[src/base/toastr2.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L87)

## Properties

### options

• **options**: [`ToastrOptions`](../README.md#toastroptions)

#### Defined in

[src/base/toastr2.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L85)

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

[src/base/toastr2.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L194)

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

[src/base/toastr2.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L111)

___

### getContainer

▸ **getContainer**(`options?`, `create?`): `HTMLElement`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `options?` | [`ToastContainerOptions`](../README.md#toastcontaineroptions) | `undefined` |
| `create` | `boolean` | `false` |

#### Returns

`HTMLElement`

#### Defined in

[src/base/toastr2.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L91)

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

[src/base/toastr2.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L150)

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

[src/base/toastr2.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L167)

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

[src/base/toastr2.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L183)

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

[src/base/toastr2.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L163)

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

[src/base/toastr2.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L137)

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

[src/base/toastr2.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L124)
