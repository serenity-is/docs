[@serenity-is/sleekgrid](../README.md) / NonDataRow

# Class: NonDataRow

Defined in: [src/core/base.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/base.ts#L6)

Base class for special rows that do not represent regular data items.
Group headers and group totals derive from this to allow the grid and
data view to distinguish them from plain data rows via the marker property.

## Extended by

- [`Group`](Group.md)
- [`GroupTotals`](GroupTotals.md)

## Constructors

### Constructor

> **new NonDataRow**(): `NonDataRow`

#### Returns

`NonDataRow`

## Properties

### \_\_nonDataRow

> **\_\_nonDataRow**: `boolean` = `true`

Defined in: [src/core/base.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/base.ts#L11)

Marker flag used at runtime to identify non-data rows.
Checked by the grid and `DataView` to skip data-specific handling.
