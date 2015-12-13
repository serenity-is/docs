# Entities (Row)


Serenity entity system is a micro-orm, which is in love with SQL just like Dapper. 

Unlike full blown ORMs like NHibernate / Entity Framework, Serenity provides minimum features required to map and query databases with intellisense, compile time checking and easy refactoring.

Serenity entities are usually named like *XYZRow*. They are subclasses of *Serenity.Data.Row*.

Let's define a simple row class:


```cs
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;

public class SimpleRow : Row
{
	public string Name
	{
		get { return Fields.Name[this]; }
		set { Fields.Name[this] = value; }
	}
	
	public Int32? Age
	{
		get { return Fields.Age[this]; }
		set { Fields.Age[this] = value; }
	}
	
	public static RowFields Fields = new RowFields().Init();
	
	public SimpleRow()
		: base(Fields)
	{
	}

	public class RowFields : RowFieldsBase
	{
		public StringField Name;
		public Int32Field Age;
	}	
}
```

> Yes, it looks a bit more complicated than a simple POCO class. This is required to make some features work without using proxy classes like some ORMs use (Entity Framework, NHibernate etc).

> This structure lets us to build queries with zero reflection, do assignment tracking, enable INotifyPropertyChanged when required. It is also possible to work with custom, user defined fields.

> Rows are JSON serializable, so they can be returned from services without any problems. You don't need extra POCO/DTO classes unless you have a good reason to use them.

Let's study parts of a row declaration.

```cs
public class SimpleRow : Row
```

Here we define an entity named SimpleRow, which probably maps to a table named `Simple` in database.

*Row* suffix here is not required, but common practice, and it prevents clashes with other class names.

All entity classes derive from `Serenity.Data.Row` base class.

```cs
public string Name
{
	get { return Fields.Name[this]; }
	set { Fields.Name[this] = value; }
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

Here we define a static dependency property object (MyCustomProperty), that contains property metadata and allows us to set and get property value through its *GetValue* and *SetValue* methods. Dependency properties allows WPF to offer features like validation, data binding, animation, and more.

Similar to dependency properties, Field objects contains column metadata and clears way for some features like assignment tracking, building queries without expression trees, change notification etc.

While dependency properties are declared as static members in class they are used, Field objects are declared in a nested class named RowFields. This allows to group and reference them easier, without having to add *Field* or *Property* suffix, and keeps our entity clear from field declarations.

```cs
public Int32? Age
{
	get { return Fields.Age[this]; }
	set { Fields.Age[this] = value; }
}
```

Here is our second property, named `Age`, with type `Int32?`.

Serenity entity properties are always nullable, even if database column is not nullable.

> Serenity never use zero in place of null.

This might seem unlogical, if you have a background of other ORMs, but consider this:

Is it not possible for a not null field to have a null value, if you query it through a left/right join? How can you say, if its retrieved value is null or zero in that case?

> Reference types are already nullable, so you can't write `String?`.



