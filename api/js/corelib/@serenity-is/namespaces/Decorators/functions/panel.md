[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / panel

# ~~Function: panel()~~

> **panel**(`value`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L173)

Legacy decorator that attaches a [PanelAttribute](../../../../classes/PanelAttribute.md) to a dialog class.

## Parameters

### value

`boolean` = `true`

Whether the dialog should prefer panel mode. Defaults to `true`.

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

Prefer `static override [Symbol.typeInfo]` with [PanelAttribute](../../../../classes/PanelAttribute.md) metadata instead.
