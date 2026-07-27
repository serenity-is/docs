[@serenity-is/corelib](../README.md) / RemoteViewOptions

# Interface: RemoteViewOptions\<TItem\>

Defined in: [src/slick/remoteview.ts:1280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1280)

Options for configuring a RemoteView instance

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### autoLoad?

> `optional` **autoLoad**: `boolean`

Defined in: [src/slick/remoteview.ts:1282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1282)

Automatically load data (call populate) on initialization

***

### contentType?

> `optional` **contentType**: `string`

Defined in: [src/slick/remoteview.ts:1284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1284)

HTTP content type for service requests

***

### dataType?

> `optional` **dataType**: `string`

Defined in: [src/slick/remoteview.ts:1286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1286)

Expected data type of the service response

***

### errormsg?

> `optional` **errormsg**: `string`

Defined in: [src/slick/remoteview.ts:1288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1288)

Error message to display when requests fail

***

### filter?

> `optional` **filter**: [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1290](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1290)

Filter criteria or function to apply to the data

***

### getItemMetadata()?

> `optional` **getItemMetadata**: (`item`, `row`) => `ItemMetadata`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1292](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1292)

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

Defined in: [src/slick/remoteview.ts:1294](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1294)

Provider for group item metadata in grouped views

***

### idField?

> `optional` **idField**: `string`

Defined in: [src/slick/remoteview.ts:1296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1296)

Name of the field containing unique item identifiers

***

### localSort?

> `optional` **localSort**: `boolean`

Defined in: [src/slick/remoteview.ts:1298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1298)

Whether to perform sorting locally instead of server-side

***

### method?

> `optional` **method**: `string`

Defined in: [src/slick/remoteview.ts:1300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1300)

HTTP method to use for service requests

***

### onAjaxCall?

> `optional` **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1302)

Callback function invoked before AJAX calls are made

***

### onProcessData?

> `optional` **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1304)

Callback function to process data received from the server

***

### onSubmit?

> `optional` **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1306)

Callback function invoked before submitting service requests

***

### params?

> `optional` **params**: `Record`\<`string`, `object`\>

Defined in: [src/slick/remoteview.ts:1308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1308)

Additional parameters to include in service requests

***

### rowsPerPage?

> `optional` **rowsPerPage**: `number`

Defined in: [src/slick/remoteview.ts:1310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1310)

Number of rows to display per page (0 for no paging)

***

### seekToPage?

> `optional` **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:1312](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1312)

Initial page number to seek to on first load

***

### sortBy?

> `optional` **sortBy**: `string` \| `string`[]

Defined in: [src/slick/remoteview.ts:1314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1314)

Initial sort criteria for the data

***

### url?

> `optional` **url**: `string`

Defined in: [src/slick/remoteview.ts:1316](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1316)

URL of the service endpoint for data requests
