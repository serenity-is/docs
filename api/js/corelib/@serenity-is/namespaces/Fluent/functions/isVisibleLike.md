[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / isVisibleLike

# Function: isVisibleLike()

> **isVisibleLike**(`element`): `boolean`

Defined in: [src/base/fluent.ts:688](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L688)

Tests whether the element is considered visible (jQuery `:visible` semantics).

## Parameters

### element

`Element`

Element to test.

## Returns

`boolean`

`true` when the element has non-zero `offsetWidth` / `offsetHeight` or any client rects.
