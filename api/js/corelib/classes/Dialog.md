[@serenity-is/corelib](../README.md) / Dialog

# Class: Dialog

## Table of contents

### Constructors

- [constructor](Dialog.md#constructor)

### Properties

- [createBSButtons](Dialog.md#createbsbuttons)
- [createPanel](Dialog.md#createpanel)
- [dialogResult](Dialog.md#dialogresult)
- [el](Dialog.md#el)
- [onButtonClick](Dialog.md#onbuttonclick)
- [defaults](Dialog.md#defaults)
- [messageDefaults](Dialog.md#messagedefaults)

### Accessors

- [result](Dialog.md#result)
- [type](Dialog.md#type)

### Methods

- [close](Dialog.md#close)
- [createBSModal](Dialog.md#createbsmodal)
- [createUIDialog](Dialog.md#createuidialog)
- [dispose](Dialog.md#dispose)
- [getContentNode](Dialog.md#getcontentnode)
- [getDialogNode](Dialog.md#getdialognode)
- [getEventsNode](Dialog.md#geteventsnode)
- [getFooterNode](Dialog.md#getfooternode)
- [getHeaderNode](Dialog.md#getheadernode)
- [onClose](Dialog.md#onclose)
- [onOpen](Dialog.md#onopen)
- [open](Dialog.md#open)
- [title](Dialog.md#title)
- [getInstance](Dialog.md#getinstance)

## Constructors

### constructor

• **new Dialog**(`opt?`): [`Dialog`](Dialog.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt?` | [`DialogOptions`](../interfaces/DialogOptions.md) |

#### Returns

[`Dialog`](Dialog.md)

#### Defined in

[../base/dist/index.d.ts:303](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L303)

## Properties

### createBSButtons

• `Private` **createBSButtons**: `any`

#### Defined in

[../base/dist/index.d.ts:333](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L333)

___

### createPanel

• `Private` **createPanel**: `any`

#### Defined in

[../base/dist/index.d.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L335)

___

### dialogResult

• `Private` **dialogResult**: `any`

#### Defined in

[../base/dist/index.d.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L302)

___

### el

• `Private` **el**: `any`

#### Defined in

[../base/dist/index.d.ts:301](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L301)

___

### onButtonClick

• `Private` **onButtonClick**: `any`

#### Defined in

[../base/dist/index.d.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L332)

___

### defaults

▪ `Static` **defaults**: [`DialogOptions`](../interfaces/DialogOptions.md)

#### Defined in

[../base/dist/index.d.ts:304](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L304)

___

### messageDefaults

▪ `Static` **messageDefaults**: [`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

#### Defined in

[../base/dist/index.d.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L305)

## Accessors

### result

• `get` **result**(): `string`

The result code of the button that is clicked. Also attached to the dialog element as data-dialog-result

#### Returns

`string`

#### Defined in

[../base/dist/index.d.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L308)

___

### type

• `get` **type**(): [`DialogType`](../README.md#dialogtype)

#### Returns

[`DialogType`](../README.md#dialogtype)

#### Defined in

[../base/dist/index.d.ts:321](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L321)

## Methods

### close

▸ **close**(): `this`

Closes dialog setting the result to null

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:310](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L310)

▸ **close**(`result`): `this`

Closes dialog with the result set to value

#### Parameters

| Name | Type |
| :------ | :------ |
| `result` | `string` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:312](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L312)

___

### createBSModal

▸ **createBSModal**(`opt`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt` | [`DialogOptions`](../interfaces/DialogOptions.md) |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L334)

___

### createUIDialog

▸ **createUIDialog**(`opt`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt` | [`DialogOptions`](../interfaces/DialogOptions.md) |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:336](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L336)

___

### dispose

▸ **dispose**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:337](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L337)

___

### getContentNode

▸ **getContentNode**(): `HTMLElement`

Gets the body/content element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L323)

___

### getDialogNode

▸ **getDialogNode**(): `HTMLElement`

Gets the dialog element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:325](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L325)

___

### getEventsNode

▸ **getEventsNode**(): `HTMLElement`

Gets the node that receives events for the dialog. It's .ui-dialog-content, .modal, or .panel-body

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:327](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L327)

___

### getFooterNode

▸ **getFooterNode**(): `HTMLElement`

Gets the footer element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L329)

___

### getHeaderNode

▸ **getHeaderNode**(): `HTMLElement`

Gets the header element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[../base/dist/index.d.ts:331](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L331)

___

### onClose

▸ **onClose**(`handler`, `before?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`result?`: `string`, `e?`: `Event`) => `void` |
| `before?` | `boolean` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:313](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L313)

___

### onOpen

▸ **onOpen**(`handler`, `before?`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e?`: `Event`) => `void` |
| `before?` | `boolean` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:314](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L314)

___

### open

▸ **open**(): `this`

Closes dialog

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:316](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L316)

___

### title

▸ **title**(): `string`

Gets the title text of the dialog

#### Returns

`string`

#### Defined in

[../base/dist/index.d.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L318)

▸ **title**(`value`): `this`

Sets the title text of the dialog.

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:320](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L320)

___

### getInstance

▸ **getInstance**(`el`): [`Dialog`](Dialog.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

[`Dialog`](Dialog.md)

#### Defined in

[../base/dist/index.d.ts:306](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L306)
