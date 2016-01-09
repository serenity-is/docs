# Adding Tenants Table and TenantId Field

We need to add a TenantId field to all tables, to isolate tenants from each other.

So, we first need a Tenants table. 

As Northwind tables already has records inside, we'll define a primary tenant with ID 1, and set all existing records TenantId to it.

It's time to write a migration.

