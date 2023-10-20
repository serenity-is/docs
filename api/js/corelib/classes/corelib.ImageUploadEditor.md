[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / ImageUploadEditor

# Class: ImageUploadEditor

[corelib](../modules/corelib.md).ImageUploadEditor

## Hierarchy

- [`FileUploadEditor`](corelib.FileUploadEditor.md)

  ↳ **`ImageUploadEditor`**

## Table of contents

### Constructors

- [constructor](corelib.ImageUploadEditor.md#constructor)

### Properties

- [element](corelib.ImageUploadEditor.md#element)
- [entity](corelib.ImageUploadEditor.md#entity)
- [fileSymbols](corelib.ImageUploadEditor.md#filesymbols)
- [hiddenInput](corelib.ImageUploadEditor.md#hiddeninput)
- [idPrefix](corelib.ImageUploadEditor.md#idprefix)
- [options](corelib.ImageUploadEditor.md#options)
- [progress](corelib.ImageUploadEditor.md#progress)
- [toolbar](corelib.ImageUploadEditor.md#toolbar)
- [uniqueName](corelib.ImageUploadEditor.md#uniquename)
- [uploadInput](corelib.ImageUploadEditor.md#uploadinput)
- [widgetName](corelib.ImageUploadEditor.md#widgetname)

### Accessors

- [value](corelib.ImageUploadEditor.md#value)

### Methods

- [addCssClass](corelib.ImageUploadEditor.md#addcssclass)
- [addFileButtonText](corelib.ImageUploadEditor.md#addfilebuttontext)
- [addValidationRule](corelib.ImageUploadEditor.md#addvalidationrule)
- [change](corelib.ImageUploadEditor.md#change)
- [changeSelect2](corelib.ImageUploadEditor.md#changeselect2)
- [destroy](corelib.ImageUploadEditor.md#destroy)
- [getCssClass](corelib.ImageUploadEditor.md#getcssclass)
- [getEditValue](corelib.ImageUploadEditor.md#geteditvalue)
- [getGridField](corelib.ImageUploadEditor.md#getgridfield)
- [getToolButtons](corelib.ImageUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](corelib.ImageUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](corelib.ImageUploadEditor.md#get_readonly)
- [get\_required](corelib.ImageUploadEditor.md#get_required)
- [get\_value](corelib.ImageUploadEditor.md#get_value)
- [init](corelib.ImageUploadEditor.md#init)
- [initialize](corelib.ImageUploadEditor.md#initialize)
- [populate](corelib.ImageUploadEditor.md#populate)
- [renderContents](corelib.ImageUploadEditor.md#rendercontents)
- [setEditValue](corelib.ImageUploadEditor.md#seteditvalue)
- [set\_readOnly](corelib.ImageUploadEditor.md#set_readonly)
- [set\_required](corelib.ImageUploadEditor.md#set_required)
- [set\_value](corelib.ImageUploadEditor.md#set_value)
- [updateInterface](corelib.ImageUploadEditor.md#updateinterface)
- [create](corelib.ImageUploadEditor.md#create)
- [elementFor](corelib.ImageUploadEditor.md#elementfor)
- [getWidgetName](corelib.ImageUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new ImageUploadEditor**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`ImageUploadEditorOptions`](../interfaces/corelib.ImageUploadEditorOptions.md) |

#### Overrides

[FileUploadEditor](corelib.FileUploadEditor.md).[constructor](corelib.FileUploadEditor.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L269)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[element](corelib.FileUploadEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### entity

• `Protected` **entity**: [`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[entity](corelib.FileUploadEditor.md#entity)

#### Defined in

[src/ui/editors/uploadeditors.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L259)

___

### fileSymbols

• `Protected` **fileSymbols**: `JQuery`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[fileSymbols](corelib.FileUploadEditor.md#filesymbols)

#### Defined in

[src/ui/editors/uploadeditors.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L262)

___

### hiddenInput

• `Protected` **hiddenInput**: `JQuery`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[hiddenInput](corelib.FileUploadEditor.md#hiddeninput)

#### Defined in

[src/ui/editors/uploadeditors.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L264)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[idPrefix](corelib.FileUploadEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: [`FileUploadEditorOptions`](../interfaces/corelib.FileUploadEditorOptions.md)

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[options](corelib.FileUploadEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### progress

• `Protected` **progress**: `JQuery`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[progress](corelib.FileUploadEditor.md#progress)

#### Defined in

[src/ui/editors/uploadeditors.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L261)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[toolbar](corelib.FileUploadEditor.md#toolbar)

#### Defined in

[src/ui/editors/uploadeditors.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L260)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[uniqueName](corelib.FileUploadEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### uploadInput

• `Protected` **uploadInput**: `JQuery`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[uploadInput](corelib.FileUploadEditor.md#uploadinput)

#### Defined in

[src/ui/editors/uploadeditors.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L263)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[widgetName](corelib.FileUploadEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### value

• `get` **value**(): [`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Inherited from

FileUploadEditor.value

#### Defined in

[src/ui/editors/uploadeditors.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L185)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | [`UploadedFile`](../interfaces/corelib.UploadedFile.md) |

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

[FileUploadEditor](corelib.FileUploadEditor.md).[addCssClass](corelib.FileUploadEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addFileButtonText

▸ `Protected` **addFileButtonText**(): `string`

#### Returns

`string`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[addFileButtonText](corelib.FileUploadEditor.md#addfilebuttontext)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[addValidationRule](corelib.FileUploadEditor.md#addvalidationrule)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[change](corelib.FileUploadEditor.md#change)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[change](corelib.FileUploadEditor.md#change)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[changeSelect2](corelib.FileUploadEditor.md#changeselect2)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[changeSelect2](corelib.FileUploadEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[destroy](corelib.FileUploadEditor.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[getCssClass](corelib.FileUploadEditor.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getEditValue

▸ **getEditValue**(`property`, `target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `property` | [`PropertyItem`](../interfaces/q.PropertyItem.md) |
| `target` | `any` |

#### Returns

`void`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[getEditValue](corelib.FileUploadEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L231)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[getGridField](corelib.FileUploadEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getToolButtons

▸ `Protected` **getToolButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[getToolButtons](corelib.FileUploadEditor.md#gettoolbuttons)

#### Defined in

[src/ui/editors/uploadeditors.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L91)

___

### getUploadInputOptions

▸ `Protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/corelib.UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/corelib.UploadInputOptions.md)

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[getUploadInputOptions](corelib.FileUploadEditor.md#getuploadinputoptions)

#### Defined in

[src/ui/editors/uploadeditors.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L57)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[get_readOnly](corelib.FileUploadEditor.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L144)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[get_required](corelib.FileUploadEditor.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L169)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/corelib.UploadedFile.md)

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[get_value](corelib.FileUploadEditor.md#get_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L177)

___

### init

▸ **init**(`action?`): [`ImageUploadEditor`](corelib.ImageUploadEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`ImageUploadEditor`](corelib.ImageUploadEditor.md)

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[init](corelib.FileUploadEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[initialize](corelib.FileUploadEditor.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### populate

▸ `Protected` **populate**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[populate](corelib.FileUploadEditor.md#populate)

#### Defined in

[src/ui/editors/uploadeditors.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L119)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[renderContents](corelib.FileUploadEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### setEditValue

▸ **setEditValue**(`source`, `property`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | `any` |
| `property` | [`PropertyItem`](../interfaces/q.PropertyItem.md) |

#### Returns

`void`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[setEditValue](corelib.FileUploadEditor.md#seteditvalue)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[set_readOnly](corelib.FileUploadEditor.md#set_readonly)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[set_required](corelib.FileUploadEditor.md#set_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L173)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`UploadedFile`](../interfaces/corelib.UploadedFile.md) |

#### Returns

`void`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[set_value](corelib.FileUploadEditor.md#set_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L189)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](corelib.FileUploadEditor.md).[updateInterface](corelib.FileUploadEditor.md#updateinterface)

#### Defined in

[src/ui/editors/uploadeditors.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L136)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[create](corelib.FileUploadEditor.md#create)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[elementFor](corelib.FileUploadEditor.md#elementfor)

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

[FileUploadEditor](corelib.FileUploadEditor.md).[getWidgetName](corelib.FileUploadEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
