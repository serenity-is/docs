[@serenity-is/corelib](../README.md) / LookupEditorBase

# Class: LookupEditorBase<TOptions, TItem\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TOptions` | extends [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md) |
| `TItem` | `TItem` |

## Hierarchy

- [`Select2Editor`](Select2Editor.md)<`TOptions`, `TItem`\>

  ↳ **`LookupEditorBase`**

  ↳↳ [`LookupEditor`](LookupEditor.md)

## Table of contents

### Constructors

- [constructor](LookupEditorBase.md#constructor)

### Properties

- [cascadeLink](LookupEditorBase.md#cascadelink)
- [element](LookupEditorBase.md#element)
- [idPrefix](LookupEditorBase.md#idprefix)
- [lastCreateTerm](LookupEditorBase.md#lastcreateterm)
- [lookup](LookupEditorBase.md#lookup)
- [onInitNewEntity](LookupEditorBase.md#oninitnewentity)
- [openDialogAsPanel](LookupEditorBase.md#opendialogaspanel)
- [options](LookupEditorBase.md#options)
- [uniqueName](LookupEditorBase.md#uniquename)
- [widgetName](LookupEditorBase.md#widgetname)

### Accessors

- [cascadeField](LookupEditorBase.md#cascadefield)
- [cascadeFrom](LookupEditorBase.md#cascadefrom)
- [cascadeValue](LookupEditorBase.md#cascadevalue)
- [filterField](LookupEditorBase.md#filterfield)
- [filterValue](LookupEditorBase.md#filtervalue)
- [itemById](LookupEditorBase.md#itembyid)
- [items](LookupEditorBase.md#items)
- [readOnly](LookupEditorBase.md#readonly)
- [selectedItem](LookupEditorBase.md#selecteditem)
- [selectedItems](LookupEditorBase.md#selecteditems)
- [text](LookupEditorBase.md#text)
- [value](LookupEditorBase.md#value)
- [values](LookupEditorBase.md#values)

### Methods

- [abortPendingQuery](LookupEditorBase.md#abortpendingquery)
- [addCssClass](LookupEditorBase.md#addcssclass)
- [addInplaceCreate](LookupEditorBase.md#addinplacecreate)
- [addItem](LookupEditorBase.md#additem)
- [addOption](LookupEditorBase.md#addoption)
- [addValidationRule](LookupEditorBase.md#addvalidationrule)
- [allowClear](LookupEditorBase.md#allowclear)
- [asyncSearch](LookupEditorBase.md#asyncsearch)
- [cascadeItems](LookupEditorBase.md#cascadeitems)
- [change](LookupEditorBase.md#change)
- [changeSelect2](LookupEditorBase.md#changeselect2)
- [clearItems](LookupEditorBase.md#clearitems)
- [createEditDialog](LookupEditorBase.md#createeditdialog)
- [destroy](LookupEditorBase.md#destroy)
- [editDialogDataChange](LookupEditorBase.md#editdialogdatachange)
- [emptyItemText](LookupEditorBase.md#emptyitemtext)
- [filterItems](LookupEditorBase.md#filteritems)
- [getCascadeFromValue](LookupEditorBase.md#getcascadefromvalue)
- [getCreateSearchChoice](LookupEditorBase.md#getcreatesearchchoice)
- [getCssClass](LookupEditorBase.md#getcssclass)
- [getDialogTypeKey](LookupEditorBase.md#getdialogtypekey)
- [getEditValue](LookupEditorBase.md#geteditvalue)
- [getGridField](LookupEditorBase.md#getgridfield)
- [getIdField](LookupEditorBase.md#getidfield)
- [getItemDisabled](LookupEditorBase.md#getitemdisabled)
- [getItemText](LookupEditorBase.md#getitemtext)
- [getItems](LookupEditorBase.md#getitems)
- [getLookup](LookupEditorBase.md#getlookup)
- [getLookupAsync](LookupEditorBase.md#getlookupasync)
- [getLookupKey](LookupEditorBase.md#getlookupkey)
- [getPageSize](LookupEditorBase.md#getpagesize)
- [getSelect2Options](LookupEditorBase.md#getselect2options)
- [getTextField](LookupEditorBase.md#gettextfield)
- [getTypeDelay](LookupEditorBase.md#gettypedelay)
- [get\_cascadeField](LookupEditorBase.md#get_cascadefield)
- [get\_cascadeFrom](LookupEditorBase.md#get_cascadefrom)
- [get\_cascadeValue](LookupEditorBase.md#get_cascadevalue)
- [get\_delimited](LookupEditorBase.md#get_delimited)
- [get\_filterField](LookupEditorBase.md#get_filterfield)
- [get\_filterValue](LookupEditorBase.md#get_filtervalue)
- [get\_itemByKey](LookupEditorBase.md#get_itembykey)
- [get\_items](LookupEditorBase.md#get_items)
- [get\_readOnly](LookupEditorBase.md#get_readonly)
- [get\_select2Container](LookupEditorBase.md#get_select2container)
- [get\_text](LookupEditorBase.md#get_text)
- [get\_value](LookupEditorBase.md#get_value)
- [get\_values](LookupEditorBase.md#get_values)
- [hasAsyncSource](LookupEditorBase.md#hasasyncsource)
- [init](LookupEditorBase.md#init)
- [initNewEntity](LookupEditorBase.md#initnewentity)
- [initialize](LookupEditorBase.md#initialize)
- [inplaceCreateClick](LookupEditorBase.md#inplacecreateclick)
- [isAutoComplete](LookupEditorBase.md#isautocomplete)
- [isMultiple](LookupEditorBase.md#ismultiple)
- [itemDisabled](LookupEditorBase.md#itemdisabled)
- [itemId](LookupEditorBase.md#itemid)
- [itemText](LookupEditorBase.md#itemtext)
- [mapItem](LookupEditorBase.md#mapitem)
- [mapItems](LookupEditorBase.md#mapitems)
- [renderContents](LookupEditorBase.md#rendercontents)
- [setCascadeFrom](LookupEditorBase.md#setcascadefrom)
- [setCreateTermOnNewEntity](LookupEditorBase.md#setcreatetermonnewentity)
- [setEditDialogReadOnly](LookupEditorBase.md#seteditdialogreadonly)
- [setEditValue](LookupEditorBase.md#seteditvalue)
- [setTermOnNewEntity](LookupEditorBase.md#settermonnewentity)
- [set\_cascadeField](LookupEditorBase.md#set_cascadefield)
- [set\_cascadeFrom](LookupEditorBase.md#set_cascadefrom)
- [set\_cascadeValue](LookupEditorBase.md#set_cascadevalue)
- [set\_filterField](LookupEditorBase.md#set_filterfield)
- [set\_filterValue](LookupEditorBase.md#set_filtervalue)
- [set\_readOnly](LookupEditorBase.md#set_readonly)
- [set\_value](LookupEditorBase.md#set_value)
- [set\_values](LookupEditorBase.md#set_values)
- [updateItems](LookupEditorBase.md#updateitems)
- [useInplaceAdd](LookupEditorBase.md#useinplaceadd)
- [create](LookupEditorBase.md#create)
- [elementFor](LookupEditorBase.md#elementfor)
- [filterByText](LookupEditorBase.md#filterbytext)
- [getWidgetName](LookupEditorBase.md#getwidgetname)

## Constructors

### constructor

• **new LookupEditorBase**<`TOptions`, `TItem`\>(`input`, `opt?`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOptions` | extends [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md) |
| `TItem` | `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |
| `opt?` | `TOptions` |

#### Overrides

[Select2Editor](Select2Editor.md).[constructor](Select2Editor.md#constructor)

#### Defined in

[src/ui/editors/lookupeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L13)

## Properties

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)<[`Widget`](Widget.md)<`any`\>\>

#### Inherited from

[Select2Editor](Select2Editor.md).[cascadeLink](Select2Editor.md#cascadelink)

#### Defined in

[src/ui/editors/select2editor.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L701)

___

### element

• **element**: `JQuery`

#### Inherited from

[Select2Editor](Select2Editor.md).[element](Select2Editor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Select2Editor](Select2Editor.md).[idPrefix](Select2Editor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### lastCreateTerm

• `Protected` **lastCreateTerm**: `string`

#### Inherited from

[Select2Editor](Select2Editor.md).[lastCreateTerm](Select2Editor.md#lastcreateterm)

#### Defined in

[src/ui/editors/select2editor.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L64)

___

### lookup

• `Protected` **lookup**: [`Lookup`](Lookup.md)<`TItem`\>

#### Defined in

[src/ui/editors/lookupeditor.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L56)

___

### onInitNewEntity

• **onInitNewEntity**: (`entity`: `TItem`) => `void`

#### Type declaration

▸ (`entity`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |

##### Returns

`void`

#### Inherited from

[Select2Editor](Select2Editor.md).[onInitNewEntity](Select2Editor.md#oninitnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:871](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L871)

___

### openDialogAsPanel

• **openDialogAsPanel**: `boolean`

#### Inherited from

[Select2Editor](Select2Editor.md).[openDialogAsPanel](Select2Editor.md#opendialogaspanel)

#### Defined in

[src/ui/editors/select2editor.ts:972](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L972)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[Select2Editor](Select2Editor.md).[options](Select2Editor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Select2Editor](Select2Editor.md).[uniqueName](Select2Editor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Select2Editor](Select2Editor.md).[widgetName](Select2Editor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

Select2Editor.cascadeField

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

Select2Editor.cascadeField

#### Defined in

[src/ui/editors/select2editor.ts:753](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L753)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

Select2Editor.cascadeFrom

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

Select2Editor.cascadeFrom

#### Defined in

[src/ui/editors/select2editor.ts:737](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L737)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

Select2Editor.cascadeValue

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

Select2Editor.cascadeValue

#### Defined in

[src/ui/editors/select2editor.ts:773](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L773)

___

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Inherited from

Select2Editor.filterField

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

Select2Editor.filterField

#### Defined in

[src/ui/editors/select2editor.ts:789](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L789)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Inherited from

Select2Editor.filterValue

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

Select2Editor.filterValue

#### Defined in

[src/ui/editors/select2editor.ts:809](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L809)

___

### itemById

• `Protected` `get` **itemById**(): `Object`

#### Returns

`Object`

#### Inherited from

Select2Editor.itemById

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

Select2Editor.itemById

#### Defined in

[src/ui/editors/select2editor.ts:356](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L356)

___

### items

• `get` **items**(): `Select2Item`[]

#### Returns

`Select2Item`[]

#### Inherited from

Select2Editor.items

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

Select2Editor.items

#### Defined in

[src/ui/editors/select2editor.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L339)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

Select2Editor.readOnly

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

Select2Editor.readOnly

#### Defined in

[src/ui/editors/select2editor.ts:693](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L693)

___

### selectedItem

• `get` **selectedItem**(): `TItem`

#### Returns

`TItem`

#### Inherited from

Select2Editor.selectedItem

#### Defined in

[src/ui/editors/select2editor.ts:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L598)

___

### selectedItems

• `get` **selectedItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

Select2Editor.selectedItems

#### Defined in

[src/ui/editors/select2editor.ts:608](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L608)

___

### text

• `get` **text**(): `string`

#### Returns

`string`

#### Inherited from

Select2Editor.text

#### Defined in

[src/ui/editors/select2editor.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L664)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

Select2Editor.value

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

Select2Editor.value

#### Defined in

[src/ui/editors/select2editor.ts:594](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L594)

___

### values

• `get` **values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

Select2Editor.values

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

Select2Editor.values

#### Defined in

[src/ui/editors/select2editor.ts:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L656)

## Methods

### abortPendingQuery

▸ `Protected` **abortPendingQuery**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](Select2Editor.md).[abortPendingQuery](Select2Editor.md#abortpendingquery)

#### Defined in

[src/ui/editors/select2editor.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L175)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](Select2Editor.md).[addCssClass](Select2Editor.md#addcssclass)

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

[Select2Editor](Select2Editor.md).[addInplaceCreate](Select2Editor.md#addinplacecreate)

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

[Select2Editor](Select2Editor.md).[addItem](Select2Editor.md#additem)

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

[Select2Editor](Select2Editor.md).[addOption](Select2Editor.md#addoption)

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

[Select2Editor](Select2Editor.md).[addValidationRule](Select2Editor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### allowClear

▸ `Protected` **allowClear**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](Select2Editor.md).[allowClear](Select2Editor.md#allowclear)

#### Defined in

[src/ui/editors/select2editor.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L162)

___

### asyncSearch

▸ `Protected` **asyncSearch**(`query`, `results`): [`Select2SearchPromise`](../interfaces/Select2SearchPromise.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/Select2SearchQuery.md) |
| `results` | (`result`: [`Select2SearchResult`](../interfaces/Select2SearchResult.md)<`TItem`\>) => `void` |

#### Returns

[`Select2SearchPromise`](../interfaces/Select2SearchPromise.md)

#### Overrides

[Select2Editor](Select2Editor.md).[asyncSearch](Select2Editor.md#asyncsearch)

#### Defined in

[src/ui/editors/lookupeditor.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L106)

___

### cascadeItems

▸ `Protected` **cascadeItems**(`items`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

`TItem`[]

#### Inherited from

[Select2Editor](Select2Editor.md).[cascadeItems](Select2Editor.md#cascadeitems)

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

[Select2Editor](Select2Editor.md).[change](Select2Editor.md#change)

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

[Select2Editor](Select2Editor.md).[change](Select2Editor.md#change)

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

[Select2Editor](Select2Editor.md).[changeSelect2](Select2Editor.md#changeselect2)

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

[Select2Editor](Select2Editor.md).[changeSelect2](Select2Editor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### clearItems

▸ **clearItems**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](Select2Editor.md).[clearItems](Select2Editor.md#clearitems)

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

[Select2Editor](Select2Editor.md).[createEditDialog](Select2Editor.md#createeditdialog)

#### Defined in

[src/ui/editors/select2editor.ts:862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L862)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Select2Editor](Select2Editor.md).[destroy](Select2Editor.md#destroy)

#### Defined in

[src/ui/editors/lookupeditor.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L30)

___

### editDialogDataChange

▸ `Protected` **editDialogDataChange**(): `void`

#### Returns

`void`

#### Overrides

[Select2Editor](Select2Editor.md).[editDialogDataChange](Select2Editor.md#editdialogdatachange)

#### Defined in

[src/ui/editors/lookupeditor.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L141)

___

### emptyItemText

▸ `Protected` **emptyItemText**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](Select2Editor.md).[emptyItemText](Select2Editor.md#emptyitemtext)

#### Defined in

[src/ui/editors/select2editor.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L114)

___

### filterItems

▸ `Protected` **filterItems**(`items`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

`TItem`[]

#### Inherited from

[Select2Editor](Select2Editor.md).[filterItems](Select2Editor.md#filteritems)

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

[Select2Editor](Select2Editor.md).[getCascadeFromValue](Select2Editor.md#getcascadefromvalue)

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

[Select2Editor](Select2Editor.md).[getCreateSearchChoice](Select2Editor.md#getcreatesearchchoice)

#### Defined in

[src/ui/editors/select2editor.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L450)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](Select2Editor.md).[getCssClass](Select2Editor.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getDialogTypeKey

▸ `Protected` **getDialogTypeKey**(): `string`

#### Returns

`string`

#### Overrides

[Select2Editor](Select2Editor.md).[getDialogTypeKey](Select2Editor.md#getdialogtypekey)

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

[Select2Editor](Select2Editor.md).[getEditValue](Select2Editor.md#geteditvalue)

#### Defined in

[src/ui/editors/select2editor.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L508)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Select2Editor](Select2Editor.md).[getGridField](Select2Editor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdField

▸ `Protected` **getIdField**(): `any`

#### Returns

`any`

#### Overrides

[Select2Editor](Select2Editor.md).[getIdField](Select2Editor.md#getidfield)

#### Defined in

[src/ui/editors/lookupeditor.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L70)

___

### getItemDisabled

▸ `Protected` **getItemDisabled**(`item`, `lookup`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `lookup` | [`Lookup`](Lookup.md)<`TItem`\> |

#### Returns

`boolean`

#### Defined in

[src/ui/editors/lookupeditor.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L91)

___

### getItemText

▸ `Protected` **getItemText**(`item`, `lookup`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `lookup` | [`Lookup`](Lookup.md)<`TItem`\> |

#### Returns

`any`

#### Defined in

[src/ui/editors/lookupeditor.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L74)

___

### getItems

▸ `Protected` **getItems**(`lookup`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `lookup` | [`Lookup`](Lookup.md)<`TItem`\> |

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/lookupeditor.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L66)

___

### getLookup

▸ `Protected` **getLookup**(): [`Lookup`](Lookup.md)<`TItem`\>

#### Returns

[`Lookup`](Lookup.md)<`TItem`\>

#### Defined in

[src/ui/editors/lookupeditor.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L62)

___

### getLookupAsync

▸ `Protected` **getLookupAsync**(): `PromiseLike`<[`Lookup`](Lookup.md)<`TItem`\>\>

#### Returns

`PromiseLike`<[`Lookup`](Lookup.md)<`TItem`\>\>

#### Defined in

[src/ui/editors/lookupeditor.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L58)

___

### getLookupKey

▸ `Protected` **getLookupKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/lookupeditor.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L37)

___

### getPageSize

▸ `Protected` **getPageSize**(): `number`

#### Returns

`number`

#### Inherited from

[Select2Editor](Select2Editor.md).[getPageSize](Select2Editor.md#getpagesize)

#### Defined in

[src/ui/editors/select2editor.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L119)

___

### getSelect2Options

▸ `Protected` **getSelect2Options**(): `Select2Options`

#### Returns

`Select2Options`

#### Inherited from

[Select2Editor](Select2Editor.md).[getSelect2Options](Select2Editor.md#getselect2options)

#### Defined in

[src/ui/editors/select2editor.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L184)

___

### getTextField

▸ `Protected` **getTextField**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](Select2Editor.md).[getTextField](Select2Editor.md#gettextfield)

#### Defined in

[src/ui/editors/select2editor.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L134)

___

### getTypeDelay

▸ `Protected` **getTypeDelay**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](Select2Editor.md).[getTypeDelay](Select2Editor.md#gettypedelay)

#### Defined in

[src/ui/editors/select2editor.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L110)

___

### get\_cascadeField

▸ `Protected` **get_cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_cascadeField](Select2Editor.md#get_cascadefield)

#### Defined in

[src/ui/editors/select2editor.ts:741](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L741)

___

### get\_cascadeFrom

▸ `Protected` **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_cascadeFrom](Select2Editor.md#get_cascadefrom)

#### Defined in

[src/ui/editors/select2editor.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L722)

___

### get\_cascadeValue

▸ `Protected` **get_cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_cascadeValue](Select2Editor.md#get_cascadevalue)

#### Defined in

[src/ui/editors/select2editor.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L757)

___

### get\_delimited

▸ **get_delimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_delimited](Select2Editor.md#get_delimited)

#### Defined in

[src/ui/editors/select2editor.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L328)

___

### get\_filterField

▸ `Protected` **get_filterField**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_filterField](Select2Editor.md#get_filterfield)

#### Defined in

[src/ui/editors/select2editor.ts:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L777)

___

### get\_filterValue

▸ `Protected` **get_filterValue**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_filterValue](Select2Editor.md#get_filtervalue)

#### Defined in

[src/ui/editors/select2editor.ts:793](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L793)

___

### get\_itemByKey

▸ `Protected` **get_itemByKey**(): `Object`

#### Returns

`Object`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_itemByKey](Select2Editor.md#get_itembykey)

#### Defined in

[src/ui/editors/select2editor.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L525)

___

### get\_items

▸ `Protected` **get_items**(): `Select2Item`[]

#### Returns

`Select2Item`[]

#### Inherited from

[Select2Editor](Select2Editor.md).[get_items](Select2Editor.md#get_items)

#### Defined in

[src/ui/editors/select2editor.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L521)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_readOnly](Select2Editor.md#get_readonly)

#### Defined in

[src/ui/editors/select2editor.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L668)

___

### get\_select2Container

▸ `Protected` **get_select2Container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_select2Container](Select2Editor.md#get_select2container)

#### Defined in

[src/ui/editors/select2editor.ts:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L517)

___

### get\_text

▸ `Protected` **get_text**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_text](Select2Editor.md#get_text)

#### Defined in

[src/ui/editors/select2editor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L660)

___

### get\_value

▸ **get_value**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](Select2Editor.md).[get_value](Select2Editor.md#get_value)

#### Defined in

[src/ui/editors/select2editor.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L551)

___

### get\_values

▸ `Protected` **get_values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[Select2Editor](Select2Editor.md).[get_values](Select2Editor.md#get_values)

#### Defined in

[src/ui/editors/select2editor.ts:623](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L623)

___

### hasAsyncSource

▸ **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Overrides

[Select2Editor](Select2Editor.md).[hasAsyncSource](Select2Editor.md#hasasyncsource)

#### Defined in

[src/ui/editors/lookupeditor.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L26)

___

### init

▸ **init**(`action?`): [`LookupEditorBase`](LookupEditorBase.md)<`TOptions`, `TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`LookupEditorBase`](LookupEditorBase.md)<`TOptions`, `TItem`\>

#### Inherited from

[Select2Editor](Select2Editor.md).[init](Select2Editor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initNewEntity

▸ `Protected` **initNewEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |

#### Returns

`void`

#### Inherited from

[Select2Editor](Select2Editor.md).[initNewEntity](Select2Editor.md#initnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:873](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L873)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](Select2Editor.md).[initialize](Select2Editor.md#initialize)

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

[Select2Editor](Select2Editor.md).[inplaceCreateClick](Select2Editor.md#inplacecreateclick)

#### Defined in

[src/ui/editors/select2editor.ts:901](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L901)

___

### isAutoComplete

▸ `Protected` **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](Select2Editor.md).[isAutoComplete](Select2Editor.md#isautocomplete)

#### Defined in

[src/ui/editors/select2editor.ts:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L446)

___

### isMultiple

▸ `Protected` **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](Select2Editor.md).[isMultiple](Select2Editor.md#ismultiple)

#### Defined in

[src/ui/editors/select2editor.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L167)

___

### itemDisabled

▸ `Protected` **itemDisabled**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`boolean`

#### Inherited from

[Select2Editor](Select2Editor.md).[itemDisabled](Select2Editor.md#itemdisabled)

#### Defined in

[src/ui/editors/select2editor.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L145)

___

### itemId

▸ `Protected` **itemId**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`string`

#### Inherited from

[Select2Editor](Select2Editor.md).[itemId](Select2Editor.md#itemid)

#### Defined in

[src/ui/editors/select2editor.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L127)

___

### itemText

▸ `Protected` **itemText**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`string`

#### Inherited from

[Select2Editor](Select2Editor.md).[itemText](Select2Editor.md#itemtext)

#### Defined in

[src/ui/editors/select2editor.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L138)

___

### mapItem

▸ `Protected` **mapItem**(`item`): `Select2Item`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`Select2Item`

#### Overrides

[Select2Editor](Select2Editor.md).[mapItem](Select2Editor.md#mapitem)

#### Defined in

[src/ui/editors/lookupeditor.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L82)

___

### mapItems

▸ `Protected` **mapItems**(`items`): `Select2Item`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

`Select2Item`[]

#### Inherited from

[Select2Editor](Select2Editor.md).[mapItems](Select2Editor.md#mapitems)

#### Defined in

[src/ui/editors/select2editor.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L158)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](Select2Editor.md).[renderContents](Select2Editor.md#rendercontents)

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

[Select2Editor](Select2Editor.md).[setCascadeFrom](Select2Editor.md#setcascadefrom)

#### Defined in

[src/ui/editors/select2editor.ts:703](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L703)

___

### setCreateTermOnNewEntity

▸ `Protected` **setCreateTermOnNewEntity**(`entity`, `term`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |
| `term` | `string` |

#### Returns

`void`

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

[Select2Editor](Select2Editor.md).[setEditDialogReadOnly](Select2Editor.md#seteditdialogreadonly)

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

[Select2Editor](Select2Editor.md).[setEditValue](Select2Editor.md#seteditvalue)

#### Defined in

[src/ui/editors/select2editor.ts:498](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L498)

___

### setTermOnNewEntity

▸ `Protected` **setTermOnNewEntity**(`entity`, `term`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |
| `term` | `string` |

#### Returns

`void`

#### Inherited from

[Select2Editor](Select2Editor.md).[setTermOnNewEntity](Select2Editor.md#settermonnewentity)

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

[Select2Editor](Select2Editor.md).[set_cascadeField](Select2Editor.md#set_cascadefield)

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

[Select2Editor](Select2Editor.md).[set_cascadeFrom](Select2Editor.md#set_cascadefrom)

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

[Select2Editor](Select2Editor.md).[set_cascadeValue](Select2Editor.md#set_cascadevalue)

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

[Select2Editor](Select2Editor.md).[set_filterField](Select2Editor.md#set_filterfield)

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

[Select2Editor](Select2Editor.md).[set_filterValue](Select2Editor.md#set_filtervalue)

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

[Select2Editor](Select2Editor.md).[set_readOnly](Select2Editor.md#set_readonly)

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

[Select2Editor](Select2Editor.md).[set_value](Select2Editor.md#set_value)

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

[Select2Editor](Select2Editor.md).[set_values](Select2Editor.md#set_values)

#### Defined in

[src/ui/editors/select2editor.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L646)

___

### updateItems

▸ **updateItems**(): `void`

#### Returns

`void`

#### Overrides

[Select2Editor](Select2Editor.md).[updateItems](Select2Editor.md#updateitems)

#### Defined in

[src/ui/editors/lookupeditor.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L95)

___

### useInplaceAdd

▸ `Protected` **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](Select2Editor.md).[useInplaceAdd](Select2Editor.md#useinplaceadd)

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

[Select2Editor](Select2Editor.md).[create](Select2Editor.md#create)

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

[Select2Editor](Select2Editor.md).[elementFor](Select2Editor.md#elementfor)

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

[Select2Editor](Select2Editor.md).[filterByText](Select2Editor.md#filterbytext)

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

[Select2Editor](Select2Editor.md).[getWidgetName](Select2Editor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
