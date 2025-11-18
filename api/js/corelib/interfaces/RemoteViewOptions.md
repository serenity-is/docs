[@serenity-is/corelib](../README.md) / RemoteViewOptions

# Interface: RemoteViewOptions\<TItem\>

Defined in: [src/slick/remoteview.ts:1260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1260)

Options for configuring a RemoteView instance

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### autoLoad?

> `optional` **autoLoad**: `boolean`

Defined in: [src/slick/remoteview.ts:1262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1262)

Automatically load data (call populate) on initialization

***

### contentType?

> `optional` **contentType**: `string`

Defined in: [src/slick/remoteview.ts:1264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1264)

HTTP content type for service requests

***

### dataType?

> `optional` **dataType**: `string`

Defined in: [src/slick/remoteview.ts:1266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1266)

Expected data type of the service response

***

### errormsg?

> `optional` **errormsg**: `string`

Defined in: [src/slick/remoteview.ts:1268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1268)

Error message to display when requests fail

***

### filter?

> `optional` **filter**: [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1270)

Filter criteria or function to apply to the data

***

### getItemMetadata()?

> `optional` **getItemMetadata**: (`item`, `row`) => `ItemMetadata`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1272)

Callback function to get metadata for individual items

#### Parameters

##### item

`TItem`

##### row

`number`

#### Returns

`ItemMetadata`\<`TItem`\>

***

### groupItemMetadataProvider?

> `optional` **groupItemMetadataProvider**: `GroupItemMetadataProvider`

Defined in: [src/slick/remoteview.ts:1274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1274)

Provider for group item metadata in grouped views

***

### idField?

> `optional` **idField**: `string`

Defined in: [src/slick/remoteview.ts:1276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1276)

Name of the field containing unique item identifiers

***

### localSort?

> `optional` **localSort**: `boolean`

Defined in: [src/slick/remoteview.ts:1278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1278)

Whether to perform sorting locally instead of server-side

***

### method?

> `optional` **method**: `string`

Defined in: [src/slick/remoteview.ts:1280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1280)

HTTP method to use for service requests

***

### onAjaxCall?

> `optional` **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1282)

Callback function invoked before AJAX calls are made

***

### onProcessData?

> `optional` **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1284)

Callback function to process data received from the server

***

### onSubmit?

> `optional` **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1286)

Callback function invoked before submitting service requests

***

### params?

> `optional` **params**: `Record`\<`string`, `object`\>

Defined in: [src/slick/remoteview.ts:1288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1288)

Additional parameters to include in service requests

***

### rowsPerPage?

> `optional` **rowsPerPage**: `number`

Defined in: [src/slick/remoteview.ts:1290](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1290)

Number of rows to display per page (0 for no paging)

***

### seekToPage?

> `optional` **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:1292](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1292)

Initial page number to seek to on first load

***

### sortBy?

> `optional` **sortBy**: `string` \| `string`[]

Defined in: [src/slick/remoteview.ts:1294](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1294)

Initial sort criteria for the data

***

### url?

> `optional` **url**: `string`

Defined in: [src/slick/remoteview.ts:1296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1296)

URL of the service endpoint for data requests
