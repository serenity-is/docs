[corelib](../README.md) / getType

# Function: getType()

> **getType**(`name`, `target?`): [`Type`](../type-aliases/Type.md)

Defined in: [src/base/system.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L67)

Get a type by name from the type registry, global object or a specific target.

## Parameters

### name

`string`

Name of the type

### target?

`any`

Target object to search in (defaults to global object)

## Returns

[`Type`](../type-aliases/Type.md)

The type or null if not found
