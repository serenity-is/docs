[@serenity-is/corelib](../README.md) / bindThis

# Function: bindThis()

> **bindThis**\<`T`\>(`obj`): `T`

Defined in: [../domwise/dist/index.d.ts:2217](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2217)

Creates a proxy that automatically binds method calls to the given object.
Intended for use in classes, e.g. when attaching event handlers.
Instead of `someElement.addEventListener("click", this.onClick.bind(this))`
or an arrow function `(e) => this.onClick(e)` (both of which hurt performance
and complicate `removeEventListener` because the bound function must be stored),
you can write:

```ts
const boundThis = bindThis(this);
someElement.addEventListener("click", boundThis.onClick);
// later, in dispose:
someElement.removeEventListener("click", this.onClick);
```

The returned proxy lazily binds methods on first access and caches the bound
function in the target object. Subsequent accesses return the same cached
function, making it safe to use with `removeEventListener` by passing the
**original** method (e.g. `this.onClick`). There is no need to call `bindThis`
again in dispose — calling it a second time returns the same proxy.
Non-function properties are returned as-is.

## Type Parameters

### T

`T`

## Parameters

### obj

`T`

The object whose methods should be auto-bound.

## Returns

`T`

A proxy wrapping the object with auto-bound method access.
