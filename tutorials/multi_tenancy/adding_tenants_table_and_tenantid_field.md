# Adding Tenants Table and TenantId Field

To ensure tenant isolation, we need to add a `TenantId` field to all relevant tables.

First, we will create a `Tenants` table.

Since the MovieDB already contains records, we will define a primary tenant with ID 1 and assign this `TenantId` to all existing records.

We will now create a migration for the Default database.

`DefaultDB_20221230_134800_MultiTenant.cs`:

```csharp
using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20221230_134800)]
public class DefaultDB_20221230_134800_MultiTenant : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId32("Tenants", "TenantId", s => s
            .WithColumn("TenantName").AsString(100)
                .NotNullable());

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
```

We have created the Tenants table in the Default database, where the user tables reside. Here, we add three predefined tenants, although only the first one with ID 1 is necessary.

We did not add the `TenantId` column to tables such as `UserPermissions`, `UserRoles`, and `RolePermissions`, as they inherently contain `TenantId` information through their `UserId` or `RoleId` (since these tables already have `TenantId` values).

Next, we will create another migration for the MovieDB tables to add the `TenantId` column:

`DefaultDB_20170430_194100_MovieDB_MultiTenant.cs`:

```csharp
using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20221230_194100)]
public class DefaultDB_20221230_194100_MovieDB_MultiTenant : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Person")
            .AddColumn("TenantId").AsInt32()
                .NotNullable().WithDefaultValue(1);

        Alter.Table("Genre")
            .AddColumn("TenantId").AsInt32()
                .NotNullable().WithDefaultValue(1);

        Alter.Table("Movie")
            .AddColumn("TenantId").AsInt32()
                .NotNullable().WithDefaultValue(1);
    }
}
```