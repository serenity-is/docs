[@serenity-is/sleekgrid](../README.md) / initColumnProps

# Function: initColumnProps()

> **initColumnProps**(`columns`, `defaults`): `void`

Defined in: [src/core/column.ts:175](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L175)

Normalizes column definitions: applies defaults, clamps widths and ensures unique ids/names.
Mutates the `columns` array in place.

## Parameters

### columns

[`Column`](../interfaces/Column.md)\<`any`\>[]

Column definitions to initialize.

### defaults

`Partial`\<[`Column`](../interfaces/Column.md)\<`any`\>\>

Default values to fall back to for missing properties.

## Returns

`void`
