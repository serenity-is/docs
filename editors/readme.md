# Editors

Editors are the input widgets used in Serenity forms. They are created by the `PropertyGrid` based on the editor type specified in the form metadata (via editor attributes on the server side), and they implement standard value interfaces so the form can read and write their values.

## The EditorWidget Base

Most editors derive from `EditorWidget`, which extends `Widget` and adds editor-specific props and read-only handling:

```ts
type EditorProps<T> = WidgetProps<T> & {
    initialValue?: any;
    maxLength?: number;
    name?: string;
    placeholder?: string;
    required?: boolean;
    readOnly?: boolean;
}
```

`EditorWidget` provides a `readOnly` property that sets/gets the read-only state of the editor's element.

## Value Interfaces

Editors implement value interfaces that let the form (and other code) interact with them generically:

| Interface | Purpose |
| --- | --- |
| `IStringValue` | `get_value()` / `set_value()` for string editors. |
| `IDoubleValue` | `get_value()` / `set_value()` for numeric editors. |
| `IBooleanValue` | `get_value()` / `set_value()` for boolean editors. |
| `IGetEditValue` | `getEditValue(property, target)` — writes the editor value into a target object. |
| `ISetEditValue` | `setEditValue(source, property)` — populates the editor from a source object. |
| `IReadOnly` | Marks a widget as supporting read-only state. |
| `IValidateRequired` | Marks an editor that participates in required validation. |

The `PropertyGrid` uses these interfaces to load entity values into editors and to collect edited values back into the entity.

## Editors by Task

### Text Editors

| Editor | Description |
| --- | --- |
| [StringEditor](../api/js/corelib/classes/StringEditor.md) | Single-line text input. |
| [TextAreaEditor](../api/js/corelib/classes/TextAreaEditor.md) | Multi-line text area. |
| [EmailEditor](../api/js/corelib/classes/EmailEditor.md) | Email input with validation. |
| [EmailAddressEditor](../api/js/corelib/classes/EmailAddressEditor.md) | Email address input. |
| [PasswordEditor](../api/js/corelib/classes/PasswordEditor.md) | Password input. |
| [URLEditor](../api/js/corelib/classes/URLEditor.md) | URL input. |
| [MaskedEditor](../api/js/corelib/classes/MaskedEditor.md) | Masked input. |

### Numeric Editors

| Editor | Description |
| --- | --- |
| [IntegerEditor](../api/js/corelib/classes/IntegerEditor.md) | Integer input. |
| [DecimalEditor](../api/js/corelib/classes/DecimalEditor.md) | Decimal input. |
| [AutoNumeric](../api/js/corelib/classes/AutoNumeric.md) | Numeric input with formatting. |

### Date and Time Editors

| Editor | Description |
| --- | --- |
| [DateEditor](../api/js/corelib/classes/DateEditor.md) | Date picker. |
| [DateTimeEditor](../api/js/corelib/classes/DateTimeEditor.md) | Date-time picker. |
| [DateYearEditor](../api/js/corelib/classes/DateYearEditor.md) | Year picker. |
| [TimeEditor](../api/js/corelib/classes/TimeEditor.md) | Time picker. |

### Selection Editors

| Editor | Description |
| --- | --- |
| [SelectEditor](../api/js/corelib/classes/SelectEditor.md) | Dropdown from a static list. |
| [EnumEditor](../api/js/corelib/classes/EnumEditor.md) | Dropdown from an enum. |
| [ComboboxEditor](../api/js/corelib/classes/ComboboxEditor.md) | Combobox with search. |
| [RadioButtonEditor](../api/js/corelib/classes/RadioButtonEditor.md) | Radio button group. |
| [BooleanEditor](../api/js/corelib/classes/BooleanEditor.md) | Checkbox. |
| [CheckTreeEditor](../api/js/corelib/classes/CheckTreeEditor.md) | Checkbox tree. |

### Lookup Editors

| Editor | Description |
| --- | --- |
| [LookupEditor](../api/js/corelib/classes/LookupEditor.md) | Dropdown from a lookup script. |
| [ServiceLookupEditor](../api/js/corelib/classes/ServiceLookupEditor.md) | Dropdown from a service lookup. |
| [CheckLookupEditor](../api/js/corelib/classes/CheckLookupEditor.md) | Checkbox list from a lookup. |

See [Lookup Editors](lookup-editors.md) for details.

### File Editors

| Editor | Description |
| --- | --- |
| [FileUploadEditor](../api/js/corelib/classes/FileUploadEditor.md) | Single file upload. |
| [MultipleFileUploadEditor](../api/js/corelib/classes/MultipleFileUploadEditor.md) | Multiple file upload. |
| [ImageUploadEditor](../api/js/corelib/classes/ImageUploadEditor.md) | Single image upload. |
| [MultipleImageUploadEditor](../api/js/corelib/classes/MultipleImageUploadEditor.md) | Multiple image upload. |

### Rich Text Editors

| Editor | Description |
| --- | --- |
| [HtmlContentEditor](../api/js/corelib/classes/HtmlContentEditor.md) | Rich HTML editor. |
| [HtmlNoteContentEditor](../api/js/corelib/classes/HtmlNoteContentEditor.md) | Rich HTML editor for notes. |
| [HtmlReportContentEditor](../api/js/corelib/classes/HtmlReportContentEditor.md) | Rich HTML editor for reports. |

### Other Editors

| Editor | Description |
| --- | --- |
| [Recaptcha](../api/js/corelib/classes/Recaptcha.md) | reCAPTCHA widget. |
| [CascadedWidgetLink](../api/js/corelib/classes/CascadedWidgetLink.md) | Links a parent editor to a child editor (cascading). |

## How Editors Are Selected

On the server side, a form property specifies its editor via an editor attribute:

```cs
[LookupEditor(typeof(CustomerRow))]
public string CustomerID { get; set; }
```

The attribute sets the editor type key (e.g. `"Lookup"`) and editor options. The generated `PropertyItem` carries this to the client, where the `PropertyGrid` looks up the editor type in the `EditorTypeRegistry` and creates it with the given options.

## Custom Editors

To create a custom editor, extend `Widget` (or `EditorWidget`), implement the value interfaces you need, and register it with `registerEditor`:

```ts
export class MyEditor extends Widget<MyEditorOptions> {
    static override [Symbol.typeInfo] = this.registerEditor("MyApp.MyEditor", [IGetEditValue, ISetEditValue]);
    // ...
}
```

See [Custom Editors](custom-editors.md) for details.

## See Also

- [EditorWidget (API reference)](../api/js/corelib/classes/EditorWidget.md) — the editor base class.
- [IStringValue](../api/js/corelib/classes/IStringValue.md), [IDoubleValue](../api/js/corelib/classes/IDoubleValue.md), [IBooleanValue](../api/js/corelib/classes/IBooleanValue.md) — value interfaces.
- [IGetEditValue](../api/js/corelib/classes/IGetEditValue.md), [ISetEditValue](../api/js/corelib/classes/ISetEditValue.md) — edit value interfaces.
- [Lookup Editors](lookup-editors.md) — lookup and service lookup editors.
- [PropertyGrid and Forms](propertygrid.md) — how forms are built from metadata.
- [Custom Editors](custom-editors.md) — creating custom editors.
- [Type Registration](../framework/ui/type-registration.md) — registering editor types.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.