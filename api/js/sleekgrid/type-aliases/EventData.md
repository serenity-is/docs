[sleekgrid](../README.md) / EventData

# Type Alias: EventData\<TArgs, TEvent\>

> **EventData**\<`TArgs`, `TEvent`\> = [`IEventData`](../interfaces/IEventData.md)\<`TArgs`, `TEvent`\> & `TEvent` & `{ [key in keyof TArgs & MergeArgKeys]: TArgs[key] }`

Defined in: [src/core/event.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/event.ts#L17)

## Type Parameters

### TArgs

`TArgs` = \{ \}

### TEvent

`TEvent` = \{ \}
