[@serenity-is/corelib](../README.md) / PostToServiceOptions

# Interface: PostToServiceOptions

Defined in: [src/compat/services-compat.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L22)

Options for posting data to a Serenity service endpoint via a hidden form.
Compat shim for the legacy `PostToServiceOptions` type.

## Properties

### request

> **request**: `any`

Defined in: [src/compat/services-compat.tsx:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L30)

Request payload that will be JSON-stringified into a hidden `request` field.

***

### service?

> `optional` **service**: `string`

Defined in: [src/compat/services-compat.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L26)

Service identifier (e.g., `"Administration/User/List"`) resolved via `resolveServiceUrl` when [url](#url) is not provided.

***

### target?

> `optional` **target**: `string`

Defined in: [src/compat/services-compat.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L28)

Form `target` attribute (e.g., `"_blank"` or a frame name). When omitted the form posts in the current window.

***

### url?

> `optional` **url**: `string`

Defined in: [src/compat/services-compat.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L24)

Absolute or app-relative URL to post to. When provided, takes precedence over [service](#service). Resolved via `resolveUrl`.
