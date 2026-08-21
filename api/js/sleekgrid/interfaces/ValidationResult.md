[@serenity-is/sleekgrid](../README.md) / ValidationResult

# Interface: ValidationResult

Defined in: [src/core/editing.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L27)

Result of validating an editor value before commit.

## Properties

### msg?

> `optional` **msg**: `string`

Defined in: [src/core/editing.ts:31](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L31)

Human-readable error message when `valid` is `false`.

***

### valid

> **valid**: `boolean`

Defined in: [src/core/editing.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L29)

Whether the value is valid.
