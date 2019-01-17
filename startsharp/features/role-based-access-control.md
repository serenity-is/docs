# Role Based Access Control

StartSharp allows you to grant/deny access to pages, services or other parts of your application based on user roles in addition to permission key based validation.

```cs
[ReadPermission("Role:Sales")]
public class SomeResource
{
}
```

```cs
if (Authorization.HasPermission("Role:Auditor"))
{
	// ...
}
```

> This works on Role names you define in the Roles page. It is also possible to assign unique *String Keys* to roles and use these for access control instead of depending on role names directly.