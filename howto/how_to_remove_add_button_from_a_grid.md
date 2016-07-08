# 如何删除网格中的新增（add）按钮？

** 本节的 TypeScript 版本有待更新 **

你可以在 *MyGrid.ts* 重写 *getButtons()* 方法。

下面的代码会删除所有按钮（包括 *刷新*）：

```cs
public class MyGrid : EntityGrid<MyRow>
{
    //...
    
    protected override List<ToolButton> GetButtons()
    {
        return new List<ToolButton>();
    }
}
```

使用索引（0 - 第一个按钮）删除新增（add）按钮：

```cs
public class MyGrid : EntityGrid<MyRow>
{
    //...
    
    protected override List<ToolButton> GetButtons()
    {
        var buttons = base.GetButtons();
        buttons.RemoveAt(0);
        return buttons;
    }
}
```

> 使用硬编码索引有一种糟糕代码的气味 

或者，返回一个新的按钮列表：

```cs
public class MyGrid : EntityGrid<MyRow>
{
    //...
    
    protected override List<ToolButton> GetButtons()
    {
        var buttons = new List<ToolButton>();

        buttons.Add(new ToolButton
        {
            Title = "My New Button",
            CssClass = "my-new-button",
            OnClick = delegate {
                // ...
            }
        });

        buttons.Add(NewRefreshButton(noText: true));

        return buttons;
    }
}
```