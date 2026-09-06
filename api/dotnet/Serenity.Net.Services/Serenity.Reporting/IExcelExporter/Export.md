# IExcelExporter.Export method (1 of 3)

Exports the specified data to Excel format using the given report columns.

```csharp
public byte[] Export(IEnumerable data, IEnumerable<ReportColumn> columns)
```

| parameter | description |
| --- | --- |
| data | The data to export. |
| columns | The columns to export. |

## Return Value

The generated Excel file content.

## See Also

* class [ReportColumn](../ReportColumn.md)
* interface [IExcelExporter](../IExcelExporter.md)

---

# IExcelExporter.Export method (2 of 3)

Exports the specified data to Excel format, deriving the report columns from a columns type.

```csharp
public byte[] Export(IEnumerable data, Type columnsType)
```

| parameter | description |
| --- | --- |
| data | The data to export. |
| columnsType | The columns type that will be used to determine report columns to export. |

## Return Value

The generated Excel file content.

## See Also

* interface [IExcelExporter](../IExcelExporter.md)

---

# IExcelExporter.Export method (3 of 3)

Exports the specified data to Excel format, deriving the report columns from a columns type and restricting the output to the given column names.

```csharp
public byte[] Export(IEnumerable data, Type columnsType, IEnumerable<string> exportColumns)
```

| parameter | description |
| --- | --- |
| data | The data to export. |
| columnsType | The columns type that will be used to determine available report columns to export. |
| exportColumns | Determines the names and order of columns to be exported. |

## Return Value

The generated Excel file content.

## See Also

* interface [IExcelExporter](../IExcelExporter.md)