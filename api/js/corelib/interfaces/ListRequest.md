[@serenity-is/corelib](../README.md) / ListRequest

# Interface: ListRequest

Defined in: [src/base/servicetypes.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L126)

Request DTO for `List` handlers (grid data source).
Supports paging, sorting, filtering and column selection.

## Extends

- [`ServiceRequest`](ServiceRequest.md)

## Properties

### ColumnSelection?

> `optional` **ColumnSelection**: [`ColumnSelection`](../enumerations/ColumnSelection.md)

Defined in: [src/base/servicetypes.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L146)

Preset that controls which columns are returned. See [ColumnSelection](../enumerations/ColumnSelection.md).

***

### ContainsField?

> `optional` **ContainsField**: `string`

Defined in: [src/base/servicetypes.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L136)

When set, `ContainsText` is applied only to this field instead of all searchable fields.

***

### ContainsText?

> `optional` **ContainsText**: `string`

Defined in: [src/base/servicetypes.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L134)

Quick-search text applied across searchable fields (or [ContainsField](#containsfield) when specified).

***

### Criteria?

> `optional` **Criteria**: `any`[]

Defined in: [src/base/servicetypes.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L138)

Advanced filter criteria tree (Serenity `Criteria` format: `[field, op, value]` or nested `["and", [...]]`).

***

### DistinctFields?

> `optional` **DistinctFields**: `string`[]

Defined in: [src/base/servicetypes.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L154)

Fields to apply `DISTINCT` on (server-dependent).

***

### EqualityFilter?

> `optional` **EqualityFilter**: `any`

Defined in: [src/base/servicetypes.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L140)

Simple equality filter map, e.g. `{ Status: 1 }`. Combined with `Criteria` via AND.

***

### ExcludeColumns?

> `optional` **ExcludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L150)

Explicit deny-list of columns to exclude.

***

### ExcludeTotalCount?

> `optional` **ExcludeTotalCount**: `boolean`

Defined in: [src/base/servicetypes.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L144)

When true the server may skip computing `TotalCount` for performance.

***

### ExportColumns?

> `optional` **ExportColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L152)

Columns to export when `List` is used for export; defaults to visible columns.

***

### IncludeColumns?

> `optional` **IncludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L148)

Explicit allow-list of columns to include (overrides `ColumnSelection`).

***

### IncludeDeleted?

> `optional` **IncludeDeleted**: `boolean`

Defined in: [src/base/servicetypes.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L142)

When true, soft-deleted rows are included in results.

***

### Localize?

> `optional` **Localize**: `string`

Defined in: [src/base/servicetypes.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L156)

Language ID for localized field selection (e.g. `"en"`, `"tr"`).

***

### Skip?

> `optional` **Skip**: `number`

Defined in: [src/base/servicetypes.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L128)

Number of records to skip (offset) for paging.

***

### Sort?

> `optional` **Sort**: `string`[]

Defined in: [src/base/servicetypes.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L132)

Sort expressions, e.g. `["Name ASC", "Age DESC"]`.

***

### Take?

> `optional` **Take**: `number`

Defined in: [src/base/servicetypes.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L130)

Maximum number of records to take (page size). Omit or 0 for server default.
