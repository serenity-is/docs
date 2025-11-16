[serenity-is/corelib](../README.md) / parseQueryString

# Function: parseQueryString()

> **parseQueryString**(`s?`): `Record`\<`string`, `string`\>

Defined in: [src/base/html.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L172)

Parses a query string into an object.

## Parameters

### s?

`string`

Query string to parse, if not specified, location.search will be used.

## Returns

`Record`\<`string`, `string`\>

An object with key/value pairs from the query string.
