[@serenity-is](../README.md) / [Modules](../modules.md) / [q](../modules/q.md) / AlertOptions

# Interface: AlertOptions

[q](../modules/q.md).AlertOptions

Additional options for Alert dialogs

## Hierarchy

- [`CommonDialogOptions`](q.CommonDialogOptions.md)

  ↳ **`AlertOptions`**

## Table of contents

### Properties

- [bootstrap](q.AlertOptions.md#bootstrap)
- [buttons](q.AlertOptions.md#buttons)
- [dialogClass](q.AlertOptions.md#dialogclass)
- [htmlEncode](q.AlertOptions.md#htmlencode)
- [modalClass](q.AlertOptions.md#modalclass)
- [okButton](q.AlertOptions.md#okbutton)
- [okButtonClass](q.AlertOptions.md#okbuttonclass)
- [onClose](q.AlertOptions.md#onclose)
- [onOpen](q.AlertOptions.md#onopen)
- [preWrap](q.AlertOptions.md#prewrap)
- [result](q.AlertOptions.md#result)
- [title](q.AlertOptions.md#title)

## Properties

### bootstrap

• `Optional` **bootstrap**: `boolean`

True to use Bootstrap dialogs even when jQuery UI  present, default is based on `Q.Config.bootstrapMessages

#### Inherited from

[CommonDialogOptions](q.CommonDialogOptions.md).[bootstrap](q.CommonDialogOptions.md#bootstrap)

#### Defined in

[src/q/dialogs.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L50)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](q.DialogButton.md)[]

List of buttons to show on the dialog

#### Inherited from

[CommonDialogOptions](q.CommonDialogOptions.md).[buttons](q.CommonDialogOptions.md#buttons)

#### Defined in

[src/q/dialogs.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L46)

___

### dialogClass

• `Optional` **dialogClass**: `string`

Dialog css class. Default is based on the message dialog type

#### Inherited from

[CommonDialogOptions](q.CommonDialogOptions.md).[dialogClass](q.CommonDialogOptions.md#dialogclass)

#### Defined in

[src/q/dialogs.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L44)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

HTML encode the message, default is true

#### Inherited from

[CommonDialogOptions](q.CommonDialogOptions.md).[htmlEncode](q.CommonDialogOptions.md#htmlencode)

#### Defined in

[src/q/dialogs.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L40)

___

### modalClass

• `Optional` **modalClass**: `string`

Class to use for the modal element for Bootstrap dialogs

#### Inherited from

[CommonDialogOptions](q.CommonDialogOptions.md).[modalClass](q.CommonDialogOptions.md#modalclass)

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

[CommonDialogOptions](q.CommonDialogOptions.md).[onClose](q.CommonDialogOptions.md#onclose)

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

[CommonDialogOptions](q.CommonDialogOptions.md).[onOpen](q.CommonDialogOptions.md#onopen)

#### Defined in

[src/q/dialogs.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L34)

___

### preWrap

• `Optional` **preWrap**: `boolean`

Wrap the message in a `<pre>` element, so that line endings are preserved, default is true

#### Inherited from

[CommonDialogOptions](q.CommonDialogOptions.md).[preWrap](q.CommonDialogOptions.md#prewrap)

#### Defined in

[src/q/dialogs.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L42)

___

### result

• `Optional` **result**: `string`

The result code of the button used to close the dialog is returned via this variable in the options object

#### Inherited from

[CommonDialogOptions](q.CommonDialogOptions.md).[result](q.CommonDialogOptions.md#result)

#### Defined in

[src/q/dialogs.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L52)

___

### title

• `Optional` **title**: `string`

Dialog title

#### Inherited from

[CommonDialogOptions](q.CommonDialogOptions.md).[title](q.CommonDialogOptions.md#title)

#### Defined in

[src/q/dialogs.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L38)
