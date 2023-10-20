[@serenity-is/corelib](../README.md) / IFiltering

# Class: IFiltering

## Implemented by

- [`BaseFiltering`](BaseFiltering.md)

## Table of contents

### Constructors

- [constructor](IFiltering.md#constructor)

### Methods

- [createEditor](IFiltering.md#createeditor)
- [getCriteria](IFiltering.md#getcriteria)
- [getOperators](IFiltering.md#getoperators)
- [get\_container](IFiltering.md#get_container)
- [get\_field](IFiltering.md#get_field)
- [get\_operator](IFiltering.md#get_operator)
- [loadState](IFiltering.md#loadstate)
- [saveState](IFiltering.md#savestate)
- [set\_container](IFiltering.md#set_container)
- [set\_field](IFiltering.md#set_field)
- [set\_operator](IFiltering.md#set_operator)

## Constructors

### constructor

• **new IFiltering**()

## Methods

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filtering.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L18)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Defined in

[src/ui/filtering/filtering.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L19)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Defined in

[src/ui/filtering/filtering.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L20)

___

### get\_container

▸ **get_container**(): `JQuery`

#### Returns

`JQuery`

#### Defined in

[src/ui/filtering/filtering.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L25)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Defined in

[src/ui/filtering/filtering.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L23)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Defined in

[src/ui/filtering/filtering.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L27)

___

### loadState

▸ **loadState**(`state`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `state` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filtering.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L21)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/filtering/filtering.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L22)

___

### set\_container

▸ **set_container**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filtering.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L26)

___

### set\_field

▸ **set_field**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filtering.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L24)

___

### set\_operator

▸ **set_operator**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterOperator`](../interfaces/FilterOperator.md) |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filtering.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L28)
