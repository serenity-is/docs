[corelib](../README.md) / RemoteViewProcessCallback

# Type Alias: RemoteViewProcessCallback()\<TItem\>

> **RemoteViewProcessCallback**\<`TItem`\> = (`data`, `view`) => [`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

Defined in: [src/slick/iremoteview.ts:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L310)

Callback function for processing data received from the server

## Type Parameters

### TItem

`TItem`

## Parameters

### data

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

The raw data response

### view

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

The RemoteView instance

## Returns

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

The processed data
