[serenity-is/corelib](../README.md) / DebouncedFunction

# Interface: DebouncedFunction()\<T\>

Defined in: [src/base/debounce.ts:1](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L1)

## Type Parameters

### T

`T` *extends* (...`args`) => `any`

> **DebouncedFunction**(...`args`): `ReturnType`\<`T`\>

Defined in: [src/base/debounce.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L11)

Call the original function, but applying the debounce rules.

If the debounced function can be run immediately, this calls it and returns its return
value.

Otherwise, it returns the return value of the last invocation, or undefined if the debounced
function was not invoked yet.

## Parameters

### args

...`Parameters`\<`T`\>

## Returns

`ReturnType`\<`T`\>

## Methods

### clear()

> **clear**(): `void`

Defined in: [src/base/debounce.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L16)

Throw away any pending invocation of the debounced function.

#### Returns

`void`

***

### flush()

> **flush**(): `ReturnType`\<`T`\>

Defined in: [src/base/debounce.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L25)

If there is a pending invocation of the debounced function, invoke it immediately and return
its return value.

Otherwise, return the value from the last invocation, or undefined if the debounced function
was never invoked.

#### Returns

`ReturnType`\<`T`\>
