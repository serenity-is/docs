# ServiceEndpointApplicationModelProvider.Order property

[ApiController] attribute model provider uses `-1000 + 100` - this needs to be applied first so that we get attribute routing. AuthorizationApplicationModelProvider uses +10 - so we're trying to split the difference here.

```csharp
public int Order { get; }
```

## See Also

* class [ServiceEndpointApplicationModelProvider](../ServiceEndpointApplicationModelProvider.md)