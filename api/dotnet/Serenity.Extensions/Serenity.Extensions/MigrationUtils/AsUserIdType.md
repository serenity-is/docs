# MigrationUtils.AsUserIdType method

Sets the column type based on the UserEntityOptions.IdFieldType, which can be Int32Field, Int64Field, StringField, or GuidField.

```csharp
public static ICreateTableColumnOptionOrWithColumnSyntax AsUserIdType(
    this ICreateTableColumnAsTypeSyntax syntax, IOptions<UserEntityOptions>? userEntityOptions)
```

| parameter | description |
| --- | --- |
| syntax | The column syntax to set the type for. |
| userEntityOptions | User entity options, will default to Int32Field if null. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Thrown when the UserEntityOptions.IdFieldType is not supported. |

## See Also

* class [UserEntityOptions](../../../Serenity.Net.Services/Serenity.Data/UserEntityOptions.md)
* class [MigrationUtils](../MigrationUtils.md)