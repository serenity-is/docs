[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / registerEnumType

# ~~Function: registerEnumType()~~

> **registerEnumType**(`target`, `name?`, `enumKey?`): `void`

Defined in: [src/types/decorators.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L67)

Legacy wrapper for [registerEnum](registerEnum.md) kept for backward compatibility.

## Parameters

### target

`any`

Enum object to register.

### name?

`string`

Full type name.

### enumKey?

`string`

Legacy lookup key.

## Returns

`void`

## Deprecated

Use [registerEnum](registerEnum.md) instead. Prefer direct `static [Symbol.typeInfo]` pattern for new code.
