[@serenity-is/corelib](../README.md) / ServiceError

# Interface: ServiceError

Defined in: [src/base/servicetypes.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L6)

Error payload returned by Serenity service endpoints inside a [ServiceResponse](ServiceResponse.md).
The server populates at least `Code` or `Message`; other fields are optional and
depend on the handler / validation layer.

## Properties

### Arguments?

> `optional` **Arguments**: `string`

Defined in: [src/base/servicetypes.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L10)

Optional comma-separated or serialized arguments that parameterize the error message (e.g. field names).

***

### Code?

> `optional` **Code**: `string`

Defined in: [src/base/servicetypes.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L8)

Machine-readable error code (e.g. `"NotLoggedIn"`, `"ValidationError"`, `"AccessDenied"`).

***

### Details?

> `optional` **Details**: `string`

Defined in: [src/base/servicetypes.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L14)

Detailed / technical information (e.g. stack trace or inner exception) — only when diagnostics are enabled.

***

### ErrorId?

> `optional` **ErrorId**: `string`

Defined in: [src/base/servicetypes.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L16)

Correlation / error ID assigned server-side for log lookup.

***

### Message?

> `optional` **Message**: `string`

Defined in: [src/base/servicetypes.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L12)

Human-readable, possibly localized, error message suitable for display.
