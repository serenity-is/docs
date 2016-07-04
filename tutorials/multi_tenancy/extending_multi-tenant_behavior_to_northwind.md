# 扩展多租户行为到 Northwind 

由于我们现在有一个行为处理仓储的详细信息，我们只需在行（rows）实现 *IMultiTenantRow* 接口并添加 *TenantId* 属性。

从 *SupplierRow.cs* 开始：

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

当你在 *SupplierRow* 做这些更改并生成后，你将看到 *tenant2* 不能在供应商页面看到其他租户的供应商。

现在，在 *EmployeeRow*， *CategoryRow*， *CustomerRow*， *ShipperRow*， *OrderRow*， *ProductRow*， *RegionRow* 和 *TerritoryRow* 重复这些修改。

