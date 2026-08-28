# Localization and Text (Client-Side)

Serenity uses a global localization table to resolve localized strings on the client. Text keys are looked up in this table, which is populated from server-side localization scripts.

## The Localization Table

Localized strings are stored in a global table keyed by text keys (e.g. `"Dialogs.YesButton"`). The table is populated from server-side localization scripts and can be extended at runtime with `addLocalText`.

## Resolving Text

### localText

`localText(key, defaultText?)` returns the localized string for a key, falling back to `defaultText` or the key itself:

```ts
import { localText } from "@serenity-is/corelib";

localText("Dialogs.YesButton");          // "Yes" if registered, otherwise "Dialogs.YesButton"
localText("Missing.Key", "Fallback");    // "Fallback"
```

### text

`text` is an alias for `localText`:

```ts
import { text } from "@serenity-is/corelib";

text("Dialogs.YesButton");
```

### tryGetText

`tryGetText(key)` returns the localized string or `undefined` (unlike `localText`, it does not fall back to the key):

```ts
import { tryGetText } from "@serenity-is/corelib";

const value = tryGetText("Some.Key"); // string | undefined
```

## Adding Text at Runtime

`addLocalText` adds entries to the localization table:

```ts
import { addLocalText } from "@serenity-is/corelib";

// Single entry
addLocalText("Db.Northwind.CustomerName", "Customer Name");

// Nested object (flattened with dots)
addLocalText({ Customer: { Name: "Name" } }, "Db.Northwind.");
// registers "Db.Northwind.Customer.Name"
```

## Text Proxies

Generated text classes (in `ServerTypes/Texts.ts`) use `proxyTexts` to provide strongly-typed access to text keys. For example:

```ts
import { UserPermissionDialogTexts } from "./ServerTypes/Texts";

UserPermissionDialogTexts.DialogTitle; // resolves the text key
```

The proxy supports `.asKey()` (returns the key) and `.asTry()` (returns `undefined` when missing).

## Localization in Widgets

Widgets and grids use localized text for titles, buttons, and messages. For example, `EntityGrid` resolves its title from the entity's plural display name:

```ts
protected getDisplayName(): string {
    return localText(this.getLocalTextDbPrefix() + 'EntityPlural', this.getEntityType());
}
```

## See Also

- [localText (API reference)](../api/js/corelib/functions/localText.md) — resolve a localized string.
- [tryGetText (API reference)](../api/js/corelib/functions/tryGetText.md) — resolve without key fallback.
- [addLocalText (API reference)](../api/js/corelib/functions/addLocalText.md) — add text at runtime.
- [proxyTexts (API reference)](../api/js/corelib/functions/proxyTexts.md) — text proxies.
- [Localization](../framework/localization.md) — server-side localization.
- [Frontend Framework Overview](ui/readme.md) — the three client-side packages and how they fit together.