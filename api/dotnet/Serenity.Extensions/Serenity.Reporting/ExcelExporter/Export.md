# ExcelExporter.Export method (1 of 3)

Exports the specified data with the given columns to Excel bytes.

```csharp
public byte[] Export(IEnumerable data, IEnumerable<ReportColumn> columns)
```

| parameter | description |
| --- | --- |
| data | The data to export. |
| columns | The report columns. |

## Return Value

The generated Excel file bytes.

## See Also

* class [ReportColumn](../../../Serenity.Net.Services/Serenity.Reporting/ReportColumn.md)
* class [ExcelExporter](../ExcelExporter.md)

---

# ExcelExporter.Export method (2 of 3)

Exports the specified data using the columns defined by the given type.

```csharp
public byte[] Export(IEnumerable data, Type columnsType)
```

| parameter | description |
| --- | --- |
| data | The data to export. |
| columnsType | The type defining the report columns. |

## Return Value

The generated Excel file bytes.

## See Also

* class [ExcelExporter](../ExcelExporter.md)

---

# ExcelExporter.Export method (3 of 3)

Exports the specified data using the columns defined by the given type, limited to the specified columns.

```csharp
public byte[] Export(IEnumerable data, Type columnsType, IEnumerable<string> exportColumns)
```

| parameter | description |
| --- | --- |
| data | The data to export. |
| columnsType | The type defining the report columns. |
| exportColumns | The subset of columns to export. |

## Return Value

The generated Excel file bytes.

## See Also

* class [ExcelExporter](../ExcelExporter.md)