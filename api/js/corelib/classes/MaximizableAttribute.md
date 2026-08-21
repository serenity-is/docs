[@serenity-is/corelib](../README.md) / MaximizableAttribute

# Class: MaximizableAttribute

Defined in: [src/types/attributes.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L56)

Indicates that a dialog should be maximizable.

## Remarks

Requires jQuery UI and `jquery.dialogextend.js`; not applicable to Bootstrap modals.

## Extends

- [`CustomAttribute`](CustomAttribute.md)

## Constructors

### Constructor

> **new MaximizableAttribute**(`value`): `MaximizableAttribute`

Defined in: [src/types/attributes.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L63)

Creates a new MaximizableAttribute.

#### Parameters

##### value

`boolean` = `true`

Whether the dialog may be maximized. Defaults to `true`.

#### Returns

`MaximizableAttribute`

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`constructor`](CustomAttribute.md#constructor)

## Properties

### value

> **value**: `boolean` = `true`

Defined in: [src/types/attributes.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L63)

Whether the dialog may be maximized. Defaults to `true`.

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/types/attributes.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L57)

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`[typeInfo]`](CustomAttribute.md#typeinfo)
