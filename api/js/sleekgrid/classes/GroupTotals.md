[@serenity-is/sleekgrid](../README.md) / GroupTotals

# Class: GroupTotals\<TEntity\>

Information about group totals.
An instance of GroupTotals will be created for each totals row and passed to the aggregators
so that they can store arbitrary data in it.  That data can later be accessed by group totals
formatters during the display.
 GroupTotals

## Extends

- [`NonDataRow`](NonDataRow.md)

## Type Parameters

• **TEntity** = `any`

## Constructors

### new GroupTotals()

> **new GroupTotals**\<`TEntity`\>(): [`GroupTotals`](GroupTotals.md)\<`TEntity`\>

#### Returns

[`GroupTotals`](GroupTotals.md)\<`TEntity`\>

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`constructor`](NonDataRow.md#constructors)

## Properties

### \_\_groupTotals

> `readonly` **\_\_groupTotals**: `true` = `true`

#### Defined in

[core/group.ts:97](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L97)

***

### \_\_nonDataRow

> **\_\_nonDataRow**: `boolean` = `true`

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`__nonDataRow`](NonDataRow.md#__nondatarow)

#### Defined in

[core/base.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/core/base.ts#L5)

***

### avg?

> `optional` **avg**: `number`

Contains avg

#### Defined in

[core/group.ts:122](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L122)

***

### group

> **group**: [`Group`](Group.md)\<`TEntity`\>

Parent Group.

#### Param

#### Defined in

[core/group.ts:104](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L104)

***

### initialized

> **initialized**: `boolean` = `false`

Whether the totals have been fully initialized / calculated.
Will be set to false for lazy-calculated group totals.

#### Param

#### Defined in

[core/group.ts:112](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L112)

***

### max?

> `optional` **max**: `any`

Contains max

#### Defined in

[core/group.ts:132](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L132)

***

### min?

> `optional` **min**: `any`

Contains min

#### Defined in

[core/group.ts:127](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L127)

***

### sum?

> `optional` **sum**: `number`

Contains sum

#### Defined in

[core/group.ts:117](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L117)
