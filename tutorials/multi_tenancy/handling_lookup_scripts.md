# Handling Lookup Scripts

Upon accessing the _Movie_ page, _tenant2_ will only see movies belonging to their tenant. However, when attempting to add a cast member to a movie, all persons are displayed:

![ _Tenant2_  All Countries](img/tenant2_all_peoples.png)

This data is provided to the script side through a dynamic script and does not utilize the _List_ services we handled previously.

The lookup script that generates this dropdown is defined in `PersonRow.cs`:

```csharp
namespace MovieTutorial.MovieDB;

[ConnectionKey("Default"), Module("MovieDB"), TableName("Person")]
[DisplayName("Person"), InstanceName("Person")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript] // <-- This is the definition
public sealed class PersonRow : Row<PersonRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Person Id"), Identity, IdProperty]
    public int? PersonId { get => fields.PersonId[this]; set => fields.PersonId[this] = value; }
    //...
```

> At times, it is necessary to implement custom lookup scripts to tailor data retrieval. For example, the Northwind sample `SupplierCountryLookup` class derives from the `RowLookupScript` base class. In such instances, we must appropriately handle these types of lookups.

We should filter the lookup query by the current tenant. To facilitate this, let's create a new base class in preparation for handling additional lookup scripts in the future.

```csharp
namespace MovieTutorial;

public class MultiTenantRowLookupScript<TRow> : RowLookupScript<TRow>
    where TRow : class, IRow, IMultiTenantRow, new()
{
    private readonly ITwoLevelCache twoLevelCache;
    private readonly IUserAccessor userAccessor;

    public MultiTenantRowLookupScript(ISqlConnections sqlConnections, ITwoLevelCache twoLevelCache, IUserAccessor userAccessor) : base(sqlConnections)
    {
        Expiration = TimeSpan.FromDays(-1);
        this.twoLevelCache = twoLevelCache ?? throw new ArgumentNullException(nameof(twoLevelCache));
        this.userAccessor = userAccessor ?? throw new ArgumentNullException(nameof(userAccessor));
    }

    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);
        AddTenantFilter(query);
    }

    protected void AddTenantFilter(SqlQuery query)
    {
        var r = new TRow();
        query.Where(r.TenantIdField == userAccessor.User.GetTenantId());
    }

    public override string GetScript()
    {
        return twoLevelCache.GetLocalStoreOnly(
            $"MultiTenantLookup:{this.ScriptName}:{userAccessor.User.GetTenantId()}",
            TimeSpan.FromHours(1),
            new TRow().GetFields().GenerationKey, () =>
            {
                return base.GetScript();
            });
    }
}
```

This will serve as our base class for multi-tenant lookup scripts.

Firstly, we set the expiration to a negative timespan to disable caching. This is necessary because the dynamic script manager caches lookup scripts based on their keys. However, we will have multiple versions of a lookup script determined by `TenantId` values.

We will disable caching at the dynamic script manager level and handle caching ourselves within the `GetScript` method. In the `GetScript` method, we utilize `TwoLevelCache.GetLocalStoreOnly` to invoke the base method, which generates our lookup script, and cache its result with a cache key that includes `TenantId`.

> Refer to the relevant section for more information about the `TwoLevelCache` class.

By overriding the `PrepareQuery` method, we add a filter based on the current `TenantId`, similar to the approach used in list service handlers.

Next, we will examine how to implement the Northwind sample lookup named `SupplierCountryLookup` using this new base class:

```csharp
namespace Serenity.Demo.Northwind.Lookups;

[LookupScript, Module("Northwind")]
public class SupplierCountryLookup : MultiTenantRowLookupScript<SupplierRow>
{
    public SupplierCountryLookup(ISqlConnections sqlConnections, ITwoLevelCache twoLevelCache, IUserAccessor userAccessor)
        : base(sqlConnections, twoLevelCache, userAccessor)
    {
        IdField = TextField = "Country";
    }

    protected override void PrepareQuery(SqlQuery query)
    {
        var fld = SupplierRow.Fields;
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
```

We manually invoked the `AddTenantFilter` method because we did not call the base `PrepareQuery` method, preventing it from being executed by the base class.

## Lookup Script Declarations on Rows

We now face an additional challenge with the `[LookupScript]` attribute on the rows.

By default, `LookupScript` generates a lookup instance based on the `RowLookupScript<>` type. For multi-tenant rows, we need to modify this to use `MultiTenantRowLookupScript<>`.

To resolve this, update the person lookup by replacing the `[LookupScript]` attribute as shown below in `PersonRow`.

```csharp
[ConnectionKey("Default"), Module("MovieDB"), TableName("Person")]
[DisplayName("Person"), InstanceName("Person")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript(LookupType = typeof(MultiTenantRowLookupScript<>))]
public sealed class PersonRow : Row<PersonRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
{
    //...
```
Perform a similar addition of `LookupType` for the `GenreRow`.

With these changes, MovieDB now supports multi-tenancy.

> If there are any issues that were overlooked, please report them in the Serenity GitHub repository.
