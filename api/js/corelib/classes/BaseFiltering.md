[@serenity-is/corelib](../README.md) / BaseFiltering

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

• **new BaseFiltering**(): [`BaseFiltering`](BaseFiltering.md)

#### Returns

[`BaseFiltering`](BaseFiltering.md)

## Properties

### container

• `Private` **container**: `HTMLElement`

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L63)

___

### field

• `Private` **field**: [`PropertyItem`](../interfaces/PropertyItem.md)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L53)

___

### operator

• `Private` **operator**: [`FilterOperator`](../interfaces/FilterOperator.md)

#### Defined in

[src/ui/filtering/filtering.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L73)

## Methods

### appendComparisonOperators

▸ **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Defined in

[src/ui/filtering/filtering.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L94)

___

### appendNullableOperators

▸ **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Defined in

[src/ui/filtering/filtering.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L85)

___

### argumentNull

▸ **argumentNull**(): `Error`

#### Returns

`Error`

#### Defined in

[src/ui/filtering/filtering.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L240)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Implementation of

[IFiltering](IFiltering.md).[createEditor](IFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L108)

___

### displayText

▸ **displayText**(`op`, `values?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/FilterOperator.md) |
| `values?` | `any`[] |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L141)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Implementation of

[IFiltering](IFiltering.md).[getCriteria](IFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L157)

___

### getCriteriaField

▸ **getCriteriaField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L153)

___

### getEditorText

▸ **getEditorText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L273)

___

### getEditorValue

▸ **getEditorValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L251)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Implementation of

[IFiltering](IFiltering.md).[getOperators](IFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

___

### getTitle

▸ **getTitle**(`field`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L137)

___

### get\_container

▸ **get_container**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Implementation of

[IFiltering](IFiltering.md).[get_container](IFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L65)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Implementation of

[IFiltering](IFiltering.md).[get_field](IFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L55)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Implementation of

[IFiltering](IFiltering.md).[get_operator](IFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L75)

___

### initQuickFilter

▸ **initQuickFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\> |

#### Returns

`void`

#### Implementation of

[IQuickFiltering](IQuickFiltering.md).[initQuickFilter](IQuickFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:290](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L290)

___

### isNullable

▸ **isNullable**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L104)

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

[src/ui/filtering/filtering.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L218)

___

### operatorFormat

▸ **operatorFormat**(`op`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/FilterOperator.md) |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L133)

___

### saveState

▸ **saveState**(): `string`

#### Returns

`string`

#### Implementation of

[IFiltering](IFiltering.md).[saveState](IFiltering.md#savestate)

#### Defined in

[src/ui/filtering/filtering.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L223)

___

### set\_container

▸ **set_container**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `HTMLElement` |

#### Returns

`void`

#### Implementation of

[IFiltering](IFiltering.md).[set_container](IFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L69)

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

[src/ui/filtering/filtering.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L59)

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

[src/ui/filtering/filtering.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L79)

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

[src/ui/filtering/filtering.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L244)
