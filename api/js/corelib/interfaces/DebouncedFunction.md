[@serenity-is/corelib](../README.md) / DebouncedFunction

# Interface: DebouncedFunction()\<T\>

Defined in: [src/base/debounce.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L13)

A debounced wrapper around a function `T` with helper methods.

## Remarks

The callable signature applies debounce timing; [DebouncedFunction.clear](#clear)
cancels a pending invocation and [DebouncedFunction.flush](#flush) forces it to run now.

## Example

```ts
const onResize = debounce(() => layout(), 150);
window.addEventListener("resize", onResize);
onResize.clear(); // cancel pending call
```

## Type Parameters

### T

`T` *extends* (...`args`) => `any`

The original function type being debounced.

> **DebouncedFunction**(...`args`): `ReturnType`\<`T`\>

Defined in: [src/base/debounce.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L20)

Invokes the debounced function, applying debounce timing rules.

## Parameters

### args

...`Parameters`\<`T`\>

Arguments forwarded to the original function `T`.

## Returns

`ReturnType`\<`T`\>

Return value of the last immediate invocation, or `undefined` if the call was deferred / never invoked.

## Methods

### clear()

> **clear**(): `void`

Defined in: [src/base/debounce.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L29)

Cancels any pending (not yet fired) invocation.

#### Returns

`void`

#### Example

```ts
const fn = debounce(save, 300);
fn(); fn.clear(); // save will not run
```

***

### flush()

> **flush**(): `ReturnType`\<`T`\>

Defined in: [src/base/debounce.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L39)

Immediately invokes the pending debounced call (if any) and returns its result.

#### Returns

`ReturnType`\<`T`\>

Return value of the flushed invocation, or the last invocation's return value if nothing was pending, or `undefined` if never invoked.

#### Example

```ts
const fn = debounce(save, 300);
fn(); fn.flush(); // save runs now instead of after 300 ms
```
