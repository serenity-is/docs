[@serenity-is/corelib](../README.md) / loadValidationRules

# Function: loadValidationRules()

> **loadValidationRules**(`validationRules`): `void` \| `Promise`\<`void`\>

Defined in: [src/ui/helpers/validationrules.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationrules.ts#L100)

Loads the classes of the validation rules that are not loaded yet, which implement LazyLoadInclude, so they can be checked
by the time the form is submitted. A form calls it once it is created.

## Parameters

### validationRules

[`ClientValidationRule`](../interfaces/ClientValidationRule.md)[]

The rules, as the server sends them.

## Returns

`void` \| `Promise`\<`void`\>

A promise that resolves when they are loaded, or nothing when they are all loaded already.
