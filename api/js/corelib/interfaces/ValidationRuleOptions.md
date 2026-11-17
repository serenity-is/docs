[@serenity-is/corelib](../README.md) / ValidationRuleOptions

# Interface: ValidationRuleOptions

Defined in: [src/ui/helpers/validationrules.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationrules.ts#L17)

The options of a validation rule registered with [registerValidationRule](../functions/registerValidationRule.md).

## Properties

### defaultText?

> `optional` **defaultText**: `string`

Defined in: [src/ui/helpers/validationrules.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationrules.ts#L24)

The text of the message for when its key has no text, e.g. the English one.

***

### textKey?

> `optional` **textKey**: `string`

Defined in: [src/ui/helpers/validationrules.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationrules.ts#L22)

The local text key of the message of the rule, e.g. `Validation.Even`, which can have the parameters of the rule as
`{0}`, `{1}`, used when the attribute gives no message of its own. It is `Validation.Invalid` when it is not set.
