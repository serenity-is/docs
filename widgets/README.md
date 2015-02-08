# Widgets

Serenity Script UI layer's component classes (control) are based on a system that is similar to *jQuery UI*'s *Widget Factory*, but redesigned for C#.

> You can find more information about jQuery UI widget system here:
>
> http://learn.jquery.com/jquery-ui/widget-factory/
>
> http://msdn.microsoft.com/en-us/library/hh404085.aspx

Widget, is an object that is attached to an HTML element and extends it with some behaviour.

For example, IntegerEditor widget, when attached to an INPUT element, makes it easier to enter numbers in the input and validates that the entered number is a correct integer.

Similarly, a Toolbar widget, when attached to a DIV element, turns it into a toolbar with tool buttons (in this case, DIV acts as a placeholder).
