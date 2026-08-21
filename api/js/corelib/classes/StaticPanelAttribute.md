[@serenity-is/corelib](../README.md) / StaticPanelAttribute

# Class: StaticPanelAttribute

Defined in: [src/types/attributes.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L113)

Indicates that the widget should render as a static panel (plain div embedded
in the page without title bar / modal behavior).
Useful for embedding widgets directly in page layout.

## Extends

- [`CustomAttribute`](CustomAttribute.md)

## Constructors

### Constructor

> **new StaticPanelAttribute**(`value`): `StaticPanelAttribute`

Defined in: [src/types/attributes.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L120)

Creates a new StaticPanelAttribute.

#### Parameters

##### value

`boolean` = `true`

Whether the widget should render as a static panel. Defaults to `true`.

#### Returns

`StaticPanelAttribute`

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`constructor`](CustomAttribute.md#constructor)

## Properties

### value

> **value**: `boolean` = `true`

Defined in: [src/types/attributes.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L120)

Whether the widget should render as a static panel. Defaults to `true`.

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/types/attributes.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L114)

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`[typeInfo]`](CustomAttribute.md#typeinfo)
