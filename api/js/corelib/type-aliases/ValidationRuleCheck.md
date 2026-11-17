[@serenity-is/corelib](../README.md) / ValidationRuleCheck

# Type Alias: ValidationRuleCheck()

> **ValidationRuleCheck** = (`value`, `params`, `context`) => `boolean`

Defined in: [src/ui/helpers/validationrules.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationrules.ts#L14)

Checks a value by a validation rule registered with [registerValidationRule](../functions/registerValidationRule.md). It is not called for an empty value,
i.e. null, an empty string or an empty list, as being required is a rule of its own.

## Parameters

### value

`any`

The value, e.g. a number for a decimal editor, or a text.

### params

`any`

The parameters of the rule, as the server sends them.

### context

[`ValidationRuleContext`](../interfaces/ValidationRuleContext.md)

The element and the other fields.

## Returns

`boolean`

Whether the value is valid.
