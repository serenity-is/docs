# Persisting Settings

Serenity 2.1.5 introduced ability to persist grid settings including these details:

- Visible Columns and Display Order
- Column Widths
- Sorted Columns
- Advanced Filters (ones created with Edit Filter link on bottom right)
- Quick Filters (as of writing, not yet available)
- State of Include Deleted Toggle

By default, grids don't automatically persist anything.

Thus, if you hide some columns and navigate away from Orders page, when you come back, you'll see that those hidden columns became visible again.

You need to turn on persistance for all grids, or for individual ones that you want them to remember their settings.

## Turning On Persistance by Default

DataGrid has a static configuration parameter with name *DefaultPersistanceStorage*. This parameter controls where grids save their settings automatically by default. It is initially null.

In ScriptInit.ts, you might turn on persistance for all grids by default like below:

```ts
DataGrid.defaultPersistanceStorage = window.sessionStorage;
```

This saves settings to browser session storage, which is a key/value dictionary that preserves data while any browser window stays open. When user closes all browser windows, all settings will be lost.

Another option is to use browser local storage. Which preserves settings between browser restarts.

```ts
DataGrid.defaultPersistanceStorage = window.localStorage;
```

Using any of the two options, grids will start to remember their settings, between page reloads.

## Handling a Browser that is Shared by Multiple Users

Both sessionStorage and localStorage is browser scoped, so if a browser is shared by multiple users, they'll have same set of settings.

If one user changes some settings, and logs out, and other one logs in, second user will start with settings of the first user (unless you clear localStorage on signout)

If this is a problem for your application, you may try writing a custom provider:

```ts
import { Authorization, SettingStorage } from '@serenity-is/corelib';

// ...

export class UserLocalStorage implements SettingStorage {
    getItem(key: string): string {
        return window.localStorage.getItem(Authorization.userDefinition.Username + ":" + key);
    }

    setItem(key: string, value: string): void {
        window.localStorage.setItem(Authorization.userDefinition.Username + ":" + key, value);
    }
}

// ...

DataGrid.defaultPersistanceStorage = new UserLocalStorage();
```

> Please note that this doesn't provide any security. It just lets users have separate settings.

## Setting Persistance Storage Per Grid Type

To turn on persistance, or change target storage for a particular grid, override getPersistanceStorage method:

```ts
import { SettingStorage } from '@serenity-is/corelib';

export class OrderGrid<P={}> extends EntityGrid<OrderRow, P> {
    // ...
        
    protected getPersistanceStorage(): SettingStorage {
        return window.localStorage;
    }
}
```

You may also turn off persistance for a grid class by returning *null* from this method.

## Determining Which Setting Types Are Saved

By default, all settings noted at start are saved, like visible columns, widths, filters etc. You may choose to not persist / restore specific settings. This is controlled by *gridPersistanceFlags* method:

```ts
import { GridPersistanceFlags } from '@serenity-is/corelib';

export class OrderGrid<P={}> extends EntityGrid<OrderRow, P> {
    // ...
        
    protected gridPersistanceFlags(): GridPersistanceFlags {
        return {
            columnWidths: false // We don't want to save column widths
        };
    }
}
```

Here is the set of complete flags: [GridPersistanceFlags](/api/js/corelib/interfaces/GridPersistanceFlags.md)

```ts
interface GridPersistanceFlags {
    columnWidths?: boolean;
    columnVisibility?: boolean;
    sortColumns?: boolean;
    filterItems?: boolean;
    quickFilters?: boolean;
    quickFilterText?: boolean;
    quickSearch?: boolean;
    includeDeleted?: boolean;
}
```

## When Settings Are Saved / Restored

Settings are automatically saved when you change something with a grid like:

- Choosing visible columns with Column Picker dialog
- Resizing a column manually
- Editing advanced filter
- Dragging a column, changing position
- Changing sorted columns

Settings are restored on first page load, just after grid creation.

## Persisting Settings to Database (User Preferences Table)

Serene comes with a *UserPreferences* table that you may use as a persistance storage. To use this storage, you just need to set it as storage similar to other storage types.

In ScriptInit.ts

```ts
import { UserPreferenceStorage } from '@serenity-is/extensions';

DataGrid.defaultPersistanceStorage = new UserPreferenceStorage();
```

OR 

```ts
import { SettingStorage } from '@serenity-is/corelib';
import { UserPreferenceStorage } from '@serenity-is/extensions';


export class OrderGrid<P={}> extends EntityGrid<OrderRow, P> {
    // ...
        
    protected getPersistanceStorage(): SettingStorage {
        return new UserPreferenceStorage();
    }
}
```

## Manually Saving / Restoring Settings

If you need to save / restore settings manually, you may use methods below:

```ts
protected getCurrentSettings(flags?: GridPersistanceFlags): PersistedGridSettings;
protected restoreSettings(settings?: PersistedGridSettings, flags?: GridPersistanceFlags): void;
```

These are protected methods of DataGrid, so can only be called from subclasses.
