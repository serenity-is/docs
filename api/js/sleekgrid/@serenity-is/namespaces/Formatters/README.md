[@serenity-is/sleekgrid](../../../README.md) / Formatters

# ~~Formatters~~

Legacy namespace exposing formatters with the old `(row, cell, value)` signature.
Each adapter wraps the modern `*Formatter(ctx)` via [formatterContext](../../../functions/formatterContext.md).

## Deprecated

Prefer importing the named formatters from `"./formatters"` directly
and passing a [FormatterContext](../../../interfaces/FormatterContext.md).

## Functions

- [~~Checkbox~~](functions/Checkbox.md)
- [~~Checkmark~~](functions/Checkmark.md)
- [~~PercentComplete~~](functions/PercentComplete.md)
- [~~PercentCompleteBar~~](functions/PercentCompleteBar.md)
- [~~YesNo~~](functions/YesNo.md)
