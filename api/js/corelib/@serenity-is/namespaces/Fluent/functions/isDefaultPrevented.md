[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / isDefaultPrevented

# Function: isDefaultPrevented()

> **isDefaultPrevented**(`event`): `boolean`

Defined in: [src/base/fluent.ts:800](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L800)

Tests whether `preventDefault()` was called on the event, supporting both native and jQuery-wrapped events.

## Parameters

### event

Event object, possibly with a jQuery `isDefaultPrevented()` method.

#### defaultPrevented?

`boolean`

#### isDefaultPrevented?

() => `boolean`

## Returns

`boolean`

`true` when `defaultPrevented` is `true` or `isDefaultPrevented()` returns `true`.
