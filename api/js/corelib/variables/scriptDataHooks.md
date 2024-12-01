[@serenity-is/corelib](../README.md) / scriptDataHooks

# Variable: scriptDataHooks

> `const` **scriptDataHooks**: `object`

Hook for script data related operations

## Type declaration

### fetchScriptData()

> **fetchScriptData**: \<`TData`\>(`name`, `sync`?, `dynJS`?) => `TData` \| `Promise`\<`TData`\>

Provides a hook to override the default fetchScriptData implementation,
it falls back to the default implementation if undefined is returned.
It is recommended to use this hook mainly for test purposes.
If the sync parameter is true (legacy/compat), then the result should be returned synchronously.
DynJS parameter is true if the script is requested to be loaded via a dynamic script,
and not a JSON request. This parameter is only true for the legacy/compat sync mode.

#### Type Parameters

• **TData**

#### Parameters

##### name

`string`

##### sync?

`boolean`

##### dynJS?

`boolean`

#### Returns

`TData` \| `Promise`\<`TData`\>

## Defined in

[src/base/scriptdata.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L50)
