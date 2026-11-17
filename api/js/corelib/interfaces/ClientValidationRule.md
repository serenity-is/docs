[@serenity-is/corelib](../README.md) / ClientValidationRule

# Interface: ClientValidationRule

Defined in: [src/base/propertyitem.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L56)

A validation rule of a field as the server sends it, from a validation attribute of its property, e.g. ValidateRange,
which is checked by the rule of the same name registered with [registerValidationRule](../functions/registerValidationRule.md).

## Properties

### message?

> `optional` **message**: `string`

Defined in: [src/base/propertyitem.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L64)

The message as it is, used when there is no text of the key. The default message of the rule is used without both.

***

### params?

> `optional` **params**: `any`

Defined in: [src/base/propertyitem.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L60)

The parameters of the rule, e.g. `[1, 10]` for a range.

***

### rule

> **rule**: `string`

Defined in: [src/base/propertyitem.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L58)

The name of the rule, e.g. `range`.

***

### textKey?

> `optional` **textKey**: `string`

Defined in: [src/base/propertyitem.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L62)

The local text key of the message, used when it has a text.
