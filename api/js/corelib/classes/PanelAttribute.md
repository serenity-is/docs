[@serenity-is/corelib](../README.md) / PanelAttribute

# Class: PanelAttribute

Defined in: [src/types/attributes.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L80)

Indicates that a dialog should open as a side panel by default.
Panels are rendered docked to the side rather than as centered modals.

## Extends

- [`CustomAttribute`](CustomAttribute.md)

## Constructors

### Constructor

> **new PanelAttribute**(`value`): `PanelAttribute`

Defined in: [src/types/attributes.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L87)

Creates a new PanelAttribute.

#### Parameters

##### value

`boolean` = `true`

Whether the dialog should prefer panel mode. Defaults to `true`.

#### Returns

`PanelAttribute`

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`constructor`](CustomAttribute.md#constructor)

## Properties

### value

> **value**: `boolean` = `true`

Defined in: [src/types/attributes.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L87)

Whether the dialog should prefer panel mode. Defaults to `true`.

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/types/attributes.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L81)

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`[typeInfo]`](CustomAttribute.md#typeinfo)
