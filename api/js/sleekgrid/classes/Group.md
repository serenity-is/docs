[@serenity-is/sleekgrid](../README.md) / Group

# Class: Group\<TEntity\>

Information about a group of rows.

## Extends

- [`NonDataRow`](NonDataRow.md)

## Type Parameters

• **TEntity** = `any`

## Constructors

### new Group()

> **new Group**\<`TEntity`\>(): [`Group`](Group.md)\<`TEntity`\>

#### Returns

[`Group`](Group.md)\<`TEntity`\>

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`constructor`](NonDataRow.md#constructors)

## Properties

### \_\_group

> `readonly` **\_\_group**: `true` = `true`

#### Defined in

[core/group.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L7)

***

### \_\_nonDataRow

> **\_\_nonDataRow**: `boolean` = `true`

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`__nonDataRow`](NonDataRow.md#__nondatarow)

#### Defined in

[core/base.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/core/base.ts#L5)

***

### collapsed

> **collapsed**: `boolean` = `false`

Whether a group is collapsed.

#### Defined in

[core/group.ts:42](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L42)

***

### count

> **count**: `number` = `0`

Number of rows in the group.

#### Defined in

[core/group.ts:21](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L21)

***

### groupingKey

> **groupingKey**: `string`

A unique key used to identify the group.  This key can be used in calls to DataView
collapseGroup() or expandGroup().

#### Defined in

[core/group.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L71)

***

### groups

> **groups**: [`Group`](Group.md)\<`TEntity`\>[]

Sub-groups that are part of the group.

#### Defined in

[core/group.ts:63](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L63)

***

### level

> **level**: `number` = `0`

Grouping level, starting with 0.

#### Defined in

[core/group.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L14)

***

### rows

> **rows**: `TEntity`[] = `[]`

Rows that are part of the group.

#### Defined in

[core/group.ts:56](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L56)

***

### title

> **title**: `string`

Formatted display value of the group.

#### Defined in

[core/group.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L35)

***

### totals

> **totals**: [`GroupTotals`](GroupTotals.md)\<`TEntity`\>

GroupTotals, if any.

#### Defined in

[core/group.ts:49](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L49)

***

### value

> **value**: `any`

Grouping value.

#### Defined in

[core/group.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L28)

## Methods

### equals()

> **equals**(`group`): `boolean`

Compares two Group instances.

#### Parameters

##### group

[`Group`](Group.md)\<`any`\>

{Group} Group instance to compare to.

#### Returns

`boolean`

#### Defined in

[core/group.ts:79](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L79)
