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

[../base/dist/index.d.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L258)

___

### autoOpen

• `Optional` **autoOpen**: `boolean`

True to auto open dialog

#### Defined in

[../base/dist/index.d.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L260)

___

### backdrop

• `Optional` **backdrop**: `boolean` \| ``"static"``

Backdrop type, static to make it modal, e.g. can't be closed by clicking outside

#### Defined in

[../base/dist/index.d.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L262)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](DialogButton.md)[]

List of buttons to show on the dialog

#### Defined in

[../base/dist/index.d.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L264)

___

### centered

• `Optional` **centered**: `boolean`

Vertically center modal

#### Defined in

[../base/dist/index.d.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L266)

___

### closeButton

• `Optional` **closeButton**: `boolean`

Show close button, default is true

#### Defined in

[../base/dist/index.d.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L268)

___

### closeOnEscape

• `Optional` **closeOnEscape**: `boolean`

Close dialog on escape key. Default is true for message dialogs.

#### Defined in

[../base/dist/index.d.ts:270](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L270)

___

### dialogClass

• `Optional` **dialogClass**: `string`

CSS class to use for all dialog types. Is added to the top ui-dialog, panel or modal element

#### Defined in

[../base/dist/index.d.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L272)

___

### element

• `Optional` **element**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`element`: `HTMLElement`) => `void`

Dialog content/body element, or callback that will populate the content element

#### Defined in

[../base/dist/index.d.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L274)

___

### fade

• `Optional` **fade**: `boolean`

Enable / disable animation. Default is false for message dialogs, true for other dialogs

#### Defined in

[../base/dist/index.d.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L276)

___

### fullScreen

• `Optional` **fullScreen**: `boolean` \| ``"sm-down"`` \| ``"md-down"`` \| ``"lg-down"`` \| ``"xl-down"`` \| ``"xxl-down"``

Sets one of modal-fullscreen{-...-down} classes. Only used for bootstrap modals

#### Defined in

[../base/dist/index.d.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L278)

___

### modal

• `Optional` **modal**: `boolean`

Modal option for jQuery UI dialog compatibility only. Not to be confused with Bootstrap modal.

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

#### Defined in

[../base/dist/index.d.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L282)

___

### preferBSModal

• `Optional` **preferBSModal**: `boolean`

Prefer Bootstrap modals to jQuery UI dialogs when both are available

#### Defined in

[../base/dist/index.d.ts:286](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L286)

___

### preferPanel

• `Optional` **preferPanel**: `boolean`

Prefer Panel even when Modal / jQuery UI is available

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

#### Defined in

[../base/dist/index.d.ts:290](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L290)

___

### scrollable

• `Optional` **scrollable**: `boolean`

Scrollable, sets content of the modal to scrollable, only for Bootstrap

#### Defined in

[../base/dist/index.d.ts:292](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L292)

___

### size

• `Optional` **size**: ``"lg"`` \| ``"sm"`` \| ``"md"`` \| ``"xl"``

Size. Default is null for (500px) message dialogs, lg for normal dialogs

#### Defined in

[../base/dist/index.d.ts:294](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L294)

___

### title

• `Optional` **title**: `string`

Dialog title

#### Defined in

[../base/dist/index.d.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L296)

___

### width

• `Optional` **width**: `number`

Only used for jQuery UI dialogs for backwards compatibility

#### Defined in

[../base/dist/index.d.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L298)
