[@serenity-is/corelib](../README.md) / panelPageInit

# Function: panelPageInit()

## Call Signature

> **panelPageInit**\<`TGrid`, `P`\>(`panel`): `TGrid`

Defined in: [src/compat/layout.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L88)

Initializes a Serenity panel page without hash-router integration.
Compat shim for the legacy `Q.panelPageInit` / `Serenity.panelPageInit` API. Accepts either an existing panel instance or a widget class + props.

### Type Parameters

#### TGrid

`TGrid` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

#### P

`P`

### Parameters

#### panel

`TGrid` & `object`

An existing panel widget instance (must expose `domNode`).

### Returns

`TGrid`

The same panel widget after layout initialization (`noRoute: true`).

### Deprecated

Use direct widget construction with [initFullHeightGridPage](initFullHeightGridPage.md). Kept for legacy compatibility.

## Call Signature

> **panelPageInit**\<`TGrid`, `P`\>(`type`, `props?`): `TGrid`

Defined in: [src/compat/layout.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L95)

Initializes a Serenity panel page without hash-router integration.

### Type Parameters

#### TGrid

`TGrid` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

#### P

`P`

### Parameters

#### type

\{(`options?`): `TGrid`; `prototype`: `TGrid`; \}

Panel widget class to instantiate.

##### prototype

`TGrid`

#### props?

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Optional widget properties.

### Returns

`TGrid`

The newly created and initialized panel widget.
