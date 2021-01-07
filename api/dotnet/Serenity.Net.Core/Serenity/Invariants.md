# Invariants class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Invariant culture related constants and formats.

```csharp
public static class Invariants
```

## Public Members

| name | description |
| --- | --- |
| static readonly [DateTimeFormat](Invariants/DateTimeFormat.md) | Date time format information for invariant culture |
| static readonly [NumberFormat](Invariants/NumberFormat.md) | Number format information for invariant culture |
| static [IDString](Invariants/IDString.md)(…) | Converts an ID value, to its string representation. |
| static [IsIntegerType](Invariants/IsIntegerType.md)(…) | Determines whether type of the value is an integer type (Int16, Int32, Int64). Avoid using this function as it is obsolete. |
| static [ToInvariant](Invariants/ToInvariant.md)(…) | Converts value to string using invariant culture. (4 methods) |
| static [TryParseID](Invariants/TryParseID.md)(…) | Tries to converts an ID's string representation to its numerical ID value (Int64).Unlike String), `null`, empty string and all other invalid strings results in Int64 value (not an exception). |
| static [TryParseID32](Invariants/TryParseID32.md)(…) | Tries to converts an ID's string representation to its numerical ID value (Int64).Unlike String), `null`, empty string and all other invalid strings results in Int64 value (not an exception). |

## See Also

* **Source:** *[Invariants.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Helpers/Invariants.cs)*