[corelib](../../../../README.md) / [Fluent](../README.md) / isVisibleLike

# Function: isVisibleLike()

> **isVisibleLike**(`element`): `boolean`

Defined in: [src/base/fluent.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L521)

Returns true if the element is visible like. This is for compatibility with jQuery's :visible selector.

## Parameters

### element

`Element`

The target element

## Returns

`boolean`

true if the element has offsetWidth or offsetHeight or any getClientRects().length > 0
