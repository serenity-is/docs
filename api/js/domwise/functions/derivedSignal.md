[@serenity-is/domwise](../README.md) / derivedSignal

# Function: derivedSignal()

> **derivedSignal**\<`TDerived`, `TInput`\>(`input`, `fn`): `DerivedSignalLike`\<`TDerived`\>

Defined in: [src/signal-util.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signal-util.ts#L162)

Creates a derived signal from a computation function

## Type Parameters

### TDerived

`TDerived`

### TInput

`TInput` = `any`

## Parameters

### input

[`SignalLike`](../interfaces/SignalLike.md)\<`TInput`\>

### fn

(`value`) => `TDerived`

## Returns

`DerivedSignalLike`\<`TDerived`\>
