# 流式 SQL (Fluent SQL)

Serenity 包含一系列 SELECT、 INSERT、 UPDATE 和 DELETE 语句的查询生成器。

这些生成器可以被简单字符串或 Serenity 实体（row）系统使用。

它们的输出可通过像 Dapper（已集成到 Serenity） 这样的微 ORM 或 Serenity 扩展直接执行。
