# Adding Tenants Table and TenantId Field

We need to add a TenantId field to all tables, to isolate tenants from each other.

So, we first need a Tenants table. 

As Northwind tables already have records, we'll define a primary tenant with ID 1, and set all existing records TenantId to it.

It's time to write a migration, actually two migrations, one for Northwind and one for Default database.

