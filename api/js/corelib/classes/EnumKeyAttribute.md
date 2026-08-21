[@serenity-is/corelib](../README.md) / EnumKeyAttribute

# Class: EnumKeyAttribute

Defined in: [src/base/system.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L260)

Attribute that overrides the lookup key under which an enum is registered in the global type registry.
By default the enum's full name is used as the key; this attribute allows an alternative key.

## Extends

- [`CustomAttribute`](CustomAttribute.md)

## Constructors

### Constructor

> **new EnumKeyAttribute**(`value`): `EnumKeyAttribute`

Defined in: [src/base/system.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L267)

Creates a new enum-key attribute.

#### Parameters

##### value

`string`

Alternative registry key for the enum (e.g. `"MyApp.MyEnum"`).

#### Returns

`EnumKeyAttribute`

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`constructor`](CustomAttribute.md#constructor)

## Properties

### value

> **value**: `string`

Defined in: [src/base/system.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L267)

Alternative registry key for the enum (e.g. `"MyApp.MyEnum"`).

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/base/system.ts:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L261)

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`[typeInfo]`](CustomAttribute.md#typeinfo)
