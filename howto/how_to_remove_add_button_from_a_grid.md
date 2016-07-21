# How To: Remove Add Button from a Grid

> ** This section was written for Saltaralle. For TypeScript version, see Basic Samples => Grids => Removing Add Button page in Serene**

You can override *getButtons()* method in *MyGrid.ts*.

This removes all buttons (including *refresh*):

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

To remove add button with its index (0 - first button):

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

> Working with hard coded indexes is a bad code smell

Or return a new list with your button list:

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