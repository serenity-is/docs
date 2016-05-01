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

