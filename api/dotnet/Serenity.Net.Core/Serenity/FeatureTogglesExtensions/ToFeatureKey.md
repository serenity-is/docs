# FeatureTogglesExtensions.ToFeatureKey method

Converts a feature (enum or string) to feature key string

```csharp
public static string ToFeatureKey(object feature)
```

| parameter | description |
| --- | --- |
| feature | Feature enum or string |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Feature is null |
| ArgumentException | Feature is not a string or enum |

## See Also

* class [FeatureTogglesExtensions](../FeatureTogglesExtensions.md)