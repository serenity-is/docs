[@serenity-is/corelib](../README.md) / ColumnSelection

# Enumeration: ColumnSelection

Defined in: [src/base/servicetypes.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L88)

Controls which columns are selected when listing entities.
Mirrors the server-side `ColumnSelection` enum and is used by `ListRequest.ColumnSelection`.

## Enumeration Members

### Details

> **Details**: `2`

Defined in: [src/base/servicetypes.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L94)

Detail view columns (more fields than `List`).

***

### IdOnly

> **IdOnly**: `4`

Defined in: [src/base/servicetypes.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L98)

Only the identity column.

***

### KeyOnly

> **KeyOnly**: `1`

Defined in: [src/base/servicetypes.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L92)

Only key (ID) columns.

***

### List

> **List**: `0`

Defined in: [src/base/servicetypes.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L90)

Default view columns (what the grid shows).

***

### Lookup

> **Lookup**: `5`

Defined in: [src/base/servicetypes.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L100)

Columns needed for lookup display (usually ID + display field).

***

### None

> **None**: `3`

Defined in: [src/base/servicetypes.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L96)

No columns (only aggregates / counts).
