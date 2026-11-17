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

## Conditional Fields

A form field can be shown, made read only or made required by the value of another field. Nothing is done on the
client side: the conditions are declared on the server with `[VisibleWhen]`, `[ReadOnlyWhen]` and `[RequiredWhen]` (see
[Forms & Editors](../framework/forms-editors.md#conditional-fields)) and arrive as `PropertyItem.visibleWhen`,
`readOnlyWhen` and `requiredWhen`:

```ts
interface PropertyCondition {
    field: string;      // the field whose value is checked
    values?: any[];     // the values that meet it; none means "has a value" (a checkbox: "checked")
    isNot?: boolean;    // the opposite
}
```

The grid evaluates the conditions when values **load and change** (not on every keystroke), updating field visibility,
the read-only state and the required state. A condition only hides a field — a field hidden by `[Visible]`, a permission or
the insert/update mode stays hidden — and a category or a tab whose fields are all hidden is hidden as well. A field hidden
by a condition is not validated and keeps its value, unless `clearWhenHidden` is set, in which case its value is saved as
empty so stale values don't come back when it is shown again. The current state of a field is available from
`PropertyFieldConditionState` (`hidden`, `readOnly`, `required`).

## Validation Rules

`PropertyItem.validationRules` carries the rules the server declared for the field (`ValidateRange`, `ValidateLength`, a
custom `ValidationRuleAttribute`, ...). The grid attaches them to the editor, so they run with the browser's own
validation instead of only on the server:

- The rule class is found by its key in `ValidationRuleTypeRegistry` (or in the rules registered by
  `registerValidationRule(name, checkFn, options)`), and loaded on demand if it implements `LazyLoadInclude`.
- The rules are attached to the editor with `Validator.addCustomRule`, so they run with the rest of the field's
  validation (before submit) and their messages use the local text key or message the server sent.
- Read-only and hidden fields are skipped, exactly like the browser's own validation.
- An empty value is always valid; being required is a separate rule.

The client rule classes derive from `ValidationRule` and implement `check(value, params, context)`; a custom one is
usually added next to the form, or registered with `registerValidationRule` when a class is not worth it. See
[Validation](../services/validation.md#unified-validation-rules) for the server side.

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

### Waiting for lazily loaded editors

An editor that is only referenced by key (see [Lazy Loading Types](../framework/ui/type-registration.md#lazy-loading-types))
is created asynchronously, so it can't save its value until its widget exists. `getEditorsLoading()` returns a promise for
the editors of the form that are still loading, or `null` when none are, so a caller can wait before saving:

```ts
const pending = propertyGrid.getEditorsLoading();
if (pending)
    await pending;
const values = propertyGrid.save();
```

## See Also

- [PropertyGrid (API reference)](../api/js/corelib/classes/PropertyGrid.md) — the full `PropertyGrid` API.
- [PropertyPanel (API reference)](../api/js/corelib/classes/PropertyPanel.md) — the panel that hosts a property grid.
- [PropertyItem (API reference)](../api/js/corelib/interfaces/PropertyItem.md) — the metadata for a form field.
- [Forms & Editors](../framework/forms-editors.md) — defining forms on the server side.
- [Editors](readme.md) — the editor guide.
- [Validation](../services/validation.md) — the rules the forms and the server share.
- [Custom Editors](custom-editors.md) — creating custom editors.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.