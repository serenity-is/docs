[@serenity-is/domwise](../README.md) / effect

# Variable: effect()

> `const` **effect**: (`fn`, `options?`) => () => `void` = `signals.effect`

Defined in: [src/signals.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L47)

Creates an effect that runs whenever its signal dependencies change.
Re-exported from `@preact/signals-core`.

## Parameters

### fn

`EffectFn`

The effect function. May optionally return a cleanup callback.

### options?

[`EffectOptions`](../interfaces/EffectOptions.md)

Optional effect options (`name`).

## Returns

A disposer function to stop the effect.

> (): `void`

### Returns

`void`
