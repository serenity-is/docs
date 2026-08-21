[@serenity-is/corelib](../README.md) / keyOf

# Function: keyOf()

> **keyOf**\<`T`\>(`prop`): keyof `T`

Defined in: [src/compat/system-compat.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L220)

Identity helper that preserves a property key's type, useful for type-safe `keyof` references.

## Type Parameters

### T

`T`

The type whose key is being referenced.

## Parameters

### prop

keyof `T`

A key of `T`.

## Returns

keyof `T`

The same key, typed as `keyof T`.
