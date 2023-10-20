[@serenity-is/corelib](../README.md) / ImageUploadEditor

# Class: ImageUploadEditor

## Hierarchy

- [`FileUploadEditor`](FileUploadEditor.md)

  ↳ **`ImageUploadEditor`**

## Table of contents

### Constructors

- [constructor](ImageUploadEditor.md#constructor)

### Properties

- [element](ImageUploadEditor.md#element)
- [entity](ImageUploadEditor.md#entity)
- [fileSymbols](ImageUploadEditor.md#filesymbols)
- [hiddenInput](ImageUploadEditor.md#hiddeninput)
- [idPrefix](ImageUploadEditor.md#idprefix)
- [options](ImageUploadEditor.md#options)
- [progress](ImageUploadEditor.md#progress)
- [toolbar](ImageUploadEditor.md#toolbar)
- [uniqueName](ImageUploadEditor.md#uniquename)
- [uploadInput](ImageUploadEditor.md#uploadinput)
- [widgetName](ImageUploadEditor.md#widgetname)

### Accessors

- [value](ImageUploadEditor.md#value)

### Methods

- [addCssClass](ImageUploadEditor.md#addcssclass)
- [addFileButtonText](ImageUploadEditor.md#addfilebuttontext)
- [addValidationRule](ImageUploadEditor.md#addvalidationrule)
- [change](ImageUploadEditor.md#change)
- [changeSelect2](ImageUploadEditor.md#changeselect2)
- [destroy](ImageUploadEditor.md#destroy)
- [getCssClass](ImageUploadEditor.md#getcssclass)
- [getEditValue](ImageUploadEditor.md#geteditvalue)
- [getGridField](ImageUploadEditor.md#getgridfield)
- [getToolButtons](ImageUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](ImageUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](ImageUploadEditor.md#get_readonly)
- [get\_required](ImageUploadEditor.md#get_required)
- [get\_value](ImageUploadEditor.md#get_value)
- [init](ImageUploadEditor.md#init)
- [initialize](ImageUploadEditor.md#initialize)
- [populate](ImageUploadEditor.md#populate)
- [renderContents](ImageUploadEditor.md#rendercontents)
- [setEditValue](ImageUploadEditor.md#seteditvalue)
- [set\_readOnly](ImageUploadEditor.md#set_readonly)
- [set\_required](ImageUploadEditor.md#set_required)
- [set\_value](ImageUploadEditor.md#set_value)
- [updateInterface](ImageUploadEditor.md#updateinterface)
- [create](ImageUploadEditor.md#create)
- [elementFor](ImageUploadEditor.md#elementfor)
- [getWidgetName](ImageUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new ImageUploadEditor**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) |

#### Overrides

[FileUploadEditor](FileUploadEditor.md).[constructor](FileUploadEditor.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L269)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[element](FileUploadEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### entity

• `Protected` **entity**: [`UploadedFile`](../interfaces/UploadedFile.md)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[entity](FileUploadEditor.md#entity)

#### Defined in

[src/ui/editors/uploadeditors.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L259)

___

### fileSymbols

• `Protected` **fileSymbols**: `JQuery`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[fileSymbols](FileUploadEditor.md#filesymbols)

#### Defined in

[src/ui/editors/uploadeditors.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L262)

___

### hiddenInput

• `Protected` **hiddenInput**: `JQuery`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[hiddenInput](FileUploadEditor.md#hiddeninput)

#### Defined in

[src/ui/editors/uploadeditors.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L264)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[idPrefix](FileUploadEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: [`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[options](FileUploadEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### progress

• `Protected` **progress**: `JQuery`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[progress](FileUploadEditor.md#progress)

#### Defined in

[src/ui/editors/uploadeditors.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L261)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[toolbar](FileUploadEditor.md#toolbar)

#### Defined in

[src/ui/editors/uploadeditors.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L260)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[uniqueName](FileUploadEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### uploadInput

• `Protected` **uploadInput**: `JQuery`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[uploadInput](FileUploadEditor.md#uploadinput)

#### Defined in

[src/ui/editors/uploadeditors.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L263)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[widgetName](FileUploadEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### value

• `get` **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Inherited from

FileUploadEditor.value

#### Defined in

[src/ui/editors/uploadeditors.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L185)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | [`UploadedFile`](../interfaces/UploadedFile.md) |

#### Returns

`void`

#### Inherited from

FileUploadEditor.value

#### Defined in

[src/ui/editors/uploadeditors.ts:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L227)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[addCssClass](FileUploadEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addFileButtonText

▸ `Protected` **addFileButtonText**(): `string`

#### Returns

`string`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[addFileButtonText](FileUploadEditor.md#addfilebuttontext)

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

[FileUploadEditor](FileUploadEditor.md).[addValidationRule](FileUploadEditor.md#addvalidationrule)

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

[FileUploadEditor](FileUploadEditor.md).[change](FileUploadEditor.md#change)

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

[FileUploadEditor](FileUploadEditor.md).[change](FileUploadEditor.md#change)

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

[FileUploadEditor](FileUploadEditor.md).[changeSelect2](FileUploadEditor.md#changeselect2)

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

[FileUploadEditor](FileUploadEditor.md).[changeSelect2](FileUploadEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[destroy](FileUploadEditor.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getCssClass](FileUploadEditor.md#getcssclass)

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

[FileUploadEditor](FileUploadEditor.md).[getEditValue](FileUploadEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L231)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getGridField](FileUploadEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getToolButtons

▸ `Protected` **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getToolButtons](FileUploadEditor.md#gettoolbuttons)

#### Defined in

[src/ui/editors/uploadeditors.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L91)

___

### getUploadInputOptions

▸ `Protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getUploadInputOptions](FileUploadEditor.md#getuploadinputoptions)

#### Defined in

[src/ui/editors/uploadeditors.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L57)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[get_readOnly](FileUploadEditor.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L144)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[get_required](FileUploadEditor.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L169)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[get_value](FileUploadEditor.md#get_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L177)

___

### init

▸ **init**(`action?`): [`ImageUploadEditor`](ImageUploadEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`ImageUploadEditor`](ImageUploadEditor.md)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[init](FileUploadEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[initialize](FileUploadEditor.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### populate

▸ `Protected` **populate**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[populate](FileUploadEditor.md#populate)

#### Defined in

[src/ui/editors/uploadeditors.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L119)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[renderContents](FileUploadEditor.md#rendercontents)

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

[FileUploadEditor](FileUploadEditor.md).[setEditValue](FileUploadEditor.md#seteditvalue)

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

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[set_readOnly](FileUploadEditor.md#set_readonly)

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

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[set_required](FileUploadEditor.md#set_required)

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

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[set_value](FileUploadEditor.md#set_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L189)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[updateInterface](FileUploadEditor.md#updateinterface)

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

[FileUploadEditor](FileUploadEditor.md).[create](FileUploadEditor.md#create)

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

[FileUploadEditor](FileUploadEditor.md).[elementFor](FileUploadEditor.md#elementfor)

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

[FileUploadEditor](FileUploadEditor.md).[getWidgetName](FileUploadEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
