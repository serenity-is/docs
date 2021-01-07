# Invariants.TryParseID method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to converts an ID's string representation to its numerical ID value (Int64).Unlike String), `null`, empty string and all other invalid strings results in Int64 value (not an exception).

```csharp
public static long? TryParseID(this string str)
```

| parameter | description |
| --- | --- |
| str | String representation of an ID. |

## Return Value

Numerical ID value or Null.Int64 if null, empty, or invalid string.

## See Also

* class [Invariants](../Invariants.md)