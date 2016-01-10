# Using Serenity Service Behaviors

If wanted to extend this multi-tenant system to other tables in Northwind, we would repeat same steps we did with Roles. Though it doesn't look so hard, it's too much of manual work.

Serenity provides service behavior system, which allows you to intercept Create, Update, Retrieve, List, Delete handlers and add custom code to them.

Some operations in these handlers, like capture log, unique constraint validation etc. are already implemented as service behaviors.

Behaviors might be activated for all rows, or based on some rule, like having a specific attribute or interface. For example, CaptureLogBehavior activates for rows with [CaptureLog] attribute.

We'll first define an interface *IMultiTenantRow* that will trigger our new behavior. Place this class in file *IMultiTenantRow.cs*, next to *TenantRow.cs*:

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

Than add this behavior in file *MultiTenantBehavior.cs* next to it:

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

Behavior classes with IImplicitBehavior interface decide if they should be activated for a specific row type.

They do this by implementing *ActivateFor* method, which is called by request handlers.

In this method, we check if row type implements *IMultiTenantRow* interface. If not it simply returns false.

Then we get a private reference to *TenantIdField* to reuse it later in other methods.

*ActivateFor* is only called once per every handler type and row. If this method returns true, behavior instance is cached aggresively for performance reasons, and reused for any request for this row and handler type.

Thus, everything you write in other methods must be thread-safe, as one instance is shared by all requests.

A behavior, might intercept one or more of *Retrieve*, *List*, *Save*, *Delete* handlers. It does this by implementing *IRetrieveBehavior*, *IListBehavior*, *ISaveBehavior*, or *IDeleteBehavior* interfaces.

Here, we need to intercept all of these service calls, so we implement all interfaces.

We only fill in methods we are interested in, and leave others empty.

The methods we implement here, corresponds to methods we override in *RoleRepository.cs* in previous section. The code they contain is almost same, except here we need to be more generic, as this behavior will work for any row type implementing *IMultiTenantRow*.

## Reimplementing RoleRepository With Using the Behavior

Now revert every change we made in *RoleRepository.cs*:

```cs
private class MySaveHandler : SaveRequestHandler<MyRow> { }
private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
private class MyListHandler : ListRequestHandler<MyRow> { }
```

And add *IMultiTenantRow* interface to *RoleRow*:

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

You should get the same result with much less code. Declarative programming is almost always better.