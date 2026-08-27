# Widgets

Serenity's Script UI layer is built on a component system centered around the `Widget` base class from `@serenity-is/corelib`. A widget wraps a DOM node, extends it with behaviour, manages its lifecycle (create/destroy), and associates itself with its element so it can be looked up later.

The implementation lives in `@serenity-is/corelib` under `src/ui/widgets/` (`widget.ts`, `widgetutils.ts`, `prefixedcontext.ts`).

A widget is an object that is attached to an HTML element and extends it with some behaviour.

For example, the `IntegerEditor` widget, when attached to an `INPUT` element, makes it easier to enter numbers in the input and validates that the entered number is a correct integer.

Similarly, a `Toolbar` widget, when attached to a `DIV` element, turns it into a toolbar with tool buttons (in this case, the `DIV` acts as a placeholder).

## Topics

- [Widget Class](widget_class.md) — the `Widget` base class, its lifecycle, CSS classes, how to retrieve widgets from elements, and the generic `Widget<P>` options class.
- [PrefixedContext Class](prefixedcontext_class.md) — the `PrefixedContext` helper for resolving child elements and widgets by an id prefix.

## Where the code lives

The widget system is implemented in the `@serenity-is/corelib` package:

- `src/ui/widgets/widget.ts` — the `Widget<P>` base class and `Widget.create`.
- `src/ui/widgets/widgetutils.ts` — `getWidgetFrom`, `tryGetWidget`, `associateWidget`, `getWidgetName`, `useIdPrefix`, and the `WidgetProps` type.
- `src/ui/widgets/widgetinternal.ts` — internal helpers for element resolution and prop handling.
- `src/ui/widgets/prefixedcontext.ts` — the `PrefixedContext` class.
