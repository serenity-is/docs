[@serenity-is/corelib](../README.md) / formatNumber

# Function: formatNumber()

> **formatNumber**(`num`, `format?`, `decOrLoc?`, `grp?`): `string`

Defined in: [src/base/formatting.ts:337](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L337)

Formats a number using .NET-style numeric format strings and locale settings.

## Parameters

### num

`number`

Value to format; `null` / `undefined` yields `""` and `NaN` yields `nanSymbol`.

### format?

`string`

Format specifier. `"g"` (general), `"d"`/`"x"`/`"e"`/`"f"`/`"n"`/`"c"`/`"p"`, or a custom pattern (`"#,##0.00"`, `"000"`, etc.).

### decOrLoc?

Either a [Locale](../interfaces/Locale.md) / [NumberFormat](../interfaces/NumberFormat.md) object, or the decimal separator string for a lightweight inline locale.

`string` | [`NumberFormat`](../interfaces/NumberFormat.md)

### grp?

`string`

Group separator when `decOrLoc` is a decimal-separator string. Ignored otherwise.

## Returns

`string`

The formatted number string, applying grouping, decimal separator, and locale symbols from `decOrLoc` or [Culture](../variables/Culture.md).

## Default Value

`"g"`.

## Remarks

- `"n"` / `"N"` insert grouping; `"c"`/`"p"` append `currencySymbol`/`percentSymbol` (percent multiplies by 100).
- Custom patterns quote literals with `'` and escape with ``.

## Example

```ts
formatNumber(1234.5, "n2"); // e.g. "1,234.50" depending on Culture
formatNumber(0.42, "p0");   // e.g. "42%"
```
