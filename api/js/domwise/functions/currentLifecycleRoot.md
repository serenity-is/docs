[@serenity-is/domwise](../README.md) / currentLifecycleRoot

# Function: currentLifecycleRoot()

> **currentLifecycleRoot**(...`args`): `Element` \| `null`

Defined in: [src/disposing-listener.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/disposing-listener.ts#L197)

Gets or sets the current JSX lifecycle root element used to scope signal subscriptions.

The lifecycle root is the `EventTarget` whose `disposing` event will dispose
effects created during JSX construction (e.g. via `observeSignal` with
`useLifecycleRoot: true`).

## Parameters

### args

...`Element`[]

When provided, the first element is installed as the new lifecycle root.
When called with no arguments the current root (or `null` if none) is returned.

## Returns

`Element` \| `null`

The current lifecycle root, or the previous root when a new one is being set. Returns `null` if none is set.
