# 部件(Widgets)

Serenity 脚本 UI 层的组件类（控制）基于类似于 *jQuery UI 的部件工厂* 系统，但使用 C# 重新设计。

> 你可以在这里找到有关 jQuery UI 部件系统的更多详细信息：
>
> http://learn.jquery.com/jquery-ui/widget-factory/
>
> http://msdn.microsoft.com/en-us/library/hh404085.aspx

部件(Widget)，是附加到 HTML 元素并扩展其行为的对象。

例如，当 IntegerEditor 部件附加到 INPUT 元素时，IntegerEditor 部件让该元素输入数字更加容易并验证输入的数字是否是正确的整数。

类似地，当一个工具栏部件附加到 DIV 元素时，该 DIV 元素便变成了一个带有工具按钮的工具栏（在本例中，DIV 仅作为占位符）。
