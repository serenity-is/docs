[@serenity-is/corelib](../../../../README.md) / [Criteria](../README.md) / functionCall

# Function: functionCall()

> **functionCall**(`functionName`, ...`args`): `any`[]

Defined in: [src/base/criteria.ts:1196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L1196)

Creates a function-call criteria. Function arguments use the same
criteria/value shapes as other criteria nodes. The server only accepts
function names registered with its criteria function factory.

## Parameters

### functionName

`string`

Name of the function.

### args

...`any`[]

Function arguments.

## Returns

`any`[]

Criteria `["function", [functionName, ...args]]`.

## Example

```ts
Criteria.functionCall("COALESCE", Criteria("Name"), "unknown");
// ["function", ["COALESCE", ["Name"], "unknown"]]
```
