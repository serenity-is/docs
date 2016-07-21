# IUserRetrieveService 接口

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

当 Serenity 需要使用给定的用户名或者用户 ID 访问 IUserDefinition 对象时，它需要使用该接口。

```cs
public interface IUserRetrieveService
{
    IUserDefinition ById(string id);
    IUserDefinition ByUsername(string username);
}
```

在你的实现中，缓存用户定义对象是一个好主意，因为通常 WEB 应用程序的同一用户可能重复使用此接口。

Serenity 基本应用程序示例已经有该接口的实现，如：

```cs
public class UserRetrieveService : IUserRetrieveService
{
    private static MyRow.RowFields fld { get { return MyRow.Fields; } }

    private UserDefinition GetFirst(IDbConnection connection, BaseCriteria criteria)
    {
        var user = connection.TrySingle<Entities.UserRow>(criteria);
        if (user != null)
            return new UserDefinition
            {
                UserId = user.UserId.Value,
                Username = user.Username,
                //...
            };

        return null;
    }

    public IUserDefinition ById(string id)
    {
        if (id.IsEmptyOrNull())
            return null;

        return TwoLevelCache.Get<UserDefinition>("UserByID_" + id, CacheExpiration.Never, CacheExpiration.OneDay, fld.GenerationKey, () =>
        {
            using (var connection = SqlConnections.NewByKey("Default"))
                return GetFirst(connection,
                    new Criteria(fld.UserId) == id.TryParseID32().Value);
        });
    }

    public IUserDefinition ByUsername(string username)
    {
        if (username.IsEmptyOrNull())
            return null;

        return TwoLevelCache.Get<UserDefinition>("UserByName_" + username, CacheExpiration.Never, CacheExpiration.OneDay, fld.GenerationKey, () =>
        {
            using (var connection = SqlConnections.NewByKey("Default"))
                return GetFirst(connection, new Criteria(fld.Username) == username);
        });
    }
}
```
