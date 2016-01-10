# Generating Code for Tenants Table

Launch *Sergen* and generate code for *Tenants* table in *Default* connection:

![Tenants Table](img/sergen_tenant.png)

Next we'll define a lookup script in *TenantRow* and set InstanceName property to *Tenant*:

```cs

namespace MultiTenancy.Administration.Entities
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
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

//...
```

