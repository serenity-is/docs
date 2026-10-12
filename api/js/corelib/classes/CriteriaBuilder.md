[@serenity-is/corelib](../README.md) / CriteriaBuilder

# Class: CriteriaBuilder

Defined in: [src/base/criteria.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L15)

Fluent builder for Serenity criteria expressions with completion support.

## Remarks

Extends `Array` so an instance itself acts as a field-reference token (e.g. `["Amount"]`).
Create instances via [Criteria](../functions/Criteria.md)`("FieldName")` rather than `new CriteriaBuilder()`.
Each method returns a Serenity criteria tuple/array that can be combined with
[Criteria.and](../@serenity-is/namespaces/Criteria/functions/and.md), [Criteria.or](../@serenity-is/namespaces/Criteria/functions/or.md), [Criteria.join](../@serenity-is/namespaces/Criteria/functions/join.md), or the
[parseCriteria](../functions/parseCriteria.md) parser. `bw` stands for "between" (inclusive).

## Examples

```ts
Criteria("Age").ge(18); // [["Age"], ">=", 18]
```

```ts
Criteria("Status").in([1, 2, 3]); // [["Status"], "in", [[1, 2, 3]]]
```

## Extends

- `Array`

## Indexable

\[`n`: `number`\]: `any`

## Constructors

### Constructor

> **new CriteriaBuilder**(`arrayLength?`): `CriteriaBuilder`

Defined in: C:/Users/volka/AppData/Roaming/npm/node\_modules/typedoc/node\_modules/typescript/lib/lib.es5.d.ts:1514

#### Parameters

##### arrayLength?

`number`

#### Returns

`CriteriaBuilder`

#### Inherited from

`Array.constructor`

## Methods

### bw()

> **bw**(`fromInclusive`, `toInclusive`): `any`[]

Defined in: [src/base/criteria.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L25)

Creates a BETWEEN (inclusive) criteria: `field >= from AND field <= to`.

#### Parameters

##### fromInclusive

`any`

Lower bound (inclusive).

##### toInclusive

`any`

Upper bound (inclusive).

#### Returns

`any`[]

Composite criteria `[[field, ">=", from], "and", [field, "<=", to]]`.

#### Example

```ts
Criteria("Amount").bw(10, 20);
```

***

### contains()

> **contains**(`value`): `any`[]

Defined in: [src/base/criteria.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L42)

Creates a `LIKE '%value%'` (contains) criteria.

The value is treated as literal text: LIKE special characters are
escaped (see [escapeLikeWildcards](../functions/escapeLikeWildcards.md)) and a 4-element array with
`ESCAPE '!'` is produced only when escaping was necessary, otherwise
a plain 3-element array, so older servers keep working.

#### Parameters

##### value

`string`

Substring to search for. Wrapped with `%` on both sides.

#### Returns

`any`[]

Criteria `[field, "like", "%value%"]` or `[field, "like", "%value%", "!"]`.

#### Example

```ts
Criteria("Name").contains("ser"); // [["Name"], "like", "%ser%"]
```

***

### endsWith()

> **endsWith**(`value`): `any`[]

Defined in: [src/base/criteria.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L59)

Creates a `LIKE '%value'` (ends-with) criteria.

The value is treated as literal text: LIKE special characters are
escaped (see [escapeLikeWildcards](../functions/escapeLikeWildcards.md)) and a 4-element array with
`ESCAPE '!'` is produced only when escaping was necessary, otherwise
a plain 3-element array, so older servers keep working.

#### Parameters

##### value

`string`

Suffix to match. Prefixed with `%`.

#### Returns

`any`[]

Criteria `[field, "like", "%value"]` or `[field, "like", "%value", "!"]`.

#### Example

```ts
Criteria("Email").endsWith("@example.com");
```

***

### eq()

> **eq**(`value`): `any`[]

Defined in: [src/base/criteria.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L71)

Creates an equality (`=`) criteria.

#### Parameters

##### value

`any`

Value to compare for equality.

#### Returns

`any`[]

Criteria `[field, "=", value]`.

#### Example

```ts
Criteria("IsActive").eq(true);
```

***

### ge()

> **ge**(`value`): `any`[]

Defined in: [src/base/criteria.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L91)

Creates a greater-than-or-equal (`>=`) criteria.

#### Parameters

##### value

`any`

Lower inclusive bound.

#### Returns

`any`[]

Criteria `[field, ">=", value]`.

***

### gt()

> **gt**(`value`): `any`[]

Defined in: [src/base/criteria.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L81)

Creates a greater-than (`>`) criteria.

#### Parameters

##### value

`any`

Lower exclusive bound.

#### Returns

`any`[]

Criteria `[field, ">", value]`.

***

### in()

> **in**(`values`): `any`[]

Defined in: [src/base/criteria.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L103)

Creates an `IN` criteria.

#### Parameters

##### values

`any`[]

Array of allowed values. Wrapped as `[values]` per Serenity wire format.

#### Returns

`any`[]

Criteria `[field, "in", [values]]`.

#### Example

```ts
Criteria("Status").in([1, 2]); // [["Status"], "in", [[1, 2]]]
```

***

### isNotNull()

> **isNotNull**(): `any`[]

Defined in: [src/base/criteria.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L121)

Creates an `IS NOT NULL` criteria.

#### Returns

`any`[]

Criteria `["is not null", field]`.

***

### isNull()

> **isNull**(): `any`[]

Defined in: [src/base/criteria.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L112)

Creates an `IS NULL` criteria.

#### Returns

`any`[]

Criteria `["is null", field]`.

***

### le()

> **le**(`value`): `any`[]

Defined in: [src/base/criteria.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L131)

Creates a less-than-or-equal (`<=`) criteria.

#### Parameters

##### value

`any`

Upper inclusive bound.

#### Returns

`any`[]

Criteria `[field, "<=", value]`.

***

### like()

> **like**(`value`): `any`[]

Defined in: [src/base/criteria.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L163)

Creates a `LIKE` criteria with the exact pattern provided.

#### Parameters

##### value

`any`

SQL LIKE pattern (use `%` / `_` wildcards as needed).

#### Returns

`any`[]

Criteria `[field, "like", value]`.

#### Example

```ts
Criteria("Name").like("A%");
```

***

### likeEscaped()

> **likeEscaped**(`mask`): `any`[]

Defined in: [src/base/criteria.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L182)

Creates a `LIKE ... ESCAPE '!'` criteria with a pre-escaped mask.

The mask must already be escaped (see [escapeLikeWildcards](../functions/escapeLikeWildcards.md));
it is used as is. A 4-element array is produced only when the mask
contains the escape character, otherwise a plain 3-element array,
so older servers keep working. For literal values prefer
[CriteriaBuilder.contains](#contains), [CriteriaBuilder.startsWith](#startswith)
or [CriteriaBuilder.endsWith](#endswith).

#### Parameters

##### mask

`string`

LIKE mask, already escaped for `!`.

#### Returns

`any`[]

Criteria `[field, "like", mask]` or `[field, "like", mask, "!"]`.

#### Example

```ts
Criteria("Name").likeEscaped("%a!%b%"); // [["Name"], "like", "%a!%b%", "!"]
```

***

### lt()

> **lt**(`value`): `any`[]

Defined in: [src/base/criteria.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L141)

Creates a less-than (`<`) criteria.

#### Parameters

##### value

`any`

Upper exclusive bound.

#### Returns

`any`[]

Criteria `[field, "<", value]`.

***

### ne()

> **ne**(`value`): `any`[]

Defined in: [src/base/criteria.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L151)

Creates a not-equal (`!=`) criteria.

#### Parameters

##### value

`any`

Value that the field must not equal.

#### Returns

`any`[]

Criteria `[field, "!=", value]`.

***

### notIn()

> **notIn**(`values`): `any`[]

Defined in: [src/base/criteria.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L211)

Creates a `NOT IN` criteria.

#### Parameters

##### values

`any`[]

Array of disallowed values. Wrapped as `[values]`.

#### Returns

`any`[]

Criteria `[field, "not in", [values]]`.

***

### notLike()

> **notLike**(`value`): `any`[]

Defined in: [src/base/criteria.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L221)

Creates a `NOT LIKE` criteria.

#### Parameters

##### value

`any`

SQL LIKE pattern that the field must not match.

#### Returns

`any`[]

Criteria `[field, "not like", value]`.

***

### notLikeEscaped()

> **notLikeEscaped**(`mask`): `any`[]

Defined in: [src/base/criteria.ts:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L237)

Creates a `NOT LIKE ... ESCAPE '!'` criteria with a pre-escaped mask.

The mask must already be escaped (see [escapeLikeWildcards](../functions/escapeLikeWildcards.md));
it is used as is. A 4-element array is produced only when the mask
contains the escape character, otherwise a plain 3-element array.

#### Parameters

##### mask

`string`

LIKE mask, already escaped for `!`.

#### Returns

`any`[]

Criteria `[field, "not like", mask]` or `[field, "not like", mask, "!"]`.

#### Example

```ts
Criteria("Name").notLikeEscaped("%a!%b%"); // [["Name"], "not like", "%a!%b%", "!"]
```

***

### startsWith()

> **startsWith**(`value`): `any`[]

Defined in: [src/base/criteria.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L201)

Creates a `LIKE 'value%'` (starts-with) criteria.

The value is treated as literal text: LIKE special characters are
escaped (see [escapeLikeWildcards](../functions/escapeLikeWildcards.md)) and a 4-element array with
`ESCAPE '!'` is produced only when escaping was necessary, otherwise
a plain 3-element array, so older servers keep working.

#### Parameters

##### value

`string`

Prefix to match. Suffixed with `%`.

#### Returns

`any`[]

Criteria `[field, "like", "value%"]` or `[field, "like", "value%", "!"]`.

#### Example

```ts
Criteria("Name").startsWith("Jo"); // [["Name"], "like", "Jo%"]
```
