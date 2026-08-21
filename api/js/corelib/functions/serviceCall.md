[@serenity-is/corelib](../README.md) / serviceCall

# Function: serviceCall()

> **serviceCall**\<`TResponse`\>(`options`): `PromiseLike`\<`TResponse`\>

Defined in: [src/base/services.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L241)

Executes a Serenity service call.
Prefers `fetch` (async) when `options.async` is `true` (default); falls back to synchronous `XMLHttpRequest` when `async` is `false` (blocks the UI — avoid in new code).
Handles CSRF headers, `blockUI`, redirect handling, and delegates error display to the global error handler unless suppressed via `errorMode` or `onError`.

## Type Parameters

### TResponse

`TResponse` *extends* [`ServiceResponse`](../interfaces/ServiceResponse.md)

Service response type (extends [ServiceResponse](../interfaces/ServiceResponse.md)).

## Parameters

### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<`TResponse`\>

Service options including `service`/`url`, `request` payload and callbacks.

## Returns

`PromiseLike`\<`TResponse`\>

A `PromiseLike` that resolves with the parsed response on success or rejects with an enriched `Error` (with `kind` and `origin === "serviceCall"`) on failure.
