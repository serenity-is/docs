[@serenity-is/sleekgrid](../README.md) / GroupTotals

# Class: GroupTotals\<TEntity\>

Information about group totals.
An instance of GroupTotals will be created for each totals row and passed to the aggregators
so that they can store arbitrary data in it.  That data can later be accessed by group totals
formatters during the display.
 GroupTotals

## Type parameters

| Name | Type |
| :------ | :------ |
| `TEntity` | `any` |

## Hierarchy

- [`NonDataRow`](NonDataRow.md)

  ↳ **`GroupTotals`**

## Table of contents

### Constructors

- [constructor](GroupTotals.md#constructor)

### Properties

- [\_\_groupTotals](GroupTotals.md#__grouptotals)
- [\_\_nonDataRow](GroupTotals.md#__nondatarow)
- [avg](GroupTotals.md#avg)
- [group](GroupTotals.md#group)
- [initialized](GroupTotals.md#initialized)
- [max](GroupTotals.md#max)
- [min](GroupTotals.md#min)
- [sum](GroupTotals.md#sum)

## Constructors

### constructor

• **new GroupTotals**\<`TEntity`\>(): [`GroupTotals`](GroupTotals.md)\<`TEntity`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TEntity` | `any` |

#### Returns

[`GroupTotals`](GroupTotals.md)\<`TEntity`\>

#### Inherited from

[NonDataRow](NonDataRow.md).[constructor](NonDataRow.md#constructor)

## Properties

### \_\_groupTotals

• `Readonly` **\_\_groupTotals**: ``true``

#### Defined in

[core/group.ts:99](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L99)

___

### \_\_nonDataRow

• **\_\_nonDataRow**: `boolean` = `true`

#### Inherited from

[NonDataRow](NonDataRow.md).[__nonDataRow](NonDataRow.md#__nondatarow)

#### Defined in

[core/base.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/core/base.ts#L5)

___

### avg

• `Optional` **avg**: `number`

Contains avg

#### Defined in

[core/group.ts:124](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L124)

___

### group

• **group**: [`Group`](Group.md)\<`TEntity`\>

Parent Group.

**`Param`**

#### Defined in

[core/group.ts:106](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L106)

___

### initialized

• **initialized**: `boolean` = `false`

Whether the totals have been fully initialized / calculated.
Will be set to false for lazy-calculated group totals.

**`Param`**

#### Defined in

[core/group.ts:114](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L114)

___

### max

• `Optional` **max**: `any`

Contains max

#### Defined in

[core/group.ts:134](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L134)

___

### min

• `Optional` **min**: `any`

Contains min

#### Defined in

[core/group.ts:129](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L129)

___

### sum

• `Optional` **sum**: `number`

Contains sum

#### Defined in

[core/group.ts:119](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#L119)
