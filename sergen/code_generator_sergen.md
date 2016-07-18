# 代码生成器 (Sergen)

Sergen 有一些额外的配置选项，你可以通过解决方案目录下的配置文件（Serenity.CodeGenerator.config）设置。

这是所有的配置选项：

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

Connections、RootNamespace、WebProjectFile、ScriptProjectFile、GenerateSSImports、GenerateSSTypings 和 GenerateTSCode 都可在用户界面中设置，所以我们将重点放在其他配置选项。


### KDiff3 路径

Sergen 在有需要时会尝试启动 KDiff3 把更改合并到现有文件。这也会发生在当再次尝试为实体生成代码时，Sergen 将执行 KDiff3，而不是重写目标文件。

Sergen 在其默认路径 C:\Program Files\Kdiff3 查找 KDiff3，但是如果你把 Kdiff3 安装在其它位置，可以使用该配置选项重写这个路径。

### TFSIntegration 和 TFPath

对于使用 TFS 的用户，Sergen 提供此配置选项让其可以检出现有文件及添加新项目到源代码控制。如果你的项目是在 TFS，则把 TFSIntegration 设置为 true ；如果 tf.exe 不在其默认位置 C:\Program Files\Visual Studio\x.y\Common7\ide\，则设置 TFPath。


```json
{
  // ...
  "TFSIntegration": true,
  "TFPath": "C:\Program Files\....\tf.exe"
}
```

### RemoveForeignFields

默认情况下，Sergen 会检查表的外键，并生成一个含所有外键表字段的行类。

有时，你可能有一些外键表字段，例如一些像 InsertUserId、UpdateDate 等对另一行没有用的日志字段。

你也可以在生成代码后手动删除它们，但使用此配置选项可能更容易，因为只需在字符串数组中列出想要在生成行中删除的字段即可：

```json
{
  // ...
  "RemoveForeignFields": ["InsertUserId", "UpdateUserId", 
      "InsertDate", "UpdateDate"]
}
```

请注意，这并不会从表的行类删除这些字段，它只从外键联接中删除这些视图字段。


### BaseRowClasses

如果你使用一些基行类（base row class），例如，类似 Serene 中的 LoggingRow 类。你可能想让 Sergen 生成继承自这些基行类（base row class）的类。

若要实现此目标，需要列出基类和其字段。

```json
{
  // ...
  "BaseRowClasses": [{
      "ClassName": "Serene.Administration.LoggingRow",
      "Fields": ["InsertUserId", "UpdateUserId", 
          "InsertDate", "UpdateDate"]
  }]     
}
```

如果 Sergen 确定表已经有数组 "Fields" 列出的所有字段，它将把 "ClassName" 设置为基类，而并不会在行中显式生成这些字段，因为它们已经在基行类（base row class）中定义。

也可以定义多个基行类（base row class）。如果行字段匹配多个基类，Sergen 将选择匹配字段最多的基行类。







