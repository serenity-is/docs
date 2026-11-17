# RequestHandlerExtensions.GetTimeZoneInfo method

Finds the time zone of a list request, see [`TimeZone`](../ListRequest/TimeZone.md).

```csharp
public static TimeZoneInfo? GetTimeZoneInfo(this ListRequest request)
```

| parameter | description |
| --- | --- |
| request | The list request. |

## Return Value

The time zone, or null when the request has none.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | There is no time zone with the ID of the request. |

## See Also

* class [ListRequest](../ListRequest.md)
* class [RequestHandlerExtensions](../RequestHandlerExtensions.md)