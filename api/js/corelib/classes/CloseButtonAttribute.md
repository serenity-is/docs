[@serenity-is/corelib](../README.md) / CloseButtonAttribute

# Class: CloseButtonAttribute

Defined in: [src/types/attributes.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L7)

Indicates whether a dialog should show a close button in its title bar.
Applied via `static [Symbol.typeInfo]` metadata or the legacy decorator.

## Extends

- [`CustomAttribute`](CustomAttribute.md)

## Constructors

### Constructor

> **new CloseButtonAttribute**(`value`): `CloseButtonAttribute`

Defined in: [src/types/attributes.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L14)

Creates a new CloseButtonAttribute.

#### Parameters

##### value

`boolean` = `true`

Whether the title bar should display a close button. Defaults to `true`.

#### Returns

`CloseButtonAttribute`

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`constructor`](CustomAttribute.md#constructor)

## Properties

### value

> **value**: `boolean` = `true`

Defined in: [src/types/attributes.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L14)

Whether the title bar should display a close button. Defaults to `true`.

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/types/attributes.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L8)

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`[typeInfo]`](CustomAttribute.md#typeinfo)
