# 在用户对话框中选择租户 

我们在 *Users* 表中添加一个 *TenantId* 字段，但是没有在 UserRow 中定义，并且也不能在用户对话框中看到该字段。 

该字段只能被 *admin* 用户查看和编辑。即使是授予了访问管理租户权限的其他用户也不能查看或者修改这些信息。 

首先把 *TenantId* 字段添加到 *UserRow.cs*：

```cs
namespace MultiTenancy.Administration.Entities
{
    //...
    public sealed class UserRow : LoggingRow, IIdRow, INameRow
    {
        //...
        [DisplayName("Last Directory Update"), Insertable(false), Updatable(false)]
        public DateTime? LastDirectoryUpdate
        {
            get { return Fields.LastDirectoryUpdate[this]; }
            set { Fields.LastDirectoryUpdate[this] = value; }
        }

        [DisplayName("Tenant"), ForeignKey("Tenants", "TenantId"), LeftJoin("tnt")]
        [LookupEditor(typeof(TenantRow))]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Tenant"), Expression("tnt.TenantName")]
        public String TenantName
        {
            get { return Fields.TenantName[this]; }
            set { Fields.TenantName[this] = value; }
        }

        //...
        public class RowFields : LoggingRowFields
        {
            //...
            public readonly DateTimeField LastDirectoryUpdate;
            public readonly Int32Field TenantId;
            public readonly StringField TenantName;
            //...
        }
    }
}

```

要编辑该字段，我们需要在 *UserForm.cs* 添加它：

```cs
namespace MultiTenancy.Administration.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [FormScript("Administration.User")]
    [BasedOnRow(typeof(Entities.UserRow))]
    public class UserForm
    {
        public String Username { get; set; }
        public String DisplayName { get; set; }
        [EmailEditor]
        public String Email { get; set; }
        [PasswordEditor]
        public String Password { get; set; }
        [PasswordEditor, OneWay]
        public String PasswordConfirm { get; set; }
        [OneWay]
        public string Source { get; set; }
        public Int32? TenantId { get; set; }
    }
}
```

同样需要增加用户对话框的大小，在 *site.administration.less* 中设置： 

```less
.s-UserDialog {
    > .size { .widthAndMin(650px); }
    .dialog-styles(@h: auto, @l: 150px, @e: 400px);
    .categories { height: 300px; }
}
```

现在，打开 *User Management* 页面并创建一个属于第二个租客的用户 *tenant2*。

![Tenant2 User](img/create_tenant2_user.png)

创建此用户之后, 编辑其权限并授予他用户、 角色管理和权限，因为这将是我们的第二个租客的管理用户。

## 使用 Tenant2 登录 

退出并使用 *tenant2* 身份登录系统。

当你打开 *User Management* 页面，你将看到该用户除了可以查看和编辑自己的 *tenant2* 用户，还可以查看和编辑 *admin* 用户。 

![Tenant2 Logged In](img/tenant2_logged_in.png)

这并不是我们所希望的。

让我们阻止他看到其他租户的用户。
