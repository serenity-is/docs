# 格式化器类型



## URLFormatter

此格式化器让你可以在网格列显示 URL 链接。

它有如下可选参数：

<table>
<tr><th>选项名称</th><th>描述</th></tr>
<tr><td>UrlFormat</td><td><p> URL 的格式。如，在"<i>http://www.site.com/{0}</i>" 中 <i>{0}</i> 被替换为 UrlProperty 的值。</p><p>如果没有指定，连接将依然显示 UrlProperty 的值。</p><p>如果 URL 格式以 "~/" 开头，它将解析为应用程序根。例如，如果格式为 "~/upload/{0}"，且你的应用程序运行在 "localhost:3045/mysite"，生成的 URL 为 "/mysite/upload/xyz.png"。</p></td></tr>
<tr><td>UrlProperty</td><td><p>该属性用于确定链接的 URL。</p>
<p>如果没有指定，列的名称被该格式化器替换。</p><p>如果 UrlProperty 的值以 "~/" 开头，将像 UrlFormat 一样解析。</p></td></tr>
<tr><td>DisplayFormat</td><td><p>链接的文本显示格式。例如，在 "<i>单击以打开 {0}</i>" 中 <i>{0}</i> 替换为 DisplayProperty 的值。</p><p>如果未指定格式，链接的值将为 DisplayProperty。</p></td></tr>
<tr><td>DisplayProperty</td><td><p>该属性用于确定连接文本。</p>
<p>如果没有指定，列的名称被该格式化器替换。</p></td></tr>
<tr><td>Target</td><td><p>链接的目标。使用 "_blank" 表示在新选项卡中打开链接。</p></td></tr>
</table>



