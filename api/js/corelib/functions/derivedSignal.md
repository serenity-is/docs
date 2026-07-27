[@serenity-is/corelib](../README.md) / derivedSignal

# Function: derivedSignal()

> **derivedSignal**\<`TDerived`, `TInput`\>(`input`, `fn`): `DerivedSignalLike`\<`TDerived`\>

Defined in: [../domwise/dist/index.d.ts:2509](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2509)

Creates a derived (computed) signal from an input signal and a transform function.
The returned signal-like object re-computes its value whenever the input signal changes.
If the input signal's constructor supports derived computation, it is used; otherwise
a `PrimitiveComputed` fallback is created.

## Type Parameters

### TDerived

`TDerived`

The type of the derived value.

### TInput

`TInput` = `any`

The type of the input signal's value.

## Parameters

### input

[`SignalLike`](../interfaces/SignalLike.md)\<`TInput`\>

The source signal to observe.

### fn

(`value`) => `TDerived`

A transform function that maps the input value to the derived value.

## Returns

`DerivedSignalLike`\<`TDerived`\>

A `DerivedSignalLike` that updates when the input signal changes.
