# BaseDynamicDataGenerator class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Base class for generating `.json` files under the `dynamic-data` folder for script testing purposes.

```csharp
public abstract class BaseDynamicDataGenerator
```

## Public Members

| name | description |
| --- | --- |
| virtual [Run](BaseDynamicDataGenerator/Run.md)() | Generates `.json` files under the `dynamic-data` folder for script testing purposes. |
| virtual [RunAndExitIf](BaseDynamicDataGenerator/RunAndExitIf.md)(…) | Checks the arguments; if they contain `dynamic-data`, runs the generator and exits the process. |

## Protected Members

| name | description |
| --- | --- |
| [BaseDynamicDataGenerator](BaseDynamicDataGenerator/BaseDynamicDataGenerator.md)() | The default constructor. |
| virtual [AddServices](BaseDynamicDataGenerator/AddServices.md)(…) | Initializes the services used by the generator. |
| virtual [GetDynamicDataFolder](BaseDynamicDataGenerator/GetDynamicDataFolder.md)() | Gets the `dynamic-data` folder. |
| virtual [GetProjectRoot](BaseDynamicDataGenerator/GetProjectRoot.md)() | Gets the project root folder. |
| virtual [GetTypeSource](BaseDynamicDataGenerator/GetTypeSource.md)() | Gets the type source. |
| virtual [InitializeScripts](BaseDynamicDataGenerator/InitializeScripts.md)(…) | Initializes the dynamic scripts. |
| virtual [ShouldSkipScript](BaseDynamicDataGenerator/ShouldSkipScript.md)(…) | Returns `true` if the script should be skipped. |

## See Also

* **Source:** *[BaseDynamicDataGenerator.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/DynamicScript/DynamicDataGenerator/BaseDynamicDataGenerator.cs)*