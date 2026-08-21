[@serenity-is/corelib](../README.md) / UrlFormatter

# Class: UrlFormatter

Defined in: [src/ui/formatters/urlformatter.tsx:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L7)

Renders a value as a hyperlink with configurable URL / display mapping.

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Constructors

### Constructor

> **new UrlFormatter**(`props`): `UrlFormatter`

Defined in: [src/ui/formatters/urlformatter.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L19)

Creates a new UrlFormatter.

#### Parameters

##### props

Formatter options.

###### displayFormat?

`string`

Format string applied to display value.

###### displayProperty?

`string`

Item field used for link text (defaults to cell value).

###### target?

`string`

Anchor target (e.g. `"_blank"`).

###### urlFormat?

`string`

Format string applied to URL value.

###### urlProperty?

`string`

Item field used for URL (defaults to cell value).

#### Returns

`UrlFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/urlformatter.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L19)

Formatter options.

#### displayFormat?

> `optional` **displayFormat**: `string`

#### displayProperty?

> `optional` **displayProperty**: `string`

#### target?

> `optional` **target**: `string`

#### urlFormat?

> `optional` **urlFormat**: `string`

#### urlProperty?

> `optional` **urlProperty**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/urlformatter.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L8)

#### Implementation of

[`IInitializeColumn`](IInitializeColumn.md).[`[typeInfo]`](IInitializeColumn.md#typeinfo)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L76)

Gets the format string applied to the display value.

##### Returns

`string`

The display format.

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L81)

Sets the format string applied to the display value.

##### Parameters

###### value

`string`

The display format string.

##### Returns

`void`

***

### displayProperty

#### Get Signature

> **get** **displayProperty**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L68)

Gets the field used for link text.

##### Returns

`string`

The display property name.

#### Set Signature

> **set** **displayProperty**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L73)

Sets the field used for link text.

##### Parameters

###### value

`string`

The display property name.

##### Returns

`void`

***

### target

#### Get Signature

> **get** **target**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L100)

Gets the anchor target (e.g. `"_blank"`).

##### Returns

`string`

The target value.

#### Set Signature

> **set** **target**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L105)

Sets the anchor target.

##### Parameters

###### value

`string`

The target value (e.g. `"_blank"`).

##### Returns

`void`

***

### urlFormat

#### Get Signature

> **get** **urlFormat**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L92)

Gets the format string applied to the URL value.

##### Returns

`string`

The URL format.

#### Set Signature

> **set** **urlFormat**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L97)

Sets the format string applied to the URL value.

##### Parameters

###### value

`string`

The URL format string.

##### Returns

`void`

***

### urlProperty

#### Get Signature

> **get** **urlProperty**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L84)

Gets the field used for the URL.

##### Returns

`string`

The URL property name.

#### Set Signature

> **set** **urlProperty**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L89)

Sets the field used for the URL.

##### Parameters

###### value

`string`

The URL property name.

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/urlformatter.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L27)

Formats the cell value as a hyperlink.

#### Parameters

##### ctx

`FormatterContext`

Formatter context containing the cell value and row item.

#### Returns

`FormatterResult`

Anchor element markup or an empty string if the URL is empty.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### initializeColumn()

> **initializeColumn**(`column`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L55)

Declares any referenced fields so they are fetched for formatting.

#### Parameters

##### column

`Column`

Column being initialized.

#### Returns

`void`

#### Implementation of

[`IInitializeColumn`](IInitializeColumn.md).[`initializeColumn`](IInitializeColumn.md#initializecolumn)
