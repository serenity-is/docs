[@serenity-is/corelib](../README.md) / CaptureOperationType

# Enumeration: CaptureOperationType

Defined in: [src/types/captureoperationtype.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/captureoperationtype.ts#L8)

Operation type for data change capture (used by history / audit features).

## Enumeration Members

### Before

> **Before**: `0`

Defined in: [src/types/captureoperationtype.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/captureoperationtype.ts#L10)

Fired before the operation; allows cancellation or modification.

***

### Delete

> **Delete**: `1`

Defined in: [src/types/captureoperationtype.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/captureoperationtype.ts#L12)

Entity deletion.

***

### Insert

> **Insert**: `2`

Defined in: [src/types/captureoperationtype.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/captureoperationtype.ts#L14)

Entity insertion.

***

### Update

> **Update**: `3`

Defined in: [src/types/captureoperationtype.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/captureoperationtype.ts#L16)

Entity update.
