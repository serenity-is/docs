# 使用 TenantId 筛选用户 

我们首先需要在 UserDefinition 加载并缓存租户用户。

打开 *Multitenancy.Web/ Modules/ Administration/ User/ Authentication* 下的 *UserDefinition.cs*，并添加 *TenantId* 属性。  

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

当你通过 *Authorization.UserDefinition* 请求当前用户时，该类被返回。 

我们也需要在类被加载的地方修改代码。在同一文件夹编辑 *UserRetrieveService.cs*，并修改 *GetFirst*： 

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

现在，是时候使用 *TenantId* 过滤并列出用户。打开 *UserRepository.cs*，定位到 *MyListHandler* 类做如下修改：  

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

在这里，我们先获得当前登录用户的缓存用户定义。

我们检查该用户是否有租户管理权限，该权限只被授予给 *admin* 。如果没有，我们使用 *TenantId* 过滤列表记录。
