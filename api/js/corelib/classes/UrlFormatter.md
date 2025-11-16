[corelib](../README.md) / UrlFormatter

# Class: UrlFormatter

Defined in: [src/ui/formatters/urlformatter.tsx:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L6)

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Constructors

### Constructor

> **new UrlFormatter**(`props`): `UrlFormatter`

Defined in: [src/ui/formatters/urlformatter.tsx:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L9)

#### Parameters

##### props

###### displayFormat?

`string`

###### displayProperty?

`string`

###### target?

`string`

###### urlFormat?

`string`

###### urlProperty?

`string`

#### Returns

`UrlFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/urlformatter.tsx:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L9)

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

Defined in: [src/ui/formatters/urlformatter.tsx:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L7)

#### Implementation of

[`IInitializeColumn`](IInitializeColumn.md).[`[typeInfo]`](IInitializeColumn.md#typeinfo)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L52)

##### Returns

`string`

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L53)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### displayProperty

#### Get Signature

> **get** **displayProperty**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L49)

##### Returns

`string`

#### Set Signature

> **set** **displayProperty**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L50)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### target

#### Get Signature

> **get** **target**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L61)

##### Returns

`string`

#### Set Signature

> **set** **target**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L62)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### urlFormat

#### Get Signature

> **get** **urlFormat**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L58)

##### Returns

`string`

#### Set Signature

> **set** **urlFormat**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L59)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### urlProperty

#### Get Signature

> **get** **urlProperty**(): `string`

Defined in: [src/ui/formatters/urlformatter.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L55)

##### Returns

`string`

#### Set Signature

> **set** **urlProperty**(`value`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L56)

##### Parameters

###### value

`string`

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/urlformatter.tsx:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L13)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`FormatterResult`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### initializeColumn()

> **initializeColumn**(`column`): `void`

Defined in: [src/ui/formatters/urlformatter.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/urlformatter.tsx#L37)

#### Parameters

##### column

`Column`

#### Returns

`void`

#### Implementation of

[`IInitializeColumn`](IInitializeColumn.md).[`initializeColumn`](IInitializeColumn.md#initializecolumn)
