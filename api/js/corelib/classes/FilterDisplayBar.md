[@serenity-is/corelib](../README.md) / FilterDisplayBar

# Class: FilterDisplayBar\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | {} |

## Hierarchy

- [`FilterWidgetBase`](FilterWidgetBase.md)\<`P`\>

  ↳ **`FilterDisplayBar`**

## Table of contents

### Constructors

- [constructor](FilterDisplayBar.md#constructor)

### Properties

- [domNode](FilterDisplayBar.md#domnode)
- [idPrefix](FilterDisplayBar.md#idprefix)
- [options](FilterDisplayBar.md#options)
- [uniqueName](FilterDisplayBar.md#uniquename)
- [typeInfo](FilterDisplayBar.md#typeinfo)

### Accessors

- [element](FilterDisplayBar.md#element)
- [props](FilterDisplayBar.md#props)

### Methods

- [addCssClass](FilterDisplayBar.md#addcssclass)
- [addValidationRule](FilterDisplayBar.md#addvalidationrule)
- [byId](FilterDisplayBar.md#byid)
- [change](FilterDisplayBar.md#change)
- [changeSelect2](FilterDisplayBar.md#changeselect2)
- [destroy](FilterDisplayBar.md#destroy)
- [filterStoreChanged](FilterDisplayBar.md#filterstorechanged)
- [findById](FilterDisplayBar.md#findbyid)
- [getCssClass](FilterDisplayBar.md#getcssclass)
- [getCustomAttribute](FilterDisplayBar.md#getcustomattribute)
- [getFieldElement](FilterDisplayBar.md#getfieldelement)
- [getGridField](FilterDisplayBar.md#getgridfield)
- [getTemplate](FilterDisplayBar.md#gettemplate)
- [get\_store](FilterDisplayBar.md#get_store)
- [init](FilterDisplayBar.md#init)
- [internalInit](FilterDisplayBar.md#internalinit)
- [internalRenderContents](FilterDisplayBar.md#internalrendercontents)
- [render](FilterDisplayBar.md#render)
- [renderContents](FilterDisplayBar.md#rendercontents)
- [set\_store](FilterDisplayBar.md#set_store)
- [syncOrAsyncThen](FilterDisplayBar.md#syncorasyncthen)
- [useIdPrefix](FilterDisplayBar.md#useidprefix)
- [create](FilterDisplayBar.md#create)
- [createDefaultElement](FilterDisplayBar.md#createdefaultelement)
- [getWidgetName](FilterDisplayBar.md#getwidgetname)

## Constructors

### constructor

• **new FilterDisplayBar**\<`P`\>(`props`): [`FilterDisplayBar`](FilterDisplayBar.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | {} |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`FilterDisplayBar`](FilterDisplayBar.md)\<`P`\>

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[constructor](FilterWidgetBase.md#constructor)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L12)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[domNode](FilterWidgetBase.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[idPrefix](FilterWidgetBase.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[options](FilterWidgetBase.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[uniqueName](FilterWidgetBase.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[typeInfo](FilterWidgetBase.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

FilterWidgetBase.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

FilterWidgetBase.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[addCssClass](FilterWidgetBase.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

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

[FilterWidgetBase](FilterWidgetBase.md).[addValidationRule](FilterWidgetBase.md#addvalidationrule)

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

[FilterWidgetBase](FilterWidgetBase.md).[addValidationRule](FilterWidgetBase.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### byId

▸ **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent-1.md)\<`TElement`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`TElement`\>

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[byId](FilterWidgetBase.md#byid)

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

[FilterWidgetBase](FilterWidgetBase.md).[change](FilterWidgetBase.md#change)

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

[FilterWidgetBase](FilterWidgetBase.md).[changeSelect2](FilterWidgetBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[destroy](FilterWidgetBase.md#destroy)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L20)

___

### filterStoreChanged

▸ **filterStoreChanged**(): `void`

#### Returns

`void`

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[filterStoreChanged](FilterWidgetBase.md#filterstorechanged)

#### Defined in

[src/ui/filtering/filterdisplaybar.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdisplaybar.ts#L40)

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

[FilterWidgetBase](FilterWidgetBase.md).[findById](FilterWidgetBase.md#findbyid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L12)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getCssClass](FilterWidgetBase.md#getcssclass)

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

[FilterWidgetBase](FilterWidgetBase.md).[getCustomAttribute](FilterWidgetBase.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getFieldElement](FilterWidgetBase.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getGridField](FilterWidgetBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getTemplate

▸ **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getTemplate](FilterWidgetBase.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L16)

___

### get\_store

▸ **get_store**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[get_store](FilterWidgetBase.md#get_store)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L34)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[init](FilterWidgetBase.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[internalInit](FilterWidgetBase.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[internalRenderContents](FilterWidgetBase.md#internalrendercontents)

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

[FilterWidgetBase](FilterWidgetBase.md).[render](FilterWidgetBase.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `HTMLDivElement`

#### Returns

`HTMLDivElement`

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[renderContents](FilterWidgetBase.md#rendercontents)

#### Defined in

[src/ui/filtering/filterdisplaybar.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdisplaybar.ts#L9)

___

### set\_store

▸ **set_store**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterStore`](FilterStore.md) |

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[set_store](FilterWidgetBase.md#set_store)

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

[FilterWidgetBase](FilterWidgetBase.md).[syncOrAsyncThen](FilterWidgetBase.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[useIdPrefix](FilterWidgetBase.md#useidprefix)

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

[FilterWidgetBase](FilterWidgetBase.md).[create](FilterWidgetBase.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[createDefaultElement](FilterWidgetBase.md#createdefaultelement)

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

[FilterWidgetBase](FilterWidgetBase.md).[getWidgetName](FilterWidgetBase.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
