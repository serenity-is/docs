# Forms & Editors

Forms in Serenity are defined declaratively with a **form class** — a plain class whose properties describe the fields of an edit dialog. Each property becomes a form field, and the editor used for it is determined by attributes on the property (or inherited from the row via `[BasedOnRow]`).

## The Form Class

A form class is a plain class with public properties. Each property becomes a form field:

```cs
[FormScript]
public class OrderForm
{
    [DisplayText("Customer"), LookupEditor(typeof(CustomerRow))]
    public string? CustomerID { get; set; }

    [TextAreaEditor(Rows = 3)]
    public string? Description { get; set; }

    [HalfWidth]
    public DateTime? OrderDate { get; set; }
}
```

The `[FormScript]` attribute marks the class so that a form script is generated (see [Script Generation](dynamic-scripts/script-generation.md)). Like columns, a form script is a `PropertyItemsScript` that produces a `PropertyItemsData` JSON structure, loaded on the client with `getFormDataAsync("Key")`.

### Form keys and `InferKey`

Without a key, a form is registered under its **full type name**. Passing `InferKey = true` derives a shorter key instead, so keys don't have to be spelled out (and don't drift) for every form:

```cs
[FormScript(InferKey = true)] // Serenity.Pro.Meeting.Forms.MeetingForm -> Pro.Meeting.Meeting
public class MeetingForm { }
```

The key is inferred from the `[Module]` attribute when the form has one (or its `[BasedOnRow]` row has), otherwise from the namespace. The root namespace, the `Forms` / `Columns` namespace segment and the `Form` / `Columns` / `Request` type suffix are dropped:

- `MovieDB.Movie.Forms.MovieForm` → `Movie.Movie`
- `MovieDB.Movie.Columns.MovieColumns` → `Movie.Movie`
- a form named `MovieForm` in the `MovieDB` namespace (no module) → `MovieDB.Movie` (the namespace stays, only the suffix is dropped)

With a `[Module("Movie")]` on the type (or on the `[BasedOnRow]` row), the module value replaces the namespace, so the
same form becomes `Movie.Movie`.

`[ColumnsScript(InferKey = true)]` works the same way. The server typings generator,
`FormScriptRegistration`, `ColumnsScriptRegistration` and
`PropertyItemsLocalTextRegistration` share the resolution
(`FormScriptAttribute.AutoFormKeyFor` / `ColumnsScriptAttribute.AutoColumnsKeyFor`),
so the generated `formKey` / `columnsKey` and the runtime script and text prefixes
match. `[EnumKey]` has the same option for enums, including the parameterless
`[EnumKey]` that implies it (see [Localization](localization.md#enumkey-attribute)).

> The `.Lookups` namespace segment is **not** stripped (only `.Forms` and `.Columns`
> are), so a lookup class in `MyApp.Lookups` keeps that segment in its key.

If you turn `InferKey` on for existing forms, regenerate server types and texts and
check anything that hardcodes a form or columns key.

## `[BasedOnRow]`

Just like columns, a form class is usually based on a row. The [BasedOnRowAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/BasedOnRowAttribute.md) makes each form property **inherit the attributes from the matching row field** (editor type, required, insertable/updatable, etc.):

```cs
[FormScript("Northwind.Order")]
[BasedOnRow(typeof(OrderRow))]
public class OrderForm
{
    [HalfWidth]
    public string? CustomerID { get; set; }
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
| Boolean | `[BooleanEditor]` | Checkbox (see `LabelPosition` below) |
| Integer / Decimal | `[IntegerEditor]` / `[DecimalEditor]` | Numeric input |
| Int64 | `[Int64Editor]` | 64-bit integer input (preserves values beyond `Number.MAX_SAFE_INTEGER`) |
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

### Editor attribute templates

A custom editor attribute can **inherit defaults from a template** — an editor attribute of the same family
(`ServiceLookupEditorBase` or `LookupEditorBase`) declared on its own class. The options of the template are applied
first, then the attribute's own options, so explicit options always win:

```cs
[ServiceLookupEditor(typeof(CustomerRow), Service = "Northwind/Customer/List")]
public partial class MyCustomerEditorAttribute : ServiceLookupEditorBaseAttribute
{
    public MyCustomerEditorAttribute() : base("MyCustomer") { }
}
```

For a service lookup template, the `ItemType` / `EndpointType` / `ActionName` are only taken from it when the attribute
specifies no endpoint, and the lookup template options (including capabilities and quick search fields) are copied into
the filtering options.

Since 10.7.0 the server typings generator emits a `<Editor>Defaults` constant (e.g. `MyCustomerEditorDefaults`) for such
attributes, resolving the service/action, capabilities (as named enum members like
`FilteringOptions | Sort | PagingOptions`), id/text/icon fields and lookup keys the same way the server does. A client
editor created directly, outside a form, can then use those defaults. `SetServiceLookupParams` is public, so the same
resolution can be reused from your own code.

### `[EditorOption]`

[EditorOptionAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/EditorOptionAttribute.md) lets you set an arbitrary editor option directly on a property:

```cs
[EditorOption("minValue", 0), EditorOption("maxValue", 100)]
public int? Score { get; set; }
```

> Avoid this where possible — option keys and values are not checked. Prefer a typed editor attribute (e.g. `[IntegerEditor(MinValue = 0, MaxValue = 100)]`) which is validated.

### `[EditorCssClass]`

[EditorCssClassAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/EditorCssClassAttribute.md) adds a CSS class to the editor element itself (as opposed to `[CssClass]`, which targets the field container).

### Checkbox label position

`BooleanEditorAttribute` / `BooleanEditorOptions` take `LabelPosition`, a
`CheckLabelPosition` enum, instead of a boolean:

| Value | Layout |
| --- | --- |
| `Start` (default) | Caption in the caption area, checkbox after it, where other editors start |
| `End` | Checkbox first, caption after it — saves horizontal space, lets several checkboxes share a row |
| `EndAligned` | Like `End`, but the caption area before the checkbox is left empty, so a checkbox alone in its row lines up with the editors above |

The `EndAligned` spacer is hidden in vertical forms and on narrow screens by CSS.
On the client the option is `labelPosition` in the editor params.

```cs
[BooleanEditor(LabelPosition = CheckLabelPosition.End)]
public bool? IsActive { get; set; }
```

> The old `LabelOnEnd` / `labelOnEnd` option was replaced by this enum in 10.7.0.
> An enum editor saves its value as text, so the option is parsed with `Number()`.

## Form Field Attributes

These attributes control how a form field behaves and is laid out.

### Validation & Editing

| Attribute | `PropertyItem` property | Description |
| --- | --- | --- |
| [RequiredAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/RequiredAttribute.md) | `required` | Marks the field as required |
| [MaxLengthAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/MaxLengthAttribute.md) | `maxLength` | Maximum input length |
| `[ValidateRange]`, `[ValidateLength]`, `[ValidatePattern]`, `[ValidateEmail]`, `[ValidateUrl]`, `[ValidateCompare]` | `validationRules` | Rules checked by the forms **and** the save handlers (see [Validation](../services/validation.md#the-validate-attributes)) |
| [OneWayAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/OneWayAttribute.md) | `oneWay` | Value is sent to server but not loaded back |
| [InsertableAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/InsertableAttribute.md) / `[Updatable]` | `insertable` / `updatable` | Editable on new/edit record mode |
| [HideOnInsertAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/HideOnInsertAttribute.md) / `[HideOnUpdate]` | `visible` | Hidden on new/edit record mode |

> The `[Required]`, `[MaxLength]` and `[DisplayFormat]` attributes a Serenity project uses
> are the ones in `Serenity.ComponentModel`, not the `System.ComponentModel.DataAnnotations`
> ones, which behave differently. Since 10.7.0 the `Serenity.Net.Web` targets add global
> using aliases for these three names, so unqualified attributes in application code bind
> to the Serenity ones.

### Conditional fields

A field can depend on the value of another field with `[VisibleWhen]`, `[ReadOnlyWhen]`
and `[RequiredWhen]` (subclasses of `PropertyConditionAttribute`):

```cs
[VisibleWhen(nameof(Action), MyAction.OpenLink)]
[ReadOnlyWhen(nameof(IsSystem))]
[RequiredWhen(nameof(Action), MyAction.Save)]
public string? LinkAddress { get; set; }
```

- A property can have several conditions of the same kind, and **all** of them must be
  met. With no values the condition means "has a value" (for a checkbox, "is
  checked"); `IsNot = true` inverts it.
- A named rule is a one-liner:
  `public class ForLinkAttribute() : VisibleWhenAttribute(nameof(Action), MyAction.OpenLink) { }`.
- The conditions are sent to the forms as `visibleWhen` / `readOnlyWhen` /
  `requiredWhen` (with enum values as numbers), and evaluated by the `PropertyGrid` as
  values load and change. `[VisibleWhen(ClearWhenHidden = true)]` saves the value as
  empty while the field is hidden.
- A condition only **hides** a field; a field hidden by `[Visible]`, a permission or the
  insert/update mode stays hidden. Categories and tabs whose fields are all hidden are
  hidden too, and a hidden field is not validated (e.g. not required).
- `[RequiredWhen]` is also enforced by the save handlers (`ValidateRequiredWhen`), so it
  is not just a UI hint. Conditions in general are **not a security boundary** — see
  [Validation](../services/validation.md#conditional-fields-requiredwhen).

See [PropertyGrid and Forms](../editors/propertygrid.md#conditional-fields) for the client side.

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

### Ordering inherited properties

Inherited properties otherwise come in the order their types are declared in the assembly, which doesn't tell which of a type and its base type comes first. `BasePropertyOrderAttribute` (`BasePropertyPosition.Default` / `Before` / `After`, `TypesBefore` / `TypesAfter`, `WhenInherited`) puts the properties of a type where you want them in forms and property grids:

```cs
[BasePropertyOrder(WhenInherited = BasePropertyPosition.After)]
public abstract class AuditOptions
{
    public int? CreatedBy { get; set; }
    // ... always after the other properties of the inheriting type
}

[BasePropertyOrder(Position = BasePropertyPosition.After)]
public class DatasetOptions : TitleOptions { /* own properties first, then the title ones */ }
```

- `Position` places the properties of all base types before or after the type's own ones.
- `TypesBefore` / `TypesAfter` place the properties of the listed base types (in list order) before or after, and win over what those base types ask for themselves.
- `WhenInherited` is for the type itself: where its properties go in any type that inherits it.
- The properties declared in the same type always keep their declaration order, and the options compose across multi-level hierarchies.

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
public string? SomeField { get; set; }
```

The add-on type and its options are transferred to the `PropertyItem`'s `editorAddons` collection (see [EditorAddonItem](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/EditorAddonItem.md)).

## See Also

- [Script Generation](dynamic-scripts/script-generation.md)
- [Grid Columns](grid-columns.md)
- [Attributes Reference](../attributes/attributes.md)
- [Dynamic Scripts](dynamic-scripts/readme.md)