# 添加租户（Tenants）表和 TenantId 字段

为了租户间相互独立，我们需要把 TenantId 字段添加到所有表中。

因此，我们先添加一个租户（Tenants）表。

因为 Northwind 表已经有记录，我们将定义一个 ID 为 1 的主租户，并把所有现有记录的 TenantId 设为该值。

现在是时候写迁移类，实际上有两个迁移类：一个是 Northwind ，另一个是 Default 数据库。

**DefaultDB_20160110_092200_MultiTenant.cs:**

```cs
using FluentMigrator;

namespace MultiTenancy.Migrations.DefaultDB
{
    [Migration(20160110092200)]
    public class DefaultDB_20160110_092200_MultiTenant 
        : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Tenants")
                .WithColumn("TenantId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("TenantName").AsString(100)
                    .NotNullable();

            Insert.IntoTable("Tenants")
                .Row(new
                {
                    TenantName = "Primary Tenant"
                });

            Insert.IntoTable("Tenants")
                .Row(new
                {
                    TenantName = "Second Tenant"
                });

            Insert.IntoTable("Tenants")
                .Row(new
                {
                    TenantName = "Third Tenant"
                });

            Alter.Table("Users")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Roles")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Languages")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
        }
    }
}
```

我已经在用户（user）表所在的 Default 数据库创建租户（Tenants）表，并在该表添加 3 个预定义的租户。实际上我们只需要 ID 为 *1* 的第一个租户。

我们没有在一些表（如 UserPermissions、UserRoles、RolePermissions 等）添加 TenantId 列，因为他们可以通过 UserId 或 RoleId 获取 TenantId 信息。

**NorthwindDB_20160110_093500_MultiTenant.cs:**

```cs
using FluentMigrator;

namespace MultiTenancy.Migrations.NorthwindDB
{
    [Migration(20160110093500)]
    public class NorthwindDB_20160110_093500_MultiTenant 
        : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Employees")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Categories")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Customers")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Shippers")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Suppliers")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Orders")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Products")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Region")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Territories")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
        }
    }
}
```