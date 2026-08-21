[@serenity-is/sleekgrid](../README.md) / IGroupTotals

# Interface: IGroupTotals\<TEntity\>

Defined in: [src/core/group.ts:72](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L72)

Minimal totals information attached to a [Group](../classes/Group.md). Aggregators populate
`sum`/`avg`/`min`/`max` and arbitrary data on this object.

## Type Parameters

### TEntity

`TEntity` = `any`

Row item type.

## Properties

### \_\_groupTotals?

> `optional` **\_\_groupTotals**: `boolean`

Defined in: [src/core/group.ts:76](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L76)

Marker identifying the row as a group-totals row.

***

### \_\_nonDataRow?

> `optional` **\_\_nonDataRow**: `boolean`

Defined in: [src/core/group.ts:74](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L74)

Whether the row is a non-data row (inherited from [NonDataRow](../classes/NonDataRow.md)).

***

### avg?

> `optional` **avg**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:84](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L84)

Per-field average values.

***

### group?

> `optional` **group**: [`Group`](../classes/Group.md)\<`TEntity`\>

Defined in: [src/core/group.ts:78](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L78)

Parent group this totals row belongs to.

***

### initialized?

> `optional` **initialized**: `boolean`

Defined in: [src/core/group.ts:80](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L80)

Whether totals have been fully calculated; `false` for lazy totals.

***

### max?

> `optional` **max**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:88](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L88)

Per-field maximum values.

***

### min?

> `optional` **min**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:86](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L86)

Per-field minimum values.

***

### sum?

> `optional` **sum**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:82](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L82)

Per-field sum values.
