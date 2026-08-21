[@serenity-is/corelib](../README.md) / parseQueryString

# Function: parseQueryString()

> **parseQueryString**(`s?`): `Record`\<`string`, `string`\>

Defined in: [src/base/html.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L202)

Parses a URL query string into a key/value map.

## Parameters

### s?

`string`

Query string to parse (without leading `?` is also accepted). When `undefined`, `location.search` is used.

## Returns

`Record`\<`string`, `string`\>

An object mapping decoded keys to decoded values. Keys without `=` map to their own name; malformed percent-encodings are skipped.

## Example

```ts
parseQueryString("a=1&b=hello%20world"); // { a: "1", b: "hello world" }
```
