# Entities (Row)


Serenity entity system is a micro-orm, which is in love with SQL just like Dapper. 

Unlike full blown ORMs like NHibernate / Entity Framework, Serenity provides minimum features required to map and query databases with intellisense, compile time checking and easy refactoring.

Serenity entities are usually named like *XYZRow*. They are subclasses of *Serenity.Data.Row*.

Let's define a simple row class:

```cs
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

> Rows are JSON serializable, so they can be returned from services without any problems. You don't need extra POCO/DTO classes and Entity <-> DTO mapping (though you may use them if you want).

