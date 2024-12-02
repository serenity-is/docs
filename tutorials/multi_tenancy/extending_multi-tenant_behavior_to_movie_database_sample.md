# Extending Multi-Tenant Behavior to MovieDB Sample

Now that we have a behavior handling repository details, we need to add the `IMultiTenantRow` interface to the rows and include the `TenantId` property.

Start with `MovieRow.cs`:

```cs
//...

namespace MovieTutorial.MovieDB;

//...
public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
{
    //...
    [Insertable(false), Updatable(false)]
    public int? TenantId { get => Fields.TenantId[this]; set => Fields.TenantId[this] = value; }

    public Int32Field TenantIdField { get => Fields.TenantId; }

    public class RowFields : RowFieldsBase
    {
        //...
        public Int32Field TenantId;
    }
}

```

After applying these changes to `MovieRow` and building the project, _tenant2_ will no longer be able to view suppliers from other tenants on the suppliers page.

Next, repeat these steps for `Person` and `Genre`.
