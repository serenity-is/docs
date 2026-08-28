# Frontend Patterns Cookbook

This page collects complete, working examples of common frontend patterns in Serene/StartSharp applications. Each example is based on real template code.

## An EntityGrid

A typical generated grid extends `EntityGrid` and wires up its columns, dialog, row, and service:

```ts
import { EntityGrid } from "@serenity-is/corelib";
import { RoleColumns, RoleRow, RoleService } from "../../ServerTypes/Administration";
import { RoleDialog } from "./RoleDialog";

export class RoleGrid extends EntityGrid<RoleRow> {
    static override[Symbol.typeInfo] = this.registerClass(nsAdministration);

    protected override getColumnsKey() { return RoleColumns.columnsKey; }
    protected override getDialogType() { return RoleDialog; }
    protected override getRowDefinition() { return RoleRow; }
    protected override getService() { return RoleService.baseUrl; }
}
```

See [Creating and Configuring Grids](../grids/creating-grids.md) and [EntityGrid CRUD](../grids/entitygrid-crud.md).

## An EntityDialog with Lookups

A typical generated dialog extends `EntityDialog` and wires up its form, row, and service:

```ts
import { EntityDialog } from "@serenity-is/corelib";
import { LanguageForm, LanguageRow, LanguageService } from "../../ServerTypes/Administration";

export class LanguageDialog<P = {}> extends EntityDialog<LanguageRow, P> {
    static override[Symbol.typeInfo] = this.registerClass(nsAdministration);

    protected override getFormKey() { return LanguageForm.formKey; }
    protected override getRowDefinition() { return LanguageRow; }
    protected override getService() { return LanguageService.baseUrl; }
}
```

The form uses lookup editors for foreign keys. For example, the generated `UserForm` declares a `Roles` lookup editor:

```ts
export interface UserForm {
    Roles: LookupEditor;
    // ...
}
```

See [EntityDialog and CRUD Workflows](../dialogs/entitydialog.md) and [Lookup Editors](../editors/lookup-editors.md).

## A Custom Widget

A custom widget extends `Widget`, registers with `registerClass`, and overrides `renderContents()`:

```ts
import { Widget } from "@serenity-is/corelib";

export class MyCoolWidget extends Widget {
    static override[Symbol.typeInfo] = this.registerClass("MyApp.MyCoolWidget");

    constructor(props: { element: HTMLElement }) {
        super(props);

        this.element.on("click", () => {
            this.element.addClass("clicked");
        });
    }
}
```

See [Widget Class](../widgets/widget_class.md).

## A Custom Component (JSX)

A function component is a plain function that returns JSX, using signals for state:

```tsx
import { signal } from "@serenity-is/corelib";

function Counter() {
    const count = signal(0);
    return (
        <div>
            <span>Count: {count}</span>
            <button onClick={() => count.value++}>Increment</button>
        </div>
    );
}
```

See [Components and Hooks](../framework/ui/components.md) and [JSX with DomWise](../framework/ui/jsx.md).

## A Custom Editor

A custom editor extends `Widget`, implements value interfaces, and registers with `registerEditor`:

```ts
import { EditorProps, IDoubleValue, IReadOnly, Widget } from "@serenity-is/corelib";

export interface MyEditorOptions {
    // options
}

export class MyEditor<P extends MyEditorOptions = MyEditorOptions>
    extends Widget<P> implements IReadOnly {

    static override[Symbol.typeInfo] = this.registerEditor("MyApp.MyEditor", [IDoubleValue, IReadOnly]);

    get_value(): number {
        // read the value
        return 0;
    }

    set_value(value: number): void {
        // set the value
    }
}
```

See [Custom Editors](../editors/custom-editors.md).

## A Custom Formatter

A custom formatter implements `Formatter` and registers with `formatterTypeInfo`:

```ts
import { FormatterContext, FormatterResult } from "@serenity-is/sleekgrid";
import { formatterTypeInfo, registerType } from "@serenity-is/corelib";

export class MyFormatter implements Formatter {
    static [Symbol.typeInfo] = formatterTypeInfo("MyApp.MyFormatter");
    static { registerType(this); }

    format(ctx: FormatterContext): FormatterResult {
        return ctx.value ? "Yes" : "No";
    }
}
```

See [Formatter Types](../grids/formatter_types.md).

## Dependent Fields (Cascaded Editors)

To make one editor depend on another (e.g. City depends on Country), use the `cascadeFrom` and `cascadeField` options on the server side:

```cs
[LookupEditor(typeof(CityRow), CascadeFrom = "CountryID", CascadeField = "CountryId")]
public string CityID { get; set; }
```

When the parent (`CountryID`) changes, the child (`CityID`) reloads and filters its options to those matching the parent value.

See [Lookup Editors](../editors/lookup-editors.md) and [How To: Setup Cascaded Editors](how_to_setup_cascaded_editors.md).

## Calling a Service

Generated service clients provide type-safe methods:

```ts
import { LanguageService } from "./ServerTypes/Administration";

const response = await LanguageService.List({});
const row = await LanguageService.Retrieve({ EntityId: 123 });
await LanguageService.Create({ Entity: { LanguageName: "English" } });
```

See [Type-Safe Service Calls](../framework/service-calls.md).

## See Also

- [Frontend Troubleshooting](frontend-troubleshooting.md) — common issues and fixes.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.