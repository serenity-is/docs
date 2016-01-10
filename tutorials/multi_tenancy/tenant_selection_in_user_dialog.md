# Tenant Selection in User Dialog

We added a *TenantId* field to *Users* table, but it's not defined in UserRow, and not visible in user dialog.

This field, should only be seen and edited by *admin* user. Other users, even if we give them access to users page to manage their tenant users, shouldn't be able to see or change this information.

Let's first add it to *UserRow*:

```cs

```

