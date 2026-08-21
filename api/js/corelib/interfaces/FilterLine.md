[@serenity-is/corelib](../README.md) / FilterLine

# Interface: FilterLine

Defined in: [src/ui/filtering/filterline.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L6)

A single line in a filter panel, describing one filter condition.

## Properties

### criteria?

> `optional` **criteria**: `any`[]

Defined in: [src/ui/filtering/filterline.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L20)

The criteria expression for this line.

***

### displayText?

> `optional` **displayText**: `string`

Defined in: [src/ui/filtering/filterline.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L22)

Display text for this line.

***

### field?

> `optional` **field**: `string`

Defined in: [src/ui/filtering/filterline.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L8)

Field name being filtered.

***

### isOr?

> `optional` **isOr**: `boolean`

Defined in: [src/ui/filtering/filterline.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L12)

Whether this line is OR-combined with the previous line.

***

### leftParen?

> `optional` **leftParen**: `boolean`

Defined in: [src/ui/filtering/filterline.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L14)

Whether this line opens a parenthesis group.

***

### operator?

> `optional` **operator**: `string`

Defined in: [src/ui/filtering/filterline.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L10)

Operator key.

***

### rightParen?

> `optional` **rightParen**: `boolean`

Defined in: [src/ui/filtering/filterline.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L16)

Whether this line closes a parenthesis group.

***

### state?

> `optional` **state**: `any`

Defined in: [src/ui/filtering/filterline.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L24)

Persisted editor state.

***

### validationError?

> `optional` **validationError**: `string`

Defined in: [src/ui/filtering/filterline.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterline.ts#L18)

Validation error message, if any.
