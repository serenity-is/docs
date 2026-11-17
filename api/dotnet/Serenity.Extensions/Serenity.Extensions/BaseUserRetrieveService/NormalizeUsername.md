# BaseUserRetrieveService.NormalizeUsername method

Gets the normalized form of the specified username, which allows looking it up and comparing it case insensitively, without depending on the collation of the database. This is the value to store in the field provided by [`INormalizedUsernameRow`](../INormalizedUsernameRow.md).

```csharp
public static string NormalizeUsername(string username)
```

| parameter | description |
| --- | --- |
| username | The username. |

## Return Value

The normalized username.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *username* is null. |

## Remarks

ToUpperInvariant leaves the Turkish dotless ı and dotted İ as they are, so they are folded to I first. A migration that fills in the normalized values of existing users with SQL should apply the same rule.

## See Also

* class [BaseUserRetrieveService](../BaseUserRetrieveService.md)