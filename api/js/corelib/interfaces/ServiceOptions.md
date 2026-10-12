[@serenity-is/corelib](../README.md) / ServiceOptions

# Interface: ServiceOptions\<TResponse\>

Defined in: [src/base/servicetypes.ts:277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L277)

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

Defined in: [src/base/servicetypes.ts:279](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L279)

When true (default), a `403` with a `Location` header triggers a top-window redirect.

#### Default Value

`true`

***

### async?

> `optional` **async**: `boolean`

Defined in: [src/base/servicetypes.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L281)

When `false` a synchronous XHR is used (blocks the UI). Prefer `true` (default).

#### Default Value

`true`

***

### blockUI?

> `optional` **blockUI**: `boolean`

Defined in: [src/base/servicetypes.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L283)

When true (default) the UI is blocked with a loading indicator for the duration of the request.

#### Default Value

`true`

***

### errorMode?

> `optional` **errorMode**: `"none"` \| `"alert"` \| `"notification"`

Defined in: [src/base/servicetypes.ts:293](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L293)

How service errors are surfaced to the user. `"alert"` shows a dialog, `"notification"` shows a toast, `"none"` suppresses default handling.

***

### headers?

> `optional` **headers**: `Record`\<`string`, `string`\>

Defined in: [src/base/servicetypes.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L285)

Extra HTTP headers merged with defaults (`Accept: application/json`, `Content-Type: application/json`, `X-CSRF-TOKEN` when same-origin).

#### Overrides

`RequestInit.headers`

***

### request?

> `optional` **request**: `any`

Defined in: [src/base/servicetypes.ts:287](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L287)

Request DTO serialized as JSON in the POST body.

***

### service?

> `optional` **service**: `string`

Defined in: [src/base/servicetypes.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L289)

Service endpoint key (e.g. `"Administration/User/List"`). Resolved via `~/Services/` when relative. Mutually exclusive with `url`.

***

### url?

> `optional` **url**: `string`

Defined in: [src/base/servicetypes.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L291)

Absolute or `~/`-prefixed URL. When provided `service` is ignored.

## Methods

### onCleanup()?

> `optional` **onCleanup**(): `void`

Defined in: [src/base/servicetypes.ts:295](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L295)

Callback invoked after the request finishes regardless of success or failure (after `blockUI` is undone).

#### Returns

`void`

***

### onError()?

> `optional` **onError**(`response`, `info?`): `boolean` \| `void`

Defined in: [src/base/servicetypes.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L302)

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

Defined in: [src/base/servicetypes.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L307)

Success callback invoked with the parsed response when `Error` is not set.

#### Parameters

##### response

`TResponse`

Successful service response.

#### Returns

`void`
