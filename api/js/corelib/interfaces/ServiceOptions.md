[@serenity-is/corelib](../README.md) / ServiceOptions

# Interface: ServiceOptions\<TResponse\>

## Extends

- `RequestInit`

## Type Parameters

• **TResponse** *extends* [`ServiceResponse`](ServiceResponse.md)

## Properties

### allowRedirect?

> `optional` **allowRedirect**: `boolean`

#### Defined in

[src/base/servicetypes.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L103)

***

### async?

> `optional` **async**: `boolean`

#### Defined in

[src/base/servicetypes.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L104)

***

### blockUI?

> `optional` **blockUI**: `boolean`

#### Defined in

[src/base/servicetypes.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L105)

***

### errorMode?

> `optional` **errorMode**: `"none"` \| `"alert"` \| `"notification"`

#### Defined in

[src/base/servicetypes.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L110)

***

### headers?

> `optional` **headers**: `Record`\<`string`, `string`\>

A Headers object, an object literal, or an array of two-item arrays to set request's headers.

#### Overrides

`RequestInit.headers`

#### Defined in

[src/base/servicetypes.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L106)

***

### request?

> `optional` **request**: `any`

#### Defined in

[src/base/servicetypes.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L107)

***

### service?

> `optional` **service**: `string`

#### Defined in

[src/base/servicetypes.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L108)

***

### url?

> `optional` **url**: `string`

#### Defined in

[src/base/servicetypes.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L109)

## Methods

### onCleanup()?

> `optional` **onCleanup**(): `void`

#### Returns

`void`

#### Defined in

[src/base/servicetypes.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L111)

***

### onError()?

> `optional` **onError**(`response`, `info`?): `boolean` \| `void`

Should return true if the error is handled (e.g. notification shown). Otherwise the error may be shown twice.

#### Parameters

##### response

`TResponse`

##### info?

[`RequestErrorInfo`](RequestErrorInfo.md)

#### Returns

`boolean` \| `void`

#### Defined in

[src/base/servicetypes.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L113)

***

### onSuccess()?

> `optional` **onSuccess**(`response`): `void`

#### Parameters

##### response

`TResponse`

#### Returns

`void`

#### Defined in

[src/base/servicetypes.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L114)
