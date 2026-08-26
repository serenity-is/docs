# Retrieve Request Handler

The `RetrieveRequestHandler` is the base class that handles Retrieve service requests — fetching a single record by ID. It's what edit dialogs use to load a record's details before showing the edit form.

## Generated Handler

For a `Language` entity, Sergen generates:

```cs
using MyRow = MyProject.Administration.LanguageRow;

namespace MyProject.Administration;

public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow> { }

public class LanguageRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), ILanguageRetrieveHandler
{
}
```

The class derives from the generic [RetrieveRequestHandler&lt;TRow&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Services/RetrieveRequestHandler-1.md) and [IRetrieveRequestHandler](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRetrieveRequestHandler.md). Like the other handlers, it is auto-registered through the type source.

> `RetrieveRequestHandler<TRow>` itself derives from the fully generic [RetrieveRequestHandler&lt;TRow, TRetrieveRequest, TRetrieveResponse&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Services/RetrieveRequestHandler-3.md) — the extra arguments let you customize the request and response types.

## The Service Endpoint

The endpoint exposes a single Retrieve action:

```cs
[Route("Services/Administration/Language/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class LanguageEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeRead(typeof(MyRow))]
    public RetrieveResponse<MyRow> Retrieve(IUnitOfWork uow, RetrieveRequest request,
        [FromServices] ILanguageRetrieveHandler handler)
    {
        return handler.Retrieve(uow, request);
    }
}
```

`[AuthorizeRead(typeof(MyRow))]` validates the read permission declared on the row.

## The Request and Response

The request is a [RetrieveRequest](../api/dotnet/Serenity.Net.Services/Serenity.Services/RetrieveRequest.md):

```cs
public class RetrieveRequest : ServiceRequest, IIncludeExcludeColumns
{
    public object EntityId { get; set; }
    public RetrieveColumnSelection ColumnSelection { get; set; }
    public HashSet<string> IncludeColumns { get; set; }
    public HashSet<string> ExcludeColumns { get; set; }
}
```

- `EntityId` — the ID of the record to fetch.
- `ColumnSelection` — which columns to load (defaults to `Details`).
- `IncludeColumns` / `ExcludeColumns` — explicit column overrides, like the list handler.

The response is a [RetrieveResponse&lt;T&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Services/RetrieveResponse-1.md):

```cs
public class RetrieveResponse<T> : ServiceResponse, IRetrieveResponse
{
    public T Entity { get; set; }
    public Dictionary<string, T> Localizations { get; set; }
}
```

`Entity` is the loaded record; `Localizations` holds per-language values when localization is used.

## RetrieveColumnSelection

[`RetrieveColumnSelection`](../api/dotnet/Serenity.Net.Services/Serenity.Services/RetrieveColumnSelection.md) controls which columns are loaded:

| Value | Meaning |
| --- | --- |
| `Details` (default) | All table and view columns (except unmapped / complex columns) |
| `KeyOnly` | Only primary key fields |
| `List` | Only table columns (like `ColumnSelection.List` in the list handler) |
| `None` | No columns by default |
| `IdOnly` | Only the ID field |
| `Lookup` | ID, name, and fields with `[LookupInclude]` |

## Lifecycle Methods

The main overridable methods are:

- `ValidateRequest()` — checks the read permission.
- `OnBeforeExecuteQuery()` — called before the retrieve query runs.
- `OnAfterExecuteQuery()` — called after the query succeeds.
- `OnReturn()` — called just before the response is returned.

These also invoke any registered `IRetrieveBehavior` hooks (`OnPrepareQuery`, `OnBeforeExecuteQuery`, `OnAfterExecuteQuery`, `OnReturn`).

## Behaviors

Behaviors implementing [IRetrieveBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRetrieveBehavior.md) run for every retrieve handler and are the recommended way to add cross-cutting retrieve logic (e.g. filtering what a user can read).

## See Also

- [Service Endpoints](service_endpoints.md)
- [List Request Handler](list_request_handler.md)
- [Save Request Handler](save_request_handler.md)
- [Delete Request Handler](delete_request_handler.md)
- [Undelete Request Handler](undelete_request_handler.md)
- [Generating Handler Interfaces](generate_interface.md)