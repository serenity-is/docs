[@serenity-is/corelib](../README.md) / Dialog

# Class: Dialog

## Table of contents

### Constructors

- [constructor](Dialog.md#constructor)

### Properties

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

[src/base/dialogs.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L83)

## Properties

### defaults

▪ `Static` **defaults**: [`DialogOptions`](../interfaces/DialogOptions.md)

#### Defined in

[src/base/dialogs.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L132)

___

### messageDefaults

▪ `Static` **messageDefaults**: [`MessageDialogOptions`](../interfaces/MessageDialogOptions.md)

#### Defined in

[src/base/dialogs.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L145)

## Accessors

### result

• `get` **result**(): `string`

The result code of the button that is clicked. Also attached to the dialog element as data-dialog-result

#### Returns

`string`

#### Defined in

[src/base/dialogs.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L169)

___

### type

• `get` **type**(): [`DialogType`](../README.md#dialogtype)

#### Returns

[`DialogType`](../README.md#dialogtype)

#### Defined in

[src/base/dialogs.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L262)

## Methods

### close

▸ **close**(): `this`

Closes dialog setting the result to null

#### Returns

`this`

#### Defined in

[src/base/dialogs.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L174)

▸ **close**(`result`): `this`

Closes dialog with the result set to value

#### Parameters

| Name | Type |
| :------ | :------ |
| `result` | `string` |

#### Returns

`this`

#### Defined in

[src/base/dialogs.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L176)

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

[src/base/dialogs.ts:326](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L326)

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

[src/base/dialogs.ts:439](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L439)

___

### dispose

▸ **dispose**(): `void`

#### Returns

`void`

#### Defined in

[src/base/dialogs.ts:468](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L468)

___

### getContentNode

▸ **getContentNode**(): `HTMLElement`

Gets the body/content element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L276)

___

### getDialogNode

▸ **getDialogNode**(): `HTMLElement`

Gets the dialog element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L281)

___

### getEventsNode

▸ **getEventsNode**(): `HTMLElement`

Gets the node that receives events for the dialog. It's .ui-dialog-content, .modal, or .panel-body

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.ts:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L286)

___

### getFooterNode

▸ **getFooterNode**(): `HTMLElement`

Gets the footer element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L291)

___

### getHeaderNode

▸ **getHeaderNode**(): `HTMLElement`

Gets the header element of the dialog

#### Returns

`HTMLElement`

#### Defined in

[src/base/dialogs.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L296)

___

### onClose

▸ **onClose**(`handler`, `before?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `handler` | (`result?`: `string`, `e?`: `Event`) => `void` | `undefined` |
| `before` | `boolean` | `false` |

#### Returns

`void`

#### Defined in

[src/base/dialogs.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L202)

___

### onOpen

▸ **onOpen**(`handler`, `before?`): `this`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `handler` | (`e?`: `Event`) => `void` | `undefined` |
| `before` | `boolean` | `false` |

#### Returns

`this`

#### Defined in

[src/base/dialogs.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L214)

___

### open

▸ **open**(): [`Dialog`](Dialog.md)

Closes dialog

#### Returns

[`Dialog`](Dialog.md)

#### Defined in

[src/base/dialogs.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L228)

___

### title

▸ **title**(): `string`

Gets the title text of the dialog

#### Returns

`string`

#### Defined in

[src/base/dialogs.ts:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L250)

▸ **title**(`value`): `this`

Sets the title text of the dialog.

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`this`

#### Defined in

[src/base/dialogs.ts:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L252)

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

[src/base/dialogs.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L161)
