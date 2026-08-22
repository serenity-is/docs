# MigrationAttributeBase constructor
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Initializes a new instance of the [`MigrationAttributeBase`](../MigrationAttributeBase.md) class.

```csharp
public MigrationAttributeBase(long version, 
    TransactionBehavior transactionBehavior = TransactionBehavior.Default, 
    string description = null)
```

| parameter | description |
| --- | --- |
| version | The migration version in yyyyMMdd_HHmm or yyyyMMdd_HHmm_ss format. |
| transactionBehavior | The transaction behavior. |
| description | The migration description. |

## Exceptions

| exception | condition |
| --- | --- |
| Exception | The version is not in a valid migration version format. |

## See Also

* class [MigrationAttributeBase](../MigrationAttributeBase.md)