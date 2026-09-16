[@serenity-is/corelib](../README.md) / PostToUrlOptions

# Interface: PostToUrlOptions

Defined in: [src/compat/services-compat.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L38)

Options for posting arbitrary parameters to a URL via a hidden form.
Compat shim for the legacy `PostToUrlOptions` type.
Prefer `fetch` or standard form handling. Kept for legacy file-export / report post flows.

## Properties

### params

> **params**: `any`

Defined in: [src/compat/services-compat.tsx:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L44)

Map of form field names to values; each entry becomes a hidden `<input>` in the posted form.

***

### target?

> `optional` **target**: `string`

Defined in: [src/compat/services-compat.tsx:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L42)

Form `target` attribute (e.g., `"_blank"`).

***

### url?

> `optional` **url**: `string`

Defined in: [src/compat/services-compat.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L40)

Target URL to post to (app-relative or absolute). Resolved via `resolveUrl`.
