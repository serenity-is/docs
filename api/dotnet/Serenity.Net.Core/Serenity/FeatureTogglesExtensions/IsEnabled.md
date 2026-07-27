# FeatureTogglesExtensions.IsEnabled method (1 of 3)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets if a feature is enabled

```csharp
public static bool IsEnabled(this IFeatureToggles featureToggles, Enum feature)
```

| parameter | description |
| --- | --- |
| featureToggles | Feature toggles |
| feature | Feature enum |

## See Also

* interface [IFeatureToggles](../../Serenity.Abstractions/IFeatureToggles.md)
* class [FeatureTogglesExtensions](../FeatureTogglesExtensions.md)

---

# FeatureTogglesExtensions.IsEnabled method (2 of 3)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets if a set of features are enabled, requiring all to be enabled

```csharp
public static bool IsEnabled(this IFeatureToggles featureToggles, IEnumerable<string> features)
```

| parameter | description |
| --- | --- |
| featureToggles | Feature toggles |
| features | Features |

## See Also

* interface [IFeatureToggles](../../Serenity.Abstractions/IFeatureToggles.md)
* class [FeatureTogglesExtensions](../FeatureTogglesExtensions.md)

---

# FeatureTogglesExtensions.IsEnabled method (3 of 3)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets if a set of features are enabled, requiring just one to be enabled if requireAny is true

```csharp
public static bool IsEnabled(this IFeatureToggles featureToggles, IEnumerable<string> features, 
    bool requireAny)
```

| parameter | description |
| --- | --- |
| featureToggles | Feature toggles |
| features | Features |
| requireAny | Require any (true) or all (false) feature |

## See Also

* interface [IFeatureToggles](../../Serenity.Abstractions/IFeatureToggles.md)
* class [FeatureTogglesExtensions](../FeatureTogglesExtensions.md)