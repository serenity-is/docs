[@serenity-is/corelib](../README.md) / PropValue

# Type Alias: PropValue\<T\>

> **PropValue**\<`T`\> = `T` \| [`PropHook`](../interfaces/PropHook.md)\<`Element`\> \| [`SignalLike`](../interfaces/SignalLike.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L137)

A value that can be assigned to a JSX attribute: a plain value, a prop hook,
or a signal-like value.

## Type Parameters

### T

`T`

The type of the attribute value.
