# ICriteria interface
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Shared criteria interface

```csharp
public interface ICriteria
```

## Members

| name | description |
| --- | --- |
| [IsEmpty](ICriteria/IsEmpty.md) { get; } | Gets a value indicating whether this criteria instance is empty. |
| [ToString](ICriteria/ToString.md)(…) | Converts the criteria to string representation while adding params to the target query. (2 methods) |
| [ToStringIgnoreParams](ICriteria/ToStringIgnoreParams.md)() | Converts the criteria to string while ignoring its params if any. ToString() raises an exception if a criteria has params, while this not. |

## See Also

* **Source:** *[ICriteria.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/QueryModel/ICriteria.cs)*