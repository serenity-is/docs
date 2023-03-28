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

        public bool ActivateFor(IRow row)
        {
            if (row is not IMultiTenantRow mt)
                return false;

            fldTenantId = mt.TenantIdField;
            return true;
        }

        public void OnPrepareQuery(IRetrieveRequestHandler handler,
            SqlQuery query)
        {
            if (!handler.Context.Permissions.HasPermission(PermissionKeys.Tenants))
                query.Where(fldTenantId == handler.Context.User.GetTenantId());
        }

        public void OnPrepareQuery(IListRequestHandler handler,
            SqlQuery query)
        {
            if (!handler.Context.Permissions.HasPermission(PermissionKeys.Tenants))
                query.Where(fldTenantId == handler.Context.User.GetTenantId());
        }

        public void OnSetInternalFields(ISaveRequestHandler handler)
        {
            if (handler.IsCreate)
                fldTenantId[handler.Row] = handler.Context.User.GetTenantId();
        }

        public void OnValidateRequest(ISaveRequestHandler handler)
        {
            if (handler.IsUpdate)
            {
                if (fldTenantId[handler.Old] != fldTenantId[handler.Row])
                    handler.Context.Permissions.ValidatePermission(PermissionKeys.Tenants, handler.Context.Localizer);
            }
        }

        public void OnValidateRequest(IDeleteRequestHandler handler)
        {
            if (fldTenantId[handler.Row] != handler.Context.User.GetTenantId())
                handler.Context.Permissions.ValidatePermission(PermissionKeys.Tenants, handler.Context.Localizer);
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
public class RoleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
{
    public RoleSaveHandler(IRequestContext context)
         : base(context)
    {
    }

    //removed methods we override

    //...
}

public class RoleDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoleDeleteHandler
{
    public RoleDeleteHandler(IRequestContext context)
         : base(context)
    {
    }
}

public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    public RoleRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}
```

And add *IMultiTenantRow* interface to *RoleRow*:

```cs
namespace MultiTenancy.Administration
{
    //...
    public sealed class RoleRow : Row<RoleRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
    {
        //...
        public Int32Field TenantIdField
        {
            get => Fields.TenantId;
        }
        //...
    }
}
```

You should get the same result with much less code. Declarative programming is almost always better.