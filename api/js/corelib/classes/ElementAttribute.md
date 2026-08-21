[@serenity-is/corelib](../README.md) / ElementAttribute

# Class: ElementAttribute

Defined in: [src/types/attributes.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L23)

Specifies the root element tag for a widget (e.g. `"div"`, `"span"`).
Used by the widget factory to create the default DOM element.

## Extends

- [`CustomAttribute`](CustomAttribute.md)

## Constructors

### Constructor

> **new ElementAttribute**(`value`): `ElementAttribute`

Defined in: [src/types/attributes.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L30)

Creates a new ElementAttribute.

#### Parameters

##### value

`string`

Tag name for the widget's root element (e.g. `"div"`).

#### Returns

`ElementAttribute`

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`constructor`](CustomAttribute.md#constructor)

## Properties

### value

> **value**: `string`

Defined in: [src/types/attributes.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L30)

Tag name for the widget's root element (e.g. `"div"`).

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/types/attributes.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/attributes.ts#L24)

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`[typeInfo]`](CustomAttribute.md#typeinfo)
