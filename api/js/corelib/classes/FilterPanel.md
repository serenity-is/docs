[@serenity-is/corelib](../README.md) / FilterPanel

# Class: FilterPanel\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | {} |

## Hierarchy

- [`FilterWidgetBase`](FilterWidgetBase.md)\<`P`\>

  ↳ **`FilterPanel`**

## Table of contents

### Constructors

- [constructor](FilterPanel.md#constructor)

### Properties

- [domNode](FilterPanel.md#domnode)
- [idPrefix](FilterPanel.md#idprefix)
- [options](FilterPanel.md#options)
- [uniqueName](FilterPanel.md#uniquename)
- [typeInfo](FilterPanel.md#typeinfo)

### Accessors

- [element](FilterPanel.md#element)
- [props](FilterPanel.md#props)

### Methods

- [addButtonClick](FilterPanel.md#addbuttonclick)
- [addCssClass](FilterPanel.md#addcssclass)
- [addEmptyRow](FilterPanel.md#addemptyrow)
- [addValidationRule](FilterPanel.md#addvalidationrule)
- [andOrClick](FilterPanel.md#andorclick)
- [byId](FilterPanel.md#byid)
- [change](FilterPanel.md#change)
- [changeSelect2](FilterPanel.md#changeselect2)
- [deleteRowClick](FilterPanel.md#deleterowclick)
- [destroy](FilterPanel.md#destroy)
- [filterStoreChanged](FilterPanel.md#filterstorechanged)
- [findById](FilterPanel.md#findbyid)
- [findEmptyRow](FilterPanel.md#findemptyrow)
- [getCssClass](FilterPanel.md#getcssclass)
- [getCustomAttribute](FilterPanel.md#getcustomattribute)
- [getFieldElement](FilterPanel.md#getfieldelement)
- [getFieldFor](FilterPanel.md#getfieldfor)
- [getFilteringFor](FilterPanel.md#getfilteringfor)
- [getGridField](FilterPanel.md#getgridfield)
- [getTemplate](FilterPanel.md#gettemplate)
- [get\_hasErrors](FilterPanel.md#get_haserrors)
- [get\_showInitialLine](FilterPanel.md#get_showinitialline)
- [get\_showSearchButton](FilterPanel.md#get_showsearchbutton)
- [get\_store](FilterPanel.md#get_store)
- [get\_updateStoreOnReset](FilterPanel.md#get_updatestoreonreset)
- [init](FilterPanel.md#init)
- [initButtons](FilterPanel.md#initbuttons)
- [internalInit](FilterPanel.md#internalinit)
- [internalRenderContents](FilterPanel.md#internalrendercontents)
- [leftRightParenClick](FilterPanel.md#leftrightparenclick)
- [onRowFieldChange](FilterPanel.md#onrowfieldchange)
- [onRowOperatorChange](FilterPanel.md#onrowoperatorchange)
- [populateOperatorList](FilterPanel.md#populateoperatorlist)
- [removeFiltering](FilterPanel.md#removefiltering)
- [render](FilterPanel.md#render)
- [renderContents](FilterPanel.md#rendercontents)
- [resetButtonClick](FilterPanel.md#resetbuttonclick)
- [rowFieldChange](FilterPanel.md#rowfieldchange)
- [rowOperatorChange](FilterPanel.md#rowoperatorchange)
- [search](FilterPanel.md#search)
- [searchButtonClick](FilterPanel.md#searchbuttonclick)
- [set\_showInitialLine](FilterPanel.md#set_showinitialline)
- [set\_showSearchButton](FilterPanel.md#set_showsearchbutton)
- [set\_store](FilterPanel.md#set_store)
- [set\_updateStoreOnReset](FilterPanel.md#set_updatestoreonreset)
- [syncOrAsyncThen](FilterPanel.md#syncorasyncthen)
- [updateButtons](FilterPanel.md#updatebuttons)
- [updateParens](FilterPanel.md#updateparens)
- [updateRowsFromStore](FilterPanel.md#updaterowsfromstore)
- [useIdPrefix](FilterPanel.md#useidprefix)
- [create](FilterPanel.md#create)
- [createDefaultElement](FilterPanel.md#createdefaultelement)
- [getWidgetName](FilterPanel.md#getwidgetname)

## Constructors

### constructor

• **new FilterPanel**\<`P`\>(`props`): [`FilterPanel`](FilterPanel.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | {} |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`FilterPanel`](FilterPanel.md)\<`P`\>

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[constructor](FilterWidgetBase.md#constructor)

#### Defined in

[src/ui/filtering/filterpanel.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L73)

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

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

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

### addButtonClick

▸ **addButtonClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L255)

___

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[addCssClass](FilterWidgetBase.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

___

### addEmptyRow

▸ **addEmptyRow**(`popupField`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `popupField` | `boolean` |

#### Returns

`HTMLElement`

#### Defined in

[src/ui/filtering/filterpanel.ts:294](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L294)

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

[FilterWidgetBase](FilterWidgetBase.md).[addValidationRule](FilterWidgetBase.md#addvalidationrule)

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

[FilterWidgetBase](FilterWidgetBase.md).[addValidationRule](FilterWidgetBase.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### andOrClick

▸ **andOrClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L491)

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

### deleteRowClick

▸ **deleteRowClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L471)

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

[src/ui/filtering/filterpanel.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L97)

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

### findEmptyRow

▸ **findEmptyRow**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[src/ui/filtering/filterpanel.ts:277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L277)

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

### getFieldFor

▸ **getFieldFor**(`row`): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `HTMLElement` |

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Defined in

[src/ui/filtering/filterpanel.ts:395](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L395)

___

### getFilteringFor

▸ **getFilteringFor**(`row`): [`IFiltering`](IFiltering.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `HTMLElement` |

#### Returns

[`IFiltering`](IFiltering.md)

#### Defined in

[src/ui/filtering/filterpanel.ts:408](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L408)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getGridField](FilterWidgetBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getTemplate

▸ **getTemplate**(): `string`

#### Returns

`string`

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[getTemplate](FilterWidgetBase.md#gettemplate)

#### Defined in

[src/ui/filtering/filterpanel.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L167)

___

### get\_hasErrors

▸ **get_hasErrors**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L195)

___

### get\_showInitialLine

▸ **get_showInitialLine**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L84)

___

### get\_showSearchButton

▸ **get_showSearchButton**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L144)

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

### get\_updateStoreOnReset

▸ **get_updateStoreOnReset**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L157)

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

### initButtons

▸ **initButtons**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L179)

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

### leftRightParenClick

▸ **leftRightParenClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:499](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L499)

___

### onRowFieldChange

▸ **onRowFieldChange**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L360)

___

### onRowOperatorChange

▸ **onRowOperatorChange**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:431](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L431)

___

### populateOperatorList

▸ **populateOperatorList**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L380)

___

### removeFiltering

▸ **removeFiltering**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L375)

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

▸ **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[renderContents](FilterWidgetBase.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L20)

___

### resetButtonClick

▸ **resetButtonClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L260)

___

### rowFieldChange

▸ **rowFieldChange**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:366](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L366)

___

### rowOperatorChange

▸ **rowOperatorChange**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L442)

___

### search

▸ **search**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L199)

___

### searchButtonClick

▸ **searchButtonClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L190)

___

### set\_showInitialLine

▸ **set_showInitialLine**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L88)

___

### set\_showSearchButton

▸ **set_showSearchButton**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L148)

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

### set\_updateStoreOnReset

▸ **set_updateStoreOnReset**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L161)

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

### updateButtons

▸ **updateButtons**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:484](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L484)

___

### updateParens

▸ **updateParens**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:505](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L505)

___

### updateRowsFromStore

▸ **updateRowsFromStore**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L102)

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
