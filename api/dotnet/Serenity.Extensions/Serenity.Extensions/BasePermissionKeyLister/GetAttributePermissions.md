# BasePermissionKeyLister.GetAttributePermissions&lt;TAttr&gt; method (1 of 2)
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Gets permissions from a member attribute.

```csharp
protected virtual IEnumerable<string> GetAttributePermissions<TAttr>(MemberInfo member, 
    Func<TAttr, string> getPermission)
    where TAttr : Attribute
```

| parameter | description |
| --- | --- |
| TAttr | Attribute type |
| member | Member |
| getPermission | Permission callback |

## See Also

* class [TAttr](../Serenity.Extensions/../BasePermissionKeyLister.TAttr.md)
* class [BasePermissionKeyLister](../BasePermissionKeyLister.md)

---

# BasePermissionKeyLister.GetAttributePermissions&lt;TAttr&gt; method (2 of 2)
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Gets permissions from a type attribute.

```csharp
protected virtual IEnumerable<string> GetAttributePermissions<TAttr>(Type type, 
    Func<TAttr, string> getPermission)
    where TAttr : Attribute
```

| parameter | description |
| --- | --- |
| TAttr | Attribute type |
| type | Type |
| getPermission | Permission callback |

## See Also

* class [TAttr](../Serenity.Extensions/../BasePermissionKeyLister.TAttr.md)
* class [BasePermissionKeyLister](../BasePermissionKeyLister.md)