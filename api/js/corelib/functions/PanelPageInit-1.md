[@serenity-is/corelib](../README.md) / PanelPageInit

# ~~Function: PanelPageInit()~~

> **PanelPageInit**\<`TPanel`, `P`\>(`type`): `HTMLElement`

Defined in: [src/compat/layout.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L58)

Initializes a full-height panel page from a widget class and props object.
Compat shim for the legacy `PanelPageInit` global; wraps initWidgetPage with `#Panel` as the default container.

## Type Parameters

### TPanel

`TPanel` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

### P

`P`

## Parameters

### type

The panel widget class to instantiate.

#### props?

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### type

\{(`options?`): `TPanel`; `prototype`: `TPanel`; \}

#### type.prototype

`TPanel`

## Returns

`HTMLElement`

The root HTMLElement of the initialized panel widget.

## Deprecated

Prefer `panelPageInit` or direct widget construction. Kept for backward compatibility.
