[@serenity-is/corelib](../README.md) / FileUploadEditor

# Class: FileUploadEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md) = [`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md) |

## Hierarchy

- [`EditorWidget`](EditorWidget.md)\<`P`\>

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

- [domNode](FileUploadEditor.md#domnode)
- [entity](FileUploadEditor.md#entity)
- [fileSymbols](FileUploadEditor.md#filesymbols)
- [hiddenInput](FileUploadEditor.md#hiddeninput)
- [idPrefix](FileUploadEditor.md#idprefix)
- [options](FileUploadEditor.md#options)
- [progress](FileUploadEditor.md#progress)
- [toolbar](FileUploadEditor.md#toolbar)
- [uniqueName](FileUploadEditor.md#uniquename)
- [uploadInput](FileUploadEditor.md#uploadinput)
- [typeInfo](FileUploadEditor.md#typeinfo)

### Accessors

- [element](FileUploadEditor.md#element)
- [props](FileUploadEditor.md#props)
- [value](FileUploadEditor.md#value)

### Methods

- [addCssClass](FileUploadEditor.md#addcssclass)
- [addFileButtonText](FileUploadEditor.md#addfilebuttontext)
- [addValidationRule](FileUploadEditor.md#addvalidationrule)
- [change](FileUploadEditor.md#change)
- [changeSelect2](FileUploadEditor.md#changeselect2)
- [destroy](FileUploadEditor.md#destroy)
- [getCssClass](FileUploadEditor.md#getcssclass)
- [getCustomAttribute](FileUploadEditor.md#getcustomattribute)
- [getEditValue](FileUploadEditor.md#geteditvalue)
- [getFieldElement](FileUploadEditor.md#getfieldelement)
- [getGridField](FileUploadEditor.md#getgridfield)
- [getToolButtons](FileUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](FileUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](FileUploadEditor.md#get_readonly)
- [get\_required](FileUploadEditor.md#get_required)
- [get\_value](FileUploadEditor.md#get_value)
- [init](FileUploadEditor.md#init)
- [internalInit](FileUploadEditor.md#internalinit)
- [internalRenderContents](FileUploadEditor.md#internalrendercontents)
- [populate](FileUploadEditor.md#populate)
- [render](FileUploadEditor.md#render)
- [renderContents](FileUploadEditor.md#rendercontents)
- [setEditValue](FileUploadEditor.md#seteditvalue)
- [set\_readOnly](FileUploadEditor.md#set_readonly)
- [set\_required](FileUploadEditor.md#set_required)
- [set\_value](FileUploadEditor.md#set_value)
- [syncOrAsyncThen](FileUploadEditor.md#syncorasyncthen)
- [updateInterface](FileUploadEditor.md#updateinterface)
- [useIdPrefix](FileUploadEditor.md#useidprefix)
- [create](FileUploadEditor.md#create)
- [createDefaultElement](FileUploadEditor.md#createdefaultelement)
- [getWidgetName](FileUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new FileUploadEditor**\<`P`\>(`props`): [`FileUploadEditor`](FileUploadEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md) = [`FileUploadEditorOptions`](../interfaces/FileUploadEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`FileUploadEditor`](FileUploadEditor.md)\<`P`\>

#### Overrides

[EditorWidget](EditorWidget.md).[constructor](EditorWidget.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L23)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[EditorWidget](EditorWidget.md).[domNode](EditorWidget.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### entity

• `Protected` **entity**: [`UploadedFile`](../interfaces/UploadedFile.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L257)

___

### fileSymbols

• `Protected` **fileSymbols**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/editors/uploadeditors.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L260)

___

### hiddenInput

• `Protected` **hiddenInput**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/editors/uploadeditors.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L262)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[EditorWidget](EditorWidget.md).[idPrefix](EditorWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<[`EditorProps`](../README.md#editorprops)\<`P`\>\>

#### Inherited from

[EditorWidget](EditorWidget.md).[options](EditorWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### progress

• `Protected` **progress**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/editors/uploadeditors.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L259)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Defined in

[src/ui/editors/uploadeditors.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L258)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[EditorWidget](EditorWidget.md).[uniqueName](EditorWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### uploadInput

• `Protected` **uploadInput**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/editors/uploadeditors.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L261)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.EditorWidget"``\>

#### Inherited from

[EditorWidget](EditorWidget.md).[typeInfo](EditorWidget.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

EditorWidget.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

EditorWidget.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### value

• `get` **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L187)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | [`UploadedFile`](../interfaces/UploadedFile.md) |

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L226)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[addCssClass](EditorWidget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

___

### addFileButtonText

▸ **addFileButtonText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/uploadeditors.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L91)

___

### addValidationRule

▸ **addValidationRule**(`rule`, `uniqueName?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rule` | (`input`: `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement`) => `string` |
| `uniqueName?` | `string` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[addValidationRule](EditorWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

▸ **addValidationRule**(`uniqueName`, `rule`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `uniqueName` | `string` |
| `rule` | (`input`: `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement`) => `string` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[addValidationRule](EditorWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[change](EditorWidget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[changeSelect2](EditorWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[destroy](EditorWidget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L49)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[EditorWidget](EditorWidget.md).[getCssClass](EditorWidget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

___

### getCustomAttribute

▸ **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit?`): `TAttr`

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `attrType` | (...`args`: `any`[]) => `TAttr` | `undefined` |
| `inherit` | `boolean` | `true` |

#### Returns

`TAttr`

#### Inherited from

[EditorWidget](EditorWidget.md).[getCustomAttribute](EditorWidget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

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

[src/ui/editors/uploadeditors.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L230)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[EditorWidget](EditorWidget.md).[getFieldElement](EditorWidget.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[EditorWidget](EditorWidget.md).[getGridField](EditorWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getToolButtons

▸ **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Defined in

[src/ui/editors/uploadeditors.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L95)

___

### getUploadInputOptions

▸ **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L64)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L145)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IValidateRequired](IValidateRequired.md).[get_required](IValidateRequired.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L171)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Defined in

[src/ui/editors/uploadeditors.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L179)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[EditorWidget](EditorWidget.md).[init](EditorWidget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[internalInit](EditorWidget.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[internalRenderContents](EditorWidget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### populate

▸ **populate**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L120)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[EditorWidget](EditorWidget.md).[render](EditorWidget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[EditorWidget](EditorWidget.md).[renderContents](EditorWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L178)

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

[src/ui/editors/uploadeditors.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L234)

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

[src/ui/editors/uploadeditors.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L149)

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

[src/ui/editors/uploadeditors.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L175)

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

[src/ui/editors/uploadeditors.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L191)

___

### syncOrAsyncThen

▸ **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `syncMethod` | () => `T` |
| `asyncMethod` | () => `PromiseLike`\<`T`\> |
| `then` | (`v`: `T`) => `void` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[syncOrAsyncThen](EditorWidget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/uploadeditors.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L137)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[EditorWidget](EditorWidget.md).[useIdPrefix](EditorWidget.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### create

▸ **create**\<`TWidget`, `P`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\> |

#### Returns

`TWidget`

#### Inherited from

[EditorWidget](EditorWidget.md).[create](EditorWidget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[EditorWidget](EditorWidget.md).[createDefaultElement](EditorWidget.md#createdefaultelement)

#### Defined in

[src/ui/widgets/widget.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L60)

___

### getWidgetName

▸ **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[EditorWidget](EditorWidget.md).[getWidgetName](EditorWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
