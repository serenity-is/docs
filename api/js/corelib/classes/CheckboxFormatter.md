[@serenity-is/corelib](../README.md) / CheckboxFormatter

# Class: CheckboxFormatter

Defined in: [src/ui/formatters/checkboxformatter.tsx:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L9)

Renders a boolean as a checkbox-like visual (with optional text). In grid display
the checkbox is read-only; in header-filter context it falls back to text/icon.

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new CheckboxFormatter**(`props`): `CheckboxFormatter`

Defined in: [src/ui/formatters/checkboxformatter.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L24)

Creates a new CheckboxFormatter.

#### Parameters

##### props

Formatter options.

###### falseIcon?

[`IconClassName`](../type-aliases/IconClassName.md)

Icon for `false`.

###### falseText?

`string`

Text for `false`.

###### nullIcon?

[`IconClassName`](../type-aliases/IconClassName.md)

Icon for `null`.

###### nullText?

`string`

Text for `null`.

###### showHint?

`boolean`

Whether to surface text as `title` hint.

###### showText?

`boolean`

Whether to show text (defaults to `true`, or `false` in grid cells).

###### trueIcon?

[`IconClassName`](../type-aliases/IconClassName.md)

Icon for `true`.

###### trueText?

`string`

Text for `true`.

#### Returns

`CheckboxFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/checkboxformatter.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L24)

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

Defined in: [src/ui/formatters/checkboxformatter.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L10)

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/checkboxformatter.tsx:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L42)

Formats the boolean value as a checkbox or icon/text markup.

#### Parameters

##### ctx

`FormatterContext`

Formatter context containing the cell value.

#### Returns

`FormatterResult`

Checkbox, icon, or text markup for the cell.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)
