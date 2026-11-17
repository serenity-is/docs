[@serenity-is/corelib](../README.md) / RetrieveRequest

# Interface: RetrieveRequest

Defined in: [src/base/servicetypes.ts:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L373)

Request DTO for `Retrieve` handlers (single-entity fetch).

## Extends

- [`ServiceRequest`](ServiceRequest.md)

## Properties

### ColumnSelection?

> `optional` **ColumnSelection**: [`RetrieveColumnSelection`](../enumerations/RetrieveColumnSelection.md)

Defined in: [src/base/servicetypes.ts:377](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L377)

Preset that controls which columns are returned. See [RetrieveColumnSelection](../enumerations/RetrieveColumnSelection.md).

***

### EntityId?

> `optional` **EntityId**: `any`

Defined in: [src/base/servicetypes.ts:375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L375)

Primary key of the entity to retrieve.

***

### ExcludeColumns?

> `optional` **ExcludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:381](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L381)

Explicit deny-list of columns to exclude.

***

### IncludeColumns?

> `optional` **IncludeColumns**: `string`[]

Defined in: [src/base/servicetypes.ts:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L379)

Explicit allow-list of columns to include.
