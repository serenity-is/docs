import { EntityDialog } from "@serenity-is/corelib";
import { PersonForm, PersonRow, PersonService } from "../../ServerTypes/MovieDB";

export class PersonDialog extends EntityDialog<PersonRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.MovieDB.");

    protected override getFormKey() { return PersonForm.formKey; }
    protected override getRowDefinition() { return PersonRow; }
    protected override getService() { return PersonService.baseUrl; }

    protected form = new PersonForm(this);
}