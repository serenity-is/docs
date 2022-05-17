# Securing Tenant Selection At Server Side

When you log in with *tenant2* user and open its edit form, *Tenant* selection dropdown is not visible, so he can't change his *tenant* from front-end if he is an ordinary user. But if he has some knowledge of how Serenity and its services work, he could send API request to the back-end.

When you are working with web, it's easy to create security holes in web applications unless you handle validations both at client side and server side.

Let's demonstrate it. Open Chrome console, while logged in with user *tenant2*.

Copy and paste this into console:

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

Now refresh the user management page, you'll see that *tenant2* can see admin user now!

We called *User Update* service with javascript, and changed *tenant2* user *TenaNntId* to *1 (Primary Tenant)*.

Let's revert it back to *Second Tenant (2)* first, then we'll fix this security hole:

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

Serenity provides field level permissions. Edit *UserRow.cs* to let the users with *Administration:Tenants* permission to see and edit tenant information.

```csharp
[LookupEditor(typeof(TenantRow))]
[ReadPermission(PermissionKeys.Tenants)]
public Int32? TenantId
{
    get => Fields.TenantId[this];
    set => Fields.TenantId[this] = value;
}
```

Now only *admin* can see and update *tenant* field for users.

> We didn't have to also set *ModifyPermission* as if a user doesn't have the read permission, he doesn't have the write permission by default.

Build your project, then try typing this into console again:

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

You will now get this error:

```text
Tenant field is read only!
```