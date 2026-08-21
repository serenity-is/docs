[@serenity-is/corelib](../README.md) / serviceRequest

# Function: serviceRequest()

> **serviceRequest**\<`TResponse`\>(`service`, `request?`, `onSuccess?`, `options?`): `PromiseLike`\<`TResponse`\>

Defined in: [src/base/services.ts:319](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L319)

Convenience wrapper around [serviceCall](serviceCall.md) that takes a service key as the first argument.

## Type Parameters

### TResponse

`TResponse` *extends* [`ServiceResponse`](../interfaces/ServiceResponse.md)

Service response type.

## Parameters

### service

`string`

Service endpoint key (e.g. `"Administration/User/List"`) or full URL.

### request?

`any`

Request DTO serialized as the POST body.

### onSuccess?

(`response`) => `void`

Optional success callback invoked with the response before the promise resolves.

### options?

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<`TResponse`\>

Additional [ServiceOptions](../interfaces/ServiceOptions.md) merged with the above (e.g. `errorMode`, `blockUI`, `signal`).

## Returns

`PromiseLike`\<`TResponse`\>

A `PromiseLike` resolving to the service response.
