[@serenity-is/corelib](../../../README.md) / Criteria

# Criteria

Helpers for composing and inspecting Serenity criteria arrays.

## Remarks

Criteria are plain arrays in the form `[left, operator, right]` (binary),
`[operator, operand]` (unary), or nested with `"and"`/`"or"` joiners.
The static helpers here handle empty-value short-circuiting so callers can
unconditionally combine optional filters.

## Variables

- [Operator](variables/Operator.md)
- [parse](variables/parse.md)

## Functions

- [and](functions/and.md)
- [isEmpty](functions/isEmpty.md)
- [join](functions/join.md)
- [not](functions/not.md)
- [or](functions/or.md)
- [paren](functions/paren.md)
