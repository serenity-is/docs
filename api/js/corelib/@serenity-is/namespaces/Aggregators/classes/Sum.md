[@serenity-is/corelib](../../../../README.md) / [Aggregators](../README.md) / Sum

# Class: Sum

Defined in: [src/slick/aggregators.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L221)

Sum of a numeric field.

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new Sum**(`field`): `Sum`

Defined in: [src/slick/aggregators.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L231)

Creates a new sum aggregator.

#### Parameters

##### field

`string`

The field to aggregate.

#### Returns

`Sum`

## Properties

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L223)

The field to aggregate.

***

### sum

> **sum**: `number`

Defined in: [src/slick/aggregators.ts:225](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L225)

Running sum of valid values.

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"sum"` = `"sum"`

Defined in: [src/slick/aggregators.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L259)

Key used to store/lookup this aggregator in totals.

***

### summaryType

> `readonly` `static` **summaryType**: [`Sum`](../../../../enumerations/SummaryType.md#sum) = `SummaryType.Sum`

Defined in: [src/slick/aggregators.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L257)

Summary type for this aggregator.

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L261)

Localized display name for this aggregator.

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L241)

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

Defined in: [src/slick/aggregators.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L236)

Initializes state before a new group is processed.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L249)

Writes computed totals into the group totals object.

#### Parameters

##### groupTotals

`any`

Totals container to write the computed sum into, keyed by field name.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)
