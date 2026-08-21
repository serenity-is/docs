[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / staticPanel

# ~~Function: staticPanel()~~

> **staticPanel**(`value`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L207)

Legacy decorator that attaches a [StaticPanelAttribute](../../../../classes/StaticPanelAttribute.md) to a widget class.

## Parameters

### value

`boolean` = `true`

Whether the widget should render as a static panel. Defaults to `true`.

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

Prefer `static override [Symbol.typeInfo]` with [StaticPanelAttribute](../../../../classes/StaticPanelAttribute.md) metadata instead.
