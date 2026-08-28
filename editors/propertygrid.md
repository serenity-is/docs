# PropertyGrid and Forms

`PropertyGrid` is the widget that builds a form from `PropertyItem` metadata. It renders each property as a labeled field with an editor, and handles loading values into editors and saving edited values back into an entity.

Forms in Serenity are defined declaratively on the server side with a **form class** (see [Forms & Editors](../framework/forms-editors.md)). The generated form script produces a `PropertyItem[]` array, which the client loads and passes to the `PropertyGrid`.

## How the PropertyGrid Works

The `PropertyGrid`:

1. Receives a list of `PropertyItem`s (from the form script).
2. Renders them into categories (or tabs, when items have a `tab`).
3. For each property, creates the editor specified by `editorType` (looked up in the `EditorTypeRegistry`), applies `editorParams`, and renders a caption label.
4. Loads entity values into the editors via `load()`.
5. Collects edited values back into an entity via `save()`.

## PropertyGridMode

The grid runs in one of two modes:

```ts
enum PropertyGridMode {
    insert = 1,  // used for inserting a new record
    update = 2   // used for updating an existing record
}
```

The mode affects which fields are editable (insert-only vs update-only fields, permissions, etc.).

## Loading and Saving Values

```ts
// Load values from an entity into the editors
propertyGrid.load(entity);

// Collect edited values into a new object
const values = propertyGrid.save();

// The value property is a shortcut for load/save
propertyGrid.value = entity;   // load
const values = propertyGrid.value; // save
```

## PropertyPanel

`PropertyPanel` is a panel that hosts a `PropertyGrid` for editing an entity. It derives the form key from the panel's type name, builds the `PropertyGridOptions`, and loads the initial (empty) entity:

```ts
protected getPropertyGridOptions(): PropertyGridOptions {
    return {
        idPrefix: this.idPrefix,
        items: this.getPropertyItems(),
        mode: PropertyGridMode.insert,
        localTextPrefix: 'Forms.' + this.getFormKey() + '.'
    };
}
```

## PropertyGridOptions

| Option | Description |
| --- | --- |
| `idPrefix` | Id prefix used for field element ids. |
| `items` | The `PropertyItem[]` to render. |
| `mode` | `PropertyGridMode.insert` or `PropertyGridMode.update`. |
| `localTextPrefix` | Prefix used to resolve localized titles/hints. |
| `value` | Initial value to load into the editors. |

## Accessing Editors

Each rendered field element carries its editor widget and property item:

```ts
interface PropertyFieldElement extends HTMLElement {
    editorWidget?: Widget<any>;
    editorPromise?: PromiseLike<void>;
    propertyItem?: PropertyItem;
}
```

You can access an editor through the form (a `PrefixedContext`) or by id:

```ts
// Through a generated form class
const editor = this.form.SomeField;

// Through the property grid
const fieldElement = propertyGrid.getFieldElement("SomeField");
const editor = fieldElement.editorWidget;
```

## See Also

- [PropertyGrid (API reference)](../api/js/corelib/classes/PropertyGrid.md) — the full `PropertyGrid` API.
- [PropertyPanel (API reference)](../api/js/corelib/classes/PropertyPanel.md) — the panel that hosts a property grid.
- [PropertyItem (API reference)](../api/js/corelib/interfaces/PropertyItem.md) — the metadata for a form field.
- [Forms & Editors](../framework/forms-editors.md) — defining forms on the server side.
- [Editors](readme.md) — the editor guide.
- [Custom Editors](custom-editors.md) — creating custom editors.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.