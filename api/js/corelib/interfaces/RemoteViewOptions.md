[@serenity-is/corelib](../README.md) / RemoteViewOptions

# Interface: RemoteViewOptions\<TItem\>

Defined in: [src/slick/remoteview.ts:1910](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1910)

Options for configuring a RemoteView instance

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### autoLoad?

> `optional` **autoLoad**: `boolean`

Defined in: [src/slick/remoteview.ts:1912](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1912)

Automatically load data (call populate) on initialization

***

### contentType?

> `optional` **contentType**: `string`

Defined in: [src/slick/remoteview.ts:1914](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1914)

HTTP content type for service requests

***

### dataType?

> `optional` **dataType**: `string`

Defined in: [src/slick/remoteview.ts:1916](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1916)

Expected data type of the service response

***

### errormsg?

> `optional` **errormsg**: `string`

Defined in: [src/slick/remoteview.ts:1918](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1918)

Error message to display when requests fail

***

### filter?

> `optional` **filter**: [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1920](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1920)

Filter criteria or function to apply to the data

***

### getItemMetadata()?

> `optional` **getItemMetadata**: (`item`, `row`) => `ItemMetadata`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1922](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1922)

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

Defined in: [src/slick/remoteview.ts:1924](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1924)

Provider for group item metadata in grouped views

***

### idField?

> `optional` **idField**: `string`

Defined in: [src/slick/remoteview.ts:1926](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1926)

Name of the field containing unique item identifiers

***

### indeterminatePaging?

> `optional` **indeterminatePaging**: `boolean`

Defined in: [src/slick/remoteview.ts:1950](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1950)

Whether to page without the total number of the rows, by asking the server whether there are more rows after the page,
which is faster for large tables. Default is false.

***

### localSort?

> `optional` **localSort**: `boolean`

Defined in: [src/slick/remoteview.ts:1928](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1928)

Whether to perform sorting locally instead of server-side

***

### method?

> `optional` **method**: `string`

Defined in: [src/slick/remoteview.ts:1930](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1930)

HTTP method to use for service requests

***

### onAjaxCall?

> `optional` **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1932](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1932)

Callback function invoked before AJAX calls are made

***

### onProcessData?

> `optional` **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1934](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1934)

Callback function to process data received from the server

***

### onSubmit?

> `optional` **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1936](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1936)

Callback function invoked before submitting service requests

***

### params?

> `optional` **params**: `Record`\<`string`, `object`\>

Defined in: [src/slick/remoteview.ts:1938](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1938)

Additional parameters to include in service requests

***

### rowsPerPage?

> `optional` **rowsPerPage**: `number`

Defined in: [src/slick/remoteview.ts:1940](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1940)

Number of rows to display per page (0 for no paging)

***

### seekToPage?

> `optional` **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:1952](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1952)

Initial page number to seek to on first load

***

### serverAggregates?

> `optional` **serverAggregates**: `boolean`

Defined in: [src/slick/remoteview.ts:1945](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1945)

Whether to ask the server for the aggregates of the summary options, calculated from all the rows the request
matches and not only from the current page, which only a server that supports them returns. Default is false.

***

### sortBy?

> `optional` **sortBy**: `string` \| `string`[]

Defined in: [src/slick/remoteview.ts:1954](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1954)

Initial sort criteria for the data

***

### url?

> `optional` **url**: `string`

Defined in: [src/slick/remoteview.ts:1956](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1956)

URL of the service endpoint for data requests
