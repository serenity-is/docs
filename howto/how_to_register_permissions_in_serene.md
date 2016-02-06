# How To: Register Permissions in Serene

Serene shows a list of permissions in user and role permission dialogs. To show your own permissions there, you need to use these permissions with one of the attributes below:

- Attributes that derive from PermissionAttributeBase:
    - *ReadPermission*
    - *ModifyPermission*
    - *InsertPermission* 
    - *UpdatePermission*
    - *DeletePermission*


- Page and Endpoint Access Control Attributes:
    - *PageAuthorize*
    - *ServiceAuthorize*

These attributes can be used with and located from one of these types:

- On top of *XYZRow* (Read, Write, Insert, Update, Delete permissions)
- On top of *XYZPage* and in action methods (PageAuthorize)
- On top of *XYZEndpoint* and in service actions (ServiceAuthorize)

If you don't use a permission key with any of them but still want to show it in permission dialogs, you can use *RegisterPermission* attribute on assembly (write this anywhere in YourProject.Web):

```cs
[assembly: Serenity.ComponentModel.RegisterPermissionKey("MySpecialPermissionKey")]
```

