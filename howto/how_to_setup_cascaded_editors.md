# 如何设置级联编辑器（Cascaded Editors）？

你可能需要多级级联的编辑器，如 国家 => 城市， 课程 => 班级 =》 科目。

从 Serenity 1.8.2 开始，级联编辑将变得简单。检索编译器（Lookup editors）已经集成了该功能。

> 在 1.8.2 之前的版本，也可以实现该功能，并且在 Serene 中也有一些示例，但为使它工作，你需要定义一些编辑器类。

假设我们的数据库有三张表：Country、 City、District：

* **Country Table**: CountryId, CountryName
* **City Table**: CityId, CityName, CountryId
* **District Table**: DistrictId, DistrictName, CityId

首先，确保你已经使用 Sergen 为这三张表生成代码，并且都含有 `[LookupScript]` 特性： 


```cs
[LookupScript("MyModule.Country")]
public sealed class CountryRow : Row...
{
    [DisplayName("Country Id"), Identity]
    public Int32? CountryId
    {
        get { return Fields.CountryId[this]; }
        set { Fields.CountryId[this] = value; }
    }

    [DisplayName("Country Name"), Size(50), NotNull, QuickSearch]
    public String CountryName
    {
        get { return Fields.CountryName[this]; }
        set { Fields.CountryName[this] = value; }
    }
}
```


```cs
[LookupScript("MyModule.City")]
public sealed class CityRow : Row...
{
    [DisplayName("City Id"), Identity]
    public Int32? CityId
    {
        get { return Fields.CityId[this]; }
        set { Fields.CityId[this] = value; }
    }

    [DisplayName("City Name"), Size(50), NotNull, QuickSearch]
    public String CityName
    {
        get { return Fields.CityName[this]; }
        set { Fields.CityName[this] = value; }
    }
    
    [DisplayName("Country"), ForeignKey("Country", "CountryId"), LookupInclude]
    public Int32? CountryId
    {
        get { return Fields.CountryId[this]; }
        set { Fields.CountryId[this] = value; }
    }
    
}
```

```cs
[LookupScript("MyModule.District")]
public sealed class DistrictRow : Row...
{
    [DisplayName("District Id"), Identity]
    public Int32? DistrictId
    {
        get { return Fields.DistrictId[this]; }
        set { Fields.DistrictId[this] = value; }
    }

    [DisplayName("District Name"), Size(50), NotNull, QuickSearch]
    public String DistrictName
    {
        get { return Fields.DistrictName[this]; }
        set { Fields.DistrictName[this] = value; }
    }
    
    [DisplayName("City"), ForeignKey("City", "CityId"), LookupInclude]
    public Int32? CityId
    {
        get { return Fields.CityId[this]; }
        set { Fields.CityId[this] = value; }
    }
    
}
```

请确保在 DistrictRow 的 CityId 字段和 CityRow 的 CountryId 字段添加 `LookupInclude` 特性。我们在客户端需要它们，否则在默认情况下,它们不包含在检索脚本中。

如果你想在表单（如 CustomerForm）中以级联检索的形式编辑这些字段。你需要把它们设置为：

```cs
[FormScript("MyModule.Customer")]
[BasedOnRow(typeof(Entities.CustomerRow))]
public class CustomerForm
{
    public String CustomerID { get; set; }
    public String CustomeraName { get; set; }
    
    [LookupEditor(typeof(Entities.CountryRow))]
    public Int32? CountryId { get; set; }
    
    [LookupEditor(typeof(Entities.CityRow), 
        CascadeFrom = "CountryId", CascadeField = "CountryId")]
    public Int32? CityId { get; set; }
    
    [LookupEditor(typeof(Entities.DistrictRow), 
        CascadeFrom = "CityId", CascadeField = "CityId")]
    public Int32? DistrictId { get; set; }
}
```

> 你应该同样在 CustomerRow 中设置这些特性。

在这里，*CascadeFrom* 特性告诉市（city）编辑器，它将绑定 （级联） 父编辑器的 ID。 

当生成这个表单时，*CountryId* 字段将被 ID 为 *CountryId* 的编辑器处理。所以我们将 *CityId* 检索编辑器的 *CascadeFrom* 特性设置为该 ID。

*CascadeField* 决定城市过滤器所在的字段。因此，当国家编辑器的值改变时，城市编辑器的项目也将被 *CountryId* 过滤，如： 

```
   this.Items.Where(x => x.CountryId == CountryEditorValue)
```

> 如果 *CascadeFrom* 和 *CascadeField* 特性是一样的，你只需要指定 *CascadeFrom*。 

如果你想在客户网格列表的筛选栏添加这些级联编辑器，在 CustomerGrid.cs 的 CreateToolbarExtensions 方法中执行此操作：

```cs
AddEqualityFilter<LookupEditor>("CountryId",
    options: new LookupEditorOptions 
    { 
        LookupKey = "MyModule.Country" 
    });
    
AddEqualityFilter<LookupEditor>("CityId", 
    options: new LookupEditorOptions 
    {
        LookupKey = "MyModule.City", 
        CascadeFrom = "CountryId",
        CascadeField = "CountryId"
    });

AddEqualityFilter<LookupEditor>("DistrictId", 
    options: new LookupEditorOptions 
    {
        LookupKey = "MyModule.District", 
        CascadeFrom = "CityId",
        CascadeField = "CityId"
    });

```

> 在这里，我假设在 CustomerRow 有 CountryId、 CityId 和 DistrictId 字段。 

现在你的编辑和过滤都有可用的多级编辑器。