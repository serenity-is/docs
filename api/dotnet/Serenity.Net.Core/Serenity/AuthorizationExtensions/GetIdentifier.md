# AuthorizationExtensions.GetIdentifier method

Gets the value of the NameIdentifier claim from the specified principal.

```csharp
public static string? GetIdentifier(this ClaimsPrincipal? identity)
```

| parameter | description |
| --- | --- |
| identity | The principal to extract the identifier from. |

## Return Value

The identifier claim value, or `null` if the principal or claim is not present.

## See Also

* class [AuthorizationExtensions](../AuthorizationExtensions.md)