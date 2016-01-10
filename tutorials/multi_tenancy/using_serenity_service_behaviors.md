# Using Serenity Service Behaviors

If wanted to extend this multi-tenant system to other tables in Northwind, we would repeat same steps we did with Roles. Though it doesn't look so hard, it's too much of manual work.

Serenity provides service behavior system, which allows you to intercept Create, Update, Retrieve, List, Delete handlers and add custom code to them.

Some operations in these handlers, like capture log, unique constraint validation etc. are already implemented as service behaviors.

Behaviors might be activated for all rows, or based on some rule, like having a specific attribute or interface. For example, CaptureLogBehavior activates for rows with [CaptureLog] attribute.

We'll first define an interface *IMultiTenantRow* that will trigger our new behavior. Place this class next to *TenantRow.cs*:

```

```



