# 为租户（Tenants）生成代码 

启动 *Sergen* ，并使用 *Default* 连接为 *租户（Tenants）*表生成代码。

![Tenants Table](img/sergen_tenant.png)

然后，我们在 *TenantRow* 定义检索脚本，并把 InstanceName 属性设置为 *Tenant*：

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

让我们定义一个只有 *admin* 用户有的 Administration:Tenants 权限：

```cs
namespace MultiTenancy.Administration
{
    public class PermissionKeys
    {
        public const string Security = "Administration:Security";
        public const string Translation = "Administration:Translation";
        public const string Tenants = "Administration:Tenants";
    }
}
```

并把它设置到 TenantRow：

```cs
[ConnectionKey("Default"), DisplayName("Tenants"), InstanceName("Tenant"), TwoLevelCached]
[ReadPermission(PermissionKeys.Tenants)]
[ModifyPermission(PermissionKeys.Tenants)]
[LookupScript("Administration.Tenant")]
public sealed class TenantRow : Row, IIdRow, INameRow
{

```
