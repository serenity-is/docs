[@serenity-is/corelib](../README.md) / ServiceOptions

# Interface: ServiceOptions\<TResponse\>

Defined in: [src/base/servicetypes.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L102)

## Extends

- `RequestInit`

## Type Parameters

### TResponse

`TResponse` *extends* [`ServiceResponse`](ServiceResponse.md)

## Properties

### allowRedirect?

> `optional` **allowRedirect**: `boolean`

Defined in: [src/base/servicetypes.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L103)

***

### async?

> `optional` **async**: `boolean`

Defined in: [src/base/servicetypes.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L104)

***

### blockUI?

> `optional` **blockUI**: `boolean`

Defined in: [src/base/servicetypes.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L105)

***

### errorMode?

> `optional` **errorMode**: `"none"` \| `"alert"` \| `"notification"`

Defined in: [src/base/servicetypes.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L110)

***

### headers?

> `optional` **headers**: `Record`\<`string`, `string`\>

Defined in: [src/base/servicetypes.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L106)

A Headers object, an object literal, or an array of two-item arrays to set request's headers.

#### Overrides

`RequestInit.headers`

***

### request?

> `optional` **request**: `any`

Defined in: [src/base/servicetypes.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L107)

***

### service?

> `optional` **service**: `string`

Defined in: [src/base/servicetypes.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L108)

***

### url?

> `optional` **url**: `string`

Defined in: [src/base/servicetypes.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L109)

## Methods

### onCleanup()?

> `optional` **onCleanup**(): `void`

Defined in: [src/base/servicetypes.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L111)

#### Returns

`void`

***

### onError()?

> `optional` **onError**(`response`, `info?`): `boolean` \| `void`

Defined in: [src/base/servicetypes.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L113)

Should return true if the error is handled (e.g. notification shown). Otherwise the error may be shown twice.

#### Parameters

##### response

`TResponse`

##### info?

[`RequestErrorInfo`](RequestErrorInfo.md)

#### Returns

`boolean` \| `void`

***

### onSuccess()?

> `optional` **onSuccess**(`response`): `void`

Defined in: [src/base/servicetypes.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L114)

#### Parameters

##### response

`TResponse`

#### Returns

`void`
