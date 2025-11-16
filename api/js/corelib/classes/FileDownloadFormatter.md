[corelib](../README.md) / FileDownloadFormatter

# Class: FileDownloadFormatter

Defined in: [src/ui/formatters/filedownloadformatter.tsx:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L7)

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Constructors

### Constructor

> **new FileDownloadFormatter**(`props`): `FileDownloadFormatter`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L10)

#### Parameters

##### props

###### displayFormat?

`string`

###### iconClass?

`string`

###### originalNameProperty?

`string`

#### Returns

`FileDownloadFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L10)

#### displayFormat?

> `optional` **displayFormat**: `string`

#### iconClass?

> `optional` **iconClass**: `string`

#### originalNameProperty?

> `optional` **originalNameProperty**: `string`

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/filedownloadformatter.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L8)

#### Implementation of

[`IInitializeColumn`](IInitializeColumn.md).[`[typeInfo]`](IInitializeColumn.md#typeinfo)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L45)

##### Returns

`string`

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L46)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### iconClass

#### Get Signature

> **get** **iconClass**(): `string`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L51)

##### Returns

`string`

#### Set Signature

> **set** **iconClass**(`value`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L52)

##### Parameters

###### value

`string`

##### Returns

`void`

***

### originalNameProperty

#### Get Signature

> **get** **originalNameProperty**(): `string`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L48)

##### Returns

`string`

#### Set Signature

> **set** **originalNameProperty**(`value`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L49)

##### Parameters

###### value

`string`

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L14)

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

Defined in: [src/ui/formatters/filedownloadformatter.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L37)

#### Parameters

##### column

`Column`

#### Returns

`void`

#### Implementation of

[`IInitializeColumn`](IInitializeColumn.md).[`initializeColumn`](IInitializeColumn.md#initializecolumn)

***

### dbFileUrl()

> `static` **dbFileUrl**(`filename`): `string`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L32)

#### Parameters

##### filename

`string`

#### Returns

`string`
