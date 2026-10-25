# HostMigrationExtensions.RunMigrationsIf method (1 of 2)

Runs [`Initialize`](../IDataMigrations/Initialize.md) when the first argument is "migrate".

```csharp
public static int? RunMigrationsIf(this IHost host, string[] args)
```

| parameter | description |
| --- | --- |
| host | Host |
| args | Arguments, e.g. the ones passed to `Main`. |

## Return Value

`null` when *args* is not the migrate command, so the application should start normally; otherwise the exit code the caller should return: 0 on success, 1 when the migrations throw, 2 for extra arguments.

## Remarks

See [`RunMigrationsIf`](./RunMigrationsIf.md).

## See Also

* class [HostMigrationExtensions](../HostMigrationExtensions.md)

---

# HostMigrationExtensions.RunMigrationsIf&lt;TService&gt; method (2 of 2)

Runs the migrations via the provided runner when the first argument is "migrate".

```csharp
public static int? RunMigrationsIf<TService>(this IHost host, string[] args, 
    Action<TService> runner)
    where TService : class
```

| parameter | description |
| --- | --- |
| TService | Service to resolve from the host, normally `IDataMigrations`. |
| host | Host |
| args | Arguments, e.g. the ones passed to `Main`. Anything other than a lone "migrate" is left to the caller, so the application starts normally. |
| runner | Runner callback that receives the resolved service. |

## Return Value

`null` when *args* is not the migrate command, so the application should start normally; otherwise the exit code the caller should return: 0 on success, 1 when *runner* throws, 2 for extra arguments.

## Remarks

Terminating the process is the caller's job, so this can be used from tests and from applications that want their own exit codes. Extra arguments are rejected instead of starting the web host, which would otherwise look like a hang to a script.

## See Also

* class [HostMigrationExtensions](../HostMigrationExtensions.md)