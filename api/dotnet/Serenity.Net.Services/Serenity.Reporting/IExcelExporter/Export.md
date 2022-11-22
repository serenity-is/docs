# IExcelExporter.Export method (1 of 3)
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

```csharp
public byte[] Export(IEnumerable data, IEnumerable<ReportColumn> columns)
```

## See Also

* class [ReportColumn](../ReportColumn.md)
* interface [IExcelExporter](../IExcelExporter.md)

---

# IExcelExporter.Export method (2 of 3)
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Exports the specified data to Excel format

```csharp
public byte[] Export(IEnumerable data, Type columnsType)
```

| parameter | description |
| --- | --- |
| data | The data. |
| columnsType | The columns type that will be used to determine report columns to export. |

## See Also

* interface [IExcelExporter](../IExcelExporter.md)

---

# IExcelExporter.Export method (3 of 3)
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Exports the specified data to Excel format

```csharp
public byte[] Export(IEnumerable data, Type columnsType, IEnumerable<string> exportColumns)
```

| parameter | description |
| --- | --- |
| data | The data. |
| columnsType | The columns type that will be used to determine available report columns to export. |
| exportColumns | Determines the names and order of columns to be exported |

## See Also

* interface [IExcelExporter](../IExcelExporter.md)