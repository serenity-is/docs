[@serenity-is/corelib](../README.md) / RetrieveRequest

# Interface: RetrieveRequest

Defined in: [src/base/servicetypes.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L238)

Request DTO for `Retrieve` handlers (single-entity fetch).

## Extends

- [`ServiceRequest`](ServiceRequest.md)

## Properties

### ColumnSelection?

> `optional` **ColumnSelection**: [`RetrieveColumnSelection`](../enumerations/RetrieveColumnSelection.md)

Defined in: [src/base/servicetypes.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L242)

Preset that controls which columns are returned. See [RetrieveColumnSelection](../enumerations/RetrieveColumnSelection.md).

***

### EntityId?

> `optional` **EntityId**: `any`

Defined in: [src/base/servicetypes.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L240)

Primary key of the entity to retrieve.

***

### ExcludeColumns?

> `optional` **ExcludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L246)

Explicit deny-list of columns to exclude.

***

### IncludeColumns?

> `optional` **IncludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L244)

Explicit allow-list of columns to include.
