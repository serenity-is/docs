[@serenity-is/corelib](../README.md) / RemoteViewOptions

# Interface: RemoteViewOptions\<TItem\>

Defined in: [src/slick/remoteview.ts:1529](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1529)

Options for configuring a RemoteView instance

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### autoLoad?

> `optional` **autoLoad**: `boolean`

Defined in: [src/slick/remoteview.ts:1531](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1531)

Automatically load data (call populate) on initialization

***

### contentType?

> `optional` **contentType**: `string`

Defined in: [src/slick/remoteview.ts:1533](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1533)

HTTP content type for service requests

***

### dataType?

> `optional` **dataType**: `string`

Defined in: [src/slick/remoteview.ts:1535](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1535)

Expected data type of the service response

***

### errormsg?

> `optional` **errormsg**: `string`

Defined in: [src/slick/remoteview.ts:1537](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1537)

Error message to display when requests fail

***

### filter?

> `optional` **filter**: [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1539](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1539)

Filter criteria or function to apply to the data

***

### getItemMetadata()?

> `optional` **getItemMetadata**: (`item`, `row`) => `ItemMetadata`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1541](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1541)

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

Defined in: [src/slick/remoteview.ts:1543](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1543)

Provider for group item metadata in grouped views

***

### idField?

> `optional` **idField**: `string`

Defined in: [src/slick/remoteview.ts:1545](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1545)

Name of the field containing unique item identifiers

***

### localSort?

> `optional` **localSort**: `boolean`

Defined in: [src/slick/remoteview.ts:1547](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1547)

Whether to perform sorting locally instead of server-side

***

### method?

> `optional` **method**: `string`

Defined in: [src/slick/remoteview.ts:1549](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1549)

HTTP method to use for service requests

***

### onAjaxCall?

> `optional` **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1551)

Callback function invoked before AJAX calls are made

***

### onProcessData?

> `optional` **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1553)

Callback function to process data received from the server

***

### onSubmit?

> `optional` **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1555](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1555)

Callback function invoked before submitting service requests

***

### params?

> `optional` **params**: `Record`\<`string`, `object`\>

Defined in: [src/slick/remoteview.ts:1557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1557)

Additional parameters to include in service requests

***

### rowsPerPage?

> `optional` **rowsPerPage**: `number`

Defined in: [src/slick/remoteview.ts:1559](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1559)

Number of rows to display per page (0 for no paging)

***

### seekToPage?

> `optional` **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:1561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1561)

Initial page number to seek to on first load

***

### sortBy?

> `optional` **sortBy**: `string` \| `string`[]

Defined in: [src/slick/remoteview.ts:1563](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1563)

Initial sort criteria for the data

***

### url?

> `optional` **url**: `string`

Defined in: [src/slick/remoteview.ts:1565](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1565)

URL of the service endpoint for data requests
