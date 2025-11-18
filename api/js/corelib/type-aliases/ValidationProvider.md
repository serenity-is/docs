[@serenity-is/corelib](../README.md) / ValidationProvider

# Type Alias: ValidationProvider()

> **ValidationProvider** = (`value`, `element`, `params?`) => `boolean` \| `string` \| `Promise`\<`boolean` \| `string`\>

Defined in: [src/base/validator.tsx:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/validator.tsx#L33)

Validation plugin signature with multitype return.
Boolean return signifies the validation result, which uses the default validation error message read from the element attribute.
String return signifies failed validation, which then will be used as the validation error message.
Promise return signifies asynchronous plugin behavior, with same behavior as Boolean or String.

## Parameters

### value

[`ValidationValue`](ValidationValue.md)

### element

[`ValidatableElement`](../interfaces/ValidatableElement.md)

### params?

`any`

## Returns

`boolean` \| `string` \| `Promise`\<`boolean` \| `string`\>
