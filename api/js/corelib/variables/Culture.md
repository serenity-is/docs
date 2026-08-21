[@serenity-is/corelib](../README.md) / Culture

# Variable: Culture

> **Culture**: [`Locale`](../interfaces/Locale.md)

Defined in: [src/base/formatting.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L112)

Current culture used by all formatting and parsing helpers, analogous to `CultureInfo.CurrentCulture`.

## Remarks

Initialized by [resetCultureSettings](../functions/resetCultureSettings.md). When a `<script id="ScriptCulture">` element containing a JSON object is present (rendered by `_LayoutHead.cshtml`), its values override the defaults. The `DecimalSeparator` / `GroupSeparator` keys are mapped explicitly; remaining keys are camel-cased from PascalCase.
