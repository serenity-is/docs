# BaseDynamicDataGenerator.RunIf method

Runs the generator when the first argument is `dynamic-data`.

```csharp
public virtual int? RunIf(string[] args)
```

| parameter | description |
| --- | --- |
| args | The command line arguments. |

## Return Value

`null` when *args* is not the dynamic data command, so the application should start normally; otherwise the exit code the caller should return: 0 on success, 1 when the generator throws, 2 for extra arguments.

## Remarks

Terminating the process is the caller's job, so this can be used from tests. Extra arguments are rejected instead of starting the web host, which would otherwise look like a hang to a script. Mirrors `MigrationUtils.RunMigrationsIf`.

## See Also

* class [BaseDynamicDataGenerator](../BaseDynamicDataGenerator.md)