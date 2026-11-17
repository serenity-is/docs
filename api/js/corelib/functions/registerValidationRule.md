[@serenity-is/corelib](../README.md) / registerValidationRule

# Function: registerValidationRule()

> **registerValidationRule**(`name`, `check`, `options?`): `void`

Defined in: [src/ui/helpers/validationrules.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationrules.ts#L57)

Registers a validation rule by a function, for the fields whose properties have a validation attribute of the same rule
name on the server. A rule class deriving from [ValidationRule](../classes/ValidationRule.md) is usually better, as it is found by its type key,
and can be loaded on demand by the forms that use it, while a rule registered by a function has to be registered by the
page before a form uses it, e.g. at the start of the application.

## Parameters

### name

`string`

The name of the rule, as the attribute gives it.

### check

[`ValidationRuleCheck`](../type-aliases/ValidationRuleCheck.md)

Checks a value by the rule.

### options?

[`ValidationRuleOptions`](../interfaces/ValidationRuleOptions.md)

The message of the rule.

## Returns

`void`
