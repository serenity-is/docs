[@serenity-is/corelib](../README.md) / FilterWidgetBase

# Class: FilterWidgetBase\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | {} |

## Hierarchy

- [`TemplatedWidget`](TemplatedWidget.md)\<`P`\>

  ↳ **`FilterWidgetBase`**

  ↳↳ [`FilterPanel`](FilterPanel.md)

  ↳↳ [`FilterDisplayBar`](FilterDisplayBar.md)

## Table of contents

### Constructors

- [constructor](FilterWidgetBase.md#constructor)

### Properties

- [domNode](FilterWidgetBase.md#domnode)
- [idPrefix](FilterWidgetBase.md#idprefix)
- [options](FilterWidgetBase.md#options)
- [uniqueName](FilterWidgetBase.md#uniquename)
- [typeInfo](FilterWidgetBase.md#typeinfo)

### Accessors

- [element](FilterWidgetBase.md#element)
- [props](FilterWidgetBase.md#props)

### Methods

- [addCssClass](FilterWidgetBase.md#addcssclass)
- [addValidationRule](FilterWidgetBase.md#addvalidationrule)
- [byId](FilterWidgetBase.md#byid)
- [change](FilterWidgetBase.md#change)
- [changeSelect2](FilterWidgetBase.md#changeselect2)
- [destroy](FilterWidgetBase.md#destroy)
- [filterStoreChanged](FilterWidgetBase.md#filterstorechanged)
- [findById](FilterWidgetBase.md#findbyid)
- [getCssClass](FilterWidgetBase.md#getcssclass)
- [getCustomAttribute](FilterWidgetBase.md#getcustomattribute)
- [getFieldElement](FilterWidgetBase.md#getfieldelement)
- [getGridField](FilterWidgetBase.md#getgridfield)
- [getTemplate](FilterWidgetBase.md#gettemplate)
- [get\_store](FilterWidgetBase.md#get_store)
- [init](FilterWidgetBase.md#init)
- [internalInit](FilterWidgetBase.md#internalinit)
- [internalRenderContents](FilterWidgetBase.md#internalrendercontents)
- [render](FilterWidgetBase.md#render)
- [renderContents](FilterWidgetBase.md#rendercontents)
- [set\_store](FilterWidgetBase.md#set_store)
- [syncOrAsyncThen](FilterWidgetBase.md#syncorasyncthen)
- [useIdPrefix](FilterWidgetBase.md#useidprefix)
- [create](FilterWidgetBase.md#create)
- [createDefaultElement](FilterWidgetBase.md#createdefaultelement)
- [getWidgetName](FilterWidgetBase.md#getwidgetname)

## Constructors

### constructor

• **new FilterWidgetBase**\<`P`\>(`props`): [`FilterWidgetBase`](FilterWidgetBase.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | {} |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`FilterWidgetBase`](FilterWidgetBase.md)\<`P`\>

#### Overrides

[TemplatedWidget](TemplatedWidget.md).[constructor](TemplatedWidget.md#constructor)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L12)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[domNode](TemplatedWidget.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[idPrefix](TemplatedWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[options](TemplatedWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[uniqueName](TemplatedWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[typeInfo](TemplatedWidget.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

TemplatedWidget.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

TemplatedWidget.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[addCssClass](TemplatedWidget.md#addcssclass)

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

[TemplatedWidget](TemplatedWidget.md).[addValidationRule](TemplatedWidget.md#addvalidationrule)

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

[TemplatedWidget](TemplatedWidget.md).[addValidationRule](TemplatedWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### byId

▸ **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[byId](TemplatedWidget.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L8)

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

[TemplatedWidget](TemplatedWidget.md).[change](TemplatedWidget.md#change)

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

[TemplatedWidget](TemplatedWidget.md).[changeSelect2](TemplatedWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](TemplatedWidget.md).[destroy](TemplatedWidget.md#destroy)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L20)

___

### filterStoreChanged

▸ **filterStoreChanged**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L31)

___

### findById

▸ **findById**\<`TElement`\>(`id`): `TElement`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`TElement`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[findById](TemplatedWidget.md#findbyid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L12)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getCssClass](TemplatedWidget.md#getcssclass)

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

[TemplatedWidget](TemplatedWidget.md).[getCustomAttribute](TemplatedWidget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getFieldElement](TemplatedWidget.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getGridField](TemplatedWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getTemplate

▸ **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getTemplate](TemplatedWidget.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L16)

___

### get\_store

▸ **get_store**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L34)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[init](TemplatedWidget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[internalInit](TemplatedWidget.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[internalRenderContents](TemplatedWidget.md#internalrendercontents)

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

[TemplatedWidget](TemplatedWidget.md).[render](TemplatedWidget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[renderContents](TemplatedWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L20)

___

### set\_store

▸ **set_store**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterStore`](FilterStore.md) |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L38)

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

[TemplatedWidget](TemplatedWidget.md).[syncOrAsyncThen](TemplatedWidget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[useIdPrefix](TemplatedWidget.md#useidprefix)

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

[TemplatedWidget](TemplatedWidget.md).[create](TemplatedWidget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[createDefaultElement](TemplatedWidget.md#createdefaultelement)

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

[TemplatedWidget](TemplatedWidget.md).[getWidgetName](TemplatedWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
