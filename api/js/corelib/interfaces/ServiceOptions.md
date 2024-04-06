[@serenity-is/corelib](../README.md) / ServiceOptions

# Interface: ServiceOptions\<TResponse\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TResponse` | extends [`ServiceResponse`](ServiceResponse.md) |

## Hierarchy

- `RequestInit`

  ↳ **`ServiceOptions`**

## Table of contents

### Properties

- [allowRedirect](ServiceOptions.md#allowredirect)
- [async](ServiceOptions.md#async)
- [blockUI](ServiceOptions.md#blockui)
- [headers](ServiceOptions.md#headers)
- [request](ServiceOptions.md#request)
- [service](ServiceOptions.md#service)
- [url](ServiceOptions.md#url)

### Methods

- [onCleanup](ServiceOptions.md#oncleanup)
- [onError](ServiceOptions.md#onerror)
- [onSuccess](ServiceOptions.md#onsuccess)

## Properties

### allowRedirect

• `Optional` **allowRedirect**: `boolean`

#### Defined in

[src/base/servicetypes.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L116)

___

### async

• `Optional` **async**: `boolean`

#### Defined in

[src/base/servicetypes.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L117)

___

### blockUI

• `Optional` **blockUI**: `boolean`

#### Defined in

[src/base/servicetypes.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L118)

___

### headers

• `Optional` **headers**: `Record`\<`string`, `string`\>

#### Overrides

RequestInit.headers

#### Defined in

[src/base/servicetypes.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L119)

___

### request

• `Optional` **request**: `any`

#### Defined in

[src/base/servicetypes.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L120)

___

### service

• `Optional` **service**: `string`

#### Defined in

[src/base/servicetypes.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L121)

___

### url

• `Optional` **url**: `string`

#### Defined in

[src/base/servicetypes.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L122)

## Methods

### onCleanup

▸ **onCleanup**(): `void`

#### Returns

`void`

#### Defined in

[src/base/servicetypes.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L123)

___

### onError

▸ **onError**(`response`, `info?`): `boolean` \| `void`

Should return true if the error is handled (e.g. notification shown). Otherwise the error may be shown twice.

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | `TResponse` |
| `info?` | [`RequestErrorInfo`](RequestErrorInfo.md) |

#### Returns

`boolean` \| `void`

#### Defined in

[src/base/servicetypes.ts:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L125)

___

### onSuccess

▸ **onSuccess**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | `TResponse` |

#### Returns

`void`

#### Defined in

[src/base/servicetypes.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L126)
