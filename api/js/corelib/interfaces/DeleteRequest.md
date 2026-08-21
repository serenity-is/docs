[@serenity-is/corelib](../README.md) / DeleteRequest

# Interface: DeleteRequest

Defined in: [src/base/servicetypes.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L59)

Request DTO for `Delete` handlers (soft or hard delete depending on row / handler).

## Extends

- [`ServiceRequest`](ServiceRequest.md)

## Properties

### EntityId?

> `optional` **EntityId**: `any`

Defined in: [src/base/servicetypes.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L61)

Primary key of the entity to delete.
