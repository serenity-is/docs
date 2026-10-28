import { EntityGrid, localText, QuickSearchField } from "@serenity-is/corelib";
import { MovieColumns, MovieRow, MovieService } from "../../ServerTypes/MovieDB";
import { MovieDialog } from "./MovieDialog";

export class MovieGrid extends EntityGrid<MovieRow> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.MovieDB.");

    protected override getColumnsKey() { return MovieColumns.columnsKey; }
    protected override getDialogType() { return MovieDialog; }
    protected override getRowDefinition() { return MovieRow; }
    protected override getService() { return MovieService.baseUrl; }

    protected override getQuickSearchFields(): QuickSearchField[] {
        const txt = (s: string) => localText(`Db.${MovieRow.localTextPrefix}.${s}`);
        const fld = MovieRow.Fields;
        return [
            { name: "", title: "All" },
            { name: fld.Description, title: txt(fld.Description) },
            { name: fld.Storyline, title: txt(fld.Storyline) },
            { name: fld.Year, title: txt(fld.Year) }
        ];
    }
}
