# Extending Multi-Tenant Behavior To MovieDB Sample

As now we have a behavior handling repository details, we just need to add *IMultiTenantRow* interface to rows and add *TenantId* property.

Start with *MovieRow.cs*:

```cs
[ConnectionKey("Default"), Module("MovieDB"), TableName("[mov].[Movie]")]
[DisplayName("Movie"), InstanceName("Movie")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
{
    //...
    [Insertable(false), Updatable(false)]
    public Int32? TenantId
    {
        get => Fields.TenantId[this];
        set => Fields.TenantId[this] = value;
    }

    public Int32Field TenantIdField
    {
        get => Fields.TenantId;
    }

    //...
    
    public class RowFields : RowFieldsBase
    {
        //...
        public Int32Field TenantId;
    }
}
```

When you these changes in *MovieRow* and build, you'll see that *tenant2* can't see suppliers from other tenants in suppliers page.

Now repeat these for *Person* and *Genre*.

