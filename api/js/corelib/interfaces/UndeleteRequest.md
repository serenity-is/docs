[@serenity-is/corelib](../README.md) / UndeleteRequest

# Interface: UndeleteRequest

Defined in: [src/base/servicetypes.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L73)

Request DTO for `Undelete` handlers (restores a soft-deleted row).

## Extends

- [`ServiceRequest`](ServiceRequest.md)

## Properties

### EntityId?

> `optional` **EntityId**: `any`

Defined in: [src/base/servicetypes.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L75)

Primary key of the entity to undelete.
