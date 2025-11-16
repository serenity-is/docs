[serenity-is/corelib](../README.md) / StaticPanelAttribute

# Class: StaticPanelAttribute

Defined in: [src/types/attributes.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L86)

Indicates if a dialog should be a static panel, which is not a dialog at all,
but a simple div element embedded in the page.
It does not have a title bar, close button or modal behavior.
It is just a way to show a form inside a page, without any dialog stuff.

## Extends

- [`CustomAttribute`](CustomAttribute.md)

## Constructors

### Constructor

> **new StaticPanelAttribute**(`value`): `StaticPanelAttribute`

Defined in: [src/types/attributes.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L89)

#### Parameters

##### value

`boolean` = `true`

#### Returns

`StaticPanelAttribute`

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`constructor`](CustomAttribute.md#constructor)

## Properties

### value

> **value**: `boolean` = `true`

Defined in: [src/types/attributes.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L89)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/types/attributes.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L87)

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`[typeInfo]`](CustomAttribute.md#typeinfo)
