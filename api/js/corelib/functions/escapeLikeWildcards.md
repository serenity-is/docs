[@serenity-is/corelib](../README.md) / escapeLikeWildcards

# Function: escapeLikeWildcards()

> **escapeLikeWildcards**(`value`): `string`

Defined in: [src/base/criteria.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L258)

Escapes a literal value for use in a LIKE pattern with the `!` escape character.

The escape character itself is escaped first, then `%`, `_` and `[`.
A `]` outside a `[...]` class is literal on all supported dialects, so it is left as is.
The result must be used with `ESCAPE '!'` declared (see
[CriteriaBuilder.likeEscaped](../classes/CriteriaBuilder.md#likeescaped)), otherwise the escape character
matches itself instead of escaping.

## Parameters

### value

`string`

The literal value to escape.

## Returns

`string`

The escaped value, with no `%` affixes added.

## Example

```ts
escapeLikeWildcards("50%"); // "50!%"
```
