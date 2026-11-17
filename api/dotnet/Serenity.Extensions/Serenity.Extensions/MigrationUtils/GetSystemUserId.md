# MigrationUtils.GetSystemUserId method

Gets the ID of the user that rows inserted by migrations are attributed to, e.g. as their `InsertUserId`, from SystemUserId.

```csharp
public static object GetSystemUserId(this IOptions<UserEntityOptions>? userEntityOptions)
```

| parameter | description |
| --- | --- |
| userEntityOptions | User entity options, will default to `1` if null. |

## Return Value

The system user ID.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Thrown when the user ID type has no default and SystemUserId is not set. |

## See Also

* class [UserEntityOptions](../../../Serenity.Net.Services/Serenity.Data/UserEntityOptions.md)
* class [MigrationUtils](../MigrationUtils.md)