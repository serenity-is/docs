[@serenity-is/corelib](../README.md) / toId

# Function: toId()

> **toId**(`id`): `any`

Defined in: [src/base/formatting.ts:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L650)

Normalizes a value to an ID suitable for entity keys.

## Parameters

### id

`any`

Candidate ID: a number is returned as-is; a string is trimmed and, when it is a plain integer with fewer than 15 characters, parsed to a number; otherwise the trimmed string is returned. `null`, `undefined`, or whitespace yields `null`.

## Returns

`any`

The normalized ID (`number` or `string`) or `null` for empty input.

## Example

```ts
toId(" 42 "); // 42
toId("abc");  // "abc"
toId("");     // null
```
