[@serenity-is/corelib](../../../../README.md) / [Criteria](../README.md) / upper

# Function: upper()

> **upper**(`value`): `any`[]

Defined in: [src/base/criteria.ts:1180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1180)

Creates an `UPPER(value)` function-call criteria.

## Parameters

### value

`any`[]

Function argument, typically a field criteria.

## Returns

`any`[]

Criteria `["function", ["UPPER", value]]`.

## Example

```ts
Criteria.upper(Criteria("Name")); // ["function", ["UPPER", ["Name"]]]
```
