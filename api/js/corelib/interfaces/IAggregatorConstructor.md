[serenity-is/corelib](../README.md) / IAggregatorConstructor

# Interface: IAggregatorConstructor

Defined in: [src/slick/aggregatortyperegistry.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L4)

## Constructors

### Constructor

> **new IAggregatorConstructor**(`field`, ...`args`): [`IAggregator`](IAggregator.md)

Defined in: [src/slick/aggregatortyperegistry.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L5)

#### Parameters

##### field

`string`

##### args

...`any`[]

#### Returns

[`IAggregator`](IAggregator.md)

## Properties

### aggregateKey

> **aggregateKey**: `string`

Defined in: [src/slick/aggregatortyperegistry.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L10)

A unique key for the aggregator (like 'sum', 'avg', etc.). This is also used in the totals object
as a property key to store the results of this aggregator.

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [src/slick/aggregatortyperegistry.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L14)

A user-friendly display name for the aggregator (like "Sum", "Average", etc.)

***

### summaryType?

> `optional` **summaryType**: [`SummaryType`](../enumerations/SummaryType.md)

Defined in: [src/slick/aggregatortyperegistry.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L19)

Corresponding SummaryType enum value (like SummaryType.Sum, SummaryType.Avg, etc.),
if any.
