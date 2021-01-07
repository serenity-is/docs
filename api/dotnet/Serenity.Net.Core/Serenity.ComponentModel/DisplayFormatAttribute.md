# DisplayFormatAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the display format for a column. This has no effect on editors! It is only for Display, "NOT Editing". For editing, you have to change UI culture.

Display format strings are specific to column data and formatter type.

If column is a Date or DateTime column, its default formatter accepts custom DateTime format strings like "dd/MM/yyyy". We don't suggest setting DisplayFormat for dates explicitly, use UI culture setting in Web.config unless a column has to display date/time in a different order than the default. You may also use following standard format strings: - "d": "dd/MM/yyyy" where DMY order changes based on current UI culture. - "g": "dd/MM/yyyy HH:mm" where DMY order changes based on current UI culture. - "G": "dd/MM/yyyy HH:mm:ss" where DMY order changes based on current UI culture. - "s": "yyydd-MM-ddTHH:mm:ss" ISO sortable date time format. - "u": "yyydd-MM-ddTHH:mm:ss.fffZ" ISO 8601 UTC.

If column is an integer, double or decimal it accepts.NET custom numeric format strings like "#,##0.00", "0.#"

```csharp
[AttributeUsage(AttributeTargets.All)]
public class DisplayFormatAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [DisplayFormatAttribute](DisplayFormatAttribute/DisplayFormatAttribute.md)(…) | Initializes a new instance of the [`DisplayFormatAttribute`](DisplayFormatAttribute.md) class. |
| [Value](DisplayFormatAttribute/Value.md) { get; } | Gets the display format value. |

## Remarks

public class SomeColumns { [DisplayFormat("d")] public DateTime DateWithCultureDMYOrder { get; set; } [DisplayFormat("dd/MM/yyyy")] public DateTime DateWithConstantDMYOrder { get; set; } [DisplayFormat("g")] public DateTime DateTimeToMinWithCultureDMYOrder { get; set; } [DisplayFormat("dd/MM/yyyy HH:mm")] public DateTime DateTimeToMinConstantDMYOrder { get; set; } [DisplayFormat("G")] public DateTime DateTimeToSecWithCultureDMYOrder { get; set; } [DisplayFormat("dd/MM/yyyy HH:mm:ss")] public DateTime DateTimeToSecWithConstantDMYOrder { get; set; } [DisplayFormat("s")] public DateTime SortableDateTime { get; set; } [DisplayFormat("u")] public DateTime ISO8601UTC { get; set; } [DisplayFormat("#,##0.00")] public Decimal ShowTwoZerosAfterDecimalWithGrouping { get; set; } [DisplayFormat("0.00")] public Decimal ShowTwoZerosAfterDecimalNoGrouping { get; set; } }

## See Also

* **Source:** *[DisplayFormatAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Formatting/DisplayFormatAttribute.cs)*