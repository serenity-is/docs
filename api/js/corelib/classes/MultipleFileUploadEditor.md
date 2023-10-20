[@serenity-is/corelib](../README.md) / MultipleFileUploadEditor

# Class: MultipleFileUploadEditor

## Hierarchy

- [`Widget`](Widget.md)<[`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md)\>

  ↳ **`MultipleFileUploadEditor`**

  ↳↳ [`MultipleImageUploadEditor`](MultipleImageUploadEditor.md)

## Implements

- [`IReadOnly`](IReadOnly.md)
- [`IGetEditValue`](IGetEditValue.md)
- [`ISetEditValue`](ISetEditValue.md)
- [`IValidateRequired`](IValidateRequired.md)

## Table of contents

### Constructors

- [constructor](MultipleFileUploadEditor.md#constructor)

### Properties

- [element](MultipleFileUploadEditor.md#element)
- [entities](MultipleFileUploadEditor.md#entities)
- [fileSymbols](MultipleFileUploadEditor.md#filesymbols)
- [hiddenInput](MultipleFileUploadEditor.md#hiddeninput)
- [idPrefix](MultipleFileUploadEditor.md#idprefix)
- [jsonEncodeValue](MultipleFileUploadEditor.md#jsonencodevalue)
- [options](MultipleFileUploadEditor.md#options)
- [progress](MultipleFileUploadEditor.md#progress)
- [toolbar](MultipleFileUploadEditor.md#toolbar)
- [uniqueName](MultipleFileUploadEditor.md#uniquename)
- [uploadInput](MultipleFileUploadEditor.md#uploadinput)
- [widgetName](MultipleFileUploadEditor.md#widgetname)

### Accessors

- [value](MultipleFileUploadEditor.md#value)

### Methods

- [addCssClass](MultipleFileUploadEditor.md#addcssclass)
- [addFileButtonText](MultipleFileUploadEditor.md#addfilebuttontext)
- [addValidationRule](MultipleFileUploadEditor.md#addvalidationrule)
- [change](MultipleFileUploadEditor.md#change)
- [changeSelect2](MultipleFileUploadEditor.md#changeselect2)
- [destroy](MultipleFileUploadEditor.md#destroy)
- [getCssClass](MultipleFileUploadEditor.md#getcssclass)
- [getEditValue](MultipleFileUploadEditor.md#geteditvalue)
- [getGridField](MultipleFileUploadEditor.md#getgridfield)
- [getToolButtons](MultipleFileUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](MultipleFileUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](MultipleFileUploadEditor.md#get_readonly)
- [get\_required](MultipleFileUploadEditor.md#get_required)
- [get\_value](MultipleFileUploadEditor.md#get_value)
- [init](MultipleFileUploadEditor.md#init)
- [initialize](MultipleFileUploadEditor.md#initialize)
- [populate](MultipleFileUploadEditor.md#populate)
- [renderContents](MultipleFileUploadEditor.md#rendercontents)
- [setEditValue](MultipleFileUploadEditor.md#seteditvalue)
- [set\_readOnly](MultipleFileUploadEditor.md#set_readonly)
- [set\_required](MultipleFileUploadEditor.md#set_required)
- [set\_value](MultipleFileUploadEditor.md#set_value)
- [updateInterface](MultipleFileUploadEditor.md#updateinterface)
- [create](MultipleFileUploadEditor.md#create)
- [elementFor](MultipleFileUploadEditor.md#elementfor)
- [getWidgetName](MultipleFileUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new MultipleFileUploadEditor**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) |

#### Overrides

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L291)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](Widget.md).[element](Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### entities

• `Private` **entities**: [`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Defined in

[src/ui/editors/uploadeditors.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L284)

___

### fileSymbols

• `Private` **fileSymbols**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L286)

___

### hiddenInput

• `Protected` **hiddenInput**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L289)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](Widget.md).[idPrefix](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### jsonEncodeValue

• **jsonEncodeValue**: `boolean`

#### Defined in

[src/ui/editors/uploadeditors.ts:473](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L473)

___

### options

• `Protected` **options**: [`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md)

#### Inherited from

[Widget](Widget.md).[options](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### progress

• `Protected` **progress**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L288)

___

### toolbar

• `Private` **toolbar**: [`Toolbar`](Toolbar.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L285)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](Widget.md).[uniqueName](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### uploadInput

• `Private` **uploadInput**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:287](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L287)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](Widget.md).[widgetName](Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### value

• `get` **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Defined in

[src/ui/editors/uploadeditors.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L428)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | [`UploadedFile`](../interfaces/UploadedFile.md)[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:440](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L440)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addCssClass](Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addFileButtonText

▸ `Protected` **addFileButtonText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/uploadeditors.ts:347](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L347)

___

### addValidationRule

▸ **addValidationRule**(`eventClass`, `rule`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `eventClass` | `string` |
| `rule` | (`p1`: `JQuery`) => `string` |

#### Returns

`JQuery`

#### Inherited from

[Widget](Widget.md).[addValidationRule](Widget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[change](Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[change](Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L259)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[destroy](Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](Widget.md).[getCssClass](Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getEditValue

▸ **getEditValue**(`property`, `target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `property` | [`PropertyItem`](../interfaces/PropertyItem.md) |
| `target` | `any` |

#### Returns

`void`

#### Implementation of

[IGetEditValue](IGetEditValue.md).[getEditValue](IGetEditValue.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L444)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](Widget.md).[getGridField](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getToolButtons

▸ `Protected` **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Defined in

[src/ui/editors/uploadeditors.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L351)

___

### getUploadInputOptions

▸ `Protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L318)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:389](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L389)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IValidateRequired](IValidateRequired.md).[get_required](IValidateRequired.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L414)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Defined in

[src/ui/editors/uploadeditors.ts:422](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L422)

___

### init

▸ **init**(`action?`): [`MultipleFileUploadEditor`](MultipleFileUploadEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md)

#### Inherited from

[Widget](Widget.md).[init](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[initialize](Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### populate

▸ `Protected` **populate**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L361)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[renderContents](Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### setEditValue

▸ **setEditValue**(`source`, `property`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | `any` |
| `property` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`void`

#### Implementation of

[ISetEditValue](ISetEditValue.md).[setEditValue](ISetEditValue.md#seteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L453)

___

### set\_readOnly

▸ **set_readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Implementation of

[IReadOnly](IReadOnly.md).[set_readOnly](IReadOnly.md#set_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L393)

___

### set\_required

▸ **set_required**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Implementation of

[IValidateRequired](IValidateRequired.md).[set_required](IValidateRequired.md#set_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:418](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L418)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`UploadedFile`](../interfaces/UploadedFile.md)[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L432)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L383)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[Widget](Widget.md).[create](Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

___

### elementFor

▸ `Static` **elementFor**<`TWidget`\>(`editorType`): `JQuery`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `editorType` | (...`args`: `any`[]) => `TWidget` |

#### Returns

`JQuery`

#### Inherited from

[Widget](Widget.md).[elementFor](Widget.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

___

### getWidgetName

▸ `Static` **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[Widget](Widget.md).[getWidgetName](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
