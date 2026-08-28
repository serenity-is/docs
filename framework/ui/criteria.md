# Criteria (Client-Side)

Criteria are Serenity's way of expressing filter conditions. They are plain arrays in the form `[left, operator, right]` (binary), `[operator, operand]` (unary), or nested with `"and"`/`"or"` joiners. They are used in list requests, service calls, and grid filters.

## The CriteriaBuilder

`Criteria("FieldName")` returns a `CriteriaBuilder` — a fluent builder that produces criteria arrays:

```ts
import { Criteria } from "@serenity-is/corelib";

Criteria("Age").ge(18);        // [["Age"], ">=", 18]
Criteria("Status").in([1, 2]); // [["Status"], "in", [[1, 2]]]
Criteria("Name").contains("ser"); // [["Name"], "like", "%ser%"]
```

### Builder Methods

| Method | Result |
| --- | --- |
| `eq(value)` | `[field, "=", value]` |
| `ne(value)` | `[field, "!=", value]` |
| `gt(value)` | `[field, ">", value]` |
| `ge(value)` | `[field, ">=", value]` |
| `lt(value)` | `[field, "<", value]` |
| `le(value)` | `[field, "<=", value]` |
| `in(values)` | `[field, "in", [values]]` |
| `notIn(values)` | `[field, "not in", [values]]` |
| `contains(value)` | `[field, "like", "%value%"]` |
| `startsWith(value)` | `[field, "like", "value%"]` |
| `endsWith(value)` | `[field, "like", "%value"]` |
| `bw(from, to)` | `[[field, ">=", from], "and", [field, "<=", to]]` (between) |
| `isNull()` | `["is null", field]` |
| `isNotNull()` | `["is not null", field]` |

## Combining Criteria

The `Criteria` namespace provides helpers to combine criteria:

```ts
import { Criteria } from "@serenity-is/corelib";

const c1 = Criteria("Age").ge(18);
const c2 = Criteria("Status").eq("Active");

// AND
const both = Criteria.and(c1, c2);
// [["Age"], ">=", 18], "and", [["Status"], "=", "Active"]]

// OR
const either = Criteria.or(c1, c2);

// NOT
const notActive = Criteria.not(Criteria("Status").eq("Deleted"));

// Join with a custom operator
const joined = Criteria.join(c1, "and", c2);
```

`Criteria.and` and `Criteria.or` skip empty criteria, so you can unconditionally combine optional filters:

```ts
const filters = Criteria.and(
    searchText && Criteria("Name").contains(searchText),
    categoryId && Criteria("CategoryId").eq(categoryId)
);
```

## Checking for Empty

`Criteria.isEmpty(c)` returns `true` for `null`, `undefined`, `[]`, or `[""]`:

```ts
if (Criteria.isEmpty(criteria)) {
    // no filter
}
```

## parseCriteria

`parseCriteria` parses a criteria expression string (or a tagged template) into a criteria array:

```ts
import { parseCriteria } from "@serenity-is/corelib";

const c = parseCriteria("Age >= 18 and Status = 'Active'");
```

## Using Criteria in Requests

Criteria are used in list requests and service calls. For example, a `ListRequest` can carry a criteria filter:

```ts
const response = await MyService.List({
    Criteria: Criteria.and(
        Criteria("IsActive").eq(true),
        Criteria("CategoryId").eq(5)
    )
});
```

## See Also

- [CriteriaBuilder (API reference)](../../api/js/corelib/classes/CriteriaBuilder.md) — the fluent builder.
- [Criteria (namespace)](../../api/js/corelib/@serenity-is/namespaces/Criteria/README.md) — the combining helpers.
- [parseCriteria (API reference)](../../api/js/corelib/functions/parseCriteria.md) — parsing criteria strings.
- [Filtering and Quick Search](../../grids/filtering.md) — how filters use criteria.
- [Type-Safe Service Calls](../service-calls.md) — using criteria in requests.
- [Frontend Framework Overview](readme.md) — the three client-side packages and how they fit together.