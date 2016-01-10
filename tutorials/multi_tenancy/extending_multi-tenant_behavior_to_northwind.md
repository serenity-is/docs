# Extending Multi-Tenant Behavior To Northwind

As now we have a behavior handling repository details, we just need to add *IMultiTenantRow* interface to rows and add *TenantId* property.

Start with *SupplierRow.cs*:

```cs
namespace MultiTenancy.Northwind.Entities
{
    //...
    public sealed class SupplierRow : Row, 
        IIdRow, INameRow, IMultiTenantRow
    {
        //...
        [Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        public Int32Field TenantIdField
        {
            get { return Fields.TenantId; }
        }

        //...
        
        public class RowFields : RowFieldsBase
        {
            //...
            public readonly Int32Field TenantId;
        }
    }
}
```

When you these changes in *SupplierRow* and build, you'll see that *tenant2* can't see suppliers from other tenants in suppliers page.

Now repeat these for *EmployeeRow*, *CategoryRow*, *CustomerRow*, *ShipperRow*, *OrderRow*, *ProductRow*, *RegionRow* and *TerritoryRow*.

