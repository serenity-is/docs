[serenity-is/corelib](../README.md) / IAggregator

# Interface: IAggregator

Defined in: [src/slick/aggregators.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L4)

## Methods

### accumulate()

> **accumulate**(`item`): `void`

Defined in: [src/slick/aggregators.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L6)

#### Parameters

##### item

`any`

#### Returns

`void`

***

### init()

> **init**(): `void`

Defined in: [src/slick/aggregators.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L5)

#### Returns

`void`

***

### storeResult()

> **storeResult**(`totals`): `void`

Defined in: [src/slick/aggregators.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/aggregators.ts#L7)

#### Parameters

##### totals

`IGroupTotals`

#### Returns

`void`
