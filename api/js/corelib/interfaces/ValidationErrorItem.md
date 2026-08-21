[@serenity-is/corelib](../README.md) / ValidationErrorItem

# Interface: ValidationErrorItem

Defined in: [src/base/validator.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L53)

Single validation failure entry.

## Properties

### element

> **element**: [`ValidatableElement`](ValidatableElement.md)

Defined in: [src/base/validator.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L57)

Element that failed validation.

***

### message

> **message**: `string`

Defined in: [src/base/validator.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L55)

Localized error message to display.

***

### method?

> `optional` **method**: `string`

Defined in: [src/base/validator.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L59)

Name of the rule / method that failed (e.g. `"required"`, `"email"`).
