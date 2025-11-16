[serenity-is/corelib](../README.md) / BooleanFormatter

# Class: BooleanFormatter

Defined in: [src/ui/formatters/booleanformatter.tsx:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L5)

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new BooleanFormatter**(`props`): `BooleanFormatter`

Defined in: [src/ui/formatters/booleanformatter.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L8)

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

`BooleanFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/booleanformatter.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L8)

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

Defined in: [src/ui/formatters/booleanformatter.tsx:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L6)

## Accessors

### falseText

#### Get Signature

> **get** **falseText**(): `string`

Defined in: [src/ui/formatters/booleanformatter.tsx:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L48)

##### Returns

`string`

#### Set Signature

> **set** **falseText**(`value`): `void`

Defined in: [src/ui/formatters/booleanformatter.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L49)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### trueText

#### Get Signature

> **get** **trueText**(): `string`

Defined in: [src/ui/formatters/booleanformatter.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L51)

##### Returns

`string`

#### Set Signature

> **set** **trueText**(`value`): `void`

Defined in: [src/ui/formatters/booleanformatter.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L52)

##### Parameters

###### value

`string`

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/booleanformatter.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/booleanformatter.tsx#L21)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`FormatterResult`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)
