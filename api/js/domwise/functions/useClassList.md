[@serenity-is/domwise](../README.md) / useClassList

# Function: useClassList()

> **useClassList**(`initialValue?`): [`BasicClassList`](../interfaces/BasicClassList.md)

Defined in: [src/hooks.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/hooks.ts#L15)

Creates a hook-like class list manager that wraps a `DOMTokenList`.
Returns a callable object that can be used as a JSX prop hook via `initPropHookSymbol`,
allowing reactive `class` attribute binding. Provides `add`, `remove`, `toggle`, `contains`,
and `value` / `size` accessors similar to the native `classList` API.

## Parameters

### initialValue?

[`ClassNames`](../type-aliases/ClassNames.md)

Optional initial class value (string, array, or dictionary).

## Returns

[`BasicClassList`](../interfaces/BasicClassList.md)

A `BasicClassList` instance.
