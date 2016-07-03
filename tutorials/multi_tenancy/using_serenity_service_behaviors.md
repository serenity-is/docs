# 使用 Serenity 服务行为 

如果想把多租户系统扩展到 Northwind 数据库中的其他表，我们会重复角色所做的相同步骤。虽然看起来没那么难，但是有太多的手工工作。

Serenity 提供服务行为系统，它可以允许我们拦截添加、更新、检索、列表、删除的操作处理并向其添加用户自定义代码。

在这些处理中有一些操作（如像获取日志、唯一约束验证等）已经使用服务行为实现了。

行为（Behaviors）可能被所有的行（rows）激活，或被基于某些规则（如特定的特性或接口）的行激活。例如，含 [CaptureLog] 特性的行激活 CaptureLogBehavior。

我们首先定义一个将触发新行为的接口 *IMultiTenantRow*。把此类放在 *TenantRow.cs* 旁边的 *IMultiTenantRow.cs* 中：

```cs
using Serenity.Data;

namespace MultiTenancy
{
    public interface IMultiTenantRow
    {
        Int32Field TenantIdField { get; }
    }
}
```

然后在旁边的 *MultiTenantBehavior.cs* 文件添加行为：

```cs
using MultiTenancy.Administration;
using Serenity;
using Serenity.Data;
using Serenity.Services;

namespace MultiTenancy
{
    public class MultiTenantBehavior : IImplicitBehavior,
        ISaveBehavior, IDeleteBehavior,
        IListBehavior, IRetrieveBehavior
    {
        private Int32Field fldTenantId;

        public bool ActivateFor(Row row)
        {
            var mt = row as IMultiTenantRow;
            if (mt == null)
                return false;

            fldTenantId = mt.TenantIdField;
            return true;
        }

        public void OnPrepareQuery(IRetrieveRequestHandler handler, 
            SqlQuery query)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (!Authorization.HasPermission(PermissionKeys.Tenants))
                query.Where(fldTenantId == user.TenantId);
        }

        public void OnPrepareQuery(IListRequestHandler handler, 
            SqlQuery query)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (!Authorization.HasPermission(PermissionKeys.Tenants))
                query.Where(fldTenantId == user.TenantId);
        }

        public void OnSetInternalFields(ISaveRequestHandler handler)
        {
            if (handler.IsCreate)
                fldTenantId[handler.Row] =
                    ((UserDefinition)Authorization
                        .UserDefinition).TenantId;
        }

        public void OnValidateRequest(IDeleteRequestHandler handler)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (fldTenantId[handler.Row] != user.TenantId)
                Authorization.ValidatePermission(
                    PermissionKeys.Tenants);
        }

        public void OnAfterDelete(IDeleteRequestHandler handler) { }
        public void OnAfterExecuteQuery(IRetrieveRequestHandler handler) { }
        public void OnAfterExecuteQuery(IListRequestHandler handler) { }
        public void OnAfterSave(ISaveRequestHandler handler) { }
        public void OnApplyFilters(IListRequestHandler handler, SqlQuery query) { }
        public void OnAudit(IDeleteRequestHandler handler) { }
        public void OnAudit(ISaveRequestHandler handler) { }
        public void OnBeforeDelete(IDeleteRequestHandler handler) { }
        public void OnBeforeExecuteQuery(IRetrieveRequestHandler handler) { }
        public void OnBeforeExecuteQuery(IListRequestHandler handler) { }
        public void OnBeforeSave(ISaveRequestHandler handler) { }       
        public void OnPrepareQuery(IDeleteRequestHandler handler, SqlQuery query) { }
        public void OnPrepareQuery(ISaveRequestHandler handler, SqlQuery query) { }
        public void OnReturn(IDeleteRequestHandler handler) { }
        public void OnReturn(IRetrieveRequestHandler handler) { }
        public void OnReturn(IListRequestHandler handler) { }
        public void OnReturn(ISaveRequestHandler handler) { }
        public void OnValidateRequest(IRetrieveRequestHandler handler) { }
        public void OnValidateRequest(IListRequestHandler handler) { }
        public void OnValidateRequest(ISaveRequestHandler handler) { }
    }
}
```

行为类实现 IImplicitBehavior 接口来决定是否应该被指定的行类型（row type）激活。 

它是通过实现 *ActivateFor* 方法做到的，该方法由请求处理（request handlers）调用。

在该方法中，我们检查行类型（row type）是否实现 *IMultiTenantRow* 接口，如果没有，则返回 false。 

然后，我们得到一个 *TenantIdField* 的私有引用，以便之后在其他方法中使用。

*ActivateFor* 在每个处理类型（handler type）和行（row）中只被调用一次。如果该方法返回 true，行为实例出于性能考虑而被缓存，并且被该行（row）和处理类型（handler type）重用。

因此，由于每个实例都被所有的请求共享，所以你在其他方法中所写的代码必须是线程安全的。

一个行为通过实现 *IRetrieveBehavior*, *IListBehavior*, *ISaveBehavior*, 或 *IDeleteBehavior* 接口，可以拦截一个或多个*检索*、*列表*、*保存*、*删除* 处理。

在这里，我们需要拦截所有这些服务调用，因此我们实现所有的接口。

我们只实现相关的方法，其他的方法保留为空。

我们这里实现的方法，对应于上一章节在 *RoleRepository.cs* 重写的方法。它们所包含的代码几乎是相同的，但我们这里需要更加通用，因为该行为将为所有实现 *IMultiTenantRow* 接口的行类型工作。 

## 使用行为重新实现 RoleRepository  

现在还原我们在 *RoleRepository.cs* 做的所有修改：

```cs
private class MySaveHandler : SaveRequestHandler<MyRow> { }
private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
private class MyListHandler : ListRequestHandler<MyRow> { }
```

并且在 *RoleRow* 添加 *IMultiTenantRow* 接口：

```cs
namespace MultiTenancy.Administration.Entities
{
    //...
    public sealed class RoleRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        //...
        public Int32Field TenantIdField
        {
            get { return Fields.TenantId; }
        }
        //...
    }
}
```

使用更少的代码得到相同的结果。声明式编程几乎总是更好的选择。