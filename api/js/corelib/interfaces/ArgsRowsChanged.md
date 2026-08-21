[@serenity-is/corelib](../README.md) / ArgsRowsChanged

# Interface: ArgsRowsChanged

Defined in: [src/slick/remoteview.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L47)

Arguments for rows changed events.

## Extends

- [`ArgsRemoteView`](ArgsRemoteView.md)

## Properties

### dataView

> **dataView**: [`IRemoteView`](IRemoteView.md)

Defined in: [src/slick/remoteview.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L13)

The data view that raised the event.

#### Inherited from

[`ArgsRemoteView`](ArgsRemoteView.md).[`dataView`](ArgsRemoteView.md#dataview)

***

### rows

> **rows**: `number`[]

Defined in: [src/slick/remoteview.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L49)

Indices of the rows that changed.
