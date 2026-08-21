[@serenity-is/sleekgrid](../README.md) / convertCompatFormatter

# Function: convertCompatFormatter()

> **convertCompatFormatter**(`compatFormatter`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)

Defined in: [src/core/formatting.ts:193](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L193)

Wraps a legacy [CompatFormatter](../type-aliases/CompatFormatter.md) as a modern [ColumnFormat](../type-aliases/ColumnFormat.md) by adapting
the argument list and lifting `addClasses`/`toolTip` onto the context.

## Parameters

### compatFormatter

[`CompatFormatter`](../type-aliases/CompatFormatter.md)

Legacy formatter to convert.

## Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)

A [ColumnFormat](../type-aliases/ColumnFormat.md) equivalent, or `null` if input was `null`.
