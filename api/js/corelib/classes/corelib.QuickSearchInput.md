[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / QuickSearchInput

# Class: QuickSearchInput

[corelib](../modules/corelib.md).QuickSearchInput

## Hierarchy

- [`Widget`](corelib.Widget.md)<[`QuickSearchInputOptions`](../interfaces/corelib.QuickSearchInputOptions.md)\>

  ↳ **`QuickSearchInput`**

## Table of contents

### Constructors

- [constructor](corelib.QuickSearchInput.md#constructor)

### Properties

- [element](corelib.QuickSearchInput.md#element)
- [field](corelib.QuickSearchInput.md#field)
- [fieldChanged](corelib.QuickSearchInput.md#fieldchanged)
- [idPrefix](corelib.QuickSearchInput.md#idprefix)
- [lastValue](corelib.QuickSearchInput.md#lastvalue)
- [options](corelib.QuickSearchInput.md#options)
- [timer](corelib.QuickSearchInput.md#timer)
- [uniqueName](corelib.QuickSearchInput.md#uniquename)
- [widgetName](corelib.QuickSearchInput.md#widgetname)

### Methods

- [addCssClass](corelib.QuickSearchInput.md#addcssclass)
- [addValidationRule](corelib.QuickSearchInput.md#addvalidationrule)
- [change](corelib.QuickSearchInput.md#change)
- [changeSelect2](corelib.QuickSearchInput.md#changeselect2)
- [checkIfValueChanged](corelib.QuickSearchInput.md#checkifvaluechanged)
- [destroy](corelib.QuickSearchInput.md#destroy)
- [getCssClass](corelib.QuickSearchInput.md#getcssclass)
- [getGridField](corelib.QuickSearchInput.md#getgridfield)
- [get\_field](corelib.QuickSearchInput.md#get_field)
- [get\_value](corelib.QuickSearchInput.md#get_value)
- [init](corelib.QuickSearchInput.md#init)
- [initialize](corelib.QuickSearchInput.md#initialize)
- [renderContents](corelib.QuickSearchInput.md#rendercontents)
- [restoreState](corelib.QuickSearchInput.md#restorestate)
- [searchNow](corelib.QuickSearchInput.md#searchnow)
- [set\_field](corelib.QuickSearchInput.md#set_field)
- [updateInputPlaceHolder](corelib.QuickSearchInput.md#updateinputplaceholder)
- [create](corelib.QuickSearchInput.md#create)
- [elementFor](corelib.QuickSearchInput.md#elementfor)
- [getWidgetName](corelib.QuickSearchInput.md#getwidgetname)

## Constructors

### constructor

• **new QuickSearchInput**(`input`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |
| `opt` | [`QuickSearchInputOptions`](../interfaces/corelib.QuickSearchInputOptions.md) |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L26)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[element](corelib.Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### field

• `Private` **field**: [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L22)

___

### fieldChanged

• `Private` **fieldChanged**: `boolean`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L23)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[idPrefix](corelib.Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### lastValue

• `Private` **lastValue**: `string`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L21)

___

### options

• `Protected` **options**: [`QuickSearchInputOptions`](../interfaces/corelib.QuickSearchInputOptions.md)

#### Inherited from

[Widget](corelib.Widget.md).[options](corelib.Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### timer

• `Private` **timer**: `number`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L24)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[uniqueName](corelib.Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[widgetName](corelib.Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[addCssClass](corelib.Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

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

[Widget](corelib.Widget.md).[addValidationRule](corelib.Widget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

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

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

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

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

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

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

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

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### checkIfValueChanged

▸ `Protected` **checkIfValueChanged**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L84)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](corelib.Widget.md).[getCssClass](corelib.Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[getGridField](corelib.Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### get\_field

▸ **get_field**(): [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)

#### Returns

[`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L113)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L109)

___

### init

▸ **init**(`action?`): [`QuickSearchInput`](corelib.QuickSearchInput.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`QuickSearchInput`](corelib.QuickSearchInput.md)

#### Inherited from

[Widget](corelib.Widget.md).[init](corelib.Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[initialize](corelib.Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[renderContents](corelib.Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### restoreState

▸ **restoreState**(`value`, `field`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |
| `field` | [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L136)

___

### searchNow

▸ `Protected` **searchNow**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L149)

___

### set\_field

▸ **set_field**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L117)

___

### updateInputPlaceHolder

▸ `Protected` **updateInputPlaceHolder**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L126)

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

[Widget](corelib.Widget.md).[create](corelib.Widget.md#create)

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

[Widget](corelib.Widget.md).[elementFor](corelib.Widget.md#elementfor)

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

[Widget](corelib.Widget.md).[getWidgetName](corelib.Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
