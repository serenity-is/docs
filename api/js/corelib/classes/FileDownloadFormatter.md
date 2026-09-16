[@serenity-is/corelib](../README.md) / FileDownloadFormatter

# Class: FileDownloadFormatter

Defined in: [src/ui/formatters/filedownloadformatter.tsx:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L7)

Renders a DB file path as a download link with an icon and optional original name.

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Constructors

### Constructor

> **new FileDownloadFormatter**(`props`): `FileDownloadFormatter`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L17)

Creates a new FileDownloadFormatter.

#### Parameters

##### props

Formatter options.

###### displayFormat?

`string`

Format string for link text (default `"{0}"`).

###### iconClass?

`string`

Icon class for the download icon.

###### originalNameProperty?

`string`

Field holding the original file name.

#### Returns

`FileDownloadFormatter`

## Properties

### props

> `readonly` **props**: `object` = `{}`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L17)

Formatter options.

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

Defined in: [src/ui/formatters/filedownloadformatter.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L67)

Gets the format string for link text.

##### Returns

`string`

The display format.

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L72)

Sets the format string for link text.

##### Parameters

###### value

`string`

The display format string.

##### Returns

`void`

***

### iconClass

#### Get Signature

> **get** **iconClass**(): `string`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L83)

Gets the icon class for the download icon.

##### Returns

`string`

The icon class.

#### Set Signature

> **set** **iconClass**(`value`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L88)

Sets the icon class for the download icon.

##### Parameters

###### value

`string`

The icon class.

##### Returns

`void`

***

### originalNameProperty

#### Get Signature

> **get** **originalNameProperty**(): `string`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L75)

Gets the field holding the original file name.

##### Returns

`string`

The original name property.

#### Set Signature

> **set** **originalNameProperty**(`value`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L80)

Sets the field holding the original file name.

##### Parameters

###### value

`string`

The original name property.

##### Returns

`void`

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L26)

Formats the stored file path as a download link.

#### Parameters

##### ctx

`FormatterContext`

Formatter context containing the cell value and row item.

#### Returns

`FormatterResult`

Anchor element markup or an empty string if the value is empty.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### initializeColumn()

> **initializeColumn**(`column`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L58)

Declares `originalNameProperty` as a referenced field so it is fetched for formatting.

#### Parameters

##### column

`Column`

Column being initialized.

#### Returns

`void`

#### Implementation of

[`IInitializeColumn`](IInitializeColumn.md).[`initializeColumn`](IInitializeColumn.md#initializecolumn)

***

### dbFileUrl()

> `static` **dbFileUrl**(`filename`): `string`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L49)

Builds the download URL for a temp/upload file.

#### Parameters

##### filename

`string`

Stored file path.

#### Returns

`string`

Resolved URL under `~/upload/`.
