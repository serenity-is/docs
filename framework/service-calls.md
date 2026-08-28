# Type-Safe Service Calls

Serenity generates TypeScript service clients from your server-side service endpoints. These generated clients (in `ServerTypes/`) provide type-safe methods for calling your services, so you don't have to write AJAX calls by hand.

## Generated Service Clients

For each service endpoint, Sergen generates a namespace with typed methods. For example, `LanguageService.ts`:

```ts
import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { LanguageRow } from "./LanguageRow";

export namespace LanguageService {
    export const baseUrl = 'Administration/Language';

    export declare function Create(request: SaveRequest<LanguageRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<LanguageRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<LanguageRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<LanguageRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<LanguageRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<LanguageRow>>;

    export const Methods = {
        Create: "Administration/Language/Create",
        Update: "Administration/Language/Update",
        Delete: "Administration/Language/Delete",
        Retrieve: "Administration/Language/Retrieve",
        List: "Administration/Language/List"
    } as const;
}
```

Each method takes a typed request, an optional success callback, and optional service options, and returns a promise.

## Calling a Service

```ts
import { LanguageService } from "./ServerTypes/Administration";

// List
const response = await LanguageService.List({});
// response.Entities is LanguageRow[]

// Retrieve
const row = await LanguageService.Retrieve({ EntityId: 123 });
// row.Entity is LanguageRow

// Create
await LanguageService.Create({ Entity: { LanguageName: "English" } });

// Update
await LanguageService.Update({ EntityId: 123, Entity: { LanguageName: "English (US)" } });

// Delete
await LanguageService.Delete({ EntityId: 123 });
```

## ServiceOptions

The optional `opt` parameter lets you customize the request:

| Option | Description |
| --- | --- |
| `service` | The service key (resolved to `~/Services/<key>`). |
| `url` | A full URL instead of a service key. |
| `method` | HTTP method (default `POST`). |
| `request` | The request body. |
| `onSuccess` | Success callback. |
| `onError` | Error callback. |
| `blockUI` | Whether to show a blocking overlay (default `true`). |
| `async` | Whether the request is asynchronous (default `true`). |
| `allowRedirect` | Whether redirects are allowed (default `true`). |
| `signal` | An `AbortSignal` to cancel the request. |

## serviceCall and serviceRequest

The generated methods call `serviceRequest`, which is a convenience wrapper around `serviceCall`:

```ts
serviceRequest<TResponse>(service: string, request?: any, onSuccess?: (response: TResponse) => void, opt?: ServiceOptions<TResponse>): PromiseLike<TResponse>
```

`serviceCall` is the lower-level function that takes a full `ServiceOptions` object:

```ts
serviceCall<TResponse>(options: ServiceOptions<TResponse>): PromiseLike<TResponse>
```

`getServiceOptions` normalizes the options: it resolves the URL, sets defaults (`POST`, `blockUI`, etc.), and injects `Accept`, `Content-Type`, and the same-origin `X-CSRF-TOKEN` header.

## Error Handling

Service calls reject with a `ServiceError` on failure. You can handle errors with a `try/catch` or the `onError` option:

```ts
try {
    await LanguageService.Create({ Entity: { LanguageName: "English" } });
}
catch (e) {
    // e is a ServiceError with Code, Message, and Details
    notifyError(e.Message);
}
```

## See Also

- [serviceCall (API reference)](../api/js/corelib/functions/serviceCall.md) — the low-level service call function.
- [serviceRequest (API reference)](../api/js/corelib/functions/serviceRequest.md) — the convenience wrapper.
- [getServiceOptions (API reference)](../api/js/corelib/functions/getServiceOptions.md) — option normalization.
- [ServiceOptions (API reference)](../api/js/corelib/interfaces/ServiceOptions.md) — service options.
- [ServiceError (API reference)](../api/js/corelib/interfaces/ServiceError.md) — the error type.
- [ListRequest](../api/js/corelib/interfaces/ListRequest.md), [ListResponse](../api/js/corelib/interfaces/ListResponse.md) — list request/response.
- [SaveRequest](../api/js/corelib/interfaces/SaveRequest.md), [SaveResponse](../api/js/corelib/interfaces/SaveResponse.md) — save request/response.
- [RetrieveRequest](../api/js/corelib/interfaces/RetrieveRequest.md), [RetrieveResponse](../api/js/corelib/interfaces/RetrieveResponse.md) — retrieve request/response.
- [DeleteRequest](../api/js/corelib/interfaces/DeleteRequest.md), [DeleteResponse](../api/js/corelib/interfaces/DeleteResponse.md) — delete request/response.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.