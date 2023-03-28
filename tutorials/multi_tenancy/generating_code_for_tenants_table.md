# Generating Code for Tenants Table

Launch *Sergen* and generate code for *Tenants* table in *Default* connection:

- Connection: **Default**
- Table Name: **dbo.Tenants**
- Module Name: **Administration**
- Identifier: **Tenant**
- Permission Key: **Administration:Tenants**

Next we'll define a lookup script in *TenantRow* and set DisplayName property to *Tenants*:

```csharp
namespace MultiTenancy.Administration
{
    //...
    [ConnectionKey("Default"), DisplayName("Tenants"), 
     InstanceName("Tenant"), TwoLevelCached]
    [LookupScript("Administration.Tenant")]
    public sealed class TenantRow : Row, IIdRow, INameRow
    {
        [DisplayName("Tenant Id"), Identity]
        public Int32? TenantId
        {
            get => Fields.TenantId[this];
            set => Fields.TenantId[this] = value;
        }

//...
```

Let's define a Administration:Tenants permission that only *admin* user will have (in _AdministrationPermissionKeys.cs_):

```csharp
namespace MultiTenancy.Administration
{
    [NestedPermissionKeys]
    [DisplayName("Administration")]
    public class PermissionKeys
    {
        [Description("User, Role Management and Permissions")]
        public const string Security = "Administration:Security";

        [Description("Languages and Translations")]
        public const string Translation = "Administration:Translation";

        [Description("Tenant Management")]
        public const string Tenants = "Administration:Tenants";
    }
}
```

And use it on TenantRow:

```csharp
[ConnectionKey("Default"), DisplayName("Tenants"), 
 InstanceName("Tenant"), TwoLevelCached]
[ReadPermission(PermissionKeys.Tenants)]
[ModifyPermission(PermissionKeys.Tenants)]
[LookupScript("Administration.Tenant")]
public sealed class TenantRow : Row, IIdRow, INameRow
{

```
