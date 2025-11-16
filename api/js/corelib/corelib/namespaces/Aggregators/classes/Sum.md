[corelib](../../../../README.md) / [Aggregators](../README.md) / Sum

# Class: Sum

Defined in: [src/slick/aggregators.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L158)

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new Sum**(`field`): `Sum`

Defined in: [src/slick/aggregators.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L162)

#### Parameters

##### field

`string`

#### Returns

`Sum`

## Properties

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L159)

***

### sum

> **sum**: `number`

Defined in: [src/slick/aggregators.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L160)

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"sum"` = `"sum"`

Defined in: [src/slick/aggregators.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L185)

***

### summaryType

> `readonly` `static` **summaryType**: [`Sum`](../../../../enumerations/SummaryType.md#sum) = `SummaryType.Sum`

Defined in: [src/slick/aggregators.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L184)

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L186)

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L170)

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

Defined in: [src/slick/aggregators.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L166)

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L177)

#### Parameters

##### groupTotals

`any`

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)
