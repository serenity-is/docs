# StringHelper.IsTrimmedSame method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Compares two strings ignoring whitespace at the left or right.

```csharp
public static bool IsTrimmedSame(this string string1, string string2)
```

| parameter | description |
| --- | --- |
| string1 | String 1. |
| string2 | String 2. |

## Return Value

If two strings are same trimmed, true

## Remarks

`null` is considered to be empty.Warning: "\n" (line end), "\t" (tab) and some other are also considered as whitespace). To see a list see Trim function.This function can be used to compare a string entered by user to the value in the database for equality.

## See Also

* class [StringHelper](../StringHelper.md)