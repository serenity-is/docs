[@serenity-is/corelib](../README.md) / ValidateEventDelegate

# Type Alias: ValidateEventDelegate()

> **ValidateEventDelegate** = (`element`, `event`, `validator`) => `void`

Defined in: [src/base/validator.tsx:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L80)

Event delegate for validation triggers (`onclick`, `onfocusout`, `onkeyup`, `onfocusin`).

## Parameters

### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Source element that raised the event.

### event

`Event`

DOM event.

### validator

[`Validator`](../classes/Validator.md)

Owning validator instance.

## Returns

`void`
