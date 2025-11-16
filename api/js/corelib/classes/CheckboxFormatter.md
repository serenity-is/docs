[corelib](../README.md) / CheckboxFormatter

# Class: CheckboxFormatter

Defined in: [src/ui/formatters/checkboxformatter.tsx:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L5)

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new CheckboxFormatter**(`props`): `CheckboxFormatter`

Defined in: [src/ui/formatters/checkboxformatter.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L8)

#### Parameters

##### props

###### falseIcon?

[`IconClassName`](../type-aliases/IconClassName.md)

###### falseText?

`string`

###### nullIcon?

[`IconClassName`](../type-aliases/IconClassName.md)

###### nullText?

`string`

###### showHint?

`boolean`

###### showText?

`boolean`

###### trueIcon?

[`IconClassName`](../type-aliases/IconClassName.md)

###### trueText?

`string`

#### Returns

`CheckboxFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/checkboxformatter.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L8)

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

Defined in: [src/ui/formatters/checkboxformatter.tsx:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L6)

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/checkboxformatter.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/checkboxformatter.tsx#L21)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`FormatterResult`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)
