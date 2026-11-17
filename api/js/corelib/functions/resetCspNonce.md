[@serenity-is/corelib](../README.md) / resetCspNonce

# Function: resetCspNonce()

> **resetCspNonce**(): `void`

Defined in: [src/base/config.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/config.ts#L134)

Re-reads [Config.cspNonce](../variables/Config.md#cspnonce) from the DOM.

## Returns

`void`

## Remarks

Probes in order: `<meta name="csp-nonce">` → `<script nonce>` → `<style nonce>`.
Sets `null` if none found or when `document` is unavailable. Called once on module load.
