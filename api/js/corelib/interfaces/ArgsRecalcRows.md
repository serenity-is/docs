[@serenity-is/corelib](../README.md) / ArgsRecalcRows

# Interface: ArgsRecalcRows

Defined in: [src/slick/remoteview.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L71)

Arguments for the recalc rows event.

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

### newRows

> **newRows**: `any`[]

Defined in: [src/slick/remoteview.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L75)

Rows after recalculation.

***

### oldRows

> **oldRows**: `any`[]

Defined in: [src/slick/remoteview.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L73)

Rows before recalculation.
