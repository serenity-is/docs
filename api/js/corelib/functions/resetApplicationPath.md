[@serenity-is/corelib](../README.md) / resetApplicationPath

# Function: resetApplicationPath()

> **resetApplicationPath**(): `void`

Defined in: [src/base/config.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/config.ts#L112)

Re-reads [Config.applicationPath](../variables/Config.md#applicationpath) from the DOM.

## Returns

`void`

## Remarks

Looks for `<link id="ApplicationPath">` and copies its `href`; falls back to `"/"`
if absent or when `document` is unavailable (SSR). Called once on module load;
call again after you change the link element at runtime.

## Example

```ts
document.getElementById("ApplicationPath").href = "/newPath/";
resetApplicationPath();
```
