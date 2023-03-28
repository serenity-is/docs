# Filtering Users By TenantId

We first need to load and cache user tenant information in UserDefinition. Then we need to add user tenant information in User Claims.

Open *UserDefinition.cs* under *Multitenancy.Web/Modules/Administration/User/Authentication* and add a *TenantId* property.

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

This is the class that is returns when you ask for current user through *GetUserDefinition*.

We also need to modify the code where this class is loaded. In the same folder, edit *UserRetrieveService.cs* and change *GetFirst* method like below:

```cs
private UserDefinition GetFirst(IDbConnection connection, BaseCriteria criteria)
{
    var user = connection.TrySingle<MyRow>(criteria);
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

And then add the tenant id claim to the *CreatePrincipal* method.

```cs
public static ClaimsPrincipal CreatePrincipal(IUserRetrieveService userRetriever, string username, string authType)
{
    if (userRetriever is null)
        throw new ArgumentNullException(nameof(userRetriever));

    if (username is null)
        throw new ArgumentNullException(nameof(username));

    var user = (UserDefinition)userRetriever.ByUsername(username);
    if (user == null)
        throw new ArgumentOutOfRangeException(nameof(username));

    if (authType == null)
        throw new ArgumentNullException(nameof(authType));

    var identity = new GenericIdentity(username, authType);
    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
    identity.AddClaim(new Claim("TenantId", user.TenantId.ToInvariant())); // add tenant id claim

    return new ClaimsPrincipal(identity);
}
```

To access the tenant id claim, we can create an extension method for ClaimsPrincipal class like this:

```cs
using System;
using System.Linq;
using System.Security.Claims;

namespace MultiTenancy
{
    public static class ClaimsPrincipalExtensions
    {
        public static int GetTenantId(this ClaimsPrincipal user)
        {
            if(user is null)
                throw new ArgumentNullException(nameof(user));

            var tenantClaim = user.Claims.FirstOrDefault(x => x.Type == "TenantId");
            if (tenantClaim is null)
                throw new NullReferenceException("TenantId claim not found");

            return int.Parse(tenantClaim.Value);
        }
    }
}
```

Now, it's time to filter listed users by *TenantId*. Open *UserListHandler.cs*, locate *UserListHandler* class and modify it like this:

```cs
 public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void ApplyFilters(SqlQuery query)
        {
            base.ApplyFilters(query);

            if (Permissions.HasPermission(PermissionKeys.Tenants))
                return;

            query.Where(MyRow.Fields.TenantId == User.GetTenantId());
        }
        //...
    }
```

Here, we first get tenant id from the logged user claims. Then we filter the users by tenant id. In this case, all users must have `TenantId` value, otherwise an exception will throw.

We check if he has tenant administration permission, which only *admin* will have in the end. If not, we filter listed records by *TenantId*.
