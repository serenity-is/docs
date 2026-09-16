# ApplicationPartsTypeSource.EnsureApplicationParts method

Tries to recover application parts when the generated application parts assembly info (e.g. `*.MvcApplicationPartsAssemblyInfo.cs`) was not included in the build. In that case the ApplicationPartManager only contains the entry assembly, which makes pages and navigation items from referenced assemblies disappear. This reads the application deps file, finds the assemblies that reference MVC and adds them to the part manager, just like the Razor SDK would have done at build time. It is only attempted once, and only when the entry assembly has no ApplicationPartAttribute at all and this assembly (Serenity.Net.Web) is missing from the part manager. Concurrent callers block until the recovery completes.

```csharp
protected virtual void EnsureApplicationParts()
```

## See Also

* class [ApplicationPartsTypeSource](../ApplicationPartsTypeSource.md)