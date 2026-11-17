# ListQueryCaptureExtensions.GetPostQueryOverrides method

Gets the names of the methods of a list handler, looking through the sync / async wrappers, that run after its query is executed and that the handler overrides, e.g. `ProcessEntity` or `OnReturn`. As they don't run when the query is captured, a filter they apply, e.g. by dropping rows, would not take effect, so a consumer may refuse to capture the query of such a handler unless told that it filters only in its query. It doesn't check the list behaviors of the handler.

```csharp
public static IReadOnlyList<string> GetPostQueryOverrides(this IListRequestHandler handler)
```

| parameter | description |
| --- | --- |
| handler | List handler |

## Return Value

The names of the overridden methods, empty if there are none.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *handler* is null. |

## See Also

* interface [IListRequestHandler](../IListRequestHandler.md)
* class [ListQueryCaptureExtensions](../ListQueryCaptureExtensions.md)