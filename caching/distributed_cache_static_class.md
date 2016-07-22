# 静态 DistributedCache 类

[**命名空间**: *Serenity*, **程序集**: *Serenity.Core*]

DistributedCache 类提供访问当前注册的 IDistributedCache 实现的快捷方法。所以，下面两行代码有相同的功能：

```
    IoC.Resolve<IDistributedCache>().Increment("LastID");
    DistributedCache.Increment("LastID");
```
