[@serenity-is/corelib](../README.md) / DateYearEditor

# Class: DateYearEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`DateYearEditorOptions`](../interfaces/DateYearEditorOptions.md) = [`DateYearEditorOptions`](../interfaces/DateYearEditorOptions.md) |

## Hierarchy

- [`SelectEditor`](SelectEditor.md)\<`P`\>

  ↳ **`DateYearEditor`**

## Table of contents

### Constructors

- [constructor](DateYearEditor.md#constructor)

### Properties

- [cascadeLink](DateYearEditor.md#cascadelink)
- [domNode](DateYearEditor.md#domnode)
- [idPrefix](DateYearEditor.md#idprefix)
- [lastCreateTerm](DateYearEditor.md#lastcreateterm)
- [onInitNewEntity](DateYearEditor.md#oninitnewentity)
- [openDialogAsPanel](DateYearEditor.md#opendialogaspanel)
- [options](DateYearEditor.md#options)
- [uniqueName](DateYearEditor.md#uniquename)
- [typeInfo](DateYearEditor.md#typeinfo)

### Accessors

- [cascadeField](DateYearEditor.md#cascadefield)
- [cascadeFrom](DateYearEditor.md#cascadefrom)
- [cascadeValue](DateYearEditor.md#cascadevalue)
- [element](DateYearEditor.md#element)
- [filterField](DateYearEditor.md#filterfield)
- [filterValue](DateYearEditor.md#filtervalue)
- [itemById](DateYearEditor.md#itembyid)
- [items](DateYearEditor.md#items)
- [props](DateYearEditor.md#props)
- [readOnly](DateYearEditor.md#readonly)
- [selectedItem](DateYearEditor.md#selecteditem)
- [selectedItems](DateYearEditor.md#selecteditems)
- [text](DateYearEditor.md#text)
- [value](DateYearEditor.md#value)
- [values](DateYearEditor.md#values)

### Methods

- [abortPendingQuery](DateYearEditor.md#abortpendingquery)
- [addCssClass](DateYearEditor.md#addcssclass)
- [addInplaceCreate](DateYearEditor.md#addinplacecreate)
- [addItem](DateYearEditor.md#additem)
- [addOption](DateYearEditor.md#addoption)
- [addValidationRule](DateYearEditor.md#addvalidationrule)
- [allowClear](DateYearEditor.md#allowclear)
- [asyncSearch](DateYearEditor.md#asyncsearch)
- [cascadeItems](DateYearEditor.md#cascadeitems)
- [change](DateYearEditor.md#change)
- [changeSelect2](DateYearEditor.md#changeselect2)
- [clearItems](DateYearEditor.md#clearitems)
- [createEditDialog](DateYearEditor.md#createeditdialog)
- [destroy](DateYearEditor.md#destroy)
- [editDialogDataChange](DateYearEditor.md#editdialogdatachange)
- [emptyItemText](DateYearEditor.md#emptyitemtext)
- [filterItems](DateYearEditor.md#filteritems)
- [getCascadeFromValue](DateYearEditor.md#getcascadefromvalue)
- [getComboboxContainer](DateYearEditor.md#getcomboboxcontainer)
- [getComboboxOptions](DateYearEditor.md#getcomboboxoptions)
- [getCreateSearchChoice](DateYearEditor.md#getcreatesearchchoice)
- [getCssClass](DateYearEditor.md#getcssclass)
- [getCustomAttribute](DateYearEditor.md#getcustomattribute)
- [getDialogTypeKey](DateYearEditor.md#getdialogtypekey)
- [getEditValue](DateYearEditor.md#geteditvalue)
- [getFieldElement](DateYearEditor.md#getfieldelement)
- [getGridField](DateYearEditor.md#getgridfield)
- [getIdField](DateYearEditor.md#getidfield)
- [getItems](DateYearEditor.md#getitems)
- [getPageSize](DateYearEditor.md#getpagesize)
- [getTextField](DateYearEditor.md#gettextfield)
- [getTypeDelay](DateYearEditor.md#gettypedelay)
- [get\_cascadeField](DateYearEditor.md#get_cascadefield)
- [get\_cascadeFrom](DateYearEditor.md#get_cascadefrom)
- [get\_cascadeValue](DateYearEditor.md#get_cascadevalue)
- [get\_delimited](DateYearEditor.md#get_delimited)
- [get\_filterField](DateYearEditor.md#get_filterfield)
- [get\_filterValue](DateYearEditor.md#get_filtervalue)
- [get\_itemByKey](DateYearEditor.md#get_itembykey)
- [get\_items](DateYearEditor.md#get_items)
- [get\_readOnly](DateYearEditor.md#get_readonly)
- [get\_text](DateYearEditor.md#get_text)
- [get\_value](DateYearEditor.md#get_value)
- [get\_values](DateYearEditor.md#get_values)
- [hasAsyncSource](DateYearEditor.md#hasasyncsource)
- [init](DateYearEditor.md#init)
- [initNewEntity](DateYearEditor.md#initnewentity)
- [inplaceCreateClick](DateYearEditor.md#inplacecreateclick)
- [internalInit](DateYearEditor.md#internalinit)
- [internalRenderContents](DateYearEditor.md#internalrendercontents)
- [isAutoComplete](DateYearEditor.md#isautocomplete)
- [isMultiple](DateYearEditor.md#ismultiple)
- [itemDisabled](DateYearEditor.md#itemdisabled)
- [itemId](DateYearEditor.md#itemid)
- [itemText](DateYearEditor.md#itemtext)
- [mapItem](DateYearEditor.md#mapitem)
- [mapItems](DateYearEditor.md#mapitems)
- [openDropdown](DateYearEditor.md#opendropdown)
- [render](DateYearEditor.md#render)
- [renderContents](DateYearEditor.md#rendercontents)
- [setCascadeFrom](DateYearEditor.md#setcascadefrom)
- [setEditDialogReadOnly](DateYearEditor.md#seteditdialogreadonly)
- [setEditValue](DateYearEditor.md#seteditvalue)
- [setTermOnNewEntity](DateYearEditor.md#settermonnewentity)
- [set\_cascadeField](DateYearEditor.md#set_cascadefield)
- [set\_cascadeFrom](DateYearEditor.md#set_cascadefrom)
- [set\_cascadeValue](DateYearEditor.md#set_cascadevalue)
- [set\_filterField](DateYearEditor.md#set_filterfield)
- [set\_filterValue](DateYearEditor.md#set_filtervalue)
- [set\_readOnly](DateYearEditor.md#set_readonly)
- [set\_value](DateYearEditor.md#set_value)
- [set\_values](DateYearEditor.md#set_values)
- [syncOrAsyncThen](DateYearEditor.md#syncorasyncthen)
- [updateItems](DateYearEditor.md#updateitems)
- [useIdPrefix](DateYearEditor.md#useidprefix)
- [useInplaceAdd](DateYearEditor.md#useinplaceadd)
- [create](DateYearEditor.md#create)
- [createDefaultElement](DateYearEditor.md#createdefaultelement)
- [filterByText](DateYearEditor.md#filterbytext)
- [getWidgetName](DateYearEditor.md#getwidgetname)

## Constructors

### constructor

• **new DateYearEditor**\<`P`\>(`props`): [`DateYearEditor`](DateYearEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`DateYearEditorOptions`](../interfaces/DateYearEditorOptions.md) = [`DateYearEditorOptions`](../interfaces/DateYearEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`DateYearEditor`](DateYearEditor.md)\<`P`\>

#### Overrides

[SelectEditor](SelectEditor.md).[constructor](SelectEditor.md#constructor)

#### Defined in

[src/ui/editors/dateyeareditor.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateyeareditor.ts#L8)

## Properties

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

#### Inherited from

[SelectEditor](SelectEditor.md).[cascadeLink](SelectEditor.md#cascadelink)

#### Defined in

[src/ui/editors/comboboxeditor.ts:572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L572)

___

### domNode

• `Readonly` **domNode**: `HTMLInputElement`

#### Inherited from

[SelectEditor](SelectEditor.md).[domNode](SelectEditor.md#domnode)

#### Defined in

[src/ui/editors/comboboxeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L44)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[SelectEditor](SelectEditor.md).[idPrefix](SelectEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### lastCreateTerm

• `Protected` **lastCreateTerm**: `string`

#### Inherited from

[SelectEditor](SelectEditor.md).[lastCreateTerm](SelectEditor.md#lastcreateterm)

#### Defined in

[src/ui/editors/comboboxeditor.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L49)

___

### onInitNewEntity

• **onInitNewEntity**: (`entity`: [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>) => `void`

#### Type declaration

▸ (`entity`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\> |

##### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[onInitNewEntity](SelectEditor.md#oninitnewentity)

#### Defined in

[src/ui/editors/comboboxeditor.ts:740](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L740)

___

### openDialogAsPanel

• **openDialogAsPanel**: `boolean`

#### Inherited from

[SelectEditor](SelectEditor.md).[openDialogAsPanel](SelectEditor.md#opendialogaspanel)

#### Defined in

[src/ui/editors/comboboxeditor.ts:846](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L846)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[SelectEditor](SelectEditor.md).[options](SelectEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[SelectEditor](SelectEditor.md).[uniqueName](SelectEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[SelectEditor](SelectEditor.md).[typeInfo](SelectEditor.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

SelectEditor.cascadeField

#### Defined in

[src/ui/editors/comboboxeditor.ts:616](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L616)

• `set` **cascadeField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

SelectEditor.cascadeField

#### Defined in

[src/ui/editors/comboboxeditor.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L624)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

SelectEditor.cascadeFrom

#### Defined in

[src/ui/editors/comboboxeditor.ts:597](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L597)

• `set` **cascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

SelectEditor.cascadeFrom

#### Defined in

[src/ui/editors/comboboxeditor.ts:608](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L608)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

SelectEditor.cascadeValue

#### Defined in

[src/ui/editors/comboboxeditor.ts:632](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L632)

• `set` **cascadeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Inherited from

SelectEditor.cascadeValue

#### Defined in

[src/ui/editors/comboboxeditor.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L644)

___

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

SelectEditor.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Inherited from

SelectEditor.filterField

#### Defined in

[src/ui/editors/comboboxeditor.ts:652](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L652)

• `set` **filterField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

SelectEditor.filterField

#### Defined in

[src/ui/editors/comboboxeditor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L660)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Inherited from

SelectEditor.filterValue

#### Defined in

[src/ui/editors/comboboxeditor.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L668)

• `set` **filterValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Inherited from

SelectEditor.filterValue

#### Defined in

[src/ui/editors/comboboxeditor.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L680)

___

### itemById

• `get` **itemById**(): `Object`

#### Returns

`Object`

#### Inherited from

SelectEditor.itemById

#### Defined in

[src/ui/editors/comboboxeditor.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L259)

• `set` **itemById**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Object` |

#### Returns

`void`

#### Inherited from

SelectEditor.itemById

#### Defined in

[src/ui/editors/comboboxeditor.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L266)

___

### items

• `get` **items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Inherited from

SelectEditor.items

#### Defined in

[src/ui/editors/comboboxeditor.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L242)

• `set` **items**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[] |

#### Returns

`void`

#### Inherited from

SelectEditor.items

#### Defined in

[src/ui/editors/comboboxeditor.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L249)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

SelectEditor.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

SelectEditor.readOnly

#### Defined in

[src/ui/editors/comboboxeditor.ts:542](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L542)

• `set` **readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Inherited from

SelectEditor.readOnly

#### Defined in

[src/ui/editors/comboboxeditor.ts:564](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L564)

___

### selectedItem

• `get` **selectedItem**(): `TItem`

#### Returns

`TItem`

#### Inherited from

SelectEditor.selectedItem

#### Defined in

[src/ui/editors/comboboxeditor.ts:485](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L485)

___

### selectedItems

• `get` **selectedItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

SelectEditor.selectedItems

#### Defined in

[src/ui/editors/comboboxeditor.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L495)

___

### text

• `get` **text**(): `string`

#### Returns

`string`

#### Inherited from

SelectEditor.text

#### Defined in

[src/ui/editors/comboboxeditor.ts:534](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L534)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

SelectEditor.value

#### Defined in

[src/ui/editors/comboboxeditor.ts:466](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L466)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Inherited from

SelectEditor.value

#### Defined in

[src/ui/editors/comboboxeditor.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L481)

___

### values

• `get` **values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

SelectEditor.values

#### Defined in

[src/ui/editors/comboboxeditor.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L514)

• `set` **values**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string`[] |

#### Returns

`void`

#### Inherited from

SelectEditor.values

#### Defined in

[src/ui/editors/comboboxeditor.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L522)

## Methods

### abortPendingQuery

▸ **abortPendingQuery**(): `void`

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[abortPendingQuery](SelectEditor.md#abortpendingquery)

#### Defined in

[src/ui/editors/comboboxeditor.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L157)

___

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[addCssClass](SelectEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

___

### addInplaceCreate

▸ **addInplaceCreate**(`addTitle`, `editTitle`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `addTitle` | `string` |
| `editTitle` | `string` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[addInplaceCreate](SelectEditor.md#addinplacecreate)

#### Defined in

[src/ui/editors/comboboxeditor.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L298)

___

### addItem

▸ **addItem**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\> |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[addItem](SelectEditor.md#additem)

#### Defined in

[src/ui/editors/comboboxeditor.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L281)

___

### addOption

▸ **addOption**(`key`, `text`, `source?`, `disabled?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `text` | `string` |
| `source?` | `any` |
| `disabled?` | `boolean` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[addOption](SelectEditor.md#addoption)

#### Defined in

[src/ui/editors/comboboxeditor.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L289)

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

[SelectEditor](SelectEditor.md).[addValidationRule](SelectEditor.md#addvalidationrule)

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

[SelectEditor](SelectEditor.md).[addValidationRule](SelectEditor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### allowClear

▸ **allowClear**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[SelectEditor](SelectEditor.md).[allowClear](SelectEditor.md#allowclear)

#### Defined in

[src/ui/editors/comboboxeditor.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L148)

___

### asyncSearch

▸ **asyncSearch**(`query`): `PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md) |

#### Returns

`PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>\>

#### Inherited from

[SelectEditor](SelectEditor.md).[asyncSearch](SelectEditor.md#asyncsearch)

#### Defined in

[src/ui/editors/comboboxeditor.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L89)

___

### cascadeItems

▸ **cascadeItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[] |

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[SelectEditor](SelectEditor.md).[cascadeItems](SelectEditor.md#cascadeitems)

#### Defined in

[src/ui/editors/comboboxeditor.ts:684](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L684)

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

[SelectEditor](SelectEditor.md).[change](SelectEditor.md#change)

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

[SelectEditor](SelectEditor.md).[changeSelect2](SelectEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### clearItems

▸ **clearItems**(): `void`

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[clearItems](SelectEditor.md#clearitems)

#### Defined in

[src/ui/editors/comboboxeditor.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L273)

___

### createEditDialog

▸ **createEditDialog**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`dlg`: [`IEditDialog`](IEditDialog.md)) => `void` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[createEditDialog](SelectEditor.md#createeditdialog)

#### Defined in

[src/ui/editors/comboboxeditor.ts:733](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L733)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[destroy](SelectEditor.md#destroy)

#### Defined in

[src/ui/editors/comboboxeditor.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L79)

___

### editDialogDataChange

▸ **editDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[editDialogDataChange](SelectEditor.md#editdialogdatachange)

#### Defined in

[src/ui/editors/comboboxeditor.ts:765](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L765)

___

### emptyItemText

▸ **emptyItemText**(): `string`

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[emptyItemText](SelectEditor.md#emptyitemtext)

#### Defined in

[src/ui/editors/selecteditor.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L18)

___

### filterItems

▸ **filterItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[] |

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[SelectEditor](SelectEditor.md).[filterItems](SelectEditor.md#filteritems)

#### Defined in

[src/ui/editors/comboboxeditor.ts:706](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L706)

___

### getCascadeFromValue

▸ **getCascadeFromValue**(`parent`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `parent` | [`Widget`](Widget.md)\<`any`\> |

#### Returns

`any`

#### Inherited from

[SelectEditor](SelectEditor.md).[getCascadeFromValue](SelectEditor.md#getcascadefromvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:568](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L568)

___

### getComboboxContainer

▸ **getComboboxContainer**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[SelectEditor](SelectEditor.md).[getComboboxContainer](SelectEditor.md#getcomboboxcontainer)

#### Defined in

[src/ui/editors/comboboxeditor.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L428)

___

### getComboboxOptions

▸ **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Inherited from

[SelectEditor](SelectEditor.md).[getComboboxOptions](SelectEditor.md#getcomboboxoptions)

#### Defined in

[src/ui/editors/comboboxeditor.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L161)

___

### getCreateSearchChoice

▸ **getCreateSearchChoice**(`getName`): (`s`: `string`) => \{ `id`: `string` ; `text`: `string`  }

#### Parameters

| Name | Type |
| :------ | :------ |
| `getName` | (`z`: `any`) => `string` |

#### Returns

`fn`

▸ (`s`): `Object`

##### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `string` |

##### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `id` | `string` |
| `text` | `string` |

#### Inherited from

[SelectEditor](SelectEditor.md).[getCreateSearchChoice](SelectEditor.md#getcreatesearchchoice)

#### Defined in

[src/ui/editors/comboboxeditor.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L363)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[getCssClass](SelectEditor.md#getcssclass)

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

[SelectEditor](SelectEditor.md).[getCustomAttribute](SelectEditor.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getDialogTypeKey

▸ **getDialogTypeKey**(): `string`

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[getDialogTypeKey](SelectEditor.md#getdialogtypekey)

#### Defined in

[src/ui/editors/comboboxeditor.ts:725](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L725)

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

[SelectEditor](SelectEditor.md).[getEditValue](SelectEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L419)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[SelectEditor](SelectEditor.md).[getFieldElement](SelectEditor.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[SelectEditor](SelectEditor.md).[getGridField](SelectEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getIdField

▸ **getIdField**(): `any`

#### Returns

`any`

#### Inherited from

[SelectEditor](SelectEditor.md).[getIdField](SelectEditor.md#getidfield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L109)

___

### getItems

▸ **getItems**(): `any`[]

#### Returns

`any`[]

#### Overrides

[SelectEditor](SelectEditor.md).[getItems](SelectEditor.md#getitems)

#### Defined in

[src/ui/editors/dateyeareditor.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateyeareditor.ts#L14)

___

### getPageSize

▸ **getPageSize**(): `number`

#### Returns

`number`

#### Inherited from

[SelectEditor](SelectEditor.md).[getPageSize](SelectEditor.md#getpagesize)

#### Defined in

[src/ui/editors/comboboxeditor.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L105)

___

### getTextField

▸ **getTextField**(): `any`

#### Returns

`any`

#### Inherited from

[SelectEditor](SelectEditor.md).[getTextField](SelectEditor.md#gettextfield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L120)

___

### getTypeDelay

▸ **getTypeDelay**(): `any`

#### Returns

`any`

#### Inherited from

[SelectEditor](SelectEditor.md).[getTypeDelay](SelectEditor.md#gettypedelay)

#### Defined in

[src/ui/editors/comboboxeditor.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L96)

___

### get\_cascadeField

▸ **get_cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_cascadeField](SelectEditor.md#get_cascadefield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:612](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L612)

___

### get\_cascadeFrom

▸ **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_cascadeFrom](SelectEditor.md#get_cascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.ts:593](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L593)

___

### get\_cascadeValue

▸ **get_cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_cascadeValue](SelectEditor.md#get_cascadevalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L628)

___

### get\_delimited

▸ **get_delimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_delimited](SelectEditor.md#get_delimited)

#### Defined in

[src/ui/editors/comboboxeditor.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L238)

___

### get\_filterField

▸ **get_filterField**(): `string`

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_filterField](SelectEditor.md#get_filterfield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L648)

___

### get\_filterValue

▸ **get_filterValue**(): `any`

#### Returns

`any`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_filterValue](SelectEditor.md#get_filtervalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L664)

___

### get\_itemByKey

▸ **get_itemByKey**(): `Object`

#### Returns

`Object`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_itemByKey](SelectEditor.md#get_itembykey)

#### Defined in

[src/ui/editors/comboboxeditor.ts:436](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L436)

___

### get\_items

▸ **get_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>[]

#### Inherited from

[SelectEditor](SelectEditor.md).[get_items](SelectEditor.md#get_items)

#### Defined in

[src/ui/editors/comboboxeditor.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L432)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_readOnly](SelectEditor.md#get_readonly)

#### Defined in

[src/ui/editors/comboboxeditor.ts:538](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L538)

___

### get\_text

▸ **get_text**(): `string`

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_text](SelectEditor.md#get_text)

#### Defined in

[src/ui/editors/comboboxeditor.ts:526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L526)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[get_value](SelectEditor.md#get_value)

#### Defined in

[src/ui/editors/comboboxeditor.ts:462](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L462)

___

### get\_values

▸ **get_values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[SelectEditor](SelectEditor.md).[get_values](SelectEditor.md#get_values)

#### Defined in

[src/ui/editors/comboboxeditor.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L510)

___

### hasAsyncSource

▸ **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[SelectEditor](SelectEditor.md).[hasAsyncSource](SelectEditor.md#hasasyncsource)

#### Defined in

[src/ui/editors/comboboxeditor.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L85)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[SelectEditor](SelectEditor.md).[init](SelectEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### initNewEntity

▸ **initNewEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\> |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[initNewEntity](SelectEditor.md#initnewentity)

#### Defined in

[src/ui/editors/comboboxeditor.ts:742](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L742)

___

### inplaceCreateClick

▸ **inplaceCreateClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[inplaceCreateClick](SelectEditor.md#inplacecreateclick)

#### Defined in

[src/ui/editors/comboboxeditor.ts:771](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L771)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[internalInit](SelectEditor.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[internalRenderContents](SelectEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### isAutoComplete

▸ **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[SelectEditor](SelectEditor.md).[isAutoComplete](SelectEditor.md#isautocomplete)

#### Defined in

[src/ui/editors/comboboxeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L359)

___

### isMultiple

▸ **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[SelectEditor](SelectEditor.md).[isMultiple](SelectEditor.md#ismultiple)

#### Defined in

[src/ui/editors/comboboxeditor.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L153)

___

### itemDisabled

▸ **itemDisabled**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\> |

#### Returns

`boolean`

#### Inherited from

[SelectEditor](SelectEditor.md).[itemDisabled](SelectEditor.md#itemdisabled)

#### Defined in

[src/ui/editors/comboboxeditor.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L131)

___

### itemId

▸ **itemId**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\> |

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[itemId](SelectEditor.md#itemid)

#### Defined in

[src/ui/editors/comboboxeditor.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L113)

___

### itemText

▸ **itemText**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\> |

#### Returns

`string`

#### Inherited from

[SelectEditor](SelectEditor.md).[itemText](SelectEditor.md#itemtext)

#### Defined in

[src/ui/editors/comboboxeditor.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L124)

___

### mapItem

▸ **mapItem**(`item`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\> |

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Inherited from

[SelectEditor](SelectEditor.md).[mapItem](SelectEditor.md#mapitem)

#### Defined in

[src/ui/editors/comboboxeditor.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L135)

___

### mapItems

▸ **mapItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[] |

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[SelectEditor](SelectEditor.md).[mapItems](SelectEditor.md#mapitems)

#### Defined in

[src/ui/editors/comboboxeditor.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L144)

___

### openDropdown

▸ **openDropdown**(): `void`

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[openDropdown](SelectEditor.md#opendropdown)

#### Defined in

[src/ui/editors/comboboxeditor.ts:842](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L842)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[SelectEditor](SelectEditor.md).[render](SelectEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[SelectEditor](SelectEditor.md).[renderContents](SelectEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L178)

___

### setCascadeFrom

▸ **setCascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[setCascadeFrom](SelectEditor.md#setcascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L574)

___

### setEditDialogReadOnly

▸ **setEditDialogReadOnly**(`dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | `any` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[setEditDialogReadOnly](SelectEditor.md#seteditdialogreadonly)

#### Defined in

[src/ui/editors/comboboxeditor.ts:756](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L756)

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

[SelectEditor](SelectEditor.md).[setEditValue](SelectEditor.md#seteditvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L409)

___

### setTermOnNewEntity

▸ **setTermOnNewEntity**(`entity`, `term`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\> |
| `term` | `string` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[setTermOnNewEntity](SelectEditor.md#settermonnewentity)

#### Defined in

[src/ui/editors/comboboxeditor.ts:768](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L768)

___

### set\_cascadeField

▸ **set_cascadeField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[set_cascadeField](SelectEditor.md#set_cascadefield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L620)

___

### set\_cascadeFrom

▸ **set_cascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[set_cascadeFrom](SelectEditor.md#set_cascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.ts:601](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L601)

___

### set\_cascadeValue

▸ **set_cascadeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[set_cascadeValue](SelectEditor.md#set_cascadevalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L636)

___

### set\_filterField

▸ **set_filterField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[set_filterField](SelectEditor.md#set_filterfield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L656)

___

### set\_filterValue

▸ **set_filterValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[set_filterValue](SelectEditor.md#set_filtervalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L672)

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

[SelectEditor](SelectEditor.md).[set_readOnly](SelectEditor.md#set_readonly)

#### Defined in

[src/ui/editors/comboboxeditor.ts:557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L557)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[set_value](SelectEditor.md#set_value)

#### Defined in

[src/ui/editors/comboboxeditor.ts:470](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L470)

___

### set\_values

▸ **set_values**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string`[] |

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[set_values](SelectEditor.md#set_values)

#### Defined in

[src/ui/editors/comboboxeditor.ts:518](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L518)

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

[SelectEditor](SelectEditor.md).[syncOrAsyncThen](SelectEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### updateItems

▸ **updateItems**(): `void`

#### Returns

`void`

#### Inherited from

[SelectEditor](SelectEditor.md).[updateItems](SelectEditor.md#updateitems)

#### Defined in

[src/ui/editors/selecteditor.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L25)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[SelectEditor](SelectEditor.md).[useIdPrefix](SelectEditor.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### useInplaceAdd

▸ **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[SelectEditor](SelectEditor.md).[useInplaceAdd](SelectEditor.md#useinplaceadd)

#### Defined in

[src/ui/editors/comboboxeditor.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L352)

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

[SelectEditor](SelectEditor.md).[create](SelectEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Inherited from

[SelectEditor](SelectEditor.md).[createDefaultElement](SelectEditor.md#createdefaultelement)

#### Defined in

[src/ui/editors/comboboxeditor.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L43)

___

### filterByText

▸ **filterByText**\<`TItem`\>(`items`, `getText`, `term`): `TItem`[]

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |
| `getText` | (`item`: `TItem`) => `string` |
| `term` | `string` |

#### Returns

`TItem`[]

#### Inherited from

[SelectEditor](SelectEditor.md).[filterByText](SelectEditor.md#filterbytext)

#### Defined in

[src/ui/editors/comboboxeditor.ts:440](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L440)

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

[SelectEditor](SelectEditor.md).[getWidgetName](SelectEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
