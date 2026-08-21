[@serenity-is/corelib](../README.md) / IAggregatorConstructor

# Interface: IAggregatorConstructor

Defined in: [src/slick/aggregatortyperegistry.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L7)

Constructor interface for aggregator classes.

## Constructors

### Constructor

> **new IAggregatorConstructor**(`field`, ...`args`): [`IAggregator`](IAggregator.md)

Defined in: [src/slick/aggregatortyperegistry.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L9)

Creates a new aggregator instance.

#### Parameters

##### field

`string`

The field to aggregate.

##### args

...`any`[]

#### Returns

[`IAggregator`](IAggregator.md)

## Properties

### aggregateKey

> **aggregateKey**: `string`

Defined in: [src/slick/aggregatortyperegistry.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L14)

A unique key for the aggregator (like 'sum', 'avg', etc.). This is also used in the totals object
as a property key to store the results of this aggregator.

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [src/slick/aggregatortyperegistry.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L18)

A user-friendly display name for the aggregator (like "Sum", "Average", etc.)

***

### summaryType?

> `optional` **summaryType**: [`SummaryType`](../enumerations/SummaryType.md)

Defined in: [src/slick/aggregatortyperegistry.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L23)

Corresponding SummaryType enum value (like SummaryType.Sum, SummaryType.Avg, etc.),
if any.
