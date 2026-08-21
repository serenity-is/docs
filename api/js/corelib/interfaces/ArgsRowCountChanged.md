[@serenity-is/corelib](../README.md) / ArgsRowCountChanged

# Interface: ArgsRowCountChanged

Defined in: [src/slick/remoteview.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L37)

Arguments for row count changed events.

## Extends

- [`ArgsRemoteView`](ArgsRemoteView.md)

## Properties

### current

> **current**: `number`

Defined in: [src/slick/remoteview.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L41)

Current row count.

***

### dataView

> **dataView**: [`IRemoteView`](IRemoteView.md)

Defined in: [src/slick/remoteview.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L13)

The data view that raised the event.

#### Inherited from

[`ArgsRemoteView`](ArgsRemoteView.md).[`dataView`](ArgsRemoteView.md#dataview)

***

### previous

> **previous**: `number`

Defined in: [src/slick/remoteview.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L39)

Previous row count.
