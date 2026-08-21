[@serenity-is/corelib](../README.md) / ServiceOptions

# Interface: ServiceOptions\<TResponse\>

Defined in: [src/base/servicetypes.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L218)

Options for [serviceCall](../functions/serviceCall.md) / [serviceRequest](../functions/serviceRequest.md) / `serviceFetch`.
Extends the native `RequestInit` so any `fetch` option (e.g. `signal`, `cache`) can be passed through.

## Extends

- `RequestInit`

## Type Parameters

### TResponse

`TResponse` *extends* [`ServiceResponse`](ServiceResponse.md)

Expected service response type (must extend [ServiceResponse](ServiceResponse.md)).

## Properties

### allowRedirect?

> `optional` **allowRedirect**: `boolean`

Defined in: [src/base/servicetypes.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L220)

When true (default), a `403` with a `Location` header triggers a top-window redirect.

#### Default Value

`true`

***

### async?

> `optional` **async**: `boolean`

Defined in: [src/base/servicetypes.ts:222](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L222)

When `false` a synchronous XHR is used (blocks the UI). Prefer `true` (default).

#### Default Value

`true`

***

### blockUI?

> `optional` **blockUI**: `boolean`

Defined in: [src/base/servicetypes.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L224)

When true (default) the UI is blocked with a loading indicator for the duration of the request.

#### Default Value

`true`

***

### errorMode?

> `optional` **errorMode**: `"none"` \| `"alert"` \| `"notification"`

Defined in: [src/base/servicetypes.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L234)

How service errors are surfaced to the user. `"alert"` shows a dialog, `"notification"` shows a toast, `"none"` suppresses default handling.

***

### headers?

> `optional` **headers**: `Record`\<`string`, `string`\>

Defined in: [src/base/servicetypes.ts:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L226)

Extra HTTP headers merged with defaults (`Accept: application/json`, `Content-Type: application/json`, `X-CSRF-TOKEN` when same-origin).

#### Overrides

`RequestInit.headers`

***

### request?

> `optional` **request**: `any`

Defined in: [src/base/servicetypes.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L228)

Request DTO serialized as JSON in the POST body.

***

### service?

> `optional` **service**: `string`

Defined in: [src/base/servicetypes.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L230)

Service endpoint key (e.g. `"Administration/User/List"`). Resolved via `~/Services/` when relative. Mutually exclusive with `url`.

***

### url?

> `optional` **url**: `string`

Defined in: [src/base/servicetypes.ts:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L232)

Absolute or `~/`-prefixed URL. When provided `service` is ignored.

## Methods

### onCleanup()?

> `optional` **onCleanup**(): `void`

Defined in: [src/base/servicetypes.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L236)

Callback invoked after the request finishes regardless of success or failure (after `blockUI` is undone).

#### Returns

`void`

***

### onError()?

> `optional` **onError**(`response`, `info?`): `boolean` \| `void`

Defined in: [src/base/servicetypes.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L243)

Custom error handler. Return `true` to indicate the error was handled and suppress default error display.

#### Parameters

##### response

`TResponse`

Parsed service response (may be `null` for network / HTTP errors).

##### info?

[`RequestErrorInfo`](RequestErrorInfo.md)

HTTP-level error details.

#### Returns

`boolean` \| `void`

`true` if handled (prevents double notification), `false`/`void` to allow default handling.

***

### onSuccess()?

> `optional` **onSuccess**(`response`): `void`

Defined in: [src/base/servicetypes.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L248)

Success callback invoked with the parsed response when `Error` is not set.

#### Parameters

##### response

`TResponse`

Successful service response.

#### Returns

`void`
