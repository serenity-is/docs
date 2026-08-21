[@serenity-is/corelib](../../../../README.md) / [ValidationHelper](../README.md) / getValidator

# Function: getValidator()

> **getValidator**(`elem`): [`Validator`](../../../../classes/Validator.md)

Defined in: [src/compat/validation.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/validation.ts#L152)

Gets the [Validator](../../../../classes/Validator.md) instance associated with the given element.

## Parameters

### elem

The form/element (or array-like wrapper) to look up the validator for.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

## Returns

[`Validator`](../../../../classes/Validator.md)

The existing [Validator](../../../../classes/Validator.md) instance, or `null`/`undefined` if none is attached.
