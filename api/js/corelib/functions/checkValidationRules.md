[@serenity-is/corelib](../README.md) / checkValidationRules

# Function: checkValidationRules()

> **checkValidationRules**(`validationRules`, `value`, `context?`): `string`

Defined in: [src/ui/helpers/validationrules.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationrules.ts#L151)

Checks a value by validation rules, in their order, stopping at the first one it is not valid by. An empty value is
valid. A rule that is neither registered by a function nor a loaded class is skipped, as the server still checks it,
with a warning unless its class is still being loaded, see [loadValidationRules](loadValidationRules.md).

## Parameters

### validationRules

[`ClientValidationRule`](../interfaces/ClientValidationRule.md)[]

The rules, as the server sends them.

### value

`any`

The value.

### context?

[`ValidationRuleContext`](../interfaces/ValidationRuleContext.md)

The element and the other fields.

## Returns

`string`

The message of the first rule the value is not valid by, or null.
