[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / AlertOptions

# Interface: AlertOptions

[corelib/q](../modules/corelib_q.md).AlertOptions

Additional options for Alert dialogs

## Hierarchy

- [`CommonDialogOptions`](corelib_q.CommonDialogOptions.md)

  ↳ **`AlertOptions`**

## Table of contents

### Properties

- [bootstrap](corelib_q.AlertOptions.md#bootstrap)
- [buttons](corelib_q.AlertOptions.md#buttons)
- [dialogClass](corelib_q.AlertOptions.md#dialogclass)
- [htmlEncode](corelib_q.AlertOptions.md#htmlencode)
- [modalClass](corelib_q.AlertOptions.md#modalclass)
- [okButton](corelib_q.AlertOptions.md#okbutton)
- [okButtonClass](corelib_q.AlertOptions.md#okbuttonclass)
- [onClose](corelib_q.AlertOptions.md#onclose)
- [onOpen](corelib_q.AlertOptions.md#onopen)
- [preWrap](corelib_q.AlertOptions.md#prewrap)
- [result](corelib_q.AlertOptions.md#result)
- [title](corelib_q.AlertOptions.md#title)

## Properties

### bootstrap

• `Optional` **bootstrap**: `boolean`

True to use Bootstrap dialogs even when jQuery UI  present, default is based on `Q.Config.bootstrapMessages

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[bootstrap](corelib_q.CommonDialogOptions.md#bootstrap)

#### Defined in

[src/q/dialogs.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L50)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](corelib_q.DialogButton.md)[]

List of buttons to show on the dialog

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[buttons](corelib_q.CommonDialogOptions.md#buttons)

#### Defined in

[src/q/dialogs.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L46)

___

### dialogClass

• `Optional` **dialogClass**: `string`

Dialog css class. Default is based on the message dialog type

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[dialogClass](corelib_q.CommonDialogOptions.md#dialogclass)

#### Defined in

[src/q/dialogs.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L44)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

HTML encode the message, default is true

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[htmlEncode](corelib_q.CommonDialogOptions.md#htmlencode)

#### Defined in

[src/q/dialogs.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L40)

___

### modalClass

• `Optional` **modalClass**: `string`

Class to use for the modal element for Bootstrap dialogs

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[modalClass](corelib_q.CommonDialogOptions.md#modalclass)

#### Defined in

[src/q/dialogs.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L48)

___

### okButton

• `Optional` **okButton**: `string` \| `boolean`

The title of OK button, or false to hide the OK button

#### Defined in

[src/q/dialogs.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L315)

___

### okButtonClass

• `Optional` **okButtonClass**: `string`

CSS class for OK button

#### Defined in

[src/q/dialogs.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L317)

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

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[onClose](corelib_q.CommonDialogOptions.md#onclose)

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

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[onOpen](corelib_q.CommonDialogOptions.md#onopen)

#### Defined in

[src/q/dialogs.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L34)

___

### preWrap

• `Optional` **preWrap**: `boolean`

Wrap the message in a `<pre>` element, so that line endings are preserved, default is true

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[preWrap](corelib_q.CommonDialogOptions.md#prewrap)

#### Defined in

[src/q/dialogs.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L42)

___

### result

• `Optional` **result**: `string`

The result code of the button used to close the dialog is returned via this variable in the options object

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[result](corelib_q.CommonDialogOptions.md#result)

#### Defined in

[src/q/dialogs.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L52)

___

### title

• `Optional` **title**: `string`

Dialog title

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[title](corelib_q.CommonDialogOptions.md#title)

#### Defined in

[src/q/dialogs.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L38)