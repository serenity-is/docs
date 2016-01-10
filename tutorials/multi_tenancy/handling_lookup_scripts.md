# Handling Lookup Scripts

If we open *Suppliers* page now, we'll see that *tenant2* can only see suppliers that belongs to its tenant. But on top right of the grid, in country dropdown, all countries are listed:

![Tenant2 All Countries](img/tenant2_all_countries.png)

This data is feed to script side through a dynamic script. It doesn't load this data with *List* services we handled recently.

The lookup script that produces this dropdown is defined in *SupplierCountryLookup.cs*:

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

We should filter its query by current tenant.

But this lookup class derives from *RowLookupScript* base class. Let's create a new base class, to prepare for other lookup scripts that we'll have to handle later.

```cs
namespace MultiTenancy.Northwind.Scripts
{
    using Administration;
    using Serenity;
    using Serenity.Data;
    using Serenity.Web;
    using System;

    public abstract class MultiTenantRowLookupScript<TRow> : RowLookupScript<TRow>
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
            query.Where(r.TenantIdField == ((UserDefinition)Authorization.UserDefinition).TenantId);
        }

        public override string GetScript()
        {
            return TwoLevelCache.GetLocalStoreOnly("MultiTenantLookup:" + this.ScriptName + ":" +
                ((UserDefinition)Authorization.UserDefinition).TenantId, TimeSpan.FromHours(1),
                new TRow().GetFields().GenerationKey, () =>
                {
                    return base.GetScript();
                });
        }
    }
}