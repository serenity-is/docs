[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / maximizable

# ~~Function: maximizable()~~

> **maximizable**(`value`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L161)

Legacy decorator that attaches a [MaximizableAttribute](../../../../classes/MaximizableAttribute.md) to a dialog class.

## Parameters

### value

`boolean` = `true`

Whether the dialog may be maximized. Defaults to `true`.

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

Prefer `static override [Symbol.typeInfo]` with [MaximizableAttribute](../../../../classes/MaximizableAttribute.md) metadata instead.
