[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / trigger

# Function: trigger()

> **trigger**(`element`, `type`, `args?`): `Event` & `object`

Defined in: [src/base/fluent.ts:647](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L647)

Dispatches a synthetic event on the element.

## Parameters

### element

`EventTarget`

Target element to dispatch on.

### type

`string`

Event type to trigger (e.g. `"click"`, `"change"`).

### args?

`any`

Optional properties merged into the created `Event` / `CustomEvent` (`detail`, `bubbles`, etc.).

## Returns

`Event` & `object`

The dispatched event. Use [Fluent.isDefaultPrevented](isDefaultPrevented.md) to test whether `preventDefault()` was called.
