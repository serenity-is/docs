[@serenity-is/corelib](../README.md) / fetchScriptData

# Function: fetchScriptData()

> **fetchScriptData**\<`TData`\>(`name`): `Promise`\<`TData`\>

Defined in: [src/base/scriptdata.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L74)

Fetches a dynamic script payload by name via the `~/DynamicData/` endpoint.
Results are de-duplicated per `name + hash` while a request is in flight and the request
participates in global AJAX / block-UI tracking. Lookup payloads are wrapped as [Lookup](../classes/Lookup.md) instances.

## Type Parameters

### TData

`TData`

Expected shape of the returned payload.

## Parameters

### name

`string`

Dynamic script name (e.g. `"Lookup.Administration.User"`, `"Form.MyForm"`, `"RemoteData.MyData"`).

## Returns

`Promise`\<`TData`\>

A promise that resolves with the parsed payload, or rejects if fetch is unavailable or the HTTP request fails.
