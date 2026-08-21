[@serenity-is/corelib](../README.md) / IAggregator

# Interface: IAggregator

Defined in: [src/slick/aggregators.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L5)

Contract for group/total aggregators (avg/min/max/sum etc.).

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L9)

Accumulates a single item into the aggregator state.

#### Parameters

##### item

`any`

Row item.

#### Returns

`void`

***

### init()

> **init**(): `void`

Defined in: [src/slick/aggregators.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L7)

Initializes state before a new group is processed.

#### Returns

`void`

***

### storeResult()

> **storeResult**(`totals`): `void`

Defined in: [src/slick/aggregators.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L11)

Writes computed totals into the group totals object.

#### Parameters

##### totals

`IGroupTotals`

Totals container keyed by aggregateKey.

#### Returns

`void`
