[@serenity-is/corelib](../../../README.md) / ScriptData

# ~~ScriptData~~

Legacy `ScriptData` namespace compat shim.
Wraps the modern `../base` script-data APIs (`getScriptData`, `setScriptData`, `ensureScriptDataSync`, etc.)
under the old `Q.ScriptData` / `Serenity.ScriptData` surface. All members delegate to the new APIs.

## Deprecated

Prefer importing `getScriptData`, `setScriptData`, `ensureScriptDataSync`, `peekScriptData`, etc. directly from `@serenity-is/corelib`. Kept for backward compatibility.

## Variables

- [~~canLoad~~](variables/canLoad.md)
- [~~ensure~~](variables/ensure.md)
- [~~set~~](variables/set.md)

## Functions

- [~~bindToChange~~](functions/bindToChange.md)
- [~~reload~~](functions/reload.md)
- [~~reloadAsync~~](functions/reloadAsync.md)
