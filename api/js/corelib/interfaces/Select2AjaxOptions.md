[corelib](../README.md) / Select2AjaxOptions

# Interface: Select2AjaxOptions

Defined in: [src/ui/editors/select2.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L37)

## Extends

- `RequestInit`

## Properties

### data()?

> `optional` **data**: (`p1`, `p2`, `p3`) => `any`

Defined in: [src/ui/editors/select2.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L41)

#### Parameters

##### p1

`string`

##### p2

`number`

##### p3

`any`

#### Returns

`any`

***

### headers?

> `optional` **headers**: `Record`\<`string`, `string`\>

Defined in: [src/ui/editors/select2.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L38)

A Headers object, an object literal, or an array of two-item arrays to set request's headers.

#### Overrides

`RequestInit.headers`

***

### params?

> `optional` **params**: `any`

Defined in: [src/ui/editors/select2.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L43)

***

### quietMillis?

> `optional` **quietMillis**: `number`

Defined in: [src/ui/editors/select2.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L40)

***

### results()?

> `optional` **results**: (`p1`, `p2`, `p3`) => `any`

Defined in: [src/ui/editors/select2.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L42)

#### Parameters

##### p1

`any`

##### p2

`number`

##### p3

`any`

#### Returns

`any`

***

### url?

> `optional` **url**: `string` \| (`term`, `page`, `context`) => `string`

Defined in: [src/ui/editors/select2.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L39)

## Methods

### onError()?

> `optional` **onError**(`response`, `info?`): `boolean` \| `void`

Defined in: [src/ui/editors/select2.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L44)

#### Parameters

##### response

`any`

##### info?

`any`

#### Returns

`boolean` \| `void`

***

### onSuccess()?

> `optional` **onSuccess**(`response`): `void`

Defined in: [src/ui/editors/select2.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L45)

#### Parameters

##### response

`any`

#### Returns

`void`
