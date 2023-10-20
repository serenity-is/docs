[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / LookupEditor

# Class: LookupEditor

## Hierarchy

- [`LookupEditorBase`](LookupEditorBase.md)<[`LookupEditorOptions`](../interfaces/LookupEditorOptions.md), `any`\>

  ↳ **`LookupEditor`**

## Table of contents

### Constructors

- [constructor](LookupEditor.md#constructor)

### Properties

- [cascadeLink](LookupEditor.md#cascadelink)
- [element](LookupEditor.md#element)
- [idPrefix](LookupEditor.md#idprefix)
- [lastCreateTerm](LookupEditor.md#lastcreateterm)
- [lookup](LookupEditor.md#lookup)
- [onInitNewEntity](LookupEditor.md#oninitnewentity)
- [openDialogAsPanel](LookupEditor.md#opendialogaspanel)
- [options](LookupEditor.md#options)
- [uniqueName](LookupEditor.md#uniquename)
- [widgetName](LookupEditor.md#widgetname)

### Accessors

- [cascadeField](LookupEditor.md#cascadefield)
- [cascadeFrom](LookupEditor.md#cascadefrom)
- [cascadeValue](LookupEditor.md#cascadevalue)
- [filterField](LookupEditor.md#filterfield)
- [filterValue](LookupEditor.md#filtervalue)
- [itemById](LookupEditor.md#itembyid)
- [items](LookupEditor.md#items)
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
- [getCreateSearchChoice](LookupEditor.md#getcreatesearchchoice)
- [getCssClass](LookupEditor.md#getcssclass)
- [getDialogTypeKey](LookupEditor.md#getdialogtypekey)
- [getEditValue](LookupEditor.md#geteditvalue)
- [getGridField](LookupEditor.md#getgridfield)
- [getIdField](LookupEditor.md#getidfield)
- [getItemDisabled](LookupEditor.md#getitemdisabled)
- [getItemText](LookupEditor.md#getitemtext)
- [getItems](LookupEditor.md#getitems)
- [getLookup](LookupEditor.md#getlookup)
- [getLookupAsync](LookupEditor.md#getlookupasync)
- [getLookupKey](LookupEditor.md#getlookupkey)
- [getPageSize](LookupEditor.md#getpagesize)
- [getSelect2Options](LookupEditor.md#getselect2options)
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
- [get\_select2Container](LookupEditor.md#get_select2container)
- [get\_text](LookupEditor.md#get_text)
- [get\_value](LookupEditor.md#get_value)
- [get\_values](LookupEditor.md#get_values)
- [hasAsyncSource](LookupEditor.md#hasasyncsource)
- [init](LookupEditor.md#init)
- [initNewEntity](LookupEditor.md#initnewentity)
- [initialize](LookupEditor.md#initialize)
- [inplaceCreateClick](LookupEditor.md#inplacecreateclick)
- [isAutoComplete](LookupEditor.md#isautocomplete)
- [isMultiple](LookupEditor.md#ismultiple)
- [itemDisabled](LookupEditor.md#itemdisabled)
- [itemId](LookupEditor.md#itemid)
- [itemText](LookupEditor.md#itemtext)
- [mapItem](LookupEditor.md#mapitem)
- [mapItems](LookupEditor.md#mapitems)
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
- [updateItems](LookupEditor.md#updateitems)
- [useInplaceAdd](LookupEditor.md#useinplaceadd)
- [create](LookupEditor.md#create)
- [elementFor](LookupEditor.md#elementfor)
- [filterByText](LookupEditor.md#filterbytext)
- [getWidgetName](LookupEditor.md#getwidgetname)

## Constructors

### constructor

• **new LookupEditor**(`hidden`, `opt?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `hidden` | `JQuery` |
| `opt?` | [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md) |

#### Overrides

[LookupEditorBase](LookupEditorBase.md).[constructor](LookupEditorBase.md#constructor)

#### Defined in

[src/ui/editors/lookupeditor.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L148)

## Properties

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)<[`Widget`](Widget.md)<`any`\>\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[cascadeLink](LookupEditorBase.md#cascadelink)

#### Defined in

[src/ui/editors/select2editor.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L701)

___

### element

• **element**: `JQuery`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[element](LookupEditorBase.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[idPrefix](LookupEditorBase.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### lastCreateTerm

• `Protected` **lastCreateTerm**: `string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[lastCreateTerm](LookupEditorBase.md#lastcreateterm)

#### Defined in

[src/ui/editors/select2editor.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L64)

___

### lookup

• `Protected` **lookup**: [`Lookup`](Lookup.md)<`any`\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[lookup](LookupEditorBase.md#lookup)

#### Defined in

[src/ui/editors/lookupeditor.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L56)

___

### onInitNewEntity

• **onInitNewEntity**: (`entity`: `any`) => `void`

#### Type declaration

▸ (`entity`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `any` |

##### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[onInitNewEntity](LookupEditorBase.md#oninitnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:871](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L871)

___

### openDialogAsPanel

• **openDialogAsPanel**: `boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[openDialogAsPanel](LookupEditorBase.md#opendialogaspanel)

#### Defined in

[src/ui/editors/select2editor.ts:972](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L972)

___

### options

• `Protected` **options**: [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md)

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[options](LookupEditorBase.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[uniqueName](LookupEditorBase.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[widgetName](LookupEditorBase.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.cascadeField

#### Defined in

[src/ui/editors/select2editor.ts:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L745)

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

[src/ui/editors/select2editor.ts:753](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L753)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.cascadeFrom

#### Defined in

[src/ui/editors/select2editor.ts:726](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L726)

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

[src/ui/editors/select2editor.ts:737](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L737)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

LookupEditorBase.cascadeValue

#### Defined in

[src/ui/editors/select2editor.ts:761](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L761)

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

[src/ui/editors/select2editor.ts:773](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L773)

___

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.filterField

#### Defined in

[src/ui/editors/select2editor.ts:781](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L781)

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

[src/ui/editors/select2editor.ts:789](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L789)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Inherited from

LookupEditorBase.filterValue

#### Defined in

[src/ui/editors/select2editor.ts:797](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L797)

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

[src/ui/editors/select2editor.ts:809](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L809)

___

### itemById

• `Protected` `get` **itemById**(): `Object`

#### Returns

`Object`

#### Inherited from

LookupEditorBase.itemById

#### Defined in

[src/ui/editors/select2editor.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L349)

• `Protected` `set` **itemById**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Object` |

#### Returns

`void`

#### Inherited from

LookupEditorBase.itemById

#### Defined in

[src/ui/editors/select2editor.ts:356](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L356)

___

### items

• `get` **items**(): `Select2Item`[]

#### Returns

`Select2Item`[]

#### Inherited from

LookupEditorBase.items

#### Defined in

[src/ui/editors/select2editor.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L332)

• `set` **items**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Select2Item`[] |

#### Returns

`void`

#### Inherited from

LookupEditorBase.items

#### Defined in

[src/ui/editors/select2editor.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L339)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

LookupEditorBase.readOnly

#### Defined in

[src/ui/editors/select2editor.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L672)

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

[src/ui/editors/select2editor.ts:693](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L693)

___

### selectedItem

• `get` **selectedItem**(): `TItem`

#### Returns

`TItem`

#### Inherited from

LookupEditorBase.selectedItem

#### Defined in

[src/ui/editors/select2editor.ts:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L598)

___

### selectedItems

• `get` **selectedItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

LookupEditorBase.selectedItems

#### Defined in

[src/ui/editors/select2editor.ts:608](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L608)

___

### text

• `get` **text**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.text

#### Defined in

[src/ui/editors/select2editor.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L664)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

LookupEditorBase.value

#### Defined in

[src/ui/editors/select2editor.ts:565](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L565)

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

[src/ui/editors/select2editor.ts:594](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L594)

___

### values

• `get` **values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

LookupEditorBase.values

#### Defined in

[src/ui/editors/select2editor.ts:642](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L642)

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

[src/ui/editors/select2editor.ts:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L656)

## Methods

### abortPendingQuery

▸ `Protected` **abortPendingQuery**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[abortPendingQuery](LookupEditorBase.md#abortpendingquery)

#### Defined in

[src/ui/editors/select2editor.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L175)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[addCssClass](LookupEditorBase.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addInplaceCreate

▸ `Protected` **addInplaceCreate**(`addTitle`, `editTitle`): `void`

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

[src/ui/editors/select2editor.ts:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L388)

___

### addItem

▸ **addItem**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Select2Item` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[addItem](LookupEditorBase.md#additem)

#### Defined in

[src/ui/editors/select2editor.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L371)

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

[src/ui/editors/select2editor.ts:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L379)

___

### addValidationRule

▸ **addValidationRule**(`eventClass`, `rule`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `eventClass` | `string` |
| `rule` | (`p1`: `JQuery`) => `string` |

#### Returns

`JQuery`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[addValidationRule](LookupEditorBase.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### allowClear

▸ `Protected` **allowClear**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[allowClear](LookupEditorBase.md#allowclear)

#### Defined in

[src/ui/editors/select2editor.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L162)

___

### asyncSearch

▸ `Protected` **asyncSearch**(`query`, `results`): [`Select2SearchPromise`](../interfaces/Select2SearchPromise.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/Select2SearchQuery.md) |
| `results` | (`result`: [`Select2SearchResult`](../interfaces/Select2SearchResult.md)<`any`\>) => `void` |

#### Returns

[`Select2SearchPromise`](../interfaces/Select2SearchPromise.md)

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[asyncSearch](LookupEditorBase.md#asyncsearch)

#### Defined in

[src/ui/editors/lookupeditor.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L106)

___

### cascadeItems

▸ `Protected` **cascadeItems**(`items`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `any`[] |

#### Returns

`any`[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[cascadeItems](LookupEditorBase.md#cascadeitems)

#### Defined in

[src/ui/editors/select2editor.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L813)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[change](LookupEditorBase.md#change)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[change](LookupEditorBase.md#change)

#### Defined in

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L259)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[changeSelect2](LookupEditorBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[changeSelect2](LookupEditorBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### clearItems

▸ **clearItems**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[clearItems](LookupEditorBase.md#clearitems)

#### Defined in

[src/ui/editors/select2editor.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L363)

___

### createEditDialog

▸ `Protected` **createEditDialog**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`dlg`: [`IEditDialog`](IEditDialog.md)) => `void` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[createEditDialog](LookupEditorBase.md#createeditdialog)

#### Defined in

[src/ui/editors/select2editor.ts:862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L862)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[destroy](LookupEditorBase.md#destroy)

#### Defined in

[src/ui/editors/lookupeditor.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L30)

___

### editDialogDataChange

▸ `Protected` **editDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[editDialogDataChange](LookupEditorBase.md#editdialogdatachange)

#### Defined in

[src/ui/editors/lookupeditor.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L141)

___

### emptyItemText

▸ `Protected` **emptyItemText**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[emptyItemText](LookupEditorBase.md#emptyitemtext)

#### Defined in

[src/ui/editors/select2editor.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L114)

___

### filterItems

▸ `Protected` **filterItems**(`items`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `any`[] |

#### Returns

`any`[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[filterItems](LookupEditorBase.md#filteritems)

#### Defined in

[src/ui/editors/select2editor.ts:835](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L835)

___

### getCascadeFromValue

▸ `Protected` **getCascadeFromValue**(`parent`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `parent` | [`Widget`](Widget.md)<`any`\> |

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getCascadeFromValue](LookupEditorBase.md#getcascadefromvalue)

#### Defined in

[src/ui/editors/select2editor.ts:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L697)

___

### getCreateSearchChoice

▸ **getCreateSearchChoice**(`getName`): (`s`: `string`) => { `id`: `string` ; `text`: `string`  }

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

[src/ui/editors/select2editor.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L450)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getCssClass](LookupEditorBase.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getDialogTypeKey

▸ `Protected` **getDialogTypeKey**(): `string`

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

[src/ui/editors/select2editor.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L508)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getGridField](LookupEditorBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdField

▸ `Protected` **getIdField**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getIdField](LookupEditorBase.md#getidfield)

#### Defined in

[src/ui/editors/lookupeditor.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L70)

___

### getItemDisabled

▸ `Protected` **getItemDisabled**(`item`, `lookup`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |
| `lookup` | [`Lookup`](Lookup.md)<`any`\> |

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getItemDisabled](LookupEditorBase.md#getitemdisabled)

#### Defined in

[src/ui/editors/lookupeditor.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L91)

___

### getItemText

▸ `Protected` **getItemText**(`item`, `lookup`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |
| `lookup` | [`Lookup`](Lookup.md)<`any`\> |

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getItemText](LookupEditorBase.md#getitemtext)

#### Defined in

[src/ui/editors/lookupeditor.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L74)

___

### getItems

▸ `Protected` **getItems**(`lookup`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `lookup` | [`Lookup`](Lookup.md)<`any`\> |

#### Returns

`any`[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getItems](LookupEditorBase.md#getitems)

#### Defined in

[src/ui/editors/lookupeditor.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L66)

___

### getLookup

▸ `Protected` **getLookup**(): [`Lookup`](Lookup.md)<`any`\>

#### Returns

[`Lookup`](Lookup.md)<`any`\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getLookup](LookupEditorBase.md#getlookup)

#### Defined in

[src/ui/editors/lookupeditor.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L62)

___

### getLookupAsync

▸ `Protected` **getLookupAsync**(): `PromiseLike`<[`Lookup`](Lookup.md)<`any`\>\>

#### Returns

`PromiseLike`<[`Lookup`](Lookup.md)<`any`\>\>

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getLookupAsync](LookupEditorBase.md#getlookupasync)

#### Defined in

[src/ui/editors/lookupeditor.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L58)

___

### getLookupKey

▸ `Protected` **getLookupKey**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getLookupKey](LookupEditorBase.md#getlookupkey)

#### Defined in

[src/ui/editors/lookupeditor.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L37)

___

### getPageSize

▸ `Protected` **getPageSize**(): `number`

#### Returns

`number`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getPageSize](LookupEditorBase.md#getpagesize)

#### Defined in

[src/ui/editors/select2editor.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L119)

___

### getSelect2Options

▸ `Protected` **getSelect2Options**(): `Select2Options`

#### Returns

`Select2Options`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getSelect2Options](LookupEditorBase.md#getselect2options)

#### Defined in

[src/ui/editors/select2editor.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L184)

___

### getTextField

▸ `Protected` **getTextField**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getTextField](LookupEditorBase.md#gettextfield)

#### Defined in

[src/ui/editors/select2editor.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L134)

___

### getTypeDelay

▸ `Protected` **getTypeDelay**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getTypeDelay](LookupEditorBase.md#gettypedelay)

#### Defined in

[src/ui/editors/select2editor.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L110)

___

### get\_cascadeField

▸ `Protected` **get_cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_cascadeField](LookupEditorBase.md#get_cascadefield)

#### Defined in

[src/ui/editors/select2editor.ts:741](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L741)

___

### get\_cascadeFrom

▸ `Protected` **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_cascadeFrom](LookupEditorBase.md#get_cascadefrom)

#### Defined in

[src/ui/editors/select2editor.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L722)

___

### get\_cascadeValue

▸ `Protected` **get_cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_cascadeValue](LookupEditorBase.md#get_cascadevalue)

#### Defined in

[src/ui/editors/select2editor.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L757)

___

### get\_delimited

▸ **get_delimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_delimited](LookupEditorBase.md#get_delimited)

#### Defined in

[src/ui/editors/select2editor.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L328)

___

### get\_filterField

▸ `Protected` **get_filterField**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_filterField](LookupEditorBase.md#get_filterfield)

#### Defined in

[src/ui/editors/select2editor.ts:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L777)

___

### get\_filterValue

▸ `Protected` **get_filterValue**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_filterValue](LookupEditorBase.md#get_filtervalue)

#### Defined in

[src/ui/editors/select2editor.ts:793](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L793)

___

### get\_itemByKey

▸ `Protected` **get_itemByKey**(): `Object`

#### Returns

`Object`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_itemByKey](LookupEditorBase.md#get_itembykey)

#### Defined in

[src/ui/editors/select2editor.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L525)

___

### get\_items

▸ `Protected` **get_items**(): `Select2Item`[]

#### Returns

`Select2Item`[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_items](LookupEditorBase.md#get_items)

#### Defined in

[src/ui/editors/select2editor.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L521)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_readOnly](LookupEditorBase.md#get_readonly)

#### Defined in

[src/ui/editors/select2editor.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L668)

___

### get\_select2Container

▸ `Protected` **get_select2Container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_select2Container](LookupEditorBase.md#get_select2container)

#### Defined in

[src/ui/editors/select2editor.ts:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L517)

___

### get\_text

▸ `Protected` **get_text**(): `string`

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_text](LookupEditorBase.md#get_text)

#### Defined in

[src/ui/editors/select2editor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L660)

___

### get\_value

▸ **get_value**(): `any`

#### Returns

`any`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_value](LookupEditorBase.md#get_value)

#### Defined in

[src/ui/editors/select2editor.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L551)

___

### get\_values

▸ `Protected` **get_values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[get_values](LookupEditorBase.md#get_values)

#### Defined in

[src/ui/editors/select2editor.ts:623](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L623)

___

### hasAsyncSource

▸ **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[hasAsyncSource](LookupEditorBase.md#hasasyncsource)

#### Defined in

[src/ui/editors/lookupeditor.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L26)

___

### init

▸ **init**(`action?`): [`LookupEditor`](LookupEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`LookupEditor`](LookupEditor.md)

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[init](LookupEditorBase.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initNewEntity

▸ `Protected` **initNewEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `any` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[initNewEntity](LookupEditorBase.md#initnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:873](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L873)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[initialize](LookupEditorBase.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### inplaceCreateClick

▸ `Protected` **inplaceCreateClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[inplaceCreateClick](LookupEditorBase.md#inplacecreateclick)

#### Defined in

[src/ui/editors/select2editor.ts:901](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L901)

___

### isAutoComplete

▸ `Protected` **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[isAutoComplete](LookupEditorBase.md#isautocomplete)

#### Defined in

[src/ui/editors/select2editor.ts:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L446)

___

### isMultiple

▸ `Protected` **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[isMultiple](LookupEditorBase.md#ismultiple)

#### Defined in

[src/ui/editors/select2editor.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L167)

___

### itemDisabled

▸ `Protected` **itemDisabled**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[itemDisabled](LookupEditorBase.md#itemdisabled)

#### Defined in

[src/ui/editors/select2editor.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L145)

___

### itemId

▸ `Protected` **itemId**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[itemId](LookupEditorBase.md#itemid)

#### Defined in

[src/ui/editors/select2editor.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L127)

___

### itemText

▸ `Protected` **itemText**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[itemText](LookupEditorBase.md#itemtext)

#### Defined in

[src/ui/editors/select2editor.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L138)

___

### mapItem

▸ `Protected` **mapItem**(`item`): `Select2Item`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`Select2Item`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[mapItem](LookupEditorBase.md#mapitem)

#### Defined in

[src/ui/editors/lookupeditor.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L82)

___

### mapItems

▸ `Protected` **mapItems**(`items`): `Select2Item`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `any`[] |

#### Returns

`Select2Item`[]

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[mapItems](LookupEditorBase.md#mapitems)

#### Defined in

[src/ui/editors/select2editor.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L158)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[renderContents](LookupEditorBase.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### setCascadeFrom

▸ `Protected` **setCascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[setCascadeFrom](LookupEditorBase.md#setcascadefrom)

#### Defined in

[src/ui/editors/select2editor.ts:703](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L703)

___

### setCreateTermOnNewEntity

▸ `Protected` **setCreateTermOnNewEntity**(`entity`, `term`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `any` |
| `term` | `string` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[setCreateTermOnNewEntity](LookupEditorBase.md#setcreatetermonnewentity)

#### Defined in

[src/ui/editors/lookupeditor.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L137)

___

### setEditDialogReadOnly

▸ `Protected` **setEditDialogReadOnly**(`dialog`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | `any` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[setEditDialogReadOnly](LookupEditorBase.md#seteditdialogreadonly)

#### Defined in

[src/ui/editors/select2editor.ts:887](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L887)

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

[src/ui/editors/select2editor.ts:498](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L498)

___

### setTermOnNewEntity

▸ `Protected` **setTermOnNewEntity**(`entity`, `term`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `any` |
| `term` | `string` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[setTermOnNewEntity](LookupEditorBase.md#settermonnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:898](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L898)

___

### set\_cascadeField

▸ `Protected` **set_cascadeField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[set_cascadeField](LookupEditorBase.md#set_cascadefield)

#### Defined in

[src/ui/editors/select2editor.ts:749](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L749)

___

### set\_cascadeFrom

▸ `Protected` **set_cascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[set_cascadeFrom](LookupEditorBase.md#set_cascadefrom)

#### Defined in

[src/ui/editors/select2editor.ts:730](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L730)

___

### set\_cascadeValue

▸ `Protected` **set_cascadeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[set_cascadeValue](LookupEditorBase.md#set_cascadevalue)

#### Defined in

[src/ui/editors/select2editor.ts:765](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L765)

___

### set\_filterField

▸ `Protected` **set_filterField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[set_filterField](LookupEditorBase.md#set_filterfield)

#### Defined in

[src/ui/editors/select2editor.ts:785](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L785)

___

### set\_filterValue

▸ `Protected` **set_filterValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[set_filterValue](LookupEditorBase.md#set_filtervalue)

#### Defined in

[src/ui/editors/select2editor.ts:801](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L801)

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

[src/ui/editors/select2editor.ts:686](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L686)

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

[src/ui/editors/select2editor.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L569)

___

### set\_values

▸ `Protected` **set_values**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string`[] |

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[set_values](LookupEditorBase.md#set_values)

#### Defined in

[src/ui/editors/select2editor.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L646)

___

### updateItems

▸ **updateItems**(): `void`

#### Returns

`void`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[updateItems](LookupEditorBase.md#updateitems)

#### Defined in

[src/ui/editors/lookupeditor.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L95)

___

### useInplaceAdd

▸ `Protected` **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[useInplaceAdd](LookupEditorBase.md#useinplaceadd)

#### Defined in

[src/ui/editors/select2editor.ts:439](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L439)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[create](LookupEditorBase.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

___

### elementFor

▸ `Static` **elementFor**<`TWidget`\>(`editorType`): `JQuery`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `editorType` | (...`args`: `any`[]) => `TWidget` |

#### Returns

`JQuery`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[elementFor](LookupEditorBase.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

___

### filterByText

▸ `Static` **filterByText**<`TItem`\>(`items`, `getText`, `term`): `TItem`[]

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

[src/ui/editors/select2editor.ts:529](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L529)

___

### getWidgetName

▸ `Static` **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[LookupEditorBase](LookupEditorBase.md).[getWidgetName](LookupEditorBase.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
