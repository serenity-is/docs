[@serenity-is/corelib](../README.md) / Criteria

# Function: Criteria()

> **Criteria**(`field`): [`CriteriaBuilder`](../classes/CriteriaBuilder.md)

Defined in: [src/base/criteria.ts:855](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L855)

Creates a fluent [CriteriaBuilder](../classes/CriteriaBuilder.md) for the given field.

## Parameters

### field

`string`

Field name / property key, e.g. `"Amount"` or `"Customer.Name"`.

## Returns

[`CriteriaBuilder`](../classes/CriteriaBuilder.md)

A [CriteriaBuilder](../classes/CriteriaBuilder.md) bound to the field.

## Remarks

The returned builder extends `Array` so it doubles as a field token. A prototype
fixup handles environments where subclassing `Array` is unreliable.

## Examples

```ts
Criteria("Age").ge(18);
```

```ts
Criteria("Name").contains("acme");
```
