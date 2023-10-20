[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / EnumEditor

# Class: EnumEditor

[corelib](../modules/corelib.md).EnumEditor

## Hierarchy

- [`Select2Editor`](corelib.Select2Editor.md)<[`EnumEditorOptions`](../interfaces/corelib.EnumEditorOptions.md), `Select2Item`\>

  ↳ **`EnumEditor`**

## Table of contents

### Constructors

- [constructor](corelib.EnumEditor.md#constructor)

### Properties

- [cascadeLink](corelib.EnumEditor.md#cascadelink)
- [element](corelib.EnumEditor.md#element)
- [idPrefix](corelib.EnumEditor.md#idprefix)
- [lastCreateTerm](corelib.EnumEditor.md#lastcreateterm)
- [onInitNewEntity](corelib.EnumEditor.md#oninitnewentity)
- [openDialogAsPanel](corelib.EnumEditor.md#opendialogaspanel)
- [options](corelib.EnumEditor.md#options)
- [uniqueName](corelib.EnumEditor.md#uniquename)
- [widgetName](corelib.EnumEditor.md#widgetname)

### Accessors

- [cascadeField](corelib.EnumEditor.md#cascadefield)
- [cascadeFrom](corelib.EnumEditor.md#cascadefrom)
- [cascadeValue](corelib.EnumEditor.md#cascadevalue)
- [filterField](corelib.EnumEditor.md#filterfield)
- [filterValue](corelib.EnumEditor.md#filtervalue)
- [itemById](corelib.EnumEditor.md#itembyid)
- [items](corelib.EnumEditor.md#items)
- [readOnly](corelib.EnumEditor.md#readonly)
- [selectedItem](corelib.EnumEditor.md#selecteditem)
- [selectedItems](corelib.EnumEditor.md#selecteditems)
- [text](corelib.EnumEditor.md#text)
- [value](corelib.EnumEditor.md#value)
- [values](corelib.EnumEditor.md#values)

### Methods

- [abortPendingQuery](corelib.EnumEditor.md#abortpendingquery)
- [addCssClass](corelib.EnumEditor.md#addcssclass)
- [addInplaceCreate](corelib.EnumEditor.md#addinplacecreate)
- [addItem](corelib.EnumEditor.md#additem)
- [addOption](corelib.EnumEditor.md#addoption)
- [addValidationRule](corelib.EnumEditor.md#addvalidationrule)
- [allowClear](corelib.EnumEditor.md#allowclear)
- [asyncSearch](corelib.EnumEditor.md#asyncsearch)
- [cascadeItems](corelib.EnumEditor.md#cascadeitems)
- [change](corelib.EnumEditor.md#change)
- [changeSelect2](corelib.EnumEditor.md#changeselect2)
- [clearItems](corelib.EnumEditor.md#clearitems)
- [createEditDialog](corelib.EnumEditor.md#createeditdialog)
- [destroy](corelib.EnumEditor.md#destroy)
- [editDialogDataChange](corelib.EnumEditor.md#editdialogdatachange)
- [emptyItemText](corelib.EnumEditor.md#emptyitemtext)
- [filterItems](corelib.EnumEditor.md#filteritems)
- [getCascadeFromValue](corelib.EnumEditor.md#getcascadefromvalue)
- [getCreateSearchChoice](corelib.EnumEditor.md#getcreatesearchchoice)
- [getCssClass](corelib.EnumEditor.md#getcssclass)
- [getDialogTypeKey](corelib.EnumEditor.md#getdialogtypekey)
- [getEditValue](corelib.EnumEditor.md#geteditvalue)
- [getGridField](corelib.EnumEditor.md#getgridfield)
- [getIdField](corelib.EnumEditor.md#getidfield)
- [getPageSize](corelib.EnumEditor.md#getpagesize)
- [getSelect2Options](corelib.EnumEditor.md#getselect2options)
- [getTextField](corelib.EnumEditor.md#gettextfield)
- [getTypeDelay](corelib.EnumEditor.md#gettypedelay)
- [get\_cascadeField](corelib.EnumEditor.md#get_cascadefield)
- [get\_cascadeFrom](corelib.EnumEditor.md#get_cascadefrom)
- [get\_cascadeValue](corelib.EnumEditor.md#get_cascadevalue)
- [get\_delimited](corelib.EnumEditor.md#get_delimited)
- [get\_filterField](corelib.EnumEditor.md#get_filterfield)
- [get\_filterValue](corelib.EnumEditor.md#get_filtervalue)
- [get\_itemByKey](corelib.EnumEditor.md#get_itembykey)
- [get\_items](corelib.EnumEditor.md#get_items)
- [get\_readOnly](corelib.EnumEditor.md#get_readonly)
- [get\_select2Container](corelib.EnumEditor.md#get_select2container)
- [get\_text](corelib.EnumEditor.md#get_text)
- [get\_value](corelib.EnumEditor.md#get_value)
- [get\_values](corelib.EnumEditor.md#get_values)
- [hasAsyncSource](corelib.EnumEditor.md#hasasyncsource)
- [init](corelib.EnumEditor.md#init)
- [initNewEntity](corelib.EnumEditor.md#initnewentity)
- [initialize](corelib.EnumEditor.md#initialize)
- [inplaceCreateClick](corelib.EnumEditor.md#inplacecreateclick)
- [isAutoComplete](corelib.EnumEditor.md#isautocomplete)
- [isMultiple](corelib.EnumEditor.md#ismultiple)
- [itemDisabled](corelib.EnumEditor.md#itemdisabled)
- [itemId](corelib.EnumEditor.md#itemid)
- [itemText](corelib.EnumEditor.md#itemtext)
- [mapItem](corelib.EnumEditor.md#mapitem)
- [mapItems](corelib.EnumEditor.md#mapitems)
- [renderContents](corelib.EnumEditor.md#rendercontents)
- [setCascadeFrom](corelib.EnumEditor.md#setcascadefrom)
- [setEditDialogReadOnly](corelib.EnumEditor.md#seteditdialogreadonly)
- [setEditValue](corelib.EnumEditor.md#seteditvalue)
- [setTermOnNewEntity](corelib.EnumEditor.md#settermonnewentity)
- [set\_cascadeField](corelib.EnumEditor.md#set_cascadefield)
- [set\_cascadeFrom](corelib.EnumEditor.md#set_cascadefrom)
- [set\_cascadeValue](corelib.EnumEditor.md#set_cascadevalue)
- [set\_filterField](corelib.EnumEditor.md#set_filterfield)
- [set\_filterValue](corelib.EnumEditor.md#set_filtervalue)
- [set\_readOnly](corelib.EnumEditor.md#set_readonly)
- [set\_value](corelib.EnumEditor.md#set_value)
- [set\_values](corelib.EnumEditor.md#set_values)
- [updateItems](corelib.EnumEditor.md#updateitems)
- [useInplaceAdd](corelib.EnumEditor.md#useinplaceadd)
- [create](corelib.EnumEditor.md#create)
- [elementFor](corelib.EnumEditor.md#elementfor)
- [filterByText](corelib.EnumEditor.md#filterbytext)
- [getWidgetName](corelib.EnumEditor.md#getwidgetname)

## Constructors

### constructor

• **new EnumEditor**(`hidden`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `hidden` | `JQuery` |
| `opt` | [`EnumEditorOptions`](../interfaces/corelib.EnumEditorOptions.md) |

#### Overrides

[Select2Editor](corelib.Select2Editor.md).[constructor](corelib.Select2Editor.md#constructor)

#### Defined in

[src/ui/editors/enumeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L13)

## Properties

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](corelib.CascadedWidgetLink.md)<[`Widget`](corelib.Widget.md)<`any`\>\>

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[cascadeLink](corelib.Select2Editor.md#cascadelink)

#### Defined in

[src/ui/editors/select2editor.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L701)

___

### element

• **element**: `JQuery`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[element](corelib.Select2Editor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[idPrefix](corelib.Select2Editor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### lastCreateTerm

• `Protected` **lastCreateTerm**: `string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[lastCreateTerm](corelib.Select2Editor.md#lastcreateterm)

#### Defined in

[src/ui/editors/select2editor.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L64)

___

### onInitNewEntity

• **onInitNewEntity**: (`entity`: `Select2Item`) => `void`

#### Type declaration

▸ (`entity`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `Select2Item` |

##### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[onInitNewEntity](corelib.Select2Editor.md#oninitnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:871](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L871)

___

### openDialogAsPanel

• **openDialogAsPanel**: `boolean`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[openDialogAsPanel](corelib.Select2Editor.md#opendialogaspanel)

#### Defined in

[src/ui/editors/select2editor.ts:972](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L972)

___

### options

• `Protected` **options**: [`EnumEditorOptions`](../interfaces/corelib.EnumEditorOptions.md)

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[options](corelib.Select2Editor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[uniqueName](corelib.Select2Editor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[widgetName](corelib.Select2Editor.md#widgetname)

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

[Select2Editor](corelib.Select2Editor.md).[abortPendingQuery](corelib.Select2Editor.md#abortpendingquery)

#### Defined in

[src/ui/editors/select2editor.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L175)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[addCssClass](corelib.Select2Editor.md#addcssclass)

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

[Select2Editor](corelib.Select2Editor.md).[addInplaceCreate](corelib.Select2Editor.md#addinplacecreate)

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

[Select2Editor](corelib.Select2Editor.md).[addItem](corelib.Select2Editor.md#additem)

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

[Select2Editor](corelib.Select2Editor.md).[addOption](corelib.Select2Editor.md#addoption)

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

[Select2Editor](corelib.Select2Editor.md).[addValidationRule](corelib.Select2Editor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### allowClear

▸ `Protected` **allowClear**(): `boolean`

#### Returns

`boolean`

#### Overrides

[Select2Editor](corelib.Select2Editor.md).[allowClear](corelib.Select2Editor.md#allowclear)

#### Defined in

[src/ui/editors/enumeditor.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L39)

___

### asyncSearch

▸ `Protected` **asyncSearch**(`query`, `results`): [`Select2SearchPromise`](../interfaces/corelib.Select2SearchPromise.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/corelib.Select2SearchQuery.md) |
| `results` | (`result`: [`Select2SearchResult`](../interfaces/corelib.Select2SearchResult.md)<`Select2Item`\>) => `void` |

#### Returns

[`Select2SearchPromise`](../interfaces/corelib.Select2SearchPromise.md)

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[asyncSearch](corelib.Select2Editor.md#asyncsearch)

#### Defined in

[src/ui/editors/select2editor.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L102)

___

### cascadeItems

▸ `Protected` **cascadeItems**(`items`): `Select2Item`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `Select2Item`[] |

#### Returns

`Select2Item`[]

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[cascadeItems](corelib.Select2Editor.md#cascadeitems)

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

[Select2Editor](corelib.Select2Editor.md).[change](corelib.Select2Editor.md#change)

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

[Select2Editor](corelib.Select2Editor.md).[change](corelib.Select2Editor.md#change)

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

[Select2Editor](corelib.Select2Editor.md).[changeSelect2](corelib.Select2Editor.md#changeselect2)

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

[Select2Editor](corelib.Select2Editor.md).[changeSelect2](corelib.Select2Editor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### clearItems

▸ **clearItems**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[clearItems](corelib.Select2Editor.md#clearitems)

#### Defined in

[src/ui/editors/select2editor.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L363)

___

### createEditDialog

▸ `Protected` **createEditDialog**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`dlg`: [`IEditDialog`](corelib.IEditDialog.md)) => `void` |

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[createEditDialog](corelib.Select2Editor.md#createeditdialog)

#### Defined in

[src/ui/editors/select2editor.ts:862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L862)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[destroy](corelib.Select2Editor.md#destroy)

#### Defined in

[src/ui/editors/select2editor.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L91)

___

### editDialogDataChange

▸ `Protected` **editDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[editDialogDataChange](corelib.Select2Editor.md#editdialogdatachange)

#### Defined in

[src/ui/editors/select2editor.ts:895](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L895)

___

### emptyItemText

▸ `Protected` **emptyItemText**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[emptyItemText](corelib.Select2Editor.md#emptyitemtext)

#### Defined in

[src/ui/editors/select2editor.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L114)

___

### filterItems

▸ `Protected` **filterItems**(`items`): `Select2Item`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `Select2Item`[] |

#### Returns

`Select2Item`[]

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[filterItems](corelib.Select2Editor.md#filteritems)

#### Defined in

[src/ui/editors/select2editor.ts:835](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L835)

___

### getCascadeFromValue

▸ `Protected` **getCascadeFromValue**(`parent`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `parent` | [`Widget`](corelib.Widget.md)<`any`\> |

#### Returns

`any`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getCascadeFromValue](corelib.Select2Editor.md#getcascadefromvalue)

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

[Select2Editor](corelib.Select2Editor.md).[getCreateSearchChoice](corelib.Select2Editor.md#getcreatesearchchoice)

#### Defined in

[src/ui/editors/select2editor.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L450)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getCssClass](corelib.Select2Editor.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getDialogTypeKey

▸ `Protected` **getDialogTypeKey**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getDialogTypeKey](corelib.Select2Editor.md#getdialogtypekey)

#### Defined in

[src/ui/editors/select2editor.ts:854](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L854)

___

### getEditValue

▸ **getEditValue**(`property`, `target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `property` | [`PropertyItem`](../interfaces/q.PropertyItem.md) |
| `target` | `any` |

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getEditValue](corelib.Select2Editor.md#geteditvalue)

#### Defined in

[src/ui/editors/select2editor.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L508)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getGridField](corelib.Select2Editor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdField

▸ `Protected` **getIdField**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getIdField](corelib.Select2Editor.md#getidfield)

#### Defined in

[src/ui/editors/select2editor.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L123)

___

### getPageSize

▸ `Protected` **getPageSize**(): `number`

#### Returns

`number`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getPageSize](corelib.Select2Editor.md#getpagesize)

#### Defined in

[src/ui/editors/select2editor.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L119)

___

### getSelect2Options

▸ `Protected` **getSelect2Options**(): `Select2Options`

#### Returns

`Select2Options`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getSelect2Options](corelib.Select2Editor.md#getselect2options)

#### Defined in

[src/ui/editors/select2editor.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L184)

___

### getTextField

▸ `Protected` **getTextField**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getTextField](corelib.Select2Editor.md#gettextfield)

#### Defined in

[src/ui/editors/select2editor.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L134)

___

### getTypeDelay

▸ `Protected` **getTypeDelay**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[getTypeDelay](corelib.Select2Editor.md#gettypedelay)

#### Defined in

[src/ui/editors/select2editor.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L110)

___

### get\_cascadeField

▸ `Protected` **get_cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_cascadeField](corelib.Select2Editor.md#get_cascadefield)

#### Defined in

[src/ui/editors/select2editor.ts:741](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L741)

___

### get\_cascadeFrom

▸ `Protected` **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_cascadeFrom](corelib.Select2Editor.md#get_cascadefrom)

#### Defined in

[src/ui/editors/select2editor.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L722)

___

### get\_cascadeValue

▸ `Protected` **get_cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_cascadeValue](corelib.Select2Editor.md#get_cascadevalue)

#### Defined in

[src/ui/editors/select2editor.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L757)

___

### get\_delimited

▸ **get_delimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_delimited](corelib.Select2Editor.md#get_delimited)

#### Defined in

[src/ui/editors/select2editor.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L328)

___

### get\_filterField

▸ `Protected` **get_filterField**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_filterField](corelib.Select2Editor.md#get_filterfield)

#### Defined in

[src/ui/editors/select2editor.ts:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L777)

___

### get\_filterValue

▸ `Protected` **get_filterValue**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_filterValue](corelib.Select2Editor.md#get_filtervalue)

#### Defined in

[src/ui/editors/select2editor.ts:793](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L793)

___

### get\_itemByKey

▸ `Protected` **get_itemByKey**(): `Object`

#### Returns

`Object`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_itemByKey](corelib.Select2Editor.md#get_itembykey)

#### Defined in

[src/ui/editors/select2editor.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L525)

___

### get\_items

▸ `Protected` **get_items**(): `Select2Item`[]

#### Returns

`Select2Item`[]

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_items](corelib.Select2Editor.md#get_items)

#### Defined in

[src/ui/editors/select2editor.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L521)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_readOnly](corelib.Select2Editor.md#get_readonly)

#### Defined in

[src/ui/editors/select2editor.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L668)

___

### get\_select2Container

▸ `Protected` **get_select2Container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_select2Container](corelib.Select2Editor.md#get_select2container)

#### Defined in

[src/ui/editors/select2editor.ts:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L517)

___

### get\_text

▸ `Protected` **get_text**(): `string`

#### Returns

`string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_text](corelib.Select2Editor.md#get_text)

#### Defined in

[src/ui/editors/select2editor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L660)

___

### get\_value

▸ **get_value**(): `any`

#### Returns

`any`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_value](corelib.Select2Editor.md#get_value)

#### Defined in

[src/ui/editors/select2editor.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L551)

___

### get\_values

▸ `Protected` **get_values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[get_values](corelib.Select2Editor.md#get_values)

#### Defined in

[src/ui/editors/select2editor.ts:623](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L623)

___

### hasAsyncSource

▸ `Protected` **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[hasAsyncSource](corelib.Select2Editor.md#hasasyncsource)

#### Defined in

[src/ui/editors/select2editor.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L98)

___

### init

▸ **init**(`action?`): [`EnumEditor`](corelib.EnumEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`EnumEditor`](corelib.EnumEditor.md)

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[init](corelib.Select2Editor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initNewEntity

▸ `Protected` **initNewEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `Select2Item` |

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[initNewEntity](corelib.Select2Editor.md#initnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:873](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L873)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[initialize](corelib.Select2Editor.md#initialize)

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

[Select2Editor](corelib.Select2Editor.md).[inplaceCreateClick](corelib.Select2Editor.md#inplacecreateclick)

#### Defined in

[src/ui/editors/select2editor.ts:901](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L901)

___

### isAutoComplete

▸ `Protected` **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[isAutoComplete](corelib.Select2Editor.md#isautocomplete)

#### Defined in

[src/ui/editors/select2editor.ts:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L446)

___

### isMultiple

▸ `Protected` **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[isMultiple](corelib.Select2Editor.md#ismultiple)

#### Defined in

[src/ui/editors/select2editor.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L167)

___

### itemDisabled

▸ `Protected` **itemDisabled**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Select2Item` |

#### Returns

`boolean`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[itemDisabled](corelib.Select2Editor.md#itemdisabled)

#### Defined in

[src/ui/editors/select2editor.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L145)

___

### itemId

▸ `Protected` **itemId**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Select2Item` |

#### Returns

`string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[itemId](corelib.Select2Editor.md#itemid)

#### Defined in

[src/ui/editors/select2editor.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L127)

___

### itemText

▸ `Protected` **itemText**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Select2Item` |

#### Returns

`string`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[itemText](corelib.Select2Editor.md#itemtext)

#### Defined in

[src/ui/editors/select2editor.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L138)

___

### mapItem

▸ `Protected` **mapItem**(`item`): `Select2Item`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `Select2Item` |

#### Returns

`Select2Item`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[mapItem](corelib.Select2Editor.md#mapitem)

#### Defined in

[src/ui/editors/select2editor.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L149)

___

### mapItems

▸ `Protected` **mapItems**(`items`): `Select2Item`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `Select2Item`[] |

#### Returns

`Select2Item`[]

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[mapItems](corelib.Select2Editor.md#mapitems)

#### Defined in

[src/ui/editors/select2editor.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L158)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[renderContents](corelib.Select2Editor.md#rendercontents)

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

[Select2Editor](corelib.Select2Editor.md).[setCascadeFrom](corelib.Select2Editor.md#setcascadefrom)

#### Defined in

[src/ui/editors/select2editor.ts:703](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L703)

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

[Select2Editor](corelib.Select2Editor.md).[setEditDialogReadOnly](corelib.Select2Editor.md#seteditdialogreadonly)

#### Defined in

[src/ui/editors/select2editor.ts:887](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L887)

___

### setEditValue

▸ **setEditValue**(`source`, `property`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | `any` |
| `property` | [`PropertyItem`](../interfaces/q.PropertyItem.md) |

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[setEditValue](corelib.Select2Editor.md#seteditvalue)

#### Defined in

[src/ui/editors/select2editor.ts:498](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L498)

___

### setTermOnNewEntity

▸ `Protected` **setTermOnNewEntity**(`entity`, `term`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `Select2Item` |
| `term` | `string` |

#### Returns

`void`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[setTermOnNewEntity](corelib.Select2Editor.md#settermonnewentity)

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

[Select2Editor](corelib.Select2Editor.md).[set_cascadeField](corelib.Select2Editor.md#set_cascadefield)

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

[Select2Editor](corelib.Select2Editor.md).[set_cascadeFrom](corelib.Select2Editor.md#set_cascadefrom)

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

[Select2Editor](corelib.Select2Editor.md).[set_cascadeValue](corelib.Select2Editor.md#set_cascadevalue)

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

[Select2Editor](corelib.Select2Editor.md).[set_filterField](corelib.Select2Editor.md#set_filterfield)

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

[Select2Editor](corelib.Select2Editor.md).[set_filterValue](corelib.Select2Editor.md#set_filtervalue)

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

[Select2Editor](corelib.Select2Editor.md).[set_readOnly](corelib.Select2Editor.md#set_readonly)

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

[Select2Editor](corelib.Select2Editor.md).[set_value](corelib.Select2Editor.md#set_value)

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

[Select2Editor](corelib.Select2Editor.md).[set_values](corelib.Select2Editor.md#set_values)

#### Defined in

[src/ui/editors/select2editor.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L646)

___

### updateItems

▸ `Protected` **updateItems**(): `void`

#### Returns

`void`

#### Overrides

[Select2Editor](corelib.Select2Editor.md).[updateItems](corelib.Select2Editor.md#updateitems)

#### Defined in

[src/ui/editors/enumeditor.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L18)

___

### useInplaceAdd

▸ `Protected` **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[useInplaceAdd](corelib.Select2Editor.md#useinplaceadd)

#### Defined in

[src/ui/editors/select2editor.ts:439](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L439)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](corelib.Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/corelib.CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[Select2Editor](corelib.Select2Editor.md).[create](corelib.Select2Editor.md#create)

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

[Select2Editor](corelib.Select2Editor.md).[elementFor](corelib.Select2Editor.md#elementfor)

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

[Select2Editor](corelib.Select2Editor.md).[filterByText](corelib.Select2Editor.md#filterbytext)

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

[Select2Editor](corelib.Select2Editor.md).[getWidgetName](corelib.Select2Editor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
