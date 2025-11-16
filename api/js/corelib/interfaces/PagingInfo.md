[serenity-is/corelib](../README.md) / PagingInfo

# Interface: PagingInfo

Defined in: [src/slick/iremoteview.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L266)

Information about the current paging state of the view

## Properties

### dataView

> **dataView**: [`IRemoteView`](IRemoteView.md)\<`any`\>

Defined in: [src/slick/iremoteview.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L268)

Reference to the RemoteView instance

***

### error

> **error**: `string`

Defined in: [src/slick/iremoteview.ts:270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L270)

Current error message, if any

***

### loading

> **loading**: `boolean`

Defined in: [src/slick/iremoteview.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L272)

Whether data is currently being loaded

***

### page

> **page**: `number`

Defined in: [src/slick/iremoteview.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L274)

Current page number (1-based)

***

### rowsPerPage

> **rowsPerPage**: `number`

Defined in: [src/slick/iremoteview.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L276)

Number of rows displayed per page

***

### totalCount

> **totalCount**: `number`

Defined in: [src/slick/iremoteview.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L278)

Total number of items available
