[@serenity-is/corelib](../README.md) / addValidationRule

# Variable: addValidationRule()

> `const` **addValidationRule**: (`element`, `rule`, `uniqueName?`) => `void` = `Validator.addCustomRule`

Defined in: [src/base/validator.tsx:2074](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L2074)

Alias for [Validator.addCustomRule](../classes/Validator.md#addcustomrule).

Adds a custom validation callback for an element. Multiple callbacks can be registered under distinct `uniqueName` keys.

## Parameters

### element

Target element or array-like collection (first element is used).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### rule

(`input`) => `string`

Callback returning an error message string when invalid, or `null`/`undefined` when valid.

### uniqueName?

`string`

Optional key to allow independent removal; defaults to `""`.

## Returns

`void`
