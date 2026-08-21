[@serenity-is/corelib](../README.md) / ShadowRootNode

# Function: ShadowRootNode()

> **ShadowRootNode**(`options`): `any`

Defined in: [../domwise/dist/index.d.ts:2785](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2785)

Creates a virtual `ShadowRoot` descriptor recognized by the JSX factory.

When a `ShadowRootContainer` produced by this function appears among a
parent element's children (e.g. `<div><ShadowRootNode mode="open">…</ShadowRootNode></div>`),
the factory calls `parent.attachShadow(init)` and appends the `children`
into the resulting `ShadowRoot`. An optional `ref` is forwarded to the
created `ShadowRoot`.

## Parameters

### options

`ShadowRootInit` & `object`

Shadow root init options (`mode`, `delegatesFocus`, etc.) plus optional `ref` and `children`.

## Returns

`any`

A virtual node descriptor that the JSX factory consumes to create the shadow root.

## Example

```tsx
<div><ShadowRootNode mode="open"><span>inside shadow</span></ShadowRootNode></div>
```
