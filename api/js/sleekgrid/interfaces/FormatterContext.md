[@serenity-is/sleekgrid](../README.md) / FormatterContext

# Interface: FormatterContext\<TItem\>

Context object for column formatters. It provides access to the
current cell value, row index, column index, etc.
Use grid.getFormatterContext() to create a new instance.

## Type Parameters

• **TItem** = `any`

## Properties

### addAttrs?

> `optional` **addAttrs**: `object`

Additional attributes to be added to the cell node.

#### Index Signature

 \[`key`: `string`\]: `string`

#### Defined in

[core/formatting.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L14)

***

### addClass?

> `optional` **addClass**: `string`

Additional classes to be added to the cell node.

#### Defined in

[core/formatting.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L19)

***

### cell?

> `optional` **cell**: `number`

The column index of the cell.

#### Defined in

[core/formatting.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L35)

***

### column?

> `optional` **column**: [`Column`](Column.md)\<`TItem`\>

The column definition of the cell.

#### Defined in

[core/formatting.ts:40](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L40)

***

### grid?

> `optional` **grid**: `any`

The grid instance.

#### Defined in

[core/formatting.ts:45](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L45)

***

### item?

> `optional` **item**: `TItem`

The item of the row.

#### Defined in

[core/formatting.ts:50](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L50)

***

### row?

> `optional` **row**: `number`

The row index of the cell.

#### Defined in

[core/formatting.ts:30](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L30)

***

### tooltip?

> `optional` **tooltip**: `string`

Tooltip text to be added to the cell node as title attribute.

#### Defined in

[core/formatting.ts:55](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L55)

***

### value?

> `optional` **value**: `any`

when returning a formatter result, prefer ctx.escape() to avoid script injection attacks!

#### Defined in

[core/formatting.ts:58](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L58)

## Methods

### escape()

> **escape**(`value`?): `string`

Returns html escaped ctx.value if called without arguments.
prefer this over ctx.value to avoid html injection attacks!

#### Parameters

##### value?

`any`

#### Returns

`string`

#### Defined in

[core/formatting.ts:25](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L25)
