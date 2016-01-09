# How To: Add Inline Action Buttons To Grid

You may add some inline action icons to grid columns, to delete current row, open a dialog, call a service etc.

Let's add a new column with delete button to CustomersGrid. 

> First remove IAsyncInit interface from CustomerGrid, otherwise you'll have to override GetColumnsAsync.


```cs

namespace Serene.Northwind
{
    //...
    public class CustomerGrid : EntityGrid<CustomerRow>
    {
        public CustomerGrid(jQueryObject container)
            : base(container)
        {
        }
        //...
        protected override List<SlickColumn> GetColumns()
        {
            var columns = base.GetColumns();

            columns.Add(new SlickColumn
            {
                Field = "DeleteRow",
                Title = "",
                Format = ctx =>
                {
                    return "<a class='inline-action delete-row' title='delete' />";
                }
            });

            return columns;
        }
    }
}
```

Now we need to style our button. Add these lines to end of site.less:

```less
.inline-action {
    background-repeat: no-repeat;
    background-position: center center;
    width: 16px;
    height: 16px;
    cursor: pointer;
    opacity: 0.5;
    display: inline-block;

    &:hover {
        opacity: 1;
    }
}

.delete-row {
    background-image: url(../serenity/images/delete2.png);
}
```

I used inline-action base CSS class to set default button style with it. This way you can create different action buttons just by changing delete-row class with something else and setting its background-image only.

After rebuild and run, we now have a delete link in rightmost column of Customers grid. When you click it nothing happens, as we didn't handle it yet.

```cs
protected override void OnClick(jQueryEvent e, int row, int cell)
{
    base.OnClick(e, row, cell);

    if (e.IsDefaultPrevented())
        return;

    var item = Items[row];

    if (J(e.Target).HasClass("inline-action"))
    {
        e.PreventDefault();

        if (J(e.Target).HasClass("delete-row"))
        {
            Q.Confirm("Delete record?", () =>
            {
                CustomerService.Delete(new DeleteRequest
                {
                    EntityId = item.ID.Value
                }, onSuccess: response => 
                {
                    Refresh();
                });
            });
        }
    }
}
```

Here we first check if click event is handled by base grid class to prevent handling same event twice. For example, base grid class handles edit links on customer ID and name columns.

Then we get a reference to entity in the clicked row.

Next step is to check if clicked HTML element has inline-action class. If so we prevent default handlers.

Then we check if clicked element is our delete-row action. If so we ask for confirmation from user to be sure. Q.Confirm calls action specified in its second parameter, if user clicks Yes.

If so, we call CustomerService.Delete method, do delete clicked row. In its success callback, we refresh the grid.

Let's add another action to edit customer (you could open another dialog same way).

```cs
protected override List<SlickColumn> GetColumns()
{
    var columns = base.GetColumns();

    columns.Add(new SlickColumn
    {
        Field = "DeleteRow",
        Title = "",
        Format = ctx =>
        {
            return "<a class='inline-action delete-row' title='delete' />";
        },
        Width = 32
    });

    columns.Add(new SlickColumn
    {
        Field = "EditRow",
        Title = "",
        Format = ctx =>
        {
            return "<a class='inline-action edit-row' title='edit customer' />";
        },
        Width = 32
    });

    return columns;
}
```




