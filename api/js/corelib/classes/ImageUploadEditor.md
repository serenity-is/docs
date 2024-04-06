[@serenity-is/corelib](../README.md) / ImageUploadEditor

# Class: ImageUploadEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) = [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) |

## Hierarchy

- [`FileUploadEditor`](FileUploadEditor.md)\<`P`\>

  ↳ **`ImageUploadEditor`**

## Table of contents

### Constructors

- [constructor](ImageUploadEditor.md#constructor)

### Properties

- [domNode](ImageUploadEditor.md#domnode)
- [entity](ImageUploadEditor.md#entity)
- [fileSymbols](ImageUploadEditor.md#filesymbols)
- [hiddenInput](ImageUploadEditor.md#hiddeninput)
- [idPrefix](ImageUploadEditor.md#idprefix)
- [options](ImageUploadEditor.md#options)
- [progress](ImageUploadEditor.md#progress)
- [toolbar](ImageUploadEditor.md#toolbar)
- [uniqueName](ImageUploadEditor.md#uniquename)
- [uploadInput](ImageUploadEditor.md#uploadinput)
- [typeInfo](ImageUploadEditor.md#typeinfo)

### Accessors

- [element](ImageUploadEditor.md#element)
- [props](ImageUploadEditor.md#props)
- [value](ImageUploadEditor.md#value)

### Methods

- [addCssClass](ImageUploadEditor.md#addcssclass)
- [addFileButtonText](ImageUploadEditor.md#addfilebuttontext)
- [addValidationRule](ImageUploadEditor.md#addvalidationrule)
- [change](ImageUploadEditor.md#change)
- [changeSelect2](ImageUploadEditor.md#changeselect2)
- [destroy](ImageUploadEditor.md#destroy)
- [getCssClass](ImageUploadEditor.md#getcssclass)
- [getCustomAttribute](ImageUploadEditor.md#getcustomattribute)
- [getEditValue](ImageUploadEditor.md#geteditvalue)
- [getFieldElement](ImageUploadEditor.md#getfieldelement)
- [getGridField](ImageUploadEditor.md#getgridfield)
- [getToolButtons](ImageUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](ImageUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](ImageUploadEditor.md#get_readonly)
- [get\_required](ImageUploadEditor.md#get_required)
- [get\_value](ImageUploadEditor.md#get_value)
- [init](ImageUploadEditor.md#init)
- [internalInit](ImageUploadEditor.md#internalinit)
- [internalRenderContents](ImageUploadEditor.md#internalrendercontents)
- [populate](ImageUploadEditor.md#populate)
- [render](ImageUploadEditor.md#render)
- [renderContents](ImageUploadEditor.md#rendercontents)
- [setEditValue](ImageUploadEditor.md#seteditvalue)
- [set\_readOnly](ImageUploadEditor.md#set_readonly)
- [set\_required](ImageUploadEditor.md#set_required)
- [set\_value](ImageUploadEditor.md#set_value)
- [syncOrAsyncThen](ImageUploadEditor.md#syncorasyncthen)
- [updateInterface](ImageUploadEditor.md#updateinterface)
- [useIdPrefix](ImageUploadEditor.md#useidprefix)
- [create](ImageUploadEditor.md#create)
- [createDefaultElement](ImageUploadEditor.md#createdefaultelement)
- [getWidgetName](ImageUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new ImageUploadEditor**\<`P`\>(`props`): [`ImageUploadEditor`](ImageUploadEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) = [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`ImageUploadEditor`](ImageUploadEditor.md)\<`P`\>

#### Overrides

[FileUploadEditor](FileUploadEditor.md).[constructor](FileUploadEditor.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L267)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[domNode](FileUploadEditor.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### entity

• `Protected` **entity**: [`UploadedFile`](../interfaces/UploadedFile.md)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[entity](FileUploadEditor.md#entity)

#### Defined in

[src/ui/editors/uploadeditors.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L257)

___

### fileSymbols

• `Protected` **fileSymbols**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[fileSymbols](FileUploadEditor.md#filesymbols)

#### Defined in

[src/ui/editors/uploadeditors.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L260)

___

### hiddenInput

• `Protected` **hiddenInput**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[hiddenInput](FileUploadEditor.md#hiddeninput)

#### Defined in

[src/ui/editors/uploadeditors.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L262)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[idPrefix](FileUploadEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<[`EditorProps`](../README.md#editorprops)\<`P`\>\>

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[options](FileUploadEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### progress

• `Protected` **progress**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[progress](FileUploadEditor.md#progress)

#### Defined in

[src/ui/editors/uploadeditors.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L259)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[toolbar](FileUploadEditor.md#toolbar)

#### Defined in

[src/ui/editors/uploadeditors.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L258)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[uniqueName](FileUploadEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### uploadInput

• `Protected` **uploadInput**: [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[uploadInput](FileUploadEditor.md#uploadinput)

#### Defined in

[src/ui/editors/uploadeditors.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L261)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.EditorWidget"``\>

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[typeInfo](FileUploadEditor.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

FileUploadEditor.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

FileUploadEditor.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### value

• `get` **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Inherited from

FileUploadEditor.value

#### Defined in

[src/ui/editors/uploadeditors.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L187)

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

[src/ui/editors/uploadeditors.ts:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L226)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[addCssClass](FileUploadEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

___

### addFileButtonText

▸ **addFileButtonText**(): `string`

#### Returns

`string`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[addFileButtonText](FileUploadEditor.md#addfilebuttontext)

#### Defined in

[src/ui/editors/uploadeditors.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L91)

___

### addValidationRule

▸ **addValidationRule**(`rule`, `uniqueName?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rule` | (`input`: `HTMLSelectElement` \| `HTMLInputElement` \| `HTMLTextAreaElement`) => `string` |
| `uniqueName?` | `string` |

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[addValidationRule](FileUploadEditor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

▸ **addValidationRule**(`uniqueName`, `rule`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `uniqueName` | `string` |
| `rule` | (`input`: `HTMLSelectElement` \| `HTMLInputElement` \| `HTMLTextAreaElement`) => `string` |

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[addValidationRule](FileUploadEditor.md#addvalidationrule)

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

[FileUploadEditor](FileUploadEditor.md).[change](FileUploadEditor.md#change)

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

[FileUploadEditor](FileUploadEditor.md).[changeSelect2](FileUploadEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[destroy](FileUploadEditor.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L49)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getCssClass](FileUploadEditor.md#getcssclass)

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

[FileUploadEditor](FileUploadEditor.md).[getCustomAttribute](FileUploadEditor.md#getcustomattribute)

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

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getEditValue](FileUploadEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L230)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getFieldElement](FileUploadEditor.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getGridField](FileUploadEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getToolButtons

▸ **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getToolButtons](FileUploadEditor.md#gettoolbuttons)

#### Defined in

[src/ui/editors/uploadeditors.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L95)

___

### getUploadInputOptions

▸ **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[getUploadInputOptions](FileUploadEditor.md#getuploadinputoptions)

#### Defined in

[src/ui/editors/uploadeditors.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L64)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[get_readOnly](FileUploadEditor.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L145)

___

### get\_required

▸ **get_required**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[get_required](FileUploadEditor.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L171)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[get_value](FileUploadEditor.md#get_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L179)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[init](FileUploadEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[internalInit](FileUploadEditor.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[internalRenderContents](FileUploadEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### populate

▸ **populate**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[populate](FileUploadEditor.md#populate)

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

[FileUploadEditor](FileUploadEditor.md).[render](FileUploadEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[renderContents](FileUploadEditor.md#rendercontents)

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

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[setEditValue](FileUploadEditor.md#seteditvalue)

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

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[set_readOnly](FileUploadEditor.md#set_readonly)

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

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[set_required](FileUploadEditor.md#set_required)

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

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[set_value](FileUploadEditor.md#set_value)

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

[FileUploadEditor](FileUploadEditor.md).[syncOrAsyncThen](FileUploadEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[updateInterface](FileUploadEditor.md#updateinterface)

#### Defined in

[src/ui/editors/uploadeditors.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L137)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[useIdPrefix](FileUploadEditor.md#useidprefix)

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

[FileUploadEditor](FileUploadEditor.md).[create](FileUploadEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[FileUploadEditor](FileUploadEditor.md).[createDefaultElement](FileUploadEditor.md#createdefaultelement)

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

[FileUploadEditor](FileUploadEditor.md).[getWidgetName](FileUploadEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
