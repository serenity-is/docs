[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / FileUploadEditor

# Class: FileUploadEditor

[corelib](../modules/corelib.md).FileUploadEditor

## Hierarchy

- [`Widget`](corelib.Widget.md)<[`FileUploadEditorOptions`](../interfaces/corelib.FileUploadEditorOptions.md)\>

  ↳ **`FileUploadEditor`**

  ↳↳ [`ImageUploadEditor`](corelib.ImageUploadEditor.md)

## Implements

- [`IReadOnly`](corelib.IReadOnly.md)
- [`IGetEditValue`](corelib.IGetEditValue.md)
- [`ISetEditValue`](corelib.ISetEditValue.md)
- [`IValidateRequired`](corelib.IValidateRequired.md)

## Table of contents

### Constructors

- [constructor](corelib.FileUploadEditor.md#constructor)

### Properties

- [element](corelib.FileUploadEditor.md#element)
- [entity](corelib.FileUploadEditor.md#entity)
- [fileSymbols](corelib.FileUploadEditor.md#filesymbols)
- [hiddenInput](corelib.FileUploadEditor.md#hiddeninput)
- [idPrefix](corelib.FileUploadEditor.md#idprefix)
- [options](corelib.FileUploadEditor.md#options)
- [progress](corelib.FileUploadEditor.md#progress)
- [toolbar](corelib.FileUploadEditor.md#toolbar)
- [uniqueName](corelib.FileUploadEditor.md#uniquename)
- [uploadInput](corelib.FileUploadEditor.md#uploadinput)
- [widgetName](corelib.FileUploadEditor.md#widgetname)

### Accessors

- [value](corelib.FileUploadEditor.md#value)

### Methods

- [addCssClass](corelib.FileUploadEditor.md#addcssclass)
- [addFileButtonText](corelib.FileUploadEditor.md#addfilebuttontext)
- [addValidationRule](corelib.FileUploadEditor.md#addvalidationrule)
- [change](corelib.FileUploadEditor.md#change)
- [changeSelect2](corelib.FileUploadEditor.md#changeselect2)
- [destroy](corelib.FileUploadEditor.md#destroy)
- [getCssClass](corelib.FileUploadEditor.md#getcssclass)
- [getEditValue](corelib.FileUploadEditor.md#geteditvalue)
- [getGridField](corelib.FileUploadEditor.md#getgridfield)
- [getToolButtons](corelib.FileUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](corelib.FileUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](corelib.FileUploadEditor.md#get_readonly)
- [get\_required](corelib.FileUploadEditor.md#get_required)
- [get\_value](corelib.FileUploadEditor.md#get_value)
- [init](corelib.FileUploadEditor.md#init)
- [initialize](corelib.FileUploadEditor.md#initialize)
- [populate](corelib.FileUploadEditor.md#populate)
- [renderContents](corelib.FileUploadEditor.md#rendercontents)
- [setEditValue](corelib.FileUploadEditor.md#seteditvalue)
- [set\_readOnly](corelib.FileUploadEditor.md#set_readonly)
- [set\_required](corelib.FileUploadEditor.md#set_required)
- [set\_value](corelib.FileUploadEditor.md#set_value)
- [updateInterface](corelib.FileUploadEditor.md#updateinterface)
- [create](corelib.FileUploadEditor.md#create)
- [elementFor](corelib.FileUploadEditor.md#elementfor)
- [getWidgetName](corelib.FileUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new FileUploadEditor**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`FileUploadEditorOptions`](../interfaces/corelib.FileUploadEditorOptions.md) |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;23)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[element](corelib.Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### entity

• `Protected` **entity**: [`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;259)

___

### fileSymbols

• `Protected` **fileSymbols**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;262)

___

### hiddenInput

• `Protected` **hiddenInput**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;264)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[idPrefix](corelib.Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

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

[src/ui/editors/uploadeditors.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;261)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;260)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[uniqueName](corelib.Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### uploadInput

• `Protected` **uploadInput**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;263)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[widgetName](corelib.Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

## Accessors

### value

• `get` **value**(): [`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;185)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | [`UploadedFile`](../interfaces/corelib.UploadedFile.md) |

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;227)

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

[src/ui/editors/uploadeditors.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;87)

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

[src/ui/editors/uploadeditors.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;231)

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

[src/ui/editors/uploadeditors.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;91)

___

### getUploadInputOptions

▸ `Protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/corelib.UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/corelib.UploadInputOptions.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;57)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](corelib.IReadOnly.md).[get_readOnly](corelib.IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;144)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IValidateRequired](corelib.IValidateRequired.md).[get_required](corelib.IValidateRequired.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;169)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;177)

___

### init

▸ **init**(`action?`): [`FileUploadEditor`](corelib.FileUploadEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`FileUploadEditor`](corelib.FileUploadEditor.md)

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

[src/ui/editors/uploadeditors.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;119)

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

[src/ui/editors/uploadeditors.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;236)

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

[src/ui/editors/uploadeditors.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;148)

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

[src/ui/editors/uploadeditors.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;173)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`UploadedFile`](../interfaces/corelib.UploadedFile.md) |

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;189)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#line&#x3D;136)

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
