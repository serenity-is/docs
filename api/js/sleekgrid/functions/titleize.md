[@serenity-is/sleekgrid](../README.md) / titleize

# Function: titleize()

> **titleize**(`str`): `string`

Defined in: [src/core/column.ts:216](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L216)

Converts a field/column identifier to a human-readable Title Case string.
Handles camelCase, PascalCase, snake_case, kebab-case and whitespace separated names.

## Parameters

### str

`string`

Raw identifier to titleize.

## Returns

`string`

Title-cased, space-separated string (e.g. `"firstName"` → `"First Name"`).
