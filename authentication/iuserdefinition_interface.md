# IUserDefinition Interface

[**namespace**: *Serenity*, **assembly**: *Serenity.Core*]

Most applications store some common information about a user, like ID, display name (nick / fullname), email address etc. Serenity provides a basic interface to access this information in an application independent manner.

```cs
public interface IUserDefinition
{
    string Id { get; }
    string Username { get; }
    string DisplayName { get; }
    string Email { get; }
    Int16 IsActive { get;  }
}
```

Your application should provide a class that implements this interface, but not all of this information is required by Serenity itself. Id, Username and IsActive properties are minimum required.

`Id` can be an integer, string or GUID that uniquely identifies a user.

`Username` should be a unique username, but you can use e-mail addresses as username too.

`IsActive` should return 1 for active users, -1 for deleted users (if you don't delete users from database), and 0 for temporarily disabled (account locked) users.

`DisplayName` and `Email` are optional and currently not used by Serenity itself, though your application may require them.
