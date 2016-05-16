# Code Generator (Sergen)

Sergen has some extra options that you may set through its configuration file (Serenity.CodeGenerator.config) in your solution directory.

Here is the full set of options:

```cs
public class GeneratorConfig
{
    public List<Connection> Connections { get; set; }
    public string KDiff3Path { get; set; }
    public string TFPath { get; set; }
    public string TSCPath { get; set; }
    public bool TFSIntegration { get; set; }
    public string WebProjectFile { get; set; }
    public string ScriptProjectFile { get; set; }
    public string RootNamespace { get; set; }
    public List<BaseRowClass> BaseRowClasses { get; set; }
    public List<string> RemoveForeignFields { get; set; }
    public bool GenerateSSImports { get; set; }
    public bool GenerateTSTypings { get; set; }
    public bool GenerateTSCode { get; set; }
}
```

Connections, RootNamespace, WebProjectFile, ScriptProjectFile, GenerateSSImports, GenerateSSTypings and GenerateTSCode options are all available in user interface, so we'll focus on other options.


### KDiff3 Path

Sergen tries to launch KDiff3 when it needs to merge changes to an existing file. This might happen when you try to generate code for an entity again. Instead of overriding target files, Sergen will execute KDiff3.

Sergen looks for KDiff3 at its default location under C:\Program Files\Kdiff3, but you may override this path with this option, if you installed Kdiff3 to another location.

### TFSIntegration and TFPath

For users that work with TFS, Sergen provides this options to make it possible to checkout existing files and add new ones to source control. Set TFSIntegration to true, if your project is versioned in TFS, and set TFPath if tf.exe is not under its default location at C:\Program Files\Visual Studio\x.y\Common7\ide\


### RemoveForeignFields

By default, Sergen examines your table foreign keys, and when generating a row class, it will bring all fields from all referenced foreign tables.

Sometimes, you might have some fields in foreign tables, e.g. some logging fields like InsertUserId, UpdateDate etc. that wouldn't be useful in another row.

You'd be able to remove them manually after code generation too, but using this option it might be easier. List fields you want to remove from generated rows as an array of string:

```json
{
  // ...
  "RemoveForeignFields": ["InsertUserId", "UpdateUserId", "InsertDate", "UpdateDate"]
}
```

Note that this doesn't remove this fields from table row itself, it only removes these view fields from foreign joins.


### BaseRowClasses

If you are using some base row class, e.g. something like LoggingRow in Serene, you might want Sergen to generate your rows deriving from these base classes.

For this to work, list your base classes, and the fields they have.

```json
{
  // ...
  "BaseRowClasses": [{
      "ClassName": "Serene.Administration.LoggingRow",
      "Fields": ["InsertUserId", "UpdateUserId", "InsertDate", "UpdateDate"]
  }]     
}
```

If Sergen determines that a table has all fields listed in "Fields" array, it will set its base class as "ClassName", and will not generate these fields explicity in row, as they are already defined in base row class.

It is possible to define more than one base row class. Sergen will choose the base row class with most matching fields, if a row's fields matches more than one base class.







