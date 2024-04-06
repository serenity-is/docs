[@serenity-is/corelib](../README.md) / ComboboxEditor

# Class: ComboboxEditor\<P, TItem\>

## Type parameters

| Name |
| :------ |
| `P` |
| `TItem` |

## Hierarchy

- [`Widget`](Widget.md)\<`P`\>

  ↳ **`ComboboxEditor`**

  ↳↳ [`SelectEditor`](SelectEditor.md)

  ↳↳ [`EnumEditor`](EnumEditor.md)

  ↳↳ [`LookupEditorBase`](LookupEditorBase.md)

  ↳↳ [`ServiceLookupEditorBase`](ServiceLookupEditorBase.md)

## Implements

- [`ISetEditValue`](ISetEditValue.md)
- [`IGetEditValue`](IGetEditValue.md)
- [`IStringValue`](IStringValue.md)
- [`IReadOnly`](IReadOnly.md)

## Table of contents

### Constructors

- [constructor](ComboboxEditor.md#constructor)

### Properties

- [cascadeLink](ComboboxEditor.md#cascadelink)
- [domNode](ComboboxEditor.md#domnode)
- [idPrefix](ComboboxEditor.md#idprefix)
- [lastCreateTerm](ComboboxEditor.md#lastcreateterm)
- [onInitNewEntity](ComboboxEditor.md#oninitnewentity)
- [openDialogAsPanel](ComboboxEditor.md#opendialogaspanel)
- [options](ComboboxEditor.md#options)
- [uniqueName](ComboboxEditor.md#uniquename)
- [typeInfo](ComboboxEditor.md#typeinfo)

### Accessors

- [cascadeField](ComboboxEditor.md#cascadefield)
- [cascadeFrom](ComboboxEditor.md#cascadefrom)
- [cascadeValue](ComboboxEditor.md#cascadevalue)
- [element](ComboboxEditor.md#element)
- [filterField](ComboboxEditor.md#filterfield)
- [filterValue](ComboboxEditor.md#filtervalue)
- [itemById](ComboboxEditor.md#itembyid)
- [items](ComboboxEditor.md#items)
- [props](ComboboxEditor.md#props)
- [readOnly](ComboboxEditor.md#readonly)
- [selectedItem](ComboboxEditor.md#selecteditem)
- [selectedItems](ComboboxEditor.md#selecteditems)
- [text](ComboboxEditor.md#text)
- [value](ComboboxEditor.md#value)
- [values](ComboboxEditor.md#values)

### Methods

- [abortPendingQuery](ComboboxEditor.md#abortpendingquery)
- [addCssClass](ComboboxEditor.md#addcssclass)
- [addInplaceCreate](ComboboxEditor.md#addinplacecreate)
- [addItem](ComboboxEditor.md#additem)
- [addOption](ComboboxEditor.md#addoption)
- [addValidationRule](ComboboxEditor.md#addvalidationrule)
- [allowClear](ComboboxEditor.md#allowclear)
- [asyncSearch](ComboboxEditor.md#asyncsearch)
- [cascadeItems](ComboboxEditor.md#cascadeitems)
- [change](ComboboxEditor.md#change)
- [changeSelect2](ComboboxEditor.md#changeselect2)
- [clearItems](ComboboxEditor.md#clearitems)
- [createEditDialog](ComboboxEditor.md#createeditdialog)
- [destroy](ComboboxEditor.md#destroy)
- [editDialogDataChange](ComboboxEditor.md#editdialogdatachange)
- [emptyItemText](ComboboxEditor.md#emptyitemtext)
- [filterItems](ComboboxEditor.md#filteritems)
- [getCascadeFromValue](ComboboxEditor.md#getcascadefromvalue)
- [getComboboxContainer](ComboboxEditor.md#getcomboboxcontainer)
- [getComboboxOptions](ComboboxEditor.md#getcomboboxoptions)
- [getCreateSearchChoice](ComboboxEditor.md#getcreatesearchchoice)
- [getCssClass](ComboboxEditor.md#getcssclass)
- [getCustomAttribute](ComboboxEditor.md#getcustomattribute)
- [getDialogTypeKey](ComboboxEditor.md#getdialogtypekey)
- [getEditValue](ComboboxEditor.md#geteditvalue)
- [getFieldElement](ComboboxEditor.md#getfieldelement)
- [getGridField](ComboboxEditor.md#getgridfield)
- [getIdField](ComboboxEditor.md#getidfield)
- [getPageSize](ComboboxEditor.md#getpagesize)
- [getTextField](ComboboxEditor.md#gettextfield)
- [getTypeDelay](ComboboxEditor.md#gettypedelay)
- [get\_cascadeField](ComboboxEditor.md#get_cascadefield)
- [get\_cascadeFrom](ComboboxEditor.md#get_cascadefrom)
- [get\_cascadeValue](ComboboxEditor.md#get_cascadevalue)
- [get\_delimited](ComboboxEditor.md#get_delimited)
- [get\_filterField](ComboboxEditor.md#get_filterfield)
- [get\_filterValue](ComboboxEditor.md#get_filtervalue)
- [get\_itemByKey](ComboboxEditor.md#get_itembykey)
- [get\_items](ComboboxEditor.md#get_items)
- [get\_readOnly](ComboboxEditor.md#get_readonly)
- [get\_text](ComboboxEditor.md#get_text)
- [get\_value](ComboboxEditor.md#get_value)
- [get\_values](ComboboxEditor.md#get_values)
- [hasAsyncSource](ComboboxEditor.md#hasasyncsource)
- [init](ComboboxEditor.md#init)
- [initNewEntity](ComboboxEditor.md#initnewentity)
- [inplaceCreateClick](ComboboxEditor.md#inplacecreateclick)
- [internalInit](ComboboxEditor.md#internalinit)
- [internalRenderContents](ComboboxEditor.md#internalrendercontents)
- [isAutoComplete](ComboboxEditor.md#isautocomplete)
- [isMultiple](ComboboxEditor.md#ismultiple)
- [itemDisabled](ComboboxEditor.md#itemdisabled)
- [itemId](ComboboxEditor.md#itemid)
- [itemText](ComboboxEditor.md#itemtext)
- [mapItem](ComboboxEditor.md#mapitem)
- [mapItems](ComboboxEditor.md#mapitems)
- [openDropdown](ComboboxEditor.md#opendropdown)
- [render](ComboboxEditor.md#render)
- [renderContents](ComboboxEditor.md#rendercontents)
- [setCascadeFrom](ComboboxEditor.md#setcascadefrom)
- [setEditDialogReadOnly](ComboboxEditor.md#seteditdialogreadonly)
- [setEditValue](ComboboxEditor.md#seteditvalue)
- [setTermOnNewEntity](ComboboxEditor.md#settermonnewentity)
- [set\_cascadeField](ComboboxEditor.md#set_cascadefield)
- [set\_cascadeFrom](ComboboxEditor.md#set_cascadefrom)
- [set\_cascadeValue](ComboboxEditor.md#set_cascadevalue)
- [set\_filterField](ComboboxEditor.md#set_filterfield)
- [set\_filterValue](ComboboxEditor.md#set_filtervalue)
- [set\_readOnly](ComboboxEditor.md#set_readonly)
- [set\_value](ComboboxEditor.md#set_value)
- [set\_values](ComboboxEditor.md#set_values)
- [syncOrAsyncThen](ComboboxEditor.md#syncorasyncthen)
- [updateItems](ComboboxEditor.md#updateitems)
- [useIdPrefix](ComboboxEditor.md#useidprefix)
- [useInplaceAdd](ComboboxEditor.md#useinplaceadd)
- [create](ComboboxEditor.md#create)
- [createDefaultElement](ComboboxEditor.md#createdefaultelement)
- [filterByText](ComboboxEditor.md#filterbytext)
- [getWidgetName](ComboboxEditor.md#getwidgetname)

## Constructors

### constructor

• **new ComboboxEditor**\<`P`, `TItem`\>(`props`): [`ComboboxEditor`](ComboboxEditor.md)\<`P`, `TItem`\>

#### Type parameters

| Name |
| :------ |
| `P` |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`ComboboxEditor`](ComboboxEditor.md)\<`P`, `TItem`\>

#### Overrides

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/editors/comboboxeditor.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L51)

## Properties

### cascadeLink

• `Protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

#### Defined in

[src/ui/editors/comboboxeditor.ts:572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L572)

___

### domNode

• `Readonly` **domNode**: `HTMLInputElement`

#### Overrides

[Widget](Widget.md).[domNode](Widget.md#domnode)

#### Defined in

[src/ui/editors/comboboxeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L44)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](Widget.md).[idPrefix](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### lastCreateTerm

• `Protected` **lastCreateTerm**: `string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L49)

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

#### Defined in

[src/ui/editors/comboboxeditor.ts:740](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L740)

___

### openDialogAsPanel

• **openDialogAsPanel**: `boolean`

#### Defined in

[src/ui/editors/comboboxeditor.ts:846](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L846)

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

### cascadeField

• `get` **cascadeField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:616](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L616)

• `set` **cascadeField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L624)

___

### cascadeFrom

• `get` **cascadeFrom**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:597](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L597)

• `set` **cascadeFrom**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:608](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L608)

___

### cascadeValue

• `get` **cascadeValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/comboboxeditor.ts:632](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L632)

• `set` **cascadeValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L644)

___

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

### filterField

• `get` **filterField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:652](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L652)

• `set` **filterField**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L660)

___

### filterValue

• `get` **filterValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/comboboxeditor.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L668)

• `set` **filterValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L680)

___

### itemById

• `get` **itemById**(): `Object`

#### Returns

`Object`

#### Defined in

[src/ui/editors/comboboxeditor.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L259)

• `set` **itemById**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Object` |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L266)

___

### items

• `get` **items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Defined in

[src/ui/editors/comboboxeditor.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L242)

• `set` **items**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L249)

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

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/comboboxeditor.ts:542](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L542)

• `set` **readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:564](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L564)

___

### selectedItem

• `get` **selectedItem**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/editors/comboboxeditor.ts:485](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L485)

___

### selectedItems

• `get` **selectedItems**(): `TItem`[]

#### Returns

`TItem`[]

#### Defined in

[src/ui/editors/comboboxeditor.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L495)

___

### text

• `get` **text**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:534](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L534)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:466](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L466)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L481)

___

### values

• `get` **values**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/editors/comboboxeditor.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L514)

• `set` **values**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string`[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L522)

## Methods

### abortPendingQuery

▸ **abortPendingQuery**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L157)

___

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addCssClass](Widget.md#addcssclass)

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

#### Defined in

[src/ui/editors/comboboxeditor.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L298)

___

### addItem

▸ **addItem**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\> |

#### Returns

`void`

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

### allowClear

▸ **allowClear**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/comboboxeditor.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L148)

___

### asyncSearch

▸ **asyncSearch**(`query`): `PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<`TItem`\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md) |

#### Returns

`PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<`TItem`\>\>

#### Defined in

[src/ui/editors/comboboxeditor.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L89)

___

### cascadeItems

▸ **cascadeItems**(`items`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

`TItem`[]

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

### clearItems

▸ **clearItems**(): `void`

#### Returns

`void`

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

#### Defined in

[src/ui/editors/comboboxeditor.ts:733](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L733)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Widget](Widget.md).[destroy](Widget.md#destroy)

#### Defined in

[src/ui/editors/comboboxeditor.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L79)

___

### editDialogDataChange

▸ **editDialogDataChange**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:765](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L765)

___

### emptyItemText

▸ **emptyItemText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L100)

___

### filterItems

▸ **filterItems**(`items`): `TItem`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

`TItem`[]

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

#### Defined in

[src/ui/editors/comboboxeditor.ts:568](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L568)

___

### getComboboxContainer

▸ **getComboboxContainer**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/comboboxeditor.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L428)

___

### getComboboxOptions

▸ **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

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

#### Defined in

[src/ui/editors/comboboxeditor.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L363)

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

### getDialogTypeKey

▸ **getDialogTypeKey**(): `string`

#### Returns

`string`

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

#### Implementation of

[IGetEditValue](IGetEditValue.md).[getEditValue](IGetEditValue.md#geteditvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L419)

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

### getIdField

▸ **getIdField**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/comboboxeditor.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L109)

___

### getPageSize

▸ **getPageSize**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/editors/comboboxeditor.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L105)

___

### getTextField

▸ **getTextField**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/comboboxeditor.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L120)

___

### getTypeDelay

▸ **getTypeDelay**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/comboboxeditor.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L96)

___

### get\_cascadeField

▸ **get_cascadeField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:612](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L612)

___

### get\_cascadeFrom

▸ **get_cascadeFrom**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:593](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L593)

___

### get\_cascadeValue

▸ **get_cascadeValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/comboboxeditor.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L628)

___

### get\_delimited

▸ **get_delimited**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/comboboxeditor.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L238)

___

### get\_filterField

▸ **get_filterField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L648)

___

### get\_filterValue

▸ **get_filterValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/comboboxeditor.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L664)

___

### get\_itemByKey

▸ **get_itemByKey**(): `Object`

#### Returns

`Object`

#### Defined in

[src/ui/editors/comboboxeditor.ts:436](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L436)

___

### get\_items

▸ **get_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Defined in

[src/ui/editors/comboboxeditor.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L432)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/comboboxeditor.ts:538](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L538)

___

### get\_text

▸ **get_text**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L526)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Implementation of

[IStringValue](IStringValue.md).[get_value](IStringValue.md#get_value)

#### Defined in

[src/ui/editors/comboboxeditor.ts:462](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L462)

___

### get\_values

▸ **get_values**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/editors/comboboxeditor.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L510)

___

### hasAsyncSource

▸ **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/comboboxeditor.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L85)

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

### initNewEntity

▸ **initNewEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |

#### Returns

`void`

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

#### Defined in

[src/ui/editors/comboboxeditor.ts:771](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L771)

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

### isAutoComplete

▸ **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/comboboxeditor.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L359)

___

### isMultiple

▸ **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/comboboxeditor.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L153)

___

### itemDisabled

▸ **itemDisabled**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`boolean`

#### Defined in

[src/ui/editors/comboboxeditor.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L131)

___

### itemId

▸ **itemId**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L113)

___

### itemText

▸ **itemText**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

`string`

#### Defined in

[src/ui/editors/comboboxeditor.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L124)

___

### mapItem

▸ **mapItem**(`item`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Defined in

[src/ui/editors/comboboxeditor.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L135)

___

### mapItems

▸ **mapItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Defined in

[src/ui/editors/comboboxeditor.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L144)

___

### openDropdown

▸ **openDropdown**(): `void`

#### Returns

`void`

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

[Widget](Widget.md).[render](Widget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[Widget](Widget.md).[renderContents](Widget.md#rendercontents)

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

#### Implementation of

[ISetEditValue](ISetEditValue.md).[setEditValue](ISetEditValue.md#seteditvalue)

#### Defined in

[src/ui/editors/comboboxeditor.ts:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L409)

___

### setTermOnNewEntity

▸ **setTermOnNewEntity**(`entity`, `term`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |
| `term` | `string` |

#### Returns

`void`

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

#### Implementation of

[IReadOnly](IReadOnly.md).[set_readOnly](IReadOnly.md#set_readonly)

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

#### Implementation of

[IStringValue](IStringValue.md).[set_value](IStringValue.md#set_value)

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

[Widget](Widget.md).[syncOrAsyncThen](Widget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### updateItems

▸ **updateItems**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/comboboxeditor.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.ts#L722)

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

### useInplaceAdd

▸ **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

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

[Widget](Widget.md).[create](Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Overrides

[Widget](Widget.md).[createDefaultElement](Widget.md#createdefaultelement)

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

[Widget](Widget.md).[getWidgetName](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
