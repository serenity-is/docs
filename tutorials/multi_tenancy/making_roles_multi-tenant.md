# 多租户角色

目前为止，我们已经让用户页面在多租户风格下工作。为使它工作，我们看起来并没有做太多的变化。但请记住，我们正在对一个原来不是多租户的系统作修改。

让我们在 Roles 表应用类似的原则。

再一次，一个租户的用户在不能查看或修改其他租户的角色，每个租户的用户是相互独立工作的。

我们先在 *RoleRow.cs* 添加 *TenantId* 属性：

```cs
namespace MultiTenancy.Administration.Entities
{
    //...
    public sealed class RoleRow : Row, IIdRow, INameRow
    {
        [Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }
        
        //...
        
        public class RowFields : RowFieldsBase
        {
            //...
            public readonly Int32Field TenantId;
            //...
        }
    }
}
```

然后，我们在 *RoleRepository.cs* 做几处修改：

```cs
private class MySaveHandler : SaveRequestHandler<MyRow>
{
    protected override void SetInternalFields()
    {
        base.SetInternalFields();

        if (IsCreate)
            Row.TenantId = ((UserDefinition)Authorization.UserDefinition).TenantId;
    }
}

private class MyDeleteHandler : DeleteRequestHandler<MyRow>
{
    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        var user = (UserDefinition)Authorization.UserDefinition;
        if (Row.TenantId != user.TenantId)
            Authorization.ValidatePermission(PermissionKeys.Tenants);
    }
}

private class MyRetrieveHandler : RetrieveRequestHandler<MyRow>
{
    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);

        var user = (UserDefinition)Authorization.UserDefinition;
        if (!Authorization.HasPermission(PermissionKeys.Tenants))
            query.Where(fld.TenantId == user.TenantId);
    }
}

private class MyListHandler : ListRequestHandler<MyRow>
{
    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);

        var user = (UserDefinition)Authorization.UserDefinition;
        if (!Authorization.HasPermission(PermissionKeys.Tenants))
            query.Where(fld.TenantId == user.TenantId);
    }
}
```

