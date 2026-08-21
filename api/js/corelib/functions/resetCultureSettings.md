[@serenity-is/corelib](../README.md) / resetCultureSettings

# Function: resetCultureSettings()

> **resetCultureSettings**(): `void`

Defined in: [src/base/formatting.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L121)

Resets [Culture](../variables/Culture.md) to its default values derived from [Invariant](../variables/Invariant.md).

## Returns

`void`

## Remarks

- Sets `dateOrder` to `"dmy"`, `dateFormat` to `"dd/MM/yyyy"`, and installs a `stringCompare` based on `String.prototype.localeCompare` with `document.documentElement.lang` when available.
- If a `<script id="ScriptCulture">` JSON block exists, its properties override the defaults (with special handling for `DecimalSeparator` / `GroupSeparator`).
- Exports in `vite8-symbol-typeinfo-workaround.md` note that no `Symbol.typeInfo` side-effects occur here.
