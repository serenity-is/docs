[corelib](../README.md) / Culture

# Variable: Culture

> **Culture**: [`Locale`](../interfaces/Locale.md)

Defined in: [src/base/formatting.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L95)

Current culture, e.g. CultureInfo.CurrentCulture. This is overridden by
settings passed from a `<script>` element in the page with id `ScriptCulture`
containing a JSON object if available. This element is generally created in 
the _LayoutHead.cshtml file for Serenity applications, so that the culture
settings determined server, can be passed to the client.
