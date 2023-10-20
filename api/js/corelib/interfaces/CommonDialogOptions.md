[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / CommonDialogOptions

# Interface: CommonDialogOptions

Options that apply to all message dialog types

## Hierarchy

- **`CommonDialogOptions`**

  ↳ [`AlertOptions`](AlertOptions.md)

  ↳ [`ConfirmOptions`](ConfirmOptions.md)

## Table of contents

### Properties

- [bootstrap](CommonDialogOptions.md#bootstrap)
- [buttons](CommonDialogOptions.md#buttons)
- [dialogClass](CommonDialogOptions.md#dialogclass)
- [htmlEncode](CommonDialogOptions.md#htmlencode)
- [modalClass](CommonDialogOptions.md#modalclass)
- [onClose](CommonDialogOptions.md#onclose)
- [onOpen](CommonDialogOptions.md#onopen)
- [preWrap](CommonDialogOptions.md#prewrap)
- [result](CommonDialogOptions.md#result)
- [title](CommonDialogOptions.md#title)

## Properties

### bootstrap

• `Optional` **bootstrap**: `boolean`

True to use Bootstrap dialogs even when jQuery UI  present, default is based on `Q.Config.bootstrapMessages

#### Defined in

[src/q/dialogs.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L50)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](DialogButton.md)[]

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
