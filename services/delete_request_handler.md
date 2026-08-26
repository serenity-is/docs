# Delete Request Handler

The `DeleteRequestHandler` is the base class that handles Delete service requests. Like the other handlers, Sergen generates a small subclass for every entity; the base class contains all the default logic.

## Generated Handler

For a `Language` entity, Sergen generates:

```cs
using MyRow = MyProject.Administration.LanguageRow;

namespace MyProject.Administration;

public interface ILanguageDeleteHandler : IDeleteHandler<MyRow> { }

public class LanguageDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), ILanguageDeleteHandler
{
}
```

The class derives from the generic [DeleteRequestHandler&lt;TRow&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Services/DeleteRequestHandler-1.md) and [IDeleteRequestHandler](../api/dotnet/Serenity.Net.Services/Serenity.Services/IDeleteRequestHandler.md).

> `DeleteRequestHandler<TRow>` itself derives from the fully generic [DeleteRequestHandler&lt;TRow, TDeleteRequest, TDeleteResponse&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Services/DeleteRequestHandler-3.md) — the extra arguments let you customize the request and response types if you ever need a delete handler with a custom request/response.

## The Service Endpoint

The endpoint exposes a single Delete action:

```cs
[Route("Services/Administration/Language/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class LanguageEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] ILanguageDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }
}
```

`[AuthorizeDelete(typeof(MyRow))]` validates the delete permission declared on the row.

## The Request and Response

The request is a [DeleteRequest](../api/dotnet/Serenity.Net.Services/Serenity.Services/DeleteRequest.md):

```cs
public class DeleteRequest : ServiceRequest
{
    public object EntityId { get; set; }
}
```

It only contains the ID of the record to delete. The response is a [DeleteResponse](../api/dotnet/Serenity.Net.Services/Serenity.Services/DeleteResponse.md):

```cs
public class DeleteResponse : ServiceResponse
{
    public bool WasAlreadyDeleted { get; set; }
}
```

`WasAlreadyDeleted` is `true` if the record was already deleted (soft deleted) before this call.

## Hard Delete vs Soft Delete

The delete behavior depends on the row type:

- **Hard delete** — if the row is a plain table row (no `IsActive`/`IsDeleted` field), the record is physically removed with a `DELETE` statement.
- **Soft delete** — if the row implements [IIsActiveDeletedRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIsActiveDeletedRow.md) (i.e. it has an `IsActive` field where `-1` means deleted), the handler issues an `UPDATE ... SET IsActive = -1` instead of deleting. The record stays in the table and can be restored later with the [Undelete Request Handler](undelete_request_handler.md).
- **IsDeleted soft delete** — if the row implements [IIsDeletedRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIsDeletedRow.md) (an `IsDeleted` field), the handler sets `IsDeleted = true`.

`IsActive` is a common pattern in Serene/StartSharp templates: rows implementing `IIsActiveRow` use `1` for active and `0` for inactive, and `-1` for deleted (the `IIsActiveDeletedRow` interface marks that `-1` is the deleted value).

## Lifecycle Methods

The main overridable methods are:

- `OnBeforeDelete()` — called before the delete/soft-delete is executed.
- `OnAfterDelete()` — called after the delete/soft-delete succeeds.
- `OnReturn()` — called just before the response is returned.

`OnBeforeDelete`/`OnAfterDelete` also invoke any registered `DeleteBehavior.OnBeforeDelete` / `OnAfterDelete`.

## Example: Deleting Related Records

The Movie tutorial manually deletes a movie's cast entries before deleting the movie, to avoid foreign-key errors:

```cs
public class MovieDeleteHandler : DeleteRequestHandler<MyRow>, IMovieDeleteHandler
{
    private readonly IServiceResolver<IMovieCastDeleteHandler> movieCastDelete;

    public MovieDeleteHandler(IRequestContext context,
        IServiceResolver<IMovieCastDeleteHandler> movieCastDelete) : base(context)
    {
        this.movieCastDelete = movieCastDelete;
    }

    protected override void OnBeforeDelete()
    {
        base.OnBeforeDelete();

        var mc = MovieCastRow.Fields;
        foreach (var detailID in Connection.Query<Int32>(
            new SqlQuery().From(mc)
                .Select(mc.MovieCastId)
                .Where(mc.MovieId == Row.MovieId.Value)))
        {
            movieCastDelete.Resolve().Delete(UnitOfWork, new() { EntityId = detailID });
        }
    }
}
```

> Note that for master–detail relations you normally don't need to do this by hand — the `MasterDetailRelation` behavior handles related records automatically.

## Behaviors

Behaviors implementing [IDeleteBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IDeleteBehavior.md) run for every delete handler and are the recommended way to add cross-cutting delete logic.

## See Also

- [Service Endpoints](service_endpoints.md)
- [Save Request Handler](save_request_handler.md)
- [Retrieve Request Handler](retrieve_request_handler.md)
- [Undelete Request Handler](undelete_request_handler.md)
- [Generating Handler Interfaces](generate_interface.md)
