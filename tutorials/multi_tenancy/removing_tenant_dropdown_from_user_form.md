# Removing Tenant Dropdown From User Form

After rebuilding and launching, the user page will appear as follows:

![ _Tenant2_  Logged In](img/tenant2_filtered.png)

Although the _tenant2_ user can no longer see the _admin_ user, the previous issue still exists. When clicking on _tenant2_, the error message appears: *"Access denied while trying to load the lookup: Administration.Tenant"*.

This error is unrelated to our recent repository-level filtering. The script fails to load because the current user lacks permission to the *Tenants* table.

Previously, the _tenant2_ user could open the dialog because the browser had cached the lookup script. When we logged in as _admin_ and loaded the lookup with _admin_ rights, the lookup was cached in the browser. After logging out from _admin_ and logging in with tenant2, it loaded the tenants lookup from the browser cache.

After rebuilding the project, the browser reset the cache and attempted to load the script from the server, resulting in the error since _tenant2_ lacks the necessary permissions. This behavior is acceptable since we do not want the _tenant2_ user to have this permission, but we need to avoid this error.

To address this, we need to remove the `Tenant` field from the user form. However, since the _admin_ user requires this field, we cannot simply delete it from `UserForm.cs`. Therefore, we need to handle it conditionally.

Build the project, auto transform all, and add the following method to `UserDialog.ts`:

```ts
import { Authorization } from "@serenity-is/corelib";
//...
protected getPropertyItems() {
    var items = super.getPropertyItems();
    if (!Authorization.hasPermission("Administration:Tenants"))
        items = items.filter(x => x.name != UserRow.Fields.TenantId);
    return items;
}
```

Dialogs retrieve the list of fields to display in their form via the `getPropertyItems` method, which loads them from the server-side form definition.

Here, we exclude the `TenantId` field if the current user does not have the tenants permission.

This approach does not modify the original user form; it only alters the list for this dialog instance.

Now, the _tenant2_ user can open the user dialog without encountering the error.