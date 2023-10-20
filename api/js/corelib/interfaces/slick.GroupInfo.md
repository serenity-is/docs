[@serenity-is](../README.md) / [Modules](../modules.md) / [slick](../modules/slick.md) / GroupInfo

# Interface: GroupInfo<TItem\>

[slick](../modules/slick.md).GroupInfo

## Type parameters

| Name |
| :------ |
| `TItem` |

## Table of contents

### Properties

- [aggregateCollapsed](slick.GroupInfo.md#aggregatecollapsed)
- [aggregators](slick.GroupInfo.md#aggregators)
- [comparer](slick.GroupInfo.md#comparer)
- [formatter](slick.GroupInfo.md#formatter)
- [getter](slick.GroupInfo.md#getter)
- [lazyTotalsCalculation](slick.GroupInfo.md#lazytotalscalculation)

## Properties

### aggregateCollapsed

• `Optional` **aggregateCollapsed**: `boolean`

#### Defined in

[src/slick/slicktypes.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L22)

___

### aggregators

• `Optional` **aggregators**: `any`[]

#### Defined in

[src/slick/slicktypes.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L21)

___

### comparer

• `Optional` **comparer**: (`a`: `Group`<`TItem`\>, `b`: `Group`<`TItem`\>) => `number`

#### Type declaration

▸ (`a`, `b`): `number`

##### Parameters

| Name | Type |
| :------ | :------ |
| `a` | `Group`<`TItem`\> |
| `b` | `Group`<`TItem`\> |

##### Returns

`number`

#### Defined in

[src/slick/slicktypes.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L20)

___

### formatter

• `Optional` **formatter**: (`p1`: `Group`<`TItem`\>) => `string`

#### Type declaration

▸ (`p1`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `Group`<`TItem`\> |

##### Returns

`string`

#### Defined in

[src/slick/slicktypes.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L19)

___

### getter

• `Optional` **getter**: `any`

#### Defined in

[src/slick/slicktypes.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L18)

___

### lazyTotalsCalculation

• `Optional` **lazyTotalsCalculation**: `boolean`

#### Defined in

[src/slick/slicktypes.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L23)
