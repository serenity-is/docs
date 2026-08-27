# PrefixedContext Class

`PrefixedContext` is a class in `@serenity-is/corelib` that provides a scoped context for resolving elements and widgets by an id prefix.

`PrefixedContext` is useful for panels and dialogs that need to look up their child elements and widgets by short, prefix-relative ids.

```ts
import { PrefixedContext } from "@serenity-is/corelib";

export class PrefixedContext {
    /** The id prefix used to resolve child element ids. */
    public readonly idPrefix: string;
    /** The DOM node that acts as the scope for lookups. */
    public readonly context: HTMLElement;

    constructor(prefixOrWidget: string | { idPrefix: string, domNode: HTMLElement }, context?: HTMLElement);
}
```

## Constructing a PrefixedContext

The constructor accepts either a plain id prefix string, or an object that exposes `idPrefix` and `domNode` (such as a widget), from which the prefix and context are derived.

```ts
// From a plain prefix string
const ctx = new PrefixedContext("MyDialog_");

// From a widget (uses the widget's idPrefix and domNode)
const ctx = new PrefixedContext(this);
```

When an object is passed, the `context` DOM node defaults to that object's `domNode`. An explicit `context` can also be supplied to scope lookups to a different node.

## Resolving Elements with *byId*

The `byId` method resolves an element by its prefix-relative id, returning a `Fluent` wrapper:

```ts
byId(id: string): Fluent;
```

```ts
const ctx = new PrefixedContext("MyDialog_");
ctx.byId("SomeInput").on("change", () => { /* ... */ });
```

This is equivalent to `Fluent(document.querySelector('#' + this.idPrefix + id))`.

## Resolving Widgets with *w*

The `w` method resolves a widget by its prefix-relative id and expected type, throwing if no matching widget is found:

```ts
w<TWidget>(id: string, type: { new(...args: any[]): TWidget }): TWidget;
```

```ts
const ctx = new PrefixedContext("MyDialog_");
const editor = ctx.w<MyEditor>("SomeEditor", MyEditor);
```

This is a shortcut for `getWidgetFrom('#' + this.idPrefix + id, type, this.context)`.

## The *initialize* Hook

Subclasses can override the protected `initialize` method to perform additional setup after the prefix and context are resolved:

```ts
export class MyDialogContext extends PrefixedContext {
    protected initialize() {
        // custom initialization
    }
}
```

## Relationship to Widgets

Widgets themselves expose similar helpers directly:

- `Widget.byId(id)` / `Widget.findById(id)` — resolve a child element by its prefix-relative id.
- `Widget.useIdPrefix()` — returns an `IdPrefixType` proxy for resolving prefix-relative ids.

`PrefixedContext` is the standalone, non-widget form of this pattern, typically used by generated form classes and dialogs that need to reach into their own subtree.

## See Also

- [Widget Class](widget_class.md)
