# IUserRetrieveService Interface

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

When Serenity needs to access IUserDefinition object for a given user name or user ID, it uses this interface.

```cs
public interface IUserRetrieveService
{
    IUserDefinition ById(string id);
    IUserDefinition ByUsername(string username);
}
```

In your implementation, it is a good idea to cache user definition objects, as a common WEB application might use this interface repeatedly for same user.

Serenity Basic Application sample has an implementation like below:

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
