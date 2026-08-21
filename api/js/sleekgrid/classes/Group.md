[@serenity-is/sleekgrid](../README.md) / Group

# Class: Group\<TEntity\>

Defined in: [src/core/group.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L8)

Represents a group of rows produced by a `DataView` grouping.

## Extends

- [`NonDataRow`](NonDataRow.md)

## Type Parameters

### TEntity

`TEntity` = `any`

Row item type being grouped.

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

Defined in: [src/core/group.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L10)

Marker flag identifying this row as a group header.

***

### \_\_nonDataRow

> **\_\_nonDataRow**: `boolean` = `true`

Defined in: [src/core/base.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/base.ts#L11)

Marker flag used at runtime to identify non-data rows.
Checked by the grid and `DataView` to skip data-specific handling.

#### Inherited from

[`NonDataRow`](NonDataRow.md).[`__nonDataRow`](NonDataRow.md#__nondatarow)

***

### collapsed

> **collapsed**: `boolean` = `false`

Defined in: [src/core/group.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L30)

Whether the group is currently collapsed (children hidden).

***

### count

> **count**: `number` = `0`

Defined in: [src/core/group.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L20)

Number of leaf rows in the group (excluding group headers/totals).

***

### formatValue()

> **formatValue**: (`ctx`) => [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/core/group.ts:53](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L53)

Formatter that renders the group value as text.

#### Parameters

##### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)\<`Group`\<`TEntity`\>\>

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

***

### groupingKey

> **groupingKey**: `string`

Defined in: [src/core/group.ts:50](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L50)

Unique key used to identify the group; pass to `DataView.collapseGroup()` / `expandGroup()`.

***

### groups

> **groups**: `Group`\<`TEntity`\>[]

Defined in: [src/core/group.ts:45](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L45)

Child groups when multiple grouping levels are active.

***

### level

> **level**: `number` = `0`

Defined in: [src/core/group.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L15)

Grouping level, starting with `0` for top-level groups.

***

### rows

> **rows**: `TEntity`[] = `[]`

Defined in: [src/core/group.ts:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L40)

Leaf rows that are part of the group.

***

### totals

> **totals**: [`GroupTotals`](GroupTotals.md)\<`TEntity`\>

Defined in: [src/core/group.ts:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L35)

Associated totals row for the group, if aggregation is enabled.

***

### value

> **value**: `any`

Defined in: [src/core/group.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L25)

Grouping value that all rows in this group share (e.g. the field value).

## Methods

### equals()

> **equals**(`group`): `boolean`

Defined in: [src/core/group.ts:60](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/group.ts#L60)

Compares two groups by `value`, `count` and `collapsed` state.

#### Parameters

##### group

`Group`

Group instance to compare to.

#### Returns

`boolean`

`true` if the groups are equal by the above fields.
