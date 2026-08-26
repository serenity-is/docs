# Undelete Request Handler

The `UndeleteRequestHandler` is the base class that handles Undelete service requests. It restores a record that was previously **soft deleted**.

Sergen only generates an Undelete handler for rows that support soft delete, i.e. rows implementing [IIsActiveDeletedRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIsActiveDeletedRow.md) or [IIsDeletedRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIsDeletedRow.md). For a row without an `IsActive`/`IsDeleted` field (which is hard-deleted), there is nothing to undelete, so no handler is generated.

## Generated Handler

For a row that supports soft delete, Sergen generates:

```cs
using MyRow = MyProject.Administration.UserRow;

namespace MyProject.Administration;

public interface IUserUndeleteHandler : IUndeleteHandler<MyRow> { }

public class UserUndeleteHandler(IRequestContext context)
    : UndeleteRequestHandler<MyRow>(context), IUserUndeleteHandler
{
}
```

The class derives from the generic [UndeleteRequestHandler&lt;TRow&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Services/UndeleteRequestHandler-1.md) and [IUndeleteRequestHandler](../api/dotnet/Serenity.Net.Services/Serenity.Services/IUndeleteRequestHandler.md).

> `UndeleteRequestHandler<TRow>` itself derives from the fully generic [UndeleteRequestHandler&lt;TRow, TUndeleteRequest, TUndeleteResponse&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Services/UndeleteRequestHandler-3.md) — the extra arguments let you customize the request and response types if you ever need an undelete handler with a custom request/response.

## The Service Endpoint

The endpoint exposes a single Undelete action:

```cs
[Route("Services/Administration/User/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class UserEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public UndeleteResponse Undelete(IUnitOfWork uow, UndeleteRequest request,
        [FromServices] IUserUndeleteHandler handler)
    {
        return handler.Undelete(uow, request);
    }
}
```

## The Request and Response

The request is an [UndeleteRequest](../api/dotnet/Serenity.Net.Services/Serenity.Services/UndeleteRequest.md):

```cs
public class UndeleteRequest : ServiceRequest
{
    public object EntityId { get; set; }
}
```

It only contains the ID of the record to restore. The response is an [UndeleteResponse](../api/dotnet/Serenity.Net.Services/Serenity.Services/UndeleteResponse.md):

```cs
public class UndeleteResponse : ServiceResponse
{
    public bool WasNotDeleted { get; set; }
}
```

`WasNotDeleted` is `true` if the record was not actually soft-deleted (e.g. it was already restored, or its `IsActive` was not `-1`).

## What Undelete Does

Depending on the row type:

- For [IIsActiveDeletedRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIsActiveDeletedRow.md) rows, the handler issues `UPDATE ... SET IsActive = 1` where `IsActive = -1`, restoring the record to active.
- For [IIsDeletedRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIsDeletedRow.md) rows, it sets `IsDeleted = false`.

If the row type doesn't implement one of these interfaces, the handler raises an error, because there is no way to undelete a hard-deleted record.

## Lifecycle Methods

The main overridable methods are:

- `OnBeforeUndelete()` — called before the undelete is executed.
- `OnAfterUndelete()` — called after the undelete succeeds.
- `OnReturn()` — called just before the response is returned.

`OnBeforeUndelete`/`OnAfterUndelete` also invoke any registered `IUndeleteBehavior.OnBeforeUndelete` / `OnAfterUndelete`.

## See Also

- [Service Endpoints](service_endpoints.md)
- [Save Request Handler](save_request_handler.md)
- [Retrieve Request Handler](retrieve_request_handler.md)
- [Delete Request Handler](delete_request_handler.md)
- [Generating Handler Interfaces](generate_interface.md)
