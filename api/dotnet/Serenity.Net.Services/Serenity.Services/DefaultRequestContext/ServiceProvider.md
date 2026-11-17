# DefaultRequestContext.ServiceProvider property

Gets the services of the current request, which are looked up on each call, as the context is a singleton, or none when it is not given the IServiceProviderAccessor.

```csharp
public IServiceProvider ServiceProvider { get; }
```

## See Also

* class [DefaultRequestContext](../DefaultRequestContext.md)