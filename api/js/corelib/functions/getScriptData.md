[@serenity-is/corelib](../README.md) / getScriptData

# Function: getScriptData()

> **getScriptData**\<`TData`\>(`name`, `reload?`): `Promise`\<`TData`\>

Defined in: [src/base/scriptdata.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L135)

Returns the script data from cache if available, or via a fetch
request to ~/DynamicData endpoint

## Type Parameters

### TData

`TData` = `any`

## Parameters

### name

`string`

### reload?

`boolean`

Clear cache and force reload

## Returns

`Promise`\<`TData`\>
