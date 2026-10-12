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
| [Field](Criteria/Field.md) { get; } | Gets a reference to the [`IField`](./IField.md) object passed to the constructor. |
| override [IsEmpty](Criteria/IsEmpty.md) { get; } | Gets whether the criteria is empty. |
| override [ToString](Criteria/ToString.md)(…) | Converts the criteria to its string representation while adding its parameters to the target query. |
| static readonly [Empty](Criteria/Empty.md) | An empty criteria instance. |
| static readonly [False](Criteria/False.md) | The false criteria instance (0 = 1). |
| static readonly [True](Criteria/True.md) | The true criteria instance (1 = 1). |
| static [EscapeLikeWildcards](Criteria/EscapeLikeWildcards.md)(…) | Escapes a literal value for use in a LIKE pattern with the given escape character. The escape character itself is escaped first, then %, _ and [. A ] outside a [...] class is literal on all supported dialects, so it is left as is. The result must be used with ESCAPE 'x' declared (see [`LikeEscapeChar`](./BinaryCriteria/LikeEscapeChar.md)), otherwise the escape character matches itself instead of escaping. |
| static [Exists](Criteria/Exists.md)(…) | Creates a new EXISTS criteria. (3 methods) |

## See Also

* class [BaseCriteria](./BaseCriteria.md)
* **Source:** *[Criteria.cs](https://github.com/serenity-is/Serenity/blob/4e74ef07ee730ccce4277f699f3dcbe3d85bb083/src/services/Data/Criteria/Criteria.cs)*