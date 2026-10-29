import { GridEditorDialog } from "@serenity-is/extensions";
import { MovieCastForm, MovieCastRow } from "../../ServerTypes/MovieDB";
import "./MovieCastEditDialog.css";

export class MovieCastEditDialog extends GridEditorDialog<MovieCastRow> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.MovieDB.MovieCastEditDialog");

    protected override getFormKey() { return MovieCastForm.formKey; }
    protected override getNameProperty() { return MovieCastRow.nameProperty; }
    protected override getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

    protected form = new MovieCastForm(this);
}
