# BaseUserRetrieveService.NormalizeEmail method

Gets the normalized form of the specified email, using the same rule as [`NormalizeUsername`](./NormalizeUsername.md). This is the value to store in the field provided by [`INormalizedEmailRow`](../INormalizedEmailRow.md).

```csharp
public static string? NormalizeEmail(string? email)
```

| parameter | description |
| --- | --- |
| email | The email. |

## Return Value

The normalized email, or null if *email* is null.

## See Also

* class [BaseUserRetrieveService](../BaseUserRetrieveService.md)