[@serenity-is/corelib](../README.md) / derivedSignal

# Function: derivedSignal()

> **derivedSignal**\<`TDerived`, `TInput`\>(`input`, `fn`): `DerivedSignalLike`\<`TDerived`\>

Defined in: [../domwise/dist/index.d.ts:2881](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2881)

Creates a derived (computed) signal from a source signal and a transform.

When the source signal changes, the derived value is re-computed via `fn`.
If the source signal's constructor appears to be a computed-capable type,
a new instance of that constructor wrapping `() => fn(input.value)` is
attempted; otherwise a lightweight PrimitiveComputed fallback is
used. The returned signal exposes a `derivedDisposer` that unsubscribes
from the source.

## Type Parameters

### TDerived

`TDerived`

Type of the derived/computed value.

### TInput

`TInput` = `any`

Type of the source signal's value.

## Parameters

### input

[`SignalLike`](../interfaces/SignalLike.md)\<`TInput`\>

Source signal to derive from. Must be signal-like.

### fn

(`value`) => `TDerived`

Transform applied to the source value to produce the derived value.

## Returns

`DerivedSignalLike`\<`TDerived`\>

A `DerivedSignalLike<TDerived>` whose `value` tracks `fn(input.value)`.

## Throws

When `input` is not signal-like.
