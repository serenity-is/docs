import { EntityGrid, WidgetProps } from "@serenity-is/corelib";
import { MovieCastRow, MovieCastService, PersonMovieColumns } from "../../ServerTypes/MovieDB";

export class PersonMovieGrid<P = {}> extends EntityGrid<MovieCastRow, P> {
    static override [Symbol.typeInfo] = this.registerEditor("MovieTutorial.MovieDB.PersonMovieGrid");

    protected override getColumnsKey() { return PersonMovieColumns.columnsKey; }
    protected override getRowDefinition() { return MovieCastRow; }
    protected override getService() { return MovieCastService.baseUrl; }

    constructor(props: WidgetProps<P>) {
        super(props);
    }

    protected override getButtons() {
        return null;
    }

    protected override getInitialTitle() {
        return null;
    }

    protected override usePager() {
        return false;
    }

    protected override getGridCanLoad() {
        return this.personId != null;
    }

    private _personId: number;

    get personId() {
        return this._personId;
    }

    set personId(value: number) {
        if (this._personId != value) {
            this._personId = value;
            this.setEquality(MovieCastRow.Fields.PersonId, value);
            this.refresh();
        }
    }
}
