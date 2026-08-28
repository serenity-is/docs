# Type Registration

Serenity's client-side framework looks up types by key at runtime. For example, the `PropertyGrid` creates an editor for a form field by looking up the editor type registered under the editor's key, and grids look up formatters and dialogs by key. For this to work, every widget, editor, dialog, grid, formatter, and enum must be registered.

Registration is done through a static `[Symbol.typeInfo]` property on the class, which carries the type's fully-qualified name (and optionally interfaces and attributes). The type registries scan these declarations to build their lookup tables.

## The Symbol.typeInfo Property

Every registered type declares a static `[Symbol.typeInfo]` property. The value is created by one of the type info helper functions, and the type is registered with `registerType`:

```ts
static [Symbol.typeInfo] = classTypeInfo("MyApp.MyClass");
static { registerType(this); }
```

For classes that derive from `Widget` (widgets, editors, dialogs, grids), the base class provides `registerClass` and `registerEditor` static methods that both create the type info and register the type:

```ts
static override [Symbol.typeInfo] = this.registerClass("MyApp.MyDialog");
```

## Registering Classes

Dialogs, grids, panels, and other widgets register with `registerClass`:

```ts
export class MyDialog extends EntityDialog<MyRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("MyApp.MyDialog");
}
```

This is the pattern used by generated Serene/StartSharp code. For example, `RoleDialog.tsx`:

```ts
export class RoleDialog extends EntityDialog<RoleRow, any> {
    static override[Symbol.typeInfo] = this.registerClass(nsAdministration);
    // ...
}
```

The `nsAdministration` constant is a namespace string (e.g. `"StartSharp.Administration."`) generated in `ServerTypes/Namespaces.ts`.

## Registering Editors

Editors register with `registerEditor`, which also adds the `EditorAttribute` so the type is recognized as an editor:

```ts
export class MyEditor extends Widget<MyEditorOptions> {
    static override [Symbol.typeInfo] = this.registerEditor("MyApp.MyEditor");
}
```

Editors can declare the value interfaces they implement, which the `PropertyGrid` uses to interact with them:

```ts
export class PermissionCheckEditor extends DataGrid<PermissionCheckItem, PermissionCheckEditorOptions> {
    static override[Symbol.typeInfo] = this.registerEditor(nsAdministration, [IGetEditValue, ISetEditValue]);
    // ...
}
```

## Registering Formatters

Formatters do not derive from `Widget`, so they use `formatterTypeInfo` directly and register with `registerType`:

```ts
export class MyFormatter implements ISlickFormatter {
    static [Symbol.typeInfo] = formatterTypeInfo("MyApp.MyFormatter");
    static { registerType(this); }

    format(ctx: FormatterContext) {
        // ...
    }
}
```

`formatterTypeInfo` automatically includes the `ISlickFormatter` interface.

## Registering Enums

Enums register with the standalone `registerEnum` function:

```ts
import { registerEnum } from "@serenity-is/corelib";

registerEnum(MyEnum, "MyApp.MyEnum");
```

## Interfaces

Interfaces that need to be discoverable (for example, value interfaces like `IGetEditValue`) declare `interfaceTypeInfo`:

```ts
static [Symbol.typeInfo] = interfaceTypeInfo("Serenity.IGetEditValue");
```

## The Type Registries

Registered types are available through the singleton registries:

- `EditorTypeRegistry` — looks up editors by key.
- `FormatterTypeRegistry` — looks up formatters by key.
- `DialogTypeRegistry` — looks up dialogs by key.
- `EnumTypeRegistry` — looks up enums by key.

These are used internally by the `PropertyGrid`, grids, and dialogs to instantiate the right type for a given key.

## Legacy Decorators

The `@Decorators.*` decorators (`@Decorators.registerClass`, `@Decorators.registerEditor`, `@Decorators.registerFormatter`, `@Decorators.registerEnum`) are deprecated. Prefer the direct `[Symbol.typeInfo]` patterns above for new code. The decorators are kept for migration and legacy code.

## See Also

- [classTypeInfo](../../api/js/corelib/functions/classTypeInfo.md), [editorTypeInfo](../../api/js/corelib/functions/editorTypeInfo.md), [formatterTypeInfo](../../api/js/corelib/functions/formatterTypeInfo.md), [registerType](../../api/js/corelib/functions/registerType.md) — type info helpers.
- [Widget](../../api/js/corelib/classes/Widget.md) — the `registerClass` / `registerEditor` static methods.
- [EditorTypeRegistry](../../api/js/corelib/variables/EditorTypeRegistry.md), [FormatterTypeRegistry](../../api/js/corelib/variables/FormatterTypeRegistry.md), [DialogTypeRegistry](../../api/js/corelib/variables/DialogTypeRegistry.md), [EnumTypeRegistry](../../api/js/corelib/variables/EnumTypeRegistry.md) — the registries.
- [Widgets](../../widgets/README.md) — the widget system.
- [Frontend Framework Overview](readme.md) — the three client-side packages and how they fit together.