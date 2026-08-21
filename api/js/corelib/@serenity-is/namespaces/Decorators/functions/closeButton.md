[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / closeButton

# ~~Function: closeButton()~~

> **closeButton**(`value`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L111)

Legacy decorator that attaches a [CloseButtonAttribute](../../../../classes/CloseButtonAttribute.md) to a dialog class.

## Parameters

### value

`boolean` = `true`

Whether the dialog should show a close button. Defaults to `true`.

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

Prefer `static override [Symbol.typeInfo] = classTypeInfo("...")` with [CloseButtonAttribute](../../../../classes/CloseButtonAttribute.md) metadata instead.
