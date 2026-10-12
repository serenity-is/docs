[@serenity-is/corelib](../README.md) / ListRequestCapabilities

# Enumeration: ListRequestCapabilities

Defined in: [src/base/servicetypes.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L164)

Specifies the capabilities of a list request handler.

## Enumeration Members

### Baseline

> **Baseline**: `65535`

Defined in: [src/base/servicetypes.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L211)

Stable baseline for current ListRequest capabilities. Do not add future capabilities
to this value; they require explicit opt-in.

***

### ColumnOptions

> **ColumnOptions**: `1792`

Defined in: [src/base/servicetypes.ts:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L192)

Combined column-selection, include-column, and exclude-column options.

***

### ColumnSelection

> **ColumnSelection**: `256`

Defined in: [src/base/servicetypes.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L186)

The source applies ColumnSelection.

***

### ContainsField

> **ContainsField**: `2`

Defined in: [src/base/servicetypes.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L170)

The source applies ContainsField together with ContainsText.

***

### ContainsText

> **ContainsText**: `1`

Defined in: [src/base/servicetypes.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L168)

The source applies ContainsText.

***

### Criteria

> **Criteria**: `8`

Defined in: [src/base/servicetypes.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L174)

The source applies Criteria.

***

### DistinctFields

> **DistinctFields**: `2048`

Defined in: [src/base/servicetypes.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L194)

The source applies DistinctFields.

***

### EqualityFilter

> **EqualityFilter**: `4`

Defined in: [src/base/servicetypes.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L172)

The source applies EqualityFilter.

***

### ExcludeColumns

> **ExcludeColumns**: `1024`

Defined in: [src/base/servicetypes.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L190)

The source applies ExcludeColumns.

***

### ExcludeTotalCount

> **ExcludeTotalCount**: `16384`

Defined in: [src/base/servicetypes.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L200)

The source honors ExcludeTotalCount.

***

### ExportColumns

> **ExportColumns**: `4096`

Defined in: [src/base/servicetypes.ts:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L196)

The source applies ExportColumns.

***

### FilteringOptions

> **FilteringOptions**: `15`

Defined in: [src/base/servicetypes.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L176)

Combined text-search, equality-filter, and criteria options.

***

### IncludeColumns

> **IncludeColumns**: `512`

Defined in: [src/base/servicetypes.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L188)

The source applies IncludeColumns.

***

### IncludeDeleted

> **IncludeDeleted**: `128`

Defined in: [src/base/servicetypes.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L184)

The source applies IncludeDeleted.

***

### IncludeMore

> **IncludeMore**: `32768`

Defined in: [src/base/servicetypes.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L202)

The handler supports the IncludeMore request option.

***

### Localize

> **Localize**: `8192`

Defined in: [src/base/servicetypes.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L198)

The source applies Localize.

***

### None

> **None**: `0`

Defined in: [src/base/servicetypes.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L166)

No ListRequest properties are supported.

***

### PagingOptions

> **PagingOptions**: `49248`

Defined in: [src/base/servicetypes.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L204)

Combined paging options, including the IncludeMore option.

***

### Skip

> **Skip**: `32`

Defined in: [src/base/servicetypes.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L180)

The source applies Skip.

***

### Sort

> **Sort**: `16`

Defined in: [src/base/servicetypes.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L178)

The source applies sorting.

***

### SourceAdapter

> **SourceAdapter**: `51327`

Defined in: [src/base/servicetypes.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L206)

Capabilities supported by the in-memory list request source adapter by default.

***

### Take

> **Take**: `64`

Defined in: [src/base/servicetypes.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L182)

The source applies Take.
