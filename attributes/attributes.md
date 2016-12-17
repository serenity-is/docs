# Attributes

## AlignCenter Attribute

[**namespace**: *Serenity.ComponentModel*] - [**assembly**: *Serenity.Core*]

Centers text horizontally.

* Used to control text alignment in grids by adding `align-center` CSS class to corresponding SlickGrid column.

* Note that it has no effect on editors or forms.

## AlignRight Attribute

[**namespace**: *Serenity.ComponentModel*] - [**assembly**: *Serenity.Core*]

Right aligns text horizontally.

* Used to control text alignment in grids by adding `align-right` CSS class to corresponding SlickGrid column.

* Note that it has no effect on editors or forms.

## Visible Attribute

[**namespace**: *Serenity.ComponentModel*] - [**assembly**: *Serenity.Core*]

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

[**namespace**: *Serenity.ComponentModel*] - [**assembly**: *Serenity.Core*]

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

[**namespace**: *Serenity.ComponentModel*] - [**assembly**: *Serenity.Core*]

Controls if a property is editable in new record mode.

* When used on row fields, turns on or off the Insertable flag.

* It has no effect on columns

```cs
public class SomeForm
{
[Insertable(false)]
public string ReadOnlyOnNew { get; set; }
}
```

## Updatable Attribute

[**namespace**: *Serenity.ComponentModel*] - [**assembly**: *Serenity.Core*]

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
