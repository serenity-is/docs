# Persisting Settings

Serenity 2.1.5 introduced ability to persist grid settings including these details:

- Visible Columns and Display Order
- Column Widths
- Sorted Columns
- Advanced Filters (ones created with Edit Filter link on bottom right)
- Quick Filters (as of writing, not yet available)
- State of Include Deleted Toggle

By default, grids doesn't automatically persist anything. 

Thus, if you hide some columns and navigate away from Orders page, when you come back, you'll see that those hidden columns became visible again.

You need to turn on persistance for all grids, or for individual ones that you want them to remember their settings.


### Turning On Persistance by Default

DataGrid has a static configuration parameter with name *DefaultPersistanceStorage*. This parameter controls where grids save their settings automatically by default. It is initially null.

In SiteInitialization.ts, you might turn on persistance for all grids by default like below:

```ts
namespace Serene.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('Serene');

    Serenity.DataGrid.defaultPersistanceStorage = window.sessionStorage;
}
```

This saves settings to browser session storage, which is a key/value dictionary that preserves data while any browser window stays open. When user closes all browser windows, all settings will be lost.

Another option is to use browser local storage. Which preserves settings between browser restarts.

```ts
Serenity.DataGrid.defaultPersistanceStorage = window.localStorage;
```

Using any of the two options, grids will start to remember their settings, between page reloads.

### Handling a Browser that is Shared by Multiple Users

Both sessionStorage and localStorage is browser scoped, so if a browser is shared by multiple users, they'll have same set of settings. 

If one user changes some settings, and logs out, and other one logs in, second user will start with settings of the first user (unless you clear localStorage on signout)

If this is a problem for your application, you may try writing a custom provider:

```ts
namespace Serene {
    export class UserLocalStorage implements Serenity.SettingStorage {
        getItem(key: string): string {
            return window.localStorage.getItem(
                Authorization.userDefinition.Username + ":" + key);
        }

        setItem(key: string, value: string): void {
            window.localStorage.setItem(
                Authorization.userDefinition.Username + ":" + key, value);
        }
    }
}

//...
Serenity.DataGrid.defaultPersistanceStorage = new UserLocalStorage();
```

> Please note that this doesn't provide any security. It just lets users have separate settings.

