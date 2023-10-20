[@serenity-is/corelib](../README.md) / FileUploadEditor

# Class: FileUploadEditor

## Hierarchy

- [`Widget`](Widget.md)<[`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md)\>

  ↳ **`FileUploadEditor`**

  ↳↳ [`ImageUploadEditor`](ImageUploadEditor.md)

## Implements

- [`IReadOnly`](IReadOnly.md)
- [`IGetEditValue`](IGetEditValue.md)
- [`ISetEditValue`](ISetEditValue.md)
- [`IValidateRequired`](IValidateRequired.md)

## Table of contents

### Constructors

- [constructor](FileUploadEditor.md#constructor)

### Properties

- [element](FileUploadEditor.md#element)
- [entity](FileUploadEditor.md#entity)
- [fileSymbols](FileUploadEditor.md#filesymbols)
- [hiddenInput](FileUploadEditor.md#hiddeninput)
- [idPrefix](FileUploadEditor.md#idprefix)
- [options](FileUploadEditor.md#options)
- [progress](FileUploadEditor.md#progress)
- [toolbar](FileUploadEditor.md#toolbar)
- [uniqueName](FileUploadEditor.md#uniquename)
- [uploadInput](FileUploadEditor.md#uploadinput)
- [widgetName](FileUploadEditor.md#widgetname)

### Accessors

- [value](FileUploadEditor.md#value)

### Methods

- [addCssClass](FileUploadEditor.md#addcssclass)
- [addFileButtonText](FileUploadEditor.md#addfilebuttontext)
- [addValidationRule](FileUploadEditor.md#addvalidationrule)
- [change](FileUploadEditor.md#change)
- [changeSelect2](FileUploadEditor.md#changeselect2)
- [destroy](FileUploadEditor.md#destroy)
- [getCssClass](FileUploadEditor.md#getcssclass)
- [getEditValue](FileUploadEditor.md#geteditvalue)
- [getGridField](FileUploadEditor.md#getgridfield)
- [getToolButtons](FileUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](FileUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](FileUploadEditor.md#get_readonly)
- [get\_required](FileUploadEditor.md#get_required)
- [get\_value](FileUploadEditor.md#get_value)
- [init](FileUploadEditor.md#init)
- [initialize](FileUploadEditor.md#initialize)
- [populate](FileUploadEditor.md#populate)
- [renderContents](FileUploadEditor.md#rendercontents)
- [setEditValue](FileUploadEditor.md#seteditvalue)
- [set\_readOnly](FileUploadEditor.md#set_readonly)
- [set\_required](FileUploadEditor.md#set_required)
- [set\_value](FileUploadEditor.md#set_value)
- [updateInterface](FileUploadEditor.md#updateinterface)
- [create](FileUploadEditor.md#create)
- [elementFor](FileUploadEditor.md#elementfor)
- [getWidgetName](FileUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new FileUploadEditor**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md) |

#### Overrides

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L23)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](Widget.md).[element](Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### entity

• `Protected` **entity**: [`UploadedFile`](../interfaces/UploadedFile.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L259)

___

### fileSymbols

• `Protected` **fileSymbols**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L262)

___

### hiddenInput

• `Protected` **hiddenInput**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L264)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](Widget.md).[idPrefix](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

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

[src/ui/editors/uploadeditors.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L261)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L260)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](Widget.md).[uniqueName](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### uploadInput

• `Protected` **uploadInput**: `JQuery`

#### Defined in

[src/ui/editors/uploadeditors.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L263)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](Widget.md).[widgetName](Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### value

• `get` **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L185)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | [`UploadedFile`](../interfaces/UploadedFile.md) |

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L227)

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

[src/ui/editors/uploadeditors.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L87)

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

[src/ui/editors/uploadeditors.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L231)

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

[src/ui/editors/uploadeditors.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L91)

___

### getUploadInputOptions

▸ `Protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L57)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L144)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IValidateRequired](IValidateRequired.md).[get_required](IValidateRequired.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L169)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L177)

___

### init

▸ **init**(`action?`): [`FileUploadEditor`](FileUploadEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`FileUploadEditor`](FileUploadEditor.md)

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

[src/ui/editors/uploadeditors.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L119)

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

[src/ui/editors/uploadeditors.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L236)

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

[src/ui/editors/uploadeditors.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L148)

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

[src/ui/editors/uploadeditors.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L173)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`UploadedFile`](../interfaces/UploadedFile.md) |

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L189)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L136)

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
