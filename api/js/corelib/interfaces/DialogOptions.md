[@serenity-is/corelib](../README.md) / DialogOptions

# Interface: DialogOptions

Options that apply to all dialog types

## Hierarchy

- **`DialogOptions`**

  ↳ [`MessageDialogOptions`](MessageDialogOptions.md)

## Table of contents

### Properties

- [autoDispose](DialogOptions.md#autodispose)
- [autoOpen](DialogOptions.md#autoopen)
- [backdrop](DialogOptions.md#backdrop)
- [buttons](DialogOptions.md#buttons)
- [centered](DialogOptions.md#centered)
- [closeButton](DialogOptions.md#closebutton)
- [closeOnEscape](DialogOptions.md#closeonescape)
- [dialogClass](DialogOptions.md#dialogclass)
- [element](DialogOptions.md#element)
- [fade](DialogOptions.md#fade)
- [fullScreen](DialogOptions.md#fullscreen)
- [modal](DialogOptions.md#modal)
- [onClose](DialogOptions.md#onclose)
- [onOpen](DialogOptions.md#onopen)
- [preferBSModal](DialogOptions.md#preferbsmodal)
- [preferPanel](DialogOptions.md#preferpanel)
- [providerOptions](DialogOptions.md#provideroptions)
- [scrollable](DialogOptions.md#scrollable)
- [size](DialogOptions.md#size)
- [title](DialogOptions.md#title)
- [width](DialogOptions.md#width)

## Properties

### autoDispose

• `Optional` **autoDispose**: `boolean`

Auto dispose dialog on close, default is true

#### Defined in

[src/base/dialogs.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L35)

___

### autoOpen

• `Optional` **autoOpen**: `boolean`

True to auto open dialog

#### Defined in

[src/base/dialogs.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L37)

___

### backdrop

• `Optional` **backdrop**: `boolean` \| ``"static"``

Backdrop type, static to make it modal, e.g. can't be closed by clicking outside

#### Defined in

[src/base/dialogs.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L39)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](DialogButton.md)[]

List of buttons to show on the dialog

#### Defined in

[src/base/dialogs.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L41)

___

### centered

• `Optional` **centered**: `boolean`

Vertically center modal

#### Defined in

[src/base/dialogs.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L43)

___

### closeButton

• `Optional` **closeButton**: `boolean`

Show close button, default is true

#### Defined in

[src/base/dialogs.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L45)

___

### closeOnEscape

• `Optional` **closeOnEscape**: `boolean`

Close dialog on escape key. Default is true for message dialogs.

#### Defined in

[src/base/dialogs.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L47)

___

### dialogClass

• `Optional` **dialogClass**: `string`

CSS class to use for all dialog types. Is added to the top ui-dialog, panel or modal element

#### Defined in

[src/base/dialogs.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L49)

___

### element

• `Optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`: `HTMLElement`) => `void`

Dialog content/body element, or callback that will populate the content element

#### Defined in

[src/base/dialogs.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L51)

___

### fade

• `Optional` **fade**: `boolean`

Enable / disable animation. Default is false for message dialogs, true for other dialogs

#### Defined in

[src/base/dialogs.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L53)

___

### fullScreen

• `Optional` **fullScreen**: `boolean` \| ``"sm-down"`` \| ``"md-down"`` \| ``"lg-down"`` \| ``"xl-down"`` \| ``"xxl-down"``

Sets one of modal-fullscreen{-...-down} classes. Only used for bootstrap modals

#### Defined in

[src/base/dialogs.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L55)

___

### modal

• `Optional` **modal**: `boolean`

Modal option for jQuery UI dialog compatibility only. Not to be confused with Bootstrap modal.

#### Defined in

[src/base/dialogs.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L57)

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

#### Defined in

[src/base/dialogs.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L61)

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

#### Defined in

[src/base/dialogs.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L59)

___

### preferBSModal

• `Optional` **preferBSModal**: `boolean`

Prefer Bootstrap modals to jQuery UI dialogs when both are available

#### Defined in

[src/base/dialogs.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L63)

___

### preferPanel

• `Optional` **preferPanel**: `boolean`

Prefer Panel even when Modal / jQuery UI is available

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

#### Defined in

[src/base/dialogs.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L67)

___

### scrollable

• `Optional` **scrollable**: `boolean`

Scrollable, sets content of the modal to scrollable, only for Bootstrap

#### Defined in

[src/base/dialogs.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L69)

___

### size

• `Optional` **size**: ``"sm"`` \| ``"md"`` \| ``"lg"`` \| ``"xl"``

Size. Default is null for (500px) message dialogs, lg for normal dialogs

#### Defined in

[src/base/dialogs.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L71)

___

### title

• `Optional` **title**: `string`

Dialog title

#### Defined in

[src/base/dialogs.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L73)

___

### width

• `Optional` **width**: `number`

Only used for jQuery UI dialogs for backwards compatibility

#### Defined in

[src/base/dialogs.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L75)
