[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / CommonDialogOptions

# Interface: CommonDialogOptions

[corelib/q](../modules/corelib_q.md).CommonDialogOptions

## Hierarchy

- **`CommonDialogOptions`**

  ↳ [`AlertOptions`](corelib_q.AlertOptions.md)

  ↳ [`ConfirmOptions`](corelib_q.ConfirmOptions.md)

## Table of contents

### Properties

- [bootstrap](corelib_q.CommonDialogOptions.md#bootstrap)
- [buttons](corelib_q.CommonDialogOptions.md#buttons)
- [dialogClass](corelib_q.CommonDialogOptions.md#dialogclass)
- [htmlEncode](corelib_q.CommonDialogOptions.md#htmlencode)
- [modalClass](corelib_q.CommonDialogOptions.md#modalclass)
- [onClose](corelib_q.CommonDialogOptions.md#onclose)
- [onOpen](corelib_q.CommonDialogOptions.md#onopen)
- [preWrap](corelib_q.CommonDialogOptions.md#prewrap)
- [result](corelib_q.CommonDialogOptions.md#result)
- [title](corelib_q.CommonDialogOptions.md#title)

## Properties

### bootstrap

• `Optional` **bootstrap**: `boolean`

#### Defined in

[src/q/dialogs.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;27)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](corelib_q.DialogButton.md)[]

#### Defined in

[src/q/dialogs.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;25)

___

### dialogClass

• `Optional` **dialogClass**: `string`

#### Defined in

[src/q/dialogs.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;24)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

#### Defined in

[src/q/dialogs.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;22)

___

### modalClass

• `Optional` **modalClass**: `string`

#### Defined in

[src/q/dialogs.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;26)

___

### onClose

• `Optional` **onClose**: (`result`: `string`) => `void`

#### Type declaration

▸ (`result`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `result` | `string` |

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;20)

___

### onOpen

• `Optional` **onOpen**: () => `void`

#### Type declaration

▸ (): `void`

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;19)

___

### preWrap

• `Optional` **preWrap**: `boolean`

#### Defined in

[src/q/dialogs.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;23)

___

### result

• `Optional` **result**: `string`

#### Defined in

[src/q/dialogs.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;28)

___

### title

• `Optional` **title**: `string`

#### Defined in

[src/q/dialogs.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;21)
