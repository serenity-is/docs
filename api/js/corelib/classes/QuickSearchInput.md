[@serenity-is/corelib](../README.md) / QuickSearchInput

# Class: QuickSearchInput

## Hierarchy

- [`Widget`](Widget.md)<[`QuickSearchInputOptions`](../interfaces/QuickSearchInputOptions.md)\>

  ↳ **`QuickSearchInput`**

## Table of contents

### Constructors

- [constructor](QuickSearchInput.md#constructor)

### Properties

- [element](QuickSearchInput.md#element)
- [field](QuickSearchInput.md#field)
- [fieldChanged](QuickSearchInput.md#fieldchanged)
- [idPrefix](QuickSearchInput.md#idprefix)
- [lastValue](QuickSearchInput.md#lastvalue)
- [options](QuickSearchInput.md#options)
- [timer](QuickSearchInput.md#timer)
- [uniqueName](QuickSearchInput.md#uniquename)
- [widgetName](QuickSearchInput.md#widgetname)

### Methods

- [addCssClass](QuickSearchInput.md#addcssclass)
- [addValidationRule](QuickSearchInput.md#addvalidationrule)
- [change](QuickSearchInput.md#change)
- [changeSelect2](QuickSearchInput.md#changeselect2)
- [checkIfValueChanged](QuickSearchInput.md#checkifvaluechanged)
- [destroy](QuickSearchInput.md#destroy)
- [getCssClass](QuickSearchInput.md#getcssclass)
- [getGridField](QuickSearchInput.md#getgridfield)
- [get\_field](QuickSearchInput.md#get_field)
- [get\_value](QuickSearchInput.md#get_value)
- [init](QuickSearchInput.md#init)
- [initialize](QuickSearchInput.md#initialize)
- [renderContents](QuickSearchInput.md#rendercontents)
- [restoreState](QuickSearchInput.md#restorestate)
- [searchNow](QuickSearchInput.md#searchnow)
- [set\_field](QuickSearchInput.md#set_field)
- [updateInputPlaceHolder](QuickSearchInput.md#updateinputplaceholder)
- [create](QuickSearchInput.md#create)
- [elementFor](QuickSearchInput.md#elementfor)
- [getWidgetName](QuickSearchInput.md#getwidgetname)

## Constructors

### constructor

• **new QuickSearchInput**(`input`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |
| `opt` | [`QuickSearchInputOptions`](../interfaces/QuickSearchInputOptions.md) |

#### Overrides

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L26)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](Widget.md).[element](Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### field

• `Private` **field**: [`QuickSearchField`](../interfaces/QuickSearchField.md)

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

[Widget](Widget.md).[idPrefix](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### lastValue

• `Private` **lastValue**: `string`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L21)

___

### options

• `Protected` **options**: [`QuickSearchInputOptions`](../interfaces/QuickSearchInputOptions.md)

#### Inherited from

[Widget](Widget.md).[options](Widget.md#options)

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

[Widget](Widget.md).[uniqueName](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](Widget.md).[widgetName](Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addCssClass](Widget.md#addcssclass)

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

[Widget](Widget.md).[addValidationRule](Widget.md#addvalidationrule)

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

[Widget](Widget.md).[change](Widget.md#change)

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

[Widget](Widget.md).[change](Widget.md#change)

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

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

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

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

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

[Widget](Widget.md).[destroy](Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](Widget.md).[getCssClass](Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](Widget.md).[getGridField](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### get\_field

▸ **get_field**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)

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

▸ **init**(`action?`): [`QuickSearchInput`](QuickSearchInput.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`QuickSearchInput`](QuickSearchInput.md)

#### Inherited from

[Widget](Widget.md).[init](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[initialize](Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[renderContents](Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### restoreState

▸ **restoreState**(`value`, `field`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |
| `field` | [`QuickSearchField`](../interfaces/QuickSearchField.md) |

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
| `value` | [`QuickSearchField`](../interfaces/QuickSearchField.md) |

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
| `TWidget` | extends [`Widget`](Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[Widget](Widget.md).[create](Widget.md#create)

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

[Widget](Widget.md).[elementFor](Widget.md#elementfor)

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

[Widget](Widget.md).[getWidgetName](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
