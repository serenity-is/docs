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

[../base/dist/index.d.ts:547](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L547)

___

### async

• `Optional` **async**: `boolean`

#### Defined in

[../base/dist/index.d.ts:548](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L548)

___

### blockUI

• `Optional` **blockUI**: `boolean`

#### Defined in

[../base/dist/index.d.ts:549](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L549)

___

### headers

• `Optional` **headers**: `Record`\<`string`, `string`\>

#### Overrides

RequestInit.headers

#### Defined in

[../base/dist/index.d.ts:550](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L550)

___

### request

• `Optional` **request**: `any`

#### Defined in

[../base/dist/index.d.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L551)

___

### service

• `Optional` **service**: `string`

#### Defined in

[../base/dist/index.d.ts:552](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L552)

___

### url

• `Optional` **url**: `string`

#### Defined in

[../base/dist/index.d.ts:553](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L553)

## Methods

### onCleanup

▸ **onCleanup**(): `void`

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:554](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L554)

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

[../base/dist/index.d.ts:556](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L556)

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

[../base/dist/index.d.ts:557](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L557)
