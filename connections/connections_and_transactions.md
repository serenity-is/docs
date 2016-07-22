# 连接和事务

Serenity 使用简单的 ADO.NET 数据访问对象，像 SqlConnection、DbCommand 等。

它提供了一些基本的助手（helpers）来创建连接、添加参数、执行查询等。


## SqlConnections 类

[**命名空间**: *Serenity.Data*, **程序集**: *Serenity.Data*]

该类包含创建连接的静态函数，并在数据库中以不可见的方式控制它。


### SqlConnections.NewByKey 方法

```cs
public static IDbConnection NewByKey(string connectionKey)
```

该方法用于获取新的 IDbConnection 连接字符串，连接字符串定义在应用程序配置文件（app.config 或 web.config）。


```cs
using (var connection = SqlConnections.NewByKey("Default")) 
{
    // ...
}
```

> 尽量在 using 块中使用数据库连接。

它读取 web.config 中 key 为 "Default" 的连接字符串，并使用同样在连接字符串中指定的 *ProviderName* 信息创建一个新的连接字符串。例如，如果 *ProviderName* 是 "System.Data.SqlClient"，则创建一个新的 SqlConnection 对象。

> 通常不需要显式打开连接，因为在需要它们的时候将自动打开连接（只要你使用 Serenity 扩展）。

### SqlConnections.NewFor< TClass > 方法

如果你不想记忆连接字符串的键，而是想重用行（row）的信息（表单的 *ConnectionKey* 特性），你可能会更喜欢该变体。

查看 Row 类的顶部，你可能会发现由 Sergen 生成的 ConnectionKey 特性：

```cs
[ConnectionKey("Northwind")]
public sealed class CustomerRow : Row, IIdRow, INameRow
{
}
```

当要查询客户时，为了不使用硬编码 "Northwind"，你可以重用来自 CustomerRow 的信息：

```cs
using (var connection = SqlConnections.NewFor<CustomerRow>()) 
{
    return connection.List<CustomerRow>();
}
```

此方法等效于 *SqlConnections.NewByKey("Northwind")*。

> 我们没有在这里打开连接，因为 List 扩展方法会自动打开它。

用此方法的类不一定非得是 Row，任何类包含 ConnectionKey 特性都可以工作，即管大部分情况会是 row 类。


### SqlConnections.New 方法

```
public static IDbConnection New(string connectionString, string providerName)
```

有时，你可能想创建配置文件中不存在的连接。

```cs
using (var connection = SqlConnections.New(
    "Data Source=(localdb)\v11.0; Initial Catalog=Northwind; 
     Integrated Security=true", "System.Data.SqlClient")) 
{
    // ...
}
```

在这里我们需要指定连接字符串和提供者的名称（如 "System.Data.SqlClient"）。

你可能会问自己 “为什么使用这种方法而不是简单地使用 *new SqlClient()* ？”，请参阅下一关于这些优势的主题。

### WrappedConnection

到目前为止，我们看到的所有方法都返回 IDbConnection 对象。你可能以为返回的是 SqlConnection、FirebirdConnection 等，但这是不完全正确的。

你所接收到的 IDbConnection 对象是 Serenity 特定的 WrappedConnection 对象，实际上包含了基本的 SqlConnection 或 FirebirdConnection 等。

这样做有助于 Serenity 提供一些功能，如自动打开连接、方言支持、默认事务、单元工作模式、可测试的重载连接等。

你可以不需要注意这些细节，而直接使用返回 IDbConnection 实例工作，它们会像基础连接那样工作，但你应优先使用 SqlConnections 方法来创建连接，否则可能会丢失一些列出的功能。


### UnitOfWork 和 IUnitOfWork

UnitOfWork 是包含事务引用的简单对象。它有两个我们可以附加的额外事件：

比方说我们正在创建任务，当这些任务成功保存到数据库时，应该发送几封电子邮件。

如果我们很急并在事务提交之前发送电子邮件，可能会在事务失败的情况下为不存在的任务发送电子邮件。所以我们应该只在事务被提交成功时发送电子邮件，例如，在 OnCommit 事件发。

你可能会说先提交事务然后再发送电子邮件，但是，如果我们调用的创建任务服务只是更大操作中的一个步骤，所以我们不控制事务而在所有步骤成功后提交。

另一个场景是关于上传文件。这次我们要更新一些文件（File）实体，并且上传的新文件将替换旧文件。如果我们同样很急并且在事务执行完成之前(而最后事务执行失败了)删除旧的文件，我们最终得到实际不存在磁盘中的旧文件的文件实体。所以，我们其实应该在 OnCommit 事件中删除文件并替换新的文件，且在 OnRollback 事件中删除上传的文件。

```cs
void SomeBatchOperation() 
{
    using (var connection = SqlConnections.NewByKey("Default")) 
    using (var uow = new UnitOfWork(connection))
    {
        // here we are in a transaction context
        // create several tasks in transaction
        CreateATask(new TaskRow { ... });
        CreateATask(new TaskRow { ... });
        //...
        
        // commit the transaction
        // if any exception occurs here or at prior
        // lines transaction will rollback
        // and no e-mails will be sent
        uow.Commit();
    }
}

void CreateATask(IUnitOfWork uow, TaskRow task)
{
    // insert task using connection wrapped inside IUnitOfWork
    // this will automatically run in transaction context
    uow.Connection.Insert(task);
   
    uow.OnCommit += () => {
       // send e-mail for this task now, this method will only
       // be called if transaction commits successfully
    };
    
    uow.OnRollback += () => {
       // optional, do something else if it fails
    };       
}
```




