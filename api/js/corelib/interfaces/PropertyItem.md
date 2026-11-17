[@serenity-is/corelib](../README.md) / PropertyItem

# Interface: PropertyItem

Defined in: [src/base/propertyitem.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L72)

Describes a single field / column / form property as returned by server-side metadata.
Drives form generation, grid columns, editors, formatters and filtering. Each
property corresponds to a row field or an unbound UI field.

## Properties

### alignment?

> `optional` **alignment**: `string`

Defined in: [src/base/propertyitem.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L158)

Horizontal alignment for the column (`"left" | "center" | "right"` or similar).

***

### allowHide?

> `optional` **allowHide**: `boolean`

Defined in: [src/base/propertyitem.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L148)

Whether the user is allowed to hide the column via the column picker.

***

### category?

> `optional` **category**: `string`

Defined in: [src/base/propertyitem.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L90)

Category group shown as a collapsible section in forms.

***

### clearWhenHidden?

> `optional` **clearWhenHidden**: `boolean`

Defined in: [src/base/propertyitem.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L140)

Whether the value of the field is saved as empty while a condition hides it in forms, instead of being kept.

***

### collapsed?

> `optional` **collapsed**: `boolean`

Defined in: [src/base/propertyitem.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L94)

Whether the category starts collapsed. Only meaningful when [collapsible](#collapsible) is true.

***

### collapsible?

> `optional` **collapsible**: `boolean`

Defined in: [src/base/propertyitem.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L92)

Whether the [category](#category) section can be collapsed.

***

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/base/propertyitem.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L98)

CSS class applied to the grid cell / column.

***

### defaultValue?

> `optional` **defaultValue**: `any`

Defined in: [src/base/propertyitem.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L132)

Default value applied to new records / empty editors.

***

### displayFormat?

> `optional` **displayFormat**: `string`

Defined in: [src/base/propertyitem.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L156)

Display format string (e.g. date / number format) consumed by the formatter.

***

### editLink?

> `optional` **editLink**: `boolean`

Defined in: [src/base/propertyitem.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L186)

When true the cell value is rendered as a link that opens the record's edit dialog.

***

### editLinkCssClass?

> `optional` **editLinkCssClass**: `string`

Defined in: [src/base/propertyitem.ts:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L192)

Extra CSS class for the edit link anchor.

***

### editLinkIdField?

> `optional` **editLinkIdField**: `string`

Defined in: [src/base/propertyitem.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L190)

Field name that provides the ID for the edit link (defaults to the identity field).

***

### editLinkItemType?

> `optional` **editLinkItemType**: `string`

Defined in: [src/base/propertyitem.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L188)

Row type key used for the edit link dialog (defaults to the current row type).

***

### editorAddons?

> `optional` **editorAddons**: `object`[]

Defined in: [src/base/propertyitem.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L86)

Addons rendered alongside the editor (e.g. buttons). Each entry specifies a type key or [EditorAddon](../type-aliases/EditorAddon.md) callback and optional params.

#### params?

> `optional` **params**: `any`

#### type

> **type**: `string` \| [`EditorAddon`](../type-aliases/EditorAddon.md)

***

### editorCssClass?

> `optional` **editorCssClass**: `string`

Defined in: [src/base/propertyitem.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L88)

Extra CSS class(es) applied to the editor element.

***

### editorParams?

> `optional` **editorParams**: `any`

Defined in: [src/base/propertyitem.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L84)

Options passed to the editor constructor.

***

### editorType?

> `optional` **editorType**: `string` \| (`props?`) => `any` \| `PromiseLike`\<(`props?`) => `any`\>

Defined in: [src/base/propertyitem.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L82)

Editor type key (e.g. `"String"`, `"Date"`) or a constructor / lazy import for a custom editor.

***

### filteringIdField?

> `optional` **filteringIdField**: `string`

Defined in: [src/base/propertyitem.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L198)

Field that provides the ID value for filtering (useful for lookup display fields).

***

### filteringParams?

> `optional` **filteringParams**: `any`

Defined in: [src/base/propertyitem.ts:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L196)

Options passed to the filtering editor.

***

### filteringType?

> `optional` **filteringType**: `string`

Defined in: [src/base/propertyitem.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L194)

Filter editor type key that determines the filtering UI for this field (e.g. `"String"`, `"Date"`).

***

### filterOnly?

> `optional` **filterOnly**: `boolean`

Defined in: [src/base/propertyitem.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L202)

When true the field appears only in filter dialogs / panels and not in the grid itself.

***

### focusable?

> `optional` **focusable**: `boolean`

Defined in: [src/base/propertyitem.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L150)

Whether the column can receive focus / be navigated via keyboard.

***

### formatterParams?

> `optional` **formatterParams**: `any`

Defined in: [src/base/propertyitem.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L154)

Options passed to the formatter.

***

### formatterType?

> `optional` **formatterType**: `string` \| (`props?`) => `object` \| `PromiseLike`\<(`props?`) => `object`\>

Defined in: [src/base/propertyitem.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L152)

Formatter type key or constructor / lazy import used to render the cell value.

***

### formCssClass?

> `optional` **formCssClass**: `string`

Defined in: [src/base/propertyitem.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L102)

CSS class applied to the form field container (`<div class="field">`).

***

### groupOrder?

> `optional` **groupOrder**: `number`

Defined in: [src/base/propertyitem.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L182)

Order index for grouping; controls group-by precedence when multiple columns are grouped.

***

### headerCssClass?

> `optional` **headerCssClass**: `string`

Defined in: [src/base/propertyitem.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L100)

CSS class applied to the column header.

***

### hideOnInsert?

> `optional` **hideOnInsert**: `boolean`

Defined in: [src/base/propertyitem.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L112)

Hides the field in insert (create) mode.

***

### hideOnUpdate?

> `optional` **hideOnUpdate**: `boolean`

Defined in: [src/base/propertyitem.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L118)

Hides the field in update (edit) mode.

***

### hint?

> `optional` **hint**: `string`

Defined in: [src/base/propertyitem.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L78)

Tooltip / hint shown on hover or beside the label.

***

### insertable?

> `optional` **insertable**: `boolean`

Defined in: [src/base/propertyitem.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L108)

Whether the field can be set on insert. When false the field is read-only during creation.

***

### insertPermission?

> `optional` **insertPermission**: `string`

Defined in: [src/base/propertyitem.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L110)

Permission key required to set the field on insert.

***

### labelWidth?

> `optional` **labelWidth**: `string`

Defined in: [src/base/propertyitem.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L170)

Width of the form label for this field (e.g. `"150px"`).

***

### localizable?

> `optional` **localizable**: `boolean`

Defined in: [src/base/propertyitem.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L134)

Whether the field supports per-language values (requires Localizations).

***

### maxLength?

> `optional` **maxLength**: `number`

Defined in: [src/base/propertyitem.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L104)

Maximum string length for validation.

***

### maxWidth?

> `optional` **maxWidth**: `number`

Defined in: [src/base/propertyitem.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L168)

Maximum column width in pixels.

***

### minWidth?

> `optional` **minWidth**: `number`

Defined in: [src/base/propertyitem.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L166)

Minimum column width in pixels.

***

### name

> **name**: `string`

Defined in: [src/base/propertyitem.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L74)

Field / property key (usually the row field name).

***

### notFilterable?

> `optional` **notFilterable**: `boolean`

Defined in: [src/base/propertyitem.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L200)

When true the column cannot be used as a filter criterion.

***

### ~~oneWay?~~

> `optional` **oneWay**: `boolean`

Defined in: [src/base/propertyitem.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L130)

#### Deprecated

use [skipOnSave](#skiponsave) instead — kept for backward compatibility.

***

### pin?

> `optional` **pin**: `boolean` \| `"start"` \| `"end"`

Defined in: [src/base/propertyitem.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L160)

Pin / freeze the column to the start (left) or end (right) of the grid, or `true` for start.

***

### placeholder?

> `optional` **placeholder**: `string`

Defined in: [src/base/propertyitem.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L80)

Placeholder text for the editor input.

***

### quickFilter?

> `optional` **quickFilter**: `boolean`

Defined in: [src/base/propertyitem.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L204)

Whether the field appears in the quick-filter bar above the grid.

***

### quickFilterCssClass?

> `optional` **quickFilterCssClass**: `string`

Defined in: [src/base/propertyitem.ts:210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L210)

Extra CSS class for the quick-filter item.

***

### quickFilterParams?

> `optional` **quickFilterParams**: `any`

Defined in: [src/base/propertyitem.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L206)

Options for the quick-filter editor.

***

### quickFilterSeparator?

> `optional` **quickFilterSeparator**: `boolean`

Defined in: [src/base/propertyitem.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L208)

When true a separator is rendered before this quick filter in the bar.

***

### readOnly?

> `optional` **readOnly**: `boolean`

Defined in: [src/base/propertyitem.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L120)

Whether the field is read-only in the UI (still submitted unless [skipOnSave](#skiponsave) is set).

***

### readOnlyWhen?

> `optional` **readOnlyWhen**: [`PropertyCondition`](PropertyCondition.md)[]

Defined in: [src/base/propertyitem.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L142)

Conditions on other fields that make the field read only in forms when they are all met.

***

### readPermission?

> `optional` **readPermission**: `string`

Defined in: [src/base/propertyitem.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L122)

Permission key required to read / view the field. Clients may hide the field when the user lacks it.

***

### required?

> `optional` **required**: `boolean`

Defined in: [src/base/propertyitem.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L106)

Whether a value is required.

***

### requiredWhen?

> `optional` **requiredWhen**: [`PropertyCondition`](PropertyCondition.md)[]

Defined in: [src/base/propertyitem.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L144)

Conditions on other fields that make the field required in forms when they are all met.

***

### resizable?

> `optional` **resizable**: `boolean`

Defined in: [src/base/propertyitem.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L172)

Whether the column is user-resizable.

***

### showSelection?

> `optional` **showSelection**: `boolean`

Defined in: [src/base/propertyitem.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L174)

Whether to show a selection checkbox column behavior for this column.

***

### skipOnLoad?

> `optional` **skipOnLoad**: `boolean`

Defined in: [src/base/propertyitem.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L124)

When true the field is not populated on load (e.g. sensitive data).

***

### skipOnSave?

> `optional` **skipOnSave**: `boolean`

Defined in: [src/base/propertyitem.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L126)

When true the field value is not sent back on save.

***

### sortable?

> `optional` **sortable**: `boolean`

Defined in: [src/base/propertyitem.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L176)

Whether the column can be sorted.

***

### sortOrder?

> `optional` **sortOrder**: `number`

Defined in: [src/base/propertyitem.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L178)

Default sort order index (lower values are sorted first). Negative or undefined means no default sort.

***

### summaryType?

> `optional` **summaryType**: [`SummaryType`](../enumerations/SummaryType.md)

Defined in: [src/base/propertyitem.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L184)

Aggregation used for group / footer summaries. See [SummaryType](../enumerations/SummaryType.md).

***

### tab?

> `optional` **tab**: `string`

Defined in: [src/base/propertyitem.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L96)

Tab name the field belongs to when the form uses tabs.

***

### tabbable?

> `optional` **tabbable**: `boolean`

Defined in: [src/base/propertyitem.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L180)

Whether the column participates in tab-stop navigation.

***

### title?

> `optional` **title**: `string`

Defined in: [src/base/propertyitem.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L76)

Display title / column header / form label. Falls back to `name` when omitted.

***

### unbound?

> `optional` **unbound**: `boolean`

Defined in: [src/base/propertyitem.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L128)

True for unbound fields that do not map to a row column (e.g. calculated UI-only fields).

***

### updatable?

> `optional` **updatable**: `boolean`

Defined in: [src/base/propertyitem.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L114)

Whether the field can be updated after creation.

***

### updatePermission?

> `optional` **updatePermission**: `string`

Defined in: [src/base/propertyitem.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L116)

Permission key required to update the field.

***

### validationRules?

> `optional` **validationRules**: [`ClientValidationRule`](ClientValidationRule.md)[]

Defined in: [src/base/propertyitem.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L146)

Validation rules the forms check for the field, from its validation attributes on the server, e.g. a range.

***

### visible?

> `optional` **visible**: `boolean`

Defined in: [src/base/propertyitem.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L136)

Whether the column / field is visible by default. Hidden columns can still be shown via column picker.

***

### visibleWhen?

> `optional` **visibleWhen**: [`PropertyCondition`](PropertyCondition.md)[]

Defined in: [src/base/propertyitem.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L138)

Conditions on other fields that must all be met for the field to be visible in forms. They only hide, never show a field hidden otherwise.

***

### width?

> `optional` **width**: `number`

Defined in: [src/base/propertyitem.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L162)

Preferred column width in pixels.

***

### widthSet?

> `optional` **widthSet**: `boolean`

Defined in: [src/base/propertyitem.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L164)

True when [width](#width) was explicitly set (vs. auto-calculated).
