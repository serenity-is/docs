using MyRow = MovieTutorial.MovieDB.MovieRow;

namespace MovieTutorial.MovieDB;

public interface IMovieListHandler : IListHandlerAsync<MyRow, ListRequest, ListResponse<MyRow>> { }

public class MovieListHandler(IRequestContext context) :
    ListRequestHandlerAsync<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IMovieListHandler
{
}