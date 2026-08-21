[@serenity-is/sleekgrid](../README.md) / GroupItemMetadataProvider

# Class: GroupItemMetadataProvider

Defined in: [src/data/groupitemmetadataprovider.tsx:62](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L62)

Grid plugin that provides row metadata and formatters for group headers and
group totals rows. Handles expand/collapse UI via click and keyboard
(Space, `+`, `-`) and delegates metadata through `getGroupRowMetadata` /
`getTotalsRowMetadata` for use by `DataView`.

## Implements

- [`GridPlugin`](../interfaces/GridPlugin.md)

## Constructors

### Constructor

> **new GroupItemMetadataProvider**(`opt?`): `GroupItemMetadataProvider`

Defined in: [src/data/groupitemmetadataprovider.tsx:72](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L72)

Creates a new provider.

#### Parameters

##### opt?

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

Partial options merged with [GroupItemMetadataProvider.defaults](#defaults).

#### Returns

`GroupItemMetadataProvider`

## Properties

### getGroupRowMetadata()

> **getGroupRowMetadata**: (`item`) => [`ItemMetadata`](../interfaces/ItemMetadata.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:320](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L320)

Returns row metadata for a group header row. The grid/DataView calls this
to obtain CSS classes, focusability and the spanned column formatter.

#### Parameters

##### item

[`Group`](Group.md)

Group row item.

#### Returns

[`ItemMetadata`](../interfaces/ItemMetadata.md)

Metadata describing how the group row should be rendered.

***

### getTotalsRowMetadata()

> **getTotalsRowMetadata**: (`item`) => [`ItemMetadata`](../interfaces/ItemMetadata.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:349](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L349)

Returns row metadata for a group totals row.

#### Parameters

##### item

[`IGroupTotals`](../interfaces/IGroupTotals.md)

Totals row item.

#### Returns

[`ItemMetadata`](../interfaces/ItemMetadata.md)

Metadata describing how the totals row should be rendered.

***

### grid

> `protected` **grid**: [`ISleekGrid`](../interfaces/ISleekGrid.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L64)

Host grid instance set during [GroupItemMetadataProvider.init](#init).

***

### pluginName

> `readonly` **pluginName**: `"GroupItemMetadataProvider"` = `"GroupItemMetadataProvider"`

Defined in: [src/data/groupitemmetadataprovider.tsx:171](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L171)

Plugin name used for lookup via `grid.getPluginByName()`.

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`pluginName`](../interfaces/GridPlugin.md#pluginname)

***

### defaults

> `readonly` `static` **defaults**: [`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:83](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L83)

Default option values. Override per instance via constructor or [GroupItemMetadataProvider.setOptions](#setoptions).

## Methods

### destroy()

> **destroy**(): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:176](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L176)

Detaches event handlers added during [GroupItemMetadataProvider.init](#init).

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`destroy`](../interfaces/GridPlugin.md#destroy)

***

### getOptions()

> **getOptions**(): [`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:187](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L187)

Returns the current resolved options.

#### Returns

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

Current options object.

***

### groupCellPosition()

> **groupCellPosition**(): `object`

Defined in: [src/data/groupitemmetadataprovider.tsx:274](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L274)

Computes the cell index and colspan for the spanned group cell, taking
summary columns and frozen columns into account.

#### Returns

`object`

Object with `cell` start index and `colspan` span width (`"*"` means full row when no totals).

##### cell

> **cell**: `number`

##### colspan

> **colspan**: `number` \| `"*"`

***

### handleGridClick()

> **handleGridClick**(`e`): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:203](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L203)

Click handler that toggles group collapse when the toggle element is clicked.

#### Parameters

##### e

[`CellMouseEvent`](../type-aliases/CellMouseEvent.md)

Cell mouse event from the grid's `onClick`.

#### Returns

`void`

***

### handleGridKeyDown()

> **handleGridKeyDown**(`e`): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:233](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L233)

Key handler that toggles group collapse on Space / `+` / `-` when a group row is active.

#### Parameters

##### e

[`CellKeyboardEvent`](../type-aliases/CellKeyboardEvent.md)

Cell keyboard event from the grid's `onKeyDown`.

#### Returns

`void`

***

### init()

> **init**(`grid`): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:164](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L164)

Initializes the plugin, attaching click and key handlers for expand/collapse.

#### Parameters

##### grid

[`ISleekGrid`](../interfaces/ISleekGrid.md)

Host grid instance.

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`init`](../interfaces/GridPlugin.md#init)

***

### setOptions()

> **setOptions**(`value`): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:195](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L195)

Merges the given values into the current options.

#### Parameters

##### value

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

Partial options to apply.

#### Returns

`void`

***

### defaultGroupFormat()

> `static` **defaultGroupFormat**(`ctx`, `opt?`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:106](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L106)

Default group row formatter. Renders the group title with an optional
expand/collapse toggle indented by `group.level`.

#### Parameters

##### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

Formatter context whose `item` is the [Group](Group.md) to render.

##### opt?

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

Options controlling indentation and toggle classes; defaults to [GroupItemMetadataProvider.defaults](#defaults).

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

Rendered group row content as DOM/JSX.

***

### defaultTotalsFormat()

> `static` **defaultTotalsFormat**(`ctx`, `grid?`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:144](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L144)

Default totals row formatter. Delegates to the grid's column totals formatter
(or the column's own `groupTotalsFormat`/`groupTotalsFormatter`).

#### Parameters

##### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

Formatter context whose `item` is the [IGroupTotals](../interfaces/IGroupTotals.md) row.

##### grid?

[`ISleekGrid`](../interfaces/ISleekGrid.md)

Optional grid fallback when `ctx.grid` is unavailable.

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

Rendered totals content, or empty string when no formatter is found.
