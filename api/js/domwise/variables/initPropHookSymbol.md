[@serenity-is/domwise](../README.md) / initPropHookSymbol

# Variable: initPropHookSymbol

> `const` **initPropHookSymbol**: unique `symbol`

Defined in: [src/prop-hook.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/prop-hook.ts#L10)

Well-known symbol (`Symbol.for("Serenity.initPropHook")`) that marks a value
as a JSX prop hook.

When a prop value that carries this symbol is assigned as a JSX attribute,
the renderer invokes `value[initPropHookSymbol](node, propName)` to let the
hook bind itself to the DOM node (e.g. to observe signals or install
class-list synchronization). See also the [PropHook](../interfaces/PropHook.md) interface.
