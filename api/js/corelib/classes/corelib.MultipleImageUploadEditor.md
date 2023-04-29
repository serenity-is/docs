[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / MultipleImageUploadEditor

# Class: MultipleImageUploadEditor

[corelib](../modules/corelib.md).MultipleImageUploadEditor

## Hierarchy

- [`MultipleFileUploadEditor`](corelib.MultipleFileUploadEditor.md)

  ↳ **`MultipleImageUploadEditor`**

## Table of contents

### Constructors

- [constructor](corelib.MultipleImageUploadEditor.md#constructor)

### Properties

- [element](corelib.MultipleImageUploadEditor.md#element)
- [hiddenInput](corelib.MultipleImageUploadEditor.md#hiddeninput)
- [idPrefix](corelib.MultipleImageUploadEditor.md#idprefix)
- [jsonEncodeValue](corelib.MultipleImageUploadEditor.md#jsonencodevalue)
- [options](corelib.MultipleImageUploadEditor.md#options)
- [progress](corelib.MultipleImageUploadEditor.md#progress)
- [uniqueName](corelib.MultipleImageUploadEditor.md#uniquename)
- [widgetName](corelib.MultipleImageUploadEditor.md#widgetname)

### Accessors

- [value](corelib.MultipleImageUploadEditor.md#value)

### Methods

- [addCssClass](corelib.MultipleImageUploadEditor.md#addcssclass)
- [addFileButtonText](corelib.MultipleImageUploadEditor.md#addfilebuttontext)
- [addValidationRule](corelib.MultipleImageUploadEditor.md#addvalidationrule)
- [change](corelib.MultipleImageUploadEditor.md#change)
- [changeSelect2](corelib.MultipleImageUploadEditor.md#changeselect2)
- [destroy](corelib.MultipleImageUploadEditor.md#destroy)
- [getCssClass](corelib.MultipleImageUploadEditor.md#getcssclass)
- [getEditValue](corelib.MultipleImageUploadEditor.md#geteditvalue)
- [getGridField](corelib.MultipleImageUploadEditor.md#getgridfield)
- [getToolButtons](corelib.MultipleImageUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](corelib.MultipleImageUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](corelib.MultipleImageUploadEditor.md#get_readonly)
- [get\_required](corelib.MultipleImageUploadEditor.md#get_required)
- [get\_value](corelib.MultipleImageUploadEditor.md#get_value)
- [init](corelib.MultipleImageUploadEditor.md#init)
- [initialize](corelib.MultipleImageUploadEditor.md#initialize)
- [populate](corelib.MultipleImageUploadEditor.md#populate)
- [renderContents](corelib.MultipleImageUploadEditor.md#rendercontents)
- [setEditValue](corelib.MultipleImageUploadEditor.md#seteditvalue)
- [set\_readOnly](corelib.MultipleImageUploadEditor.md#set_readonly)
- [set\_required](corelib.MultipleImageUploadEditor.md#set_required)
- [set\_value](corelib.MultipleImageUploadEditor.md#set_value)
- [updateInterface](corelib.MultipleImageUploadEditor.md#updateinterface)
- [create](corelib.MultipleImageUploadEditor.md#create)
- [elementFor](corelib.MultipleImageUploadEditor.md#elementfor)
- [getWidgetName](corelib.MultipleImageUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new MultipleImageUploadEditor**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`ImageUploadEditorOptions`](../interfaces/corelib.ImageUploadEditorOptions.md) |

#### Overrides

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[constructor](corelib.MultipleFileUploadEditor.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;478)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[element](corelib.MultipleFileUploadEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### hiddenInput

• `Protected` **hiddenInput**: `JQuery`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[hiddenInput](corelib.MultipleFileUploadEditor.md#hiddeninput)

#### Defined in

[src/ui/editors/uploadeditors.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;289)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[idPrefix](corelib.MultipleFileUploadEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### jsonEncodeValue

• **jsonEncodeValue**: `boolean`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[jsonEncodeValue](corelib.MultipleFileUploadEditor.md#jsonencodevalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:473](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;473)

___

### options

• `Protected` **options**: [`FileUploadEditorOptions`](../interfaces/corelib.FileUploadEditorOptions.md)

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[options](corelib.MultipleFileUploadEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### progress

• `Protected` **progress**: `JQuery`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[progress](corelib.MultipleFileUploadEditor.md#progress)

#### Defined in

[src/ui/editors/uploadeditors.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;288)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[uniqueName](corelib.MultipleFileUploadEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[widgetName](corelib.MultipleFileUploadEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

## Accessors

### value

• `get` **value**(): [`UploadedFile`](../interfaces/corelib.UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/corelib.UploadedFile.md)[]

#### Inherited from

MultipleFileUploadEditor.value

#### Defined in

[src/ui/editors/uploadeditors.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;428)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | [`UploadedFile`](../interfaces/corelib.UploadedFile.md)[] |

#### Returns

`void`

#### Inherited from

MultipleFileUploadEditor.value

#### Defined in

[src/ui/editors/uploadeditors.ts:440](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;440)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[addCssClass](corelib.MultipleFileUploadEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;100)

___

### addFileButtonText

▸ `Protected` **addFileButtonText**(): `string`

#### Returns

`string`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[addFileButtonText](corelib.MultipleFileUploadEditor.md#addfilebuttontext)

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

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[addValidationRule](corelib.MultipleFileUploadEditor.md#addvalidationrule)

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

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[change](corelib.MultipleFileUploadEditor.md#change)

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

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[change](corelib.MultipleFileUploadEditor.md#change)

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

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[changeSelect2](corelib.MultipleFileUploadEditor.md#changeselect2)

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

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[changeSelect2](corelib.MultipleFileUploadEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[destroy](corelib.MultipleFileUploadEditor.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[getCssClass](corelib.MultipleFileUploadEditor.md#getcssclass)

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

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[getEditValue](corelib.MultipleFileUploadEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;444)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[getGridField](corelib.MultipleFileUploadEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### getToolButtons

▸ `Protected` **getToolButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[getToolButtons](corelib.MultipleFileUploadEditor.md#gettoolbuttons)

#### Defined in

[src/ui/editors/uploadeditors.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;351)

___

### getUploadInputOptions

▸ `Protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/corelib.UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/corelib.UploadInputOptions.md)

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[getUploadInputOptions](corelib.MultipleFileUploadEditor.md#getuploadinputoptions)

#### Defined in

[src/ui/editors/uploadeditors.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;318)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[get_readOnly](corelib.MultipleFileUploadEditor.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:389](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;389)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[get_required](corelib.MultipleFileUploadEditor.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;414)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/corelib.UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/corelib.UploadedFile.md)[]

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[get_value](corelib.MultipleFileUploadEditor.md#get_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:422](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;422)

___

### init

▸ **init**(`action?`): [`MultipleImageUploadEditor`](corelib.MultipleImageUploadEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`MultipleImageUploadEditor`](corelib.MultipleImageUploadEditor.md)

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[init](corelib.MultipleFileUploadEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[initialize](corelib.MultipleFileUploadEditor.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### populate

▸ `Protected` **populate**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[populate](corelib.MultipleFileUploadEditor.md#populate)

#### Defined in

[src/ui/editors/uploadeditors.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;361)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[renderContents](corelib.MultipleFileUploadEditor.md#rendercontents)

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

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[setEditValue](corelib.MultipleFileUploadEditor.md#seteditvalue)

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

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[set_readOnly](corelib.MultipleFileUploadEditor.md#set_readonly)

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

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[set_required](corelib.MultipleFileUploadEditor.md#set_required)

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

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[set_value](corelib.MultipleFileUploadEditor.md#set_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;432)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[updateInterface](corelib.MultipleFileUploadEditor.md#updateinterface)

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

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[create](corelib.MultipleFileUploadEditor.md#create)

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

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[elementFor](corelib.MultipleFileUploadEditor.md#elementfor)

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

[MultipleFileUploadEditor](corelib.MultipleFileUploadEditor.md).[getWidgetName](corelib.MultipleFileUploadEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;124)
