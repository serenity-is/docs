# SqlHelper.NewCommand method (1 of 2)

Creates a new command.

```csharp
public static IDbCommand NewCommand(IDbConnection connection, string commandText)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |

## Return Value

A new command with the specified command text.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection is null. |

## See Also

* class [SqlHelper](../SqlHelper.md)

---

# SqlHelper.NewCommand method (2 of 2)

Creates a new command.

```csharp
public static IDbCommand NewCommand(IDbConnection connection, string commandText, 
    IDictionary<string, object> param)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| commandText | The command text. |
| param | The parameters. |

## Return Value

A new command with the specified command text and parameters.

## See Also

* class [SqlHelper](../SqlHelper.md)