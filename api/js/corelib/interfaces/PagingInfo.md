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

Defined in: [src/slick/iremoteview.ts:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L304)

Total number of items available
