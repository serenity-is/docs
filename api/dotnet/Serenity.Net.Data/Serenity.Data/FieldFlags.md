# FieldFlags enumeration
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Flags that determine basic properties of a field

```csharp
[Flags]
public enum FieldFlags
```

## Values

| name | value | description |
| --- | --- | --- |
| None | `0x0` | No flags set. |
| Internal | `0x0` | Internal fields are equal to no flags set. |
| Insertable | `0x1` | Can a value be set on INSERT? Server side calculated fields (like identity) shouldn't have this flag. |
| Updatable | `0x2` | Can it be set on UPDATE? Server side calculated fields (like identity) shouldn't have this flag. |
| NotNull | `0x4` | Can it have a null or empty value? |
| PrimaryKey | `0x8` | Field is a member of primary key. |
| AutoIncrement | `0x10` | Auto incrementing field. |
| Foreign | `0x20` | It is a field originating from another table through a join. e.g. view field. |
| Calculated | `0x40` | Calculated field. |
| Reflective | `0x80` | Just reflects another field value (e.g. negative/absolute version of it), so doesn't have client and server side storage of its own, and setting it just sets another field. |
| ClientSide | `0x100` | Field which is just a container to use in client side code (might also be client side calculated / reflective). |
| NotMapped | `0x100` | Property which is not mapped to a SQL field / expression. |
| Trim | `0x200` | Should be trimmed (empty string as null) before setting its value. |
| TrimToEmpty | `0x600` | Should be trimmed to (null to empty string) before setting its value. |
| DenyFiltering | `0x800` | Deny filtering on this field. |
| Unique | `0x1000` | Values should be unique. |
| Default | `0x203` | These are default flags unless specified otherwise. Insertable, updatable and nullable and trimmed (to null). |
| Required | `0x207` | Default flags with NotNull included. |
| Identity | `0x1C` | An identity primary key field with auto incrementing value. |

## See Also

* **Source:** *[FieldFlags.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/FieldFlags.cs)*