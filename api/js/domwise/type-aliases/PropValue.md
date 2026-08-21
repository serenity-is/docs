[@serenity-is/domwise](../README.md) / PropValue

# Type Alias: PropValue\<T\>

> **PropValue**\<`T`\> = `T` \| [`PropHook`](../interfaces/PropHook.md)\<`Element`\> \| [`SignalLike`](../interfaces/SignalLike.md)\<`T`\>

Defined in: [types/basic-types.d.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L146)

A value that can be assigned to a JSX attribute: a plain value, a prop hook,
or a signal-like value.

## Type Parameters

### T

`T`

The type of the attribute value.
