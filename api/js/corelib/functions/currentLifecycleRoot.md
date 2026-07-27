[@serenity-is/corelib](../README.md) / currentLifecycleRoot

# Function: currentLifecycleRoot()

> **currentLifecycleRoot**(...`args`): `Element`

Defined in: [../domwise/dist/index.d.ts:2314](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2314)

Gets or sets the current lifecycle root element.
When called with an argument, sets the lifecycle root and returns the previous value.
When called without arguments, returns the current lifecycle root.

## Parameters

### args

...`Element`[]

If provided, the first element is set as the new lifecycle root.

## Returns

`Element`

The current (or previous) lifecycle root element, or `null` if none is set.
