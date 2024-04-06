[@serenity-is/sleekgrid](../README.md) / ItemMetadata

# Interface: ItemMetadata\<TItem\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

## Table of contents

### Properties

- [columns](ItemMetadata.md#columns)
- [cssClasses](ItemMetadata.md#cssclasses)
- [focusable](ItemMetadata.md#focusable)
- [format](ItemMetadata.md#format)
- [formatter](ItemMetadata.md#formatter)
- [selectable](ItemMetadata.md#selectable)

## Properties

### columns

• `Optional` **columns**: `Object`

#### Index signature

▪ [key: `string`]: [`ColumnMetadata`](ColumnMetadata.md)\<`TItem`\>

#### Defined in

[core/column.ts:68](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L68)

___

### cssClasses

• `Optional` **cssClasses**: `string`

#### Defined in

[core/column.ts:67](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L67)

___

### focusable

• `Optional` **focusable**: `boolean`

#### Defined in

[core/column.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L69)

___

### format

• `Optional` **format**: [`ColumnFormat`](../README.md#columnformat)\<`TItem`\>

#### Defined in

[core/column.ts:70](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L70)

___

### formatter

• `Optional` **formatter**: [`CompatFormatter`](../README.md#compatformatter)\<`TItem`\>

**`Deprecated`**

#### Defined in

[core/column.ts:72](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L72)

___

### selectable

• `Optional` **selectable**: `boolean`

#### Defined in

[core/column.ts:73](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L73)
