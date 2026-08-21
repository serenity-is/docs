[@serenity-is/corelib](../README.md) / initNProgress

# Function: initNProgress()

> **initNProgress**(`nprogress?`): `boolean`

Defined in: [src/compat/init-global-mappings.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L202)

Wires NProgress to global `ajaxStart`/`ajaxStop` events (via [Fluent](Fluent.md)).

## Parameters

### nprogress?

`any`

NProgress instance; defaults to `getGlobalObject().NProgress` when omitted.

## Returns

`boolean`

`true` once initialized (`nprogress.serenityInit` is set); `undefined`/falsy if already initialized, missing, or `document` is unavailable.

## Remarks

Starts the progress bar 200 ms after `ajaxStart` (debounced) and completes it on `ajaxStop`. No-ops if `start`/`done` are missing, already initialized, or running outside a browser. Called automatically by [initGlobalMappings](initGlobalMappings.md) when an `nprogress` module is provided.

## Example

```ts
initNProgress(NProgress);
```
