[@serenity-is/corelib](../README.md) / initFlatpickrLocale

# Function: initFlatpickrLocale()

> **initFlatpickrLocale**(`flatpickr`): `void`

Defined in: [src/compat/init-global-mappings.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L182)

Localizes a flatpickr instance to the document language.

## Parameters

### flatpickr

`any`

flatpickr module/instance with a `l10ns` dictionary and `localize` method; no-op if missing `l10ns`.

## Returns

`void`

## Remarks

Reads `document.documentElement.lang` (falls back to `"en"`), tries the full locale (e.g. `"tr-tr"`) then the base language (e.g. `"tr"`) if available in `flatpickr.l10ns`. Called automatically by [initGlobalMappings](initGlobalMappings.md) when a flatpickr module is provided.

## Example

```ts
initFlatpickrLocale(flatpickr);
```
