[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / responsive

# ~~Function: responsive()~~

> **responsive**(`value`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L196)

Legacy responsive decorator retained for backward compatibility.

## Parameters

### value

`boolean` = `true`

Whether responsive behavior should be enabled. Defaults to `true`.

## Returns

> (`target`, `_context?`): `void`

### Parameters

#### target

`Function`

#### \_context?

`any`

### Returns

`void`

## Deprecated

This is no longer used as all dialogs are responsive. Prefer direct `static [Symbol.typeInfo]` pattern.
