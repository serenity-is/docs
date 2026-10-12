# ListResponse&lt;T&gt;.Values property

List of distinct values, if DistinctFields are passed in the list request. Values for each distinct row are appended in the requested field order. When multiple fields are requested, the list is flat and values are not grouped into tuples.

```csharp
public List<object?>? Values { get; set; }
```

## See Also

* class [ListResponse&lt;T&gt;](../ListResponse-1.md)