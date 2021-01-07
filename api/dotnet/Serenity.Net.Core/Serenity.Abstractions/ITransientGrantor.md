# ITransientGrantor interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Interface for permission services that supports granting permissions temporarily

```csharp
public interface ITransientGrantor
```

## Members

| name | description |
| --- | --- |
| [Grant](ITransientGrantor/Grant.md)(…) | Grants specified permissions temporarily (or makes it look like) |
| [GrantAll](ITransientGrantor/GrantAll.md)() | Grants all permissions temporarily (or makes it look like) |
| [UndoGrant](ITransientGrantor/UndoGrant.md)() | Undoes last grant or grant all operation |

## See Also

* **Source:** *[ITransientGrantor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/ITransientGrantor.cs)*