[@serenity-is/corelib](../README.md) / PagingInfo

# Interface: PagingInfo

Defined in: [src/slick/iremoteview.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L273)

Information about the current paging state of the view

## Properties

### dataView

> **dataView**: [`IRemoteView`](IRemoteView.md)\<`any`\>

Defined in: [src/slick/iremoteview.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L275)

Reference to the RemoteView instance

***

### error

> **error**: `string`

Defined in: [src/slick/iremoteview.ts:277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L277)

Current error message, if any

***

### loading

> **loading**: `boolean`

Defined in: [src/slick/iremoteview.ts:279](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L279)

Whether data is currently being loaded

***

### page

> **page**: `number`

Defined in: [src/slick/iremoteview.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L281)

Current page number (1-based)

***

### rowsPerPage

> **rowsPerPage**: `number`

Defined in: [src/slick/iremoteview.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L283)

Number of rows displayed per page

***

### totalCount

> **totalCount**: `number`

Defined in: [src/slick/iremoteview.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L285)

Total number of items available
