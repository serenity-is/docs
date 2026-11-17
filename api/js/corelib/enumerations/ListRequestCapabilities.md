[@serenity-is/corelib](../README.md) / ListRequestCapabilities

# Enumeration: ListRequestCapabilities

Defined in: [src/base/servicetypes.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L269)

Specifies the capabilities of a list request handler.

## Enumeration Members

### AggregateOptions

> **AggregateOptions**: `983040`

Defined in: [src/base/servicetypes.ts:322](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L322)

Combined aggregate, group, entity exclusion and time zone options. Only the entity exclusion is in ListHandler,
and all of them are in ProListHandler.

***

### Aggregates

> **Aggregates**: `65536`

Defined in: [src/base/servicetypes.ts:311](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L311)

The handler calculates Aggregates from all the rows the request matches.

***

### Baseline

> **Baseline**: `327679`

Defined in: [src/base/servicetypes.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L329)

Stable baseline for current ListRequest capabilities. Do not add future capabilities
to this value; they require explicit opt-in.

***

### ColumnOptions

> **ColumnOptions**: `1792`

Defined in: [src/base/servicetypes.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L297)

Combined column-selection, include-column, and exclude-column options.

***

### ColumnSelection

> **ColumnSelection**: `256`

Defined in: [src/base/servicetypes.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L291)

The source applies ColumnSelection.

***

### ContainsField

> **ContainsField**: `2`

Defined in: [src/base/servicetypes.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L275)

The source applies ContainsField together with ContainsText.

***

### ContainsText

> **ContainsText**: `1`

Defined in: [src/base/servicetypes.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L273)

The source applies ContainsText.

***

### Criteria

> **Criteria**: `8`

Defined in: [src/base/servicetypes.ts:279](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L279)

The source applies Criteria.

***

### DistinctFields

> **DistinctFields**: `2048`

Defined in: [src/base/servicetypes.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L299)

The source applies DistinctFields.

***

### EqualityFilter

> **EqualityFilter**: `4`

Defined in: [src/base/servicetypes.ts:277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L277)

The source applies EqualityFilter.

***

### ExcludeColumns

> **ExcludeColumns**: `1024`

Defined in: [src/base/servicetypes.ts:295](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L295)

The source applies ExcludeColumns.

***

### ExcludeEntities

> **ExcludeEntities**: `262144`

Defined in: [src/base/servicetypes.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L315)

The handler honors ExcludeEntities.

***

### ExcludeTotalCount

> **ExcludeTotalCount**: `16384`

Defined in: [src/base/servicetypes.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L305)

The source honors ExcludeTotalCount.

***

### ExportColumns

> **ExportColumns**: `4096`

Defined in: [src/base/servicetypes.ts:301](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L301)

The source applies ExportColumns.

***

### FilteringOptions

> **FilteringOptions**: `15`

Defined in: [src/base/servicetypes.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L281)

Combined text-search, equality-filter, and criteria options.

***

### GroupBy

> **GroupBy**: `131072`

Defined in: [src/base/servicetypes.ts:313](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L313)

The handler calculates the aggregates of the groups of GroupBy.

***

### IncludeColumns

> **IncludeColumns**: `512`

Defined in: [src/base/servicetypes.ts:293](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L293)

The source applies IncludeColumns.

***

### IncludeDeleted

> **IncludeDeleted**: `128`

Defined in: [src/base/servicetypes.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L289)

The source applies IncludeDeleted.

***

### IncludeMore

> **IncludeMore**: `32768`

Defined in: [src/base/servicetypes.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L307)

The handler supports the IncludeMore request option.

***

### ListHandler

> **ListHandler**: `327679`

Defined in: [src/base/servicetypes.ts:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L336)

The capabilities of ListRequestHandler itself, without the behaviors of Serenity.Pro.Extensions. Currently
equivalent to Baseline. May include capabilities added to it in the future.

***

### Localize

> **Localize**: `8192`

Defined in: [src/base/servicetypes.ts:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L303)

The source applies Localize.

***

### None

> **None**: `0`

Defined in: [src/base/servicetypes.ts:271](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L271)

No ListRequest properties are supported.

***

### PagingOptions

> **PagingOptions**: `49248`

Defined in: [src/base/servicetypes.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L309)

Combined paging options, including the IncludeMore option.

***

### ProListHandler

> **ProListHandler**: `1048575`

Defined in: [src/base/servicetypes.ts:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L341)

The capabilities of ListRequestHandler with the behaviors of Serenity.Pro.Extensions, which are the ones of
ListHandler and AggregateOptions. May include capabilities added to them in the future.

***

### Skip

> **Skip**: `32`

Defined in: [src/base/servicetypes.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L285)

The source applies Skip.

***

### Sort

> **Sort**: `16`

Defined in: [src/base/servicetypes.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L283)

The source applies sorting.

***

### SourceAdapter

> **SourceAdapter**: `1034367`

Defined in: [src/base/servicetypes.ts:324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L324)

Capabilities supported by the in-memory list request source adapter by default.

***

### Take

> **Take**: `64`

Defined in: [src/base/servicetypes.ts:287](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L287)

The source applies Take.

***

### TimeZone

> **TimeZone**: `524288`

Defined in: [src/base/servicetypes.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L317)

The handler groups the dates by the days of the TimeZone of the request.
