[@serenity-is/corelib](../README.md) / Toastr

# Class: Toastr

## Table of contents

### Constructors

- [constructor](Toastr.md#constructor)

### Properties

- [listener](Toastr.md#listener)
- [options](Toastr.md#options)
- [previousToast](Toastr.md#previoustoast)
- [toastId](Toastr.md#toastid)

### Methods

- [clear](Toastr.md#clear)
- [clearContainer](Toastr.md#clearcontainer)
- [clearToast](Toastr.md#cleartoast)
- [createContainer](Toastr.md#createcontainer)
- [error](Toastr.md#error)
- [getContainer](Toastr.md#getcontainer)
- [info](Toastr.md#info)
- [notify](Toastr.md#notify)
- [publish](Toastr.md#publish)
- [remove](Toastr.md#remove)
- [removeToast](Toastr.md#removetoast)
- [subscribe](Toastr.md#subscribe)
- [success](Toastr.md#success)
- [warning](Toastr.md#warning)

## Constructors

### constructor

• **new Toastr**(`options?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | [`ToastrOptions`](../README.md#toastroptions) |

#### Defined in

[src/q/toastr2.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L88)

## Properties

### listener

• `Private` **listener**: `any`

#### Defined in

[src/q/toastr2.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L80)

___

### options

• **options**: [`ToastrOptions`](../README.md#toastroptions)

#### Defined in

[src/q/toastr2.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L86)

___

### previousToast

• `Private` **previousToast**: `string` = `null`

#### Defined in

[src/q/toastr2.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L84)

___

### toastId

• `Private` **toastId**: `number` = `0`

#### Defined in

[src/q/toastr2.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L82)

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

[src/q/toastr2.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L185)

___

### clearContainer

▸ `Private` **clearContainer**(`options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | `Partial`<[`ToastrOptions`](../README.md#toastroptions)\> |

#### Returns

`void`

#### Defined in

[src/q/toastr2.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L235)

___

### clearToast

▸ `Private` **clearToast**(`toastElement?`, `options?`, `clearOptions?`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toastElement?` | `HTMLElement` |
| `options?` | [`ToastContainerOptions`](../README.md#toastcontaineroptions) |
| `clearOptions` | `Object` |
| `clearOptions.force?` | `boolean` |

#### Returns

`boolean`

#### Defined in

[src/q/toastr2.ts:247](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L247)

___

### createContainer

▸ `Private` **createContainer**(`options?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ToastContainerOptions`](../README.md#toastcontaineroptions) |

#### Returns

`HTMLElement`

#### Defined in

[src/q/toastr2.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L93)

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

[src/q/toastr2.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L121)

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

[src/q/toastr2.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L109)

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

[src/q/toastr2.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L160)

___

### notify

▸ `Private` **notify**(`map`, `opt`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `map` | [`NotifyMap`](../README.md#notifymap) |
| `opt` | [`ToastrOptions`](../README.md#toastroptions) |

#### Returns

`HTMLElement`

#### Defined in

[src/q/toastr2.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L266)

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

[src/q/toastr2.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L177)

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

[src/q/toastr2.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L191)

___

### removeToast

▸ **removeToast**(`toastElement`, `options?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toastElement` | `HTMLElement` |
| `options` | [`ToastrOptions`](../README.md#toastroptions) |

#### Returns

`void`

#### Defined in

[src/q/toastr2.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L211)

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

[src/q/toastr2.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L173)

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

[src/q/toastr2.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L147)

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

[src/q/toastr2.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/toastr2.ts#L134)
