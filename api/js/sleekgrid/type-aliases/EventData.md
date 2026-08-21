[@serenity-is/sleekgrid](../README.md) / EventData

# Type Alias: EventData\<TArgs, TEvent\>

> **EventData**\<`TArgs`, `TEvent`\> = [`IEventData`](../interfaces/IEventData.md)\<`TArgs`, `TEvent`\> & `TEvent` & `{ [key in keyof TArgs & MergeArgKeys]: TArgs[key] }`

Defined in: [src/core/event.ts:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L46)

Union type representing the actual event object handlers receive. It merges
[IEventData](../interfaces/IEventData.md) with the native event and hoisted arg keys so callers can
access `e.row`, `e.cell`, `e.grid`, etc. directly.

## Type Parameters

### TArgs

`TArgs` = \{ \}

### TEvent

`TEvent` = \{ \}
