[@serenity-is/corelib](../README.md) / Select2AjaxOptions

# Interface: Select2AjaxOptions

Defined in: [src/ui/editors/select2.tsx:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L68)

Options for ajax-based Select2 queries.

## Extends

- `RequestInit`

## Properties

### data()?

> `optional` **data**: (`p1`, `p2`, `p3`) => `any`

Defined in: [src/ui/editors/select2.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L76)

Callback that builds the request data.

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

Defined in: [src/ui/editors/select2.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L70)

Request headers.

#### Overrides

`RequestInit.headers`

***

### params?

> `optional` **params**: `any`

Defined in: [src/ui/editors/select2.tsx:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L80)

Additional request parameters.

***

### quietMillis?

> `optional` **quietMillis**: `number`

Defined in: [src/ui/editors/select2.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L74)

Delay in milliseconds before the ajax request.

***

### results()?

> `optional` **results**: (`p1`, `p2`, `p3`) => `any`

Defined in: [src/ui/editors/select2.tsx:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L78)

Callback that processes the response.

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

Defined in: [src/ui/editors/select2.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L72)

The URL or a function returning it.

## Methods

### onError()?

> `optional` **onError**(`response`, `info?`): `boolean` \| `void`

Defined in: [src/ui/editors/select2.tsx:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L84)

Callback invoked when the ajax request fails.

#### Parameters

##### response

`any`

The error response payload.

##### info?

`any`

Additional error info.

#### Returns

`boolean` \| `void`

***

### onSuccess()?

> `optional` **onSuccess**(`response`): `void`

Defined in: [src/ui/editors/select2.tsx:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L87)

Callback invoked when the ajax request succeeds.

#### Parameters

##### response

`any`

The success response payload.

#### Returns

`void`
