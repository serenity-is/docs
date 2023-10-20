[@serenity-is/corelib](../README.md) / MultipleImageUploadEditor

# Class: MultipleImageUploadEditor

## Hierarchy

- [`MultipleFileUploadEditor`](MultipleFileUploadEditor.md)

  ↳ **`MultipleImageUploadEditor`**

## Table of contents

### Constructors

- [constructor](MultipleImageUploadEditor.md#constructor)

### Properties

- [element](MultipleImageUploadEditor.md#element)
- [hiddenInput](MultipleImageUploadEditor.md#hiddeninput)
- [idPrefix](MultipleImageUploadEditor.md#idprefix)
- [jsonEncodeValue](MultipleImageUploadEditor.md#jsonencodevalue)
- [options](MultipleImageUploadEditor.md#options)
- [progress](MultipleImageUploadEditor.md#progress)
- [uniqueName](MultipleImageUploadEditor.md#uniquename)
- [widgetName](MultipleImageUploadEditor.md#widgetname)

### Accessors

- [value](MultipleImageUploadEditor.md#value)

### Methods

- [addCssClass](MultipleImageUploadEditor.md#addcssclass)
- [addFileButtonText](MultipleImageUploadEditor.md#addfilebuttontext)
- [addValidationRule](MultipleImageUploadEditor.md#addvalidationrule)
- [change](MultipleImageUploadEditor.md#change)
- [changeSelect2](MultipleImageUploadEditor.md#changeselect2)
- [destroy](MultipleImageUploadEditor.md#destroy)
- [getCssClass](MultipleImageUploadEditor.md#getcssclass)
- [getEditValue](MultipleImageUploadEditor.md#geteditvalue)
- [getGridField](MultipleImageUploadEditor.md#getgridfield)
- [getToolButtons](MultipleImageUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](MultipleImageUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](MultipleImageUploadEditor.md#get_readonly)
- [get\_required](MultipleImageUploadEditor.md#get_required)
- [get\_value](MultipleImageUploadEditor.md#get_value)
- [init](MultipleImageUploadEditor.md#init)
- [initialize](MultipleImageUploadEditor.md#initialize)
- [populate](MultipleImageUploadEditor.md#populate)
- [renderContents](MultipleImageUploadEditor.md#rendercontents)
- [setEditValue](MultipleImageUploadEditor.md#seteditvalue)
- [set\_readOnly](MultipleImageUploadEditor.md#set_readonly)
- [set\_required](MultipleImageUploadEditor.md#set_required)
- [set\_value](MultipleImageUploadEditor.md#set_value)
- [updateInterface](MultipleImageUploadEditor.md#updateinterface)
- [create](MultipleImageUploadEditor.md#create)
- [elementFor](MultipleImageUploadEditor.md#elementfor)
- [getWidgetName](MultipleImageUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new MultipleImageUploadEditor**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) |

#### Overrides

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[constructor](MultipleFileUploadEditor.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L478)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[element](MultipleFileUploadEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### hiddenInput

• `Protected` **hiddenInput**: `JQuery`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[hiddenInput](MultipleFileUploadEditor.md#hiddeninput)

#### Defined in

[src/ui/editors/uploadeditors.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L289)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[idPrefix](MultipleFileUploadEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### jsonEncodeValue

• **jsonEncodeValue**: `boolean`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[jsonEncodeValue](MultipleFileUploadEditor.md#jsonencodevalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:473](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L473)

___

### options

• `Protected` **options**: [`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md)

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[options](MultipleFileUploadEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### progress

• `Protected` **progress**: `JQuery`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[progress](MultipleFileUploadEditor.md#progress)

#### Defined in

[src/ui/editors/uploadeditors.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L288)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[uniqueName](MultipleFileUploadEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[widgetName](MultipleFileUploadEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### value

• `get` **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Inherited from

MultipleFileUploadEditor.value

#### Defined in

[src/ui/editors/uploadeditors.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L428)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | [`UploadedFile`](../interfaces/UploadedFile.md)[] |

#### Returns

`void`

#### Inherited from

MultipleFileUploadEditor.value

#### Defined in

[src/ui/editors/uploadeditors.ts:440](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L440)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[addCssClass](MultipleFileUploadEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addFileButtonText

▸ `Protected` **addFileButtonText**(): `string`

#### Returns

`string`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[addFileButtonText](MultipleFileUploadEditor.md#addfilebuttontext)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[addValidationRule](MultipleFileUploadEditor.md#addvalidationrule)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[change](MultipleFileUploadEditor.md#change)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[change](MultipleFileUploadEditor.md#change)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[changeSelect2](MultipleFileUploadEditor.md#changeselect2)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[changeSelect2](MultipleFileUploadEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[destroy](MultipleFileUploadEditor.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getCssClass](MultipleFileUploadEditor.md#getcssclass)

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

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getEditValue](MultipleFileUploadEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L444)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getGridField](MultipleFileUploadEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getToolButtons

▸ `Protected` **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getToolButtons](MultipleFileUploadEditor.md#gettoolbuttons)

#### Defined in

[src/ui/editors/uploadeditors.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L351)

___

### getUploadInputOptions

▸ `Protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getUploadInputOptions](MultipleFileUploadEditor.md#getuploadinputoptions)

#### Defined in

[src/ui/editors/uploadeditors.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L318)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[get_readOnly](MultipleFileUploadEditor.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:389](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L389)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[get_required](MultipleFileUploadEditor.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L414)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[get_value](MultipleFileUploadEditor.md#get_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:422](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L422)

___

### init

▸ **init**(`action?`): [`MultipleImageUploadEditor`](MultipleImageUploadEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`MultipleImageUploadEditor`](MultipleImageUploadEditor.md)

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[init](MultipleFileUploadEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[initialize](MultipleFileUploadEditor.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### populate

▸ `Protected` **populate**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[populate](MultipleFileUploadEditor.md#populate)

#### Defined in

[src/ui/editors/uploadeditors.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L361)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[renderContents](MultipleFileUploadEditor.md#rendercontents)

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

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[setEditValue](MultipleFileUploadEditor.md#seteditvalue)

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

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[set_readOnly](MultipleFileUploadEditor.md#set_readonly)

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

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[set_required](MultipleFileUploadEditor.md#set_required)

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

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[set_value](MultipleFileUploadEditor.md#set_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L432)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[updateInterface](MultipleFileUploadEditor.md#updateinterface)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[create](MultipleFileUploadEditor.md#create)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[elementFor](MultipleFileUploadEditor.md#elementfor)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getWidgetName](MultipleFileUploadEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
