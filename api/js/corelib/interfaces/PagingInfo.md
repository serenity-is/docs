[@serenity-is/corelib](../README.md) / PagingInfo

# Interface: PagingInfo

Defined in: [src/slick/iremoteview.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L289)

Information about the current paging state of the view

## Properties

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

Number of rows displayed per page

***

### totalCount

> **totalCount**: `number`

Defined in: [src/slick/iremoteview.ts:301](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L301)

Total number of items available
