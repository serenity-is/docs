# Securing Tenant Selection

Now signout and login with user *tenant2*.

When you open *User Management* page, you'll see that user can see and edit *admin* user, in addition to his own *tenant2* user. He can even see and edit his tenant in user dialog.

![Tenant2 Logged In](img/tenant2_logged_in.png)

This is not what we wanted.

Let's prevent him seeing users of other tenants.

We first need to load and cache user tenant information in UserDefinition.

Open *UserDefinition.cs* under *Multitenancy.Web/ Modules/ Administration/ User/ Authentication* and add a *TenantId* property.

```cs
namespace MultiTenancy.Administration
{
    using Serenity;
    using System;

    [Serializable]
    public class UserDefinition : IUserDefinition
    {
        public string Id { get { return UserId.ToInvariant(); } }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public short IsActive { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Source { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? LastDirectoryUpdate { get; set; }
        public int TenantId { get; set; }
    }
}
```

This is the class that is returned when you ask for current user through *Authorization.UserDefinition*.

We also need to modify the code wher this class is loaded. In the same folder, edit *UserRetrieveService.cs* and change *GetFirst* method like below:

```cs
private UserDefinition GetFirst(IDbConnection connection, BaseCriteria criteria)
{
    var user = connection.TrySingle<Entities.UserRow>(criteria);
    if (user != null)
        return new UserDefinition
        {
            UserId = user.UserId.Value,
            Username = user.Username,
            Email = user.Email,
            DisplayName = user.DisplayName,
            IsActive = user.IsActive.Value,
            Source = user.Source,
            PasswordHash = user.PasswordHash,
            PasswordSalt = user.PasswordSalt,
            UpdateDate = user.UpdateDate,
            LastDirectoryUpdate = user.LastDirectoryUpdate,
            TenantId = user.TenantId.Value
        };

    return null;
}

```

Now, it's time to filter listed users by *TenantId*. Open *UserRepository.cs*, locate *MyListHandler* class and modify it like this:

```cs
private class MyListHandler : ListRequestHandler<MyRow>
{
    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);

        var user = (UserDefinition)Authorization.UserDefinition;
        if (!Authorization.HasPermission(PermissionKeys.Tenants))
            query.Where(fld.TenantId == user.TenantId);
    }
}
```

Here, we first get a reference to cached user definition of currently logged user.

We check if he has tenant administration permission, which only *admin* will have in the end. If not, we filter listed records by *TenantId*.

After you rebuild, and launch, now user page will be like this:

![Tenant2 Logged In](img/tenant2_filtered.png)

Yes, he can't see admin user anymore, but something is wrong. When you click *tenant2*, nothing will happen and you'll get an error *"Can't load script data: Lookup.Administration.Tenant*":

This error is not related to our filtering. It can't load this lookup script, because current user has no permission to *Tenants* table. But how did he see it last time? 

He could see it, because we first logged in as *admin* and when we open edit dialog for user, we loaded this lookup script. Browser cached it, so when we logged in with *tenant2* and open edit dialog, it loaded tenants from browser cache. 

But this time, as we rebuild project, browser tried to load it from server, and we got this error, as *tenant2* doesn't have this permission. It's ok, we don't want him to have this permission, but how to avoid this error?

We need to remove *Tenant* field from the user form. But we need that field for *admin* user, so we can't simply delete it from *UserForm.cs*. Thus, we need to do it conditionally.

Open *UserDialog.cs* and override *GetPropertyItems* method like below:

