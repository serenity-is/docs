# Making Roles Multi-Tenant

So far, we have made users page work in multi-tenant style. Seems like we did too many changes to make it work. But remember that we are trying to turn a system that is not designed to be multi-tenant into such one.

Let's apply similar principles to the Roles table.

Again, a user in one tenant shouldn't see or modify roles in other tenants and work in isolation.

We start by adding *TenantId* property to *RoleRow.cs*:

```cs
namespace MultiTenancy.Administration.Entities
{
    //...
    public sealed class RoleRow : Row, IIdRow, INameRow
    {
        [Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }
        
        //...
        
        public class RowFields : RowFieldsBase
        {
            //...
            public readonly Int32Field TenantId;
            //...
        }
    }
}
```

Then we'll do several changes in *RoleRepository.cs*:

