# 如何添加一个行选择列? 

** 本节的 TypeScript 版本有待更新 **

若要添加列以选择单行或所有行，可以使用 GridRowSelectionMixin。

> GridRowSelectionMixin 在 Serenity 1.6.8+ 有效。 

示例代码：

```
public class MyGrid : EntityGrid<MyRow>
{
    private GridRowSelectionMixin rowSelection;

    public MyGrid(jQueryObject container)
        : base(container)
    {
        rowSelection = new GridRowSelectionMixin(this);
    }

    protected override List<SlickColumn> GetColumns()
    {
        var columns = base.GetColumns();
        columns.Insert(0, GridRowSelectionMixin.CreateSelectColumn(() => rowSelection));
        return columns;
    }
    
    protected override List<ToolButton> GetButtons()
    {
        var buttons = base.GetButtons();

        buttons.Add(new ToolButton
        {
            CssClass = "tag-button",
            Title = "Do Something With Selected Rows",
            OnClick = delegate
            {
                var selectedIDs = rowSelection.GetSelectedKeys();
                if (selectedIDs.Count == 0)
                    Q.NotifyWarning("Please select some rows");
                else
                    Q.NotifySuccess("You have selected " + selectedIDs.Count + 
                        " row(s) with ID(s): " + string.Join(", ", selectedIDs));
            }
        });

        return buttons;
    }

}
```
