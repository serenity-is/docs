[@serenity-is/corelib](../README.md) / ListResponse

# Interface: ListResponse\<TEntity\>

Defined in: [src/base/servicetypes.ts:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L350)

Response DTO for `List` handlers.

## Extends

- [`ServiceResponse`](ServiceResponse.md)

## Type Parameters

### TEntity

`TEntity`

Row / entity type of the listed records.

## Properties

### Aggregates?

> `optional` **Aggregates**: [`AggregateGroup`](AggregateGroup.md)

Defined in: [src/base/servicetypes.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L367)

The aggregates of all the rows the request matches, and of their groups, when requested. Not set when the handler
doesn't support aggregates, in which case they can only be calculated from the returned entities.

***

### Entities?

> `optional` **Entities**: `TEntity`[]

Defined in: [src/base/servicetypes.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L352)

Page of entities matching the request.

***

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L27)

Error information when the request failed; `undefined` on success.

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)

***

### More?

> `optional` **More**: `boolean`

Defined in: [src/base/servicetypes.ts:362](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L362)

Whether more records are available beyond the returned page, when requested.

***

### Skip?

> `optional` **Skip**: `number`

Defined in: [src/base/servicetypes.ts:358](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L358)

Echo of `Skip` from the request.

***

### Take?

> `optional` **Take**: `number`

Defined in: [src/base/servicetypes.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L360)

Echo of `Take` from the request.

***

### TotalCount?

> `optional` **TotalCount**: `number`

Defined in: [src/base/servicetypes.ts:356](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L356)

Total number of records matching the filter (before paging), unless `ExcludeTotalCount` was set.

***

### Values?

> `optional` **Values**: `any`[]

Defined in: [src/base/servicetypes.ts:354](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L354)

Alternative `Values` array used by some handlers that return raw values instead of entities.
