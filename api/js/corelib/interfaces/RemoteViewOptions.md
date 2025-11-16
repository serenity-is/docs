[corelib](../README.md) / RemoteViewOptions

# Interface: RemoteViewOptions\<TItem\>

Defined in: [src/slick/remoteview.ts:1492](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1492)

Options for configuring a RemoteView instance

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### autoLoad?

> `optional` **autoLoad**: `boolean`

Defined in: [src/slick/remoteview.ts:1494](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1494)

Automatically load data (call populate) on initialization

***

### contentType?

> `optional` **contentType**: `string`

Defined in: [src/slick/remoteview.ts:1496](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1496)

HTTP content type for service requests

***

### dataType?

> `optional` **dataType**: `string`

Defined in: [src/slick/remoteview.ts:1498](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1498)

Expected data type of the service response

***

### errormsg?

> `optional` **errormsg**: `string`

Defined in: [src/slick/remoteview.ts:1500](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1500)

Error message to display when requests fail

***

### filter?

> `optional` **filter**: [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1502)

Filter criteria or function to apply to the data

***

### getItemMetadata()?

> `optional` **getItemMetadata**: (`item`, `row`) => `ItemMetadata`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1504](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1504)

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

Defined in: [src/slick/remoteview.ts:1506](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1506)

Provider for group item metadata in grouped views

***

### idField?

> `optional` **idField**: `string`

Defined in: [src/slick/remoteview.ts:1508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1508)

Name of the field containing unique item identifiers

***

### localSort?

> `optional` **localSort**: `boolean`

Defined in: [src/slick/remoteview.ts:1510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1510)

Whether to perform sorting locally instead of server-side

***

### method?

> `optional` **method**: `string`

Defined in: [src/slick/remoteview.ts:1512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1512)

HTTP method to use for service requests

***

### onAjaxCall?

> `optional` **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1514)

Callback function invoked before AJAX calls are made

***

### onProcessData?

> `optional` **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1516](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1516)

Callback function to process data received from the server

***

### onSubmit?

> `optional` **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1518](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1518)

Callback function invoked before submitting service requests

***

### params?

> `optional` **params**: `Record`\<`string`, `object`\>

Defined in: [src/slick/remoteview.ts:1520](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1520)

Additional parameters to include in service requests

***

### rowsPerPage?

> `optional` **rowsPerPage**: `number`

Defined in: [src/slick/remoteview.ts:1522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1522)

Number of rows to display per page (0 for no paging)

***

### seekToPage?

> `optional` **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:1524](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1524)

Initial page number to seek to on first load

***

### sortBy?

> `optional` **sortBy**: `string` \| `string`[]

Defined in: [src/slick/remoteview.ts:1526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1526)

Initial sort criteria for the data

***

### url?

> `optional` **url**: `string`

Defined in: [src/slick/remoteview.ts:1528](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1528)

URL of the service endpoint for data requests
