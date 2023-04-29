[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / BooleanFiltering

# Class: BooleanFiltering

[corelib](../modules/corelib.md).BooleanFiltering

## Hierarchy

- [`BaseFiltering`](corelib.BaseFiltering.md)

  ↳ **`BooleanFiltering`**

## Table of contents

### Constructors

- [constructor](corelib.BooleanFiltering.md#constructor)

### Methods

- [appendComparisonOperators](corelib.BooleanFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](corelib.BooleanFiltering.md#appendnullableoperators)
- [argumentNull](corelib.BooleanFiltering.md#argumentnull)
- [createEditor](corelib.BooleanFiltering.md#createeditor)
- [displayText](corelib.BooleanFiltering.md#displaytext)
- [getCriteria](corelib.BooleanFiltering.md#getcriteria)
- [getCriteriaField](corelib.BooleanFiltering.md#getcriteriafield)
- [getEditorText](corelib.BooleanFiltering.md#geteditortext)
- [getEditorValue](corelib.BooleanFiltering.md#geteditorvalue)
- [getOperators](corelib.BooleanFiltering.md#getoperators)
- [getTitle](corelib.BooleanFiltering.md#gettitle)
- [get\_container](corelib.BooleanFiltering.md#get_container)
- [get\_field](corelib.BooleanFiltering.md#get_field)
- [get\_operator](corelib.BooleanFiltering.md#get_operator)
- [initQuickFilter](corelib.BooleanFiltering.md#initquickfilter)
- [isNullable](corelib.BooleanFiltering.md#isnullable)
- [loadState](corelib.BooleanFiltering.md#loadstate)
- [operatorFormat](corelib.BooleanFiltering.md#operatorformat)
- [saveState](corelib.BooleanFiltering.md#savestate)
- [set\_container](corelib.BooleanFiltering.md#set_container)
- [set\_field](corelib.BooleanFiltering.md#set_field)
- [set\_operator](corelib.BooleanFiltering.md#set_operator)
- [validateEditorValue](corelib.BooleanFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new BooleanFiltering**()

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[constructor](corelib.BaseFiltering.md#constructor)

## Methods

### appendComparisonOperators

▸ `Protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[appendComparisonOperators](corelib.BaseFiltering.md#appendcomparisonoperators)

#### Defined in

[src/ui/filtering/filtering.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;92)

___

### appendNullableOperators

▸ `Protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[appendNullableOperators](corelib.BaseFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;83)

___

### argumentNull

▸ `Protected` **argumentNull**(): [`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Returns

[`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[argumentNull](corelib.BaseFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;238)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[createEditor](corelib.BaseFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;106)

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

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[displayText](corelib.BaseFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;139)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[getCriteria](corelib.BaseFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;155)

___

### getCriteriaField

▸ `Protected` **getCriteriaField**(): `string`

#### Returns

`string`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[getCriteriaField](corelib.BaseFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;151)

___

### getEditorText

▸ **getEditorText**(): `any`

#### Returns

`any`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[getEditorText](corelib.BaseFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;269)

___

### getEditorValue

▸ **getEditorValue**(): `string`

#### Returns

`string`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[getEditorValue](corelib.BaseFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;249)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Overrides

[BaseFiltering](corelib.BaseFiltering.md).[getOperators](corelib.BaseFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:408](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;408)

___

### getTitle

▸ `Protected` **getTitle**(`field`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`string`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[getTitle](corelib.BaseFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;135)

___

### get\_container

▸ **get_container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[get_container](corelib.BaseFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;63)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[get_field](corelib.BaseFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;53)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[get_operator](corelib.BaseFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;73)

___

### initQuickFilter

▸ **initQuickFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\> |

#### Returns

`void`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[initQuickFilter](corelib.BaseFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;284)

___

### isNullable

▸ `Protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[isNullable](corelib.BaseFiltering.md#isnullable)

#### Defined in

[src/ui/filtering/filtering.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;102)

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

[BaseFiltering](corelib.BaseFiltering.md).[loadState](corelib.BaseFiltering.md#loadstate)

#### Defined in

[src/ui/filtering/filtering.ts:216](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;216)

___

### operatorFormat

▸ `Protected` **operatorFormat**(`op`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md) |

#### Returns

`string`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[operatorFormat](corelib.BaseFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;131)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[saveState](corelib.BaseFiltering.md#savestate)

#### Defined in

[src/ui/filtering/filtering.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;221)

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

[BaseFiltering](corelib.BaseFiltering.md).[set_container](corelib.BaseFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;67)

___

### set\_field

▸ **set_field**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`void`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[set_field](corelib.BaseFiltering.md#set_field)

#### Defined in

[src/ui/filtering/filtering.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;57)

___

### set\_operator

▸ **set_operator**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md) |

#### Returns

`void`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[set_operator](corelib.BaseFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;77)

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

[BaseFiltering](corelib.BaseFiltering.md).[validateEditorValue](corelib.BaseFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;242)
