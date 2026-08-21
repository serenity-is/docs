[@serenity-is/corelib](../README.md) / scriptDataHooks

# Variable: scriptDataHooks

> `const` **scriptDataHooks**: `object`

Defined in: [src/base/scriptdata.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L52)

Global hooks for script-data loading.
Allows tests or custom bootstrapping to intercept `fetchScriptData` / `ensureScriptDataSync`.
When the hook returns `undefined` the default `fetch` / XHR implementation is used.

## Type Declaration

### fetchScriptData()

> **fetchScriptData**: \<`TData`\>(`name`, `sync?`, `dynJS?`) => `TData` \| `Promise`\<`TData`\>

Override for script-data fetching.
Return a value / promise to short-circuit the default loader, or `undefined` to fall back.

#### Type Parameters

##### TData

`TData`

#### Parameters

##### name

`string`

Dynamic script name (e.g. `"Lookup.MyLookup"`, `"Form.MyForm"`).

##### sync?

`boolean`

When true the caller expects a synchronous result (legacy compat path). The hook must return data directly, not a promise.

##### dynJS?

`boolean`

When true the script was requested as a legacy `DynJS.axd` JavaScript payload rather than JSON. Only relevant when `sync` is true.

#### Returns

`TData` \| `Promise`\<`TData`\>

The script data directly (sync) or a promise of it, or `undefined` to use the default fetch.
