# Attributes

## AlignCenter Attribute

> **namespace**: *Serenity.ComponentModel*, **assembly**: *Serenity.Core*

Centers text horizontally.

* Used to control text alignment in grids by adding `align-center` CSS class to corresponding SlickGrid column.

* Note that it has no effect on editors or forms.

## AlignRight Attribute

> **namespace**: *Serenity.ComponentModel*, **assembly**: *Serenity.Core*

Right aligns text horizontally.

* Used to control text alignment in grids by adding `align-right` CSS class to corresponding SlickGrid column.

* Note that it has no effect on editors or forms.

## Visible Attribute

> **namespace**: *Serenity.ComponentModel*, **assembly**: *Serenity.Core*

Controls visibility of a column or form field.

It is also possible to hide a field by passing *false* as its value.

```cs
public class SomeColumns
{
    [Visible]
    public string ExplicitlyVisible { get; set; }
    [Visible(false)]
    public string ExplicitlyHidden { get; set; }
}
```

## Hidden Attribute

> **namespace**: *Serenity.ComponentModel*, **assembly**: *Serenity.Core*

Hides a column or form field.

This is just a subclass of *VisibleAttribute* with *false* value.

```cs
public class SomeColumns
{
    [Hidden]
    public string HiddenColumn { get; set; }
}
```

## Insertable Attribute

> **namespace**: *Serenity.ComponentModel*, **assembly**: *Serenity.Core*

Controls if a property is editable in new record mode.

* When used on row fields, turns on or off the Insertable flag.

* It has no effect on columns

```cs
public class SomeForm
{
    [Insertable(false)]
    public string ReadOnlyOnInsert { get; set; }
}
```

## Updatable Attribute

> **namespace**: *Serenity.ComponentModel*, **assembly**: *Serenity.Core*

Controls if a property is editable in edit record mode.

* When used on row fields, turns on or off the Updatable flag.

* It has no effect on columns

```cs
public class SomeForm
{
    [Updatable(false)]
    public string ReadOnlyOnUpdate { get; set; }
}
```

## DisplayName Attribute

> **namespace**: *System.ComponentModel*, **assembly**: *System*

Determines default title for grid columns or form fields.

```cs
public class SomeForm
{
    [DisplayName("Title for Some Field")]
    public string SomeField { get; set; }
}
```

* DisplayName attribute cannot be used on Enum members, so you have to use
Description attribute

* Titles set with this attribute is considered to be in *invariant* language.

> This is not a Serenity attribute, it resides in .NET System assembly.

## Description Attribute

> **namespace**: *System.ComponentModel*, **assembly**: *System*

Determines default title for enum members.

```cs
public class SomeEnum
{
    [Description("Title for Value 1")]
    Value1 = 1,
    [Description("Value 2")]
    Value2 = 2
}
```

* Titles set with this attribute is considered to be in *invariant* language.

> This is not a Serenity attribute, it resides in .NET System assembly.
