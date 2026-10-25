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
| virtual [RunIf](BaseDynamicDataGenerator/RunIf.md)(…) | Runs the generator when the first argument is `dynamic-data`. |

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

* **Source:** *[BaseDynamicDataGenerator.cs](https://github.com/serenity-is/Serenity/blob/88446beca303039b3d0ead2e38f6c3b940c9df86/src/web/DynamicScript/DynamicDataGenerator/BaseDynamicDataGenerator.cs)*