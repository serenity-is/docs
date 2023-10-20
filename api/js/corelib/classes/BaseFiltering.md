[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / BaseFiltering

# Class: BaseFiltering

## Hierarchy

- **`BaseFiltering`**

  ↳ [`BaseEditorFiltering`](BaseEditorFiltering.md)

  ↳ [`BooleanFiltering`](BooleanFiltering.md)

  ↳ [`StringFiltering`](StringFiltering.md)

## Implements

- [`IFiltering`](IFiltering.md)
- [`IQuickFiltering`](IQuickFiltering.md)

## Table of contents

### Constructors

- [constructor](BaseFiltering.md#constructor)

### Properties

- [container](BaseFiltering.md#container)
- [field](BaseFiltering.md#field)
- [operator](BaseFiltering.md#operator)

### Methods

- [appendComparisonOperators](BaseFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](BaseFiltering.md#appendnullableoperators)
- [argumentNull](BaseFiltering.md#argumentnull)
- [createEditor](BaseFiltering.md#createeditor)
- [displayText](BaseFiltering.md#displaytext)
- [getCriteria](BaseFiltering.md#getcriteria)
- [getCriteriaField](BaseFiltering.md#getcriteriafield)
- [getEditorText](BaseFiltering.md#geteditortext)
- [getEditorValue](BaseFiltering.md#geteditorvalue)
- [getOperators](BaseFiltering.md#getoperators)
- [getTitle](BaseFiltering.md#gettitle)
- [get\_container](BaseFiltering.md#get_container)
- [get\_field](BaseFiltering.md#get_field)
- [get\_operator](BaseFiltering.md#get_operator)
- [initQuickFilter](BaseFiltering.md#initquickfilter)
- [isNullable](BaseFiltering.md#isnullable)
- [loadState](BaseFiltering.md#loadstate)
- [operatorFormat](BaseFiltering.md#operatorformat)
- [saveState](BaseFiltering.md#savestate)
- [set\_container](BaseFiltering.md#set_container)
- [set\_field](BaseFiltering.md#set_field)
- [set\_operator](BaseFiltering.md#set_operator)
- [validateEditorValue](BaseFiltering.md#validateeditorvalue)

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

• `Private` **field**: [`PropertyItem`](../interfaces/PropertyItem.md)

#### Defined in

[src/ui/filtering/filtering.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L51)

___

### operator

• `Private` **operator**: [`FilterOperator`](../interfaces/FilterOperator.md)

#### Defined in

[src/ui/filtering/filtering.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L71)

## Methods

### appendComparisonOperators

▸ `Protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Defined in

[src/ui/filtering/filtering.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L92)

___

### appendNullableOperators

▸ `Protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

___

### argumentNull

▸ `Protected` **argumentNull**(): `Error`

#### Returns

`Error`

#### Defined in

[src/ui/filtering/filtering.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L238)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Implementation of

[IFiltering](IFiltering.md).[createEditor](IFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L106)

___

### displayText

▸ `Protected` **displayText**(`op`, `values?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/FilterOperator.md) |
| `values?` | `any`[] |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L139)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Implementation of

[IFiltering](IFiltering.md).[getCriteria](IFiltering.md#getcriteria)

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

▸ `Abstract` **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Implementation of

[IFiltering](IFiltering.md).[getOperators](IFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L81)

___

### getTitle

▸ `Protected` **getTitle**(`field`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | [`PropertyItem`](../interfaces/PropertyItem.md) |

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

[IFiltering](IFiltering.md).[get_container](IFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L63)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Implementation of

[IFiltering](IFiltering.md).[get_field](IFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L53)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Implementation of

[IFiltering](IFiltering.md).[get_operator](IFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L73)

___

### initQuickFilter

▸ **initQuickFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`QuickFilter`](../interfaces/QuickFilter.md)<[`Widget`](Widget.md)<`any`\>, `any`\> |

#### Returns

`void`

#### Implementation of

[IQuickFiltering](IQuickFiltering.md).[initQuickFilter](IQuickFiltering.md#initquickfilter)

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

[IFiltering](IFiltering.md).[loadState](IFiltering.md#loadstate)

#### Defined in

[src/ui/filtering/filtering.ts:216](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L216)

___

### operatorFormat

▸ `Protected` **operatorFormat**(`op`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/FilterOperator.md) |

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

[IFiltering](IFiltering.md).[saveState](IFiltering.md#savestate)

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

[IFiltering](IFiltering.md).[set_container](IFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L67)

___

### set\_field

▸ **set_field**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`void`

#### Implementation of

[IFiltering](IFiltering.md).[set_field](IFiltering.md#set_field)

#### Defined in

[src/ui/filtering/filtering.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L57)

___

### set\_operator

▸ **set_operator**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterOperator`](../interfaces/FilterOperator.md) |

#### Returns

`void`

#### Implementation of

[IFiltering](IFiltering.md).[set_operator](IFiltering.md#set_operator)

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
