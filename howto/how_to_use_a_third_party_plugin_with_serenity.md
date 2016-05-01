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


### Using Our New Editor

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


### Populating Editor With Lookup Items

If you now build your project and open a Customer dialog, you'll see an empty SELECT in place of Customer representatives field.

Let's first fill it with data:

```ts
export class BSMultiSelectEditor {
    constructor(element: JQuery, opt: BSMultiSelectOptions) {
        super(element, opt);
        
        let lookup = Q.getLookup(this.options.lookupKey) as Q.Lookup<any>;
        for (let item of lookup.get_items()) {
            let key = item[lookup.get_idField()];
            let text = item[lookup.get_textField()] || '';
            Q.addOption(element, key, text);
        }        
    }
```

We first get a reference to lookup object specified by our *lookupKey* option.

Lookups has idField and textField properties, which usually corresponds to fields determined by IIdRow and INameRow interfaces on your lookup row.

We enumerate all items in lookup and determine key and text properties of those items, using idField and textField properties.

Now save file, and open Customer dialog again. You'll see that this time options are filled.


### Bootstrap Multi Select Typings


According to documentation we should now call ".multiselect()" jQuery extension on our select element.

I would cast our SELECT element to `<any>` and call .multiselect on it, but i want to write a TypeScript .d.ts definition file to reuse multiselect with intellisense.

So, under MyProject.Web/Scripts/typings/bsmultiselect folder, create a file,* bsmultiselect.d.ts*

```ts
interface JQuery {
    multiselect(options?: BSMultiSelectOptions | string): JQuery;
}

interface BSMultiSelectOptions {
    multiple?: boolean;
    includeSelectAllOption?: boolean;
    selectAllText?: string;
    selectAllValue?: string | number;
}
```

Here, i have extended JQuery interface which belongs to jQuery itself and is defined in jquery.d.ts. In TypeScript you can extend any interface with new methods, properties etc.

I used plugin documentation to define BSMultiSelectOptions. The plugin actually has much more options, but for now i keep it short.


### Creating Bootstrap MultiSelect on Our Editor

Now i'll go back to our constructor and initialize a multiselect plugin on it:

```ts
export class BSMultiSelectEditor {
    constructor(element: JQuery, opt: BSMultiSelectOptions) {
        super(element, opt);
        
        let lookup = Q.getLookup(this.options.lookupKey) as Q.Lookup<any>;
        for (let item of lookup.get_items()) {
            let key = item[lookup.get_idField()];
            let text = item[lookup.get_textField()] || '';
            Q.addOption(element, key, text);
        }        
        
        element.attr('multiple', 'multiple')
            .attr('name', this.uniqueName + "[]")
            .multiselect();     
    }
```

Open CustomerDialog and you'll see that Representatives has our bootstrap multi select editor.

### Handling GetEditValue and SetEditValue Method

If we don't handle these methods, Serenity won't know how to read or set your editor value, so even if you select some representatives, next time you open the dialog, you'll have empty selections.


```ts
export class BSMultiSelectEditor {
//...

public setEditValue(source: any, property: Serenity.PropertyItem): void {
    this.element.val(source[property.name] || []).multiselect('refresh');
}

public getEditValue(property: Serenity.PropertyItem, target: any): void {
    target[property.name] = this.element.val() || [];
}
```

setEditValue is called when editor value needs to be setted. It takes a *source* object, which is usually your entity being loaded in a dialog.

Property parameter is a PropertyItem object that contains details about the field being handled, e.g. our Representatives property. It's *name* field contains field name, e.g. *Representatives*.

Here we have to call multiselect('refresh') after setting select value, as multiselect plugin can't know when selections are changed.

getEditValue is opposite. It should read edit value and set it in target entity.

Ok, now our custom editor should be working fine.