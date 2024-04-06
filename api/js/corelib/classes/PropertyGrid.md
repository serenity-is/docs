[@serenity-is/corelib](../README.md) / PropertyGrid

# Class: PropertyGrid\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md) = [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md) |

## Hierarchy

- [`Widget`](Widget.md)\<`P`\>

  ↳ **`PropertyGrid`**

## Table of contents

### Constructors

- [constructor](PropertyGrid.md#constructor)

### Properties

- [domNode](PropertyGrid.md#domnode)
- [idPrefix](PropertyGrid.md#idprefix)
- [options](PropertyGrid.md#options)
- [uniqueName](PropertyGrid.md#uniquename)
- [typeInfo](PropertyGrid.md#typeinfo)

### Accessors

- [element](PropertyGrid.md#element)
- [props](PropertyGrid.md#props)
- [value](PropertyGrid.md#value)

### Methods

- [addCssClass](PropertyGrid.md#addcssclass)
- [addValidationRule](PropertyGrid.md#addvalidationrule)
- [change](PropertyGrid.md#change)
- [changeSelect2](PropertyGrid.md#changeselect2)
- [destroy](PropertyGrid.md#destroy)
- [enumerateItems](PropertyGrid.md#enumerateitems)
- [getCssClass](PropertyGrid.md#getcssclass)
- [getCustomAttribute](PropertyGrid.md#getcustomattribute)
- [getFieldElement](PropertyGrid.md#getfieldelement)
- [getGridField](PropertyGrid.md#getgridfield)
- [get\_editors](PropertyGrid.md#get_editors)
- [get\_idPrefix](PropertyGrid.md#get_idprefix)
- [get\_items](PropertyGrid.md#get_items)
- [get\_mode](PropertyGrid.md#get_mode)
- [init](PropertyGrid.md#init)
- [internalInit](PropertyGrid.md#internalinit)
- [internalRenderContents](PropertyGrid.md#internalrendercontents)
- [load](PropertyGrid.md#load)
- [render](PropertyGrid.md#render)
- [renderContents](PropertyGrid.md#rendercontents)
- [save](PropertyGrid.md#save)
- [set\_mode](PropertyGrid.md#set_mode)
- [syncOrAsyncThen](PropertyGrid.md#syncorasyncthen)
- [updateInterface](PropertyGrid.md#updateinterface)
- [useIdPrefix](PropertyGrid.md#useidprefix)
- [create](PropertyGrid.md#create)
- [createDefaultElement](PropertyGrid.md#createdefaultelement)
- [getWidgetName](PropertyGrid.md#getwidgetname)

## Constructors

### constructor

• **new PropertyGrid**\<`P`\>(`props`): [`PropertyGrid`](PropertyGrid.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md) = [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`PropertyGrid`](PropertyGrid.md)\<`P`\>

#### Inherited from

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[Widget](Widget.md).[domNode](Widget.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](Widget.md).[idPrefix](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[Widget](Widget.md).[options](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[Widget](Widget.md).[uniqueName](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[Widget](Widget.md).[typeInfo](Widget.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

Widget.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

Widget.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### value

• `get` **value**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/widgets/propertygrid.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L508)

• `set` **value**(`val`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `val` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L512)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addCssClass](Widget.md#addcssclass)

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

[Widget](Widget.md).[addValidationRule](Widget.md#addvalidationrule)

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

[Widget](Widget.md).[addValidationRule](Widget.md#addvalidationrule)

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

[Widget](Widget.md).[change](Widget.md#change)

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

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Widget](Widget.md).[destroy](Widget.md#destroy)

#### Defined in

[src/ui/widgets/propertygrid.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L82)

___

### enumerateItems

▸ **enumerateItems**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`p1`: [`PropertyItem`](../interfaces/PropertyItem.md), `p2`: [`Widget`](Widget.md)\<`any`\>) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L566)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](Widget.md).[getCssClass](Widget.md#getcssclass)

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

[Widget](Widget.md).[getCustomAttribute](Widget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[Widget](Widget.md).[getFieldElement](Widget.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[Widget](Widget.md).[getGridField](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### get\_editors

▸ **get_editors**(): [`Widget`](Widget.md)\<`any`\>[]

#### Returns

[`Widget`](Widget.md)\<`any`\>[]

#### Defined in

[src/ui/widgets/propertygrid.ts:448](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L448)

___

### get\_idPrefix

▸ **get_idPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/widgets/propertygrid.ts:456](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L456)

___

### get\_items

▸ **get_items**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/widgets/propertygrid.ts:452](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L452)

___

### get\_mode

▸ **get_mode**(): [`PropertyGridMode`](../enums/PropertyGridMode.md)

#### Returns

[`PropertyGridMode`](../enums/PropertyGridMode.md)

#### Defined in

[src/ui/widgets/propertygrid.ts:460](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L460)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[Widget](Widget.md).[init](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[internalInit](Widget.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[internalRenderContents](Widget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### load

▸ **load**(`source`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L482)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[Widget](Widget.md).[render](Widget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `void`

#### Returns

`void`

#### Overrides

[Widget](Widget.md).[renderContents](Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/propertygrid.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L16)

___

### save

▸ **save**(`target?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target?` | `any` |

#### Returns

`any`

#### Defined in

[src/ui/widgets/propertygrid.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L495)

___

### set\_mode

▸ **set_mode**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`PropertyGridMode`](../enums/PropertyGridMode.md) |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:464](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L464)

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

[Widget](Widget.md).[syncOrAsyncThen](Widget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:544](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L544)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[Widget](Widget.md).[useIdPrefix](Widget.md#useidprefix)

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

[Widget](Widget.md).[create](Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[Widget](Widget.md).[createDefaultElement](Widget.md#createdefaultelement)

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

[Widget](Widget.md).[getWidgetName](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
