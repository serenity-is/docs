# BaseCriteria class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Base criteria object type

```csharp
public abstract class BaseCriteria : ICriteria
```

## Public Members

| name | description |
| --- | --- |
| virtual [IsEmpty](BaseCriteria/IsEmpty.md) { get; } | Gets a value indicating whether this criteria instance is empty. |
| [Contains](BaseCriteria/Contains.md)(…) | Creates a new binary Contains criteria (LIKE '%...%') containing this criteria as the left operand. |
| [EndsWith](BaseCriteria/EndsWith.md)(…) | Creates a new binary Ends With (LIKE '%...') criteria containing this criteria as the left operand. |
| override [Equals](BaseCriteria/Equals.md)(…) | Must override this or will get operator overload warning. |
| override [GetHashCode](BaseCriteria/GetHashCode.md)() | Must override this or will get operator overload warning. |
| [In](BaseCriteria/In.md)(…) | Creates a new binary IN criteria containing this criteria as the left operand. (2 methods) |
| [In&lt;T&gt;](BaseCriteria/In.md)(…) | Creates a new binary IN criteria containing this criteria as the left operand. |
| [InStatement](BaseCriteria/InStatement.md)(…) | Creates a new binary IN criteria containing this criteria as the left operand. |
| [IsNotNull](BaseCriteria/IsNotNull.md)() | Creates a new unary IsNotNull criteria containing this criteria as the operand. |
| [IsNull](BaseCriteria/IsNull.md)() | Creates a new unary IsNull criteria containing this criteria as the operand. |
| [Like](BaseCriteria/Like.md)(…) | Creates a new binary Like criteria containing this criteria as the left operand. |
| [NotContains](BaseCriteria/NotContains.md)(…) | Creates a new binary Not Contains criteria (NOT LIKE '%...%') containing this criteria as the left operand. |
| [NotIn](BaseCriteria/NotIn.md)(…) | Creates a new binary NOT IN criteria containing this criteria as the left operand. (2 methods) |
| [NotIn&lt;T&gt;](BaseCriteria/NotIn.md)(…) | Creates a new binary NOT IN criteria containing this criteria as the left operand. |
| [NotLike](BaseCriteria/NotLike.md)(…) | Creates a new binary Not Like criteria containing this criteria as the left operand. |
| [StartsWith](BaseCriteria/StartsWith.md)(…) | Creates a new binary Stars With (LIKE '...%') criteria containing this criteria as the left operand. |
| override [ToString](BaseCriteria/ToString.md)() | Converts the criteria to string. Raises an exception if criteria contains parameters. |
| [ToString](BaseCriteria/ToString.md)(…) | Converts the criteria to string representation while adding params to the target query. |
| virtual [ToString](BaseCriteria/ToString.md)(…) | Converts the criteria to string representation into a string builder, while adding its params to the target query. |
| [ToStringIgnoreParams](BaseCriteria/ToStringIgnoreParams.md)() | Converts the criteria to string while ignoring its params if any. ToString() raises an exception if a criteria has params, while this not. |
| [operator &amp;](BaseCriteria/op_BitwiseAnd.md) | Implements the operator &amp;. |
| [operator &#x7C;](BaseCriteria/op_BitwiseOr.md) | Implements the operator &#x7C;. |
| [operator ==](BaseCriteria/op_Equality.md) | Implements the operator ==. (10 operators) |
| [operator ^](BaseCriteria/op_ExclusiveOr.md) | Implements the operator ^. |
| [operator false](BaseCriteria/op_False.md) | Must return FALSE from this for short circuit OR (&#x7C;&#x7C;) to return a new binary criteria merging left and right operands in any case |
| [operator &gt;](BaseCriteria/op_GreaterThan.md) | Implements the operator &gt;. (10 operators) |
| [operator &gt;=](BaseCriteria/op_GreaterThanOrEqual.md) | Implements the operator &gt;=. (10 operators) |
| [operator !=](BaseCriteria/op_Inequality.md) | Implements the operator !=. (10 operators) |
| [operator &lt;](BaseCriteria/op_LessThan.md) | Implements the operator &lt;. (10 operators) |
| [operator &lt;=](BaseCriteria/op_LessThanOrEqual.md) | Implements the operator &lt;=. (10 operators) |
| [operator !](BaseCriteria/op_LogicalNot.md) | Implements the operator !. |
| [operator ~](BaseCriteria/op_OnesComplement.md) | Implements the operator ~. |
| [operator true](BaseCriteria/op_True.md) | Must ALSO return FALSE from this for short circuit AND (&amp;&amp;) to return a new binary criteria merging left and right operands in any case https://msdn.microsoft.com/en-us/library/aa691312 |

## Protected Members

| name | description |
| --- | --- |
| [BaseCriteria](BaseCriteria/BaseCriteria.md)() | The default constructor. |

## See Also

* interface [ICriteria](../Serenity/ICriteria.md)
* **Source:** *[BaseCriteria.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Criteria/BaseCriteria.cs)*