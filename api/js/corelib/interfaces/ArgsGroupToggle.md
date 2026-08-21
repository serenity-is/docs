[@serenity-is/corelib](../README.md) / ArgsGroupToggle

# Interface: ArgsGroupToggle

Defined in: [src/slick/remoteview.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L19)

Arguments for group expand/collapse events.

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

### groupingKey

> **groupingKey**: `string`

Defined in: [src/slick/remoteview.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L21)

The grouping key of the toggled group.

***

### level

> **level**: `number`

Defined in: [src/slick/remoteview.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L23)

The grouping level of the toggled group (0-based).
