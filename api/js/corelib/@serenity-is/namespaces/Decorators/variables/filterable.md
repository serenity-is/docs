[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / filterable

# ~~Variable: filterable()~~

> `const` **filterable**: (`value`) => (`target`, `_context?`) => `void` = `advancedFiltering`

Defined in: [src/types/decorators.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L153)

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

## Deprecated

Use `advancedFiltering` instead
