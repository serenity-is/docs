[@serenity-is/corelib](../README.md) / ListResponse

# Interface: ListResponse\<TEntity\>

Defined in: [src/base/servicetypes.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L163)

Response DTO for `List` handlers.

## Extends

- [`ServiceResponse`](ServiceResponse.md)

## Type Parameters

### TEntity

`TEntity`

Row / entity type of the listed records.

## Properties

### Entities?

> `optional` **Entities**: `TEntity`[]

Defined in: [src/base/servicetypes.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L165)

Page of entities matching the request.

***

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L25)

Error information when the request failed; `undefined` on success.

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)

***

### Skip?

> `optional` **Skip**: `number`

Defined in: [src/base/servicetypes.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L171)

Echo of `Skip` from the request.

***

### Take?

> `optional` **Take**: `number`

Defined in: [src/base/servicetypes.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L173)

Echo of `Take` from the request.

***

### TotalCount?

> `optional` **TotalCount**: `number`

Defined in: [src/base/servicetypes.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L169)

Total number of records matching the filter (before paging), unless `ExcludeTotalCount` was set.

***

### Values?

> `optional` **Values**: `any`[]

Defined in: [src/base/servicetypes.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L167)

Alternative `Values` array used by some handlers that return raw values instead of entities.
