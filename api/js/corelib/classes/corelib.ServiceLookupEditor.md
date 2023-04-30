[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / ServiceLookupEditor

# Class: ServiceLookupEditor

[corelib](../modules/corelib.md).ServiceLookupEditor

## Hierarchy

- [`ServiceLookupEditorBase`](corelib.ServiceLookupEditorBase.md)<[`ServiceLookupEditorOptions`](../interfaces/corelib.ServiceLookupEditorOptions.md), `any`\>

  ↳ **`ServiceLookupEditor`**

## Table of contents

### Constructors

- [constructor](corelib.ServiceLookupEditor.md#constructor)

### Properties

- [cascadeLink](corelib.ServiceLookupEditor.md#cascadelink)
- [element](corelib.ServiceLookupEditor.md#element)
- [idPrefix](corelib.ServiceLookupEditor.md#idprefix)
- [lastCreateTerm](corelib.ServiceLookupEditor.md#lastcreateterm)
- [onInitNewEntity](corelib.ServiceLookupEditor.md#oninitnewentity)
- [openDialogAsPanel](corelib.ServiceLookupEditor.md#opendialogaspanel)
- [options](corelib.ServiceLookupEditor.md#options)
- [uniqueName](corelib.ServiceLookupEditor.md#uniquename)
- [widgetName](corelib.ServiceLookupEditor.md#widgetname)

### Accessors

- [cascadeField](corelib.ServiceLookupEditor.md#cascadefield)
- [cascadeFrom](corelib.ServiceLookupEditor.md#cascadefrom)
- [cascadeValue](corelib.ServiceLookupEditor.md#cascadevalue)
- [filterField](corelib.ServiceLookupEditor.md#filterfield)
- [filterValue](corelib.ServiceLookupEditor.md#filtervalue)
- [itemById](corelib.ServiceLookupEditor.md#itembyid)
- [items](corelib.ServiceLookupEditor.md#items)
- [readOnly](corelib.ServiceLookupEditor.md#readonly)
- [selectedItem](corelib.ServiceLookupEditor.md#selecteditem)
- [selectedItems](corelib.ServiceLookupEditor.md#selecteditems)
- [text](corelib.ServiceLookupEditor.md#text)
- [value](corelib.ServiceLookupEditor.md#value)
- [values](corelib.ServiceLookupEditor.md#values)

### Methods

- [abortPendingQuery](corelib.ServiceLookupEditor.md#abortpendingquery)
- [addCssClass](corelib.ServiceLookupEditor.md#addcssclass)
- [addInplaceCreate](corelib.ServiceLookupEditor.md#addinplacecreate)
- [addItem](corelib.ServiceLookupEditor.md#additem)
- [addOption](corelib.ServiceLookupEditor.md#addoption)
- [addValidationRule](corelib.ServiceLookupEditor.md#addvalidationrule)
- [allowClear](corelib.ServiceLookupEditor.md#allowclear)
- [asyncSearch](corelib.ServiceLookupEditor.md#asyncsearch)
- [cascadeItems](corelib.ServiceLookupEditor.md#cascadeitems)
- [change](corelib.ServiceLookupEditor.md#change)
- [changeSelect2](corelib.ServiceLookupEditor.md#changeselect2)
- [clearItems](corelib.ServiceLookupEditor.md#clearitems)
- [createEditDialog](corelib.ServiceLookupEditor.md#createeditdialog)
- [destroy](corelib.ServiceLookupEditor.md#destroy)
- [editDialogDataChange](corelib.ServiceLookupEditor.md#editdialogdatachange)
- [emptyItemText](corelib.ServiceLookupEditor.md#emptyitemtext)
- [filterItems](corelib.ServiceLookupEditor.md#filteritems)
- [getCascadeCriteria](corelib.ServiceLookupEditor.md#getcascadecriteria)
- [getCascadeFromValue](corelib.ServiceLookupEditor.md#getcascadefromvalue)
- [getCreateSearchChoice](corelib.ServiceLookupEditor.md#getcreatesearchchoice)
- [getCriteria](corelib.ServiceLookupEditor.md#getcriteria)
- [getCssClass](corelib.ServiceLookupEditor.md#getcssclass)
- [getDialogTypeKey](corelib.ServiceLookupEditor.md#getdialogtypekey)
- [getEditValue](corelib.ServiceLookupEditor.md#geteditvalue)
- [getFilterCriteria](corelib.ServiceLookupEditor.md#getfiltercriteria)
- [getGridField](corelib.ServiceLookupEditor.md#getgridfield)
- [getIdField](corelib.ServiceLookupEditor.md#getidfield)
- [getIdListCriteria](corelib.ServiceLookupEditor.md#getidlistcriteria)
- [getIncludeColumns](corelib.ServiceLookupEditor.md#getincludecolumns)
- [getListRequest](corelib.ServiceLookupEditor.md#getlistrequest)
- [getPageSize](corelib.ServiceLookupEditor.md#getpagesize)
- [getSelect2Options](corelib.ServiceLookupEditor.md#getselect2options)
- [getService](corelib.ServiceLookupEditor.md#getservice)
- [getServiceCallOptions](corelib.ServiceLookupEditor.md#getservicecalloptions)
- [getServiceUrl](corelib.ServiceLookupEditor.md#getserviceurl)
- [getSort](corelib.ServiceLookupEditor.md#getsort)
- [getTextField](corelib.ServiceLookupEditor.md#gettextfield)
- [getTypeDelay](corelib.ServiceLookupEditor.md#gettypedelay)
- [get\_cascadeField](corelib.ServiceLookupEditor.md#get_cascadefield)
- [get\_cascadeFrom](corelib.ServiceLookupEditor.md#get_cascadefrom)
- [get\_cascadeValue](corelib.ServiceLookupEditor.md#get_cascadevalue)
- [get\_delimited](corelib.ServiceLookupEditor.md#get_delimited)
- [get\_filterField](corelib.ServiceLookupEditor.md#get_filterfield)
- [get\_filterValue](corelib.ServiceLookupEditor.md#get_filtervalue)
- [get\_itemByKey](corelib.ServiceLookupEditor.md#get_itembykey)
- [get\_items](corelib.ServiceLookupEditor.md#get_items)
- [get\_readOnly](corelib.ServiceLookupEditor.md#get_readonly)
- [get\_select2Container](corelib.ServiceLookupEditor.md#get_select2container)
- [get\_text](corelib.ServiceLookupEditor.md#get_text)
- [get\_value](corelib.ServiceLookupEditor.md#get_value)
- [get\_values](corelib.ServiceLookupEditor.md#get_values)
- [hasAsyncSource](corelib.ServiceLookupEditor.md#hasasyncsource)
- [init](corelib.ServiceLookupEditor.md#init)
- [initNewEntity](corelib.ServiceLookupEditor.md#initnewentity)
- [initialize](corelib.ServiceLookupEditor.md#initialize)
- [inplaceCreateClick](corelib.ServiceLookupEditor.md#inplacecreateclick)
- [isAutoComplete](corelib.ServiceLookupEditor.md#isautocomplete)
- [isMultiple](corelib.ServiceLookupEditor.md#ismultiple)
- [itemDisabled](corelib.ServiceLookupEditor.md#itemdisabled)
- [itemId](corelib.ServiceLookupEditor.md#itemid)
- [itemText](corelib.ServiceLookupEditor.md#itemtext)
- [mapItem](corelib.ServiceLookupEditor.md#mapitem)
- [mapItems](corelib.ServiceLookupEditor.md#mapitems)
- [renderContents](corelib.ServiceLookupEditor.md#rendercontents)
- [setCascadeFrom](corelib.ServiceLookupEditor.md#setcascadefrom)
- [setEditDialogReadOnly](corelib.ServiceLookupEditor.md#seteditdialogreadonly)
- [setEditValue](corelib.ServiceLookupEditor.md#seteditvalue)
- [setTermOnNewEntity](corelib.ServiceLookupEditor.md#settermonnewentity)
- [set\_cascadeField](corelib.ServiceLookupEditor.md#set_cascadefield)
- [set\_cascadeFrom](corelib.ServiceLookupEditor.md#set_cascadefrom)
- [set\_cascadeValue](corelib.ServiceLookupEditor.md#set_cascadevalue)
- [set\_filterField](corelib.ServiceLookupEditor.md#set_filterfield)
- [set\_filterValue](corelib.ServiceLookupEditor.md#set_filtervalue)
- [set\_readOnly](corelib.ServiceLookupEditor.md#set_readonly)
- [set\_value](corelib.ServiceLookupEditor.md#set_value)
- [set\_values](corelib.ServiceLookupEditor.md#set_values)
- [updateItems](corelib.ServiceLookupEditor.md#updateitems)
- [useInplaceAdd](corelib.ServiceLookupEditor.md#useinplaceadd)
- [create](corelib.ServiceLookupEditor.md#create)
- [elementFor](corelib.ServiceLookupEditor.md#elementfor)
- [filterByText](corelib.ServiceLookupEditor.md#filterbytext)
- [getWidgetName](corelib.ServiceLookupEditor.md#getwidgetname)

## Constructors

### constructor

• **new ServiceLookupEditor**(`hidden`, `opt?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `hidden` | `JQuery` |
| `opt?` | [`ServiceLookupEditorOptions`](../interfaces/corelib.ServiceLookupEditorOptions.md) |

#### Overrides

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[constructor](corelib.ServiceLookupEditorBase.md#constructor)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L181)

## Properties

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](corelib.CascadedWidgetLink.md)<[`Widget`](corelib.Widget.md)<`any`\>\>

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[cascadeLink](corelib.ServiceLookupEditorBase.md#cascadelink)

#### Defined in

[src/ui/editors/select2editor.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L701)

___

### element

• **element**: `JQuery`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[element](corelib.ServiceLookupEditorBase.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[idPrefix](corelib.ServiceLookupEditorBase.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### lastCreateTerm

• `Protected` **lastCreateTerm**: `string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[lastCreateTerm](corelib.ServiceLookupEditorBase.md#lastcreateterm)

#### Defined in

[src/ui/editors/select2editor.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L64)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[onInitNewEntity](corelib.ServiceLookupEditorBase.md#oninitnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:871](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L871)

___

### openDialogAsPanel

• **openDialogAsPanel**: `boolean`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[openDialogAsPanel](corelib.ServiceLookupEditorBase.md#opendialogaspanel)

#### Defined in

[src/ui/editors/select2editor.ts:972](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L972)

___

### options

• `Protected` **options**: [`ServiceLookupEditorOptions`](../interfaces/corelib.ServiceLookupEditorOptions.md)

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[options](corelib.ServiceLookupEditorBase.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[uniqueName](corelib.ServiceLookupEditorBase.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[widgetName](corelib.ServiceLookupEditorBase.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

ServiceLookupEditorBase.cascadeField

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

ServiceLookupEditorBase.cascadeField

#### Defined in

[src/ui/editors/select2editor.ts:753](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L753)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

ServiceLookupEditorBase.cascadeFrom

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

ServiceLookupEditorBase.cascadeFrom

#### Defined in

[src/ui/editors/select2editor.ts:737](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L737)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

ServiceLookupEditorBase.cascadeValue

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

ServiceLookupEditorBase.cascadeValue

#### Defined in

[src/ui/editors/select2editor.ts:773](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L773)

___

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Inherited from

ServiceLookupEditorBase.filterField

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

ServiceLookupEditorBase.filterField

#### Defined in

[src/ui/editors/select2editor.ts:789](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L789)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Inherited from

ServiceLookupEditorBase.filterValue

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

ServiceLookupEditorBase.filterValue

#### Defined in

[src/ui/editors/select2editor.ts:809](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L809)

___

### itemById

• `Protected` `get` **itemById**(): `Object`

#### Returns

`Object`

#### Inherited from

ServiceLookupEditorBase.itemById

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

ServiceLookupEditorBase.itemById

#### Defined in

[src/ui/editors/select2editor.ts:356](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L356)

___

### items

• `get` **items**(): `Select2Item`[]

#### Returns

`Select2Item`[]

#### Inherited from

ServiceLookupEditorBase.items

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

ServiceLookupEditorBase.items

#### Defined in

[src/ui/editors/select2editor.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L339)

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

ServiceLookupEditorBase.readOnly

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

ServiceLookupEditorBase.readOnly

#### Defined in

[src/ui/editors/select2editor.ts:693](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L693)

___

### selectedItem

• `get` **selectedItem**(): `TItem`

#### Returns

`TItem`

#### Inherited from

ServiceLookupEditorBase.selectedItem

#### Defined in

[src/ui/editors/select2editor.ts:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L598)

___

### selectedItems

• `get` **selectedItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Inherited from

ServiceLookupEditorBase.selectedItems

#### Defined in

[src/ui/editors/select2editor.ts:608](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L608)

___

### text

• `get` **text**(): `string`

#### Returns

`string`

#### Inherited from

ServiceLookupEditorBase.text

#### Defined in

[src/ui/editors/select2editor.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L664)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

ServiceLookupEditorBase.value

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

ServiceLookupEditorBase.value

#### Defined in

[src/ui/editors/select2editor.ts:594](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L594)

___

### values

• `get` **values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

ServiceLookupEditorBase.values

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

ServiceLookupEditorBase.values

#### Defined in

[src/ui/editors/select2editor.ts:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L656)

## Methods

### abortPendingQuery

▸ `Protected` **abortPendingQuery**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[abortPendingQuery](corelib.ServiceLookupEditorBase.md#abortpendingquery)

#### Defined in

[src/ui/editors/select2editor.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L175)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[addCssClass](corelib.ServiceLookupEditorBase.md#addcssclass)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[addInplaceCreate](corelib.ServiceLookupEditorBase.md#addinplacecreate)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[addItem](corelib.ServiceLookupEditorBase.md#additem)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[addOption](corelib.ServiceLookupEditorBase.md#addoption)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[addValidationRule](corelib.ServiceLookupEditorBase.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### allowClear

▸ `Protected` **allowClear**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[allowClear](corelib.ServiceLookupEditorBase.md#allowclear)

#### Defined in

[src/ui/editors/select2editor.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L162)

___

### asyncSearch

▸ `Protected` **asyncSearch**(`query`, `results`): [`Select2SearchPromise`](../interfaces/corelib.Select2SearchPromise.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/corelib.Select2SearchQuery.md) |
| `results` | (`result`: [`Select2SearchResult`](../interfaces/corelib.Select2SearchResult.md)<`any`\>) => `void` |

#### Returns

[`Select2SearchPromise`](../interfaces/corelib.Select2SearchPromise.md)

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[asyncSearch](corelib.ServiceLookupEditorBase.md#asyncsearch)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L173)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[cascadeItems](corelib.ServiceLookupEditorBase.md#cascadeitems)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[change](corelib.ServiceLookupEditorBase.md#change)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[change](corelib.ServiceLookupEditorBase.md#change)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[changeSelect2](corelib.ServiceLookupEditorBase.md#changeselect2)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[changeSelect2](corelib.ServiceLookupEditorBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### clearItems

▸ **clearItems**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[clearItems](corelib.ServiceLookupEditorBase.md#clearitems)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[createEditDialog](corelib.ServiceLookupEditorBase.md#createeditdialog)

#### Defined in

[src/ui/editors/select2editor.ts:862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L862)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[destroy](corelib.ServiceLookupEditorBase.md#destroy)

#### Defined in

[src/ui/editors/select2editor.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L91)

___

### editDialogDataChange

▸ `Protected` **editDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[editDialogDataChange](corelib.ServiceLookupEditorBase.md#editdialogdatachange)

#### Defined in

[src/ui/editors/select2editor.ts:895](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L895)

___

### emptyItemText

▸ `Protected` **emptyItemText**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[emptyItemText](corelib.ServiceLookupEditorBase.md#emptyitemtext)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[filterItems](corelib.ServiceLookupEditorBase.md#filteritems)

#### Defined in

[src/ui/editors/select2editor.ts:835](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L835)

___

### getCascadeCriteria

▸ `Protected` **getCascadeCriteria**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getCascadeCriteria](corelib.ServiceLookupEditorBase.md#getcascadecriteria)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L79)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getCascadeFromValue](corelib.ServiceLookupEditorBase.md#getcascadefromvalue)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getCreateSearchChoice](corelib.ServiceLookupEditorBase.md#getcreatesearchchoice)

#### Defined in

[src/ui/editors/select2editor.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L450)

___

### getCriteria

▸ `Protected` **getCriteria**(`query`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/corelib.Select2SearchQuery.md) |

#### Returns

`any`[]

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getCriteria](corelib.ServiceLookupEditorBase.md#getcriteria)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L122)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getCssClass](corelib.ServiceLookupEditorBase.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getDialogTypeKey

▸ `Protected` **getDialogTypeKey**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getDialogTypeKey](corelib.ServiceLookupEditorBase.md#getdialogtypekey)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L28)

___

### getEditValue

▸ **getEditValue**(`property`, `target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `property` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |
| `target` | `any` |

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getEditValue](corelib.ServiceLookupEditorBase.md#geteditvalue)

#### Defined in

[src/ui/editors/select2editor.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L508)

___

### getFilterCriteria

▸ `Protected` **getFilterCriteria**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getFilterCriteria](corelib.ServiceLookupEditorBase.md#getfiltercriteria)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L97)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getGridField](corelib.ServiceLookupEditorBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdField

▸ `Protected` **getIdField**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getIdField](corelib.ServiceLookupEditorBase.md#getidfield)

#### Defined in

[src/ui/editors/select2editor.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L123)

___

### getIdListCriteria

▸ `Protected` **getIdListCriteria**(`idList`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `idList` | `any`[] |

#### Returns

`any`[]

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getIdListCriteria](corelib.ServiceLookupEditorBase.md#getidlistcriteria)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L108)

___

### getIncludeColumns

▸ `Protected` **getIncludeColumns**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getIncludeColumns](corelib.ServiceLookupEditorBase.md#getincludecolumns)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L61)

___

### getListRequest

▸ `Protected` **getListRequest**(`query`): [`ListRequest`](../interfaces/corelib_q.ListRequest.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/corelib.Select2SearchQuery.md) |

#### Returns

[`ListRequest`](../interfaces/corelib_q.ListRequest.md)

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getListRequest](corelib.ServiceLookupEditorBase.md#getlistrequest)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L128)

___

### getPageSize

▸ `Protected` **getPageSize**(): `number`

#### Returns

`number`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getPageSize](corelib.ServiceLookupEditorBase.md#getpagesize)

#### Defined in

[src/ui/editors/select2editor.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L119)

___

### getSelect2Options

▸ `Protected` **getSelect2Options**(): `Select2Options`

#### Returns

`Select2Options`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getSelect2Options](corelib.ServiceLookupEditorBase.md#getselect2options)

#### Defined in

[src/ui/editors/select2editor.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L184)

___

### getService

▸ `Protected` **getService**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getService](corelib.ServiceLookupEditorBase.md#getservice)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L43)

___

### getServiceCallOptions

▸ `Protected` **getServiceCallOptions**(`query`, `results`): [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`any`\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/corelib.Select2SearchQuery.md) |
| `results` | (`result`: [`Select2SearchResult`](../interfaces/corelib.Select2SearchResult.md)<`any`\>) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`any`\>\>

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getServiceCallOptions](corelib.ServiceLookupEditorBase.md#getservicecalloptions)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L150)

___

### getServiceUrl

▸ `Protected` **getServiceUrl**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getServiceUrl](corelib.ServiceLookupEditorBase.md#getserviceurl)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L47)

___

### getSort

▸ `Protected` **getSort**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getSort](corelib.ServiceLookupEditorBase.md#getsort)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L75)

___

### getTextField

▸ `Protected` **getTextField**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getTextField](corelib.ServiceLookupEditorBase.md#gettextfield)

#### Defined in

[src/ui/editors/select2editor.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L134)

___

### getTypeDelay

▸ `Protected` **getTypeDelay**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getTypeDelay](corelib.ServiceLookupEditorBase.md#gettypedelay)

#### Defined in

[src/ui/editors/select2editor.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L110)

___

### get\_cascadeField

▸ `Protected` **get_cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_cascadeField](corelib.ServiceLookupEditorBase.md#get_cascadefield)

#### Defined in

[src/ui/editors/select2editor.ts:741](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L741)

___

### get\_cascadeFrom

▸ `Protected` **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_cascadeFrom](corelib.ServiceLookupEditorBase.md#get_cascadefrom)

#### Defined in

[src/ui/editors/select2editor.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L722)

___

### get\_cascadeValue

▸ `Protected` **get_cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_cascadeValue](corelib.ServiceLookupEditorBase.md#get_cascadevalue)

#### Defined in

[src/ui/editors/select2editor.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L757)

___

### get\_delimited

▸ **get_delimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_delimited](corelib.ServiceLookupEditorBase.md#get_delimited)

#### Defined in

[src/ui/editors/select2editor.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L328)

___

### get\_filterField

▸ `Protected` **get_filterField**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_filterField](corelib.ServiceLookupEditorBase.md#get_filterfield)

#### Defined in

[src/ui/editors/select2editor.ts:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L777)

___

### get\_filterValue

▸ `Protected` **get_filterValue**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_filterValue](corelib.ServiceLookupEditorBase.md#get_filtervalue)

#### Defined in

[src/ui/editors/select2editor.ts:793](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L793)

___

### get\_itemByKey

▸ `Protected` **get_itemByKey**(): `Object`

#### Returns

`Object`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_itemByKey](corelib.ServiceLookupEditorBase.md#get_itembykey)

#### Defined in

[src/ui/editors/select2editor.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L525)

___

### get\_items

▸ `Protected` **get_items**(): `Select2Item`[]

#### Returns

`Select2Item`[]

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_items](corelib.ServiceLookupEditorBase.md#get_items)

#### Defined in

[src/ui/editors/select2editor.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L521)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_readOnly](corelib.ServiceLookupEditorBase.md#get_readonly)

#### Defined in

[src/ui/editors/select2editor.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L668)

___

### get\_select2Container

▸ `Protected` **get_select2Container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_select2Container](corelib.ServiceLookupEditorBase.md#get_select2container)

#### Defined in

[src/ui/editors/select2editor.ts:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L517)

___

### get\_text

▸ `Protected` **get_text**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_text](corelib.ServiceLookupEditorBase.md#get_text)

#### Defined in

[src/ui/editors/select2editor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L660)

___

### get\_value

▸ **get_value**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_value](corelib.ServiceLookupEditorBase.md#get_value)

#### Defined in

[src/ui/editors/select2editor.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L551)

___

### get\_values

▸ `Protected` **get_values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[get_values](corelib.ServiceLookupEditorBase.md#get_values)

#### Defined in

[src/ui/editors/select2editor.ts:623](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L623)

___

### hasAsyncSource

▸ `Protected` **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[hasAsyncSource](corelib.ServiceLookupEditorBase.md#hasasyncsource)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L169)

___

### init

▸ **init**(`action?`): [`ServiceLookupEditor`](corelib.ServiceLookupEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`ServiceLookupEditor`](corelib.ServiceLookupEditor.md)

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[init](corelib.ServiceLookupEditorBase.md#init)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[initNewEntity](corelib.ServiceLookupEditorBase.md#initnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:873](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L873)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[initialize](corelib.ServiceLookupEditorBase.md#initialize)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[inplaceCreateClick](corelib.ServiceLookupEditorBase.md#inplacecreateclick)

#### Defined in

[src/ui/editors/select2editor.ts:901](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L901)

___

### isAutoComplete

▸ `Protected` **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[isAutoComplete](corelib.ServiceLookupEditorBase.md#isautocomplete)

#### Defined in

[src/ui/editors/select2editor.ts:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L446)

___

### isMultiple

▸ `Protected` **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[isMultiple](corelib.ServiceLookupEditorBase.md#ismultiple)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[itemDisabled](corelib.ServiceLookupEditorBase.md#itemdisabled)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[itemId](corelib.ServiceLookupEditorBase.md#itemid)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[itemText](corelib.ServiceLookupEditorBase.md#itemtext)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[mapItem](corelib.ServiceLookupEditorBase.md#mapitem)

#### Defined in

[src/ui/editors/select2editor.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L149)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[mapItems](corelib.ServiceLookupEditorBase.md#mapitems)

#### Defined in

[src/ui/editors/select2editor.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L158)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[renderContents](corelib.ServiceLookupEditorBase.md#rendercontents)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[setCascadeFrom](corelib.ServiceLookupEditorBase.md#setcascadefrom)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[setEditDialogReadOnly](corelib.ServiceLookupEditorBase.md#seteditdialogreadonly)

#### Defined in

[src/ui/editors/select2editor.ts:887](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L887)

___

### setEditValue

▸ **setEditValue**(`source`, `property`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | `any` |
| `property` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[setEditValue](corelib.ServiceLookupEditorBase.md#seteditvalue)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[setTermOnNewEntity](corelib.ServiceLookupEditorBase.md#settermonnewentity)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[set_cascadeField](corelib.ServiceLookupEditorBase.md#set_cascadefield)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[set_cascadeFrom](corelib.ServiceLookupEditorBase.md#set_cascadefrom)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[set_cascadeValue](corelib.ServiceLookupEditorBase.md#set_cascadevalue)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[set_filterField](corelib.ServiceLookupEditorBase.md#set_filterfield)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[set_filterValue](corelib.ServiceLookupEditorBase.md#set_filtervalue)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[set_readOnly](corelib.ServiceLookupEditorBase.md#set_readonly)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[set_value](corelib.ServiceLookupEditorBase.md#set_value)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[set_values](corelib.ServiceLookupEditorBase.md#set_values)

#### Defined in

[src/ui/editors/select2editor.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L646)

___

### updateItems

▸ `Protected` **updateItems**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[updateItems](corelib.ServiceLookupEditorBase.md#updateitems)

#### Defined in

[src/ui/editors/select2editor.ts:851](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L851)

___

### useInplaceAdd

▸ `Protected` **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[useInplaceAdd](corelib.ServiceLookupEditorBase.md#useinplaceadd)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[create](corelib.ServiceLookupEditorBase.md#create)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[elementFor](corelib.ServiceLookupEditorBase.md#elementfor)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[filterByText](corelib.ServiceLookupEditorBase.md#filterbytext)

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

[ServiceLookupEditorBase](corelib.ServiceLookupEditorBase.md).[getWidgetName](corelib.ServiceLookupEditorBase.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
