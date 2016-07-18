# 演员和角色 

如果我们要这样保存演员和角色记录：

*Actor/Actress*|*Character *
--|--
Keanu Reeves|Neo       
Laurence Fishburne|Morpheus
Carrie-Anne Moss|Trinity

我们需要一张 演员（MovieCast） 表，其内容如：

*MovieCastId*|*MovieId*|*PersonId*|*Character*
--|--|--
...|...|...|...
11|2 (Matrix)|77 (Keanu Reeves)|Neo
12|2 (Matrix)|99 (Laurence Fisburne)|Morpheus
13|2 (Matrix)|30 (Carrie-Anne Moss)|Trinitity
...|...|...|...

很显然，我们还需要一张 人员（Person） 表，因为我们要通过其 id 关联演员信息。

> 这里用 人员（Person） 表示演员会更好，因为演员后来可能成为导演，编剧等。


### 创建 人员（Person） 和 演员（MovieCast） 表 

现在是时候创建这两张表的迁移类（migration）：

MovieTutorial.Web/Modules/Common/Migrations/DefaultDB/ DefaultDB_20160528_141600_PersonAndMovieCast.cs:

```cs
using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20151025170200)]
    public class DefaultDB_20160528_141600_PersonAndMovieCast : Migration
    {
        public override void Up()
        {
            Create.Table("Person").InSchema("mov")
                .WithColumn("PersonId").AsInt32().Identity()
                    .PrimaryKey().NotNullable()
                .WithColumn("Firstname").AsString(50).NotNullable()
                .WithColumn("Lastname").AsString(50).NotNullable()
                .WithColumn("BirthDate").AsDateTime().Nullable()
                .WithColumn("BirthPlace").AsString(100).Nullable()
                .WithColumn("Gender").AsInt32().Nullable()
                .WithColumn("Height").AsInt32().Nullable();

            Create.Table("MovieCast").InSchema("mov")
                .WithColumn("MovieCastId").AsInt32().Identity()
                    .PrimaryKey().NotNullable()
                .WithColumn("MovieId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_MovieId", "mov", "Movie", "MovieId")
                .WithColumn("PersonId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_PersonId", "mov", "Person", "PersonId")
                .WithColumn("Character").AsString(50).Nullable();
        }
                
        public override void Down()
        {
        }
    }
}
```


### 为 人员（Person） 表生成代码 

我们首先为 人员（Person） 表生成代码：

![Person Code Generation](img/mdb_sergen_person.png)


### 把 性别（Gender） 修改为枚举 

人员（Person） 表的 性别（Gender） 列应该存放枚举类型的数据，在 PersonRow.cs 所在文件夹创建文件 Gender.cs，并定义一个 Gender 枚举：

```cs
using Serenity.ComponentModel;
using System.ComponentModel;

namespace MovieTutorial.MovieDB
{
    [EnumKey("MovieDB.Gender")]
    public enum Gender
    {
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2
    }
}
```

修改 PersonRow.cs 定义的 Gender 属性，如： 

```cs
//...
        [DisplayName("Gender")]
        public Gender? Gender
        {
            get { return (Gender?)Fields.Gender[this]; }
            set { Fields.Gender[this] = (Int32?)value; }
        }
//...
```

为保持一致性，把 PersonForm.cs 和 PersonColumns.cs 的 Gender 属性类型 Int32 改为 Gender 枚举类型。


### 重新生成 T4 模板 

当我们定义并使用一个新的枚举，我们应该重新生成解决方案，以便 T4 模板重新生成内容：

现在当你启动项目后，你应该可以输入演员信息：

![Person Editing](img/mdb_person_carrie.png)


### 声明 FullName 字段 

编辑对话框的标题只显示人员的 姓氏(*Carrie-Anne*)，显示完整名字会更好，并且搜索也应该按列表中的全名进行搜索的。

因此，让我们编辑 PersonRow.cs：

```cs
namespace MovieTutorial.MovieDB.Entities
{
    //...
    public sealed class PersonRow : Row, IIdRow, INameRow
    {
        //... remove QuickSearch from FirstName
        [DisplayName("First Name"), Size(50), NotNull]
        public String Firstname
        {
            get { return Fields.Firstname[this]; }
            set { Fields.Firstname[this] = value; }
        }

        [DisplayName("Last Name"), Size(50), NotNull]
        public String Lastname
        {
            get { return Fields.Lastname[this]; }
            set { Fields.Lastname[this] = value; }
        }

        [DisplayName("Full Name"), 
         Expression("(t0.Firstname + ' ' + t0.Lastname)"), QuickSearch]
        public String Fullname
        {
            get { return Fields.Fullname[this]; }
            set { Fields.Fullname[this] = value; }
        }
        
        //... change NameField to Fullname
        StringField INameRow.NameField
        {
            get { return Fields.Fullname; }
        }

        //...

        public class RowFields : RowFieldsBase
        {
            public readonly Int32Field PersonId;
            public readonly StringField Firstname;
            public readonly StringField Lastname;
            public readonly StringField Fullname;
            //...
        }
    }
}
```

我们在 Fullname 属性上面添加 SQL 表达式 *Expression("(t0.Firstname + ' ' + t0.Lastname)")*，因此，这是一个在服务器端计算的字段。 

通过给 FullName 属性添加 QuickSearch 特性，列表现在将默认以 Fullname 字段进行搜索，而不再以 Firstname 搜索。

但对话框显示的仍然是 Firstname。要显示 Fullname，我们需要生成项目让 T4模板转换模板。

### 为什么必须转换模板吗？

查看 *PersonDialog.ts* 文件后会变得更清晰：

```ts
namespace MovieTutorial.MovieDB {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PersonDialog extends Serenity.EntityDialog<PersonRow, any> {
        protected getFormKey() { return PersonForm.formKey; }
        protected getIdProperty() { return PersonRow.idProperty; }
        protected getLocalTextPrefix() { return PersonRow.localTextPrefix; }
        protected getNameProperty() { return PersonRow.nameProperty; }
        protected getService() { return PersonService.baseUrl; }

        protected form = new PersonForm(this.idPrefix);
    }
}
```

在这里我们看到 getNameProperty() 方法返回 PersonRow.nameProperty。TypeScript 文件(MovieDB.PersonRow.ts) 中的 PersonRow 就是由我们的 T4 模板生成的。

因此，除非我们转换 T4 模板，否则我们在 PersonRow.cs 中对 name 属性的更改将不会反映在 \*Modules/Common/Imports/ServerTypings/ ServerTypings.tt" 下的 *MovieDB.PersonRow.ts* 文件：

```ts
namespace MovieTutorial.MovieDB {
    export interface PersonRow {
        PersonId?: number;
        Firstname?: string;
        Lastname?: string;
        Fullname?: string;
        //...
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'Fullname';
        export const localTextPrefix = 'MovieDB.Person';

        export namespace Fields {
            export declare const PersonId: string;
            //...
        }
        //...
    }
}
```

此元数据 （PersonRow 的 nameProperty 常量） 是由 ServerTypings.tt 生成 TypeScript 文件(MovieDB.PersonRow.ts)的代码。 

同样，*idProperty*, *localTextPrefix*, *Enum Types* 等也是由 *ServerTypings.tt* 文件生成的。因此，当你的更改对生成文件中的元数据有影响时，你就应该转换 T4 模板以将该修改信息应用到对应的 TypeScript 文件中。

> 你应该总是在转换模板之前生成项目，因为 T4 模板文件引用了 MovieTutorial.Web 项目输出的 DLL。否则你将会为一个旧版本的 Web 项目生成代码。

### 声明 PersonRow 查找脚本 Declaring PersonRow Lookup Script
 
让我们继续在 PersonRow.cs 文件中为 人员（Person） 表添加一个 LookupScript 特性：

```cs
namespace MovieTutorial.MovieDB.Entities
{
    //...
    [LookupScript("MovieDB.Person")]
    public sealed class PersonRow : Row, IIdRow, INameRow
    //...
```

我们会在稍后的编辑影片中使用它。

再次生成项目，你将看到 *MovieDB.PersonRow.ts* 中有一个返回 lookupKey 类型的 *getLookup()* 方法。  

```ts
namespace MovieTutorial.MovieDB {
    export interface PersonRow {
        //...
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'Fullname';
        export const localTextPrefix = 'MovieDB.Person';
        export const lookupKey = 'MovieDB.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('MovieDB.Person');
        }

    //...
}
```

### 为 演员（MovieCast）表生成代码 

使用 *sergen* 为 演员（MovieCast）表生成代码：

![Movie Cast Code Generation](img/mdb_sergen_moviecast.png)

生成代码之后，由于我们不需要一个单独的页面编辑 演员（MovieCast）表，所以你可以删除下列的文件：

```
MovieCastIndex.cshtml
MovieCastPage.cs
MovieDialog.ts
MovieGrid.ts
```

再次生成项目。

### 演员（MovieCast）表主从关系的编辑逻辑 

到目前为止，我们为每张表创建一个页面，并在该页面显示列表和编辑记录。这一次，我们将使用不同的策略。

我们将在影片对话框中列出演员信息，并允许他们与影片一起进行编辑。此外，演员也将与影片实体在同一个事务中保存。

因此，编辑演员的信息将保存在内存中，当用户点击影片对话框中的保存按钮时，影片和其演员会同时（同一事务）保存到数据库。

> 也有可能需要单独编辑演员信息的情况，但我们这里仅演示其中一种实现方式。 

> 对于一些主从关系，如订单/订单详细，由于需要保持主从表的一致性，从表不应该允许进行独立编辑。 Serene 已经在 Northwind/Order 的编辑对话框中为该情况提供了示例。


### 创建演员（MovieCast）列表的编辑器 

在 MovieCastRow.cs（位于 MovieTutorial.Web/Modules/MovieDB/MovieCast/)目录下面，创建文件 MovieCastEditor.ts，其内容如下：

```ts
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace MovieTutorial.MovieDB {
    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor 
          extends Common.GridEditorBase<MovieCastRow> {
        protected getColumnsKey() { return "MovieDB.MovieCast"; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}   
```

此编辑器继承自 Serene 的 Common.GridEditorBase 类，这是一种在内存中编辑内容的特殊网格类型。它也是订单对话框中订单详细信息编辑器的基类。 

> 在文件顶部的 `<reference />` 很重要。TypeScript 有输入文件的顺序问题。如果我们不把它放在那里，TypeScript 有时会在输出 MovieCastEditor 之后再输出 GridEditorBase ，导致出现运行时错误。  
> 
> 作为一个经验法则，如果你有一些类继承自另一个项目（不是 Serenity 的类），你应该在文件中包含该基类文件的引用。
>
> 这有助于在其他类使用 GridEditorBase 之前， TypeScript 把它转换为 javascript 。

若要从服务器端引用此新的编辑器类型，生成和转换所有模板。

> 此基类可能会在以后的版本中集成到 Serenity 。在这种情况下，其命名空间可能会变为 Serenity，代替当前的 Serene 或 MovieTutorial。


### 在影片窗体中使用 MovieCastEditor 

打开 MovieForm.cs，在 *Description* and *Storyline* 属性之间添加 CastList 属性，如： 

```cs
namespace MovieTutorial.MovieDB.Forms
{
    //...
    public class MovieForm
    {
        public String Title { get; set; }
        [TextAreaEditor(Rows = 3)]
        public String Description { get; set; }
        [MovieCastEditor]
        public List<Entities.MovieCastRow> CastList { get; set; }
        [TextAreaEditor(Rows = 8)]
        public String Storyline { get; set; }
        //...
    }
}
```

通过将把 *[MovieCastEditor]* 特性放在 CastList 属性上，我们指定该属性将由新的 MovieCastEditor 类型所定义的 TypeScript 代码编辑。

> 我们也可以像这样添加特性 *[EditorType("MovieDB.MovieCast")]*，但谁真的喜欢硬编码的字符串呢？我可不喜欢... 

现在生成并启动你的应用程序。打开一个影片编辑对话框，你将看到我们的新编辑器：

![Movie Cast Editor Initial](img/mdb_casteditor_initial.png)

OK，这看起来很容易该功能，但我实话告诉你，我们连功能的一半都还没完成。 

*New MovieCast* 按钮不能工作，需要为它定义一个对话框。网格显示的列不是我想要的并且字段和按钮的标题很不友好……

此外，我们还有更多的细节需要处理，如在服务器端保存和加载演员列表（我们先用手工方式演示其有多困难，然后再用服务行为（service behavior）来演示其有多简单）


### 配置演员编辑器（MovieCastEditor）使用编辑演员对话框（MovieCastEditDialog）

在 *MovieCastEditor.ts* 所在文件夹中创建文件 *MovieCastEditDialog.ts*，并对其做如下修改： 

```ts
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieCastEditDialog extends 
          Common.GridEditorDialog<MovieCastRow> {
        protected getFormKey() { return MovieCastForm.formKey; }
        protected getNameProperty() { return MovieCastRow.nameProperty; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

        protected form: MovieCastForm;

        constructor() {
            super();
            this.form = new MovieCastForm(this.idPrefix);
        }
    }
}
```

我们使用另外一个来自 Serene 的基类 *Common.GridEditorDialog*，编辑订单详细对话框（OrderDetailEditDialog）也是使用该基类。 

再次打开 *MovieCastEditor.ts* 文件， 添加一个 getDialogType 方法并重写 getAddButtonCaption 方法：

```ts
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace MovieTutorial.MovieDB {
    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor 
          extends Common.GridEditorBase<MovieCastRow> {
        protected getColumnsKey() { return "MovieDB.MovieCast"; }
        protected getDialogType() { return MovieCastEditDialog; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
    }
}
```

我们指定演员编辑器（MovieCastEditor）默认使用编辑演员对话框（MovieCastEditDialog）， *Add* 按钮也使用该对话框。 

现在，*Add* 按钮将显示一个对话框，而不是什么也没做。

![Movie Cast Edit Dialog](img/mdb_casteditor_adddialog.png)

此对话框需要一些 CSS 美化。电影标题和人名字段接受数字输入（因为它们实际上是 MovieId 和 PersonId 字段）。

### 编辑 MovieCastForm.cs 文件

*MovieCastEditDialog* 的 *getFormKey()* 方法返回 *MovieCastForm.formKey*, 所以它当前使用 Sergen 生成的 MovieCastForm.cs。

在 Serenity 中也有可能一个实体有多个窗体。如果我想要一些其他独立的对话框保存 *MovieCastForm*，例如 演员对话框（MovieCastDialog，我们已经把它删除了），我更愿意定义一个像 *MovieCastEditForm* 新窗体，但在这里我没有这样做。 

打开并编辑 MovieCastForm.cs：

```cs
namespace MovieTutorial.MovieDB.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [FormScript("MovieDB.MovieCast")]
    [BasedOnRow(typeof(Entities.MovieCastRow))]
    public class MovieCastForm
    {
        public Int32 PersonId { get; set; }
        public String Character { get; set; }
    }
}
```

我已经删除了 *MovieId*，因为这个表单在 *编辑演员对话框（MovieCastEditDialog）* 中使用，所以在 *影片对话框（MovieDialog）* 中， *演员（MovieCast）* 实体自动带有当前被编辑电影的 *MovieId*，打开 《魔戒》(*Lord of the Rings*)，并添加《黑客帝国》（*the Matrix*）的演员列表是没有意义的。  

下一步，编辑 MovieCastRow.cs： 

```cs
    [ConnectionKey("Default"), TwoLevelCached]
    [DisplayName("Movie Casts"), InstanceName("Cast")]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class MovieCastRow : Row, IIdRow, INameRow
    {
        //...
        [DisplayName("Actor/Actress"), NotNull, ForeignKey("[mov].[Person]", "PersonId")]
        [LeftJoin("jPerson"), TextualField("PersonFirstname")]
        [LookupEditor(typeof(PersonRow))]
        public Int32? PersonId
        {
            get { return Fields.PersonId[this]; }
            set { Fields.PersonId[this] = value; }
        }
```

我为 PersonId 属性设置 LookupEditor 特性，正如我在 *PersonRow* 添加 LookupScript 特性一样，我可以重用这些信息来设置查找键。 

> 我们也能写成 <br/>*[LookupEditor("MovieDB.Person")]*  

把 *PersonId* 的显示名称修改为 *Actor/Actress*。

同时修改行的 *DisplayName* 和 *InstanceName*特性来设置对话框标题。  

生成解决方案，并启动项目，现在 MovieCastEditDialog 有更好的编辑体验。但对话框宽度和高度仍然太大了。


### 美化 编辑演员对话框（MovieCastEditDialog）

让我们检查 *site.less* 来了解为什么我们的 MovieCastEditDialog 不会应用样式。

```css
.s-MovieDB-MovieCastDialog {
    > .size { width: 650px; }
    .caption { width: 150px; }
}
```

Site.less 底部 CSS 是 MovieCastDialog，而不是 MovieCastEditDialog，因为该类样式是我们自己定义的，而不是用代码生成器生成。 

我们创建了一个名为 *MovieCastEditDialog* 新对话框，所以现在我们的新对话框只有一个 s-MovieDB-MovieCastEditDialog 样式类，但是代码生成器只生成样式 *s-MovieDB-MovieCastDialog* 。

> Serenity 将自动为对话框元素分配以"s-"为前缀的 CSS 类名。你可以在开发人员工具中通过该特点检查对话框。MovieCastEditDialog 有 *s-MovieCastEditDialog* 和 *s-MovieDB-MovieCastEditDialog* 及一些其它类似 *ui-dialog* 的 CSS 类。

> *s-ModuleName-TypeName* CSS 类帮助区分两个具有相同名称模块的样式。 

由于我们实际上并没有打算使用演员对话框（MovieCastDialog，我们已经把它删除了），让我们在 site.less 重命名一个类：

```css
.s-MovieDB-MovieCastEditDialog {
    > .size { width: 450px; }
    .caption { width: 120px; }
    .s-PropertyGrid .categories { height: 120px; }
}
```

现在 *编辑演员对话框（MovieCastEditDialog）* 更为美观了：

![Movie Cast Dialog Fixed](img/mdb_castdialog_final.png)


### 调整演员编辑器（MovieCastEditor）的列

演员编辑器（MovieCastEditor） 目前使用在 MovieCastColumns.cs 定义的列（因为它在 getColumnsKey() 方法中返回"MovieDB.MovieCast"）。

我们这里有MovieCastId, MovieId, PersonId (显示为 Actor/Actress) and Character字段，只显示 Actor/Actress 和 Character 字段会更好。

我们想显示演员的全名而不是整数值（PersonId 是整数），所以我们首先在 MovieCastRow.cs 中定义该属性：

```cs
namespace MovieTutorial.MovieDB.Entities
{
    //...
    public sealed class MovieCastRow : Row, IIdRow, INameRow
    {
        // ...
        
        [DisplayName("Person Firstname"), Expression("jPerson.Firstname")]
        public String PersonFirstname
        {
            get { return Fields.PersonFirstname[this]; }
            set { Fields.PersonFirstname[this] = value; }
        }

        [DisplayName("Person Lastname"), Expression("jPerson.Lastname")]
        public String PersonLastname
        {
            get { return Fields.PersonLastname[this]; }
            set { Fields.PersonLastname[this] = value; }
        }

        [DisplayName("Actor/Actress"), 
         Expression("(jPerson.Firstname + ' ' + jPerson.Lastname)")]
        public String PersonFullname
        {
            get { return Fields.PersonFullname[this]; }
            set { Fields.PersonFullname[this] = value; }
        }

        // ...
        
        public class RowFields : RowFieldsBase
        {
            // ...
            public readonly StringField PersonFirstname;
            public readonly StringField PersonLastname;
            public readonly StringField PersonFullname;
            // ...
        }
    }
}
```

并且修改 MovieCastColumns.cs：

```cs
namespace MovieTutorial.MovieDB.Columns
{
    using Serenity.ComponentModel;
    using System;

    [ColumnsScript("MovieDB.MovieCast")]
    [BasedOnRow(typeof(Entities.MovieCastRow))]
    public class MovieCastColumns
    {
        [EditLink, Width(220)]
        public String PersonFullname { get; set; }
        [EditLink, Width(150)]
        public String Character { get; set; }
    }
}
```

重新生成项目，现在网格列表有更友好的列：

![Movie Cast Dialog Fixed](img/mdb_castgrid_columns.png)

现在尝试添加演员信息，例如，Keanu Reeves / Neo：

![Movie Cast Grid Empty Actor](img/mdb_castgrid_emptyactor.png)

为什么 Actor/Actress 列是空的？

### 解决 Actor/Actress 列为空的问题

请记住，我们的编辑是在内存中进行的。这里有没有涉及服务的调用。因此，网格列表显示从对话框传给它的任何实体。

当你点击保存按钮时，对话框生成这样的实体进行保存：

```json
{
    PersonId: 7,
    Character: 'Neo'
}
```

这些字段对应你之前在 MovieCastForm.cs 设置的表单字段：

```cs
public class MovieCastForm
{
    public Int32 PersonId { get; set; }
    public String Character { get; set; }
}
```

但是在网格列表中，我们显示的是这些列：

```cs
public class MovieCastColumns
{
    public String PersonFullname { get; set; }
    public String Character { get; set; }
}
```

在该实体中并没有 PersonFullname 属性，所以网格列表不会显示它的值。 

我们需要自己设置 PersonFullname 属性。首先，转换 T4 模板以获得我们最近添加的 PersonFullname 属性，然后编辑 MovieCastEditor.ts：

```ts
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace MovieTutorial.MovieDB {
    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor extends Common.GridEditorBase<MovieCastRow> {
        //...

        protected validateEntity(row: MovieCastRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;        

            row.PersonFullname = PersonRow.getLookup()
                .itemById[row.PersonId].Fullname;
                
            return true;
        }        
    }
}   
```

ValidateEntity 是一个 Serene 的 GridEditorBase 类中的方法，点击保存按钮，在实体添加到网格列表之前调用该方法对实体进行验证，但是我们需要重写它，让其设置 PersonFullname 属性的值而不是验证。

正如我们之前看到的，我们的实体有 PersonId 和 Character 字段。我们可以使用 PersonId 字段的值来确定角色的全名。

为此，我们需要一个把 PersonId 对应到角色全名的字典。幸运的是，人员检索（lookup）有这样的字典。我们可以通过其 getLookup 方法来访问 PersonRow 的检索（lookup）。

> 另外一种访问 人员检索（lookup）的方法是使用 *Q.getLookup('MovieDB.Person')*。PersonRow 中的这个方法是 T4 模板定义的快捷方式。 

所有的检索（lookups）都有一个 *itemById* 字典，以允许你通过其 ID 访问该实体类。

> 检索（lookups）是一个简单的服务器端与客户端共享数据的方法。但他们只适用于小型数据集。 

> 如果一个表有成千上万条记录，就没有理由为其定义检索(lookup)。在此情况下，我们会用一个服务器请求并通过其 ID 来查询记录。


### 在 MovieRow 中声明 CastList 

当有一个影片对话框打开时，且演员列表（CastList）中没有演员，这时点击保存按钮，你会得到这样的错误：

![Cast Save Error](img/mdb_castgrid_saveerror.png)

引发该错误的是在服务器端的行反序列化器 (JsonRowConverter for JSON.NET)。 

我们在 MovieForm 定义 CastList 属性，但是在 MovieRow 没有对应的字段，所以反序列器不知道如何处理从客户端接收的 CastList 值。 

如果你使用 F12 打开开发者工具，选择网络选项卡，并在点击保存按钮之后查看 AJAX 请求，你将看到有这样的一个请求：

```json
{
    "Entity": {
        "Title": "The Matrix",
        "Description": "A computer hacker...",
        "CastList": [
            {
                "PersonId":"1",
                "Character":"Neo",
                "PersonFullname":"Keanu Reeves"
            }
        ],
        "Storyline":"Thomas A. Anderson is a man living two lives...",
        "Year":1999,
        "ReleaseDate":"1999-03-31",
        "Runtime":136,
        "GenreId":"",
        "Kind":"1",
        "MovieId":1
    }
}
```

在这里，CastList 属性不能在服务器端进行反序列化。所以我们要在 MovieRow.cs 中声明：

```cs
namespace MovieTutorial.MovieDB.Entities
{
    // ...
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Cast List"), SetFieldFlags(FieldFlags.ClientSide)]
        public List<MovieCastRow> CastList
        {
            get { return Fields.CastList[this]; }
            set { Fields.CastList[this] = value; }
        }

        public class RowFields : RowFieldsBase
        {
            // ...
            public readonly RowListField<MovieCastRow> CastList;
            // ...
        }
    }
}
```

我们定义一个接受列表中 MovieCastRow 对象的 CastList 属性。用于这种行列属性的*Field*类的类型是 *RowListField*。

通过添加 *[SetFieldFlags(FieldFlags.ClientSide)]* 特性，我们指定此字段直接在数据库表中不可用，因此不能通过简单的 SQL 查询来选择。它在其他 ORM 系统中，类似于未映射的字段。

现在，当你点击保存按钮，将不会有错误发生。

但是，重新打开刚保存的《黑客帝国》（the Matrix） 实体。这里并没有演员记录，尼欧（Neo）发生什么事？ 

因为这是一个未映射的字段，所以电影保存服务忽略了 CastList 属性。

> 如果你还记得在前一节我们的 GenreList 同样也是一个未映射的字段，但不知为何它在那里可以正常工作。这是因为我们在该属性中使用了 LinkedSetRelationBehavior 行为（behavior） 。 
> 
> 我们在这里演示若没有该服务器行为（service behavior）将会发生什么。


### 处理演员列表（CastList）的保存

打开 *MovieRepository.cs*， 找到空 *MySaveHandler* 类，并对其做如下修改： 

```cs
private class MySaveHandler : SaveRequestHandler<MyRow>
{
    protected override void AfterSave()
    {
        base.AfterSave();

        if (Row.CastList != null)
        {
            var mc = Entities.MovieCastRow.Fields;
            var oldList = IsCreate ? null :
                Connection.List<Entities.MovieCastRow>(
                    mc.MovieId == this.Row.MovieId.Value);

            new Common.DetailListSaveHandler<Entities.MovieCastRow>(
                oldList, Row.CastList,
                x => x.MovieId = Row.MovieId.Value).Process(this.UnitOfWork);
        }
    }
}
```

MySaveHandler 处理影片行（Movie rows）的添加和修改服务请求。其大部分逻辑由基类 SaveRequestHandler 处理，所以之前该类是空的。 

在添加/修改演员列表之前，我们应该先成功添加/修改影片实体。因此，我们通过重写基方法 *AfterSave* 包含自定义的代码。

> 如果是添加操作，我们需要在演员（MovieCast）纪录中重用 MovieId 字段的值。由于 MovieId 是一个标识字段，所以它只在添加影片记录之后生效。

由于我们是在内存（客户端）中编辑演员列表信息，因此这将是一个批处理更新。 

我们需要比较影片的新旧演员列表记录，并对其进行添加/更新/删除操作。

假设我们数据库中有影片 X，演员有： A、 B、 C、 D。

我们在编辑对话框中对演员列表做了一些修改，现在演员变为：A、 B、 D、 E、 F。

因此我们需要更新 A、 B、 D (角色/演员 发生了改变)，删除 C，并添加新的演员记录 E 和 F。

幸运的是，Serene 中定义的 DetailListSaveHandler 类可处理所有这些比较，并自动执行插入/更新/删除操作(通过ID值)。否则我们需要在这里编写大量的代码。

如果这是一个更新影片的操作，为了获取演员列表中的旧记录，我们需要查询数据库。而如果是新增操作，我们就不需要任何演员记录。

我们使用 *Connection.List< Entities.MovieCastRow >* 扩展方法获取演员列表，这里的 *Connection* 是 SaveRequestHandler 的属性，该属性返回当前使用的连接。*List* 选择匹配指定条件（*mc.MovieId == this.Row.MovieId.Value*）的记录。 

*this.Row* 是指添加/更新当前含有新的字段值的记录（影片记录），因此它包含 MovieId 值（新的或者现有的 ID）。

为了更新演员记录，我们创建了一个 *DetailListHandler* 对象，该对象含旧的演员列表、新的演员列表及设置演员记录 MovieId 字段值的委托。让对象为新的演员记录与当前电影建立联系。 

然后我们使用当前的工作单元（unit of work）调用 DetailListHandler 方法。UnitOfWork 是一个特殊的对象，它封装了当前 连接/事务。 

> 所有的 Serenity 添加/更新/删除 处理都适用于隐式事务(IUnitOfWork)。

### 处理演员列表的检索

我们还没有完成该功能。当在影片列表中点击影片实体时，对话框调用 *Retrieve* 服务加载影片记录。就像 演员列表（CastList）字段没有映射的情况，即使我们正确保存了演员，演员也不会加载到对话框。

我们同样需要在 MovieRepository.cs 文件中编辑 *MyRetrieveHandler* 类：

```cs
private class MyRetrieveHandler : RetrieveRequestHandler<MyRow>
{
    protected override void OnReturn()
    {
        base.OnReturn();

        var mc = Entities.MovieCastRow.Fields;
        Row.CastList = Connection.List<Entities.MovieCastRow>(q => q
            .SelectTableFields()
            .Select(mc.PersonFullname)
            .Where(mc.MovieId == Row.MovieId.Value));
    }
}
```

在这里，我们重写 OnReturn 方法，以使在检索服务返回之前把 CastList 注入影片的行（Row）对象中。

我使用 Connection.List 的不同扩展，这样我就可以修改 select 查询。

默认情况下，列表选择所有的表字段(除了外键表的字段)，但为了显示演员名字，我还需要选择 *PersonFullName* 字段。

现在生成解决方案，我们终于可以显示/编辑演员了。


### 处理演员列表的删除

当你尝试删除电影实体时，你将获得一个外键错误。你可以在创建 演员（MovieCast） 表时使用 "级联删除（CASCADE DELETE）" 外键，但是我们选择再次在仓储层（repository level）中处理：

```cs
private class MyDeleteHandler : DeleteRequestHandler<MyRow>
{
    protected override void OnBeforeDelete()
    {
        base.OnBeforeDelete();

        var mc = Entities.MovieCastRow.Fields;
        foreach (var detailID in Connection.Query<Int32>(
            new SqlQuery()
                .From(mc)
                .Select(mc.MovieCastId)
                .Where(mc.MovieId == Row.MovieId.Value)))
        {
            new DeleteRequestHandler<Entities.MovieCastRow>().Process(this.UnitOfWork,
                new DeleteRequest
                {
                    EntityId = detailID
                });
        }
    }
}
```


我们实现这个主/从处理的方式不是很直观，并且在存储层包含了几个手工步骤。请继续阅读，看我们如何通过使用一个集成的功能 (MasterDetailRelationAttribute)轻松地实现同一逻辑。


### 在行为（Behavior）中处理 保存/检索/删除

主/从关系是一个综合性的功能（至少在服务器端是），所以我使用 *MasterDetailRelation* 特性替代手工重写 保存/检索和删除操作。

打开 MovieRow.cs 并修改 *CastList* 属性：

```cs
[MasterDetailRelation(foreignKey: "MovieId", IncludeColumns = "PersonFullname")]
[DisplayName("Cast List"), SetFieldFlags(FieldFlags.ClientSide)]
public List<MovieCastRow> CastList
{
    get { return Fields.CastList[this]; }
    set { Fields.CastList[this] = value; }
}
```

我们指定该字段是主/从关系的详细列表（从表内容），并且详细列表的主 ID 字段（外键）是 *MovieId*。

现在我们撤消在 MovieRepository.cs 中做的所有更改：

```cs
private class MySaveHandler : SaveRequestHandler<MyRow> { }
private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
```

在我们 *MasterDetailRelation* 特性中，我们指定了一个额外的属性 *IncludeColumns*：

```
[MasterDetailRelation(foreignKey: "MovieId", IncludeColumns = "PersonFullname")]
```

这是确保在检索演员列表时包含 *PersonFullname* 字段。另外，只默认选中表字段的情况下它将不会加载。当你打开一个存在演员信息的影片对话框时，演员的全名将为空。

> 确保你在网格列中使用到的任何可视字段都添加到 IncludeColumns。使用逗号分隔多个字段名称，例如 IncludeColumns ="FieldA, FieldB, FieldC"。

现在生成项目，你将看到使用更少的代码完成了同样的工作。

*MasterDetailRelationAttribute* 自动触发一种深层次行为（behavior），*MasterDetailRelationBehavior* 拦截检索/保存/删除处理并执行我们之前已经重写的方法及其他类似的操作方法。

所以我们做了同样的事情，但这一次，是以声明的方式，而不是命令式（告诉程序应该做什么，而不是如何去做）

> https://en.wikipedia.org/wiki/Declarative_programming

> 我们将在下面的章节介绍如何编写你自己的请求处理行为（behaviors）。 