[@serenity-is/corelib](../README.md) / MessageDialogOptions

# Interface: MessageDialogOptions

Options that apply to all message dialog types

## Hierarchy

- [`DialogOptions`](DialogOptions.md)

  ↳ **`MessageDialogOptions`**

  ↳↳ [`ConfirmDialogOptions`](ConfirmDialogOptions.md)

## Table of contents

### Properties

- [autoDispose](MessageDialogOptions.md#autodispose)
- [autoOpen](MessageDialogOptions.md#autoopen)
- [backdrop](MessageDialogOptions.md#backdrop)
- [buttons](MessageDialogOptions.md#buttons)
- [centered](MessageDialogOptions.md#centered)
- [closeButton](MessageDialogOptions.md#closebutton)
- [closeOnEscape](MessageDialogOptions.md#closeonescape)
- [dialogClass](MessageDialogOptions.md#dialogclass)
- [element](MessageDialogOptions.md#element)
- [fade](MessageDialogOptions.md#fade)
- [fullScreen](MessageDialogOptions.md#fullscreen)
- [htmlEncode](MessageDialogOptions.md#htmlencode)
- [modal](MessageDialogOptions.md#modal)
- [onClose](MessageDialogOptions.md#onclose)
- [onOpen](MessageDialogOptions.md#onopen)
- [preWrap](MessageDialogOptions.md#prewrap)
- [preferBSModal](MessageDialogOptions.md#preferbsmodal)
- [preferPanel](MessageDialogOptions.md#preferpanel)
- [providerOptions](MessageDialogOptions.md#provideroptions)
- [scrollable](MessageDialogOptions.md#scrollable)
- [size](MessageDialogOptions.md#size)
- [title](MessageDialogOptions.md#title)
- [width](MessageDialogOptions.md#width)

## Properties

### autoDispose

• `Optional` **autoDispose**: `boolean`

Auto dispose dialog on close, default is true

#### Inherited from

[DialogOptions](DialogOptions.md).[autoDispose](DialogOptions.md#autodispose)

#### Defined in

[../base/dist/index.d.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L258)

___

### autoOpen

• `Optional` **autoOpen**: `boolean`

True to auto open dialog

#### Inherited from

[DialogOptions](DialogOptions.md).[autoOpen](DialogOptions.md#autoopen)

#### Defined in

[../base/dist/index.d.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L260)

___

### backdrop

• `Optional` **backdrop**: `boolean` \| ``"static"``

Backdrop type, static to make it modal, e.g. can't be closed by clicking outside

#### Inherited from

[DialogOptions](DialogOptions.md).[backdrop](DialogOptions.md#backdrop)

#### Defined in

[../base/dist/index.d.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L262)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](DialogButton.md)[]

List of buttons to show on the dialog

#### Inherited from

[DialogOptions](DialogOptions.md).[buttons](DialogOptions.md#buttons)

#### Defined in

[../base/dist/index.d.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L264)

___

### centered

• `Optional` **centered**: `boolean`

Vertically center modal

#### Inherited from

[DialogOptions](DialogOptions.md).[centered](DialogOptions.md#centered)

#### Defined in

[../base/dist/index.d.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L266)

___

### closeButton

• `Optional` **closeButton**: `boolean`

Show close button, default is true

#### Inherited from

[DialogOptions](DialogOptions.md).[closeButton](DialogOptions.md#closebutton)

#### Defined in

[../base/dist/index.d.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L268)

___

### closeOnEscape

• `Optional` **closeOnEscape**: `boolean`

Close dialog on escape key. Default is true for message dialogs.

#### Inherited from

[DialogOptions](DialogOptions.md).[closeOnEscape](DialogOptions.md#closeonescape)

#### Defined in

[../base/dist/index.d.ts:270](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L270)

___

### dialogClass

• `Optional` **dialogClass**: `string`

CSS class to use for all dialog types. Is added to the top ui-dialog, panel or modal element

#### Inherited from

[DialogOptions](DialogOptions.md).[dialogClass](DialogOptions.md#dialogclass)

#### Defined in

[../base/dist/index.d.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L272)

___

### element

• `Optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`: `HTMLElement`) => `void`

Dialog content/body element, or callback that will populate the content element

#### Inherited from

[DialogOptions](DialogOptions.md).[element](DialogOptions.md#element)

#### Defined in

[../base/dist/index.d.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L274)

___

### fade

• `Optional` **fade**: `boolean`

Enable / disable animation. Default is false for message dialogs, true for other dialogs

#### Inherited from

[DialogOptions](DialogOptions.md).[fade](DialogOptions.md#fade)

#### Defined in

[../base/dist/index.d.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L276)

___

### fullScreen

• `Optional` **fullScreen**: `boolean` \| ``"sm-down"`` \| ``"md-down"`` \| ``"lg-down"`` \| ``"xl-down"`` \| ``"xxl-down"``

Sets one of modal-fullscreen{-...-down} classes. Only used for bootstrap modals

#### Inherited from

[DialogOptions](DialogOptions.md).[fullScreen](DialogOptions.md#fullscreen)

#### Defined in

[../base/dist/index.d.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L278)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

HTML encode the message, default is true

#### Defined in

[../base/dist/index.d.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L365)

___

### modal

• `Optional` **modal**: `boolean`

Modal option for jQuery UI dialog compatibility only. Not to be confused with Bootstrap modal.

#### Inherited from

[DialogOptions](DialogOptions.md).[modal](DialogOptions.md#modal)

#### Defined in

[../base/dist/index.d.ts:280](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L280)

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

[DialogOptions](DialogOptions.md).[onClose](DialogOptions.md#onclose)

#### Defined in

[../base/dist/index.d.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L284)

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

[DialogOptions](DialogOptions.md).[onOpen](DialogOptions.md#onopen)

#### Defined in

[../base/dist/index.d.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L282)

___

### preWrap

• `Optional` **preWrap**: `boolean`

Wrap the message in a `<pre>` element, so that line endings are preserved, default is true

#### Defined in

[../base/dist/index.d.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L367)

___

### preferBSModal

• `Optional` **preferBSModal**: `boolean`

Prefer Bootstrap modals to jQuery UI dialogs when both are available

#### Inherited from

[DialogOptions](DialogOptions.md).[preferBSModal](DialogOptions.md#preferbsmodal)

#### Defined in

[../base/dist/index.d.ts:286](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L286)

___

### preferPanel

• `Optional` **preferPanel**: `boolean`

Prefer Panel even when Modal / jQuery UI is available

#### Inherited from

[DialogOptions](DialogOptions.md).[preferPanel](DialogOptions.md#preferpanel)

#### Defined in

[../base/dist/index.d.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L288)

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

[DialogOptions](DialogOptions.md).[providerOptions](DialogOptions.md#provideroptions)

#### Defined in

[../base/dist/index.d.ts:290](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L290)

___

### scrollable

• `Optional` **scrollable**: `boolean`

Scrollable, sets content of the modal to scrollable, only for Bootstrap

#### Inherited from

[DialogOptions](DialogOptions.md).[scrollable](DialogOptions.md#scrollable)

#### Defined in

[../base/dist/index.d.ts:292](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L292)

___

### size

• `Optional` **size**: ``"lg"`` \| ``"sm"`` \| ``"md"`` \| ``"xl"``

Size. Default is null for (500px) message dialogs, lg for normal dialogs

#### Inherited from

[DialogOptions](DialogOptions.md).[size](DialogOptions.md#size)

#### Defined in

[../base/dist/index.d.ts:294](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L294)

___

### title

• `Optional` **title**: `string`

Dialog title

#### Inherited from

[DialogOptions](DialogOptions.md).[title](DialogOptions.md#title)

#### Defined in

[../base/dist/index.d.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L296)

___

### width

• `Optional` **width**: `number`

Only used for jQuery UI dialogs for backwards compatibility

#### Inherited from

[DialogOptions](DialogOptions.md).[width](DialogOptions.md#width)

#### Defined in

[../base/dist/index.d.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L298)
