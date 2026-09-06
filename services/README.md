# Services

Serenity services follow a **request handler** based architecture. When a client calls a service endpoint (an MVC controller deriving from `ServiceEndpoint`), the endpoint delegates the actual work to a *request handler* — a class deriving from one of Serenity's handler base classes. The handlers encapsulate the standard CRUD operations:

- [List Request Handler](list_request_handler.md) — lists/reads data (used by grids)
- [Save Request Handler](save_request_handler.md) — inserts or updates a record
- [Delete Request Handler](delete_request_handler.md) — deletes a record
- [Undelete Request Handler](undelete_request_handler.md) — undeletes a soft-deleted record
- [Retrieve Request Handler](retrieve_request_handler.md) — retrieves a single record by ID
- [Service Models](service-models.md) — the request/response shapes used by endpoints and client typings
- [Generating Handler Interfaces](generate_interface.md) — auto-generate handler interfaces with `[GenerateInterface]` (StartSharp)
- [Custom Request Handlers](custom_request_handlers.md) — write handlers for non-CRUD actions
- [Request Context](request-context.md) — the `IRequestContext` services passed to handlers and the `BaseRequestHandler` base class
- [Auto-Registration of Request Handlers](handler_auto_registration.md) — how handlers are registered automatically
- [Service Behaviors](behaviors.md) — cross-cutting hooks that run for every handler of a matching type
- [Built-in Service Behaviors](built-in-behaviors.md) — framework behaviors (capture log, localization, master-detail, unique constraints, etc.)
- [Uploads](upload.md) — file and image uploads (storage, processing, validation, configuration)
- [Validation](validation.md) — server-side validation of request data (required fields, custom validators, error responses)
- [Reporting](reporting.md) — server-side reports (HTML/PDF/Excel/CSV), report registry/factory, HTML-to-PDF converters

Each handler type has a corresponding base class and a marker interface that behaviors use. From Serenity 10.5.0 the default (and Sergen-generated) variants are **asynchronous** — `ListRequestHandlerAsync`, `SaveRequestHandlerAsync`, `DeleteRequestHandlerAsync`, `UndeleteRequestHandlerAsync`, `RetrieveRequestHandlerAsync` — with `...Async` methods taking a `CancellationToken`. The synchronous bases are kept for backward compatibility and are marked **obsolete**; they will be deprecated in a future version.

## Request Handlers

Request handlers are auto-registered through the type source by `AddServiceHandlers()`. For each entity (row), Sergen generates a small handler class that derives from the relevant async base class and implements the corresponding interface. For example, for a `Language` entity:

```cs
public interface ILanguageSaveHandler : ISaveHandlerAsync<MyRow> { }

public class LanguageSaveHandler(IRequestContext context)
    : SaveRequestHandlerAsync<MyRow>(context), ILanguageSaveHandler
{
}
```

The base classes provide all the default logic (validation, permission checks, audit logging, SQL generation, etc.), so an empty handler like the one above already gives you a working Create/Update/Delete service. You override virtual `...Async` methods when you need custom behavior.

## Behaviors

In addition to overriding methods, you can intercept request handlers through *behaviors* — classes implementing `ISaveBehaviorAsync`/`ISaveBehaviorSync`, `IListBehaviorAsync`/`IListBehaviorSync`, `IDeleteBehaviorAsync`/`IDeleteBehaviorSync`, `IUndeleteBehaviorAsync`/`IUndeleteBehaviorSync`, or `IRetrieveBehaviorAsync`/`IRetrieveBehaviorSync`. Behaviors run for every handler of the matching type (they are discovered through the type source), making them ideal for cross-cutting concerns like audit logging, multi-tenancy, or master–detail handling.

See [Service Behaviors](behaviors.md) for the full guide — the behavior interfaces, how they are discovered and attached, the handler lifecycle, and worked examples.

## Service Endpoints

The MVC layer that exposes handlers to the client is covered in [Service Endpoints](service_endpoints.md).

## See Also

- [Service Endpoints](service_endpoints.md)
- [Service Models](service-models.md)
- [List Request Handler](list_request_handler.md)
- [Save Request Handler](save_request_handler.md)
- [Delete Request Handler](delete_request_handler.md)
- [Undelete Request Handler](undelete_request_handler.md)
- [Retrieve Request Handler](retrieve_request_handler.md)
- [Generating Handler Interfaces](generate_interface.md)
- [Request Context](request-context.md)
- [Validation](validation.md)
- [Reporting](reporting.md)