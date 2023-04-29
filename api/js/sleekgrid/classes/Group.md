[@serenity-is/sleekgrid](../README.md) / Group

# Class: Group<TEntity\>

Information about a group of rows.

## Type parameters

| Name | Type |
| :------ | :------ |
| `TEntity` | `any` |

## Hierarchy

- [`NonDataRow`](NonDataRow.md)

  ↳ **`Group`**

## Table of contents

### Constructors

- [constructor](Group.md#constructor)

### Properties

- [\_\_group](Group.md#__group)
- [\_\_nonDataRow](Group.md#__nondatarow)
- [collapsed](Group.md#collapsed)
- [count](Group.md#count)
- [groupingKey](Group.md#groupingkey)
- [groups](Group.md#groups)
- [level](Group.md#level)
- [rows](Group.md#rows)
- [title](Group.md#title)
- [totals](Group.md#totals)
- [value](Group.md#value)

### Methods

- [equals](Group.md#equals)

## Constructors

### constructor

• **new Group**<`TEntity`\>()

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TEntity` | `any` |

#### Inherited from

[NonDataRow](NonDataRow.md).[constructor](NonDataRow.md#constructor)

## Properties

### \_\_group

• `Readonly` **\_\_group**: ``true``

#### Defined in

[core/group.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;7)

___

### \_\_nonDataRow

• **\_\_nonDataRow**: `boolean` = `true`

#### Inherited from

[NonDataRow](NonDataRow.md).[__nonDataRow](NonDataRow.md#__nondatarow)

#### Defined in

[core/base.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/core/base.ts#line&#x3D;5)

___

### collapsed

• **collapsed**: `boolean` = `false`

Whether a group is collapsed.

#### Defined in

[core/group.ts:42](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;42)

___

### count

• **count**: `number` = `0`

Number of rows in the group.

#### Defined in

[core/group.ts:21](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;21)

___

### groupingKey

• **groupingKey**: `string`

A unique key used to identify the group.  This key can be used in calls to DataView
collapseGroup() or expandGroup().

#### Defined in

[core/group.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;71)

___

### groups

• **groups**: [`Group`](Group.md)<`TEntity`\>[]

Sub-groups that are part of the group.

#### Defined in

[core/group.ts:63](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;63)

___

### level

• **level**: `number` = `0`

Grouping level, starting with 0.

#### Defined in

[core/group.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;14)

___

### rows

• **rows**: `TEntity`[] = `[]`

Rows that are part of the group.

#### Defined in

[core/group.ts:56](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;56)

___

### title

• **title**: `string`

Formatted display value of the group.

#### Defined in

[core/group.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;35)

___

### totals

• **totals**: [`GroupTotals`](GroupTotals.md)<`TEntity`\>

GroupTotals, if any.

#### Defined in

[core/group.ts:49](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;49)

___

### value

• **value**: `any`

Grouping value.

#### Defined in

[core/group.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;28)

## Methods

### equals

▸ **equals**(`group`): `boolean`

Compares two Group instances.

**`Method`**

equals

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `group` | [`Group`](Group.md)<`any`\> | {Group} Group instance to compare to. |

#### Returns

`boolean`

#### Defined in

[core/group.ts:80](https://github.com/serenity-is/sleekgrid/blob/master/src/core/group.ts#line&#x3D;80)
