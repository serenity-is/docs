[@serenity-is/corelib](../README.md) / GridPageInit

# ~~Function: GridPageInit()~~

> **GridPageInit**\<`TGrid`, `P`\>(`type`): `HTMLElement`

Defined in: [src/compat/layout.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L46)

Initializes a full-height grid page from a widget class and props object.
Compat shim for the legacy `GridPageInit` global; wraps initWidgetPage with `#GridDiv` as the default container.

## Type Parameters

### TGrid

`TGrid` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

### P

`P`

## Parameters

### type

The widget class to instantiate.

#### props?

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### type

\{(`options?`): `TGrid`; `prototype`: `TGrid`; \}

#### type.prototype

`TGrid`

## Returns

`HTMLElement`

The root HTMLElement (`domNode`) of the initialized grid widget.

## Deprecated

Prefer calling `initWidgetPage` / `gridPageInit` directly or using the modern `Fluent` / widget APIs. Kept for backward compatibility with pre-corelib page scripts.
