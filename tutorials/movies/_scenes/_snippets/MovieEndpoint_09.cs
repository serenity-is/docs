using Serenity.Reporting;
using System.Data;
using System.Globalization;
using MyRow = MovieTutorial.MovieDB.MovieRow;

namespace MovieTutorial.MovieDB.Endpoints;

[Route("Services/MovieDB/Movie/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class MovieEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public Task<SaveResponse> Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IMovieSaveHandler handler, CancellationToken cancellationToken = default)
    {
        return handler.CreateAsync(uow, request, cancellationToken);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public Task<SaveResponse> Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IMovieSaveHandler handler, CancellationToken cancellationToken = default)
    {
        return handler.UpdateAsync(uow, request, cancellationToken);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public Task<DeleteResponse> Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IMovieDeleteHandler handler, CancellationToken cancellationToken = default)
    {
        return handler.DeleteAsync(uow, request, cancellationToken);
    }

    [HttpPost, AuthorizeRetrieve(typeof(MyRow))]
    public Task<RetrieveResponse<MyRow>> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IMovieRetrieveHandler handler, CancellationToken cancellationToken = default)
    {
        return handler.RetrieveAsync(connection, request, cancellationToken);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public Task<ListResponse<MyRow>> List(IDbConnection connection, ListRequest request,
        [FromServices] IMovieListHandler handler, CancellationToken cancellationToken = default)
    {
        return handler.ListAsync(connection, request, cancellationToken);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public async Task<FileContentResult> ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IMovieListHandler handler,
        [FromServices] IExcelExporter exporter, CancellationToken cancellationToken = default)
    {
        var data = (await List(connection, request, handler, cancellationToken)).Entities;
        var bytes = exporter.Export(data, typeof(Columns.MovieColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "MovieList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
}