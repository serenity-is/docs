# ListRequestCapabilities enumeration
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Specifies the capabilities of a list request handler.

```csharp
[Flags]
public enum ListRequestCapabilities
```

## Values

| name | value | description |
| --- | --- | --- |
| None | `0x0` | No list operations are handled by the source. |
| ContainsText | `0x1` | The source applies ContainsText. |
| ContainsField | `0x2` | The source applies ContainsField together with ContainsText. |
| EqualityFilter | `0x4` | The source applies EqualityFilter. |
| Criteria | `0x8` | The source applies Criteria. |
| FilteringOptions | `0xF` | Combined text-search, equality-filter, and criteria options. |
| Sort | `0x10` | The source applies sorting. |
| Skip | `0x20` | The source applies Skip. |
| Take | `0x40` | The source applies Take. |
| IncludeDeleted | `0x80` | The source applies IncludeDeleted. |
| ColumnSelection | `0x100` | The source applies ColumnSelection. |
| IncludeColumns | `0x200` | The source applies IncludeColumns. |
| ExcludeColumns | `0x400` | The source applies ExcludeColumns. |
| ColumnOptions | `0x700` | Combined column-selection, include-column, and exclude-column options. |
| DistinctFields | `0x800` | The source applies DistinctFields. |
| ExportColumns | `0x1000` | The source applies ExportColumns. |
| Localize | `0x2000` | The source applies Localize. |
| ExcludeTotalCount | `0x4000` | The source honors ExcludeTotalCount. |
| IncludeMore | `0x8000` | The handler supports the IncludeMore request option. |
| PagingOptions | `0xC060` | Combined paging options, including the IncludeMore option. |
| SourceAdapter | `0xC87F` | Capabilities supported by the in-memory list request source adapter by default. |
| Baseline | `0xFFFF` | Fixed set of baseline capabilities. This value will not be expanded with future capabilities added to `ListRequest` or `ListRequestHandler` implementations. |
| All | `0xFFFF` | Currently equivalent to Baseline. May include capabilities added to `ListRequest` and `ListRequestHandler` implementations in the future. |

## See Also

* **Source:** *[ListRequestCapabilities.cs](https://github.com/serenity-is/Serenity/blob/7942b778cba1362623aa070554117a88735f249a/src/core/ComponentModel/Services/ListRequestCapabilities.cs)*