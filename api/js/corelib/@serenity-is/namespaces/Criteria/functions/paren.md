[@serenity-is/corelib](../../../../README.md) / [Criteria](../README.md) / paren

# Function: paren()

> **paren**(`c`): `any`[]

Defined in: [src/base/criteria.ts:962](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L962)

Wraps a criteria in parentheses (compatibility helper).

## Parameters

### c

`any`[]

Criteria to wrap.

## Returns

`any`[]

`["()", c]` or `c` if empty.

## Remarks

Produces `["()", c]`. The server treats this as a grouping no-op but it can
preserve intended precedence when criteria are serialized. Returns `c` unchanged if empty.
