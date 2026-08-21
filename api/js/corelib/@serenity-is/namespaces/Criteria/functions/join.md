[@serenity-is/corelib](../../../../README.md) / [Criteria](../README.md) / join

# Function: join()

> **join**(`c1`, `op`, `c2`): `any`[]

Defined in: [src/base/criteria.ts:895](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L895)

Joins two criteria with an operator, skipping empty sides.

## Parameters

### c1

`any`[]

Left criteria. If empty, `c2` is returned as-is.

### op

`string`

Join operator, typically `"and"` or `"or"` / `"xor"`.

### c2

`any`[]

Right criteria. If empty, `c1` is returned as-is.

## Returns

`any`[]

`[c1, op, c2]` or whichever side is non-empty, if the other is empty.
