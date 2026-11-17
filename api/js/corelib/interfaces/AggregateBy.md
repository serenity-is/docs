[@serenity-is/corelib](../README.md) / AggregateBy

# Interface: AggregateBy

Defined in: [src/base/servicetypes.ts:205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L205)

A value to calculate from all the rows a list request matches, and from the rows of each of its groups.

## Properties

### Field?

> `optional` **Field**: `string`

Defined in: [src/base/servicetypes.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L207)

The field name, which is only optional for `Count`.

***

### Type?

> `optional` **Type**: [`AggregateType`](../enumerations/AggregateType.md)

Defined in: [src/base/servicetypes.ts:209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L209)

The type of the aggregate.
