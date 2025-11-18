[@serenity-is/sleekgrid](../README.md) / Group

# Class: Group\<TEntity\>

Defined in: [src/core/group.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L7)

Information about a group of rows.

## Extends

- [`NonDataRow`](NonDataRow.md)

## Type Parameters

### TEntity

`TEntity` = `any`

## Constructors

### Constructor

> **new Group**\<`TEntity`\>(): `Group`\<`TEntity`\>

#### Returns

`Group`\<`TEntity`\>

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`constructor`](NonDataRow.md#constructor)

## Properties

### \_\_group

> `readonly` **\_\_group**: `true` = `true`

Defined in: [src/core/group.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L8)

***

### \_\_nonDataRow

> **\_\_nonDataRow**: `boolean` = `true`

Defined in: [src/core/base.ts:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/base.ts#L5)

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`__nonDataRow`](NonDataRow.md#__nondatarow)

***

### collapsed

> **collapsed**: `boolean` = `false`

Defined in: [src/core/group.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L36)

Whether a group is collapsed.

***

### count

> **count**: `number` = `0`

Defined in: [src/core/group.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L22)

Number of rows in the group.

***

### formatValue()

> **formatValue**: (`ctx`) => [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/core/group.ts:68](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L68)

Returns a text representation of the group value.

#### Parameters

##### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)\<`Group`\<`TEntity`\>\>

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

***

### groupingKey

> **groupingKey**: `string`

Defined in: [src/core/group.ts:65](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L65)

A unique key used to identify the group.  This key can be used in calls to DataView
collapseGroup() or expandGroup().

***

### groups

> **groups**: `Group`\<`TEntity`\>[]

Defined in: [src/core/group.ts:57](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L57)

Sub-groups that are part of the group.

***

### level

> **level**: `number` = `0`

Defined in: [src/core/group.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L15)

Grouping level, starting with 0.

***

### rows

> **rows**: `TEntity`[] = `[]`

Defined in: [src/core/group.ts:50](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L50)

Rows that are part of the group.

***

### totals

> **totals**: [`GroupTotals`](GroupTotals.md)\<`TEntity`\>

Defined in: [src/core/group.ts:43](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L43)

GroupTotals, if any.

***

### value

> **value**: `any`

Defined in: [src/core/group.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L29)

Grouping value.

## Methods

### equals()

> **equals**(`group`): `boolean`

Defined in: [src/core/group.ts:75](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L75)

Compares two Group instances.

#### Parameters

##### group

`Group`

{Group} Group instance to compare to.

#### Returns

`boolean`
