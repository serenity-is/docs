# Grid Columns

Grid columns in Serenity are defined declaratively in a **columns class** — a plain class whose properties describe the columns of a grid. The class is turned into a **columns script** (a dynamic script) that the client grid loads to build its columns.

## The Columns Class

A columns class is a plain class with public properties. Each property becomes a column:

```cs
[ColumnsScript]
public class OrderColumns
{
    [Width(150), EditLink]
    public string CustomerID { get; set; }

    [Width(200)]
    public string ShipCity { get; set; }

    [Width(120), AlignRight]
    public decimal? Freight { get; set; }
}
```

The `[ColumnsScript]` attribute marks the class so that a columns script is generated and registered. See [Script Generation](script-generation.md) for the attribute itself.

## `[ColumnsScript]` in Detail

### Auto Key Determination

When you use `[ColumnsScript]` without a key, the script key is the **full name of the type**:

```cs
[ColumnsScript]
public class OrderColumns { }
// key = "MyProject.Northwind.OrderColumns"
```

You can also specify an explicit key:

```cs
[ColumnsScript("Northwind.Order")]
public class OrderColumns { }
```

The generated dynamic script is registered under the key `Columns.<key>` (the `ColumnsScript` dynamic script type prefixes the name with `Columns.`). So for the example above the script name is `Columns.Northwind.Order`.

### What It Generates

A columns script is a **dynamic script** (specifically a `PropertyItemsScript`) that produces a `PropertyItemsData` object — a JSON structure containing the `PropertyItem[]` array for the columns, plus any `AdditionalItems`. The `PropertyItem` objects are built by the `IPropertyItemProvider` from the attributes on the columns class (and its `BasedOnRow` row, if any).

The script is served through the dynamic script middleware, and can be retrieved as **JSON** (via `~/DynamicData`) or as a **script** (via `~/DynJS.axd`).

### Accessing Columns from the Client

On the client side you load the columns data with the async helpers:

```ts
import { getColumnsDataAsync } from "@serenity-is/corelib";

const data = await getColumnsDataAsync("Northwind.Order");
// data.items is the PropertyItem[] for the columns
```

The older synchronous `getColumns` (and `getColumnsData`) methods are **deprecated** in favor of the async versions, which don't block the UI thread. Grids load their columns automatically through `getColumnsKey()` / `getPropertyItemsData()`, so you normally don't call these directly.

## `[BasedOnRow]`

A columns class often maps to a row. The [BasedOnRowAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/BasedOnRowAttribute.md) tells Serenity that the columns class is based on a row type, so each column property **inherits the attributes from the matching row field** (display name, formatter, filtering, etc.):

```cs
[ColumnsScript("Northwind.Order")]
[BasedOnRow(typeof(OrderRow))]
public class OrderColumns
{
    [Width(150)]
    public string CustomerID { get; set; }
    // ...
}
```

- Properties whose names match row fields inherit the row field's attributes (e.g. `[DisplayName]`, `[FormatterType]`, `[Filtering]`).
- `CheckNames = true` validates that every property matches a row field (add `[SkipNameCheck]` to properties that shouldn't be checked).
- When `BasedOnRow` is set, the provider also generates `AdditionalItems` for any `FilteringIdField` referenced by the columns but not explicitly declared.

## Column Attributes

These attributes apply to columns-class properties and set the corresponding `PropertyItem` properties that the client grid reads.

### Layout & Width

| Attribute | `PropertyItem` property | Description |
| --- | --- | --- |
| [WidthAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/WidthAttribute.md) | `width` | Column width in pixels |
| [FixedWidthAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/FixedWidthAttribute.md) | `width` (fixed) | Fixed width that can't be resized |
| [AlignCenterAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/AlignCenterAttribute.md) / `AlignRight` | `alignment` | Text alignment in the column |

### Behavior

| Attribute | `PropertyItem` property | Description |
| --- | --- | --- |
| [SortableAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/SortableAttribute.md) | `sortable` | Whether the column can be sorted |
| [EditLinkAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/EditLinkAttribute.md) | `editLink` | Renders the value as a link that opens the edit dialog |
| [ShowSelectionAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/ShowSelectionAttribute.md) | `showSelection` | Shows a selection checkbox in the column |
| [PinToStartAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/PinToStartAttribute.md) / `PinToEnd` | `pinnedPosition` | Pins the column to the start/end of the grid |
| `FocusableAttribute` / `TabbableAttribute` | `tabIndex` | Keyboard focus/tab behavior |

### Formatting

| Attribute | `PropertyItem` property | Description |
| --- | --- | --- |
| [FormatterTypeAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/FormatterTypeAttribute.md) | `formatterType` | The formatter used to render the cell (e.g. `Date`, `Number`, `Enum`) |
| `FormatterOptionAttribute` | `formatterParams` | Options passed to the formatter |
| `DisplayFormatAttribute` | `format` | Display format for date/number formatters |
| `SummaryTypeAttribute` | `summaryType` | Aggregation shown in the grid footer (e.g. `Sum`, `Avg`) |

### Filtering

| Attribute | `PropertyItem` property | Description |
| --- | --- | --- |
| `FilteringTypeAttribute` | `filteringType` | The filtering type for the column's quick filter |
| `FilteringOptionAttribute` | `filteringParams` | Options for the filtering type |
| `QuickFilterAttribute` | `quickFilter` | Shows a quick filter for the column |
| `NotFilterableAttribute` | `filtering` | Disables filtering for the column |

> The `PropertyItem` type is shared between columns and forms — see the [PropertyItem API reference](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/PropertyItem.md) for the full list of properties.

## See Also

- [Script Generation](script-generation.md)
- [Dynamic Scripts](dynamic-scripts/readme.md)
- [Forms & Editors](attributes/attributes.md)
- [Formatter Types](../grids/formatter_types.md)
