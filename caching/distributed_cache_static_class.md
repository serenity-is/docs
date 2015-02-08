# Distributed Cache Static Class
[**namespace**: *Serenity*, **assembly**: *Serenity.Core*]

DistributedCache class provides shortcuts to methods for currently registered IDistributedCache implementation. So below two lines are functionally equal:

```
    IoC.Resolve<IDistributedCache>().Increment("LastID");
    DistributedCache.Increment("LastID");
```
