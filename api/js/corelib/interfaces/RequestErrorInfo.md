[@serenity-is/corelib](../README.md) / RequestErrorInfo

# Interface: RequestErrorInfo

Defined in: [src/base/servicetypes.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L263)

HTTP-level error details supplied to [ServiceOptions.onError](ServiceOptions.md#onerror) alongside the service error payload.

## Properties

### responseText?

> `optional` **responseText**: `string`

Defined in: [src/base/servicetypes.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L269)

Raw response body text when the response could not be parsed as JSON.

***

### status?

> `optional` **status**: `number`

Defined in: [src/base/servicetypes.ts:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L265)

HTTP status code (e.g. `403`, `500`).

***

### statusText?

> `optional` **statusText**: `string`

Defined in: [src/base/servicetypes.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L267)

HTTP status text (e.g. `"Forbidden"`).
