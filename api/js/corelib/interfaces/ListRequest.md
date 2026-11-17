[@serenity-is/corelib](../README.md) / ListRequest

# Interface: ListRequest

Defined in: [src/base/servicetypes.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L133)

Request DTO for `List` handlers (grid data source).
Supports paging, sorting, filtering and column selection.

## Extends

- [`ServiceRequest`](ServiceRequest.md)

## Properties

### Aggregates?

> `optional` **Aggregates**: [`AggregateBy`](AggregateBy.md)[]

Defined in: [src/base/servicetypes.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L170)

Values to calculate from all the rows the request matches, and not only from the returned page, e.g. the sum of a field.
They are returned in [ListResponse.Aggregates](ListResponse.md#aggregates). A handler that doesn't support aggregates ignores this.

***

### ColumnSelection?

> `optional` **ColumnSelection**: [`ColumnSelection`](../enumerations/ColumnSelection.md)

Defined in: [src/base/servicetypes.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L155)

Preset that controls which columns are returned. See [ColumnSelection](../enumerations/ColumnSelection.md).

***

### ContainsField?

> `optional` **ContainsField**: `string`

Defined in: [src/base/servicetypes.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L145)

When set, `ContainsText` is applied only to this field instead of all searchable fields.

***

### ContainsText?

> `optional` **ContainsText**: `string`

Defined in: [src/base/servicetypes.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L143)

Quick-search text applied across searchable fields (or [ContainsField](#containsfield) when specified).

***

### Criteria?

> `optional` **Criteria**: `any`[]

Defined in: [src/base/servicetypes.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L147)

Advanced filter criteria tree (Serenity `Criteria` format: `[field, op, value]` or nested `["and", [...]]`).

***

### DistinctFields?

> `optional` **DistinctFields**: `string`[]

Defined in: [src/base/servicetypes.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L163)

Fields to apply `DISTINCT` on (server-dependent).

***

### EqualityFilter?

> `optional` **EqualityFilter**: `any`

Defined in: [src/base/servicetypes.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L149)

Simple equality filter map, e.g. `{ Status: 1 }`. Combined with `Criteria` via AND.

***

### ExcludeColumns?

> `optional` **ExcludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L159)

Explicit deny-list of columns to exclude.

***

### ExcludeEntities?

> `optional` **ExcludeEntities**: `boolean`

Defined in: [src/base/servicetypes.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L174)

When true no entities are returned, only what is calculated from them, like the total count and the aggregates.

***

### ExcludeTotalCount?

> `optional` **ExcludeTotalCount**: `boolean`

Defined in: [src/base/servicetypes.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L153)

When true the server may skip computing `TotalCount` for performance.

***

### ExportColumns?

> `optional` **ExportColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L161)

Columns to export when `List` is used for export; defaults to visible columns.

***

### GroupBy?

> `optional` **GroupBy**: [`GroupBy`](GroupBy.md)[]

Defined in: [src/base/servicetypes.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L172)

Fields to group the rows by for the aggregates, the outermost first, so they are also calculated for each group.

***

### IncludeColumns?

> `optional` **IncludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L157)

Explicit allow-list of columns to include (overrides `ColumnSelection`).

***

### IncludeDeleted?

> `optional` **IncludeDeleted**: `boolean`

Defined in: [src/base/servicetypes.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L151)

When true, soft-deleted rows are included in results.

***

### IncludeMore?

> `optional` **IncludeMore**: `boolean`

Defined in: [src/base/servicetypes.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L139)

When true, request whether more records are available beyond the returned page.

***

### Localize?

> `optional` **Localize**: `string`

Defined in: [src/base/servicetypes.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L165)

Language ID for localized field selection (e.g. `"en"`, `"tr"`).

***

### Skip?

> `optional` **Skip**: `number`

Defined in: [src/base/servicetypes.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L135)

Number of records to skip (offset) for paging.

***

### Sort?

> `optional` **Sort**: `string`[]

Defined in: [src/base/servicetypes.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L141)

Sort expressions, e.g. `["Name ASC", "Age DESC"]`.

***

### Take?

> `optional` **Take**: `number`

Defined in: [src/base/servicetypes.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L137)

Maximum number of records to take (page size). Omit or 0 for server default.

***

### TimeZone?

> `optional` **TimeZone**: `string`

Defined in: [src/base/servicetypes.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L180)

The time zone of the user, an IANA one like `Europe/Istanbul`, as `Intl.DateTimeFormat().resolvedOptions().timeZone`
gives. It tells where the days start for the intervals of `GroupBy`, so the dates and times of the fields that are UTC
are grouped by the days the user sees. It doesn't change the filters, or the dates that are returned.
