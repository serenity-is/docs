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

For a `[Flags]` enum, pass `enumFlags` so `Enum.toString` returns a named member, or the fewest members that make the value
(like .NET). Enum members can also declare `[IconClass]`, which the server emits as `enumIcons` and is exposed through
`Enum.getIconClass`.

A server-side `Serenity.StringEnum` (a class of string constants, stored as text) is generated as a const object plus a
union type and a `registerEnum` call, so `EnumEditor`, `EnumSelectFormatter` and `RadioButtonEditor` handle string values
instead of their old numeric-only workarounds.

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
- `ValidationRuleTypeRegistry` — looks up validation rule classes by key.

These are used internally by the `PropertyGrid`, grids, and dialogs to instantiate the right type for a given key.

### Lazy Loading Types

A type that is only referenced **by key** — for example the editor of a dynamically generated property item, a dialog
opened by name, or a custom validation rule — doesn't have to be imported by the code that uses it. Mark the class with the
`LazyLoadInclude` marker interface and code generation registers it, so the type is loaded when a registry first asks for
it:

```ts
export class MyCustomEditor extends Widget<MyCustomEditorOptions> implements LazyLoadInclude {
    static override [Symbol.typeInfo] = this.registerEditor("MyApp.MyCustomEditor");
}
```

- Each type gets its own chunk, unless a **group** name is given: `implements LazyLoadInclude<"NorthwindDialogs">` puts
  all the types of that group into a single chunk, so eight entity dialogs share one download.
- The generated `LazyTypeLoader.mts` uses **literal dynamic imports**, so bundlers can split the types into chunks.
- `LazyLoadTypesAttribute` (rendered by `@Html.LazyTypes()` in the layout head, which both templates have) declares the
  content-hashed module URLs and the type keys as JSON.
- `Config.lazyTypeLoader` is the default loader. It uses that JSON to import a module when a registry asks for a type, and
  can also answer availability checks without importing it. Override it if you serve chunks from elsewhere, wrapping the
  existing value.
- `QuickFilterBar` and `EditorFiltering` accept promise-like widget types with placeholders, preserving saved state, values
  and handlers until the real widget is ready, and `PropertyGrid.getEditorsLoading()` reports editors that are still
  loading.

## Legacy Decorators

The `@Decorators.*` decorators (`@Decorators.registerClass`, `@Decorators.registerEditor`, `@Decorators.registerFormatter`, `@Decorators.registerEnum`) are deprecated. Prefer the direct `[Symbol.typeInfo]` patterns above for new code. The decorators are kept for migration and legacy code.

## See Also

- [classTypeInfo](../../api/js/corelib/functions/classTypeInfo.md), [editorTypeInfo](../../api/js/corelib/functions/editorTypeInfo.md), [formatterTypeInfo](../../api/js/corelib/functions/formatterTypeInfo.md), [registerType](../../api/js/corelib/functions/registerType.md) — type info helpers.
- [LazyLoadInclude](../../api/js/corelib/interfaces/LazyLoadInclude.md), [Config](../../api/js/corelib/variables/Config.md) — lazy loading of types.
- [ValidationRule](../../api/js/corelib/classes/ValidationRule.md) — the base of the rule classes the forms check.
- [Widget](../../api/js/corelib/classes/Widget.md) — the `registerClass` / `registerEditor` static methods.
- [EditorTypeRegistry](../../api/js/corelib/variables/EditorTypeRegistry.md), [FormatterTypeRegistry](../../api/js/corelib/variables/FormatterTypeRegistry.md), [DialogTypeRegistry](../../api/js/corelib/variables/DialogTypeRegistry.md), [EnumTypeRegistry](../../api/js/corelib/variables/EnumTypeRegistry.md), [ValidationRuleTypeRegistry](../../api/js/corelib/variables/ValidationRuleTypeRegistry.md) — the registries.
- [Widgets](../../widgets/README.md) — the widget system.
- [Frontend Framework Overview](readme.md) — the three client-side packages and how they fit together.