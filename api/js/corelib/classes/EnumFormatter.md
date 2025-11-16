[corelib](../README.md) / EnumFormatter

# Class: EnumFormatter

Defined in: [src/ui/formatters/enumformatter.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L6)

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new EnumFormatter**(`props`): `EnumFormatter`

Defined in: [src/ui/formatters/enumformatter.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L9)

#### Parameters

##### props

###### enumKey?

`string`

#### Returns

`EnumFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/enumformatter.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L9)

#### enumKey?

> `optional` **enumKey**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/enumformatter.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L7)

## Accessors

### enumKey

#### Get Signature

> **get** **enumKey**(): `string`

Defined in: [src/ui/formatters/enumformatter.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L26)

##### Returns

`string`

#### Set Signature

> **set** **enumKey**(`value`): `void`

Defined in: [src/ui/formatters/enumformatter.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L27)

##### Parameters

###### value

`string`

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/enumformatter.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L13)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`FormatterResult`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### format()

> `static` **format**(`enumType`, `value`): `string`

Defined in: [src/ui/formatters/enumformatter.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L29)

#### Parameters

##### enumType

`any`

##### value

`any`

#### Returns

`string`

***

### getName()

> `static` **getName**(`enumType`, `value`): `string`

Defined in: [src/ui/formatters/enumformatter.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L48)

#### Parameters

##### enumType

`any`

##### value

`any`

#### Returns

`string`

***

### getText()

> `static` **getText**(`enumKey`, `name`): `string`

Defined in: [src/ui/formatters/enumformatter.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/enumformatter.ts#L41)

#### Parameters

##### enumKey

`string`

##### name

`string`

#### Returns

`string`
