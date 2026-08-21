[@serenity-is/corelib](../../../../README.md) / [Criteria](../README.md) / parse

# Variable: parse()

> `const` **parse**: \{(`expression`, `params?`): `any`[]; (`strings`, ...`values`): `any`[]; \} = `parseCriteria`

Defined in: [src/base/criteria.ts:978](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L978)

Alias for [parseCriteria](../../../../functions/parseCriteria.md) — parses a criteria expression string or tagged template.

## Call Signature

> (`expression`, `params?`): `any`[]

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

> (`strings`, ...`values`): `any`[]

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

## Remarks

Accepts either `"A >= @p1"` with a params object, or a tagged template
`` Criteria.parse`A >= ${value}` ``. See [parseCriteria](../../../../functions/parseCriteria.md) for details.

## Examples

```ts
Criteria.parse("A >=
```

```ts
let a = 5, b = 4;
Criteria.parse`A >= ${a} and B < ${b}`;
```

## P1

and B < @p2", { p1: 5, p2: 4 });
