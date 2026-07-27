[@serenity-is/domwise](../README.md) / currentLifecycleRoot

# Function: currentLifecycleRoot()

> **currentLifecycleRoot**(...`args`): `Element` \| `null`

Defined in: [src/disposing-listener.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/disposing-listener.ts#L168)

Gets or sets the current lifecycle root element.
When called with an argument, sets the lifecycle root and returns the previous value.
When called without arguments, returns the current lifecycle root.

## Parameters

### args

...`Element`[]

If provided, the first element is set as the new lifecycle root.

## Returns

`Element` \| `null`

The current (or previous) lifecycle root element, or `null` if none is set.
