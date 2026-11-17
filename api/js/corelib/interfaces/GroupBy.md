[@serenity-is/corelib](../README.md) / GroupBy

# Interface: GroupBy

Defined in: [src/base/servicetypes.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L234)

A field the rows a list request matches are grouped by, for the aggregates of each group.

## Properties

### Descending?

> `optional` **Descending**: `boolean`

Defined in: [src/base/servicetypes.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L238)

Whether the groups are in descending order of the field.

***

### Field?

> `optional` **Field**: `string`

Defined in: [src/base/servicetypes.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L236)

The field name.

***

### Interval?

> `optional` **Interval**: [`DateGroupInterval`](../enumerations/DateGroupInterval.md)

Defined in: [src/base/servicetypes.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L243)

The interval the values of a date field are grouped by, e.g. the months. The key of a group is then the start
of its interval. It can only be used with a date field, and the rows are not grouped at all otherwise.
