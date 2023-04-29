[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](corelib_q.md) / ErrorHandling

# Namespace: ErrorHandling

[corelib/q](corelib_q.md).ErrorHandling

## Table of contents

### Functions

- [runtimeErrorHandler](corelib_q.ErrorHandling.md#runtimeerrorhandler)
- [showServiceError](corelib_q.ErrorHandling.md#showserviceerror)

## Functions

### runtimeErrorHandler

▸ **runtimeErrorHandler**(`message`, `filename?`, `lineno?`, `colno?`, `error?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `filename?` | `string` |
| `lineno?` | `number` |
| `colno?` | `number` |
| `error?` | `Error` |

#### Returns

`void`

#### Defined in

[src/q/errorhandling.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/errorhandling.ts#line&#x3D;23)

___

### showServiceError

▸ **showServiceError**(`error`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `error` | [`ServiceError`](../interfaces/corelib_q.ServiceError.md) |

#### Returns

`void`

#### Defined in

[src/q/errorhandling.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/errorhandling.ts#line&#x3D;8)
