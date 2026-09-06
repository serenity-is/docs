# Criteria class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An object that is used to create criteria by employing the operator overloading features of the C# language, instead of using string based criteria.

```csharp
public class Criteria : BaseCriteria
```

## Public Members

| name | description |
| --- | --- |
| [Criteria](Criteria/Criteria.md)(…) | Creates a new criteria with the given condition. This condition is usually a field name, but it can also be a pre-generated criteria text. (10 constructors) |
| static [Bracket](Criteria/Bracket.md)(…) | Creates a new criteria containing the field name in brackets. |
| [Expression](Criteria/Expression.md) { get; } | Gets the criteria expression. |
| override [IsEmpty](Criteria/IsEmpty.md) { get; } | Gets whether the criteria is empty. |
| override [ToString](Criteria/ToString.md)(…) | Converts the criteria to its string representation while adding its parameters to the target query. |
| static [Field](Criteria/Field.md) { get; } | Gets a reference to the [`IField`](./IField.md) object passed to the constructor. |
| static readonly [Empty](Criteria/Empty.md) | An empty criteria instance. |
| static readonly [False](Criteria/False.md) | The false criteria instance (0 = 1). |
| static readonly [True](Criteria/True.md) | The true criteria instance (1 = 1). |
| static [Exists](Criteria/Exists.md)(…) | Creates a new EXISTS criteria. (2 methods) |

## See Also

* class [BaseCriteria](./BaseCriteria.md)
* **Source:** *[Criteria.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Criteria/Criteria.cs)*