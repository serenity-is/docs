[@serenity-is/corelib](../README.md) / getRegisteredScriptNames

# Function: getRegisteredScriptNames()

> **getRegisteredScriptNames**(`prefix?`): `string`[]

Defined in: [src/base/scriptdata.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L53)

Gets the names of the dynamic scripts known to be registered server-side, e.g. Lookup.Northwind.Customer, which are the keys
of the RegisteredScripts script element, along with the ones registered by [setRegisteredScripts](setRegisteredScripts.md).

## Parameters

### prefix?

`string`

Only the names starting with it are returned, e.g. "Lookup." for the lookups.

## Returns

`string`[]

The names, in the order they were registered.
