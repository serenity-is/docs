[@serenity-is/corelib](../../../../README.md) / [Criteria](../README.md) / and

# Function: and()

> **and**(`c1`, `c2`, ...`rest`): `any`[]

Defined in: [src/base/criteria.ts:924](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L924)

Combines two or more criteria with `and`, skipping empty entries.

## Parameters

### c1

`any`[]

First criteria.

### c2

`any`[]

Second criteria.

### rest

...`any`[][]

Additional criteria joined incrementally with `and`.

## Returns

`any`[]

Combined criteria or the sole non-empty input if others are empty.
