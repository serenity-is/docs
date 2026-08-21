[@serenity-is/corelib](../../../../README.md) / [Aggregators](../README.md) / WeightedAvg

# Class: WeightedAvg

Defined in: [src/slick/aggregators.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L68)

Weighted average given a value field and a weight field.

## Implements

- [`IAggregator`](../../../../interfaces/IAggregator.md)

## Constructors

### Constructor

> **new WeightedAvg**(`field`, `weightedField`): `WeightedAvg`

Defined in: [src/slick/aggregators.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L79)

Creates a new weighted average aggregator.

#### Parameters

##### field

`string`

The value field name.

##### weightedField

`string`

The weight field name.

#### Returns

`WeightedAvg`

## Properties

### field

> `readonly` **field**: `string`

Defined in: [src/slick/aggregators.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L79)

The value field name.

***

### sum

> **sum**: `number`

Defined in: [src/slick/aggregators.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L70)

Weighted sum of values.

***

### weightedField

> `readonly` **weightedField**: `string`

Defined in: [src/slick/aggregators.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L80)

The weight field name.

***

### weightedSum

> **weightedSum**: `number`

Defined in: [src/slick/aggregators.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L72)

Sum of weights.

***

### aggregateKey

> `readonly` `static` **aggregateKey**: `"weightedAvg"` = `"weightedAvg"`

Defined in: [src/slick/aggregators.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L120)

Key used to store/lookup this aggregator in totals.

## Accessors

### displayName

#### Get Signature

> **get** `static` **displayName**(): `string`

Defined in: [src/slick/aggregators.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L122)

Localized display name for this aggregator.

##### Returns

`string`

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L90)

Accumulates a single item into the aggregator state.

#### Parameters

##### item

`any`

Row item to accumulate; both value and weight fields must contain valid numeric values.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`accumulate`](../../../../interfaces/IAggregator.md#accumulate)

***

### init()

> **init**(): `void`

Defined in: [src/slick/aggregators.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L84)

Initializes state before a new group is processed.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`init`](../../../../interfaces/IAggregator.md#init)

***

### storeResult()

> **storeResult**(`groupTotals`): `void`

Defined in: [src/slick/aggregators.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L101)

Writes computed totals into the group totals object.

#### Parameters

##### groupTotals

`any`

Totals container to write the computed weighted average into, keyed by field name.

#### Returns

`void`

#### Implementation of

[`IAggregator`](../../../../interfaces/IAggregator.md).[`storeResult`](../../../../interfaces/IAggregator.md#storeresult)

***

### isValid()

> `static` **isValid**(`val`): `boolean`

Defined in: [src/slick/aggregators.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L115)

Checks if a value is valid for aggregation.

#### Parameters

##### val

`any`

The value to check.

#### Returns

`boolean`

True if valid.
