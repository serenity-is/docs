[@serenity-is/corelib](../README.md) / BooleanFormatter

# Class: BooleanFormatter

Defined in: [src/ui/formatters/booleanformatter.tsx:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L9)

Renders a boolean value as localized text and/or an icon.
Falls back to `DialogTexts.YesButton` / `NoButton` when no explicit texts are provided.

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new BooleanFormatter**(`props`): `BooleanFormatter`

Defined in: [src/ui/formatters/booleanformatter.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L24)

Creates a new BooleanFormatter.

#### Parameters

##### props

Formatter options.

###### falseIcon?

[`IconClassName`](../type-aliases/IconClassName.md)

Icon class for `false` values.

###### falseText?

`string`

Text for `false` values.

###### nullIcon?

[`IconClassName`](../type-aliases/IconClassName.md)

Icon class for `null` values.

###### nullText?

`string`

Text for `null` values.

###### showHint?

`boolean`

Whether to show text as `title` hint.

###### showText?

`boolean`

Whether to show text alongside icon (default `true`).

###### trueIcon?

[`IconClassName`](../type-aliases/IconClassName.md)

Icon class for `true` values.

###### trueText?

`string`

Text for `true` values.

#### Returns

`BooleanFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/booleanformatter.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L24)

Formatter options.

#### falseIcon?

> `optional` **falseIcon**: [`IconClassName`](../type-aliases/IconClassName.md)

#### falseText?

> `optional` **falseText**: `string`

#### nullIcon?

> `optional` **nullIcon**: [`IconClassName`](../type-aliases/IconClassName.md)

#### nullText?

> `optional` **nullText**: `string`

#### showHint?

> `optional` **showHint**: `boolean`

#### showText?

> `optional` **showText**: `boolean`

#### trueIcon?

> `optional` **trueIcon**: [`IconClassName`](../type-aliases/IconClassName.md)

#### trueText?

> `optional` **trueText**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/booleanformatter.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L10)

## Accessors

### falseText

#### Get Signature

> **get** **falseText**(): `string`

Defined in: [src/ui/formatters/booleanformatter.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L70)

Gets the text for `false` values.

##### Returns

`string`

The false text.

#### Set Signature

> **set** **falseText**(`value`): `void`

Defined in: [src/ui/formatters/booleanformatter.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L75)

Sets the text for `false` values.

##### Parameters

###### value

`string`

The false text.

##### Returns

`void`

***

### trueText

#### Get Signature

> **get** **trueText**(): `string`

Defined in: [src/ui/formatters/booleanformatter.tsx:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L78)

Gets the text for `true` values.

##### Returns

`string`

The true text.

#### Set Signature

> **set** **trueText**(`value`): `void`

Defined in: [src/ui/formatters/booleanformatter.tsx:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L83)

Sets the text for `true` values.

##### Parameters

###### value

`string`

The true text.

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/booleanformatter.tsx:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L42)

Formats the boolean value for display.

#### Parameters

##### ctx

`FormatterContext`

Formatter context with value/item/column.

#### Returns

`FormatterResult`

Text, icon, or combined span per `props`.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)
