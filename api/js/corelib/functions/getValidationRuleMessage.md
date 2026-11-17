[@serenity-is/corelib](../README.md) / getValidationRuleMessage

# Function: getValidationRuleMessage()

> **getValidationRuleMessage**(`rule`): `string`

Defined in: [src/ui/helpers/validationrules.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationrules.ts#L131)

Gets the message of a validation rule whose check failed: the text of its key, else its message, else the default message
of the rule, with the parameters of the rule.

## Parameters

### rule

[`ClientValidationRule`](../interfaces/ClientValidationRule.md)

The rule, as the server sends it.

## Returns

`string`
