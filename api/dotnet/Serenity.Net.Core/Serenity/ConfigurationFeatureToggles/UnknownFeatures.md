# ConfigurationFeatureToggles.UnknownFeatures property

Gets the names of the features that were queried, but were not declared anywhere, so they are most likely due to a typo in a feature key or a missing declaration. They are disabled when `disableUnknown` is `true`, and reported in either case, so it is a good idea to log them at startup. Note that this only keeps the keys that were queried, and is meant for diagnostics, not as a registry.

```csharp
public IEnumerable<string> UnknownFeatures { get; }
```

## See Also

* class [ConfigurationFeatureToggles](../ConfigurationFeatureToggles.md)