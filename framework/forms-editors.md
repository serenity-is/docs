# Forms & Editors

Forms in Serenity are defined declaratively with a **form class** — a plain class whose properties describe the fields of an edit dialog. Each property becomes a form field, and the editor used for it is determined by attributes on the property (or inherited from the row via `[BasedOnRow]`).

## The Form Class

A form class is a plain class with public properties. Each property becomes a form field:

```cs
[FormScript]
public class OrderForm
{
    [DisplayName("Customer"), LookupEditor(typeof(CustomerRow))]
    public string CustomerID { get; set; }

    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }

    [HalfWidth]
    public DateTime? OrderDate { get; set; }
}
```

The `[FormScript]` attribute marks the class so that a form script is generated (see [Script Generation](script-generation.md)). Like columns, a form script is a `PropertyItemsScript` that produces a `PropertyItemsData` JSON structure, loaded on the client with `getFormDataAsync("Key")`.

## `[BasedOnRow]`

Just like columns, a form class is usually based on a row. The [BasedOnRowAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/BasedOnRowAttribute.md) makes each form property **inherit the attributes from the matching row field** (editor type, required, insertable/updatable, etc.):

```cs
[FormScript("Northwind.Order")]
[BasedOnRow(typeof(OrderRow))]
public class OrderForm
{
    [HalfWidth]
    public string CustomerID { get; set; }
    // ...
}
```

- Properties whose names match row fields inherit the row field's attributes.
- `CheckNames = true` validates that every property matches a row field (add `[SkipNameCheck]` to properties that shouldn't be checked).

## Editor Attributes

The editor for a field is set with an editor attribute. Serenity ships a large set of built-in editor attributes (in the `Serenity.ComponentModel` namespace), including:

| Editor | Attribute | Typical use |
| --- | --- | --- |
| String | `[StringEditor]` | Single-line text |
| TextArea | `[TextAreaEditor]` | Multi-line text |
| Boolean | `[BooleanEditor]` | Checkbox |
| Integer / Decimal | `[IntegerEditor]` / `[DecimalEditor]` | Numeric input |
| Date / DateTime | `[DateEditor]` / `[DateTimeEditor]` | Date/time pickers |
| Enum | `[EnumEditor]` | Dropdown from an enum |
| Lookup | [LookupEditorAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/LookupEditorAttribute.md) | Dropdown from a lookup script |
| ServiceLookup | `[ServiceLookupEditor]` | Dropdown from a service lookup |
| Password | `[PasswordEditor]` | Password input |
| Email / Url | `[EmailAddressEditor]` / `[URLEditor]` | Email/URL input |
| HtmlContent | `[HtmlContentEditor]` | Rich HTML editor |
| Time | `[TimeEditor]` | Time picker |

### How Editor Attributes Work

All editor attributes derive from [CustomEditorAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/CustomEditorAttribute.md), which in turn derives from [EditorTypeAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/EditorTypeAttribute.md). `EditorTypeAttribute` sets the editor type key (e.g. `"Lookup"`, `"Date"`), and `CustomEditorAttribute` adds the ability to set editor options:

```cs
public abstract class CustomEditorAttribute(string editorType) : EditorTypeAttribute(editorType)
{
    protected void SetOption(string key, object? value);
    protected TType GetOption<TType>(string key);
}
```

The options set via `SetOption` are transferred to the `editorParams` dictionary of the generated `PropertyItem`, which the client editor reads.

### `[EditorOption]`

[EditorOptionAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/EditorOptionAttribute.md) lets you set an arbitrary editor option directly on a property:

```cs
[EditorOption("minValue", 0), EditorOption("maxValue", 100)]
public int? Score { get; set; }
```

> Avoid this where possible — option keys and values are not checked. Prefer a typed editor attribute (e.g. `[IntegerEditor(MinValue = 0, MaxValue = 100)]`) which is validated.

### `[EditorCssClass]`

[EditorCssClassAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/EditorCssClassAttribute.md) adds a CSS class to the editor element itself (as opposed to `[CssClass]`, which targets the field container).

## Form Field Attributes

These attributes control how a form field behaves and is laid out.

### Validation & Editing

| Attribute | `PropertyItem` property | Description |
| --- | --- | --- |
| [RequiredAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/RequiredAttribute.md) | `required` | Marks the field as required |
| [MaxLengthAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/MaxLengthAttribute.md) | `maxLength` | Maximum input length |
| [OneWayAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/OneWayAttribute.md) | `oneWay` | Value is sent to server but not loaded back |
| [InsertableAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/InsertableAttribute.md) / `[Updatable]` | `insertable` / `updatable` | Editable on new/edit record mode |
| [HideOnInsertAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/HideOnInsertAttribute.md) / `[HideOnUpdate]` | `visible` | Hidden on new/edit record mode |

### Layout & Grouping

| Attribute | `PropertyItem` property | Description |
| --- | --- | --- |
| [TabAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/TabAttribute.md) | `category` | Places the field in a tab/category |
| [CollapsibleAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/CollapsibleAttribute.md) | `collapsible` | Makes the field's category collapsible |
| [SortOrderAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/SortOrderAttribute.md) | `sortOrder` | Field order within the form |
| [GroupOrderAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/GroupOrderAttribute.md) | `groupOrder` | Order of the field's group |
| [ResizableAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/ResizableAttribute.md) | `resizable` | Allows resizing the field |
| [UnboundAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/UnboundAttribute.md) | `unbound` | Field is not bound to a row field |
| [SkipNameCheckAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/SkipNameCheckAttribute.md) | — | Skips `CheckNames` validation for this property |

### Width & Layout

Form field widths are set with the layout width attributes, which apply Bootstrap grid column classes:

| Attribute | CSS class | Width |
| --- | --- | --- |
| [FullWidthAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/FullWidthAttribute.md) | `col-sm-12` | Full row |
| [HalfWidthAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/HalfWidthAttribute.md) | `col-sm-6` | Half row |
| `OneThirdWidthAttribute` | `col-sm-4` | One third |
| `TwoThirdWidthAttribute` | `col-sm-8` | Two thirds |
| `QuarterWidthAttribute` | `col-sm-3` | Quarter |
| `ThreeQuarterWidthAttribute` | `col-sm-9` | Three quarters |

All of these derive from [FormWidthAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/FormWidthAttribute.md), which lets you set responsive widths per device size (`XSmall`, `Small`, `Medium`, `Large`) and control whether the width applies to the current field only (`JustThis`) or to all following fields (`UntilNext`).

## Editor Add-ons

[EditorAddonAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/EditorAddonAttribute.md) adds an **editor add-on** to a field — a small UI element attached to the editor (e.g. a button or icon). It's `AllowMultiple`, so a field can have several add-ons:

```cs
[EditorAddon("MyAddon", Option = "value")]
public string SomeField { get; set; }
```

The add-on type and its options are transferred to the `PropertyItem`'s `editorAddons` collection (see [EditorAddonItem](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/EditorAddonItem.md)).

## See Also

- [Script Generation](script-generation.md)
- [Grid Columns](grid-columns.md)
- [Attributes Reference](../attributes/attributes.md)
- [Dynamic Scripts](dynamic-scripts/readme.md)