[@serenity-is/corelib](../README.md) / PostToServiceOptions

# ~~Interface: PostToServiceOptions~~

Defined in: [src/compat/services-compat.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L23)

Options for posting data to a Serenity service endpoint via a hidden form.
Compat shim for the legacy `Q.PostToServiceOptions` type.

## Deprecated

Prefer `fetch` / `serviceCall` APIs. Kept for legacy form-post integrations.

## Properties

### ~~request~~

> **request**: `any`

Defined in: [src/compat/services-compat.tsx:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L31)

Request payload that will be JSON-stringified into a hidden `request` field.

***

### ~~service?~~

> `optional` **service**: `string`

Defined in: [src/compat/services-compat.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L27)

Service identifier (e.g., `"Administration/User/List"`) resolved via `resolveServiceUrl` when [url](#url) is not provided.

***

### ~~target?~~

> `optional` **target**: `string`

Defined in: [src/compat/services-compat.tsx:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L29)

Form `target` attribute (e.g., `"_blank"` or a frame name). When omitted the form posts in the current window.

***

### ~~url?~~

> `optional` **url**: `string`

Defined in: [src/compat/services-compat.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L25)

Absolute or app-relative URL to post to. When provided, takes precedence over [service](#service). Resolved via `resolveUrl`.
