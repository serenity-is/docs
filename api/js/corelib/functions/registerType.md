[@serenity-is/corelib](../README.md) / registerType

# Function: registerType()

> **registerType**(`type`): `void`

Defined in: [src/base/system.ts:687](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L687)

Registers a type that already has a `static [Symbol.typeInfo]` declaration.
Called automatically by the `static { registerType(this); }` block that follows the typeInfo declaration.
Validates that the typeInfo exists and has a `typeName`.

## Parameters

### type

Class / interface object carrying `[Symbol.typeInfo]` and a `name` property.

#### [typeInfo]

[`TypeInfo`](../type-aliases/TypeInfo.md)\<`any`\>

#### name

`string`

## Returns

`void`

## Throws

If `type` is null, lacks `[Symbol.typeInfo]`, or its `typeName` is empty.
