# DynamicScriptServiceCollectionExtensions.UseScriptWatching method (1 of 2)

Activates script file watching.

```csharp
public static IServiceProvider UseScriptWatching(this IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| serviceProvider | The service provider. |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)

---

# DynamicScriptServiceCollectionExtensions.UseScriptWatching method (2 of 2)

Activates script file watching.

```csharp
public static IServiceProvider UseScriptWatching(this IServiceProvider serviceProvider, 
    params string[] scriptPaths)
```

| parameter | description |
| --- | --- |
| serviceProvider | The service provider. |
| scriptPaths | The list of script paths to watch. |

## Return Value

The same service provider so that calls can be chained.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProvider* or *scriptPaths* is `null`. |
| InvalidOperationException | No script bundle manager or content hash cache is registered. |

## See Also

* class [DynamicScriptServiceCollectionExtensions](../DynamicScriptServiceCollectionExtensions.md)