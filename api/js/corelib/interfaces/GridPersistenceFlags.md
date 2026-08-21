[@serenity-is/corelib](../README.md) / GridPersistenceFlags

# Interface: GridPersistenceFlags

Defined in: [src/ui/datagrid/datagrid-persistence.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L75)

Flags controlling which parts of grid state are persisted.
Unspecified flags fall back to defaultGridPersistenceFlags.

## Properties

### columnPinning?

> `optional` **columnPinning**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L77)

Column pinning state. Defaults to persist unless explicitly set to false.

***

### columnVisibility?

> `optional` **columnVisibility**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L81)

Column visibility. Defaults to persist unless explicitly set to false.

***

### columnWidths?

> `optional` **columnWidths**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L79)

Column widths. Defaults to persist unless explicitly set to false.

***

### filterItems?

> `optional` **filterItems**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L85)

Filter items. Defaults to persist unless explicitly set to false.

***

### includeDeleted?

> `optional` **includeDeleted**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L93)

Include deleted toggle state. Defaults to persist unless explicitly set to false.

***

### quickFilters?

> `optional` **quickFilters**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L87)

Quick filter values. Defaults to persist unless explicitly set to false.

***

### quickFilterText?

> `optional` **quickFilterText**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L89)

Quick filter display text. Only persists when explicitly set to true.

***

### quickSearch?

> `optional` **quickSearch**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L91)

Quick search input text. Only persists when explicitly set to true.

***

### sortColumns?

> `optional` **sortColumns**: `boolean`

Defined in: [src/ui/datagrid/datagrid-persistence.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L83)

Sort columns. Defaults to persist unless explicitly set to false.
