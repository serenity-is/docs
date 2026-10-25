# Generating Code for Tenants Table

To generate code for the *Tenants* table using *Sergen* in the *Default* connection, follow these steps:

- **Connection**: `Default`
- **Table Name**: `dbo.Tenants`
- **Module Name**: `Administration`
- **Identifier**: `Tenant`
- **Permission Key**: `Administration:Tenants`
- **What to Generate**: `All`

Next, define a lookup script in the `TenantRow` class and set the `DisplayName` property to "Tenants":

```csharp
namespace MovieTutorial.Administration;

[ConnectionKey("Default"), Module("Administration"), TableName("Tenants")]
[DisplayText("Tenant"), InstanceName("Tenant")]
[LookupScript("Administration.Tenant")]
public sealed class TenantRow : Row<TenantRow.RowFields>, IIdRow, INameRow
{
    [DisplayText("Tenant Id"), Identity, IdProperty]
    public int? TenantId { get => fields.TenantId[this]; set => fields.TenantId[this] = value; }
    //...
```

Define an `Administration:Tenants` permission that only the _admin_ user will have (in `AdministrationPermissionKeys.cs`):

```csharp
namespace MovieTutorial.Administration;

[NestedPermissionKeys]
[DisplayText("Administration")]
public class PermissionKeys
{
    [DescriptionText("User, Role Management and Permissions")]
    public const string Security = "Administration:Security";

    [DescriptionText("Languages and Translations")]
    public const string Translation = "Administration:Translation";

    [DescriptionText("Tenant Management")]
    public const string Tenants = "Administration:Tenants";
}
```

Apply this permission to `TenantRow`:

```csharp
namespace MovieTutorial.Administration;

[ConnectionKey("Default"), Module("Administration"), TableName("Tenants")]
[DisplayText("Tenant"), InstanceName("Tenant")]
[ReadPermission(PermissionKeys.Tenants)]
[ModifyPermission(PermissionKeys.Tenants)]
[ServiceLookupPermission(PermissionKeys.Tenants)]
[LookupScript("Administration.Tenant")]
public sealed class TenantRow : Row<TenantRow.RowFields>, IIdRow, INameRow
{
    //...
```
