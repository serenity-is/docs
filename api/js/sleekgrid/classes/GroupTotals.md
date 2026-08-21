[@serenity-is/sleekgrid](../README.md) / GroupTotals

# Class: GroupTotals\<TEntity\>

Defined in: [src/core/group.ts:96](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L96)

Totales row for a [Group](Group.md). Created for each group and passed to aggregators
so they can store computed data that is later accessed by group-totals formatters.

## Extends

- [`NonDataRow`](NonDataRow.md)

## Type Parameters

### TEntity

`TEntity` = `any`

Row item type.

## Implements

- [`IGroupTotals`](../interfaces/IGroupTotals.md)\<`TEntity`\>

## Constructors

### Constructor

> **new GroupTotals**\<`TEntity`\>(): `GroupTotals`\<`TEntity`\>

#### Returns

`GroupTotals`\<`TEntity`\>

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`constructor`](NonDataRow.md#constructor)

## Properties

### \_\_groupTotals

> `readonly` **\_\_groupTotals**: `true` = `true`

Defined in: [src/core/group.ts:99](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L99)

Marker identifying this row as a group-totals row.

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`__groupTotals`](../interfaces/IGroupTotals.md#__grouptotals)

***

### \_\_nonDataRow

> **\_\_nonDataRow**: `boolean` = `true`

Defined in: [src/core/base.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/base.ts#L11)

Marker flag used at runtime to identify non-data rows.
Checked by the grid and `DataView` to skip data-specific handling.

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`__nonDataRow`](../interfaces/IGroupTotals.md#__nondatarow)

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`__nonDataRow`](NonDataRow.md#__nondatarow)

***

### avg?

> `optional` **avg**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:120](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L120)

Per-field average values computed by aggregators.

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`avg`](../interfaces/IGroupTotals.md#avg)

***

### group

> **group**: [`Group`](Group.md)\<`TEntity`\>

Defined in: [src/core/group.ts:104](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L104)

Parent group this totals row belongs to.

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`group`](../interfaces/IGroupTotals.md#group)

***

### initialized

> **initialized**: `boolean` = `false`

Defined in: [src/core/group.ts:110](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L110)

Whether the totals have been fully initialized/calculated.
Set to `false` for lazy-calculated totals.

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`initialized`](../interfaces/IGroupTotals.md#initialized)

***

### max?

> `optional` **max**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:130](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L130)

Per-field maximum values computed by aggregators.

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`max`](../interfaces/IGroupTotals.md#max)

***

### min?

> `optional` **min**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:125](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L125)

Per-field minimum values computed by aggregators.

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`min`](../interfaces/IGroupTotals.md#min)

***

### sum?

> `optional` **sum**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:115](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L115)

Per-field sum values computed by aggregators.

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`sum`](../interfaces/IGroupTotals.md#sum)
