[@serenity-is/corelib](../README.md) / MaskedEditor

# Class: MaskedEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`MaskedEditorOptions`](../interfaces/MaskedEditorOptions.md) = [`MaskedEditorOptions`](../interfaces/MaskedEditorOptions.md) |

## Hierarchy

- [`EditorWidget`](EditorWidget.md)\<`P`\>

  ↳ **`MaskedEditor`**

## Table of contents

### Constructors

- [constructor](MaskedEditor.md#constructor)

### Properties

- [domNode](MaskedEditor.md#domnode)
- [idPrefix](MaskedEditor.md#idprefix)
- [options](MaskedEditor.md#options)
- [uniqueName](MaskedEditor.md#uniquename)
- [typeInfo](MaskedEditor.md#typeinfo)

### Accessors

- [element](MaskedEditor.md#element)
- [props](MaskedEditor.md#props)
- [value](MaskedEditor.md#value)

### Methods

- [addCssClass](MaskedEditor.md#addcssclass)
- [addValidationRule](MaskedEditor.md#addvalidationrule)
- [change](MaskedEditor.md#change)
- [changeSelect2](MaskedEditor.md#changeselect2)
- [destroy](MaskedEditor.md#destroy)
- [getCssClass](MaskedEditor.md#getcssclass)
- [getCustomAttribute](MaskedEditor.md#getcustomattribute)
- [getFieldElement](MaskedEditor.md#getfieldelement)
- [getGridField](MaskedEditor.md#getgridfield)
- [get\_value](MaskedEditor.md#get_value)
- [init](MaskedEditor.md#init)
- [internalInit](MaskedEditor.md#internalinit)
- [internalRenderContents](MaskedEditor.md#internalrendercontents)
- [render](MaskedEditor.md#render)
- [renderContents](MaskedEditor.md#rendercontents)
- [set\_value](MaskedEditor.md#set_value)
- [syncOrAsyncThen](MaskedEditor.md#syncorasyncthen)
- [useIdPrefix](MaskedEditor.md#useidprefix)
- [create](MaskedEditor.md#create)
- [createDefaultElement](MaskedEditor.md#createdefaultelement)
- [getWidgetName](MaskedEditor.md#getwidgetname)

## Constructors

### constructor

• **new MaskedEditor**\<`P`\>(`props`): [`MaskedEditor`](MaskedEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`MaskedEditorOptions`](../interfaces/MaskedEditorOptions.md) = [`MaskedEditorOptions`](../interfaces/MaskedEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`MaskedEditor`](MaskedEditor.md)\<`P`\>

#### Overrides

[EditorWidget](EditorWidget.md).[constructor](EditorWidget.md#constructor)

#### Defined in

[src/ui/editors/maskededitor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/maskededitor.ts#L13)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLInputElement`

#### Overrides

[EditorWidget](EditorWidget.md).[domNode](EditorWidget.md#domnode)

#### Defined in

[src/ui/editors/maskededitor.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/maskededitor.ts#L11)

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

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[EditorWidget](EditorWidget.md).[uniqueName](EditorWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

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

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/maskededitor.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/maskededitor.ts#L27)

• `set` **value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/maskededitor.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/maskededitor.ts#L36)

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

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/maskededitor.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/maskededitor.ts#L32)

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

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/maskededitor.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/maskededitor.ts#L40)

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

▸ **createDefaultElement**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Overrides

[EditorWidget](EditorWidget.md).[createDefaultElement](EditorWidget.md#createdefaultelement)

#### Defined in

[src/ui/editors/maskededitor.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/maskededitor.ts#L10)

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
