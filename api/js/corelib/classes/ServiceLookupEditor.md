[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / ServiceLookupEditor

# Class: ServiceLookupEditor

## Hierarchy

- [`ServiceLookupEditorBase`](ServiceLookupEditorBase.md)<[`ServiceLookupEditorOptions`](../interfaces/ServiceLookupEditorOptions.md), `any`\>

  ↳ **`ServiceLookupEditor`**

## Table of contents

### Constructors

- [constructor](ServiceLookupEditor.md#constructor)

### Properties

- [cascadeLink](ServiceLookupEditor.md#cascadelink)
- [element](ServiceLookupEditor.md#element)
- [idPrefix](ServiceLookupEditor.md#idprefix)
- [lastCreateTerm](ServiceLookupEditor.md#lastcreateterm)
- [onInitNewEntity](ServiceLookupEditor.md#oninitnewentity)
- [openDialogAsPanel](ServiceLookupEditor.md#opendialogaspanel)
- [options](ServiceLookupEditor.md#options)
- [uniqueName](ServiceLookupEditor.md#uniquename)
- [widgetName](ServiceLookupEditor.md#widgetname)

### Accessors

- [cascadeField](ServiceLookupEditor.md#cascadefield)
- [cascadeFrom](ServiceLookupEditor.md#cascadefrom)
- [cascadeValue](ServiceLookupEditor.md#cascadevalue)
- [filterField](ServiceLookupEditor.md#filterfield)
- [filterValue](ServiceLookupEditor.md#filtervalue)
- [itemById](ServiceLookupEditor.md#itembyid)
- [items](ServiceLookupEditor.md#items)
- [readOnly](ServiceLookupEditor.md#readonly)
- [selectedItem](ServiceLookupEditor.md#selecteditem)
- [selectedItems](ServiceLookupEditor.md#selecteditems)
- [text](ServiceLookupEditor.md#text)
- [value](ServiceLookupEditor.md#value)
- [values](ServiceLookupEditor.md#values)

### Methods

- [abortPendingQuery](ServiceLookupEditor.md#abortpendingquery)
- [addCssClass](ServiceLookupEditor.md#addcssclass)
- [addInplaceCreate](ServiceLookupEditor.md#addinplacecreate)
- [addItem](ServiceLookupEditor.md#additem)
- [addOption](ServiceLookupEditor.md#addoption)
- [addValidationRule](ServiceLookupEditor.md#addvalidationrule)
- [allowClear](ServiceLookupEditor.md#allowclear)
- [asyncSearch](ServiceLookupEditor.md#asyncsearch)
- [cascadeItems](ServiceLookupEditor.md#cascadeitems)
- [change](ServiceLookupEditor.md#change)
- [changeSelect2](ServiceLookupEditor.md#changeselect2)
- [clearItems](ServiceLookupEditor.md#clearitems)
- [createEditDialog](ServiceLookupEditor.md#createeditdialog)
- [destroy](ServiceLookupEditor.md#destroy)
- [editDialogDataChange](ServiceLookupEditor.md#editdialogdatachange)
- [emptyItemText](ServiceLookupEditor.md#emptyitemtext)
- [filterItems](ServiceLookupEditor.md#filteritems)
- [getCascadeCriteria](ServiceLookupEditor.md#getcascadecriteria)
- [getCascadeFromValue](ServiceLookupEditor.md#getcascadefromvalue)
- [getCreateSearchChoice](ServiceLookupEditor.md#getcreatesearchchoice)
- [getCriteria](ServiceLookupEditor.md#getcriteria)
- [getCssClass](ServiceLookupEditor.md#getcssclass)
- [getDialogTypeKey](ServiceLookupEditor.md#getdialogtypekey)
- [getEditValue](ServiceLookupEditor.md#geteditvalue)
- [getFilterCriteria](ServiceLookupEditor.md#getfiltercriteria)
- [getGridField](ServiceLookupEditor.md#getgridfield)
- [getIdField](ServiceLookupEditor.md#getidfield)
- [getIdListCriteria](ServiceLookupEditor.md#getidlistcriteria)
- [getIncludeColumns](ServiceLookupEditor.md#getincludecolumns)
- [getListRequest](ServiceLookupEditor.md#getlistrequest)
- [getPageSize](ServiceLookupEditor.md#getpagesize)
- [getSelect2Options](ServiceLookupEditor.md#getselect2options)
- [getService](ServiceLookupEditor.md#getservice)
- [getServiceCallOptions](ServiceLookupEditor.md#getservicecalloptions)
- [getServiceUrl](ServiceLookupEditor.md#getserviceurl)
- [getSort](ServiceLookupEditor.md#getsort)
- [getTextField](ServiceLookupEditor.md#gettextfield)
- [getTypeDelay](ServiceLookupEditor.md#gettypedelay)
- [get\_cascadeField](ServiceLookupEditor.md#get_cascadefield)
- [get\_cascadeFrom](ServiceLookupEditor.md#get_cascadefrom)
- [get\_cascadeValue](ServiceLookupEditor.md#get_cascadevalue)
- [get\_delimited](ServiceLookupEditor.md#get_delimited)
- [get\_filterField](ServiceLookupEditor.md#get_filterfield)
- [get\_filterValue](ServiceLookupEditor.md#get_filtervalue)
- [get\_itemByKey](ServiceLookupEditor.md#get_itembykey)
- [get\_items](ServiceLookupEditor.md#get_items)
- [get\_readOnly](ServiceLookupEditor.md#get_readonly)
- [get\_select2Container](ServiceLookupEditor.md#get_select2container)
- [get\_text](ServiceLookupEditor.md#get_text)
- [get\_value](ServiceLookupEditor.md#get_value)
- [get\_values](ServiceLookupEditor.md#get_values)
- [hasAsyncSource](ServiceLookupEditor.md#hasasyncsource)
- [init](ServiceLookupEditor.md#init)
- [initNewEntity](ServiceLookupEditor.md#initnewentity)
- [initialize](ServiceLookupEditor.md#initialize)
- [inplaceCreateClick](ServiceLookupEditor.md#inplacecreateclick)
- [isAutoComplete](ServiceLookupEditor.md#isautocomplete)
- [isMultiple](ServiceLookupEditor.md#ismultiple)
- [itemDisabled](ServiceLookupEditor.md#itemdisabled)
- [itemId](ServiceLookupEditor.md#itemid)
- [itemText](ServiceLookupEditor.md#itemtext)
- [mapItem](ServiceLookupEditor.md#mapitem)
- [mapItems](ServiceLookupEditor.md#mapitems)
- [renderContents](ServiceLookupEditor.md#rendercontents)
- [setCascadeFrom](ServiceLookupEditor.md#setcascadefrom)
- [setEditDialogReadOnly](ServiceLookupEditor.md#seteditdialogreadonly)
- [setEditValue](ServiceLookupEditor.md#seteditvalue)
- [setTermOnNewEntity](ServiceLookupEditor.md#settermonnewentity)
- [set\_cascadeField](ServiceLookupEditor.md#set_cascadefield)
- [set\_cascadeFrom](ServiceLookupEditor.md#set_cascadefrom)
- [set\_cascadeValue](ServiceLookupEditor.md#set_cascadevalue)
- [set\_filterField](ServiceLookupEditor.md#set_filterfield)
- [set\_filterValue](ServiceLookupEditor.md#set_filtervalue)
- [set\_readOnly](ServiceLookupEditor.md#set_readonly)
- [set\_value](ServiceLookupEditor.md#set_value)
- [set\_values](ServiceLookupEditor.md#set_values)
- [updateItems](ServiceLookupEditor.md#updateitems)
- [useInplaceAdd](ServiceLookupEditor.md#useinplaceadd)
- [create](ServiceLookupEditor.md#create)
- [elementFor](ServiceLookupEditor.md#elementfor)
- [filterByText](ServiceLookupEditor.md#filterbytext)
- [getWidgetName](ServiceLookupEditor.md#getwidgetname)

## Constructors

### constructor

• **new ServiceLookupEditor**(`hidden`, `opt?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `hidden` | `JQuery` |
| `opt?` | [`ServiceLookupEditorOptions`](../interfaces/ServiceLookupEditorOptions.md) |

#### Overrides

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[constructor](ServiceLookupEditorBase.md#constructor)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L181)

## Properties

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)<[`Widget`](Widget.md)<`any`\>\>

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[cascadeLink](ServiceLookupEditorBase.md#cascadelink)

#### Defined in

[src/ui/editors/select2editor.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L701)

___

### element

• **element**: `JQuery`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[element](ServiceLookupEditorBase.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[idPrefix](ServiceLookupEditorBase.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### lastCreateTerm

• `Protected` **lastCreateTerm**: `string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[lastCreateTerm](ServiceLookupEditorBase.md#lastcreateterm)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[onInitNewEntity](ServiceLookupEditorBase.md#oninitnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:871](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L871)

___

### openDialogAsPanel

• **openDialogAsPanel**: `boolean`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[openDialogAsPanel](ServiceLookupEditorBase.md#opendialogaspanel)

#### Defined in

[src/ui/editors/select2editor.ts:972](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L972)

___

### options

• `Protected` **options**: [`ServiceLookupEditorOptions`](../interfaces/ServiceLookupEditorOptions.md)

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[options](ServiceLookupEditorBase.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[uniqueName](ServiceLookupEditorBase.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[widgetName](ServiceLookupEditorBase.md#widgetname)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[abortPendingQuery](ServiceLookupEditorBase.md#abortpendingquery)

#### Defined in

[src/ui/editors/select2editor.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L175)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[addCssClass](ServiceLookupEditorBase.md#addcssclass)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[addInplaceCreate](ServiceLookupEditorBase.md#addinplacecreate)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[addItem](ServiceLookupEditorBase.md#additem)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[addOption](ServiceLookupEditorBase.md#addoption)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[addValidationRule](ServiceLookupEditorBase.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### allowClear

▸ `Protected` **allowClear**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[allowClear](ServiceLookupEditorBase.md#allowclear)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[asyncSearch](ServiceLookupEditorBase.md#asyncsearch)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[cascadeItems](ServiceLookupEditorBase.md#cascadeitems)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[change](ServiceLookupEditorBase.md#change)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[change](ServiceLookupEditorBase.md#change)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[changeSelect2](ServiceLookupEditorBase.md#changeselect2)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[changeSelect2](ServiceLookupEditorBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### clearItems

▸ **clearItems**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[clearItems](ServiceLookupEditorBase.md#clearitems)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[createEditDialog](ServiceLookupEditorBase.md#createeditdialog)

#### Defined in

[src/ui/editors/select2editor.ts:862](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L862)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[destroy](ServiceLookupEditorBase.md#destroy)

#### Defined in

[src/ui/editors/select2editor.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L91)

___

### editDialogDataChange

▸ `Protected` **editDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[editDialogDataChange](ServiceLookupEditorBase.md#editdialogdatachange)

#### Defined in

[src/ui/editors/select2editor.ts:895](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L895)

___

### emptyItemText

▸ `Protected` **emptyItemText**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[emptyItemText](ServiceLookupEditorBase.md#emptyitemtext)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[filterItems](ServiceLookupEditorBase.md#filteritems)

#### Defined in

[src/ui/editors/select2editor.ts:835](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L835)

___

### getCascadeCriteria

▸ `Protected` **getCascadeCriteria**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getCascadeCriteria](ServiceLookupEditorBase.md#getcascadecriteria)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L79)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getCascadeFromValue](ServiceLookupEditorBase.md#getcascadefromvalue)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getCreateSearchChoice](ServiceLookupEditorBase.md#getcreatesearchchoice)

#### Defined in

[src/ui/editors/select2editor.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L450)

___

### getCriteria

▸ `Protected` **getCriteria**(`query`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/Select2SearchQuery.md) |

#### Returns

`any`[]

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getCriteria](ServiceLookupEditorBase.md#getcriteria)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L122)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getCssClass](ServiceLookupEditorBase.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getDialogTypeKey

▸ `Protected` **getDialogTypeKey**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getDialogTypeKey](ServiceLookupEditorBase.md#getdialogtypekey)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L28)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getEditValue](ServiceLookupEditorBase.md#geteditvalue)

#### Defined in

[src/ui/editors/select2editor.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L508)

___

### getFilterCriteria

▸ `Protected` **getFilterCriteria**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getFilterCriteria](ServiceLookupEditorBase.md#getfiltercriteria)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L97)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getGridField](ServiceLookupEditorBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getIdField

▸ `Protected` **getIdField**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getIdField](ServiceLookupEditorBase.md#getidfield)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getIdListCriteria](ServiceLookupEditorBase.md#getidlistcriteria)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L108)

___

### getIncludeColumns

▸ `Protected` **getIncludeColumns**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getIncludeColumns](ServiceLookupEditorBase.md#getincludecolumns)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L61)

___

### getListRequest

▸ `Protected` **getListRequest**(`query`): [`ListRequest`](../interfaces/ListRequest.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/Select2SearchQuery.md) |

#### Returns

[`ListRequest`](../interfaces/ListRequest.md)

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getListRequest](ServiceLookupEditorBase.md#getlistrequest)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L128)

___

### getPageSize

▸ `Protected` **getPageSize**(): `number`

#### Returns

`number`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getPageSize](ServiceLookupEditorBase.md#getpagesize)

#### Defined in

[src/ui/editors/select2editor.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L119)

___

### getSelect2Options

▸ `Protected` **getSelect2Options**(): `Select2Options`

#### Returns

`Select2Options`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getSelect2Options](ServiceLookupEditorBase.md#getselect2options)

#### Defined in

[src/ui/editors/select2editor.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L184)

___

### getService

▸ `Protected` **getService**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getService](ServiceLookupEditorBase.md#getservice)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L43)

___

### getServiceCallOptions

▸ `Protected` **getServiceCallOptions**(`query`, `results`): [`ServiceOptions`](../interfaces/ServiceOptions.md)<[`ListResponse`](../interfaces/ListResponse.md)<`any`\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`Select2SearchQuery`](../interfaces/Select2SearchQuery.md) |
| `results` | (`result`: [`Select2SearchResult`](../interfaces/Select2SearchResult.md)<`any`\>) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)<[`ListResponse`](../interfaces/ListResponse.md)<`any`\>\>

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getServiceCallOptions](ServiceLookupEditorBase.md#getservicecalloptions)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L150)

___

### getServiceUrl

▸ `Protected` **getServiceUrl**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getServiceUrl](ServiceLookupEditorBase.md#getserviceurl)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L47)

___

### getSort

▸ `Protected` **getSort**(): `any`[]

#### Returns

`any`[]

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getSort](ServiceLookupEditorBase.md#getsort)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L75)

___

### getTextField

▸ `Protected` **getTextField**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getTextField](ServiceLookupEditorBase.md#gettextfield)

#### Defined in

[src/ui/editors/select2editor.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L134)

___

### getTypeDelay

▸ `Protected` **getTypeDelay**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getTypeDelay](ServiceLookupEditorBase.md#gettypedelay)

#### Defined in

[src/ui/editors/select2editor.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L110)

___

### get\_cascadeField

▸ `Protected` **get_cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_cascadeField](ServiceLookupEditorBase.md#get_cascadefield)

#### Defined in

[src/ui/editors/select2editor.ts:741](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L741)

___

### get\_cascadeFrom

▸ `Protected` **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_cascadeFrom](ServiceLookupEditorBase.md#get_cascadefrom)

#### Defined in

[src/ui/editors/select2editor.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L722)

___

### get\_cascadeValue

▸ `Protected` **get_cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_cascadeValue](ServiceLookupEditorBase.md#get_cascadevalue)

#### Defined in

[src/ui/editors/select2editor.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L757)

___

### get\_delimited

▸ **get_delimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_delimited](ServiceLookupEditorBase.md#get_delimited)

#### Defined in

[src/ui/editors/select2editor.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L328)

___

### get\_filterField

▸ `Protected` **get_filterField**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_filterField](ServiceLookupEditorBase.md#get_filterfield)

#### Defined in

[src/ui/editors/select2editor.ts:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L777)

___

### get\_filterValue

▸ `Protected` **get_filterValue**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_filterValue](ServiceLookupEditorBase.md#get_filtervalue)

#### Defined in

[src/ui/editors/select2editor.ts:793](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L793)

___

### get\_itemByKey

▸ `Protected` **get_itemByKey**(): `Object`

#### Returns

`Object`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_itemByKey](ServiceLookupEditorBase.md#get_itembykey)

#### Defined in

[src/ui/editors/select2editor.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L525)

___

### get\_items

▸ `Protected` **get_items**(): `Select2Item`[]

#### Returns

`Select2Item`[]

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_items](ServiceLookupEditorBase.md#get_items)

#### Defined in

[src/ui/editors/select2editor.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L521)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_readOnly](ServiceLookupEditorBase.md#get_readonly)

#### Defined in

[src/ui/editors/select2editor.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L668)

___

### get\_select2Container

▸ `Protected` **get_select2Container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_select2Container](ServiceLookupEditorBase.md#get_select2container)

#### Defined in

[src/ui/editors/select2editor.ts:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L517)

___

### get\_text

▸ `Protected` **get_text**(): `string`

#### Returns

`string`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_text](ServiceLookupEditorBase.md#get_text)

#### Defined in

[src/ui/editors/select2editor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L660)

___

### get\_value

▸ **get_value**(): `any`

#### Returns

`any`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_value](ServiceLookupEditorBase.md#get_value)

#### Defined in

[src/ui/editors/select2editor.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L551)

___

### get\_values

▸ `Protected` **get_values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[get_values](ServiceLookupEditorBase.md#get_values)

#### Defined in

[src/ui/editors/select2editor.ts:623](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L623)

___

### hasAsyncSource

▸ `Protected` **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[hasAsyncSource](ServiceLookupEditorBase.md#hasasyncsource)

#### Defined in

[src/ui/editors/servicelookupeditor.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L169)

___

### init

▸ **init**(`action?`): [`ServiceLookupEditor`](ServiceLookupEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`ServiceLookupEditor`](ServiceLookupEditor.md)

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[init](ServiceLookupEditorBase.md#init)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[initNewEntity](ServiceLookupEditorBase.md#initnewentity)

#### Defined in

[src/ui/editors/select2editor.ts:873](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L873)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[initialize](ServiceLookupEditorBase.md#initialize)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[inplaceCreateClick](ServiceLookupEditorBase.md#inplacecreateclick)

#### Defined in

[src/ui/editors/select2editor.ts:901](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L901)

___

### isAutoComplete

▸ `Protected` **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[isAutoComplete](ServiceLookupEditorBase.md#isautocomplete)

#### Defined in

[src/ui/editors/select2editor.ts:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L446)

___

### isMultiple

▸ `Protected` **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[isMultiple](ServiceLookupEditorBase.md#ismultiple)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[itemDisabled](ServiceLookupEditorBase.md#itemdisabled)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[itemId](ServiceLookupEditorBase.md#itemid)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[itemText](ServiceLookupEditorBase.md#itemtext)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[mapItem](ServiceLookupEditorBase.md#mapitem)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[mapItems](ServiceLookupEditorBase.md#mapitems)

#### Defined in

[src/ui/editors/select2editor.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L158)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[renderContents](ServiceLookupEditorBase.md#rendercontents)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[setCascadeFrom](ServiceLookupEditorBase.md#setcascadefrom)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[setEditDialogReadOnly](ServiceLookupEditorBase.md#seteditdialogreadonly)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[setEditValue](ServiceLookupEditorBase.md#seteditvalue)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[setTermOnNewEntity](ServiceLookupEditorBase.md#settermonnewentity)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[set_cascadeField](ServiceLookupEditorBase.md#set_cascadefield)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[set_cascadeFrom](ServiceLookupEditorBase.md#set_cascadefrom)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[set_cascadeValue](ServiceLookupEditorBase.md#set_cascadevalue)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[set_filterField](ServiceLookupEditorBase.md#set_filterfield)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[set_filterValue](ServiceLookupEditorBase.md#set_filtervalue)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[set_readOnly](ServiceLookupEditorBase.md#set_readonly)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[set_value](ServiceLookupEditorBase.md#set_value)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[set_values](ServiceLookupEditorBase.md#set_values)

#### Defined in

[src/ui/editors/select2editor.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L646)

___

### updateItems

▸ `Protected` **updateItems**(): `void`

#### Returns

`void`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[updateItems](ServiceLookupEditorBase.md#updateitems)

#### Defined in

[src/ui/editors/select2editor.ts:851](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2editor.ts#L851)

___

### useInplaceAdd

▸ `Protected` **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[useInplaceAdd](ServiceLookupEditorBase.md#useinplaceadd)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[create](ServiceLookupEditorBase.md#create)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[elementFor](ServiceLookupEditorBase.md#elementfor)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[filterByText](ServiceLookupEditorBase.md#filterbytext)

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

[ServiceLookupEditorBase](ServiceLookupEditorBase.md).[getWidgetName](ServiceLookupEditorBase.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
