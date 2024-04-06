[@serenity-is/corelib](../README.md) / MultipleImageUploadEditor

# Class: MultipleImageUploadEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) = [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) |

## Hierarchy

- [`MultipleFileUploadEditor`](MultipleFileUploadEditor.md)\<`P`\>

  ↳ **`MultipleImageUploadEditor`**

## Table of contents

### Constructors

- [constructor](MultipleImageUploadEditor.md#constructor)

### Properties

- [domNode](MultipleImageUploadEditor.md#domnode)
- [hiddenInput](MultipleImageUploadEditor.md#hiddeninput)
- [idPrefix](MultipleImageUploadEditor.md#idprefix)
- [options](MultipleImageUploadEditor.md#options)
- [progress](MultipleImageUploadEditor.md#progress)
- [uniqueName](MultipleImageUploadEditor.md#uniquename)
- [typeInfo](MultipleImageUploadEditor.md#typeinfo)

### Accessors

- [element](MultipleImageUploadEditor.md#element)
- [jsonEncodeValue](MultipleImageUploadEditor.md#jsonencodevalue)
- [props](MultipleImageUploadEditor.md#props)
- [value](MultipleImageUploadEditor.md#value)

### Methods

- [addCssClass](MultipleImageUploadEditor.md#addcssclass)
- [addFileButtonText](MultipleImageUploadEditor.md#addfilebuttontext)
- [addValidationRule](MultipleImageUploadEditor.md#addvalidationrule)
- [change](MultipleImageUploadEditor.md#change)
- [changeSelect2](MultipleImageUploadEditor.md#changeselect2)
- [destroy](MultipleImageUploadEditor.md#destroy)
- [getCssClass](MultipleImageUploadEditor.md#getcssclass)
- [getCustomAttribute](MultipleImageUploadEditor.md#getcustomattribute)
- [getEditValue](MultipleImageUploadEditor.md#geteditvalue)
- [getFieldElement](MultipleImageUploadEditor.md#getfieldelement)
- [getGridField](MultipleImageUploadEditor.md#getgridfield)
- [getToolButtons](MultipleImageUploadEditor.md#gettoolbuttons)
- [getUploadInputOptions](MultipleImageUploadEditor.md#getuploadinputoptions)
- [get\_readOnly](MultipleImageUploadEditor.md#get_readonly)
- [get\_required](MultipleImageUploadEditor.md#get_required)
- [get\_value](MultipleImageUploadEditor.md#get_value)
- [init](MultipleImageUploadEditor.md#init)
- [internalInit](MultipleImageUploadEditor.md#internalinit)
- [internalRenderContents](MultipleImageUploadEditor.md#internalrendercontents)
- [populate](MultipleImageUploadEditor.md#populate)
- [render](MultipleImageUploadEditor.md#render)
- [renderContents](MultipleImageUploadEditor.md#rendercontents)
- [setEditValue](MultipleImageUploadEditor.md#seteditvalue)
- [set\_readOnly](MultipleImageUploadEditor.md#set_readonly)
- [set\_required](MultipleImageUploadEditor.md#set_required)
- [set\_value](MultipleImageUploadEditor.md#set_value)
- [syncOrAsyncThen](MultipleImageUploadEditor.md#syncorasyncthen)
- [updateInterface](MultipleImageUploadEditor.md#updateinterface)
- [useIdPrefix](MultipleImageUploadEditor.md#useidprefix)
- [create](MultipleImageUploadEditor.md#create)
- [createDefaultElement](MultipleImageUploadEditor.md#createdefaultelement)
- [getWidgetName](MultipleImageUploadEditor.md#getwidgetname)

## Constructors

### constructor

• **new MultipleImageUploadEditor**\<`P`\>(`props`): [`MultipleImageUploadEditor`](MultipleImageUploadEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) = [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`MultipleImageUploadEditor`](MultipleImageUploadEditor.md)\<`P`\>

#### Overrides

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[constructor](MultipleFileUploadEditor.md#constructor)

#### Defined in

[src/ui/editors/uploadeditors.ts:479](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L479)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[domNode](MultipleFileUploadEditor.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### hiddenInput

• `Protected` **hiddenInput**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[hiddenInput](MultipleFileUploadEditor.md#hiddeninput)

#### Defined in

[src/ui/editors/uploadeditors.ts:290](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L290)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[idPrefix](MultipleFileUploadEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<[`EditorProps`](../README.md#editorprops)\<`P`\>\>

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[options](MultipleFileUploadEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### progress

• `Protected` **progress**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[progress](MultipleFileUploadEditor.md#progress)

#### Defined in

[src/ui/editors/uploadeditors.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L289)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[uniqueName](MultipleFileUploadEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.EditorWidget"``\>

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[typeInfo](MultipleFileUploadEditor.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

MultipleFileUploadEditor.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### jsonEncodeValue

• `get` **jsonEncodeValue**(): `boolean`

#### Returns

`boolean`

#### Inherited from

MultipleFileUploadEditor.jsonEncodeValue

#### Defined in

[src/ui/editors/uploadeditors.ts:473](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L473)

• `set` **jsonEncodeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Inherited from

MultipleFileUploadEditor.jsonEncodeValue

#### Defined in

[src/ui/editors/uploadeditors.ts:474](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L474)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

MultipleFileUploadEditor.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### value

• `get` **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Inherited from

MultipleFileUploadEditor.value

#### Defined in

[src/ui/editors/uploadeditors.ts:429](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L429)

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

[src/ui/editors/uploadeditors.ts:441](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L441)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[addCssClass](MultipleFileUploadEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

___

### addFileButtonText

▸ **addFileButtonText**(): `string`

#### Returns

`string`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[addFileButtonText](MultipleFileUploadEditor.md#addfilebuttontext)

#### Defined in

[src/ui/editors/uploadeditors.ts:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L350)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[addValidationRule](MultipleFileUploadEditor.md#addvalidationrule)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[addValidationRule](MultipleFileUploadEditor.md#addvalidationrule)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[change](MultipleFileUploadEditor.md#change)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[changeSelect2](MultipleFileUploadEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[destroy](MultipleFileUploadEditor.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L49)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getCssClass](MultipleFileUploadEditor.md#getcssclass)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getCustomAttribute](MultipleFileUploadEditor.md#getcustomattribute)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getEditValue](MultipleFileUploadEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L445)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getFieldElement](MultipleFileUploadEditor.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getGridField](MultipleFileUploadEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getToolButtons

▸ **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getToolButtons](MultipleFileUploadEditor.md#gettoolbuttons)

#### Defined in

[src/ui/editors/uploadeditors.ts:354](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L354)

___

### getUploadInputOptions

▸ **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getUploadInputOptions](MultipleFileUploadEditor.md#getuploadinputoptions)

#### Defined in

[src/ui/editors/uploadeditors.ts:324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L324)

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

[src/ui/editors/uploadeditors.ts:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L415)

___

### get\_value

▸ **get_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[get_value](MultipleFileUploadEditor.md#get_value)

#### Defined in

[src/ui/editors/uploadeditors.ts:423](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L423)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[init](MultipleFileUploadEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[internalInit](MultipleFileUploadEditor.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[internalRenderContents](MultipleFileUploadEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### populate

▸ **populate**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[populate](MultipleFileUploadEditor.md#populate)

#### Defined in

[src/ui/editors/uploadeditors.ts:364](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L364)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[render](MultipleFileUploadEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[renderContents](MultipleFileUploadEditor.md#rendercontents)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[setEditValue](MultipleFileUploadEditor.md#seteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.ts:454](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L454)

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

[src/ui/editors/uploadeditors.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L419)

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

[src/ui/editors/uploadeditors.ts:433](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L433)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[syncOrAsyncThen](MultipleFileUploadEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[updateInterface](MultipleFileUploadEditor.md#updateinterface)

#### Defined in

[src/ui/editors/uploadeditors.ts:383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.ts#L383)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[useIdPrefix](MultipleFileUploadEditor.md#useidprefix)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[create](MultipleFileUploadEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[createDefaultElement](MultipleFileUploadEditor.md#createdefaultelement)

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

[MultipleFileUploadEditor](MultipleFileUploadEditor.md).[getWidgetName](MultipleFileUploadEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
