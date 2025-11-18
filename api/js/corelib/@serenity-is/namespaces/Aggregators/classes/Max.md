[@serenity-is/corelib](../../../../README.md) / [Aggregators](../README.md) / Max

# Class: Max

Defined in: [src/slick/aggregators.ts:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L125)

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new Max**(`field`): `Max`

Defined in: [src/slick/aggregators.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L128)

#### Parameters

##### field

`string`

#### Returns

`Max`

## Properties

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L128)

***

### max

> **max**: `any`

Defined in: [src/slick/aggregators.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L126)

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"max"` = `"max"`

Defined in: [src/slick/aggregators.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L152)

***

### summaryType

> `readonly` `static` **summaryType**: [`Max`](../../../../enumerations/SummaryType.md#max) = `SummaryType.Max`

Defined in: [src/slick/aggregators.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L151)

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L153)

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L135)

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

Defined in: [src/slick/aggregators.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L131)

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L144)

#### Parameters

##### groupTotals

`any`

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)
