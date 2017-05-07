# Handling Lookup Scripts

If we open _Suppliers_ page now, we'll see that _tenant2_ can only see suppliers that belongs to its tenant. But on top right of the grid, in country dropdown, all countries are listed:

![Tenant2 All Countries](img/tenant2_all_countries.png)

This data is feed to script side through a dynamic script. It doesn't load this data with _List_ services we handled recently.

The lookup script that produces this dropdown is defined in _SupplierCountryLookup.cs_:

```csharp
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

> We couldn't use a simple \[LookupScript\] attribute on a row class here, because there is actually no country table in Northwind database. We are collecting country names from existing records in Supplier table using distinct.

We should filter its query by current tenant.

But this lookup class derives from _RowLookupScript_ base class. Let's create a new base class, to prepare for other lookup scripts that we'll have to handle later.

```csharp
namespace MultiTenancy.Northwind.Scripts
{
    using Administration;
    using Serenity;
    using Serenity.Data;
    using Serenity.Web;
    using System;

    public class MultiTenantRowLookupScript<TRow> : 
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

This will be our base class for multi-tenant lookup scripts.

We first set expiration to a negative timespan to disable caching. Why do we have to do this? Because dynamic script manager caches lookup scripts by their keys. But we'll have multiple versions of a lookup script based on TenantId values.

We'll turn off caching at dynamic script manager level and handle caching ourself in GetScript method. In _GetScript_ method, we are using _TwoLevelCache.GetLocalStoreOnly_ to call base method, that generates our lookup script, and cache its result with a cache key including _TenantId_.

> See relevant section for more info about TwoLevelCache class.

By overriding, _PrepareQuery_ method, we are adding a filter by current _TenantId_, just like we did in list service handlers.

Now its time to rewrite our _SupplierCountryLookup_ using this new base class:

```csharp
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

We just called _AddTenantFilter_ method manually, because we weren't calling base _PrepareQuery_ method here \(so it won't be called by base class\).

> Please first delete _Northwind.DynamicScripts.cs_ file, if you have it.

There are several more similar lookup scripts in _CustomerCountryLookup_, _CustomerCityLookup_,  
_OrderShipCityLookup_, _OrderShipCountryLookup_. I'll do similar changes in them. Change base class to _MultiTenantRowLookupScript_ and call _AddTenantFilter_ in _PrepareQuery_ method.

## Lookup Script Declarations On Rows

We now have one more problem to solve. If you open _Orders_ page, you'll see that _Ship Via_ and _Employee_ filter dropdowns still lists records from other tenants. It is because we defined their lookup scripts by a \[LookupScript\] attribute on their rows.

By default, LookupScript generates a lookup instance based on `RowLookupScript<>` type. We need to change it to `MultiTenantRowLookupScript<>` for these multi-tenant rows.

Let's fix employee lookup first. Replace \[LookupScript\] attribute like below in _EmployeeRow_.

```csharp
[LookupScript("Northwind.Employee", 
 LookupType = typeof(MultiTenantRowLookupScript<>))]
public sealed class EmployeeRow : Row, IIdRow, INameRow, IMultiTenantRow
{
    //...
```

> Note that this requires Serenity 2.9.22+

Do similar (add LookupType) for _Shipper_, _Product_, _Supplier_, _Category_, _Region_ and _Territory_ rows.

Now Northwind supports multi-tenancy.

> There might be some glitches i missed, report in Serenity Github repository if any.



