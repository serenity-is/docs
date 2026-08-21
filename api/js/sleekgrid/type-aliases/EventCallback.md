[@serenity-is/sleekgrid](../README.md) / EventCallback

# Type Alias: EventCallback()\<TArgs, TEvent\>

> **EventCallback**\<`TArgs`, `TEvent`\> = (`e`, `args?`) => `void`

Defined in: [src/core/event.ts:54](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L54)

Handler signature for SleekGrid events.

## Type Parameters

### TArgs

`TArgs` = \{ \}

Event payload type.

### TEvent

`TEvent` = \{ \}

Wrapped native event type.

## Parameters

### e

[`EventData`](EventData.md)\<`TArgs`, `TEvent`\>

Event object with propagation controls and merged fields.

### args?

`TArgs`

Optional duplicate of `e.args` for convenience.

## Returns

`void`
