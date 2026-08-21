[@serenity-is/corelib](../README.md) / FileDownloadFormatter

# Class: FileDownloadFormatter

Defined in: [src/ui/formatters/filedownloadformatter.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L8)

Renders a DB file path as a download link with an icon and optional original name.

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Constructors

### Constructor

> **new FileDownloadFormatter**(`props`): `FileDownloadFormatter`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L18)

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

Defined in: [src/ui/formatters/filedownloadformatter.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L18)

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

Defined in: [src/ui/formatters/filedownloadformatter.tsx:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L9)

#### Implementation of

[`IInitializeColumn`](IInitializeColumn.md).[`[typeInfo]`](IInitializeColumn.md#typeinfo)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L68)

Gets the format string for link text.

##### Returns

`string`

The display format.

#### Set Signature

> **set** **displayFormat**(`value`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L73)

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

Defined in: [src/ui/formatters/filedownloadformatter.tsx:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L84)

Gets the icon class for the download icon.

##### Returns

`string`

The icon class.

#### Set Signature

> **set** **iconClass**(`value`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L89)

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

Defined in: [src/ui/formatters/filedownloadformatter.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L76)

Gets the field holding the original file name.

##### Returns

`string`

The original name property.

#### Set Signature

> **set** **originalNameProperty**(`value`): `void`

Defined in: [src/ui/formatters/filedownloadformatter.tsx:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L81)

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

Defined in: [src/ui/formatters/filedownloadformatter.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L27)

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

Defined in: [src/ui/formatters/filedownloadformatter.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L59)

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

Defined in: [src/ui/formatters/filedownloadformatter.tsx:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/filedownloadformatter.tsx#L50)

Builds the download URL for a temp/upload file.

#### Parameters

##### filename

`string`

Stored file path.

#### Returns

`string`

Resolved URL under `~/upload/`.
