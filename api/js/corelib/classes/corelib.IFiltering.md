[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / IFiltering

# Class: IFiltering

[corelib](../modules/corelib.md).IFiltering

## Implemented by

- [`BaseFiltering`](corelib.BaseFiltering.md)

## Table of contents

### Constructors

- [constructor](corelib.IFiltering.md#constructor)

### Methods

- [createEditor](corelib.IFiltering.md#createeditor)
- [getCriteria](corelib.IFiltering.md#getcriteria)
- [getOperators](corelib.IFiltering.md#getoperators)
- [get\_container](corelib.IFiltering.md#get_container)
- [get\_field](corelib.IFiltering.md#get_field)
- [get\_operator](corelib.IFiltering.md#get_operator)
- [loadState](corelib.IFiltering.md#loadstate)
- [saveState](corelib.IFiltering.md#savestate)
- [set\_container](corelib.IFiltering.md#set_container)
- [set\_field](corelib.IFiltering.md#set_field)
- [set\_operator](corelib.IFiltering.md#set_operator)

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

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Defined in

[src/ui/filtering/filtering.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L19)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

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

▸ **get_field**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Defined in

[src/ui/filtering/filtering.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L23)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)

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
| `value` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

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
| `value` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md) |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filtering.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L28)
