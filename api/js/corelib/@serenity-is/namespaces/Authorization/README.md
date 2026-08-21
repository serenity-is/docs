[@serenity-is/corelib](../../../README.md) / Authorization

# Authorization

Provides permission checks and user-state accessors for the current session.

Aggregates synchronous and asynchronous helpers that are intended for UI gating only;
server-side authorization must still be enforced. Permission expressions may combine
keys with `&` (AND) and `|` (OR), e.g. `"Admin&Sales|Manager"`.

## Remarks

Defined as a namespace (rather than plain functions) for backward compatibility and
to allow consumers to override/monkey-patch members in ES-module environments.
`*` always grants access; `""` and `"?"` only check that a user is logged in.
Users with `IsAdmin` are granted every permission.

## Examples

```ts
if (Authorization.hasPermission("Administration:General")) {
    // show admin UI
}
```

```ts
if (await Authorization.hasPermissionAsync("Orders:View&Orders:Approve")) {
    // show approve button
}
```

## Variables

- [isLoggedIn](variables/isLoggedIn.md)
- [isLoggedInAsync](variables/isLoggedInAsync.md)
- [userDefinition](variables/userDefinition.md)
- [userDefinitionAsync](variables/userDefinitionAsync.md)
- [username](variables/username.md)
- [usernameAsync](variables/usernameAsync.md)

## Functions

- [hasPermission](functions/hasPermission.md)
- [hasPermissionAsync](functions/hasPermissionAsync.md)
- [isPermissionInSet](functions/isPermissionInSet.md)
- [validatePermission](functions/validatePermission.md)
- [validatePermissionAsync](functions/validatePermissionAsync.md)
