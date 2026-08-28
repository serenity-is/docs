# Custom Editors and Validation

This page covers creating custom editors and adding validation rules.

## Creating a Custom Editor

A custom editor is a `Widget` (or `EditorWidget`) that implements the value interfaces the form needs, and registers with `registerEditor`.

### A Simple Custom Editor

Here is a real example from the Advanced Samples — an `EnumFlagsEditor` that edits an enum-flags value as checkboxes:

```ts
export interface EnumFlagsEditorOptions {
    enumKey?: string;
}

export class EnumFlagsEditor<P extends EnumFlagsEditorOptions = EnumFlagsEditorOptions>
    extends Widget<P> implements IReadOnly {

    static override[Symbol.typeInfo] = this.registerEditor(nsDemoAdvancedSamples, [IDoubleValue, IReadOnly]);
    static override createDefaultElement() { return document.createElement("div"); }

    declare private flagValues: number[];

    constructor(props: EditorProps<P>) {
        super(props);

        this.flagValues = [];

        if (!this.options.enumKey)
            return;

        const enumType = EnumTypeRegistry.get(this.options.enumKey);
        const values = Enum.getValues(enumType);
        for (const x of values) {
            this.flagValues.push(toId(x));
            const name = Enum.toString(enumType, x);
            this.addCheckBox(x.toString(), localText('Enums.' + enumKey + '.' + name, name));
        }
    }

    protected addCheckBox(value: string, text: string) {
        this.element.append(<label>
            <input id={this.idPrefix + value} type="checkbox" value={value} />{text}
        </label>)
    }

    get_value(): number {
        let sum = 0;
        this.element.findEach<HTMLInputElement>("input:checked", x => sum += toId(x.val()));
        return sum;
    }

    set_value(value: number): void {
        // ...
    }
}
```

Key points:

- **Register with `registerEditor`** — `static override [Symbol.typeInfo] = this.registerEditor("MyApp.MyEditor", [interfaces])`.
- **Declare value interfaces** — `IDoubleValue` (with `get_value`/`set_value`), `IStringValue`, `IGetEditValue`/`ISetEditValue`, `IReadOnly`, etc. The `PropertyGrid` uses these to load/save values.
- **Create the element** — override `createDefaultElement()` or use the `element` prop.
- **Use `EditorProps`** — for `initialValue`, `maxLength`, `placeholder`, `required`, `readOnly`.

### Using the Editor in a Form

On the server side, use a `[CustomEditor]` attribute with the editor's key:

```cs
[CustomEditor("MyApp.MyEditor")]
public int MyValue { get; set; }
```

Or, if the editor has options, use a custom editor attribute that sets them.

## Validation

Serenity uses a `Validator` (inspired by jQuery Validation) to validate forms. Validation rules are attached to elements and run when the form is submitted.

### Adding a Validation Rule

The `Widget` base class provides `addValidationRule`:

```ts
this.addValidationRule((input) => {
    if (input.value === "bad")
        return "This value is not allowed";
    return null; // valid
});
```

A rule returns:

- `null` / empty string — the value is valid.
- A non-empty string — the value is invalid, and the string is the error message.
- A `Promise` — for async validation.

### Validation in EntityDialog

`EntityDialog` validates the form before saving via `validateBeforeSave()`:

```ts
protected override validateBeforeSave() {
    // custom validation
    if (this.form.SomeField.value === "bad")
        return false;
    return super.validateBeforeSave();
}
```

### The Validator Class

The `Validator` class manages validation rules and error display. It is created by dialogs and panels for the form. You can access it via the dialog's `validator` property.

## See Also

- [Widget (API reference)](../api/js/corelib/classes/Widget.md) — the `addValidationRule` method.
- [Validator (API reference)](../api/js/corelib/classes/Validator.md) — the validation engine.
- [EditorWidget (API reference)](../api/js/corelib/classes/EditorWidget.md) — the editor base class.
- [IDoubleValue](../api/js/corelib/classes/IDoubleValue.md), [IStringValue](../api/js/corelib/classes/IStringValue.md), [IGetEditValue](../api/js/corelib/classes/IGetEditValue.md), [ISetEditValue](../api/js/corelib/classes/ISetEditValue.md) — value interfaces.
- [Type Registration](../framework/ui/type-registration.md) — registering editor types.
- [Editors](readme.md) — the editor guide.
- [PropertyGrid and Forms](propertygrid.md) — how forms use editors.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.