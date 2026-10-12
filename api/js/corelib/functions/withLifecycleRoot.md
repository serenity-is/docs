[@serenity-is/corelib](../README.md) / withLifecycleRoot

# Function: withLifecycleRoot()

> **withLifecycleRoot**\<`T`\>(`root`, `fn`): `T`

Defined in: [../domwise/dist/index.d.ts:2605](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2605)

Runs `fn` with the lifecycle root temporarily set to `root`, restoring the
previous root afterwards even if `fn` throws.

Use this instead of calling [currentLifecycleRoot](currentLifecycleRoot.md) directly so that a
thrown error cannot leave a stale root in the global state.

## Type Parameters

### T

`T`

Return type of `fn`.

## Parameters

### root

`Element`

Root to install for the duration of `fn` (`null`/`undefined` clears it).

### fn

() => `T`

Callback executed while the root is installed.

## Returns

`T`

The value returned by `fn`.
