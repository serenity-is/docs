[@serenity-is/corelib](../README.md) / addLocalText

# Function: addLocalText()

> **addLocalText**(`obj`, `pre?`): `void`

Defined in: [src/base/localtext.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/localtext.ts#L23)

Adds one or more entries to the global localization table.

## Parameters

### obj

Either a single key (string) whose value is `pre`, or a nested object map where leaf string values are stored under dot-joined keys (recursively). Pass `null`/`undefined`/empty to no-op.

`string` | `Record`\<`string`, `string` \| `Record`\<`string`, `any`\>\>

### pre?

`string`

Prefix prepended to each key, or the value when `obj` is a string. Defaults to `""` for object mode.

## Returns

`void`

## Remarks

The table is stored on the global object under localTextTableSymbol and is shared across the application. Nested objects are flattened with `.` separators (e.g. `{ a: { b: "x" } }` with `pre="Ns."` registers `"Ns.a.b"`).

## Example

```ts
addLocalText({ "Db.Northwind.CustomerName": "Customer Name" });
addLocalText("Db.Northwind.CustomerName", "Customer Name");
addLocalText({ Customer: { Name: "Name" } }, "Db.Northwind.");
```
