# Lookup Editors

Lookup editors are dropdowns that let users pick a value from a list of options. There are two main kinds:

- **`LookupEditor`** — loads options from a **lookup script** (a server-side `[LookupScript]`).
- **`ServiceLookupEditor`** — loads options from a **service** (a list endpoint).

Both are combobox-based and support searching, in-place add, and cascading.

## LookupEditor

`LookupEditor` renders a combobox over items from a lookup script. The lookup key is determined from the `lookupKey` option, or derived from the editor class name.

On the server side, a form property uses `[LookupEditor]`:

```cs
[LookupEditor(typeof(CustomerRow))]
public string CustomerID { get; set; }
```

The generated form declares the editor type:

```ts
export interface UserForm {
    Roles: LookupEditor;
    // ...
}
```

### LookupEditor Options

| Option | Description |
| --- | --- |
| `lookupKey` | Key of the lookup to load items from. |
| `async` | Whether items are loaded asynchronously. |
| `inplaceAdd` | Whether the editor supports adding new items in place. |
| `dialogType` | Dialog type used for in-place add. |

The editor subscribes to lookup changes, so when the lookup script is reloaded, the editor updates its items automatically.

## ServiceLookupEditor

`ServiceLookupEditor` loads options from a service list endpoint instead of a lookup script. This is useful when the option list is too large or dynamic for a lookup script.

On the server side:

```cs
[ServiceLookupEditor(typeof(MyRow))]
public string SomeID { get; set; }
```

### ServiceLookupEditor Options

| Option | Description |
| --- | --- |
| `service` | Service endpoint to load items from. |
| `idField` | Id field name. |
| `textField` | Text field name. |
| `pageSize` | Page size for paged searches. |
| `sort` | Sort order for results. |
| `includeColumns` / `excludeColumns` | Columns to include/exclude. |
| `includeDeleted` | Whether to include deleted rows. |
| `containsField` | Field used for contains-text search. |
| `equalityFilter` | Equality filter applied to the request. |
| `criteria` | Criteria applied to the request. |

## Cascaded Editors

Lookup editors support cascading — a child editor filters its options based on the parent editor's value. This is done with the `cascadeFrom` and `cascadeField` options:

```cs
[LookupEditor(typeof(CityRow), CascadeFrom = "CountryID", CascadeField = "CountryId")]
public string CityID { get; set; }
```

- `cascadeFrom` — the id of the parent editor (e.g. `CountryID`).
- `cascadeField` — the field on the child's lookup items that must match the parent's value.

When the parent changes, the child editor reloads and filters its options to those matching the parent value.

The `CascadedWidgetLink` class implements this behavior — it links a child widget to a parent widget and reacts to the parent's changes.

See [How To: Setup Cascaded Editors](../howto/how_to_setup_cascaded_editors.md) for a full example.

## CheckLookupEditor

`CheckLookupEditor` renders a checkbox list from a lookup, for multi-select fields:

```cs
[CheckLookupEditor(typeof(MyRow))]
public List<int> MyIDs { get; set; }
```

## See Also

- [LookupEditor (API reference)](../api/js/corelib/classes/LookupEditor.md) — the lookup editor.
- [LookupEditorBase (API reference)](../api/js/corelib/classes/LookupEditorBase.md) — the lookup editor base class.
- [ServiceLookupEditor (API reference)](../api/js/corelib/classes/ServiceLookupEditor.md) — the service lookup editor.
- [ServiceLookupEditorBase (API reference)](../api/js/corelib/classes/ServiceLookupEditorBase.md) — the service lookup editor base class.
- [CheckLookupEditor (API reference)](../api/js/corelib/classes/CheckLookupEditor.md) — the checkbox lookup editor.
- [CascadedWidgetLink (API reference)](../api/js/corelib/classes/CascadedWidgetLink.md) — cascading implementation.
- [Lookup (API reference)](../api/js/corelib/classes/Lookup.md) — the lookup class.
- [Editors](readme.md) — the editor guide.
- [How To: Setup Cascaded Editors](../howto/how_to_setup_cascaded_editors.md) — cascading example.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.