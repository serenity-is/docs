# Removing Tenant Dropdown From User Form

After you rebuild, and launch, now user page will be like this:

![Tenant2 Logged In](img/tenant2_filtered.png)

Yes, he can't see admin user anymore, but something is wrong. When you click *tenant2*, nothing will happen and you'll get an error *"Can't load script data: Lookup.Administration.Tenant*" in browser console:

This error is not related to our recent filtering at repository level. It can't load this lookup script, because current user has no permission to *Tenants* table. But how did he see it last time (in one case)? 

He could see it, because we first logged in as *admin* and when we open edit dialog for user, we loaded this lookup script. Browser cached it, so when we logged in with *tenant2* and open edit dialog, it loaded tenants from browser cache. 

But this time, as we rebuild project, browser tried to load it from server, and we got this error, as *tenant2* doesn't have this permission. It's ok, we don't want him to have this permission, but how to avoid this error?

We need to remove *Tenant* field from the user form. But we need that field for *admin* user, so we can't simply delete it from *UserForm.cs*. Thus, we need to do it conditionally.

Luckily, Serenity provides field level permissions. Edit *UserRow.cs* to let only users with *Administration:Tenants* permission to see and edit tenant information.

```cs
[LookupEditor(typeof(TenantRow))]
[ReadPermission(PermissionKeys.Tenants)]
public Int32? TenantId
{
    get { return Fields.TenantId[this]; }
    set { Fields.TenantId[this] = value; }
}
```

Now only *admin* can see and update *tenant* field for users.

But still, *tenant2* can't open the user dialog, why?

Even though *TenantId* field is hidden in user form, it's editor is still there (invisible) and it tries to load *tenant* lookup (this is something we might try to handle in later versions).

