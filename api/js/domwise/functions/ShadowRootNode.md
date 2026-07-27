[@serenity-is/domwise](../README.md) / ShadowRootNode

# Function: ShadowRootNode()

> **ShadowRootNode**(`options`): `any`

Defined in: [src/shadow.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/shadow.ts#L13)

Creates a virtual node descriptor for a `ShadowRoot` that can be used
during JSX element creation. The returned object is recognized by the
JSX factory to create a shadow root on the parent element.

## Parameters

### options

`ShadowRootInit` & `object`

An object with `ShadowRootInit` properties plus optional `ref` and `children`.

## Returns

`any`

A virtual node descriptor recognized by the JSX factory.
