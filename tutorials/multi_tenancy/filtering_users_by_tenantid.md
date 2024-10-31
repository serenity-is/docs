# Filtering Users By TenantId

We first need to load and cache user tenant information in `UserDefinition`. Then we need to add user tenant information in User Claims.

Open `UserDefinition.cs` under `/Modules/Common/AppServices/Models/` and add a `TenantId` property.

```cs
namespace MovieTutorial;

[Serializable]
public class UserDefinition : IUserDefinition, IHasPassword
{
    public string Id { get { return UserId.ToInvariant(); } }
    public string DisplayName { get; set; }
    public string Email { get; set; }
    public string UserImage { get; set; }
    public short IsActive { get; set; }
    public int UserId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string PasswordSalt { get; set; }
    public string Source { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? LastDirectoryUpdate { get; set; }
    public bool HasPassword => PasswordSalt != "unassigned";
    public int TenantId { get; set; }
}
```

This class is returned when retrieving the current user via the `GetUserDefinition` method.

We must also update the code responsible for loading this class. Navigate to the `/Modules/Common/AppServices/` directory, open `UserRetrieveService.cs`, and modify the `ToUserDefinition` method as shown below:

```cs
using MyRow = MovieTutorial.Administration.UserRow;

namespace MovieTutorial.AppServices;
public class UserRetrieveService(ITwoLevelCache cache, ISqlConnections sqlConnections)
    : BaseUserRetrieveService<MyRow>(cache, sqlConnections)
{
    protected override UserDefinition ToUserDefinition(MyRow user)
    {
        return new UserDefinition
        {
            UserId = user.UserId.Value,
            Username = user.Username,
            Email = user.Email,
            UserImage = user.UserImage,
            DisplayName = user.DisplayName,
            IsActive = user.IsActive.Value,
            Source = user.Source,
            PasswordHash = user.PasswordHash,
            PasswordSalt = user.PasswordSalt,
            UpdateDate = user.UpdateDate,
            LastDirectoryUpdate = user.LastDirectoryUpdate,
            TenantId = user.TenantId.Value
        };
    }
}
```

Next, we need to add the tenant ID claim to the user.

Create a new class `TenantUserClaimCreator` in the `/Modules/Common/AppServices/` folder.

```cs
using System.Security.Claims;

namespace MovieTutorial.AppServices;

public class TenantUserClaimCreator(IUserRetrieveService userRetriever) : DefaultUserClaimCreator(userRetriever)
{
    protected override void AddClaims(ClaimsIdentity identity, IUserDefinition userDefinition)
    {
        base.AddClaims(identity, userDefinition);
        identity.AddClaim(new Claim("TenantId", (userDefinition as UserDefinition).TenantId.ToString()));
    }
}
```

Register this class in `Startup.cs` file.

```cs
//...
services.AddSingleton<IUserPasswordValidator, AppServices.UserPasswordValidator>();
services.AddSingleton<IUserClaimCreator, AppServices.TenantUserClaimCreator>();
services.AddUserProvider<AppServices.UserAccessor, AppServices.UserRetrieveService>();
//...
```

To access the tenant ID claim, create an extension method for the `ClaimsPrincipal` class as shown below:

```cs
using System.Security.Claims;

namespace MovieTutorial;

public static class ClaimsPrincipalExtensions
{
    public static int? GetTenantId(this ClaimsPrincipal user)
    {
        ArgumentNullException.ThrowIfNull(user);

        var tenantClaim = user.Claims.FirstOrDefault(x => x.Type == "TenantId");
        if (tenantClaim is null)
            throw new NullReferenceException("TenantId claim not found");

        return int.Parse(tenantClaim.Value);
    }
}

```
Now, it is necessary to filter the listed users by `TenantId`. Navigate to the `/Modules/Administration/User/RequestHandlers/` directory, locate the `UserListHandler.cs` file, and modify it as shown below:

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
}
```

First, retrieve the tenant ID from the logged-in user's claims. Then, apply a filter to the users based on the tenant ID. In this implementation, all users must have a `TenantId` value; otherwise, an exception will be thrown.

We check whether the user has tenant administration permissions, which are typically reserved for admin. If the user does not possess this permission, the listed records are filtered by `TenantId`.
