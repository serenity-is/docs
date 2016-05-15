# Formatter Types



## URLFormatter

This formatter lets you put a link with a URL to a grid column.

It takes optional arguments below:

<table>
<tr><th>Option Name</th><th>Description</th></tr>
<tr><td>UrlFormat</td><td><p>This is the format of URL. A sample would be "<i>http://www.site.com/{0}</i>" where <i>{0}</i> is the UrlProperty value.</p><p>If no format is specified, link will be the value of UrlProperty as is.</p></td></tr>
<tr><td>UrlProperty</td><td><p>This is name of the property that will be used to determine link URL.</p>
<p>If not specified, it is the name of the column that this formatter is placed on.</p></td></tr>
<tr><td>DisplayFormat</td><td><p>This is the display text format of link. A sample would be "<i>open {0}</i>" where <i>{0}</i> is the DisplayProperty value.</p><p>If no format is specified, link will be the value of DisplayProperty as is.</p></td></tr>
<tr><td>DisplayProperty</td><td><p>This is name of the property that will be used to determine link text.</p>
<p>If not specified, it is the name of the column that this formatter is placed on.</p></td></tr>
</table>


