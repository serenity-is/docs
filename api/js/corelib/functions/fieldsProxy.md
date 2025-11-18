[@serenity-is/corelib](../README.md) / fieldsProxy

# Function: fieldsProxy()

> **fieldsProxy**\<`TRow`\>(): `Readonly`\<`Record`\<keyof `TRow`, `string`\>\>

Defined in: [src/base/system.ts:390](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L390)

Get a proxy for form fields. This proxy returns the field name for any property
accessed on it. This is used in form initialization to avoid having to declare
a variable for the fields type. There is no actual runtime check for field names,
so it is only used to provide intellisense and compile-time checks.

## Type Parameters

### TRow

`TRow`

## Returns

`Readonly`\<`Record`\<keyof `TRow`, `string`\>\>

A readonly record of form field names and same string values
