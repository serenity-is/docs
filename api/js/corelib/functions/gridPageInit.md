[@serenity-is/corelib](../README.md) / gridPageInit

# Function: gridPageInit()

## Call Signature

> **gridPageInit**\<`TGrid`, `P`\>(`grid`): `TGrid`

Defined in: [src/compat/layout.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L69)

Initializes a Serenity grid page that fills the available viewport height.
Compat shim for the legacy `Q.gridPageInit` / `Serenity.gridPageInit` API. Accepts either an existing widget instance or a widget class + props.

### Type Parameters

#### TGrid

`TGrid` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

#### P

`P`

### Parameters

#### grid

`TGrid` & `object`

An existing grid widget instance (must expose `domNode`).

### Returns

`TGrid`

The same grid widget after full-height layout initialization.

### Deprecated

Use widget construction with [initFullHeightGridPage](initFullHeightGridPage.md) or modern layout components. Kept for legacy page scripts.

## Call Signature

> **gridPageInit**\<`TGrid`, `P`\>(`type`, `props?`): `TGrid`

Defined in: [src/compat/layout.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L76)

Initializes a Serenity grid page that fills the available viewport height.

### Type Parameters

#### TGrid

`TGrid` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

#### P

`P`

### Parameters

#### type

\{(`options?`): `TGrid`; `prototype`: `TGrid`; \}

Grid widget class to instantiate.

##### prototype

`TGrid`

#### props?

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Optional widget properties (supports `element` as selector or callback).

### Returns

`TGrid`

The newly created and initialized grid widget.
