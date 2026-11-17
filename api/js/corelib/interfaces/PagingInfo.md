[@serenity-is/corelib](../README.md) / PagingInfo

# Interface: PagingInfo

Defined in: [src/slick/iremoteview.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L289)

Information about the current paging state of the view

## Properties

### actualRowsPerPage

> **actualRowsPerPage**: `number`

Defined in: [src/slick/iremoteview.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L302)

Number of rows actually used by the server for the current page. May differ from
[rowsPerPage](#rowsperpage) when the server applies a maximum or default page size.

***

### dataView

> **dataView**: [`IRemoteView`](IRemoteView.md)\<`any`\>

Defined in: [src/slick/iremoteview.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L291)

Reference to the RemoteView instance

***

### error

> **error**: `string`

Defined in: [src/slick/iremoteview.ts:293](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L293)

Current error message, if any

***

### hasMore?

> `optional` **hasMore**: `boolean`

Defined in: [src/slick/iremoteview.ts:311](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L311)

Whether there are more rows after the current page, for a view that is [indeterminate](#indeterminate).

***

### indeterminate?

> `optional` **indeterminate**: `boolean`

Defined in: [src/slick/iremoteview.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L309)

Whether the view pages without knowing the total number of the rows, so only whether there are more after the page.

***

### loading

> **loading**: `boolean`

Defined in: [src/slick/iremoteview.ts:295](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L295)

Whether data is currently being loaded

***

### page

> **page**: `number`

Defined in: [src/slick/iremoteview.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L297)

Current page number (1-based)

***

### rowsPerPage

> **rowsPerPage**: `number`

Defined in: [src/slick/iremoteview.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L299)

Number of rows requested per page

***

### totalCount

> **totalCount**: `number`

Defined in: [src/slick/iremoteview.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L307)

Total number of items available, or the number of the rows known so far when the view is [indeterminate](#indeterminate), which
is more than the rows up to the current page only when there are more.
