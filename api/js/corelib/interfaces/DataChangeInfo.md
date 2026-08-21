[@serenity-is/corelib](../README.md) / DataChangeInfo

# Interface: DataChangeInfo

Defined in: [src/types/datachangeinfo.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/datachangeinfo.ts#L7)

Event payload broadcast when an entity is inserted / updated / deleted via a dialog or grid.
Listen via bubbled `datachange` events or [SubDialogHelper](../@serenity-is/namespaces/SubDialogHelper/README.md).

## Extends

- `Event`

## Properties

### entity

> **entity**: `any`

Defined in: [src/types/datachangeinfo.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/datachangeinfo.ts#L13)

Full entity payload, if available.

***

### entityId

> **entityId**: `any`

Defined in: [src/types/datachangeinfo.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/datachangeinfo.ts#L11)

Primary key of the affected entity, if available.

***

### operationType

> **operationType**: `string`

Defined in: [src/types/datachangeinfo.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/datachangeinfo.ts#L9)

Operation that triggered the event (e.g. insert / update / delete).
