[serenity-is/corelib](../README.md) / debounce

# Function: debounce()

> **debounce**\<`T`\>(`func`, `wait?`, `immediate?`): [`DebouncedFunction`](../interfaces/DebouncedFunction.md)\<`T`\>

Defined in: [src/base/debounce.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L38)

Returns a function, that, as long as it continues to be invoked, will not
be triggered. The function also has a property 'clear' that can be used 
to clear the timer to prevent previously scheduled executions, and flush method
to invoke scheduled executions now if any.

## Type Parameters

### T

`T` *extends* (...`args`) => `any`

## Parameters

### func

`T`

### wait?

`number`

The function will be called after it stops being called for
N milliseconds.

### immediate?

`boolean`

If passed, trigger the function on the leading edge, instead of the trailing.

## Returns

[`DebouncedFunction`](../interfaces/DebouncedFunction.md)\<`T`\>
