[@serenity-is/corelib](../README.md) / useClassList

# Function: useClassList()

> **useClassList**(`initialValue?`): [`BasicClassList`](../interfaces/BasicClassList.md)

Defined in: [../domwise/dist/index.d.ts:2626](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2626)

Creates a `classList`-like manager that can be used as a JSX prop hook for the `class` attribute.

The returned [BasicClassList](../interfaces/BasicClassList.md) is a callable that also implements
`add`/`remove`/`toggle`/`contains` plus `value`/`size`, mirroring the native
`DOMTokenList` API. When assigned to `class` (e.g. `<div class={cls} />`),
the hook binds to the element's `classList` and keeps it in sync; the
binding is cleaned up automatically when the element is disposed.
Before binding, an optional `initialValue` is used to seed a detached
`classList` so that `add`/`remove` calls prior to attachment are preserved.

## Parameters

### initialValue?

[`ClassNames`](../type-aliases/ClassNames.md)

Optional initial class value (string, array, dictionary, iterable, or `DOMTokenList`).

## Returns

[`BasicClassList`](../interfaces/BasicClassList.md)

A `BasicClassList` instance that is both callable and a prop hook.

## Example

```tsx
const cls = useClassList("foo");
cls.add("bar");
return <div class={cls} />;
```
