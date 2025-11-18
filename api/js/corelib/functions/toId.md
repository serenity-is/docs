[@serenity-is/corelib](../README.md) / toId

# Function: toId()

> **toId**(`id`): `any`

Defined in: [src/base/formatting.ts:595](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L595)

Converts a string to an ID. If the string is a number, it is returned as-is.
If the string is empty, null or whitespace, null is returned.
Otherwise, it is converted to a number if possible. If the string is not a
valid number or longer than 14 digits, the trimmed string is returned as-is.

## Parameters

### id

`any`

the string to convert to an ID

## Returns

`any`
