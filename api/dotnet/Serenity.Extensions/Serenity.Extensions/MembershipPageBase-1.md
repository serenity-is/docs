# MembershipPageBase&lt;TUserRow&gt; class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Base class for membership pages that provides common helpers for password hashing, salt generation, and user lookup.

```csharp
public abstract class MembershipPageBase<TUserRow> : Controller
    where TUserRow : class, IRow, IIdRow, IEmailRow, IPasswordRow, new()
```

## Public Members

| name | description |
| --- | --- |
| static [GetDeterministicHashCode](MembershipPageBase-1/GetDeterministicHashCode.md)(…) | Computes a deterministic hash code for the specified string. |

## Protected Members

| name | description |
| --- | --- |
| [MembershipPageBase](MembershipPageBase-1/MembershipPageBase.md)() | The default constructor. |
| virtual [CalculateHash](MembershipPageBase-1/CalculateHash.md)(…) | Calculates the SHA-512 hash of the password combined with the salt. |
| virtual [Error](MembershipPageBase-1/Error.md)(…) | Returns a validation error view with the specified message. |
| virtual [GenerateSalt](MembershipPageBase-1/GenerateSalt.md)(…) | Generates a random salt of the configured size. |
| virtual [GetConnectionKey](MembershipPageBase-1/GetConnectionKey.md)() | Gets the connection key for the user row type. |
| virtual [GetNonceFor](MembershipPageBase-1/GetNonceFor.md)(…) | Gets a nonce value for the specified user based on its update/insert date and password fields. |

## See Also

* interface [IRow](../Serenity.Net.Services/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Services/../Serenity.Data/IIdRow.md)
* interface [IEmailRow](../Serenity.Net.Services/../Serenity.Data/IEmailRow.md)
* interface [IPasswordRow](../Serenity.Net.Services/../Serenity.Data/IPasswordRow.md)
* **Source:** *[MembershipPageBase.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/common-features/src/extensions/Modules/Membership/MembershipPageBase.cs)*