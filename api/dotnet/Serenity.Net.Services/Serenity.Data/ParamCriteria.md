# ParamCriteria class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A criteria object containing a parameter name

```csharp
public class ParamCriteria : BaseCriteria
```

| parameter | description |
| --- | --- |
| name | The parameter name. Should start with @. |

## Public Members

| name | description |
| --- | --- |
| [ParamCriteria](ParamCriteria/ParamCriteria.md)(…) | A criteria object containing a parameter name |
| [Name](ParamCriteria/Name.md) { get; } | Gets the parameter name including the @ symbol. |
| override [ToString](ParamCriteria/ToString.md)(…) | Converts the criteria to string. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | name is null or empty |
| ArgumentOutOfRangeException | name doesn't start with "@", or has nothing but whitespace after it. |

## Remarks

Initializes a new instance of the [`ParamCriteria`](./ParamCriteria.md) class.

## See Also

* class [BaseCriteria](./BaseCriteria.md)
* **Source:** *[ParamCriteria.cs](https://github.com/serenity-is/Serenity/blob/489f72f785a9733fa81e465e1a3854209296a6c0/src/services/Data/Criteria/ParamCriteria.cs)*