[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / resizable

# ~~Function: resizable()~~

> **resizable**(`value`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L185)

Legacy decorator that attaches a [ResizableAttribute](../../../../classes/ResizableAttribute.md) to a dialog class.

## Parameters

### value

`boolean` = `true`

Whether the dialog may be resized. Defaults to `true`.

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

Prefer `static override [Symbol.typeInfo]` with [ResizableAttribute](../../../../classes/ResizableAttribute.md) metadata instead.
