[@serenity-is/corelib](../../../../README.md) / [Aggregators](../README.md) / Min

# Class: Min

Defined in: [src/slick/aggregators.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L128)

Minimum of a field.

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new Min**(`field`): `Min`

Defined in: [src/slick/aggregators.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L138)

Creates a new minimum aggregator.

#### Parameters

##### field

`string`

The field to aggregate.

#### Returns

`Min`

## Properties

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L130)

The field to aggregate.

***

### min

> **min**: `any`

Defined in: [src/slick/aggregators.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L132)

Current minimum value.

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"min"` = `"min"`

Defined in: [src/slick/aggregators.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L168)

Key used to store/lookup this aggregator in totals.

***

### summaryType

> `readonly` `static` **summaryType**: [`Min`](../../../../enumerations/SummaryType.md#min) = `SummaryType.Min`

Defined in: [src/slick/aggregators.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L166)

Summary type for this aggregator.

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L170)

Localized display name for this aggregator.

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L148)

Accumulates a single item into the aggregator state.

#### Parameters

##### item

`any`

Row item to accumulate; numeric field values are compared against the current minimum.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`accumulate`](../../../../interfaces/IAggregator.md#accumulate)

***

### init()

> **init**(): `void`

Defined in: [src/slick/aggregators.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L143)

Initializes state before a new group is processed.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L158)

Writes computed totals into the group totals object.

#### Parameters

##### groupTotals

`any`

Totals container to write the computed minimum into, keyed by field name.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)
