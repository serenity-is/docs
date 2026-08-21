[@serenity-is/sleekgrid](../README.md) / AutoTooltipsOptions

# Interface: AutoTooltipsOptions

Defined in: [src/plugins/autotooltips.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L6)

Options for [AutoTooltips](../classes/AutoTooltips.md).

## Properties

### enableForCells?

> `optional` **enableForCells**: `boolean`

Defined in: [src/plugins/autotooltips.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L8)

Auto-assign tooltips for body cells when text overflows. Defaults to `true`.

***

### enableForHeaderCells?

> `optional` **enableForHeaderCells**: `boolean`

Defined in: [src/plugins/autotooltips.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L10)

Auto-assign tooltips for header cells when text overflows. Defaults to `false`.

***

### maxToolTipLength?

> `optional` **maxToolTipLength**: `number`

Defined in: [src/plugins/autotooltips.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L12)

Maximum tooltip length before truncation with `"..."`; `null` means no limit.

***

### replaceExisting?

> `optional` **replaceExisting**: `boolean`

Defined in: [src/plugins/autotooltips.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/autotooltips.ts#L14)

When `true`, overwrites existing `title` attributes.
