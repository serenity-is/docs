# How To: Setup Cascaded Editors

You might need multi-level cascaded editors like Country => City, Course => Class Name => Subject.

Starting with Serenity 1.8.2, it's rather simple. Lookup editors have this integrated functionality.

> For versions before 1.8.2, it was also possible, and there was some samples in Serene, but you had to define some editor classes to make it work.

Let's say we have a database with three tables, Country, City, District:

* **Country Table**: CountryId, CountryName
* **City Table**: CityId, CityName, CountryId
* **District Table**: DistrictId, DistrictName, CityId

First make sure you generate code for all three tables using Sergen, and you have a `[LookupScript]` attribute on all of them:


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

Make sure you add `LookupInclude` attribute to CityId field of DistrictRow, and CountryId field of CityRow. We need them to be available at client side, otherwise they are not included by default in lookup scripts.

If you wanted to edit these fields as cascaded lookup editors in a form, e.g. CustomerForm, you would set them up like this:

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

> You could also set these attributes in CustomerRow

Here, *CascadeFrom* attribute tells city editor, ID of the parent editor that it will bind to (cascade). 

When this form is generated, *CountryId* field will be handled with an editor with ID *CountryId*, so we set *CascadeFrom* attribute of *CityId* lookup editor to that ID.

*CascadeField* determines the field to filter cities on. Thus, when country editor value changes, city editor items will be filtered on their *CountryId* properties like this:

```
   this.Items.Where(x => x.CountryId == CountryEditorValue)
```

> If *CascadeFrom* and *CascadeField* attributes are same, you only need to specify *CascadeFrom*, but i wanted to be explicit here.

If you wanted to add these cascaded editors to filter bar of customer grid, in CreateToolbarExtensions method of CustomerGrid.cs, do this:

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

> Here i suppose you have CountryId, CityId and DistrictId fields in CustomerRow.

Now you have useful cascaded editors for both editing and filtering.