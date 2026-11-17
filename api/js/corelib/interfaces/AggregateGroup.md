[@serenity-is/corelib](../README.md) / AggregateGroup

# Interface: AggregateGroup

Defined in: [src/base/servicetypes.ts:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L250)

The aggregates of a list request for a set of rows: all the rows the request matches at the root, and
the rows of a group under it, one level for each `GroupBy` of the request.

## Properties

### Count?

> `optional` **Count**: `number`

Defined in: [src/base/servicetypes.ts:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L254)

The number of the rows.

***

### Groups?

> `optional` **Groups**: `AggregateGroup`[]

Defined in: [src/base/servicetypes.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L261)

The groups of the next level, in their order. Not set when the rows are not grouped further.

***

### Key?

> `optional` **Key**: `any`

Defined in: [src/base/servicetypes.ts:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L252)

The value of the group field for the rows of the group, as it is in the entities. Null at the root.

***

### More?

> `optional` **More**: `boolean`

Defined in: [src/base/servicetypes.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L263)

True when there are more groups than the ones in `Groups`, as their number is limited.

***

### Values?

> `optional` **Values**: `object`

Defined in: [src/base/servicetypes.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L259)

The values of the aggregates by the key of their type (`count`, `sum`, `avg`, `min`, `max`, `distinct`), then by
the name of their field, e.g. `Values.sum.Freight`, as the totals of a grid are.

#### Index Signature

\[`type`: `string`\]: `object`
