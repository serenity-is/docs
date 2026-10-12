[@serenity-is/corelib](../README.md) / RemoteViewOptions

# Interface: RemoteViewOptions\<TItem\>

Defined in: [src/slick/remoteview.ts:1544](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1544)

Options for configuring a RemoteView instance

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### autoLoad?

> `optional` **autoLoad**: `boolean`

Defined in: [src/slick/remoteview.ts:1546](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1546)

Automatically load data (call populate) on initialization

***

### contentType?

> `optional` **contentType**: `string`

Defined in: [src/slick/remoteview.ts:1548](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1548)

HTTP content type for service requests

***

### dataType?

> `optional` **dataType**: `string`

Defined in: [src/slick/remoteview.ts:1550](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1550)

Expected data type of the service response

***

### errormsg?

> `optional` **errormsg**: `string`

Defined in: [src/slick/remoteview.ts:1552](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1552)

Error message to display when requests fail

***

### filter?

> `optional` **filter**: [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1554](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1554)

Filter criteria or function to apply to the data

***

### getItemMetadata()?

> `optional` **getItemMetadata**: (`item`, `row`) => `ItemMetadata`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1556](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1556)

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

Defined in: [src/slick/remoteview.ts:1558](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1558)

Provider for group item metadata in grouped views

***

### idField?

> `optional` **idField**: `string`

Defined in: [src/slick/remoteview.ts:1560](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1560)

Name of the field containing unique item identifiers

***

### localSort?

> `optional` **localSort**: `boolean`

Defined in: [src/slick/remoteview.ts:1562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1562)

Whether to perform sorting locally instead of server-side

***

### method?

> `optional` **method**: `string`

Defined in: [src/slick/remoteview.ts:1564](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1564)

HTTP method to use for service requests

***

### onAjaxCall?

> `optional` **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1566)

Callback function invoked before AJAX calls are made

***

### onProcessData?

> `optional` **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1568](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1568)

Callback function to process data received from the server

***

### onSubmit?

> `optional` **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1570)

Callback function invoked before submitting service requests

***

### params?

> `optional` **params**: `Record`\<`string`, `object`\>

Defined in: [src/slick/remoteview.ts:1572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1572)

Additional parameters to include in service requests

***

### rowsPerPage?

> `optional` **rowsPerPage**: `number`

Defined in: [src/slick/remoteview.ts:1574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1574)

Number of rows to display per page (0 for no paging)

***

### seekToPage?

> `optional` **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:1576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1576)

Initial page number to seek to on first load

***

### sortBy?

> `optional` **sortBy**: `string` \| `string`[]

Defined in: [src/slick/remoteview.ts:1578](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1578)

Initial sort criteria for the data

***

### url?

> `optional` **url**: `string`

Defined in: [src/slick/remoteview.ts:1580](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1580)

URL of the service endpoint for data requests
