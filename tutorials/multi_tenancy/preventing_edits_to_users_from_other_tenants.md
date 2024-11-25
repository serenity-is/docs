# Preventing Edits To Users From Other Tenants

Remember, a user with the identifier _tenant2_ should not be able to update their tenantId through service calls. It's crucial to secure this on the server side.

Even if users cannot view other tenants' users by default, they can still retrieve and update them. This poses a security risk.

## Example of a Security Vulnerability

To demonstrate, open the Users page, then open the Chrome console and enter the following:
```js
new (Q.getType('MovieTutorial.Administration.UserDialog'))().loadByIdAndOpenDialog(1)
```
> Ensure you have `@Decorators.registerClass("MovieTutorial.Administration.UserDialog")` at the top of your `UserDialog` class.

As shown, anyone can open the user dialog for the _admin_ user and update it. The UserDialog class is invoked when clicking a username on the user administration page. We create a new instance of it and request to load a user entity by its ID, where the _admin_ user has an ID of 1.

To load the entity with ID 1, the dialog calls the Retrieve service of `UserRetrieveHandler`. Note that we applied filtering in the List method of `UserListHandler`, not in Retrieve. Consequently, the service is unaware of whether it should return this record from another tenant.

## Securing the Retrieve Service
To secure the retrieve service in `UserRetrieveHandler`, modify the class as follows:

```cs
public class UserRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserRetrieveHandler
{
    public UserRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }

    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);

        if (!Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(MyRow.Fields.TenantId == User.GetTenantId());
    }
}
```

We applied similar changes to `UserListHandler` previously. After these modifications, attempting the same JavaScript code will result in an error:

```txt
Record not found. It might be deleted or you don't have required permissions!
```

## Securing the Update Service

However, it is still possible to update the record by manually calling the `Update` service. Therefore, it is necessary to secure the `UserSaveHandler` as well. Update its `ValidateRequest` method as shown below:

Change its `ValidateRequest` method like this:

```cs
protected override void ValidateRequest()
{
    base.ValidateRequest();

    if (IsUpdate)
    {
        if (Old.TenantId != User.GetTenantId())
            Permissions.ValidatePermission(PermissionKeys.Tenants, Context.Localizer);
            
        // ...
```

This check ensures that if an update is attempted, and the TenantId of the record being updated (Old.TenantId) differs from the currently logged-in user's TenantId, the system verifies that the user has tenant administration permissions. If not, an error is raised:

```
Authorization has been denied for this request!
```

## Preventing Deletion of Users from Other Tenants

Similar to the vulnerabilities in the Retrieve and Update services, the Delete handler is also susceptible to unauthorized access. To mitigate this, it is essential to secure the `UserDeleteHandler` to ensure that users can only delete records within their own tenant.

There are delete and undelete handlers, and they suffer from similar security holes.

To secure the delete service in `UserDeleteHandler`, modify the class as follows:

```cs
public class UserDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUserDeleteHandler
{
    public UserDeleteHandler(IRequestContext context)
         : base(context)
    {
    }

    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        if (Row.TenantId != User.GetTenantId())
            Permissions.ValidatePermission(PermissionKeys.Tenants, Context.Localizer);
    }
    //...
```