[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / advancedFiltering

# ~~Function: advancedFiltering()~~

> **advancedFiltering**(`value`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L146)

Legacy decorator that attaches an [AdvancedFilteringAttribute](../../../../classes/AdvancedFilteringAttribute.md) to a grid class.

## Parameters

### value

`boolean` = `true`

Whether advanced filtering should be enabled. Defaults to `true`.

## Returns

Class decorator.

> (`target`, `_context?`): `void`

### Parameters

#### target

`Function`

#### \_context?

`any`

### Returns

`void`

## Deprecated

Prefer `static override [Symbol.typeInfo]` with [AdvancedFilteringAttribute](../../../../classes/AdvancedFilteringAttribute.md) metadata instead.
