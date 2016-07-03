# 处理检索脚本（Lookup Scripts）

如果我们现在打开 *Suppliers* 页面，我们可以看到 *tenant2* 只能查看属于自己的供应商。但是在网格列表的右上角的 country 下拉列表中，所有的国家选项都被列出来了。

![Tenant2 All Countries](img/tenant2_all_countries.png)

这个数据是通过动态脚本提供给脚本端。它不会在我们最近处理的 *服务列表* 中加载该数据。

提供给该下拉列表的检索脚本在 *SupplierCountryLookup.cs* 中定义：

```cs
namespace MultiTenancy.Northwind.Scripts
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("Northwind.SupplierCountry")]
    public class SupplierCountryLookup : 
        RowLookupScript<Entities.SupplierRow>
    {
        public SupplierCountryLookup()
        {
            IdField = TextField = "Country";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.SupplierRow.Fields;
            query.Distinct(true)
                .Select(fld.Country)
                .Where(
                    new Criteria(fld.Country) != "" &
                    new Criteria(fld.Country).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}
```

> 因为实际上 Northwind 数据库并没有 country 表， 所以我们不能在行（row）类上使用简单的 [LookupScript] 特性。我们从供应商表的现有记录中收集不同的国家名称。  

我们应该通过当前的租户来筛选查询。

但是这个检索类继承自基类 *RowLookupScript* 。让我们创建一个新的基类，为我们稍后再处理其他检索脚本准备。 

```cs
namespace MultiTenancy.Northwind.Scripts
{
    using Administration;
    using Serenity;
    using Serenity.Data;
    using Serenity.Web;
    using System;

    public abstract class MultiTenantRowLookupScript<TRow> : 
        RowLookupScript<TRow>
        where TRow : Row, IMultiTenantRow, new()
    {
        public MultiTenantRowLookupScript()
        {
            Expiration = TimeSpan.FromDays(-1);
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            AddTenantFilter(query);
        }

        protected void AddTenantFilter(SqlQuery query)
        {
            var r = new TRow();
            query.Where(r.TenantIdField ==
                ((UserDefinition)Authorization.UserDefinition).TenantId);
        }

        public override string GetScript()
        {
            return TwoLevelCache.GetLocalStoreOnly("MultiTenantLookup:" + 
                    this.ScriptName + ":" +
                    ((UserDefinition)Authorization.UserDefinition).TenantId, 
                    TimeSpan.FromHours(1),
                new TRow().GetFields().GenerationKey, () =>
                {
                    return base.GetScript();
                });
        }
    }
}
```

这将是我们多租户检索脚本的基类。

我们首先将过期时间设置设为一个负的时间间隔来禁用缓存。为什么要这样做呢？因为动态脚本使用键值（keys）管理检索脚本的缓存。但我们会有多个基于 TenantId 值的检索脚本的版本。

我们会在动态脚本管理层面关闭缓存并在 GetScript 方法中自己处理缓存。在 *GetScript* 方法中，我们使用 *TwoLevelCache.GetLocalStoreOnly* 调用基方法生成我们的检索脚本，并缓存其包含 *TenantId* 缓存键的结果。  

> 更多关于 TwoLevelCache 类的信息，请查看相关章节。


通过重写 *PrepareQuery* 方法，我们添加一个使用当前 *TenantId* 的过滤器，就像我们在列表服务处理中做的一样。

现在是时候使用新基类重写 *SupplierCountryLookup*： 

```cs
namespace MultiTenancy.Northwind.Scripts
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("Northwind.SupplierCountry")]
    public class SupplierCountryLookup : 
        MultiTenantRowLookupScript<Entities.SupplierRow>
    {
        public SupplierCountryLookup()
        {
            IdField = TextField = "Country";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.SupplierRow.Fields;
            query.Distinct(true)
                .Select(fld.Country)
                .Where(
                    new Criteria(fld.Country) != "" &
                    new Criteria(fld.Country).IsNotNull());

            AddTenantFilter(query);
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}
```

因为我们没有在这里调用基类的 *PrepareQuery* 方法(因此它不会由基类调用)，所以我们就手工调用 *AddTenantFilter* 方法。

> 如果有 *Northwind.DynamicScripts.cs* 文件，请先删除它。

在 *CustomerCountryLookup*, *CustomerCityLookup*,
*OrderShipCityLookup*, *OrderShipCountryLookup* 有几个非常相似的检索脚本。我将对它们做类似的修改：把基类改为 *MultiTenantRowLookupScript* 并在 *PrepareQuery* 方法中调用 *AddTenantFilter*。 

我们现在还有一个问题需要解决：如果你打开 *Orders* 页面，你将看到 *Ship Via* 和 *Employee* 过滤下拉列表一直列出其他租户的记录。这是因为我们使用含 [LookupScript] 特性的行定义检索脚本。 

让我们首先来修复雇员检索（employee lookup），从 *EmployeeRow* 中删除 [LookupScript] 特性。

```cs
[ConnectionKey("Northwind"), DisplayName("Employees"), InstanceName("Employee"), TwoLevelCached]
[ReadPermission(Northwind.PermissionKeys.General)]
[ModifyPermission(Northwind.PermissionKeys.General)]
public sealed class EmployeeRow : Row, IIdRow, INameRow, IMultiTenantRow
{
    //...
```

并在 *EmployeeRow.cs* 旁边的 *EmployeeLookup* 文件添加一个新的检索：

```cs

namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Employee")]
    public class EmployeeLookup : 
        MultiTenantRowLookupScript<EmployeeRow>
    {
    }
}
```

由于基类会帮我们处理所有的事情，我们没有重写任何东西。默认情况下，行的 *LookupScript* 特性使用 *RowLookupScript* 作为基类定义一个新的自动检索脚本类。  

由于没有办法重写每行的基类，我们显式定义检索脚本类，并使用 *MultiTenantRowLookupScript* 作为基类。

现在如果你生成并运行应用程序，你将得到一个错误：

```
'MultiTenancy.Northwind.Entities.EmployeeRow' type doesn't have a 
[LookupScript] attribute, so it can't be used with a LookupEditor!
```

这是由于我们的行类前面没有 [LookupScript] 特性，但是在一些像表单的地方，我们需要使用 *[LookupEditor("Northwind.Employee")]*。 

打开  *OrderRow.cs*，你将看到在 *EmployeeID* 属性上面有这个特性。把它修改为 *[LookupEditor("Northwind.Employee")]*。

我们在 *ShipperRow* 做类似的事情。删除 *LookupScript* 特性并定义下面的类： 

```cs

namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Shipper")]
    public class ShipperLookup : 
        MultiTenantRowLookupScript<ShipperRow>
    {
    }
}
```

并且在 *OrderRow* 的 *ShipVia* 属性上面你将找到另一个相似的 LookupEditor 特性。把它修改为 [LookupEditor("Northwind.Shipper")]。 

在 *ProductRow* 重复同样的步骤。

```cs

namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Product")]
    public class ProductLookup : MultiTenantRowLookupScript<ProductRow>
    {
    }
}
```

在 *OrderDetailRow* 的 *ProductID* 属性上面你将找到另一个相似的 LookupEditor 特性。把它修改为 [LookupEditor("Northwind.Product")]。

*Supplier*, *Category*, *Region*, *Territory* 是下一个需要做类似处理的类。请查看 Serenity 教程的 github 仓库提交日志。 

现在 Northwind 支持多租户。

> 可能有一些被我忽略了的小问题，如果发现任何问题，请在 Serenity 的 Github 仓库中的提交报告。

> 如果大家对多租户应用程序有足够的兴趣，该功能可能会被集成到 Serenity。