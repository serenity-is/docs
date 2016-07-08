# 如何将内联动作按钮（Inline Action Buttons）添加到网格？

** 本节的 TypeScript 版本有待更新 **

你可以在网络添加一些内联动作图标，用以删除当前行、打开对话框、调用服务等。

让我们在客户网格列表（CustomersGrid）添加一个含删除按钮的新列。 

> 首先从 CustomerGrid 删除 IAsyncInit 接口，否则你得重写 GetColumnsAsync。


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
                    return "<a class='inline-action delete-row' title='delete'></a>";
                },
                Width = 24,
                MinWidth = 24,
                MaxWidth = 24                
            });

            return columns;
        }
    }
}
```

现在我们需要给我们的按钮添加样式。site.less 末尾添加下面的样式：

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

我用基本 CSS 类 inline-action 来设置默认按钮样式。通过这种方式，你可以只改变 delete-row 类并设置其 background-image 创建不同的动作按钮。

生成并运行项目后，在客户网格列表最右边，我们将有一个删除连接。当你点击该连接，不会有任何响应，因为我们还没有处理该点击事件。

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

我们首先检查点击事件是否被基本的网格类处理来防止同样的事件被处理再次。例如，基本的网格类在 customer ID 和 name 处理了编辑连接。

然后，我们获得点击行的实体。

下一步骤是检查单击的 HTML 元素是否有 inline-action 样式，如果有该样式，我们就阻止其默认行为。 

然后，我们检查单击元素是否是 delete-row 操作，如果是该操作，则弹出确认框给用户确认。 Q.Confirm 在第二个参数中指定用户确认操作后所调用的操作。 

如果用户确认了删除操作，我们调用 CustomerService.Delete 方法删除所选的行，并使用成功删除之后的回调方法刷新网格。 

让我们添加另一个操作来编辑客户（你可以用相同的方法打开另一对话框）。

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
            return "<a class='inline-action delete-row' title='delete'></a>";
        },
        Width = 24,
        MinWidth = 24,
        MaxWidth = 24
    });

    columns.Add(new SlickColumn
    {
        Field = "EditRow",
        Title = "",
        Format = ctx =>
        {
            return "<a class='inline-action edit-row' title='edit customer'></a>";
        },
        Width = 24,
        MinWidth = 24,
        MaxWidth = 24
    });

    return columns;
}
```

为其添加 CSS：

```less
.delete-row {
    background-image: url(../serenity/images/delete2.png);
}

.edit-row {
    background-image: url(../serenity/images/magnifier.png);
}
```

添加单击处理事件：

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
        else if (J(e.Target).HasClass("edit-row"))
        {
            var dlg = new CustomerDialog();
            InitEntityDialog(dlg);
            dlg.LoadByIdAndOpenDialog(item.ID.Value);
        }
    }
}
```

我们首先创建一个新的客户对话框。 InitEntityDialog  是 CustomerGrid 的一个方法，它允许附加 ondatachange 事件，因此当对话框的数据改变时，它可以自动刷新。然后，我们调用 LoadByIdAndOpenDialog 加载所选 ID 的客户到对话框，在加载完成后显示对话框。 




