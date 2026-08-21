[@serenity-is/corelib](../README.md) / ResizableAttribute

# Class: ResizableAttribute

Defined in: [src/types/attributes.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L96)

Indicates whether a dialog should be resizable (jQuery UI dialogs only).
Has no effect on Bootstrap modal dialogs.

## Extends

- [`CustomAttribute`](CustomAttribute.md)

## Constructors

### Constructor

> **new ResizableAttribute**(`value`): `ResizableAttribute`

Defined in: [src/types/attributes.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L103)

Creates a new ResizableAttribute.

#### Parameters

##### value

`boolean` = `true`

Whether the dialog may be resized by the user. Defaults to `true`.

#### Returns

`ResizableAttribute`

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`constructor`](CustomAttribute.md#constructor)

## Properties

### value

> **value**: `boolean` = `true`

Defined in: [src/types/attributes.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L103)

Whether the dialog may be resized by the user. Defaults to `true`.

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/types/attributes.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L97)

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`[typeInfo]`](CustomAttribute.md#typeinfo)
