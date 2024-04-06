[@serenity-is/corelib](../README.md) / SelectEditor

# Class: SelectEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md) = [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md) |

## Hierarchy

- [`ComboboxEditor`](ComboboxEditor.md)\<`P`, [`ComboboxItem`](../interfaces/ComboboxItem.md)\>

  ↳ **`SelectEditor`**

  ↳↳ [`DateYearEditor`](DateYearEditor.md)

## Table of contents

### Constructors

- [constructor](SelectEditor.md#constructor)

### Properties

- [cascadeLink](SelectEditor.md#cascadelink)
- [domNode](SelectEditor.md#domnode)
- [idPrefix](SelectEditor.md#idprefix)
- [lastCreateTerm](SelectEditor.md#lastcreateterm)
- [onInitNewEntity](SelectEditor.md#oninitnewentity)
- [openDialogAsPanel](SelectEditor.md#opendialogaspanel)
- [options](SelectEditor.md#options)
- [uniqueName](SelectEditor.md#uniquename)
- [typeInfo](SelectEditor.md#typeinfo)

### Accessors

- [cascadeField](SelectEditor.md#cascadefield)
- [cascadeFrom](SelectEditor.md#cascadefrom)
- [cascadeValue](SelectEditor.md#cascadevalue)
- [element](SelectEditor.md#element)
- [filterField](SelectEditor.md#filterfield)
- [filterValue](SelectEditor.md#filtervalue)
- [itemById](SelectEditor.md#itembyid)
- [items](SelectEditor.md#items)
- [props](SelectEditor.md#props)
- [readOnly](SelectEditor.md#readonly)
- [selectedItem](SelectEditor.md#selecteditem)
- [selectedItems](SelectEditor.md#selecteditems)
- [text](SelectEditor.md#text)
- [value](SelectEditor.md#value)
- [values](SelectEditor.md#values)

### Methods

- [abortPendingQuery](SelectEditor.md#abortpendingquery)
- [addCssClass](SelectEditor.md#addcssclass)
- [addInplaceCreate](SelectEditor.md#addinplacecreate)
- [addItem](SelectEditor.md#additem)
- [addOption](SelectEditor.md#addoption)
- [addValidationRule](SelectEditor.md#addvalidationrule)
- [allowClear](SelectEditor.md#allowclear)
- [asyncSearch](SelectEditor.md#asyncsearch)
- [cascadeItems](SelectEditor.md#cascadeitems)
- [change](SelectEditor.md#change)
- [changeSelect2](SelectEditor.md#changeselect2)
- [clearItems](SelectEditor.md#clearitems)
- [createEditDialog](SelectEditor.md#createeditdialog)
- [destroy](SelectEditor.md#destroy)
- [editDialogDataChange](SelectEditor.md#editdialogdatachange)
- [emptyItemText](SelectEditor.md#emptyitemtext)
- [filterItems](SelectEditor.md#filteritems)
- [getCascadeFromValue](SelectEditor.md#getcascadefromvalue)
- [getComboboxContainer](SelectEditor.md#getcomboboxcontainer)
- [getComboboxOptions](SelectEditor.md#getcomboboxoptions)
- [getCreateSearchChoice](SelectEditor.md#getcreatesearchchoice)
- [getCssClass](SelectEditor.md#getcssclass)
- [getCustomAttribute](SelectEditor.md#getcustomattribute)
- [getDialogTypeKey](SelectEditor.md#getdialogtypekey)
- [getEditValue](SelectEditor.md#geteditvalue)
- [getFieldElement](SelectEditor.md#getfieldelement)
- [getGridField](SelectEditor.md#getgridfield)
- [getIdField](SelectEditor.md#getidfield)
- [getItems](SelectEditor.md#getitems)
- [getPageSize](SelectEditor.md#getpagesize)
- [getTextField](SelectEditor.md#gettextfield)
- [getTypeDelay](SelectEditor.md#gettypedelay)
- [get\_cascadeField](SelectEditor.md#get_cascadefield)
- [get\_cascadeFrom](SelectEditor.md#get_cascadefrom)
- [get\_cascadeValue](SelectEditor.md#get_cascadevalue)
- [get\_delimited](SelectEditor.md#get_delimited)
- [get\_filterField](SelectEditor.md#get_filterfield)
- [get\_filterValue](SelectEditor.md#get_filtervalue)
- [get\_itemByKey](SelectEditor.md#get_itembykey)
- [get\_items](SelectEditor.md#get_items)
- [get\_readOnly](SelectEditor.md#get_readonly)
- [get\_text](SelectEditor.md#get_text)
- [get\_value](SelectEditor.md#get_value)
- [get\_values](SelectEditor.md#get_values)
- [hasAsyncSource](SelectEditor.md#hasasyncsource)
- [init](SelectEditor.md#init)
- [initNewEntity](SelectEditor.md#initnewentity)
- [inplaceCreateClick](SelectEditor.md#inplacecreateclick)
- [internalInit](SelectEditor.md#internalinit)
- [internalRenderContents](SelectEditor.md#internalrendercontents)
- [isAutoComplete](SelectEditor.md#isautocomplete)
- [isMultiple](SelectEditor.md#ismultiple)
- [itemDisabled](SelectEditor.md#itemdisabled)
- [itemId](SelectEditor.md#itemid)
- [itemText](SelectEditor.md#itemtext)
- [mapItem](SelectEditor.md#mapitem)
- [mapItems](SelectEditor.md#mapitems)
- [openDropdown](SelectEditor.md#opendropdown)
- [render](SelectEditor.md#render)
- [renderContents](SelectEditor.md#rendercontents)
- [setCascadeFrom](SelectEditor.md#setcascadefrom)
- [setEditDialogReadOnly](SelectEditor.md#seteditdialogreadonly)
- [setEditValue](SelectEditor.md#seteditvalue)
- [setTermOnNewEntity](SelectEditor.md#settermonnewentity)
- [set\_cascadeField](SelectEditor.md#set_cascadefield)
- [set\_cascadeFrom](SelectEditor.md#set_cascadefrom)
- [set\_cascadeValue](SelectEditor.md#set_cascadevalue)
- [set\_filterField](SelectEditor.md#set_filterfield)
- [set\_filterValue](SelectEditor.md#set_filtervalue)
- [set\_readOnly](SelectEditor.md#set_readonly)
- [set\_value](SelectEditor.md#set_value)
- [set\_values](SelectEditor.md#set_values)
- [syncOrAsyncThen](SelectEditor.md#syncorasyncthen)
- [updateItems](SelectEditor.md#updateitems)
- [useIdPrefix](SelectEditor.md#useidprefix)
- [useInplaceAdd](SelectEditor.md#useinplaceadd)
- [create](SelectEditor.md#create)
- [createDefaultElement](SelectEditor.md#createdefaultelement)
- [filterByText](SelectEditor.md#filterbytext)
- [getWidgetName](SelectEditor.md#getwidgetname)

## Constructors

### constructor

• **new SelectEditor**\<`P`\>(`props`): [`SelectEditor`](SelectEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md) = [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`SelectEditor`](SelectEditor.md)\<`P`\>

#### Overrides

[ComboboxEditor](ComboboxEditor.md).[constructor](ComboboxEditor.md#constructor)

#### Defined in

[src/ui/editors/selecteditor.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L8)

## Properties

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[cascadeLink](ComboboxEditor.md#cascadelink)

#### Defined in

[src/ui/editors/comboboxeditor.ts:572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L572)

___

### domNode

• `Readonly` **domNode**: `HTMLInputElement`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[domNode](ComboboxEditor.md#domnode)

#### Defined in

[src/ui/editors/comboboxeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L44)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[idPrefix](ComboboxEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### lastCreateTerm

• `Protected` **lastCreateTerm**: `string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[lastCreateTerm](ComboboxEditor.md#lastcreateterm)

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

[ComboboxEditor](ComboboxEditor.md).[onInitNewEntity](ComboboxEditor.md#oninitnewentity)

#### Defined in

[src/ui/editors/comboboxeditor.ts:740](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L740)

___

### openDialogAsPanel

• **openDialogAsPanel**: `boolean`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[openDialogAsPanel](ComboboxEditor.md#opendialogaspanel)

#### Defined in

[src/ui/editors/comboboxeditor.ts:846](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L846)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[options](ComboboxEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[uniqueName](ComboboxEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[typeInfo](ComboboxEditor.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

ComboboxEditor.cascadeField

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

ComboboxEditor.cascadeField

#### Defined in

[src/ui/editors/comboboxeditor.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L624)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

ComboboxEditor.cascadeFrom

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

ComboboxEditor.cascadeFrom

#### Defined in

[src/ui/editors/comboboxeditor.ts:608](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L608)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

ComboboxEditor.cascadeValue

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

ComboboxEditor.cascadeValue

#### Defined in

[src/ui/editors/comboboxeditor.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L644)

___

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

ComboboxEditor.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Inherited from

ComboboxEditor.filterField

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

ComboboxEditor.filterField

#### Defined in

[src/ui/editors/comboboxeditor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L660)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Inherited from

ComboboxEditor.filterValue

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

ComboboxEditor.filterValue

#### Defined in

[src/ui/editors/comboboxeditor.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L680)

___

### itemById

• `get` **itemById**(): `Object`

#### Returns

`Object`

#### Inherited from

ComboboxEditor.itemById

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

ComboboxEditor.itemById

#### Defined in

[src/ui/editors/comboboxeditor.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L266)

___

### items

• `get` **items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Inherited from

ComboboxEditor.items

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

ComboboxEditor.items

#### Defined in

[src/ui/editors/comboboxeditor.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L249)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

ComboboxEditor.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

ComboboxEditor.readOnly

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

ComboboxEditor.readOnly

#### Defined in

[src/ui/editors/comboboxeditor.ts:564](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L564)

___

### selectedItem

• `get` **selectedItem**(): `TItem`

#### Returns

`TItem`

#### Inherited from

ComboboxEditor.selectedItem

#### Defined in

[src/ui/editors/comboboxeditor.ts:485](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L485)

___

### selectedItems

• `get` **selectedItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

ComboboxEditor.selectedItems

#### Defined in

[src/ui/editors/comboboxeditor.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L495)

___

### text

• `get` **text**(): `string`

#### Returns

`string`

#### Inherited from

ComboboxEditor.text

#### Defined in

[src/ui/editors/comboboxeditor.ts:534](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L534)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

ComboboxEditor.value

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

ComboboxEditor.value

#### Defined in

[src/ui/editors/comboboxeditor.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L481)

___

### values

• `get` **values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

ComboboxEditor.values

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

ComboboxEditor.values

#### Defined in

[src/ui/editors/comboboxeditor.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L522)

## Methods

### abortPendingQuery

▸ **abortPendingQuery**(): `void`

#### Returns

`void`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[abortPendingQuery](ComboboxEditor.md#abortpendingquery)

#### Defined in

[src/ui/editors/comboboxeditor.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L157)

___

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[addCssClass](ComboboxEditor.md#addcssclass)

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

[ComboboxEditor](ComboboxEditor.md).[addInplaceCreate](ComboboxEditor.md#addinplacecreate)

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

[ComboboxEditor](ComboboxEditor.md).[addItem](ComboboxEditor.md#additem)

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

[ComboboxEditor](ComboboxEditor.md).[addOption](ComboboxEditor.md#addoption)

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

[ComboboxEditor](ComboboxEditor.md).[addValidationRule](ComboboxEditor.md#addvalidationrule)

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

[ComboboxEditor](ComboboxEditor.md).[addValidationRule](ComboboxEditor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### allowClear

▸ **allowClear**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[allowClear](ComboboxEditor.md#allowclear)

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

[ComboboxEditor](ComboboxEditor.md).[asyncSearch](ComboboxEditor.md#asyncsearch)

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

[ComboboxEditor](ComboboxEditor.md).[cascadeItems](ComboboxEditor.md#cascadeitems)

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

[ComboboxEditor](ComboboxEditor.md).[change](ComboboxEditor.md#change)

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

[ComboboxEditor](ComboboxEditor.md).[changeSelect2](ComboboxEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### clearItems

▸ **clearItems**(): `void`

#### Returns

`void`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[clearItems](ComboboxEditor.md#clearitems)

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

[ComboboxEditor](ComboboxEditor.md).[createEditDialog](ComboboxEditor.md#createeditdialog)

#### Defined in

[src/ui/editors/comboboxeditor.ts:733](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L733)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[destroy](ComboboxEditor.md#destroy)

#### Defined in

[src/ui/editors/comboboxeditor.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L79)

___

### editDialogDataChange

▸ **editDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[editDialogDataChange](ComboboxEditor.md#editdialogdatachange)

#### Defined in

[src/ui/editors/comboboxeditor.ts:765](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L765)

___

### emptyItemText

▸ **emptyItemText**(): `string`

#### Returns

`string`

#### Overrides

[ComboboxEditor](ComboboxEditor.md).[emptyItemText](ComboboxEditor.md#emptyitemtext)

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

[ComboboxEditor](ComboboxEditor.md).[filterItems](ComboboxEditor.md#filteritems)

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

[ComboboxEditor](ComboboxEditor.md).[getCascadeFromValue](ComboboxEditor.md#getcascadefromvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:568](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L568)

___

### getComboboxContainer

▸ **getComboboxContainer**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getComboboxContainer](ComboboxEditor.md#getcomboboxcontainer)

#### Defined in

[src/ui/editors/comboboxeditor.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L428)

___

### getComboboxOptions

▸ **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getComboboxOptions](ComboboxEditor.md#getcomboboxoptions)

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

[ComboboxEditor](ComboboxEditor.md).[getCreateSearchChoice](ComboboxEditor.md#getcreatesearchchoice)

#### Defined in

[src/ui/editors/comboboxeditor.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L363)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getCssClass](ComboboxEditor.md#getcssclass)

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

[ComboboxEditor](ComboboxEditor.md).[getCustomAttribute](ComboboxEditor.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getDialogTypeKey

▸ **getDialogTypeKey**(): `string`

#### Returns

`string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getDialogTypeKey](ComboboxEditor.md#getdialogtypekey)

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

[ComboboxEditor](ComboboxEditor.md).[getEditValue](ComboboxEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L419)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getFieldElement](ComboboxEditor.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getGridField](ComboboxEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getIdField

▸ **getIdField**(): `any`

#### Returns

`any`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getIdField](ComboboxEditor.md#getidfield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L109)

___

### getItems

▸ **getItems**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/editors/selecteditor.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L14)

___

### getPageSize

▸ **getPageSize**(): `number`

#### Returns

`number`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getPageSize](ComboboxEditor.md#getpagesize)

#### Defined in

[src/ui/editors/comboboxeditor.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L105)

___

### getTextField

▸ **getTextField**(): `any`

#### Returns

`any`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getTextField](ComboboxEditor.md#gettextfield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L120)

___

### getTypeDelay

▸ **getTypeDelay**(): `any`

#### Returns

`any`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[getTypeDelay](ComboboxEditor.md#gettypedelay)

#### Defined in

[src/ui/editors/comboboxeditor.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L96)

___

### get\_cascadeField

▸ **get_cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_cascadeField](ComboboxEditor.md#get_cascadefield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:612](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L612)

___

### get\_cascadeFrom

▸ **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_cascadeFrom](ComboboxEditor.md#get_cascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.ts:593](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L593)

___

### get\_cascadeValue

▸ **get_cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_cascadeValue](ComboboxEditor.md#get_cascadevalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L628)

___

### get\_delimited

▸ **get_delimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_delimited](ComboboxEditor.md#get_delimited)

#### Defined in

[src/ui/editors/comboboxeditor.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L238)

___

### get\_filterField

▸ **get_filterField**(): `string`

#### Returns

`string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_filterField](ComboboxEditor.md#get_filterfield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L648)

___

### get\_filterValue

▸ **get_filterValue**(): `any`

#### Returns

`any`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_filterValue](ComboboxEditor.md#get_filtervalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L664)

___

### get\_itemByKey

▸ **get_itemByKey**(): `Object`

#### Returns

`Object`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_itemByKey](ComboboxEditor.md#get_itembykey)

#### Defined in

[src/ui/editors/comboboxeditor.ts:436](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L436)

___

### get\_items

▸ **get_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>[]

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_items](ComboboxEditor.md#get_items)

#### Defined in

[src/ui/editors/comboboxeditor.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L432)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_readOnly](ComboboxEditor.md#get_readonly)

#### Defined in

[src/ui/editors/comboboxeditor.ts:538](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L538)

___

### get\_text

▸ **get_text**(): `string`

#### Returns

`string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_text](ComboboxEditor.md#get_text)

#### Defined in

[src/ui/editors/comboboxeditor.ts:526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L526)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_value](ComboboxEditor.md#get_value)

#### Defined in

[src/ui/editors/comboboxeditor.ts:462](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L462)

___

### get\_values

▸ **get_values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[get_values](ComboboxEditor.md#get_values)

#### Defined in

[src/ui/editors/comboboxeditor.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L510)

___

### hasAsyncSource

▸ **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[hasAsyncSource](ComboboxEditor.md#hasasyncsource)

#### Defined in

[src/ui/editors/comboboxeditor.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L85)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[init](ComboboxEditor.md#init)

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

[ComboboxEditor](ComboboxEditor.md).[initNewEntity](ComboboxEditor.md#initnewentity)

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

[ComboboxEditor](ComboboxEditor.md).[inplaceCreateClick](ComboboxEditor.md#inplacecreateclick)

#### Defined in

[src/ui/editors/comboboxeditor.ts:771](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L771)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[internalInit](ComboboxEditor.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[internalRenderContents](ComboboxEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### isAutoComplete

▸ **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[isAutoComplete](ComboboxEditor.md#isautocomplete)

#### Defined in

[src/ui/editors/comboboxeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L359)

___

### isMultiple

▸ **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[isMultiple](ComboboxEditor.md#ismultiple)

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

[ComboboxEditor](ComboboxEditor.md).[itemDisabled](ComboboxEditor.md#itemdisabled)

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

[ComboboxEditor](ComboboxEditor.md).[itemId](ComboboxEditor.md#itemid)

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

[ComboboxEditor](ComboboxEditor.md).[itemText](ComboboxEditor.md#itemtext)

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

[ComboboxEditor](ComboboxEditor.md).[mapItem](ComboboxEditor.md#mapitem)

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

[ComboboxEditor](ComboboxEditor.md).[mapItems](ComboboxEditor.md#mapitems)

#### Defined in

[src/ui/editors/comboboxeditor.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L144)

___

### openDropdown

▸ **openDropdown**(): `void`

#### Returns

`void`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[openDropdown](ComboboxEditor.md#opendropdown)

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

[ComboboxEditor](ComboboxEditor.md).[render](ComboboxEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[renderContents](ComboboxEditor.md#rendercontents)

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

[ComboboxEditor](ComboboxEditor.md).[setCascadeFrom](ComboboxEditor.md#setcascadefrom)

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

[ComboboxEditor](ComboboxEditor.md).[setEditDialogReadOnly](ComboboxEditor.md#seteditdialogreadonly)

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

[ComboboxEditor](ComboboxEditor.md).[setEditValue](ComboboxEditor.md#seteditvalue)

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

[ComboboxEditor](ComboboxEditor.md).[setTermOnNewEntity](ComboboxEditor.md#settermonnewentity)

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

[ComboboxEditor](ComboboxEditor.md).[set_cascadeField](ComboboxEditor.md#set_cascadefield)

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

[ComboboxEditor](ComboboxEditor.md).[set_cascadeFrom](ComboboxEditor.md#set_cascadefrom)

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

[ComboboxEditor](ComboboxEditor.md).[set_cascadeValue](ComboboxEditor.md#set_cascadevalue)

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

[ComboboxEditor](ComboboxEditor.md).[set_filterField](ComboboxEditor.md#set_filterfield)

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

[ComboboxEditor](ComboboxEditor.md).[set_filterValue](ComboboxEditor.md#set_filtervalue)

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

[ComboboxEditor](ComboboxEditor.md).[set_readOnly](ComboboxEditor.md#set_readonly)

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

[ComboboxEditor](ComboboxEditor.md).[set_value](ComboboxEditor.md#set_value)

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

[ComboboxEditor](ComboboxEditor.md).[set_values](ComboboxEditor.md#set_values)

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

[ComboboxEditor](ComboboxEditor.md).[syncOrAsyncThen](ComboboxEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### updateItems

▸ **updateItems**(): `void`

#### Returns

`void`

#### Overrides

[ComboboxEditor](ComboboxEditor.md).[updateItems](ComboboxEditor.md#updateitems)

#### Defined in

[src/ui/editors/selecteditor.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L25)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[useIdPrefix](ComboboxEditor.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### useInplaceAdd

▸ **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[useInplaceAdd](ComboboxEditor.md#useinplaceadd)

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

[ComboboxEditor](ComboboxEditor.md).[create](ComboboxEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Inherited from

[ComboboxEditor](ComboboxEditor.md).[createDefaultElement](ComboboxEditor.md#createdefaultelement)

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

[ComboboxEditor](ComboboxEditor.md).[filterByText](ComboboxEditor.md#filterbytext)

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

[ComboboxEditor](ComboboxEditor.md).[getWidgetName](ComboboxEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
