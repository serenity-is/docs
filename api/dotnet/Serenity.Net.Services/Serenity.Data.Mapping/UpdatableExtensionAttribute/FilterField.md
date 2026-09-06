# UpdatableExtensionAttribute.FilterField property

Name of a field in extension table that will be filtered in extension table in addition to key. For example, if you have a CustomerAddresses table, and your join condition is T0.CustomerID = ca.CustomerID and ca.AddressType = 'Billing', your FilterField is AddressType and your FilterValue is 'Billing'

```csharp
public string FilterField { get; set; }
```

## See Also

* class [UpdatableExtensionAttribute](../UpdatableExtensionAttribute.md)