# Securing Tenant Selection At Server Side

When you log in with a _tenant2_ user and open its edit form, the *Tenant* selection dropdown is not visible, preventing the user from changing their tenant from the front end if they are an ordinary user. However, if they have knowledge of how Serenity and its services work, they could send an API request to the back end.

When working with web applications, it is easy to create security vulnerabilities unless validations are handled both on the client side and the server side.

Let's demonstrate this. Open the Chrome console while logged in as the _tenant2_ user.

Copy and paste the following into the console:

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

Now refresh the user management page, you'll see that _tenant2_ user record is gone! This is because the user is now associated with another tenant. Hovever, the user claims in this session still point to _tenant2_.

We called the *User Update* service with JavaScript and changed the _tenant2_ user's TenantId to 1 (Primary Tenant).

First, revert it back to *Second Tenant (2)*, then we'll address this security vulnerability:

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

Serenity provides field-level permissions. Edit `UserRow.cs` to allow users with the *Administration:Tenants* permission to view and edit tenant information.

```csharp
[LookupEditor(typeof(TenantRow))]
[ReadPermission(PermissionKeys.Tenants)]
public int? TenantId { get => Fields.TenantId[this]; set => Fields.TenantId[this] = value; }
```

Now, only an _admin_ can view and update the *tenant* field for users.

> We did not need to set *ModifyPermission* explicitly. if a user does not have read permission, they do not have write permission by default.

Build your project, then try typing the following into the console:

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

You will now receive the following error:

```text
Tenant field is read only!
```