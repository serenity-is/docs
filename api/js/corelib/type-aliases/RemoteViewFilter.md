[corelib](../README.md) / RemoteViewFilter

# Type Alias: RemoteViewFilter()\<TItem\>

> **RemoteViewFilter**\<`TItem`\> = (`item`, `view`) => `boolean`

Defined in: [src/slick/iremoteview.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L302)

Filter function for items in the view

## Type Parameters

### TItem

`TItem`

## Parameters

### item

`TItem`

The item to test

### view

[`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

The RemoteView instance

## Returns

`boolean`

true if the item should be included
