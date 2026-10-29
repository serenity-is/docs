import { GridEditorBase } from "@serenity-is/extensions";
import { MovieCastColumns, MovieCastRow, PersonRow } from "../../ServerTypes/MovieDB";
import { MovieCastEditDialog } from "./MovieCastEditDialog";

export class MovieCastEditor extends GridEditorBase<MovieCastRow> {
    static override [Symbol.typeInfo] = this.registerEditor("MovieTutorial.MovieDB.MovieCastEditor");

    protected override getColumnsKey() { return MovieCastColumns.columnsKey; }
    protected override getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
    protected override getDialogType() { return MovieCastEditDialog; }
    protected override getAddButtonCaption() { return "Add"; }

    protected override validateEntity(row: MovieCastRow, id: number) {
        if (!super.validateEntity(row, id))
            return false;

        const itemId = id ?? row[this.getIdProperty()];
        PersonRow.getLookupAsync().then(lookup => {
            const item = this.view?.getItemById(itemId);
            if (item) {
                item.PersonFullName = lookup.itemById[row.PersonId].FullName;
                this.view.updateItem(itemId, item);
            }
        });
        return true;
    }
}
