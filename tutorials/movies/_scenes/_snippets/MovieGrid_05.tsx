import { EntityGrid } from "@serenity-is/corelib";
import { MovieColumns, MovieRow, MovieService } from "../../ServerTypes/MovieDB";
import { MovieDialog } from "./MovieDialog";

export class MovieGrid extends EntityGrid<MovieRow> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.MovieDB.");

    protected override getColumnsKey() { return MovieColumns.columnsKey; }
    protected override getDialogType() { return MovieDialog; }
    protected override getRowDefinition() { return MovieRow; }
    protected override getService() { return MovieService.baseUrl; }
}