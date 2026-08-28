# Authorization and Permissions (Client-Side)

The `Authorization` namespace in `@serenity-is/corelib` provides client-side permission checks and user-state accessors. These are intended for **UI gating only** — always enforce permissions on the server side as well.

## Checking Permissions

### hasPermission (synchronous)

```ts
import { Authorization } from "@serenity-is/corelib";

if (Authorization.hasPermission("Administration:General")) {
    // show admin UI
}
```

### hasPermissionAsync (recommended)

Prefer the async variant in new code — it awaits the `UserData` script instead of potentially blocking the UI thread:

```ts
if (await Authorization.hasPermissionAsync("Orders:View&Orders:Approve")) {
    // show approve button
}
```

## Permission Expressions

Permission checks support logical operators:

- `&` — AND (all permissions required).
- `|` — OR (at least one required).
- `&` binds tighter than `|`, so `"A&B|C"` means `(A AND B) OR C`.

Special values:

| Value | Meaning |
| --- | --- |
| `"*"` | Always grants access. |
| `""` or `"?"` | Only checks that a user is logged in. |
| `null` / `undefined` | Returns `false`. |

Users with `IsAdmin` are granted every permission.

## User State

The `Authorization` namespace exposes the current user:

```ts
// Whether a user is logged in
const loggedIn = Authorization.isLoggedIn;

// The current user definition
const user = Authorization.userDefinition;
// user.Username, user.DisplayName, user.IsAdmin, user.Permissions
```

The `UserDefinition` interface describes the current user:

```ts
interface UserDefinition {
    Username?: string;
    DisplayName?: string;
    IsAdmin?: boolean;
    Permissions?: { [key: string]: boolean };
}
```

## Permission-Based UI

A common pattern is to hide or disable UI elements based on permissions. For example, the `EntityGrid` disables the add button when the user lacks insert permission:

```ts
buttons.push({
    title: this.getAddButtonCaption(),
    action: 'add',
    cssClass: 'add-button',
    icon: faIcon("plus-circle", "green"),
    hotkey: 'alt+n',
    onClick: () => { this.addButtonClick(); },
    disabled: () => !this.hasInsertPermission() || this.readOnly
});
```

## Important: UI-Only Checks

Client-side permission checks are **not security**. They only control what the user sees and can click. The server must always re-validate permissions, because a malicious client can bypass any client-side check.

## See Also

- [Authorization (API reference)](../api/js/corelib/@serenity-is/namespaces/Authorization/README.md) — the full `Authorization` API.
- [UserDefinition (API reference)](../api/js/corelib/interfaces/UserDefinition.md) — the user definition type.
- [EntityGrid CRUD](../grids/entitygrid-crud.md) — how grids use permissions.
- [EntityDialog and CRUD Workflows](../dialogs/entitydialog.md) — how dialogs use permissions.
- [Frontend Framework Overview](ui/readme.md) — the three client-side packages and how they fit together.