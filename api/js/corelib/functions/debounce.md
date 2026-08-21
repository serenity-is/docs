[@serenity-is/corelib](../README.md) / debounce

# Function: debounce()

> **debounce**\<`T`\>(`func`, `wait?`, `immediate?`): [`DebouncedFunction`](../interfaces/DebouncedFunction.md)\<`T`\>

Defined in: [src/base/debounce.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/debounce.ts#L66)

Creates a debounced function that delays invoking `func` until after `wait` ms have elapsed
since the last time it was invoked.

## Type Parameters

### T

`T` *extends* (...`args`) => `any`

Type of the function to debounce.

## Parameters

### func

`T`

Function to debounce.

### wait?

`number`

Delay in milliseconds to wait after the last call before invoking `func`. Defaults to `100`.

### immediate?

`boolean`

If `true`, trigger on the leading edge instead of the trailing edge. Defaults to `false`.

## Returns

[`DebouncedFunction`](../interfaces/DebouncedFunction.md)\<`T`\>

Debounced wrapper with `clear` and `flush` helpers.

## Remarks

When `immediate` is `false` (default), `func` is invoked on the trailing edge after the quiet period.
When `immediate` is `true`, `func` is invoked on the leading edge and subsequent calls within
`wait` ms are ignored. The returned function exposes [DebouncedFunction.clear](../interfaces/DebouncedFunction.md#clear) to cancel
a pending trailing call and [DebouncedFunction.flush](../interfaces/DebouncedFunction.md#flush) to run it immediately. `wait` defaults to `100` ms.

## Examples

```ts
const save = debounce(() => api.save(data), 500);
save(); save(); // only the last call triggers after 500 ms of quiet
```

```ts
const track = debounce(() => analytics.send(), 200, true); // leading-edge
```

```ts
const fn = debounce(() => console.log("hi"), 300);
fn(); fn.clear(); // cancels
fn(); fn.flush(); // forces immediate invocation
```
