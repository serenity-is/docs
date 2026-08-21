[@serenity-is/corelib](../README.md) / stringFormat

# Function: stringFormat()

> **stringFormat**(`format`, ...`prm`): `string`

Defined in: [src/base/formatting.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L251)

Formats a string by replacing `{index[:format]}` placeholders with the supplied arguments, using [Culture](../variables/Culture.md) for locale-aware value formatting.

## Parameters

### format

`string`

Composite format string (e.g. `"Hello {0}, you have {1:n2} messages"`). `{{` / `}}` are escaped to a single brace.

### prm

...`any`[]

Values to substitute; each may be a number, `Date`, or any object with a `format(formatSpec, locale)` method. Nullish values render as empty strings.

## Returns

`string`

The formatted string.

## Example

```ts
stringFormat("Hello {0}, balance {1:c}", "Alice", 1234.5); // uses Culture currency symbol
```
