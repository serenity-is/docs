# Filtering Users By TenantId

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

We also need to modify the code where this class is loaded. In the same folder, edit *UserRetrieveService.cs* and change *GetFirst* method like below:

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
