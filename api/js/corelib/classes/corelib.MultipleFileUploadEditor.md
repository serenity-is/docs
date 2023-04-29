[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / MultipleFileUploadEditor

# Class: MultipleFileUploadEditor

[corelib](../modules/corelib.md).MultipleFileUploadEditor

## Hierarchy

- [`Widget`](corelib.Widget.md)<[`FileUploadEditorOptions`](../interfaces/corelib.FileUploadEditorOptions.md)\>

  ↳ **`MultipleFileUploadEditor`**

  ↳↳ [`MultipleImageUploadEditor`](corelib.MultipleImageUploadEditor.md)

## Implements

- [`IReadOnly`](corelib.IReadOnly.md)
- [`IGetEditValue`](corelib.IGetEditValue.md)
- [`ISetEditValue`](corelib.ISetEditValue.md)
- [`IValidateRequired`](corelib.IValidateRequired.md)

## Table of contents

### Constructors

- [constructor](corelib.MultipleFileUploadEditor.md#constructor)

### Properties

- [element](corelib.MultipleFileUploadEditor.md#element)
- [entities](corelib.MultipleFileUploadEditor.md#entities)
- [fileSymbols](corelib.MultipleFileUploadEditor.md#filesymbols)
- [hiddenInput](corelib.MultipleFileUploadEditor.md#hiddeninput)
- [idPrefix](corelib.MultipleFileUploadEditor.md#idprefix)
- [jsonEncodeValue](corelib.MultipleFileUploadEditor.md#jsonencodevalue)
- [options](corelib.MultipleFileUploadEditor.md#options)
- [progress](corelib.MultipleFileUploadEditor.md#progress)
- [toolbar](corelib.MultipleFileUploadEditor.md#toolbar)
- [uniqueName](corelib.MultipleFileUploadEditor.md#uniquename)
- [uploadInput](corelib.MultipleFileUploadEditor.md#uploadinput)
- [widgetName](corelib.MultipleFileUploadEditor.md#widgetname)

### Accessors

- [value](corelib.MultipleFileUploadEditor.md#value)

### Methods

- [addCssClass](corelib.MultipleFileUploadEditor.md#addcssclass)
- [addFileButtonText](corelib.MultipleFileUploadEditor.md#addfilebuttontext)
- [addValidationRule](corelib.MultipleFileUploadEditor.md#addvalidationrule)
- [change](corelib.MultipleFileUploadEditor.md#change)
- [changeSelect2](corelib.MultipleFileUploadEditor.md#changeselect2)
- [destroy](corelib.MultipleFileUploadEditor.md#destroy)
- [getCssClass](corelib.MultipleFileUploadEditor.md#getcssclass)
- [getEditValue](corelib.MultipleFileUploadEditor.md#geteditvalue)
- [getGridField](corelib.MultipleFileUploadEditor.md#getgridfield)
- [getToolButtons](corelib.MultipleFileUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](corelib.MultipleFileUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](corelib.MultipleFileUploadEditor.md#get_readonly)
- [get\_required](corelib.MultipleFileUploadEditor.md#get_required)
- [get\_value](corelib.MultipleFileUploadEditor.md#get_value)
- [init](corelib.MultipleFileUploadEditor.md#init)
- [initialize](corelib.MultipleFileUploadEditor.md#initialize)
- [populate](corelib.MultipleFileUploadEditor.md#populate)
- [renderContents](corelib.MultipleFileUploadEditor.md#rendercontents)
- [setEditValue](corelib.MultipleFileUploadEditor.md#seteditvalue)
- [set\_readOnly](corelib.MultipleFileUploadEditor.md#set_readonly)
- [set\_required](corelib.MultipleFileUploadEditor.md#set_required)
- [set\_value](corelib.MultipleFileUploadEditor.md#set_value)
- [updateInterface](corelib.MultipleFileUploadEditor.md#updateinterface)
- [create](corelib.MultipleFileUploadEditor.md#create)
- [elementFor](corelib.MultipleFileUploadEditor.md#elementfor)
- [getWidgetName](corelib.MultipleFileUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new MultipleFileUploadEditor**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`ImageUploadEditorOptions`](../interfaces/corelib.ImageUploadEditorOptions.md) |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;291)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[element](corelib.Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### entities

• `Private` **entities**: [`UploadedFile`](../interfaces/corelib.UploadedFile.md)[]

#### Defined in

[src/ui/editors/uploadeditors.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;284)

___

### fileSymbols

• `Private` **fileSymbols**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;286)

___

### hiddenInput

• `Protected` **hiddenInput**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;289)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[idPrefix](corelib.Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### jsonEncodeValue

• **jsonEncodeValue**: `boolean`

#### Defined in

[src/ui/editors/uploadeditors.ts:473](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;473)

___

### options

• `Protected` **options**: [`FileUploadEditorOptions`](../interfaces/corelib.FileUploadEditorOptions.md)

#### Inherited from

[Widget](corelib.Widget.md).[options](corelib.Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### progress

• `Protected` **progress**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;288)

___

### toolbar

• `Private` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;285)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[uniqueName](corelib.Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### uploadInput

• `Private` **uploadInput**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:287](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;287)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[widgetName](corelib.Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

## Accessors

### value

• `get` **value**(): [`UploadedFile`](../interfaces/corelib.UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/corelib.UploadedFile.md)[]

#### Defined in

[src/ui/editors/uploadeditors.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;428)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | [`UploadedFile`](../interfaces/corelib.UploadedFile.md)[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:440](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;440)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[addCssClass](corelib.Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;100)

___

### addFileButtonText

▸ `Protected` **addFileButtonText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/uploadeditors.ts:347](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;347)

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

[Widget](corelib.Widget.md).[addValidationRule](corelib.Widget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;134)

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

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;259)

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

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](corelib.Widget.md).[getCssClass](corelib.Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;104)

___

### getEditValue

▸ **getEditValue**(`property`, `target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `property` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |
| `target` | `any` |

#### Returns

`void`

#### Implementation of

[IGetEditValue](corelib.IGetEditValue.md).[getEditValue](corelib.IGetEditValue.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;444)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[getGridField](corelib.Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### getToolButtons

▸ `Protected` **getToolButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Defined in

[src/ui/editors/uploadeditors.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;351)

___

### getUploadInputOptions

▸ `Protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/corelib.UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/corelib.UploadInputOptions.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;318)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](corelib.IReadOnly.md).[get_readOnly](corelib.IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:389](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;389)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IValidateRequired](corelib.IValidateRequired.md).[get_required](corelib.IValidateRequired.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;414)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/corelib.UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/corelib.UploadedFile.md)[]

#### Defined in

[src/ui/editors/uploadeditors.ts:422](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;422)

___

### init

▸ **init**(`action?`): [`MultipleFileUploadEditor`](corelib.MultipleFileUploadEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`MultipleFileUploadEditor`](corelib.MultipleFileUploadEditor.md)

#### Inherited from

[Widget](corelib.Widget.md).[init](corelib.Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[initialize](corelib.Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### populate

▸ `Protected` **populate**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;361)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[renderContents](corelib.Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;184)

___

### setEditValue

▸ **setEditValue**(`source`, `property`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | `any` |
| `property` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`void`

#### Implementation of

[ISetEditValue](corelib.ISetEditValue.md).[setEditValue](corelib.ISetEditValue.md#seteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;453)

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

[IReadOnly](corelib.IReadOnly.md).[set_readOnly](corelib.IReadOnly.md#set_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;393)

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

[IValidateRequired](corelib.IValidateRequired.md).[set_required](corelib.IValidateRequired.md#set_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:418](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;418)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`UploadedFile`](../interfaces/corelib.UploadedFile.md)[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;432)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;383)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](corelib.Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/corelib.CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[Widget](corelib.Widget.md).[create](corelib.Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;153)

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

[Widget](corelib.Widget.md).[elementFor](corelib.Widget.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;128)

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

[Widget](corelib.Widget.md).[getWidgetName](corelib.Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;124)
