# Throttler.Check method

Records an attempt and checks whether the throttling limit has been exceeded.

```csharp
public bool Check()
```

## Return Value

`true` if the attempt is within the allowed limit; `false` if throttled.

## See Also

* class [Throttler](../Throttler.md)