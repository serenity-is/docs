[@serenity-is/corelib](../README.md) / ColumnsBase

# Class: ColumnsBase\<TRow\>

Defined in: [src/ui/helpers/columnsbase.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/columnsbase.tsx#L8)

Base class for column definitions. Exposes each column as a property of the
instance, keyed by its id, source item name, or field name.

## Type Parameters

### TRow

`TRow` = `any`

The type of the row data.

## Constructors

### Constructor

> **new ColumnsBase**\<`TRow`\>(`items`): `ColumnsBase`\<`TRow`\>

Defined in: [src/ui/helpers/columnsbase.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/columnsbase.tsx#L15)

Creates a new ColumnsBase instance from the given column definitions.

#### Parameters

##### items

`Column`\<`TRow`\>[]

The column definitions.

#### Returns

`ColumnsBase`\<`TRow`\>

## Methods

### valueOf()

> **valueOf**(): `Column`\<`TRow`\>[]

Defined in: [src/ui/helpers/columnsbase.tsx:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/columnsbase.tsx#L39)

Returns the underlying column definitions array.

#### Returns

`Column`\<`TRow`\>[]

The column definitions.
