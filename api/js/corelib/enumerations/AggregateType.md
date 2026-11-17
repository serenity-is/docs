[@serenity-is/corelib](../README.md) / AggregateType

# Enumeration: AggregateType

Defined in: [src/base/servicetypes.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L187)

The kind of a value that is calculated from the rows of a list request. The values of the ones that are
also in `SummaryType` are the same.

## Enumeration Members

### Avg

> **Avg**: `2`

Defined in: [src/base/servicetypes.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L193)

The average of the values of the field, without the null ones.

***

### Count

> **Count**: `0`

Defined in: [src/base/servicetypes.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L189)

The number of the rows, or of the rows whose field is not null when a field is given.

***

### DistinctCount

> **DistinctCount**: `5`

Defined in: [src/base/servicetypes.ts:199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L199)

The number of the different values of the field, without null.

***

### Max

> **Max**: `4`

Defined in: [src/base/servicetypes.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L197)

The largest value of the field.

***

### Min

> **Min**: `3`

Defined in: [src/base/servicetypes.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L195)

The smallest value of the field.

***

### Sum

> **Sum**: `1`

Defined in: [src/base/servicetypes.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L191)

The sum of the values of the field.
