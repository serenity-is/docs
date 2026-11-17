[@serenity-is/corelib](../README.md) / resetLazyTypes

# Function: resetLazyTypes()

> **resetLazyTypes**(): `void`

Defined in: [src/base/config.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/config.ts#L152)

Makes the types that can be lazily loaded read again from the DOM when a type is next requested.

## Returns

`void`

## Remarks

These are in the `<script id="LazyTypes">` JSON block rendered by `Html.LazyTypes()`, which maps
the urls of the modules that load the types implementing `LazyLoadInclude` to the keys of the types.
