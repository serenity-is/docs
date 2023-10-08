[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / CommonDialogOptions

# Interface: CommonDialogOptions

[corelib/q](../modules/corelib_q.md).CommonDialogOptions

Options that apply to all message dialog types

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

True to use Bootstrap dialogs even when jQuery UI  present, default is based on `Q.Config.bootstrapMessages

#### Defined in

[src/q/dialogs.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L50)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](corelib_q.DialogButton.md)[]

List of buttons to show on the dialog

#### Defined in

[src/q/dialogs.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L46)

___

### dialogClass

• `Optional` **dialogClass**: `string`

Dialog css class. Default is based on the message dialog type

#### Defined in

[src/q/dialogs.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L44)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

HTML encode the message, default is true

#### Defined in

[src/q/dialogs.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L40)

___

### modalClass

• `Optional` **modalClass**: `string`

Class to use for the modal element for Bootstrap dialogs

#### Defined in

[src/q/dialogs.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L48)

___

### onClose

• `Optional` **onClose**: (`result`: `string`) => `void`

#### Type declaration

▸ (`result`): `void`

Event handler that is called when dialog is closed

##### Parameters

| Name | Type |
| :------ | :------ |
| `result` | `string` |

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L36)

___

### onOpen

• `Optional` **onOpen**: () => `void`

#### Type declaration

▸ (): `void`

Event handler that is called when dialog is opened

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L34)

___

### preWrap

• `Optional` **preWrap**: `boolean`

Wrap the message in a `<pre>` element, so that line endings are preserved, default is true

#### Defined in

[src/q/dialogs.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L42)

___

### result

• `Optional` **result**: `string`

The result code of the button used to close the dialog is returned via this variable in the options object

#### Defined in

[src/q/dialogs.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L52)

___

### title

• `Optional` **title**: `string`

Dialog title

#### Defined in

[src/q/dialogs.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L38)