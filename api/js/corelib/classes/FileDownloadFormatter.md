[@serenity-is/corelib](../README.md) / FileDownloadFormatter

# Class: FileDownloadFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Constructors

### new FileDownloadFormatter()

> **new FileDownloadFormatter**(`props`): [`FileDownloadFormatter`](FileDownloadFormatter.md)

#### Parameters

##### props

###### props.displayFormat

`string`

###### props.iconClass

`string`

###### props.originalNameProperty

`string`

#### Returns

[`FileDownloadFormatter`](FileDownloadFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L149)

## Properties

### props

> `readonly` **props**: `object` = `{}`

#### displayFormat?

> `optional` **displayFormat**: `string`

#### iconClass?

> `optional` **iconClass**: `string`

#### originalNameProperty?

> `optional` **originalNameProperty**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L149)

## Accessors

### displayFormat

#### Get Signature

> **get** **displayFormat**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **displayFormat**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L185)

***

### iconClass

#### Get Signature

> **get** **iconClass**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **iconClass**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L191)

***

### originalNameProperty

#### Get Signature

> **get** **originalNameProperty**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **originalNameProperty**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L188)

## Methods

### format()

> **format**(`ctx`): `string`

#### Parameters

##### ctx

`FormatterContext`\<`any`\>

#### Returns

`string`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

#### Defined in

[src/ui/formatters/formatters.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L153)

***

### initializeColumn()

> **initializeColumn**(`column`): `void`

#### Parameters

##### column

`Column`\<`any`\>

#### Returns

`void`

#### Implementation of

[`IInitializeColumn`](IInitializeColumn.md).[`initializeColumn`](IInitializeColumn.md#initializecolumn)

#### Defined in

[src/ui/formatters/formatters.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L177)

***

### dbFileUrl()

> `static` **dbFileUrl**(`filename`): `string`

#### Parameters

##### filename

`string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L172)
