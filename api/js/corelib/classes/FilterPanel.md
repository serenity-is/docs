[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / FilterPanel

# Class: FilterPanel

## Hierarchy

- [`FilterWidgetBase`](FilterWidgetBase.md)<`any`\>

  ↳ **`FilterPanel`**

## Table of contents

### Constructors

- [constructor](FilterPanel.md#constructor)

### Properties

- [element](FilterPanel.md#element)
- [idPrefix](FilterPanel.md#idprefix)
- [options](FilterPanel.md#options)
- [rowsDiv](FilterPanel.md#rowsdiv)
- [showInitialLine](FilterPanel.md#showinitialline)
- [showSearchButton](FilterPanel.md#showsearchbutton)
- [uniqueName](FilterPanel.md#uniquename)
- [updateStoreOnReset](FilterPanel.md#updatestoreonreset)
- [widgetName](FilterPanel.md#widgetname)

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
- [findEmptyRow](FilterPanel.md#findemptyrow)
- [getCssClass](FilterPanel.md#getcssclass)
- [getFallbackTemplate](FilterPanel.md#getfallbacktemplate)
- [getFieldFor](FilterPanel.md#getfieldfor)
- [getFilteringFor](FilterPanel.md#getfilteringfor)
- [getGridField](FilterPanel.md#getgridfield)
- [getTemplate](FilterPanel.md#gettemplate)
- [getTemplateName](FilterPanel.md#gettemplatename)
- [get\_hasErrors](FilterPanel.md#get_haserrors)
- [get\_showInitialLine](FilterPanel.md#get_showinitialline)
- [get\_showSearchButton](FilterPanel.md#get_showsearchbutton)
- [get\_store](FilterPanel.md#get_store)
- [get\_updateStoreOnReset](FilterPanel.md#get_updatestoreonreset)
- [init](FilterPanel.md#init)
- [initButtons](FilterPanel.md#initbuttons)
- [initialize](FilterPanel.md#initialize)
- [leftRightParenClick](FilterPanel.md#leftrightparenclick)
- [onRowFieldChange](FilterPanel.md#onrowfieldchange)
- [onRowOperatorChange](FilterPanel.md#onrowoperatorchange)
- [populateOperatorList](FilterPanel.md#populateoperatorlist)
- [removeFiltering](FilterPanel.md#removefiltering)
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
- [updateButtons](FilterPanel.md#updatebuttons)
- [updateParens](FilterPanel.md#updateparens)
- [updateRowsFromStore](FilterPanel.md#updaterowsfromstore)
- [useIdPrefix](FilterPanel.md#useidprefix)
- [create](FilterPanel.md#create)
- [elementFor](FilterPanel.md#elementfor)
- [getWidgetName](FilterPanel.md#getwidgetname)

## Constructors

### constructor

• **new FilterPanel**(`div`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[constructor](FilterWidgetBase.md#constructor)

#### Defined in

[src/ui/filtering/filterpanel.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L67)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[element](FilterWidgetBase.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[idPrefix](FilterWidgetBase.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: `any`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[options](FilterWidgetBase.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### rowsDiv

• `Private` **rowsDiv**: `JQuery`

#### Defined in

[src/ui/filtering/filterpanel.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L65)

___

### showInitialLine

• `Private` **showInitialLine**: `boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L76)

___

### showSearchButton

• `Private` **showSearchButton**: `boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L137)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[uniqueName](FilterWidgetBase.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### updateStoreOnReset

• `Private` **updateStoreOnReset**: `boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L150)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[widgetName](FilterWidgetBase.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addButtonClick

▸ `Protected` **addButtonClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L256)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[addCssClass](FilterWidgetBase.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addEmptyRow

▸ `Protected` **addEmptyRow**(`popupField`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `popupField` | `boolean` |

#### Returns

`JQuery`

#### Defined in

[src/ui/filtering/filterpanel.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L298)

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

[FilterWidgetBase](FilterWidgetBase.md).[addValidationRule](FilterWidgetBase.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### andOrClick

▸ `Protected` **andOrClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:501](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L501)

___

### byId

▸ `Protected` **byId**(`id`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`JQuery`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[byId](FilterWidgetBase.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L10)

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

[FilterWidgetBase](FilterWidgetBase.md).[change](FilterWidgetBase.md#change)

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

[FilterWidgetBase](FilterWidgetBase.md).[change](FilterWidgetBase.md#change)

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

[FilterWidgetBase](FilterWidgetBase.md).[changeSelect2](FilterWidgetBase.md#changeselect2)

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

[FilterWidgetBase](FilterWidgetBase.md).[changeSelect2](FilterWidgetBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### deleteRowClick

▸ `Protected` **deleteRowClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L481)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[destroy](FilterWidgetBase.md#destroy)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L19)

___

### filterStoreChanged

▸ `Protected` **filterStoreChanged**(): `void`

#### Returns

`void`

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[filterStoreChanged](FilterWidgetBase.md#filterstorechanged)

#### Defined in

[src/ui/filtering/filterpanel.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L91)

___

### findEmptyRow

▸ `Protected` **findEmptyRow**(): `JQuery`

#### Returns

`JQuery`

#### Defined in

[src/ui/filtering/filterpanel.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L278)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getCssClass](FilterWidgetBase.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getFallbackTemplate](FilterWidgetBase.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L79)

___

### getFieldFor

▸ `Protected` **getFieldFor**(`row`): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `JQuery` |

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Defined in

[src/ui/filtering/filterpanel.ts:403](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L403)

___

### getFilteringFor

▸ `Protected` **getFilteringFor**(`row`): [`IFiltering`](IFiltering.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `JQuery` |

#### Returns

[`IFiltering`](IFiltering.md)

#### Defined in

[src/ui/filtering/filterpanel.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L417)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getGridField](FilterWidgetBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[getTemplate](FilterWidgetBase.md#gettemplate)

#### Defined in

[src/ui/filtering/filterpanel.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L162)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getTemplateName](FilterWidgetBase.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L31)

___

### get\_hasErrors

▸ **get_hasErrors**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L190)

___

### get\_showInitialLine

▸ **get_showInitialLine**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L78)

___

### get\_showSearchButton

▸ **get_showSearchButton**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L139)

___

### get\_store

▸ **get_store**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[get_store](FilterWidgetBase.md#get_store)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L33)

___

### get\_updateStoreOnReset

▸ **get_updateStoreOnReset**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filterpanel.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L152)

___

### init

▸ **init**(`action?`): [`FilterPanel`](FilterPanel.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`FilterPanel`](FilterPanel.md)

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[init](FilterWidgetBase.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initButtons

▸ `Protected` **initButtons**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L174)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[initialize](FilterWidgetBase.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### leftRightParenClick

▸ `Protected` **leftRightParenClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L508)

___

### onRowFieldChange

▸ `Protected` **onRowFieldChange**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L363)

___

### onRowOperatorChange

▸ `Protected` **onRowOperatorChange**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:440](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L440)

___

### populateOperatorList

▸ `Protected` **populateOperatorList**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L388)

___

### removeFiltering

▸ `Protected` **removeFiltering**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L383)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[renderContents](FilterWidgetBase.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L110)

___

### resetButtonClick

▸ `Protected` **resetButtonClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L261)

___

### rowFieldChange

▸ `Protected` **rowFieldChange**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:370](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L370)

___

### rowOperatorChange

▸ `Protected` **rowOperatorChange**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:451](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L451)

___

### search

▸ **search**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L195)

___

### searchButtonClick

▸ `Protected` **searchButtonClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L185)

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

[src/ui/filtering/filterpanel.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L82)

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

[src/ui/filtering/filterpanel.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L143)

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

[src/ui/filtering/filterwidgetbase.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L37)

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

[src/ui/filtering/filterpanel.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L156)

___

### updateButtons

▸ `Protected` **updateButtons**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:494](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L494)

___

### updateParens

▸ `Protected` **updateParens**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L514)

___

### updateRowsFromStore

▸ **updateRowsFromStore**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterpanel.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.ts#L96)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[useIdPrefix](FilterWidgetBase.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L131)

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

[FilterWidgetBase](FilterWidgetBase.md).[create](FilterWidgetBase.md#create)

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

[FilterWidgetBase](FilterWidgetBase.md).[elementFor](FilterWidgetBase.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

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

[FilterWidgetBase](FilterWidgetBase.md).[getWidgetName](FilterWidgetBase.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
