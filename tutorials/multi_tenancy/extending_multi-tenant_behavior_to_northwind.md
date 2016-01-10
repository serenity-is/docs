# Extending Multi-Tenant Behavior To Northwind

As now we have a behavior handling repository details, we just need to add *IMultiTenantRow* interface to rows and add *TenantId* property.

Start with *ProductRow.cs*:

