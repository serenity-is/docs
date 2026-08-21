[@serenity-is/corelib](../README.md) / RetrieveRequest

# Interface: RetrieveRequest

Defined in: [src/base/servicetypes.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L179)

Request DTO for `Retrieve` handlers (single-entity fetch).

## Extends

- [`ServiceRequest`](ServiceRequest.md)

## Properties

### ColumnSelection?

> `optional` **ColumnSelection**: [`RetrieveColumnSelection`](../enumerations/RetrieveColumnSelection.md)

Defined in: [src/base/servicetypes.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L183)

Preset that controls which columns are returned. See [RetrieveColumnSelection](../enumerations/RetrieveColumnSelection.md).

***

### EntityId?

> `optional` **EntityId**: `any`

Defined in: [src/base/servicetypes.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L181)

Primary key of the entity to retrieve.

***

### ExcludeColumns?

> `optional` **ExcludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L187)

Explicit deny-list of columns to exclude.

***

### IncludeColumns?

> `optional` **IncludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L185)

Explicit allow-list of columns to include.
