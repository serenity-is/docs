[serenity-is/corelib](../../../../README.md) / [Aggregators](../README.md) / Min

# Class: Min

Defined in: [src/slick/aggregators.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L90)

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new Min**(`field`): `Min`

Defined in: [src/slick/aggregators.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L94)

#### Parameters

##### field

`string`

#### Returns

`Min`

## Properties

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L91)

***

### min

> **min**: `any`

Defined in: [src/slick/aggregators.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L92)

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"min"` = `"min"`

Defined in: [src/slick/aggregators.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L119)

***

### summaryType

> `readonly` `static` **summaryType**: [`Min`](../../../../enumerations/SummaryType.md#min) = `SummaryType.Min`

Defined in: [src/slick/aggregators.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L118)

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L120)

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L102)

#### Parameters

##### item

`any`

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`accumulate`](../../../../interfaces/IAggregator.md#accumulate)

***

### init()

> **init**(): `void`

Defined in: [src/slick/aggregators.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L98)

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L111)

#### Parameters

##### groupTotals

`any`

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)
