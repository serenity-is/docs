[@serenity-is/corelib](../README.md) / Formatter

# Interface: Formatter

Defined in: [src/slick/slicktypes.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L22)

Legacy formatter contract. Prefer [Format](../type-aliases/Format.md).

## Methods

### format()

> **format**(`ctx`): `FormatterResult`

Defined in: [src/slick/slicktypes.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L24)

Formats a cell value.

#### Parameters

##### ctx

`FormatterContext`

Formatter context with item/column/value/grid.

#### Returns

`FormatterResult`

Formatted result.
