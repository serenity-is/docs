[@serenity-is/corelib](../README.md) / initFullHeightGridPage

# ~~Function: initFullHeightGridPage()~~

> **initFullHeightGridPage**(`gridDiv`, `opt?`): `void`

Defined in: [src/compat/layout.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L109)

Configures a full-height page layout for a grid or panel container.
Compat shim for the legacy `Q.initFullHeightGridPage`. Adds `full-height-page` / `responsive-height` classes, wires resize or `layout` events, and optionally resolves the hash router.

## Parameters

### gridDiv

Target container: an HTMLElement, array-like collection, or an object with a `domNode` property.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\> | \{ `domNode`: `HTMLElement`; \}

### opt?

Layout options.

#### noRoute?

`boolean`

When `true`, skips the one-time [Router](../variables/Router.md).`resolve()` call on initial page load. Defaults to `false`.

#### setHeight?

`boolean`

When `true` forces height filling via [layoutFillHeight](layoutFillHeight.md); when `false` disables it; when omitted auto-detects via jQuery and element classes. Defaults to auto.

## Returns

`void`

## Deprecated

Prefer CSS flex / grid layouts or `Fluent` responsive utilities. Kept for legacy full-height pages.
