[@serenity-is/corelib](../README.md) / serviceRequest

# Function: serviceRequest()

> **serviceRequest**\<`TResponse`\>(`service`, `request`?, `onSuccess`?, `options`?): `PromiseLike`\<`TResponse`\>

## Type Parameters

• **TResponse** *extends* [`ServiceResponse`](../interfaces/ServiceResponse.md)

## Parameters

### service

`string`

### request?

`any`

### onSuccess?

(`response`) => `void`

### options?

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<`TResponse`\>

## Returns

`PromiseLike`\<`TResponse`\>

## Defined in

[src/base/services.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L253)
