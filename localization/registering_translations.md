# 注册翻译

有几种方法来定义本地文本键（local text keys）和翻译，包括：

  - 通过 ILocalTextRegistry.Add 方法手工添加
  - 在嵌套静态类中声明包含本地文本的对象
  - 在枚举类添加 Description 特性
  - 在预先确定的位置定义 JSON 文件（~/scripts/serenity/texts、~/scripts/site/texts 和 ~/App_Data/texts）

我们会谈论所有这些方法。
