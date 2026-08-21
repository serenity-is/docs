[@serenity-is/corelib](../../../../README.md) / [Criteria](../README.md) / or

# Function: or()

> **or**(`c1`, `c2`, ...`rest`): `any`[]

Defined in: [src/base/criteria.ts:942](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L942)

Combines two or more criteria with `or`, skipping empty entries.

## Parameters

### c1

`any`[]

First criteria.

### c2

`any`[]

Second criteria.

### rest

...`any`[][]

Additional criteria joined incrementally with `or`.

## Returns

`any`[]

Combined criteria or the sole non-empty input if others are empty.
