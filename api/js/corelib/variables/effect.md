[@serenity-is/corelib](../README.md) / effect

# Variable: effect()

> `const` **effect**: (`fn`, `options?`) => () => `void`

Defined in: [../domwise/dist/index.d.ts:2549](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2549)

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
