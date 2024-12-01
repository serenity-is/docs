[@serenity-is/corelib](../README.md) / BaseFiltering

# Class: `abstract` BaseFiltering

## Extended by

- [`BaseEditorFiltering`](BaseEditorFiltering.md)
- [`BooleanFiltering`](BooleanFiltering.md)
- [`StringFiltering`](StringFiltering.md)

## Implements

- [`IFiltering`](IFiltering.md)
- [`IQuickFiltering`](IQuickFiltering.md)

## Constructors

### new BaseFiltering()

> **new BaseFiltering**(): [`BaseFiltering`](BaseFiltering.md)

#### Returns

[`BaseFiltering`](BaseFiltering.md)

## Methods

### appendComparisonOperators()

> `protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Defined in

[src/ui/filtering/filtering.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L94)

***

### appendNullableOperators()

> `protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Defined in

[src/ui/filtering/filtering.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L85)

***

### argumentNull()

> `protected` **argumentNull**(): `Error`

#### Returns

`Error`

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L242)

***

### createEditor()

> **createEditor**(): `void`

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`createEditor`](IFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L108)

***

### displayText()

> `protected` **displayText**(`op`, `values`?): `string`

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

##### values?

`any`[]

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L143)

***

### get\_container()

> **get\_container**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Implementation of

[`IFiltering`](IFiltering.md).[`get_container`](IFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L65)

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Implementation of

[`IFiltering`](IFiltering.md).[`get_field`](IFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L55)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Implementation of

[`IFiltering`](IFiltering.md).[`get_operator`](IFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L75)

***

### getCriteria()

> **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Implementation of

[`IFiltering`](IFiltering.md).[`getCriteria`](IFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L159)

***

### getCriteriaField()

> `protected` **getCriteriaField**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L155)

***

### getEditorText()

> **getEditorText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L275)

***

### getEditorValue()

> **getEditorValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L253)

***

### getOperators()

> `abstract` **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Implementation of

[`IFiltering`](IFiltering.md).[`getOperators`](IFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

***

### getTitle()

> `protected` **getTitle**(`field`): `string`

#### Parameters

##### field

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L139)

***

### initQuickFilter()

> **initQuickFilter**(`filter`): `void`

#### Parameters

##### filter

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>

#### Returns

`void`

#### Implementation of

[`IQuickFiltering`](IQuickFiltering.md).[`initQuickFilter`](IQuickFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:292](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L292)

***

### isNullable()

> `protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L104)

***

### loadState()

> **loadState**(`state`): `void`

#### Parameters

##### state

`any`

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`loadState`](IFiltering.md#loadstate)

#### Defined in

[src/ui/filtering/filtering.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L220)

***

### operatorFormat()

> `protected` **operatorFormat**(`op`): `string`

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L135)

***

### saveState()

> **saveState**(): `string`

#### Returns

`string`

#### Implementation of

[`IFiltering`](IFiltering.md).[`saveState`](IFiltering.md#savestate)

#### Defined in

[src/ui/filtering/filtering.ts:225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L225)

***

### set\_container()

> **set\_container**(`value`): `void`

#### Parameters

##### value

`HTMLElement`

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`set_container`](IFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L69)

***

### set\_field()

> **set\_field**(`value`): `void`

#### Parameters

##### value

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`set_field`](IFiltering.md#set_field)

#### Defined in

[src/ui/filtering/filtering.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L59)

***

### set\_operator()

> **set\_operator**(`value`): `void`

#### Parameters

##### value

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`set_operator`](IFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L79)

***

### validateEditorValue()

> **validateEditorValue**(`value`): `string`

#### Parameters

##### value

`string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L246)
