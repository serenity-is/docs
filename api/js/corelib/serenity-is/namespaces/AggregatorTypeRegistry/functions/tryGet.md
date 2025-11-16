[serenity-is/corelib](../../../../README.md) / [AggregatorTypeRegistry](../README.md) / tryGet

# Function: tryGet()

> **tryGet**(`aggKey`): [`IAggregatorConstructor`](../../../../interfaces/IAggregatorConstructor.md)

Defined in: [src/slick/aggregatortyperegistry.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregatortyperegistry.ts#L54)

Tries to get an aggregator constructor by its SummaryType or unique key.

## Parameters

### aggKey

The SummaryType enum value or the unique key of the aggregator (like 'sum', 'avg', etc.)

`string` | [`SummaryType`](../../../../enumerations/SummaryType.md)

## Returns

[`IAggregatorConstructor`](../../../../interfaces/IAggregatorConstructor.md)

The corresponding aggregator constructor, or undefined if not found.
