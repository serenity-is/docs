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
                    return "<a class='delete-row' title='delete' />";
                }
            });

            return columns;
        }
    }
}
```

Now we 