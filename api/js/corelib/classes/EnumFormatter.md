[@serenity-is/corelib](../README.md) / EnumFormatter

# Class: EnumFormatter

Defined in: [src/ui/formatters/enumformatter.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L7)

Renders enum values as localized text via `Enums.<EnumKey>.<Name>`.

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new EnumFormatter**(`props`): `EnumFormatter`

Defined in: [src/ui/formatters/enumformatter.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L15)

Creates a new EnumFormatter.

#### Parameters

##### props

Formatter options.

###### enumKey?

`string`

Full enum key (e.g. `"MyProject.MyEnum"`). Resolved via [EnumTypeRegistry](../variables/EnumTypeRegistry.md).

#### Returns

`EnumFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/enumformatter.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L15)

Formatter options.

#### enumKey?

> `optional` **enumKey**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/enumformatter.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L8)

## Accessors

### enumKey

#### Get Signature

> **get** **enumKey**(): `string`

Defined in: [src/ui/formatters/enumformatter.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L38)

Gets the enum key used to resolve the enum type.

##### Returns

`string`

The enum key.

#### Set Signature

> **set** **enumKey**(`value`): `void`

Defined in: [src/ui/formatters/enumformatter.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L43)

Sets the enum key used to resolve the enum type.

##### Parameters

###### value

`string`

The enum key.

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/enumformatter.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L24)

Formats the enum value as localized text.

#### Parameters

##### ctx

`FormatterContext`

Formatter context containing the enum value.

#### Returns

`FormatterResult`

Localized enum text or a placeholder element when the enum type loads asynchronously.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### format()

> `static` **format**(`enumType`, `value`): `string`

Defined in: [src/ui/formatters/enumformatter.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L51)

Formats an enum value given an enum type.

#### Parameters

##### enumType

`any`

Registered enum object.

##### value

`any`

Enum numeric value.

#### Returns

`string`

Localized display text.

***

### getName()

> `static` **getName**(`enumType`, `value`): `string`

Defined in: [src/ui/formatters/enumformatter.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L82)

Gets the member name for a value.

#### Parameters

##### enumType

`any`

Enum object.

##### value

`any`

Numeric value.

#### Returns

`string`

Enum member name or empty string.

***

### getText()

> `static` **getText**(`enumKey`, `name`): `string`

Defined in: [src/ui/formatters/enumformatter.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L69)

Gets localized text for an enum name.

#### Parameters

##### enumKey

`string`

Enum key (e.g. `"MyEnum"`).

##### name

`string`

Member name.

#### Returns

`string`

Localized string (falls back to name).
