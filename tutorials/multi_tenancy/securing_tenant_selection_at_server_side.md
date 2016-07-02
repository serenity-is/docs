# 在服务端对租户选择进行安全检测 

当使用 *tenant2* 身份登录并打开它的编辑窗体，没有显示选择 *Tenant* 下拉列表，因此不能改变它的 *Tenant* 吗？  

错！

如果是一个普通的用户，就不能改变 *Tenant*。但如果有一些 Serenity 和服务器工作原理的知识，就能修改 *Tenant*。 

当你正在使用 web 时，你得更认真地对待安全。 

这是非常容易在 web 应用程序中创建安全漏洞，除非你在客户端和服务器端都进行验证处理。

我们来演示一下。当使用 *tenant2* 身份登录时，打开 Chrome 控制台。

复制下面的代码，并把它粘贴到控制台：

```js
Q.serviceCall({ 
    service: 'Administration/User/Update', 
    request: { 
        EntityId: 2, 
        Entity: { 
            UserId: 2, 
            TenantId: 1 
        }
    }
});
```

现在刷新用户管理页面，你将看到 *tenant2* 现在可以看到 admin 用户。 

我们使用 javascript 调用 *User Update* 服务，并把 *tenant2* 用户的 *TenaNntId* 修改为 * 1 (主租客)*。

让我们把它还原回 *第二承租人(2)*，然后我们将修复这个安全漏洞：

```js
Q.serviceCall({ 
    service: 'Administration/User/Update', 
    request: { 
        EntityId: 2, 
        Entity: { 
            UserId: 2, 
            TenantId: 2 
        }
    }
});
```

打开 *UserRepository.cs*，定位到 *MySaveHandler* 类，并修改它的 *GetEditableFields* 方法：


```cs
protected override void GetEditableFields(HashSet<Field> editable)
{
    base.GetEditableFields(editable);

    if (!Authorization.HasPermission(Administration.PermissionKeys.Security))
    {
        editable.Remove(fld.Source);
        editable.Remove(fld.IsActive);
    }

    if (!Authorization.HasPermission(Administration.PermissionKeys.Tenants))
    {
        editable.Remove(fld.TenantId);
    }
}
```

生成你的项目，然后尝试再次在控制台输入：

```js
Q.serviceCall({ 
    service: 'Administration/User/Update', 
    request: { 
        EntityId: 2, 
        Entity: { 
            UserId: 2, 
            TenantId: 1 
        }
    }
});
```

你将得到这个错误：

```
Tenant field is read only!
```

SaveRequestHandler 调用 *GetEditableField* 方法来决定哪些字段是可编辑的，因此由用户更新。默认情况下，这些字段通过检索行（row）属性的 *Updatable* 和 *Insertable* 特性决定。  

> 除非特别指定，所有字段是可插入和可更新的。

如果我们没有租户管理权限，我们从自动确定可编辑字段列表中删除 *TenantId*。 
