[@serenity-is/corelib](../README.md) / RequestErrorInfo

# Interface: RequestErrorInfo

Defined in: [src/base/servicetypes.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L204)

HTTP-level error details supplied to [ServiceOptions.onError](ServiceOptions.md#onerror) alongside the service error payload.

## Properties

### responseText?

> `optional` **responseText**: `string`

Defined in: [src/base/servicetypes.ts:210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L210)

Raw response body text when the response could not be parsed as JSON.

***

### status?

> `optional` **status**: `number`

Defined in: [src/base/servicetypes.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L206)

HTTP status code (e.g. `403`, `500`).

***

### statusText?

> `optional` **statusText**: `string`

Defined in: [src/base/servicetypes.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L208)

HTTP status text (e.g. `"Forbidden"`).
