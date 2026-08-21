[@serenity-is/corelib](../README.md) / PropertyItem

# Interface: PropertyItem

Defined in: [src/base/propertyitem.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L40)

Describes a single field / column / form property as returned by server-side metadata.
Drives form generation, grid columns, editors, formatters and filtering. Each
property corresponds to a row field or an unbound UI field.

## Properties

### alignment?

> `optional` **alignment**: `string`

Defined in: [src/base/propertyitem.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L116)

Horizontal alignment for the column (`"left" | "center" | "right"` or similar).

***

### allowHide?

> `optional` **allowHide**: `boolean`

Defined in: [src/base/propertyitem.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L106)

Whether the user is allowed to hide the column via the column picker.

***

### category?

> `optional` **category**: `string`

Defined in: [src/base/propertyitem.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L58)

Category group shown as a collapsible section in forms.

***

### collapsed?

> `optional` **collapsed**: `boolean`

Defined in: [src/base/propertyitem.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L62)

Whether the category starts collapsed. Only meaningful when [collapsible](#collapsible) is true.

***

### collapsible?

> `optional` **collapsible**: `boolean`

Defined in: [src/base/propertyitem.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L60)

Whether the [category](#category) section can be collapsed.

***

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/base/propertyitem.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L66)

CSS class applied to the grid cell / column.

***

### defaultValue?

> `optional` **defaultValue**: `any`

Defined in: [src/base/propertyitem.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L100)

Default value applied to new records / empty editors.

***

### displayFormat?

> `optional` **displayFormat**: `string`

Defined in: [src/base/propertyitem.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L114)

Display format string (e.g. date / number format) consumed by the formatter.

***

### editLink?

> `optional` **editLink**: `boolean`

Defined in: [src/base/propertyitem.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L144)

When true the cell value is rendered as a link that opens the record's edit dialog.

***

### editLinkCssClass?

> `optional` **editLinkCssClass**: `string`

Defined in: [src/base/propertyitem.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L150)

Extra CSS class for the edit link anchor.

***

### editLinkIdField?

> `optional` **editLinkIdField**: `string`

Defined in: [src/base/propertyitem.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L148)

Field name that provides the ID for the edit link (defaults to the identity field).

***

### editLinkItemType?

> `optional` **editLinkItemType**: `string`

Defined in: [src/base/propertyitem.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L146)

Row type key used for the edit link dialog (defaults to the current row type).

***

### editorAddons?

> `optional` **editorAddons**: `object`[]

Defined in: [src/base/propertyitem.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L54)

Addons rendered alongside the editor (e.g. buttons). Each entry specifies a type key or [EditorAddon](../type-aliases/EditorAddon.md) callback and optional params.

#### params?

> `optional` **params**: `any`

#### type

> **type**: `string` \| [`EditorAddon`](../type-aliases/EditorAddon.md)

***

### editorCssClass?

> `optional` **editorCssClass**: `string`

Defined in: [src/base/propertyitem.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L56)

Extra CSS class(es) applied to the editor element.

***

### editorParams?

> `optional` **editorParams**: `any`

Defined in: [src/base/propertyitem.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L52)

Options passed to the editor constructor.

***

### editorType?

> `optional` **editorType**: `string` \| (`props?`) => `any` \| `PromiseLike`\<(`props?`) => `any`\>

Defined in: [src/base/propertyitem.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L50)

Editor type key (e.g. `"String"`, `"Date"`) or a constructor / lazy import for a custom editor.

***

### filteringIdField?

> `optional` **filteringIdField**: `string`

Defined in: [src/base/propertyitem.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L156)

Field that provides the ID value for filtering (useful for lookup display fields).

***

### filteringParams?

> `optional` **filteringParams**: `any`

Defined in: [src/base/propertyitem.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L154)

Options passed to the filtering editor.

***

### filteringType?

> `optional` **filteringType**: `string`

Defined in: [src/base/propertyitem.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L152)

Filter editor type key that determines the filtering UI for this field (e.g. `"String"`, `"Date"`).

***

### filterOnly?

> `optional` **filterOnly**: `boolean`

Defined in: [src/base/propertyitem.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L160)

When true the field appears only in filter dialogs / panels and not in the grid itself.

***

### focusable?

> `optional` **focusable**: `boolean`

Defined in: [src/base/propertyitem.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L108)

Whether the column can receive focus / be navigated via keyboard.

***

### formatterParams?

> `optional` **formatterParams**: `any`

Defined in: [src/base/propertyitem.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L112)

Options passed to the formatter.

***

### formatterType?

> `optional` **formatterType**: `string` \| (`props?`) => `object` \| `PromiseLike`\<(`props?`) => `object`\>

Defined in: [src/base/propertyitem.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L110)

Formatter type key or constructor / lazy import used to render the cell value.

***

### formCssClass?

> `optional` **formCssClass**: `string`

Defined in: [src/base/propertyitem.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L70)

CSS class applied to the form field container (`<div class="field">`).

***

### groupOrder?

> `optional` **groupOrder**: `number`

Defined in: [src/base/propertyitem.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L140)

Order index for grouping; controls group-by precedence when multiple columns are grouped.

***

### headerCssClass?

> `optional` **headerCssClass**: `string`

Defined in: [src/base/propertyitem.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L68)

CSS class applied to the column header.

***

### hideOnInsert?

> `optional` **hideOnInsert**: `boolean`

Defined in: [src/base/propertyitem.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L80)

Hides the field in insert (create) mode.

***

### hideOnUpdate?

> `optional` **hideOnUpdate**: `boolean`

Defined in: [src/base/propertyitem.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L86)

Hides the field in update (edit) mode.

***

### hint?

> `optional` **hint**: `string`

Defined in: [src/base/propertyitem.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L46)

Tooltip / hint shown on hover or beside the label.

***

### insertable?

> `optional` **insertable**: `boolean`

Defined in: [src/base/propertyitem.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L76)

Whether the field can be set on insert. When false the field is read-only during creation.

***

### insertPermission?

> `optional` **insertPermission**: `string`

Defined in: [src/base/propertyitem.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L78)

Permission key required to set the field on insert.

***

### labelWidth?

> `optional` **labelWidth**: `string`

Defined in: [src/base/propertyitem.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L128)

Width of the form label for this field (e.g. `"150px"`).

***

### localizable?

> `optional` **localizable**: `boolean`

Defined in: [src/base/propertyitem.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L102)

Whether the field supports per-language values (requires Localizations).

***

### maxLength?

> `optional` **maxLength**: `number`

Defined in: [src/base/propertyitem.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L72)

Maximum string length for validation.

***

### maxWidth?

> `optional` **maxWidth**: `number`

Defined in: [src/base/propertyitem.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L126)

Maximum column width in pixels.

***

### minWidth?

> `optional` **minWidth**: `number`

Defined in: [src/base/propertyitem.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L124)

Minimum column width in pixels.

***

### name

> **name**: `string`

Defined in: [src/base/propertyitem.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L42)

Field / property key (usually the row field name).

***

### notFilterable?

> `optional` **notFilterable**: `boolean`

Defined in: [src/base/propertyitem.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L158)

When true the column cannot be used as a filter criterion.

***

### ~~oneWay?~~

> `optional` **oneWay**: `boolean`

Defined in: [src/base/propertyitem.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L98)

#### Deprecated

use [skipOnSave](#skiponsave) instead — kept for backward compatibility.

***

### pin?

> `optional` **pin**: `boolean` \| `"start"` \| `"end"`

Defined in: [src/base/propertyitem.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L118)

Pin / freeze the column to the start (left) or end (right) of the grid, or `true` for start.

***

### placeholder?

> `optional` **placeholder**: `string`

Defined in: [src/base/propertyitem.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L48)

Placeholder text for the editor input.

***

### quickFilter?

> `optional` **quickFilter**: `boolean`

Defined in: [src/base/propertyitem.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L162)

Whether the field appears in the quick-filter bar above the grid.

***

### quickFilterCssClass?

> `optional` **quickFilterCssClass**: `string`

Defined in: [src/base/propertyitem.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L168)

Extra CSS class for the quick-filter item.

***

### quickFilterParams?

> `optional` **quickFilterParams**: `any`

Defined in: [src/base/propertyitem.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L164)

Options for the quick-filter editor.

***

### quickFilterSeparator?

> `optional` **quickFilterSeparator**: `boolean`

Defined in: [src/base/propertyitem.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L166)

When true a separator is rendered before this quick filter in the bar.

***

### readOnly?

> `optional` **readOnly**: `boolean`

Defined in: [src/base/propertyitem.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L88)

Whether the field is read-only in the UI (still submitted unless [skipOnSave](#skiponsave) is set).

***

### readPermission?

> `optional` **readPermission**: `string`

Defined in: [src/base/propertyitem.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L90)

Permission key required to read / view the field. Clients may hide the field when the user lacks it.

***

### required?

> `optional` **required**: `boolean`

Defined in: [src/base/propertyitem.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L74)

Whether a value is required.

***

### resizable?

> `optional` **resizable**: `boolean`

Defined in: [src/base/propertyitem.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L130)

Whether the column is user-resizable.

***

### showSelection?

> `optional` **showSelection**: `boolean`

Defined in: [src/base/propertyitem.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L132)

Whether to show a selection checkbox column behavior for this column.

***

### skipOnLoad?

> `optional` **skipOnLoad**: `boolean`

Defined in: [src/base/propertyitem.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L92)

When true the field is not populated on load (e.g. sensitive data).

***

### skipOnSave?

> `optional` **skipOnSave**: `boolean`

Defined in: [src/base/propertyitem.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L94)

When true the field value is not sent back on save.

***

### sortable?

> `optional` **sortable**: `boolean`

Defined in: [src/base/propertyitem.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L134)

Whether the column can be sorted.

***

### sortOrder?

> `optional` **sortOrder**: `number`

Defined in: [src/base/propertyitem.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L136)

Default sort order index (lower values are sorted first). Negative or undefined means no default sort.

***

### summaryType?

> `optional` **summaryType**: [`SummaryType`](../enumerations/SummaryType.md)

Defined in: [src/base/propertyitem.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L142)

Aggregation used for group / footer summaries. See [SummaryType](../enumerations/SummaryType.md).

***

### tab?

> `optional` **tab**: `string`

Defined in: [src/base/propertyitem.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L64)

Tab name the field belongs to when the form uses tabs.

***

### tabbable?

> `optional` **tabbable**: `boolean`

Defined in: [src/base/propertyitem.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L138)

Whether the column participates in tab-stop navigation.

***

### title?

> `optional` **title**: `string`

Defined in: [src/base/propertyitem.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L44)

Display title / column header / form label. Falls back to `name` when omitted.

***

### unbound?

> `optional` **unbound**: `boolean`

Defined in: [src/base/propertyitem.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L96)

True for unbound fields that do not map to a row column (e.g. calculated UI-only fields).

***

### updatable?

> `optional` **updatable**: `boolean`

Defined in: [src/base/propertyitem.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L82)

Whether the field can be updated after creation.

***

### updatePermission?

> `optional` **updatePermission**: `string`

Defined in: [src/base/propertyitem.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L84)

Permission key required to update the field.

***

### visible?

> `optional` **visible**: `boolean`

Defined in: [src/base/propertyitem.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L104)

Whether the column / field is visible by default. Hidden columns can still be shown via column picker.

***

### width?

> `optional` **width**: `number`

Defined in: [src/base/propertyitem.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L120)

Preferred column width in pixels.

***

### widthSet?

> `optional` **widthSet**: `boolean`

Defined in: [src/base/propertyitem.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L122)

True when [width](#width) was explicitly set (vs. auto-calculated).
