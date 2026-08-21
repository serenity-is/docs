[@serenity-is/corelib](../README.md) / removeValidationRule

# Variable: removeValidationRule()

> `const` **removeValidationRule**: (`element`, `uniqueName`) => `void` = `Validator.removeCustomRule`

Defined in: [src/base/validator.tsx:2076](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L2076)

Alias for [Validator.removeCustomRule](../classes/Validator.md#removecustomrule).

Removes a custom validation callback previously added with [Validator.addCustomRule](../classes/Validator.md#addcustomrule).

## Parameters

### element

Target element or array-like collection.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### uniqueName

`string`

Key under which the rule was registered.

## Returns

`void`
