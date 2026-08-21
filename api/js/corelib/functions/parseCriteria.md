[@serenity-is/corelib](../README.md) / parseCriteria

# Function: parseCriteria()

Parses a criteria expression (string or tagged template) to Serenity criteria array format.

## Param

Expression string or template strings array.

## Param

Parameter values or interpolated template values.

## Call Signature

> **parseCriteria**(`expression`, `params?`): `any`[]

Defined in: [src/base/criteria.ts:759](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L759)

Parses a criteria expression string to Serenity criteria array format.

### Parameters

#### expression

`string`

Expression text, e.g. `"A >= @p1 and B < @p2"`.

#### params?

`any`

Dictionary mapping parameter names to values, e.g. `{ p1: 5, p2: 4 }`.

### Returns

`any`[]

Serenity criteria array, e.g. `[[["A"], ">=", 5], "and", [["B"], "<", 4]]`.

### Remarks

Supports named parameters via `@name` placeholders. Operator precedence is handled
via a shunting-yard pass; string literals use single quotes with `''` escaping.

### Example

```ts
`parseCriteria('A >= @p1 and B < @p2', { p1: 5, p2: 4 }) // [[[a], '>=' 5], 'and', [[b], '<', 4]]`
```

## Call Signature

> **parseCriteria**(`strings`, ...`values`): `any`[]

Defined in: [src/base/criteria.ts:773](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L773)

Parses a tagged-template criteria expression to Serenity criteria array format.

### Parameters

#### strings

`TemplateStringsArray`

Template string fragments.

#### values

...`any`[]

Interpolated values (one per placeholder).

### Returns

`any`[]

Serenity criteria array.

### Remarks

Each interpolated value becomes an auto-named `@__N` parameter, avoiding manual
parameter dictionaries and SQL-injection-prone concatenation.

### Example

```ts
let a = 5, b = 4;
parseCriteria`A >= ${a} and B < ${b}`; // [[["A"], ">=", 5], "and", [["B"], "<", 4]]
```
