# How To: Use a Third Party Plugin With Serenity

To use a third party / custom plugin with a Serenity application involves no special steps. You may include their scripts and CSS in _LayoutHead.cshtml, and follow their documentation. 

Especially if you are using TypeScript, there are no special steps involved. 

In case of Saltaralle (which is being deprecated), you might have to write some import classes or use dynamic otherwise.

But, if you want that component to work well among other Serenity editors in dialogs, you may try wrapping it into a Serenity widget.

Here we'll take Bootstrap MultiSelect plugin as a sample, and integrate it as an editor into Serenity, similar to LookupEditor.

Here is the documentation and samples for this component:

http://davidstutz.github.io/bootstrap-multiselect/


### Getting Script and CSS Files

First we should download its script and CSS files and place them in correct places under MyProject.Web/scripts/ and MyProject.Web/content folders.

This component has a NuGet package but unfortunately it is not in a standard fashion (it doesn't place files into your project folders), so we'll have to download files manually.

Download this script file and put it under MyProject.Web/Scripts:

https://raw.githubusercontent.com/davidstutz/bootstrap-multiselect/master/dist/js/bootstrap-multiselect.js

Download this CSS file and put it under MyProject.Web/Content:

https://raw.githubusercontent.com/davidstutz/bootstrap-multiselect/master/dist/css/bootstrap-multiselect.css

### Including Script/Css Files in _LayoutHead.cshtml

According to plugin documentation, we should include these files:

```html
<!-- Include the plugin's CSS and JS: -->
<script type="text/javascript" 
  src="js/bootstrap-multiselect.js">
</script>
<link rel="stylesheet" type="text/css"/
      href="css/bootstrap-multiselect.css" />
```

Open _LayoutHead.cshtml under MyProject.Web/Views/Shared and include these files:

```html
// ...
@Html.Stylesheet("~/Content/bootstrap-multiselect.css")
@Html.Stylesheet("~/Content/serenity/serenity.css")
@Html.Stylesheet("~/Content/site/site.css")
// ...
@Html.Script("~/Scripts/bootstrap-multiselect.js")
@Html.Script("~/Scripts/Site/Serene.Script.js")
@Html.Script("~/Scripts/Site/Serene.Web.js")
```


### Creating BSMultiSelectEditor.ts

Now we need a TypeScript source file to hold our component. We should put it under MyProject.Web/Scripts or MyProject.Web/Modules directories.

I'll create it under MyProject.Web/Modules/Common/Widgets (first you need to create folder Widgets)

Create file BSMultiSelectEditor.ts at this location:

```ts
namespace MyProject {
    @Serenity.Decorators.element("<select/>")
    @Serenity.Decorators.registerClass(
        [Serenity.IGetEditValue, Serenity.ISetEditValue])
    export class BSMultiSelectEditor
        extends Serenity.Widget<BSMultiSelectOptions>
        implements Serenity.IGetEditValue, Serenity.ISetEditValue {

        constructor(element: JQuery, opt: BSMultiSelectOptions) {
            super(element, opt);
        }

        public setEditValue(source: any, 
            property: Serenity.PropertyItem): void {
        }

        public getEditValue(property: Serenity.PropertyItem, 
            target: any): void {
        }
    }

    export interface BSMultiSelectOptions {
        lookupKey: string;
    }
}
```

Here we defined a new editor type, deriving from Widget. Our widget takes options of type BSMultiSelectOptions, which contains a lookupKey option, similar to a LookupEditor. It also implements IGetEditValue and ISetEditValue TypeScript interfaces (this is different than C# interfaces)

`@Serenity.Decorators.element("<select/>")`

With above line, we specified that our widget works on a SELECT element, as this bootstrap multiselect plugin requires a select element too.

```
@Serenity.Decorators.registerClass(
    [Serenity.IGetEditValue, Serenity.ISetEditValue])
```

Above, we register our TypeScript class, with Saltaralle type system and specify that our widget implements custom value getter and setter methods, corresponding to getEditValue and setEditValue methods.

> Here syntax is a bit terse as we have to handle interop between Saltaralle and TypeScript.

Our constructor and getEditValue, setEditValue methods are yet empty. We'll fill them in soon.

Now, build your project and transform templates. 

Open CustomerRow.cs and locate Representatives property:

```cs
[LookupEditor(typeof(EmployeeRow), Multiple = true), ClientSide]
[LinkingSetRelation(typeof(CustomerRepresentativesRow), 
    "CustomerId", "EmployeeId")]
public List<Int32> Representatives
{
    get { return Fields.Representatives[this]; }
    set { Fields.Representatives[this] = value; }
}
```

Here we see that Representatives uses a LookupEditor with multiple option true. We'll replace it with our brand new editor:

```cs
[BSMultiSelectEditor(LookupKey = "Northwind.Employee"), ClientSide]
[LinkingSetRelation(typeof(CustomerRepresentativesRow), 
    "CustomerId", "EmployeeId")]
public List<Int32> Representatives
{
    get { return Fields.Representatives[this]; }
    set { Fields.Representatives[this] = value; }
}
```

