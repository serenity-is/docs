[@serenity-is/corelib](../../../../README.md) / [TabsExtensions](../README.md) / initialize

# Function: initialize()

> **initialize**(`tabs`, `activeChange`): [`Fluent`](../../../../interfaces/Fluent.md)\<`HTMLElement`\>

Defined in: [src/ui/helpers/tabsextensions.tsx:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/tabsextensions.tsx#L200)

Initializes a tabs control, using jQuery UI tabs if available, otherwise
emulating them with Bootstrap.

## Parameters

### tabs

The tabs element (or array-like of elements).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### activeChange

() => `void`

Optional callback invoked when the active tab changes.

## Returns

[`Fluent`](../../../../interfaces/Fluent.md)\<`HTMLElement`\>

A Fluent wrapper around the tabs element, or null if invalid.
