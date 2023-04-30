[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / BaseFiltering

# Class: BaseFiltering

[corelib](../modules/corelib.md).BaseFiltering

## Hierarchy

- **`BaseFiltering`**

  ↳ [`BaseEditorFiltering`](corelib.BaseEditorFiltering.md)

  ↳ [`BooleanFiltering`](corelib.BooleanFiltering.md)

  ↳ [`StringFiltering`](corelib.StringFiltering.md)

## Implements

- [`IFiltering`](corelib.IFiltering.md)
- [`IQuickFiltering`](corelib.IQuickFiltering.md)

## Table of contents

### Constructors

- [constructor](corelib.BaseFiltering.md#constructor)

### Properties

- [container](corelib.BaseFiltering.md#container)
- [field](corelib.BaseFiltering.md#field)
- [operator](corelib.BaseFiltering.md#operator)

### Methods

- [appendComparisonOperators](corelib.BaseFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](corelib.BaseFiltering.md#appendnullableoperators)
- [argumentNull](corelib.BaseFiltering.md#argumentnull)
- [createEditor](corelib.BaseFiltering.md#createeditor)
- [displayText](corelib.BaseFiltering.md#displaytext)
- [getCriteria](corelib.BaseFiltering.md#getcriteria)
- [getCriteriaField](corelib.BaseFiltering.md#getcriteriafield)
- [getEditorText](corelib.BaseFiltering.md#geteditortext)
- [getEditorValue](corelib.BaseFiltering.md#geteditorvalue)
- [getOperators](corelib.BaseFiltering.md#getoperators)
- [getTitle](corelib.BaseFiltering.md#gettitle)
- [get\_container](corelib.BaseFiltering.md#get_container)
- [get\_field](corelib.BaseFiltering.md#get_field)
- [get\_operator](corelib.BaseFiltering.md#get_operator)
- [initQuickFilter](corelib.BaseFiltering.md#initquickfilter)
- [isNullable](corelib.BaseFiltering.md#isnullable)
- [loadState](corelib.BaseFiltering.md#loadstate)
- [operatorFormat](corelib.BaseFiltering.md#operatorformat)
- [saveState](corelib.BaseFiltering.md#savestate)
- [set\_container](corelib.BaseFiltering.md#set_container)
- [set\_field](corelib.BaseFiltering.md#set_field)
- [set\_operator](corelib.BaseFiltering.md#set_operator)
- [validateEditorValue](corelib.BaseFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new BaseFiltering**()

## Properties

### container

• `Private` **container**: `JQuery`

#### Defined in

[src/ui/filtering/filtering.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L61)

___

### field

• `Private` **field**: [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Defined in

[src/ui/filtering/filtering.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L51)

___

### operator

• `Private` **operator**: [`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Defined in

[src/ui/filtering/filtering.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L71)

## Methods

### appendComparisonOperators

▸ `Protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Defined in

[src/ui/filtering/filtering.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L92)

___

### appendNullableOperators

▸ `Protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

___

### argumentNull

▸ `Protected` **argumentNull**(): [`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Returns

[`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Defined in

[src/ui/filtering/filtering.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L238)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Implementation of

[IFiltering](corelib.IFiltering.md).[createEditor](corelib.IFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L106)

___

### displayText

▸ `Protected` **displayText**(`op`, `values?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md) |
| `values?` | `any`[] |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L139)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Implementation of

[IFiltering](corelib.IFiltering.md).[getCriteria](corelib.IFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L155)

___

### getCriteriaField

▸ `Protected` **getCriteriaField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L151)

___

### getEditorText

▸ **getEditorText**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/filtering/filtering.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L269)

___

### getEditorValue

▸ **getEditorValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L249)

___

### getOperators

▸ `Abstract` **getOperators**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Implementation of

[IFiltering](corelib.IFiltering.md).[getOperators](corelib.IFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L81)

___

### getTitle

▸ `Protected` **getTitle**(`field`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L135)

___

### get\_container

▸ **get_container**(): `JQuery`

#### Returns

`JQuery`

#### Implementation of

[IFiltering](corelib.IFiltering.md).[get_container](corelib.IFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L63)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Implementation of

[IFiltering](corelib.IFiltering.md).[get_field](corelib.IFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L53)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Implementation of

[IFiltering](corelib.IFiltering.md).[get_operator](corelib.IFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L73)

___

### initQuickFilter

▸ **initQuickFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\> |

#### Returns

`void`

#### Implementation of

[IQuickFiltering](corelib.IQuickFiltering.md).[initQuickFilter](corelib.IQuickFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L284)

___

### isNullable

▸ `Protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L102)

___

### loadState

▸ **loadState**(`state`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `state` | `any` |

#### Returns

`void`

#### Implementation of

[IFiltering](corelib.IFiltering.md).[loadState](corelib.IFiltering.md#loadstate)

#### Defined in

[src/ui/filtering/filtering.ts:216](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L216)

___

### operatorFormat

▸ `Protected` **operatorFormat**(`op`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md) |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L131)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Implementation of

[IFiltering](corelib.IFiltering.md).[saveState](corelib.IFiltering.md#savestate)

#### Defined in

[src/ui/filtering/filtering.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L221)

___

### set\_container

▸ **set_container**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `JQuery` |

#### Returns

`void`

#### Implementation of

[IFiltering](corelib.IFiltering.md).[set_container](corelib.IFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L67)

___

### set\_field

▸ **set_field**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`void`

#### Implementation of

[IFiltering](corelib.IFiltering.md).[set_field](corelib.IFiltering.md#set_field)

#### Defined in

[src/ui/filtering/filtering.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L57)

___

### set\_operator

▸ **set_operator**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md) |

#### Returns

`void`

#### Implementation of

[IFiltering](corelib.IFiltering.md).[set_operator](corelib.IFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L77)

___

### validateEditorValue

▸ **validateEditorValue**(`value`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L242)
