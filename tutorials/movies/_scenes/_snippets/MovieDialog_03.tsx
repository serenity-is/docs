import { EntityDialog } from '@serenity-is/corelib';
import { MovieForm, MovieRow, MovieService } from '../../ServerTypes/MovieDB';

export class MovieDialog extends EntityDialog<MovieRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.MovieDB.");

    protected override getFormKey() { return MovieForm.formKey; }
    protected override getRowDefinition() { return MovieRow; }
    protected override getService() { return MovieService.baseUrl; }

    protected form = new MovieForm(this);
}
