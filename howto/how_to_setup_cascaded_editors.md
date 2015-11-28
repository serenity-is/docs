# How To: Setup Cascaded Editors

You might need multi-level cascaded editors like Country => City, Course => Class Name => Subject.

Starting with Serenity 1.8.2, it's rather simple. Lookup editors has this functionality.

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
    [DisplayName("Country ID"), Identity]
    public Int32? CountryID
    {
        get { return Fields.CountryID[this]; }
        set { Fields.CountryID[this] = value; }
    }

    [DisplayName("Country Name"), Size(50), NotNull, QuickSearch]
    public String CountryName
    {
        get { return Fields.CountryName[this]; }
        set { Fields.CountryName[this] = value; }
    }
}
```