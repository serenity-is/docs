[@serenity-is/corelib](../README.md) / BigIntFormatter

# Class: BigIntFormatter

Defined in: [src/ui/formatters/bigintformatter.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L16)

Formats big integer values, including values outside the JavaScript safe integer range
(2^53) that arrive as strings, without losing precision.

## Remarks

Values that fit in the safe integer range (including numeric strings and small
bigints) are delegated to [NumberFormatter](NumberFormatter.md). Only integers outside that range are
formatted from their `bigint` representation, so no digits are lost.

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new BigIntFormatter**(`props`): `BigIntFormatter`

Defined in: [src/ui/formatters/bigintformatter.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L24)

Creates a BigIntFormatter.

#### Parameters

##### props

Formatter options.

###### displayFormat?

`string`

Number format string (default `"0"`).

#### Returns

`BigIntFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/bigintformatter.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L24)

Formatter options.

#### displayFormat?

> `optional` **displayFormat**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/bigintformatter.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L17)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

Defined in: [src/ui/formatters/bigintformatter.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L164)

Gets the number display format.

##### Returns

`string`

The display format string.

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/bigintformatter.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L169)

Sets the number display format.

##### Parameters

###### value

`string`

The display format string.

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `string`

Defined in: [src/ui/formatters/bigintformatter.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L33)

Formats the cell value as an integer string.

#### Parameters

##### ctx

`FormatterContext`

Formatter context containing the cell value.

#### Returns

`string`

Formatted integer string.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### formatBigInt()

> `static` **formatBigInt**(`value`, `format?`): `string`

Defined in: [src/ui/formatters/bigintformatter.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L106)

Formats a bigint using .NET-style integer format strings and [Culture](../variables/Culture.md) settings.

#### Parameters

##### value

`bigint`

Value to format.

##### format?

`string`

Format specifier: `"g"`, `"d"`, `"n"`, `"x"`, or a custom pattern (`"#,##0"`, `"000"`, etc.). Defaults to `"0"`.

#### Returns

`string`

The formatted integer string.

***

### formatValue()

> `static` **formatValue**(`value`, `format?`): `string`

Defined in: [src/ui/formatters/bigintformatter.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L44)

Static helper to format any big integer value (number, numeric string or bigint).
This does not HTML encode the return value.

#### Parameters

##### value

`any`

Number, numeric string or bigint.

##### format?

`string`

Format string (default `"0"`).

#### Returns

`string`

Formatted string.

***

### getAsBigIntIfUnsafe()

> `static` **getAsBigIntIfUnsafe**(`value`): `bigint`

Defined in: [src/ui/formatters/bigintformatter.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/bigintformatter.ts#L71)

Returns the value as a bigint only when it is an integer outside the safe JavaScript
integer range (where a number would lose precision); otherwise `null`, so the caller
can delegate to the number formatter.

#### Parameters

##### value

`any`

Number, numeric string or bigint.

#### Returns

`bigint`

The value as a bigint, or `null`.
