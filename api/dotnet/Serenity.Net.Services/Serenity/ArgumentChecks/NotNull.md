# ArgumentChecks.NotNull&lt;T&gt; method (1 of 2)

Throws an ArgumentNullException if *argument* is null, otherwise returns it.

```csharp
public static T NotNull<T>(T? argument, string? paramName = null)
```

| parameter | description |
| --- | --- |
| T | Type of the argument. |
| argument | Argument to check. |
| paramName | Automatically populated with the caller's expression, e.g. `"request.Entity"`, using CallerArgumentExpressionAttribute. |

## Return Value

The non-null *argument*.

## See Also

* class [ArgumentChecks](../ArgumentChecks.md)

---

# ArgumentChecks.NotNull&lt;T&gt; method (2 of 2)

Type of the argument.Argument to check.Automatically populated with the caller's expression, e.g. `"request.Id"`, using CallerArgumentExpressionAttribute.The non-null *argument*.

```csharp
public static T NotNull<T>(T? argument, string? paramName = null)
    where T : struct
```

## See Also

* class [ArgumentChecks](../ArgumentChecks.md)