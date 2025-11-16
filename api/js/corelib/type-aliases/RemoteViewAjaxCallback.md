[corelib](../README.md) / RemoteViewAjaxCallback

# Type Alias: RemoteViewAjaxCallback()\<TItem\>

> **RemoteViewAjaxCallback**\<`TItem`\> = (`view`, `options`) => `boolean` \| `void`

Defined in: [src/slick/iremoteview.ts:294](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L294)

Callback function for AJAX calls made by the view

## Type Parameters

### TItem

`TItem`

## Parameters

### view

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

The RemoteView instance

### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>\>

The service options for the AJAX call

## Returns

`boolean` \| `void`

true to continue, false to cancel
