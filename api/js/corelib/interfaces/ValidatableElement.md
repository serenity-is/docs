[@serenity-is/corelib](../README.md) / ValidatableElement

# Interface: ValidatableElement

Defined in: [src/base/validator.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L20)

An `HTMLElement` that can be validated (`input`, `select`, `textarea`, or `[contenteditable]`).
Extends `HTMLElement` with form-associated properties used by the validation engine.

## Extends

- `HTMLElement`

## Properties

### form?

> `optional` **form**: `HTMLFormElement`

Defined in: [src/base/validator.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L22)

Owning form element, if associated.

***

### name?

> `optional` **name**: `string`

Defined in: [src/base/validator.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L24)

Field name used as the validation key.

***

### type?

> `optional` **type**: `string`

Defined in: [src/base/validator.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L26)

Input type (e.g. `"text"`, `"checkbox"`, `"radio"`).

***

### value?

> `optional` **value**: `string`

Defined in: [src/base/validator.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L28)

Current string value of the element.
