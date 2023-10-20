[@serenity-is/corelib](../README.md) / BooleanFiltering

# Class: BooleanFiltering

## Hierarchy

- [`BaseFiltering`](BaseFiltering.md)

  ↳ **`BooleanFiltering`**

## Table of contents

### Constructors

- [constructor](BooleanFiltering.md#constructor)

### Methods

- [appendComparisonOperators](BooleanFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](BooleanFiltering.md#appendnullableoperators)
- [argumentNull](BooleanFiltering.md#argumentnull)
- [createEditor](BooleanFiltering.md#createeditor)
- [displayText](BooleanFiltering.md#displaytext)
- [getCriteria](BooleanFiltering.md#getcriteria)
- [getCriteriaField](BooleanFiltering.md#getcriteriafield)
- [getEditorText](BooleanFiltering.md#geteditortext)
- [getEditorValue](BooleanFiltering.md#geteditorvalue)
- [getOperators](BooleanFiltering.md#getoperators)
- [getTitle](BooleanFiltering.md#gettitle)
- [get\_container](BooleanFiltering.md#get_container)
- [get\_field](BooleanFiltering.md#get_field)
- [get\_operator](BooleanFiltering.md#get_operator)
- [initQuickFilter](BooleanFiltering.md#initquickfilter)
- [isNullable](BooleanFiltering.md#isnullable)
- [loadState](BooleanFiltering.md#loadstate)
- [operatorFormat](BooleanFiltering.md#operatorformat)
- [saveState](BooleanFiltering.md#savestate)
- [set\_container](BooleanFiltering.md#set_container)
- [set\_field](BooleanFiltering.md#set_field)
- [set\_operator](BooleanFiltering.md#set_operator)
- [validateEditorValue](BooleanFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new BooleanFiltering**()

#### Inherited from

[BaseFiltering](BaseFiltering.md).[constructor](BaseFiltering.md#constructor)

## Methods

### appendComparisonOperators

▸ `Protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[BaseFiltering](BaseFiltering.md).[appendComparisonOperators](BaseFiltering.md#appendcomparisonoperators)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[appendNullableOperators](BaseFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

___

### argumentNull

▸ `Protected` **argumentNull**(): `Error`

#### Returns

`Error`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[argumentNull](BaseFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L238)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[createEditor](BaseFiltering.md#createeditor)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[displayText](BaseFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L139)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getCriteria](BaseFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L155)

___

### getCriteriaField

▸ `Protected` **getCriteriaField**(): `string`

#### Returns

`string`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getCriteriaField](BaseFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L151)

___

### getEditorText

▸ **getEditorText**(): `any`

#### Returns

`any`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getEditorText](BaseFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L269)

___

### getEditorValue

▸ **getEditorValue**(): `string`

#### Returns

`string`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getEditorValue](BaseFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L249)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Overrides

[BaseFiltering](BaseFiltering.md).[getOperators](BaseFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:408](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L408)

___

### getTitle

▸ `Protected` **getTitle**(`field`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`string`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getTitle](BaseFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L135)

___

### get\_container

▸ **get_container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_container](BaseFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L63)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_field](BaseFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L53)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_operator](BaseFiltering.md#get_operator)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[initQuickFilter](BaseFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L284)

___

### isNullable

▸ `Protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[isNullable](BaseFiltering.md#isnullable)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[loadState](BaseFiltering.md#loadstate)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[operatorFormat](BaseFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L131)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[saveState](BaseFiltering.md#savestate)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[set_container](BaseFiltering.md#set_container)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[set_field](BaseFiltering.md#set_field)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[set_operator](BaseFiltering.md#set_operator)

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

#### Inherited from

[BaseFiltering](BaseFiltering.md).[validateEditorValue](BaseFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L242)
