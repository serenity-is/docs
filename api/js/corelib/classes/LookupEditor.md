[@serenity-is/corelib](../README.md) / LookupEditor

# Class: LookupEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md) = [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md) |

## Hierarchy

- [`LookupEditorBase`](LookupEditorBase.md)\<`P`, {}\>

  ↳ **`LookupEditor`**

## Table of contents

### Constructors

- [constructor](LookupEditor.md#constructor)

### Properties

- [cascadeLink](LookupEditor.md#cascadelink)
- [domNode](LookupEditor.md#domnode)
- [idPrefix](LookupEditor.md#idprefix)
- [lastCreateTerm](LookupEditor.md#lastcreateterm)
- [lookup](LookupEditor.md#lookup)
- [onInitNewEntity](LookupEditor.md#oninitnewentity)
- [openDialogAsPanel](LookupEditor.md#opendialogaspanel)
- [options](LookupEditor.md#options)
- [uniqueName](LookupEditor.md#uniquename)
- [typeInfo](LookupEditor.md#typeinfo)

### Accessors

- [cascadeField](LookupEditor.md#cascadefield)
- [cascadeFrom](LookupEditor.md#cascadefrom)
- [cascadeValue](LookupEditor.md#cascadevalue)
- [element](LookupEditor.md#element)
- [filterField](LookupEditor.md#filterfield)
- [filterValue](LookupEditor.md#filtervalue)
- [itemById](LookupEditor.md#itembyid)
- [items](LookupEditor.md#items)
- [props](LookupEditor.md#props)
- [readOnly](LookupEditor.md#readonly)
- [selectedItem](LookupEditor.md#selecteditem)
- [selectedItems](LookupEditor.md#selecteditems)
- [text](LookupEditor.md#text)
- [value](LookupEditor.md#value)
- [values](LookupEditor.md#values)

### Methods

- [abortPendingQuery](LookupEditor.md#abortpendingquery)
- [addCssClass](LookupEditor.md#addcssclass)
- [addInplaceCreate](LookupEditor.md#addinplacecreate)
- [addItem](LookupEditor.md#additem)
- [addOption](LookupEditor.md#addoption)
- [addValidationRule](LookupEditor.md#addvalidationrule)
- [allowClear](LookupEditor.md#allowclear)
- [asyncSearch](LookupEditor.md#asyncsearch)
- [cascadeItems](LookupEditor.md#cascadeitems)
- [change](LookupEditor.md#change)
- [changeSelect2](LookupEditor.md#changeselect2)
- [clearItems](LookupEditor.md#clearitems)
- [createEditDialog](LookupEditor.md#createeditdialog)
- [destroy](LookupEditor.md#destroy)
- [editDialogDataChange](LookupEditor.md#editdialogdatachange)
- [emptyItemText](LookupEditor.md#emptyitemtext)
- [filterItems](LookupEditor.md#filteritems)
- [getCascadeFromValue](LookupEditor.md#getcascadefromvalue)
- [getComboboxContainer](LookupEditor.md#getcomboboxcontainer)
- [getComboboxOptions](LookupEditor.md#getcomboboxoptions)
- [getCreateSearchChoice](LookupEditor.md#getcreatesearchchoice)
- [getCssClass](LookupEditor.md#getcssclass)
- [getCustomAttribute](LookupEditor.md#getcustomattribute)
- [getDialogTypeKey](LookupEditor.md#getdialogtypekey)
- [getEditValue](LookupEditor.md#geteditvalue)
- [getFieldElement](LookupEditor.md#getfieldelement)
- [getGridField](LookupEditor.md#getgridfield)
- [getIdField](LookupEditor.md#getidfield)
- [getItemDisabled](LookupEditor.md#getitemdisabled)
- [getItemText](LookupEditor.md#getitemtext)
- [getItems](LookupEditor.md#getitems)
- [getLookup](LookupEditor.md#getlookup)
- [getLookupAsync](LookupEditor.md#getlookupasync)
- [getLookupKey](LookupEditor.md#getlookupkey)
- [getPageSize](LookupEditor.md#getpagesize)
- [getTextField](LookupEditor.md#gettextfield)
- [getTypeDelay](LookupEditor.md#gettypedelay)
- [get\_cascadeField](LookupEditor.md#get_cascadefield)
- [get\_cascadeFrom](LookupEditor.md#get_cascadefrom)
- [get\_cascadeValue](LookupEditor.md#get_cascadevalue)
- [get\_delimited](LookupEditor.md#get_delimited)
- [get\_filterField](LookupEditor.md#get_filterfield)
- [get\_filterValue](LookupEditor.md#get_filtervalue)
- [get\_itemByKey](LookupEditor.md#get_itembykey)
- [get\_items](LookupEditor.md#get_items)
- [get\_readOnly](LookupEditor.md#get_readonly)
- [get\_text](LookupEditor.md#get_text)
- [get\_value](LookupEditor.md#get_value)
- [get\_values](LookupEditor.md#get_values)
- [hasAsyncSource](LookupEditor.md#hasasyncsource)
- [init](LookupEditor.md#init)
- [initNewEntity](LookupEditor.md#initnewentity)
- [inplaceCreateClick](LookupEditor.md#inplacecreateclick)
- [internalInit](LookupEditor.md#internalinit)
- [internalRenderContents](LookupEditor.md#internalrendercontents)
- [isAutoComplete](LookupEditor.md#isautocomplete)
- [isMultiple](LookupEditor.md#ismultiple)
- [itemDisabled](LookupEditor.md#itemdisabled)
- [itemId](LookupEditor.md#itemid)
- [itemText](LookupEditor.md#itemtext)
- [mapItem](LookupEditor.md#mapitem)
- [mapItems](LookupEditor.md#mapitems)
- [openDropdown](LookupEditor.md#opendropdown)
- [render](LookupEditor.md#render)
- [renderContents](LookupEditor.md#rendercontents)
- [setCascadeFrom](LookupEditor.md#setcascadefrom)
- [setCreateTermOnNewEntity](LookupEditor.md#setcreatetermonnewentity)
- [setEditDialogReadOnly](LookupEditor.md#seteditdialogreadonly)
- [setEditValue](LookupEditor.md#seteditvalue)
- [setTermOnNewEntity](LookupEditor.md#settermonnewentity)
- [set\_cascadeField](LookupEditor.md#set_cascadefield)
- [set\_cascadeFrom](LookupEditor.md#set_cascadefrom)
- [set\_cascadeValue](LookupEditor.md#set_cascadevalue)
- [set\_filterField](LookupEditor.md#set_filterfield)
- [set\_filterValue](LookupEditor.md#set_filtervalue)
- [set\_readOnly](LookupEditor.md#set_readonly)
- [set\_value](LookupEditor.md#set_value)
- [set\_values](LookupEditor.md#set_values)
- [syncOrAsyncThen](LookupEditor.md#syncorasyncthen)
- [updateItems](LookupEditor.md#updateitems)
- [useIdPrefix](LookupEditor.md#useidprefix)
- [useInplaceAdd](LookupEditor.md#useinplaceadd)
- [create](LookupEditor.md#create)
- [createDefaultElement](LookupEditor.md#createdefaultelement)
- [filterByText](LookupEditor.md#filterbytext)
- [getWidgetName](LookupEditor.md#getwidgetname)

## Constructors

### constructor

• **new LookupEditor**\<`P`\>(`props`): [`LookupEditor`](LookupEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md) = [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`LookupEditor`](LookupEditor.md)\<`P`\>

#### Overrides

[LookupEditorBase](LookupEditorBase.md).[constructor](LookupEditorBase.md#constructor)

#### Defined in

[src/ui/editors/lookupeditor.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L149)

## Properties

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[cascadeLink](LookupEditorBase.md#cascadelink)

#### Defined in

[src/ui/editors/comboboxeditor.ts:572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L572)

___

### domNode

• `Readonly` **domNode**: `HTMLInputElement`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[domNode](LookupEditorBase.md#domnode)

#### Defined in

[src/ui/editors/comboboxeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L44)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[idPrefix](LookupEditorBase.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### lastCreateTerm

• `Protected` **lastCreateTerm**: `string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[lastCreateTerm](LookupEditorBase.md#lastcreateterm)

#### Defined in

[src/ui/editors/comboboxeditor.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L49)

___

### lookup

• `Protected` **lookup**: [`Lookup`](Lookup.md)\<{}\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[lookup](LookupEditorBase.md#lookup)

#### Defined in

[src/ui/editors/lookupeditor.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L59)

___

### onInitNewEntity

• **onInitNewEntity**: (`entity`: {}) => `void`

#### Type declaration

▸ (`entity`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `Object` |

##### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[onInitNewEntity](LookupEditorBase.md#oninitnewentity)

#### Defined in

[src/ui/editors/comboboxeditor.ts:740](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L740)

___

### openDialogAsPanel

• **openDialogAsPanel**: `boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[openDialogAsPanel](LookupEditorBase.md#opendialogaspanel)

#### Defined in

[src/ui/editors/comboboxeditor.ts:846](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L846)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[options](LookupEditorBase.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[uniqueName](LookupEditorBase.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[typeInfo](LookupEditorBase.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.cascadeField

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

LookupEditorBase.cascadeField

#### Defined in

[src/ui/editors/comboboxeditor.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L624)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.cascadeFrom

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

LookupEditorBase.cascadeFrom

#### Defined in

[src/ui/editors/comboboxeditor.ts:608](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L608)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

LookupEditorBase.cascadeValue

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

LookupEditorBase.cascadeValue

#### Defined in

[src/ui/editors/comboboxeditor.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L644)

___

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

LookupEditorBase.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.filterField

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

LookupEditorBase.filterField

#### Defined in

[src/ui/editors/comboboxeditor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L660)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Inherited from

LookupEditorBase.filterValue

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

LookupEditorBase.filterValue

#### Defined in

[src/ui/editors/comboboxeditor.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L680)

___

### itemById

• `get` **itemById**(): `Object`

#### Returns

`Object`

#### Inherited from

LookupEditorBase.itemById

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

LookupEditorBase.itemById

#### Defined in

[src/ui/editors/comboboxeditor.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L266)

___

### items

• `get` **items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Inherited from

LookupEditorBase.items

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

LookupEditorBase.items

#### Defined in

[src/ui/editors/comboboxeditor.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L249)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

LookupEditorBase.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

LookupEditorBase.readOnly

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

LookupEditorBase.readOnly

#### Defined in

[src/ui/editors/comboboxeditor.ts:564](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L564)

___

### selectedItem

• `get` **selectedItem**(): `TItem`

#### Returns

`TItem`

#### Inherited from

LookupEditorBase.selectedItem

#### Defined in

[src/ui/editors/comboboxeditor.ts:485](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L485)

___

### selectedItems

• `get` **selectedItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

LookupEditorBase.selectedItems

#### Defined in

[src/ui/editors/comboboxeditor.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L495)

___

### text

• `get` **text**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.text

#### Defined in

[src/ui/editors/comboboxeditor.ts:534](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L534)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.value

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

LookupEditorBase.value

#### Defined in

[src/ui/editors/comboboxeditor.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L481)

___

### values

• `get` **values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

LookupEditorBase.values

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

LookupEditorBase.values

#### Defined in

[src/ui/editors/comboboxeditor.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L522)

## Methods

### abortPendingQuery

▸ **abortPendingQuery**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[abortPendingQuery](LookupEditorBase.md#abortpendingquery)

#### Defined in

[src/ui/editors/comboboxeditor.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L157)

___

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[addCssClass](LookupEditorBase.md#addcssclass)

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

[LookupEditorBase](LookupEditorBase.md).[addInplaceCreate](LookupEditorBase.md#addinplacecreate)

#### Defined in

[src/ui/editors/comboboxeditor.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L298)

___

### addItem

▸ **addItem**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<{}\> |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[addItem](LookupEditorBase.md#additem)

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

[LookupEditorBase](LookupEditorBase.md).[addOption](LookupEditorBase.md#addoption)

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

[LookupEditorBase](LookupEditorBase.md).[addValidationRule](LookupEditorBase.md#addvalidationrule)

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

[LookupEditorBase](LookupEditorBase.md).[addValidationRule](LookupEditorBase.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### allowClear

▸ **allowClear**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[allowClear](LookupEditorBase.md#allowclear)

#### Defined in

[src/ui/editors/comboboxeditor.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L148)

___

### asyncSearch

▸ **asyncSearch**(`query`): `Promise`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<{}\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md) |

#### Returns

`Promise`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<{}\>\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[asyncSearch](LookupEditorBase.md#asyncsearch)

#### Defined in

[src/ui/editors/lookupeditor.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L109)

___

### cascadeItems

▸ **cascadeItems**(`items`): {}[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | {}[] |

#### Returns

{}[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[cascadeItems](LookupEditorBase.md#cascadeitems)

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

[LookupEditorBase](LookupEditorBase.md).[change](LookupEditorBase.md#change)

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

[LookupEditorBase](LookupEditorBase.md).[changeSelect2](LookupEditorBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### clearItems

▸ **clearItems**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[clearItems](LookupEditorBase.md#clearitems)

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

[LookupEditorBase](LookupEditorBase.md).[createEditDialog](LookupEditorBase.md#createeditdialog)

#### Defined in

[src/ui/editors/comboboxeditor.ts:733](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L733)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[destroy](LookupEditorBase.md#destroy)

#### Defined in

[src/ui/editors/lookupeditor.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L31)

___

### editDialogDataChange

▸ **editDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[editDialogDataChange](LookupEditorBase.md#editdialogdatachange)

#### Defined in

[src/ui/editors/lookupeditor.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L141)

___

### emptyItemText

▸ **emptyItemText**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[emptyItemText](LookupEditorBase.md#emptyitemtext)

#### Defined in

[src/ui/editors/comboboxeditor.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L100)

___

### filterItems

▸ **filterItems**(`items`): {}[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | {}[] |

#### Returns

{}[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[filterItems](LookupEditorBase.md#filteritems)

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

[LookupEditorBase](LookupEditorBase.md).[getCascadeFromValue](LookupEditorBase.md#getcascadefromvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:568](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L568)

___

### getComboboxContainer

▸ **getComboboxContainer**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getComboboxContainer](LookupEditorBase.md#getcomboboxcontainer)

#### Defined in

[src/ui/editors/comboboxeditor.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L428)

___

### getComboboxOptions

▸ **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getComboboxOptions](LookupEditorBase.md#getcomboboxoptions)

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

[LookupEditorBase](LookupEditorBase.md).[getCreateSearchChoice](LookupEditorBase.md#getcreatesearchchoice)

#### Defined in

[src/ui/editors/comboboxeditor.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L363)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getCssClass](LookupEditorBase.md#getcssclass)

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

[LookupEditorBase](LookupEditorBase.md).[getCustomAttribute](LookupEditorBase.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getDialogTypeKey

▸ **getDialogTypeKey**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getDialogTypeKey](LookupEditorBase.md#getdialogtypekey)

#### Defined in

[src/ui/editors/lookupeditor.ts:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L129)

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

[LookupEditorBase](LookupEditorBase.md).[getEditValue](LookupEditorBase.md#geteditvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L419)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getFieldElement](LookupEditorBase.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getGridField](LookupEditorBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getIdField

▸ **getIdField**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getIdField](LookupEditorBase.md#getidfield)

#### Defined in

[src/ui/editors/lookupeditor.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L73)

___

### getItemDisabled

▸ **getItemDisabled**(`item`, `lookup`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Object` |
| `lookup` | [`Lookup`](Lookup.md)\<{}\> |

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getItemDisabled](LookupEditorBase.md#getitemdisabled)

#### Defined in

[src/ui/editors/lookupeditor.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L94)

___

### getItemText

▸ **getItemText**(`item`, `lookup`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Object` |
| `lookup` | [`Lookup`](Lookup.md)\<{}\> |

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getItemText](LookupEditorBase.md#getitemtext)

#### Defined in

[src/ui/editors/lookupeditor.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L77)

___

### getItems

▸ **getItems**(`lookup`): {}[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `lookup` | [`Lookup`](Lookup.md)\<{}\> |

#### Returns

{}[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getItems](LookupEditorBase.md#getitems)

#### Defined in

[src/ui/editors/lookupeditor.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L69)

___

### getLookup

▸ **getLookup**(): [`Lookup`](Lookup.md)\<{}\>

#### Returns

[`Lookup`](Lookup.md)\<{}\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getLookup](LookupEditorBase.md#getlookup)

#### Defined in

[src/ui/editors/lookupeditor.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L65)

___

### getLookupAsync

▸ **getLookupAsync**(): `PromiseLike`\<[`Lookup`](Lookup.md)\<{}\>\>

#### Returns

`PromiseLike`\<[`Lookup`](Lookup.md)\<{}\>\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getLookupAsync](LookupEditorBase.md#getlookupasync)

#### Defined in

[src/ui/editors/lookupeditor.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L61)

___

### getLookupKey

▸ **getLookupKey**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getLookupKey](LookupEditorBase.md#getlookupkey)

#### Defined in

[src/ui/editors/lookupeditor.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L40)

___

### getPageSize

▸ **getPageSize**(): `number`

#### Returns

`number`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getPageSize](LookupEditorBase.md#getpagesize)

#### Defined in

[src/ui/editors/comboboxeditor.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L105)

___

### getTextField

▸ **getTextField**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getTextField](LookupEditorBase.md#gettextfield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L120)

___

### getTypeDelay

▸ **getTypeDelay**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getTypeDelay](LookupEditorBase.md#gettypedelay)

#### Defined in

[src/ui/editors/comboboxeditor.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L96)

___

### get\_cascadeField

▸ **get_cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_cascadeField](LookupEditorBase.md#get_cascadefield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:612](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L612)

___

### get\_cascadeFrom

▸ **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_cascadeFrom](LookupEditorBase.md#get_cascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.ts:593](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L593)

___

### get\_cascadeValue

▸ **get_cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_cascadeValue](LookupEditorBase.md#get_cascadevalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L628)

___

### get\_delimited

▸ **get_delimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_delimited](LookupEditorBase.md#get_delimited)

#### Defined in

[src/ui/editors/comboboxeditor.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L238)

___

### get\_filterField

▸ **get_filterField**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_filterField](LookupEditorBase.md#get_filterfield)

#### Defined in

[src/ui/editors/comboboxeditor.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L648)

___

### get\_filterValue

▸ **get_filterValue**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_filterValue](LookupEditorBase.md#get_filtervalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L664)

___

### get\_itemByKey

▸ **get_itemByKey**(): `Object`

#### Returns

`Object`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_itemByKey](LookupEditorBase.md#get_itembykey)

#### Defined in

[src/ui/editors/comboboxeditor.ts:436](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L436)

___

### get\_items

▸ **get_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<{}\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<{}\>[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_items](LookupEditorBase.md#get_items)

#### Defined in

[src/ui/editors/comboboxeditor.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L432)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_readOnly](LookupEditorBase.md#get_readonly)

#### Defined in

[src/ui/editors/comboboxeditor.ts:538](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L538)

___

### get\_text

▸ **get_text**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_text](LookupEditorBase.md#get_text)

#### Defined in

[src/ui/editors/comboboxeditor.ts:526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L526)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_value](LookupEditorBase.md#get_value)

#### Defined in

[src/ui/editors/comboboxeditor.ts:462](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L462)

___

### get\_values

▸ **get_values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_values](LookupEditorBase.md#get_values)

#### Defined in

[src/ui/editors/comboboxeditor.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L510)

___

### hasAsyncSource

▸ **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[hasAsyncSource](LookupEditorBase.md#hasasyncsource)

#### Defined in

[src/ui/editors/lookupeditor.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L27)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[init](LookupEditorBase.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### initNewEntity

▸ **initNewEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `Object` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[initNewEntity](LookupEditorBase.md#initnewentity)

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

[LookupEditorBase](LookupEditorBase.md).[inplaceCreateClick](LookupEditorBase.md#inplacecreateclick)

#### Defined in

[src/ui/editors/comboboxeditor.ts:771](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L771)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[internalInit](LookupEditorBase.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[internalRenderContents](LookupEditorBase.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### isAutoComplete

▸ **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[isAutoComplete](LookupEditorBase.md#isautocomplete)

#### Defined in

[src/ui/editors/comboboxeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L359)

___

### isMultiple

▸ **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[isMultiple](LookupEditorBase.md#ismultiple)

#### Defined in

[src/ui/editors/comboboxeditor.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L153)

___

### itemDisabled

▸ **itemDisabled**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Object` |

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[itemDisabled](LookupEditorBase.md#itemdisabled)

#### Defined in

[src/ui/editors/comboboxeditor.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L131)

___

### itemId

▸ **itemId**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Object` |

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[itemId](LookupEditorBase.md#itemid)

#### Defined in

[src/ui/editors/comboboxeditor.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L113)

___

### itemText

▸ **itemText**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Object` |

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[itemText](LookupEditorBase.md#itemtext)

#### Defined in

[src/ui/editors/comboboxeditor.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L124)

___

### mapItem

▸ **mapItem**(`item`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<{}\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Object` |

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<{}\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[mapItem](LookupEditorBase.md#mapitem)

#### Defined in

[src/ui/editors/lookupeditor.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L85)

___

### mapItems

▸ **mapItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | {}[] |

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[mapItems](LookupEditorBase.md#mapitems)

#### Defined in

[src/ui/editors/comboboxeditor.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L144)

___

### openDropdown

▸ **openDropdown**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[openDropdown](LookupEditorBase.md#opendropdown)

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

[LookupEditorBase](LookupEditorBase.md).[render](LookupEditorBase.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[renderContents](LookupEditorBase.md#rendercontents)

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

[LookupEditorBase](LookupEditorBase.md).[setCascadeFrom](LookupEditorBase.md#setcascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L574)

___

### setCreateTermOnNewEntity

▸ **setCreateTermOnNewEntity**(`entity`, `term`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `Object` |
| `term` | `string` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[setCreateTermOnNewEntity](LookupEditorBase.md#setcreatetermonnewentity)

#### Defined in

[src/ui/editors/lookupeditor.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L137)

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

[LookupEditorBase](LookupEditorBase.md).[setEditDialogReadOnly](LookupEditorBase.md#seteditdialogreadonly)

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

[LookupEditorBase](LookupEditorBase.md).[setEditValue](LookupEditorBase.md#seteditvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L409)

___

### setTermOnNewEntity

▸ **setTermOnNewEntity**(`entity`, `term`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `Object` |
| `term` | `string` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[setTermOnNewEntity](LookupEditorBase.md#settermonnewentity)

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

[LookupEditorBase](LookupEditorBase.md).[set_cascadeField](LookupEditorBase.md#set_cascadefield)

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

[LookupEditorBase](LookupEditorBase.md).[set_cascadeFrom](LookupEditorBase.md#set_cascadefrom)

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

[LookupEditorBase](LookupEditorBase.md).[set_cascadeValue](LookupEditorBase.md#set_cascadevalue)

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

[LookupEditorBase](LookupEditorBase.md).[set_filterField](LookupEditorBase.md#set_filterfield)

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

[LookupEditorBase](LookupEditorBase.md).[set_filterValue](LookupEditorBase.md#set_filtervalue)

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

[LookupEditorBase](LookupEditorBase.md).[set_readOnly](LookupEditorBase.md#set_readonly)

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

[LookupEditorBase](LookupEditorBase.md).[set_value](LookupEditorBase.md#set_value)

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

[LookupEditorBase](LookupEditorBase.md).[set_values](LookupEditorBase.md#set_values)

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

[LookupEditorBase](LookupEditorBase.md).[syncOrAsyncThen](LookupEditorBase.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### updateItems

▸ **updateItems**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[updateItems](LookupEditorBase.md#updateitems)

#### Defined in

[src/ui/editors/lookupeditor.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L98)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[useIdPrefix](LookupEditorBase.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### useInplaceAdd

▸ **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[useInplaceAdd](LookupEditorBase.md#useinplaceadd)

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

[LookupEditorBase](LookupEditorBase.md).[create](LookupEditorBase.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[createDefaultElement](LookupEditorBase.md#createdefaultelement)

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

[LookupEditorBase](LookupEditorBase.md).[filterByText](LookupEditorBase.md#filterbytext)

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

[LookupEditorBase](LookupEditorBase.md).[getWidgetName](LookupEditorBase.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
