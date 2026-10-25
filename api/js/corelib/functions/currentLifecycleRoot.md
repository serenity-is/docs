[@serenity-is/corelib](../README.md) / currentLifecycleRoot

# Function: currentLifecycleRoot()

> **currentLifecycleRoot**(...`args`): `Element`

Defined in: [../domwise/dist/index.d.ts:2897](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2897)

Gets or sets the current lifecycle root element used to scope signal subscriptions.

The lifecycle root is the `EventTarget` whose `disposing` event will dispose
effects created during JSX construction (e.g. via `observeSignal` with
`useLifecycleRoot: true`).

This value is **not** set automatically during JSX creation. It is stored on
`globalThis`, so callers that install a root should restore the previous one;
prefer [withLifecycleRoot](withLifecycleRoot.md) which restores it even when the callback
throws.

## Parameters

### args

...`Element`[]

When provided, the first element is installed as the new lifecycle root.
When called with no arguments the current root (or `null` if none) is returned.

## Returns

`Element`

The current lifecycle root, or the previous root when a new one is being set. Returns `null` if none is set.
