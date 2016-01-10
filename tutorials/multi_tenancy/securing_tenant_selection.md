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