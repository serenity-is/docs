# MigrationUtils.UserIdForeignKey&lt;TNext,TNextFk&gt; method

Sets the foreign key for a user ID column based on the UserEntityOptions, linking it to the "Users" table and "UserId" column.

```csharp
public static TNextFk UserIdForeignKey<TNext, TNextFk>(
    this IColumnOptionSyntax<TNext, TNextFk> syntax, 
    IOptions<UserEntityOptions>? userEntityOptions, string foreignKeyName)
    where TNext : IFluentSyntax
    where TNextFk : IFluentSyntax
```

| parameter | description |
| --- | --- |
| TNext | TNext |
| TNextFk | TNextFk |
| syntax | The column option syntax |
| userEntityOptions | User entity options |
| foreignKeyName | Foreign key name |

## Return Value

The column option syntax with the foreign key applied

## See Also

* class [UserEntityOptions](../../../Serenity.Net.Services/Serenity.Data/UserEntityOptions.md)
* class [MigrationUtils](../MigrationUtils.md)