# Data Audit Log

StartSharp provides a zero-configuration data logging system that enables auditing changes made to an entity simply by adding the `[DataAuditLog]` attribute. Any modification to such an entity will automatically result in its details being logged in the data audit log table, without the need to write a single line of code.

![Data Audit Log](img/data-audit-log.png)

To enable Data Audit Log for the `Order` and `Order Details` tables, you can do so as shown below:

```cs
[DataAuditLog]
public sealed class OrderRow : Row, IIdRow, INameRow
{
```

```cs
[DataAuditLog]
public sealed class OrderDetailRow : Row, IIdRow
{
```

For more detailed information about Data Audit Log, including access to the source code, integration instructions, and options for customization, please visit the following link in the StartSharp repository:

[Data Audit Log Source and Documentation](https://github.com/serenity-premium/startsharp/tree/master/pro-features/src/Serenity.Pro.DataAuditLog)

Kindly ensure that you are logged in to GitHub and have the necessary repository access to view the contents of this folder. It will provide you with additional insights into Data Audit Log within the StartSharp project.