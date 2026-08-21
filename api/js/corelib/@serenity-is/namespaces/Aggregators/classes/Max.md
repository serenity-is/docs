[@serenity-is/corelib](../../../../README.md) / [Aggregators](../README.md) / Max

# Class: Max

Defined in: [src/slick/aggregators.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L176)

Maximum of a field.

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new Max**(`field`): `Max`

Defined in: [src/slick/aggregators.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L184)

Creates a new maximum aggregator.

#### Parameters

##### field

`string`

The field to aggregate.

#### Returns

`Max`

## Properties

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L184)

The field to aggregate.

***

### max

> **max**: `any`

Defined in: [src/slick/aggregators.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L178)

Current maximum value.

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"max"` = `"max"`

Defined in: [src/slick/aggregators.ts:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L213)

Key used to store/lookup this aggregator in totals.

***

### summaryType

> `readonly` `static` **summaryType**: [`Max`](../../../../enumerations/SummaryType.md#max) = `SummaryType.Max`

Defined in: [src/slick/aggregators.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L211)

Summary type for this aggregator.

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L215)

Localized display name for this aggregator.

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L193)

Accumulates a single item into the aggregator state.

#### Parameters

##### item

`any`

Row item to accumulate; numeric field values are compared against the current maximum.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`accumulate`](../../../../interfaces/IAggregator.md#accumulate)

***

### init()

> **init**(): `void`

Defined in: [src/slick/aggregators.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L188)

Initializes state before a new group is processed.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L203)

Writes computed totals into the group totals object.

#### Parameters

##### groupTotals

`any`

Totals container to write the computed maximum into, keyed by field name.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)
