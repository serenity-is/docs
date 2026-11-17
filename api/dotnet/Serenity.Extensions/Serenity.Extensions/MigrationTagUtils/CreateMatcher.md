# MigrationTagUtils.CreateMatcher method

Creates a function that can be assigned to `IMigrationRunnerConventions.TypeHasMatchingTags` to match migrations by dimensions.

```csharp
public static Func<Type, IEnumerable<string>, bool> CreateMatcher()
```

## Return Value

The tag matching function.

## See Also

* class [MigrationTagUtils](../MigrationTagUtils.md)