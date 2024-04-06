[@serenity-is/corelib](../README.md) / ConfirmDialogOptions

# Interface: ConfirmDialogOptions

Additional options for confirm dialog

## Hierarchy

- [`MessageDialogOptions`](MessageDialogOptions.md)

  ↳ **`ConfirmDialogOptions`**

## Table of contents

### Properties

- [autoDispose](ConfirmDialogOptions.md#autodispose)
- [autoOpen](ConfirmDialogOptions.md#autoopen)
- [backdrop](ConfirmDialogOptions.md#backdrop)
- [buttons](ConfirmDialogOptions.md#buttons)
- [cancelButton](ConfirmDialogOptions.md#cancelbutton)
- [centered](ConfirmDialogOptions.md#centered)
- [closeButton](ConfirmDialogOptions.md#closebutton)
- [closeOnEscape](ConfirmDialogOptions.md#closeonescape)
- [dialogClass](ConfirmDialogOptions.md#dialogclass)
- [element](ConfirmDialogOptions.md#element)
- [fade](ConfirmDialogOptions.md#fade)
- [fullScreen](ConfirmDialogOptions.md#fullscreen)
- [htmlEncode](ConfirmDialogOptions.md#htmlencode)
- [modal](ConfirmDialogOptions.md#modal)
- [onCancel](ConfirmDialogOptions.md#oncancel)
- [onClose](ConfirmDialogOptions.md#onclose)
- [onNo](ConfirmDialogOptions.md#onno)
- [onOpen](ConfirmDialogOptions.md#onopen)
- [preWrap](ConfirmDialogOptions.md#prewrap)
- [preferBSModal](ConfirmDialogOptions.md#preferbsmodal)
- [preferPanel](ConfirmDialogOptions.md#preferpanel)
- [providerOptions](ConfirmDialogOptions.md#provideroptions)
- [scrollable](ConfirmDialogOptions.md#scrollable)
- [size](ConfirmDialogOptions.md#size)
- [title](ConfirmDialogOptions.md#title)
- [width](ConfirmDialogOptions.md#width)

## Properties

### autoDispose

• `Optional` **autoDispose**: `boolean`

Auto dispose dialog on close, default is true

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[autoDispose](MessageDialogOptions.md#autodispose)

#### Defined in

[src/base/dialogs.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L35)

___

### autoOpen

• `Optional` **autoOpen**: `boolean`

True to auto open dialog

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[autoOpen](MessageDialogOptions.md#autoopen)

#### Defined in

[src/base/dialogs.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L37)

___

### backdrop

• `Optional` **backdrop**: `boolean` \| ``"static"``

Backdrop type, static to make it modal, e.g. can't be closed by clicking outside

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[backdrop](MessageDialogOptions.md#backdrop)

#### Defined in

[src/base/dialogs.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L39)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](DialogButton.md)[]

List of buttons to show on the dialog

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[buttons](MessageDialogOptions.md#buttons)

#### Defined in

[src/base/dialogs.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L41)

___

### cancelButton

• `Optional` **cancelButton**: `boolean`

True to also add a cancel button

#### Defined in

[src/base/dialogs.ts:822](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L822)

___

### centered

• `Optional` **centered**: `boolean`

Vertically center modal

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[centered](MessageDialogOptions.md#centered)

#### Defined in

[src/base/dialogs.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L43)

___

### closeButton

• `Optional` **closeButton**: `boolean`

Show close button, default is true

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[closeButton](MessageDialogOptions.md#closebutton)

#### Defined in

[src/base/dialogs.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L45)

___

### closeOnEscape

• `Optional` **closeOnEscape**: `boolean`

Close dialog on escape key. Default is true for message dialogs.

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[closeOnEscape](MessageDialogOptions.md#closeonescape)

#### Defined in

[src/base/dialogs.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L47)

___

### dialogClass

• `Optional` **dialogClass**: `string`

CSS class to use for all dialog types. Is added to the top ui-dialog, panel or modal element

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[dialogClass](MessageDialogOptions.md#dialogclass)

#### Defined in

[src/base/dialogs.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L49)

___

### element

• `Optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`: `HTMLElement`) => `void`

Dialog content/body element, or callback that will populate the content element

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[element](MessageDialogOptions.md#element)

#### Defined in

[src/base/dialogs.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L51)

___

### fade

• `Optional` **fade**: `boolean`

Enable / disable animation. Default is false for message dialogs, true for other dialogs

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[fade](MessageDialogOptions.md#fade)

#### Defined in

[src/base/dialogs.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L53)

___

### fullScreen

• `Optional` **fullScreen**: `boolean` \| ``"sm-down"`` \| ``"md-down"`` \| ``"lg-down"`` \| ``"xl-down"`` \| ``"xxl-down"``

Sets one of modal-fullscreen{-...-down} classes. Only used for bootstrap modals

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[fullScreen](MessageDialogOptions.md#fullscreen)

#### Defined in

[src/base/dialogs.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L55)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

HTML encode the message, default is true

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[htmlEncode](MessageDialogOptions.md#htmlencode)

#### Defined in

[src/base/dialogs.ts:737](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L737)

___

### modal

• `Optional` **modal**: `boolean`

Modal option for jQuery UI dialog compatibility only. Not to be confused with Bootstrap modal.

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[modal](MessageDialogOptions.md#modal)

#### Defined in

[src/base/dialogs.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L57)

___

### onCancel

• `Optional` **onCancel**: () => `void`

Event handler for cancel button click

#### Type declaration

▸ (): `void`

##### Returns

`void`

#### Defined in

[src/base/dialogs.ts:824](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L824)

___

### onClose

• `Optional` **onClose**: (`result`: `string`, `e?`: `Event`) => `void`

Event handler that is called when dialog is closed

#### Type declaration

▸ (`result`, `e?`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `result` | `string` |
| `e?` | `Event` |

##### Returns

`void`

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[onClose](MessageDialogOptions.md#onclose)

#### Defined in

[src/base/dialogs.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L61)

___

### onNo

• `Optional` **onNo**: () => `void`

Event handler for no button click

#### Type declaration

▸ (): `void`

##### Returns

`void`

#### Defined in

[src/base/dialogs.ts:826](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L826)

___

### onOpen

• `Optional` **onOpen**: (`e?`: `Event`) => `void`

Event handler that is called when dialog is opened

#### Type declaration

▸ (`e?`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `e?` | `Event` |

##### Returns

`void`

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[onOpen](MessageDialogOptions.md#onopen)

#### Defined in

[src/base/dialogs.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L59)

___

### preWrap

• `Optional` **preWrap**: `boolean`

Wrap the message in a `<pre>` element, so that line endings are preserved, default is true

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[preWrap](MessageDialogOptions.md#prewrap)

#### Defined in

[src/base/dialogs.ts:739](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L739)

___

### preferBSModal

• `Optional` **preferBSModal**: `boolean`

Prefer Bootstrap modals to jQuery UI dialogs when both are available

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[preferBSModal](MessageDialogOptions.md#preferbsmodal)

#### Defined in

[src/base/dialogs.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L63)

___

### preferPanel

• `Optional` **preferPanel**: `boolean`

Prefer Panel even when Modal / jQuery UI is available

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[preferPanel](MessageDialogOptions.md#preferpanel)

#### Defined in

[src/base/dialogs.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L65)

___

### providerOptions

• `Optional` **providerOptions**: (`type`: [`DialogType`](../README.md#dialogtype), `opt`: [`DialogOptions`](DialogOptions.md)) => `any`

Callback to get options specific to the dialog provider type

#### Type declaration

▸ (`type`, `opt`): `any`

##### Parameters

| Name | Type |
| :------ | :------ |
| `type` | [`DialogType`](../README.md#dialogtype) |
| `opt` | [`DialogOptions`](DialogOptions.md) |

##### Returns

`any`

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[providerOptions](MessageDialogOptions.md#provideroptions)

#### Defined in

[src/base/dialogs.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L67)

___

### scrollable

• `Optional` **scrollable**: `boolean`

Scrollable, sets content of the modal to scrollable, only for Bootstrap

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[scrollable](MessageDialogOptions.md#scrollable)

#### Defined in

[src/base/dialogs.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L69)

___

### size

• `Optional` **size**: ``"sm"`` \| ``"md"`` \| ``"lg"`` \| ``"xl"``

Size. Default is null for (500px) message dialogs, lg for normal dialogs

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[size](MessageDialogOptions.md#size)

#### Defined in

[src/base/dialogs.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L71)

___

### title

• `Optional` **title**: `string`

Dialog title

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[title](MessageDialogOptions.md#title)

#### Defined in

[src/base/dialogs.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L73)

___

### width

• `Optional` **width**: `number`

Only used for jQuery UI dialogs for backwards compatibility

#### Inherited from

[MessageDialogOptions](MessageDialogOptions.md).[width](MessageDialogOptions.md#width)

#### Defined in

[src/base/dialogs.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L75)
