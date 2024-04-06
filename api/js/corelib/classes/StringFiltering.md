[@serenity-is/corelib](../README.md) / StringFiltering

# Class: StringFiltering

## Hierarchy

- [`BaseFiltering`](BaseFiltering.md)

  ↳ **`StringFiltering`**

## Table of contents

### Constructors

- [constructor](StringFiltering.md#constructor)

### Methods

- [appendComparisonOperators](StringFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](StringFiltering.md#appendnullableoperators)
- [argumentNull](StringFiltering.md#argumentnull)
- [createEditor](StringFiltering.md#createeditor)
- [displayText](StringFiltering.md#displaytext)
- [getCriteria](StringFiltering.md#getcriteria)
- [getCriteriaField](StringFiltering.md#getcriteriafield)
- [getEditorText](StringFiltering.md#geteditortext)
- [getEditorValue](StringFiltering.md#geteditorvalue)
- [getOperators](StringFiltering.md#getoperators)
- [getTitle](StringFiltering.md#gettitle)
- [get\_container](StringFiltering.md#get_container)
- [get\_field](StringFiltering.md#get_field)
- [get\_operator](StringFiltering.md#get_operator)
- [initQuickFilter](StringFiltering.md#initquickfilter)
- [isNullable](StringFiltering.md#isnullable)
- [loadState](StringFiltering.md#loadstate)
- [operatorFormat](StringFiltering.md#operatorformat)
- [saveState](StringFiltering.md#savestate)
- [set\_container](StringFiltering.md#set_container)
- [set\_field](StringFiltering.md#set_field)
- [set\_operator](StringFiltering.md#set_operator)
- [validateEditorValue](StringFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new StringFiltering**(): [`StringFiltering`](StringFiltering.md)

#### Returns

[`StringFiltering`](StringFiltering.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[constructor](BaseFiltering.md#constructor)

## Methods

### appendComparisonOperators

▸ **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[BaseFiltering](BaseFiltering.md).[appendComparisonOperators](BaseFiltering.md#appendcomparisonoperators)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[appendNullableOperators](BaseFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L85)

___

### argumentNull

▸ **argumentNull**(): `Error`

#### Returns

`Error`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[argumentNull](BaseFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L240)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[createEditor](BaseFiltering.md#createeditor)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[displayText](BaseFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L141)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getCriteria](BaseFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L157)

___

### getCriteriaField

▸ **getCriteriaField**(): `string`

#### Returns

`string`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getCriteriaField](BaseFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L153)

___

### getEditorText

▸ **getEditorText**(): `string`

#### Returns

`string`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getEditorText](BaseFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L273)

___

### getEditorValue

▸ **getEditorValue**(): `string`

#### Returns

`string`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getEditorValue](BaseFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L251)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Overrides

[BaseFiltering](BaseFiltering.md).[getOperators](BaseFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L672)

___

### getTitle

▸ **getTitle**(`field`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`string`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getTitle](BaseFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L137)

___

### get\_container

▸ **get_container**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_container](BaseFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L65)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_field](BaseFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L55)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_operator](BaseFiltering.md#get_operator)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[initQuickFilter](BaseFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:290](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L290)

___

### isNullable

▸ **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[isNullable](BaseFiltering.md#isnullable)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[loadState](BaseFiltering.md#loadstate)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[operatorFormat](BaseFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L133)

___

### saveState

▸ **saveState**(): `string`

#### Returns

`string`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[saveState](BaseFiltering.md#savestate)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[set_container](BaseFiltering.md#set_container)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[set_field](BaseFiltering.md#set_field)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[set_operator](BaseFiltering.md#set_operator)

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

#### Overrides

[BaseFiltering](BaseFiltering.md).[validateEditorValue](BaseFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:682](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L682)
