[@serenity-is/corelib](../README.md) / useClassList

# Function: useClassList()

> **useClassList**(`initialValue?`): [`BasicClassList`](../interfaces/BasicClassList.md)

Defined in: [../domwise/dist/index.d.ts:2346](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2346)

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
