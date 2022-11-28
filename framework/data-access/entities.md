# Entities (Row)

Serenity entity system is a Micro-ORM that is in love with SQL just like Dapper. 

Unlike full-blown ORMs like NHibernate / Entity Framework, Serenity provides the minimum features required to map and query databases with intelli-sense, compile-time checking, and easy refactoring.

Serenity entities are usually named like *XYZRow*. They are subclasses of *Serenity.Data.Row*.

Let's define a simple row class:


```cs
using Serenity.Data;

public class SimpleRow : Row<SimpleRow.RowFields>
{
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }
    
    public int? Age
    {
        get => return fields.Age[this];
        set => fields.Age[this] = value;
    }
    
    public SimpleRow() 
    {
    }

    public class RowFields : RowFieldsBase
    {
        public StringField Name;
        public Int32Field Age;
    }	
}
```

Yes, it looks a bit more complicated than a simple POCO class. This is required to make some features work without using proxy classes like some ORMs use.

This structure allows us to build queries with zero reflection, do assignment tracking, and enable INotifyPropertyChanged when required. It makes it also possible to work with custom, user-defined fields.

Rows are JSON serializable, so they can be returned from services without any problems. You don't need extra POCO/DTO classes unless you have a good reason to use them.

Let's study parts of a row declaration.

```cs
public class SimpleRow : Row<SimpleRow.RowFields>
```

Here we define an entity named SimpleRow, which should map to a table named `Simple` in the database.

*Row* suffix here is not required but is common practice, and it prevents clashes with other class names.

All entity classes should derive from `Serenity.Data.Row<TFields>` generic base class which accepts the type of `RowFields` class for the row with the field definitions.

```cs
public string Name
{
    get => fields.Name[this];
    set => fields.Name[this] = value;
}
```

Now we declare our first property. This property maps to a database column named `Name` in the `Simple` table.

It is not possible to use an auto property here (like `get; set;`). Field values must be read and set through a special object called *Field*.

Field objects are very similar to WPF dependency properties. Here is a dependency property declaration sample:

```cs
public static readonly DependencyProperty MyCustomProperty = 
    DependencyProperty.Register("MyCustom", typeof(string), typeof(Window1));

public string MyCustom
{
    get { return this.GetValue(MyCustomProperty) as string; }
    set { this.SetValue(MyCustomProperty, value); }
}
```

Here we define a static dependency property object (MyCustomProperty), that contains property metadata and allows us to set and get property value through its *GetValue* and *SetValue* methods. Dependency properties allow WPF to offer features like validation, data binding, animation, and more.

Similar to dependency properties, `Field` objects contain column metadata and clear the way for some features like assignment tracking, building queries without expression trees, change notifications, etc.

While dependency properties are declared as static members in the class they are used, Field objects are declared in a nested class named RowFields. This allows grouping and referencing them easier, without having to add *Field* or *Property* suffix, and keeps our entity clear from field declarations.

One instance of the RowFields class is shared between all the row instances of a particular type, so it is also similar to a static object.

```cs
public Int32? Age
{
    get => Fields.Age[this];
    set => Fields.Age[this] = value;
}
```

Here is our second property, named `Age`, with type `int?`.

Serenity entity properties are always nullable, even if the database column is not nullable. We never use zero in place of null. 

This might seem unlogical if you have a background in other ORMs, but consider that it is possible for a not-null field to have a null value, if you query it through a left/right join. How can you say, if its retrieved value is null or zero in that case?

Note that reference types are already nullable, so you shouldn't write `"String?"`.

```cs
public SimpleRow()
{
}
```

Now we define SimpleRow's parameterless constructor. This is optional unless you need to write some statements inside the constructor.

```cs
public class RowFields : RowFieldsBase
{
    public StringField Name;
    public Int32Field Age;
}
```

Here we define our nested class that contains the field objects. It should be derived from `Serenity.Data.RowFieldsBase`. *RowFieldsBase* is a special class closely related to *Row* that contains table and field metadata.

We declared a `StringField` and an `Int32Field`. Their type is based on their property types, and they must match exactly.

Their names should also match the property names, or you'll get an initialization error.

We didn't initialize these field objects, so their values are initially null. 

Serenity automatically creates these field objects based on the corresponding property declaration, matching them by the property name.

It's also possible to initialize them in the RowFields constructor manually, but not recommended, except for special customizations.

## StartSharp and Row Templates

If you are using `StartSharp` and have a reference to the `Serenity.Pro.Coder` package, it is possible to simplify the above row declaration by using a nested `RowTemplate` class:

```cs
public partial class SimpleRow
{
    private class RowTemplate
    {
        public string Name { get; set; }
        public int? Age { get; set; }
    }
}
```

This looks simpler than the original row definition but they are functionally equal. 

The source generator in `Serenity.Pro.Coder` generates the following partial class for you:

```cs
using Serenity.Data;

partial class SimpleRow : Row<SimpleRow.RowFields>
{
    private string name;
    private int? age;

    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    public int? Age
    {
        get => fields.Age[this];
        set => fields.Age[this] = value;
    }

    public partial class RowFields : RowFieldsBase
    {
        public StringField Name;
        public Int32Field Age;

        protected override void CreateGeneratedFields()
        {
            Name = new StringField(this, "Name", null, 0, FieldFlags.Default,
                getValue: row => ((SimpleRow)row).name,
                setValue: (row, value) => ((SimpleRow)row).name = value);

            Age = new Int32Field(this, "Age", null, 0, FieldFlags.Default,
                getValue: row => ((SimpleRow)row).age,
                setValue: (row, value) => ((SimpleRow)row).age = value);
        }
    }
}
```

We'll talk more about `Serenity.Pro.Coder` and its source generators in the following sections.