[@serenity-is/corelib](../README.md) / usePropBinding

# Function: usePropBinding()

> **usePropBinding**\<`T`\>(`initialValue?`): [`PropBinding`](../interfaces/PropBinding.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:2647](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2647)

Creates a two-way prop binding hook that synchronizes a value to a single element attribute.

The returned [PropBinding](../interfaces/PropBinding.md) is a callable getter/setter that also
implements the prop-hook protocol. When the binding is assigned to a JSX
attribute (e.g. `<input value={binding} />`), it attaches to that element
and calls `assignProp` on every subsequent `binding(newValue)`. The hook
may only be bound once — reusing the same binding on a different element
or attribute throws.

## Type Parameters

### T

`T`

Type of the bound prop value.

## Parameters

### initialValue?

Optional initial value stored prior to element attachment.

`false` | `T`

## Returns

[`PropBinding`](../interfaces/PropBinding.md)\<`T`\>

A `PropBinding<T>` callable that reads the current value when called
with no arguments, and writes a new value when called with an argument.

## Example

```tsx
const value = usePropBinding("hello");
return <><input value={value} /><button onClick={() => value("world")} /></>;
```
