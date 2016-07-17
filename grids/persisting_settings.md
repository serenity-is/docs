# 持久化设置

Serenity 2.1.5 引入保存如下信息的网格列表设置：

- 可见列和显示顺序
- 列宽
- 排序的列
- 高级过滤器（由右下角的编辑过滤器链接创建）
- 快速过滤器（撰写本文档时，尚未提供该功能）
- 包含已删除的状态切换 

默认情况下，网格列表不会自动持久化任何东西。 

因此，如果你隐藏某些列并离开订单页面，当你再次返回该页面时，你就会看到那些隐藏的列再次成为可见列。

你需要开启所有网格列表的持久化设置，或设置单独记住它们的设置。


### 默认情况下开启持久性

DataGrid 有名为 *DefaultPersistanceStorage* 的静态配置参数。此参数控制默认情况下的网格列表设置自动保存的位置。它最初为空。

在 SiteInitialization.ts，你可能像下面这样默认开启所有网格列表的持久化：

```ts
namespace Serene.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('Serene');

    Serenity.DataGrid.defaultPersistanceStorage = window.sessionStorage;
}
```

这将设置保存到浏览器的会话(session)。当任何浏览器窗口保持打开状态时，将数据保存到一个键/值字典。当用户关闭所有浏览器窗口时，所有的设置都会丢失。

另一种选择是使用浏览器本地存储。在浏览器重新启动之间将保留设置。

```ts
Serenity.DataGrid.defaultPersistanceStorage = window.localStorage;
```

使用这两个选项的任意一个，在重新加载页面之间，网格列表会开始记住它们的设置。

### 处理由多个用户共同使用的浏览器

SessionStorage 和 localStorage 是浏览器范围，因此，如果浏览器由多个用户共同使用，他们会得到同一组设置。 

如果一个用户更改某些设置并注销，而后另一个用户登录，第二个用户将以第一个用户的设置开始使用系统（除非你在注销时清除 localStorage ）。

如果你认为这是应用程序的一个问题，可以尝试编写自定义提供程序：

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

> 请注意，上述代码不能提供任何的安全保障。它只是让用户有单独的设置。


### 持久化存储每个网格列表类型的设置

要开启持久化，或更改某一特定网格列表的存储目标，可重写 getPersistanceStorage 方法：

```ts
namespace Serene.Northwind {
    //...
    export class OrderGrid extends Serenity.EntityGrid<OrderRow, any> {
        //...
        
        protected getPersistanceStorage(): Serenity.SettingStorage {
            return window.localStorage;
        }
    }
}

```

你也以在该方法中通过返回 *null* 关闭网格列表类的持久化。


### 确定保存的设置类型

默认情况下，在开始时注意到的所有设置（如可见列、宽度、过滤器等）都被保存。你也可以选择不持久化/还原特定的设置。这些都可在 *getPersistanceFlags* 方法控制：

```ts
namespace Serene.Northwind {
    //...
    export class OrderGrid extends Serenity.EntityGrid<OrderRow, any> {
        //...
        
        protected getPersistanceFlags(): GridPersistanceFlags {
            return {
                columnWidths: false // dont persist column widths;
            }
        }
    }
}
```

这里是一组完整的标识： 

```ts
interface GridPersistanceFlags {
    columnWidths?: boolean;
    columnVisibility?: boolean;
    sortColumns?: boolean;
    filterItems?: boolean;
    quickFilters?: boolean;
    includeDeleted?: boolean;
}
```

### 何时保存/还原设置

当你改变网格列表的如下设置时，会自动保存设置：

* 使用列选取器对话框选择可见的列
* 手动调整列的大小
* 编辑高级过滤器
* 拖动列、改变列位置
* 更改排序的列

只在创建网格列表后，在加载第一页时还原设置。



### 持久化设置到数据库（UserPreferences 表）

Serene 2.1.5 带有 *UserPreferences* 表，可以作为持久化存储设置。若要使用该表存储设置，你只需要将网格列表的 *defaultPersistanceStorage* 设置为存储类型（类似于其他存储类型）。

```ts
/// <reference path="../Common/UserPreference/UserPreferenceStorage.ts" />

Serenity.DataGrid.defaultPersistanceStorage = new Common.UserPreferenceStorage();
```

> 别忘了添加引用语句，否则你会有运行时错误，因为 TypeScript 有加载顺序问题。

或者： 

```ts
namespace Serene.Northwind {
    //...
    export class OrderGrid extends Serenity.EntityGrid<OrderRow, any> {
        //...
        
        protected getPersistanceStorage(): Serenity.SettingStorage {
            return new Common.UserPreferenceStorage();
        }
    }
}
```


### 手动保存/还原设置

如果需要手动保存/还原设置，可以使用以下方法：

```ts
protected getCurrentSettings(flags?: GridPersistanceFlags): PersistedGridSettings;
protected restoreSettings(settings?: PersistedGridSettings, flags?: GridPersistanceFlags): void;
```

这些都是 DataGrid 的受保护方法，所以只能从子类调用。
