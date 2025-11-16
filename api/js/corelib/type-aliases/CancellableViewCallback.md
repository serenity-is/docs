[corelib](../README.md) / CancellableViewCallback

# Type Alias: CancellableViewCallback()\<TItem\>

> **CancellableViewCallback**\<`TItem`\> = (`view`) => `boolean` \| `void`

Defined in: [src/slick/iremoteview.ts:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L286)

Callback function that can cancel a view operation

## Type Parameters

### TItem

`TItem`

## Parameters

### view

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

The RemoteView instance

## Returns

`boolean` \| `void`

true to continue, false to cancel
