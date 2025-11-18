[@serenity-is/corelib](../../../../README.md) / [AggregateFormatting](../README.md) / initGridDefaults

# Function: initGridDefaults()

> **initGridDefaults**(): `void`

Defined in: [src/slick/aggregateformatting.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregateformatting.tsx#L97)

Call this method to ensure that `gridDefaults.groupTotalsFormat` is set to `AggregateFormatting.groupTotalsFormat`.
It only sets it when it is not already set to some value. This is normally called by `RemoteView` constructor.

## Returns

`void`
