[@serenity-is/corelib](../README.md) / jQueryPatch

# Function: jQueryPatch()

> **jQueryPatch**(): `boolean`

Defined in: [src/compat/jquery-compat.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/jquery-compat.ts#L101)

Applies legacy jQuery compatibility patches to the globally registered jQuery instance.

Patches applied (when applicable):
- **jQuery UI Dialog fixes** — allows interaction with overlays such as dropdowns,
  datepickers, Select2, CKEditor and modals; suppresses tabbable focusing in mobile
  view; injects a FontAwesome close icon into the title bar.
- **cleanData patch** — invokes [invokeDisposingListeners](invokeDisposingListeners.md) and any `disposing`
  event handlers before the original `$.cleanData`, then polyfills `$.toJSON` /
  `$.parseJSON` when missing.
- **CSRF token hook** — registers a global `beforeSend` via `$.ajaxSetup` that
  attaches the `CSRF-TOKEN` cookie as `X-CSRF-TOKEN` on same-origin requests.

This is a compatibility shim for legacy pages that still load jQuery / jQuery UI.
New code should avoid a jQuery dependency.

## Returns

`boolean`

`true` if a jQuery instance was found and patches were applied; `false` if no jQuery is registered.
