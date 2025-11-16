[serenity-is/corelib](../../../../README.md) / [Aggregators](../README.md) / Avg

# Class: Avg

Defined in: [src/slick/aggregators.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L11)

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new Avg**(`field`): `Avg`

Defined in: [src/slick/aggregators.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L16)

#### Parameters

##### field

`string`

#### Returns

`Avg`

## Properties

### count

> **count**: `number`

Defined in: [src/slick/aggregators.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L12)

***

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L16)

***

### nonNullCount

> **nonNullCount**: `number`

Defined in: [src/slick/aggregators.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L13)

***

### sum

> **sum**: `number`

Defined in: [src/slick/aggregators.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L14)

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"avg"` = `"avg"`

Defined in: [src/slick/aggregators.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L42)

***

### summaryType

> `readonly` `static` **summaryType**: [`Avg`](../../../../enumerations/SummaryType.md#avg) = `SummaryType.Avg`

Defined in: [src/slick/aggregators.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L41)

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L43)

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L25)

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

Defined in: [src/slick/aggregators.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L19)

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L34)

#### Parameters

##### groupTotals

`IGroupTotals`

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)
