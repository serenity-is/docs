[@serenity-is/corelib](../README.md) / ArgsRowsOrCountChanged

# Interface: ArgsRowsOrCountChanged

Defined in: [src/slick/remoteview.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L55)

Arguments for rows or row-count changed events.

## Extends

- [`ArgsRemoteView`](ArgsRemoteView.md)

## Properties

### currentRowCount

> **currentRowCount**: `number`

Defined in: [src/slick/remoteview.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L61)

Current row count after the change.

***

### dataView

> **dataView**: [`IRemoteView`](IRemoteView.md)

Defined in: [src/slick/remoteview.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L13)

The data view that raised the event.

#### Inherited from

[`ArgsRemoteView`](ArgsRemoteView.md).[`dataView`](ArgsRemoteView.md#dataview)

***

### previousRowCount

> **previousRowCount**: `number`

Defined in: [src/slick/remoteview.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L59)

Previous row count before the change.

***

### rowCountChanged

> **rowCountChanged**: `boolean`

Defined in: [src/slick/remoteview.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L63)

Whether the row count changed.

***

### rowsChanged

> **rowsChanged**: `boolean`

Defined in: [src/slick/remoteview.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L65)

Whether any rows changed.

***

### rowsDiff

> **rowsDiff**: `number`[]

Defined in: [src/slick/remoteview.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L57)

Indices of the rows that changed.
