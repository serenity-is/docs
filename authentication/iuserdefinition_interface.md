# IUserDefinition 接口

[**命名空间**: *Serenity*, **程序集**: *Serenity.Core*]

很多应用程序存储用户常见的信息，如 ID、显示名称（别名/全名）、邮箱等。Serenity 提供基础接口以独立应用程序方式访问这些信息。

```cs
public interface IUserDefinition
{
    string Id { get; }
    string Username { get; }
    string DisplayName { get; }
    string Email { get; }
    Int16 IsActive { get;  }
}
```

你的应用程序应该实现该接口，但并不是所有这些信息都是 Serenity 自身必须的。只有 Id、Username 及 IsActive 属性是必需的。

`Id` 可以是整型、字符串或者 GUID ，用以唯一标识用户。

`Username` 应该是唯一的用户名，但是你也可以使用邮箱地址作为用户名。

`IsActive` 活跃状态的用户返回 1；已删除(如果你没有在数据库中删除用户)的用户返回 -1；暂时禁用（锁住账号）的用户返回 0。

`DisplayName` 和 `Email` 是可选的，且当前并没有被 Serenity 使用，可能你的应用程序需要它们。
