[@serenity-is/corelib](../README.md) / ValidationProvider

# Type Alias: ValidationProvider()

> **ValidationProvider** = (`value`, `element`, `params?`) => `boolean` \| `string` \| `Promise`\<`boolean` \| `string`\>

Defined in: [src/base/validator.tsx:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L44)

Validation rule implementation.
- `boolean` return: `true` passes, `false` fails using the default message.
- `string` return: non-empty string fails and is used as the error message.
- `Promise` return: async variant with the same semantics.

## Parameters

### value

[`ValidationValue`](ValidationValue.md)

Current field value.

### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

Element being validated.

### params?

`any`

Optional rule parameter (e.g. min value, regex).

## Returns

`boolean` \| `string` \| `Promise`\<`boolean` \| `string`\>

Validation result or promise thereof.
