import { EntityDialog } from "@serenity-is/corelib";
import { PersonForm, PersonRow, PersonService } from "../../ServerTypes/MovieDB";
import { PersonMovieGrid } from "./PersonMovieGrid";
import "./PersonDialog.css";

export class PersonDialog extends EntityDialog<PersonRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.MovieDB.");

    protected override getFormKey() { return PersonForm.formKey; }
    protected override getRowDefinition() { return PersonRow; }
    protected override getService() { return PersonService.baseUrl; }

    protected form: PersonForm;

    constructor(...args: any[]) {
        super(...args);
        const w = globalThis as any;
        if (w.Serenity) {
            w.Serenity.EditorTypeRegistry.registeredTypes ??= {};
            w.Serenity.EditorTypeRegistry.registeredTypes["MovieTutorial.MovieDB.PersonMovieGrid"] = PersonMovieGrid;
        }
        this.form = new PersonForm(this);
    }

    protected override afterLoadEntity() {
        super.afterLoadEntity();

        this.form.MoviesGrid.personId = this.entityId;
    }
}