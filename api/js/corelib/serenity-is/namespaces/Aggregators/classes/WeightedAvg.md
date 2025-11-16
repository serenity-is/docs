[serenity-is/corelib](../../../../README.md) / [Aggregators](../README.md) / WeightedAvg

# Class: WeightedAvg

Defined in: [src/slick/aggregators.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L48)

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new WeightedAvg**(`field`, `weightedField`): `WeightedAvg`

Defined in: [src/slick/aggregators.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L52)

#### Parameters

##### field

`string`

##### weightedField

`string`

#### Returns

`WeightedAvg`

## Properties

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L52)

***

### sum

> **sum**: `number`

Defined in: [src/slick/aggregators.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L49)

***

### weightedField

> `readonly` **weightedField**: `string`

Defined in: [src/slick/aggregators.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L53)

***

### weightedSum

> **weightedSum**: `number`

Defined in: [src/slick/aggregators.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L50)

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"weightedAvg"` = `"weightedAvg"`

Defined in: [src/slick/aggregators.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L84)

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L85)

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L61)

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

Defined in: [src/slick/aggregators.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L56)

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L71)

#### Parameters

##### groupTotals

`any`

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)

***

### isValid()

> `static` **isValid**(`val`): `boolean`

Defined in: [src/slick/aggregators.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L80)

#### Parameters

##### val

`any`

#### Returns

`boolean`
