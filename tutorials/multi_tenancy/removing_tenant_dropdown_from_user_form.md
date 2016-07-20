# 从用户窗体移除租户下拉列表

在你重新生成并启动项目后，现在的用户页面是这样的：

![Tenant2 Logged In](img/tenant2_filtered.png)

是的，再也不能看到 admin 用户，但是有些事不对劲。当你点击 *tenant2* 时，没有任何响应，却得到一个错误 “Can't load script data: Lookup.Administration.Tenant”。

该错误与我们在仓储层的最近一次过滤没有关系。它不能加载检索脚本，因为当前用户没有 *Tenants* 表的权限。但是最后怎么就看到该记录了？

可以看到该记录是由于我们之前是以 *admin* 身份登录并打开用户的编辑对话框，此时我们已经加载了这个检索脚本，并且浏览器对它进行缓存，因此当我们使用 *tenant2* 登录并打开编辑对话框时，它从浏览器缓存加载租户。

但这一次，因为我们重新生成项目，浏览器尝试从服务器加载它，由于 *tenant2* 不具有此权限，所以我们有了这个错误。It's ok，我们不想让他有此权限，但如何避免出现这个错误呢？

我们需要从用户窗体删除 *Tenant* 字段。但是 *admin* 用户需要这个字段，所以，我们不能简单地从 *UserForm.cs* 删除它。因此，我们需要有条件地做这事。

转换所有 T4 文件，然后打开 *MultiTutorial.Web/Modules/Administration/ User/UserDialog.ts* 并重写 *getPropertyItems* 方法：

```ts
namespace Serene.Administration {

    @Serenity.Decorators.registerClass()
    export class UserDialog extends Serenity.EntityDialog<UserRow, any> {
        //...
        
        protected getPropertyItems() {
            let items = super.getPropertyItems();
            if (!Authorization.hasPermission("Administration:Tenants"))
                items = items.filter(x => x.name != UserRow.Fields.TenantId);
            return items;
        }
    }
```

> 如果 Serenity < 2.0：
> 转换所有 T4 文件，然后打开 *UserDialog.cs* 并重写 *GetPropertyItems* 方法：
>
>
>```cs
>namespace MultiTenancy.Administration
>{
>    using jQueryApi;
>    using Serenity;
>    using System.Collections.Generic;
>    using System.Linq;
>
>    //...
>    public class UserDialog : EntityDialog<UserRow>
>    {
>        //...
>        protected override List<PropertyItem> GetPropertyItems()
>        {
>            var items = base.GetPropertyItems();
>
>            if (!Authorization.HasPermission("Administration:Tenants"))
>                items = items.Where(x => 
>                    x.Name != UserRow.Fields.TenantId).ToList();
>
>            return items;
>        }
>    }
>}
>```

*GetPropertyItems* 是对话框从服务器端表单定义获取表单字段的方法。从服务器端定义的 *UserForm* 中读取该字段。

如果没有租户的管理权限，我们在客户端的表单定义中移除 *TenantId* 字段。

只是在对话框实例中删除 *TenantId* 字段，实际上，并没有修改表单定义。

现在 tenant2 可以编辑自己的用户。

> 有些用户报告说，这也将删除 admin 用户的租户选择。请确保你 MultiTenancy.Script 项目中 Authorization.cs 文件的 HasPermission 方法是这样的：

>```cs
>public static bool HasPermission(string permissionKey)
>{
>   return 
>        UserDefinition.Username == "admin" ||
>        UserDefinition.Permissions[permissionKey];
>}
>```