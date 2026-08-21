[@serenity-is/corelib](../../../../README.md) / [Aggregators](../README.md) / Avg

# Class: Avg

Defined in: [src/slick/aggregators.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L17)

Average of a numeric field (ignores non-numeric / empty values).

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new Avg**(`field`): `Avg`

Defined in: [src/slick/aggregators.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L29)

Creates a new average aggregator.

#### Parameters

##### field

`string`

The field to average.

#### Returns

`Avg`

## Properties

### count

> **count**: `number`

Defined in: [src/slick/aggregators.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L19)

Number of items processed.

***

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L29)

The field to average.

***

### nonNullCount

> **nonNullCount**: `number`

Defined in: [src/slick/aggregators.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L21)

Number of non-null numeric values.

***

### sum

> **sum**: `number`

Defined in: [src/slick/aggregators.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L23)

Running sum of valid values.

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"avg"` = `"avg"`

Defined in: [src/slick/aggregators.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L60)

Key used to store/lookup this aggregator in totals.

***

### summaryType

> `readonly` `static` **summaryType**: [`Avg`](../../../../enumerations/SummaryType.md#avg) = `SummaryType.Avg`

Defined in: [src/slick/aggregators.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L58)

Summary type for this aggregator.

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L62)

Localized display name for this aggregator.

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L40)

Accumulates a single item into the aggregator state.

#### Parameters

##### item

`any`

Row item to accumulate; the configured field value is parsed as a number when valid.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`accumulate`](../../../../interfaces/IAggregator.md#accumulate)

***

### init()

> **init**(): `void`

Defined in: [src/slick/aggregators.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L33)

Initializes state before a new group is processed.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L50)

Writes computed totals into the group totals object.

#### Parameters

##### groupTotals

`IGroupTotals`

Totals container to write the computed average into, keyed by field name.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)
