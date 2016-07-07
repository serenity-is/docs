# 如何使用其他类型的数据库？

Serenity 有方言系统（dialect system）以支持在非 Sql Server 的其他数据库中工作。  

> 方言系统（Dialect system）目前还是一项在不断完善的实验性功能。虽然它也能工作，但如果有任何问题，你可能在 Serenity 的 GitHub 向我们反馈。

如果你需要支持多种数据库类型，只需在 web.config 修改连接字符串，并在表达式中小心使用数据库特定的功能及避免使用保留的关键字。 


## PostgreSQL

### 注册 Npgsql 提供者

PostgreSQL 有一个名为 Npgsql 的 .NET 提供者。你首先需要在 MyProject.Web 中安装该提供者：

> Install-Package Npgsql -Project MyProject.Web

如果你之前没有在 GAC/machine.config 安装该提供者，或者不想在此安装，你需要在 web.config 文件配置：

```xml
<configuration>
  // ...
  <system.data>
    <DbProviderFactories>
      <remove invariant="Npgsql"/>
      <add name="Npgsql Data Provider" 
           invariant="Npgsql" 
           description=".Net Data Provider for PostgreSQL"
           type="Npgsql.NpgsqlFactory, Npgsql, Culture=neutral,
                 PublicKeyToken=5d8b90d52f46fda7" 
           support="FF" />
    </DbProviderFactories>
  </system.data>
  // ...
```

### 设置连接字符串 

下一步是把连接字符串修改为 Postgres 数据库的配置：

> 确保你使用自己的服务器信息替换连接字符串的对应参数值。

```xml
<connectionStrings>
    <add name="Default" connectionString="
            Server=127.0.0.1;Database=serene_default_v1;
            User Id=postgres;Password=yourpassword;"  
        providerName="Npgsql" />

    <add name="Northwind" connectionString="
            Server=127.0.0.1;Database=serene_northwind_v1;
            User Id=postgres;Password=yourpassword;" 
        providerName="Npgsql" />
</connectionStrings>    

```

> 由于 Postgres 总会将字母转换为小写，所以请使用小写的数据库名称，如 `serene_default_v1` 。 

> 提供者名称必须是 Npgsql ，以使 Serenity 自动检测方言。

### 注意标识符的大小写 

PostgreSQL 的标识符区分大小写。 

FluentMigrator 自动为所有标识符添加引号，所以数据库中的表和列名称将被添加引号并区分大小写。当试图检索不带引号的表或列标识符时，这可能会导致问题。 

一个选项是在迁移中始终使用小写字母标识符，但这种命名方案在其它数据库类型中不是很好，因此我们不喜欢这种方式。

为了防止 Postgres 的这类问题，Serenity 有自动添加引号功能，以解决 Postgres/FluentMigrator 的兼容问题，但需要在应用程序的 SiteInitialization.cs 启动方法中启用：

```cs
public static void ApplicationStart()
{
    try
    {
        SqlSettings.AutoQuotedIdentifiers = true;
        Serenity.Web.CommonInitialization.Run();
```

> 确保在 CommonInitialization.Run 运行之前设置 AutoQuotedIdentifiers 。 

该设置自动为实体的列名称添加引号，但不能应用在手工编写的表达式中（如，表达式特性）。

如果你想支持多数据库类型，在表达式中对标识符使用方括号 `[]` 。 Serenity 在运行查询之前，将自动把方括号转为数据库具体的引用类型（quote type）。

你可能还希望在表达式中使用双引号，但它不能与 MySQL 数据库兼容。

### 设置默认方言 

这一步骤是可选的。 

Serenity 通过检索连接字符串的 *providerName* 自动决定使用的方言。 

它甚至可以在同一时间与多个数据库类型工作。 

例如，Northwind 使用 Sql Server，而 Default 使用 PostgreSQL。

但是，如果你打算每个站点只使用一种数据库类型，你可以在 SiteInitialization 注册默认使用的数据库类型。

```cs
public static void ApplicationStart()
{
    try
    {
        SqlSettings.DefaultDialect = PostgresDialect.Instance;
        SqlSettings.AutoQuotedIdentifiers = true;
        Serenity.Web.CommonInitialization.Run();
```

当连接方言/实体等不能自动确定时，使用默认方言。 

> 该设置不会覆盖自动检测，它只是被用作回退。

## 启动应用程序 

现在启动你的应用程序，如果之前没有手工创建数据库，它将自动创建数据库。

## 配置代码生成器 

Sergen 没有 PostgreSQL 提供者的引用，因此如果你想使用它生成代码，你必须向其注册该提供者。

Sergen.exe 是一个 exe 文件，因此你不能为它添加 NuGet 引用。我们需要在应用程序配置文件中注册该提供者。

> 也可以在 GAC/machine.config 注册提供者并完全跳过此步骤。

定位到 Sergen.exe，该文件在 *packages/Serenity.CodeGenerator.1.8.6/tools* 目录下，并创建文件 `Sergen.exe.config` ，然后向其添加如下内容：

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <system.data>
    <DbProviderFactories>
      <remove invariant="Npgsql"/>
      <add name="Npgsql Data Provider" 
           invariant="Npgsql" 
           description=".Net Data Provider for PostgreSQL"
           type="Npgsql.NpgsqlFactory, Npgsql, Culture=neutral,
                 PublicKeyToken=5d8b90d52f46fda7" 
           support="FF" />
    </DbProviderFactories>
  </system.data>
  <appSettings>
    <add key="LoadProviderDLLs" value="Npgsql.dll"/>
  </appSettings>
</configuration>
```

把 Npgsql.dll 拷贝到与 Sergen.exe 同一文件夹。现在 Sergen 将可以为 Postgres 表生成代码。

> 如果你想要能够使用多个数据库，你可能想删除 `[public].` 前缀，该前缀是生成的行（rows）中 tablename/column 表达式的默认 schema 。

## MySql

> Serene 1.8.13+ 支持 MySql 

### 注册 MySql 提供者

MySQL 有一个名为 MySql.Data 的 .NET 提供者。你首先需要在 MyProject.Web 中安装该提供者：

> Install-Package MySql.Data -Project MyProject.Web

如果你之前没有在 GAC/machine.config 安装该提供者，或者不想在此安装，你需要在 web.config 文件配置（MySql.Data NuGet 程序包在安装时已经为我们添加了该配置）：

```xml
<configuration>
  // ...
  <system.data>
    <DbProviderFactories>
      <remove invariant="MySql.Data.MySqlClient"/>
      <add name="MySQL Data Provider" 
           invariant="MySql.Data.MySqlClient" 
           description=".Net Framework Data Provider for MySQL"
           type="MySql.Data.MySqlClient.MySqlClientFactory, 
                 MySql.Data, Culture=neutral,
                 PublicKeyToken=c5687fc88969c44d" />
     </DbProviderFactories>
  </system.data>
  // ...
```

### 设置连接字符串

下一步是把连接字符串修改为 MySql 数据库的配置：

> 确保你使用自己的服务器信息替换连接字符串的对应参数值。

```xml
<connectionStrings>
    <add name="Default" connectionString="
            Server=localhost; Port=3306; Database=Serene_Default_v1; 
            Uid=root; Pwd=yourpass"
        providerName="MySql.Data.MySqlClient" />
        
    <add name="Northwind" connectionString="
            Server=localhost; Port=3306; Database=Serene_Northwind_v1; 
            Uid=root; Pwd=yourpass" 
        providerName="MySql.Data.MySqlClient" />
</connectionStrings>    

```

> 提供者名称必须是 `MySql.Data.MySqlClient` ，以使 Serenity 自动检测方言。注意，上述重写默认方言。

> MySql 使用小写的数据库（schema）和表名称，但没有 Postgres 的区分大小写问题。

### 配置代码生成器 

Sergen 没有 MySql 提供者的引用，因此如果你想使用它生成代码，你必须向其注册该提供者。

Sergen.exe 是一个 exe 文件，因此你不能为它添加 NuGet 引用。我们需要在应用程序配置文件中注册该提供者。

> 也可以在 GAC/machine.config 注册提供者并完全跳过此步骤。

定位到 Sergen.exe，该文件在 *packages/Serenity.CodeGenerator.1.8.6/tools* 目录下，并创建文件 `Sergen.exe.config` ，然后向其添加如下内容：

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <system.data>
    <DbProviderFactories>
      <remove invariant="MySql.Data.MySqlClient"/>
      <add name="MySQL Data Provider" 
           invariant="MySql.Data.MySqlClient" 
           description=".Net Framework Data Provider for MySQL"
           type="MySql.Data.MySqlClient.MySqlClientFactory, 
                 MySql.Data, Culture=neutral,
                 PublicKeyToken=c5687fc88969c44d" />
     </DbProviderFactories>
  </system.data>
  <appSettings>
    <add key="LoadProviderDLLs" value="MySql.Data.dll"/>
  </appSettings>
</configuration>
```

把 MySql.Data.dll 拷贝到与 Sergen.exe 同一文件夹。现在 Sergen 将可以为 Postgres 表生成代码。

## Oracle

> Serene 2.2.2+ 已支持 Oracle 数据库  

### 注册 Oracle 提供者 

Oracle 有一个名为 Oracle.ManagedDataAccess 的托管 .NET 提供者。你首先需要在 MyProject.Web 中安装该提供者：

> Install-Package Oracle.ManagedDataAccess -Project MyProject.Web

如果你之前没有在 GAC/machine.config 安装该提供者，或者不想在此安装，你需要在 web.config 文件配置（Oracle.ManagedDataAccess NuGet 程序包在安装时已经为我们添加了该配置）：

```xml
<configuration>
  // ...
  <system.data>
    <DbProviderFactories>
      <remove invariant="Oracle.ManagedDataAccess.Client"/>
      <add name="ODP.NET, Managed Driver" 
           invariant="Oracle.ManagedDataAccess.Client" 
           description="Oracle Data Provider for .NET, Managed Driver"
           type="Oracle.ManagedDataAccess.Client.OracleClientFactory, 
                 Oracle.ManagedDataAccess, Version=4.121.2.0, Culture=neutral, 
                 PublicKeyToken=89b483f429c47342"/>
     </DbProviderFactories>
  </system.data>
  // ...
```

### 创建数据库

Serene 不能在 Oracle 自动创建数据库（tablespace）。你需要自己创建它们，或者使用下面的脚本（我在 XE 运行该脚本）：

```sql
CREATE TABLESPACE Serene_Default_v1_TABS 
    DATAFILE 'Serene_Default_v1_TABS.dat' SIZE 10M AUTOEXTEND ON;
CREATE TEMPORARY TABLESPACE Serene_Default_v1_TEMP 
    TEMPFILE 'Serene_Default_v1_TEMP.dat' SIZE 5M AUTOEXTEND ON;
CREATE USER Serene_Default_v1 
    IDENTIFIED BY somepassword 
    DEFAULT TABLESPACE Serene_Default_v1_TABS 
    TEMPORARY TABLESPACE Serene_Default_v1_TEMP;
GRANT CREATE SESSION TO Serene_Default_v1;
GRANT CREATE TABLE TO Serene_Default_v1;
GRANT CREATE SEQUENCE TO Serene_Default_v1;
GRANT CREATE TRIGGER TO Serene_Default_v1;
GRANT UNLIMITED TABLESPACE TO Serene_Default_v1;

CREATE TABLESPACE Serene_Northwind_v1_TABS 
    DATAFILE 'Serene_Northwind_v1_TABS.dat' SIZE 10M AUTOEXTEND ON;
CREATE TEMPORARY TABLESPACE Serene_Northwind_v1_TEMP 
    TEMPFILE 'Serene_Northwind_v1_TEMP.dat' SIZE 5M AUTOEXTEND ON;
CREATE USER Serene_Northwind_v1 
    IDENTIFIED BY somepassword 
    DEFAULT TABLESPACE Serene_Northwind_v1_TABS 
    TEMPORARY TABLESPACE Serene_Northwind_v1_TEMP;
    
GRANT CREATE SESSION TO Serene_Northwind_v1;
GRANT CREATE TABLE TO Serene_Northwind_v1;
GRANT CREATE SEQUENCE TO Serene_Northwind_v1;
GRANT CREATE TRIGGER TO Serene_Northwind_v1;
GRANT UNLIMITED TABLESPACE TO Serene_Northwind_v1;
```

### 设置连接字符串

你可能想要为 ORACLE 配置你的数据源。我在这里用 Express Edition (XE)：

```xml
<configuration>
  <oracle.manageddataaccess.client>
    <version number="*">
      <dataSources>
        <dataSource alias="XE"
          descriptor="
              (DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)
              (HOST=localhost)(PORT=1521))
              (CONNECT_DATA=(SERVICE_NAME=XE))) "/>
      </dataSources>
    </version>
  </oracle.manageddataaccess.client>
</configuration>
```

下一步是把连接字符串修改为 Oracle 数据库的配置：

> 确保你使用自己的服务器信息替换连接字符串的对应参数值。

```xml
<connectionStrings>
    <add name="Default" connectionString="
        Data Source=XE;User Id=Serene_Default_v1;Password=somepassword;" 
        providerName="Oracle.ManagedDataAccess.Client"/>
    <add name="Northwind" connectionString="
        Data Source=XE;User Id=Serene_Northwind_v1;Password=somepassword;" 
        providerName="Oracle.ManagedDataAccess.Client"/>
</connectionStrings>    

```

> 提供者名称必须是 `Oracle.ManagedDataAccess.Client` ，以使 Serenity 自动检测方言。注意，上述重写默认方言。

### 配置代码生成器 

Sergen 目前还不支持 Oracle，希望尽快支持…… 