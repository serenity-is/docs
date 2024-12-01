[@serenity-is/corelib](../README.md) / UrlFormatter

# Class: UrlFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Constructors

### new UrlFormatter()

> **new UrlFormatter**(`props`): [`UrlFormatter`](UrlFormatter.md)

#### Parameters

##### props

###### props.displayFormat

`string`

###### props.displayProperty

`string`

###### props.target

`string`

###### props.urlFormat

`string`

###### props.urlProperty

`string`

#### Returns

[`UrlFormatter`](UrlFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L260)

## Properties

### props

> `readonly` **props**: `object` = `{}`

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

#### Defined in

[src/ui/formatters/formatters.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L260)

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

[src/ui/formatters/formatters.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L308)

***

### displayProperty

#### Get Signature

> **get** **displayProperty**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **displayProperty**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L305)

***

### target

#### Get Signature

> **get** **target**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **target**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L317)

***

### urlFormat

#### Get Signature

> **get** **urlFormat**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **urlFormat**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L314)

***

### urlProperty

#### Get Signature

> **get** **urlProperty**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **urlProperty**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:311](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L311)

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

[src/ui/formatters/formatters.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L264)

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

[src/ui/formatters/formatters.ts:293](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L293)
