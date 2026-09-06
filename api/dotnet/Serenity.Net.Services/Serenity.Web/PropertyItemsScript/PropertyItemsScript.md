# PropertyItemsScript constructor

Abstract base class for [`ColumnsScript`](../ColumnsScript.md) and [`FormScript`](../FormScript.md).

```csharp
protected PropertyItemsScript(string scriptName, Type type, IPropertyItemProvider propertyProvider, 
    IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| scriptName | The script name. |
| type | The columns or form type. |
| propertyProvider | The property item provider. |
| serviceProvider | The service provider. |

## Remarks

Creates a new instance of the class.

## See Also

* interface [IPropertyItemProvider](../../Serenity.PropertyGrid/IPropertyItemProvider.md)
* class [PropertyItemsScript](../PropertyItemsScript.md)