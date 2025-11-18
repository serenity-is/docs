[@serenity-is/sleekgrid](../README.md) / GroupTotals

# Class: GroupTotals\<TEntity\>

Defined in: [src/core/group.ts:101](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L101)

Information about group totals.
An instance of GroupTotals will be created for each totals row and passed to the aggregators
so that they can store arbitrary data in it.  That data can later be accessed by group totals
formatters during the display.
 GroupTotals

## Extends

- [`NonDataRow`](NonDataRow.md)

## Type Parameters

### TEntity

`TEntity` = `any`

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

Defined in: [src/core/group.ts:103](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L103)

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`__groupTotals`](../interfaces/IGroupTotals.md#__grouptotals)

***

### \_\_nonDataRow

> **\_\_nonDataRow**: `boolean` = `true`

Defined in: [src/core/base.ts:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/base.ts#L5)

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`__nonDataRow`](../interfaces/IGroupTotals.md#__nondatarow)

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`__nonDataRow`](NonDataRow.md#__nondatarow)

***

### avg?

> `optional` **avg**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:128](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L128)

Contains avg

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`avg`](../interfaces/IGroupTotals.md#avg)

***

### group

> **group**: [`Group`](Group.md)\<`TEntity`\>

Defined in: [src/core/group.ts:110](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L110)

Parent Group.

#### Param

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`group`](../interfaces/IGroupTotals.md#group)

***

### initialized

> **initialized**: `boolean` = `false`

Defined in: [src/core/group.ts:118](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L118)

Whether the totals have been fully initialized / calculated.
Will be set to false for lazy-calculated group totals.

#### Param

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`initialized`](../interfaces/IGroupTotals.md#initialized)

***

### max?

> `optional` **max**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:138](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L138)

Contains max

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`max`](../interfaces/IGroupTotals.md#max)

***

### min?

> `optional` **min**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:133](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L133)

Contains min

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`min`](../interfaces/IGroupTotals.md#min)

***

### sum?

> `optional` **sum**: `Record`\<`string`, `any`\>

Defined in: [src/core/group.ts:123](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L123)

Contains sum

#### Implementation of

[`IGroupTotals`](../interfaces/IGroupTotals.md).[`sum`](../interfaces/IGroupTotals.md#sum)
