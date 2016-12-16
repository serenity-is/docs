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




