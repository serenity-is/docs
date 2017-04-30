# Removing Tenant Dropdown From User Form

After you rebuild, and launch, now user page will be like this:

![Tenant2 Logged In](img/tenant2_filtered.png)

Yes, he can't see admin user anymore, but something is wrong. When you click *tenant2*, nothing will happen and you'll get an error *"Can't load script data: Lookup.Administration.Tenant*" in browser console:

This error is not related to our recent filtering at repository level. It can't load this lookup script, because current user has no permission to *Tenants* table. But how did he see it last time (in one case)? 

He could see it, because we first logged in as *admin* and when we open edit dialog for user, we loaded this lookup script. Browser cached it, so when we logged in with *tenant2* and open edit dialog, it loaded tenants from browser cache. 

But this time, as we rebuild project, browser tried to load it from server, and we got this error, as *tenant2* doesn't have this permission. It's ok, we don't want him to have this permission, but how to avoid this error?

We need to remove *Tenant* field from the user form. But we need that field for *admin* user, so we can't simply delete it from *UserForm.cs*. Thus, we need to do it conditionally.

Luckily, Serenity provides field level permissions:


Transform all T4 files, then open *MultiTutorial.Web/Modules/Administration/ User/UserDialog.ts* and override *getPropertyItems* method like below:

```ts
namespace Serene.Administration {

    @Serenity.Decorators.registerClass()
    export class UserDialog extends Serenity.EntityDialog<UserRow, any> {
        //...
        
        protected getPropertyItems() {
            let items = super.getPropertyItems();
            if (!Authorization.hasPermission("Administration:Tenants"))
                items = items.filter(x => x.name != UserRow.Fields.TenantId);
            return items;
        }
    }
```

> For Serenity < 2.0:
> Transform all T4 files, then open *UserDialog.cs* and override *GetPropertyItems* method like below:
>
>
>```cs
>namespace MultiTenancy.Administration
>{
>    using jQueryApi;
>    using Serenity;
>    using System.Collections.Generic;
>    using System.Linq;
>
>    //...
>    public class UserDialog : EntityDialog<UserRow>
>    {
>        //...
>        protected override List<PropertyItem> GetPropertyItems()
>        {
>            var items = base.GetPropertyItems();
>
>            if (!Authorization.HasPermission("Administration:Tenants"))
>                items = items.Where(x => 
>                    x.Name != UserRow.Fields.TenantId).ToList();
>
>            return items;
>        }
>    }
>}
>```

*GetPropertyItems* is the method, dialog gets its list of form fields, from server side form definition. Here fields are read from *UserForm* we defined server side.

If user doesn't have tenant administration permission, we remove the *TenantId* field from form definition at client side.

This doesn't modify the actual form definition, it just removes *TenantId* field for this dialog instance.

Now it is possible to edit tenant2 user by himself.

> Some users report that this also removes tenant selection for admin user. Make sure your HasPermission method in Authorization.cs of MultiTenancy.Script project is like below:

>```cs
>public static bool HasPermission(string permissionKey)
>{
>   return 
>        UserDefinition.Username == "admin" ||
>        UserDefinition.Permissions[permissionKey];
>}
>```