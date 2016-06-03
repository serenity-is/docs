# How To: Add a Row Selection Column

** This section is pending update for TypeScript **

To add a column to select individual rows or all rows, GridRowSelectionMixin can be used.

> GridRowSelectionMixin is available in Serenity 1.6.8+

Sample code:

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
