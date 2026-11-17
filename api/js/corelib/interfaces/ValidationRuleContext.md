[@serenity-is/corelib](../README.md) / ValidationRuleContext

# Interface: ValidationRuleContext

Defined in: [src/base/validationrule.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L4)

What a validation rule is checked with, besides the value and its parameters.

## Properties

### element?

> `optional` **element**: `HTMLElement`

Defined in: [src/base/validationrule.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L6)

The element being validated, e.g. the input of an editor.

***

### getValue()?

> `optional` **getValue**: (`field`) => `any`

Defined in: [src/base/validationrule.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validationrule.ts#L8)

Gets the value of another field of the form, e.g. for a rule comparing two fields.

#### Parameters

##### field

`string`

#### Returns

`any`
