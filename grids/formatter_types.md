# Formatter Types

Formatters control how cell values are rendered in a grid column. They receive a `FormatterContext` and return a string, a DOM node, or a fragment.

## The FormatterContext

A formatter is a function (or an object with a `format` method) that receives a `FormatterContext`:

```ts
interface FormatterContext<TItem = any> {
    value?: any;                 // the cell value
    row?: number;                // the row index
    cell?: number;               // the column index
    column?: Column<TItem>;      // the column definition
    item?: TItem;                // the row item
    grid?: ISleekGrid;           // the grid instance
    enableHtmlRendering: boolean; // whether HTML strings are allowed
    escape(value?: any): string; // HTML-escapes a value
    sanitizer: (dirtyHtml: string) => string; // sanitizes HTML
    purpose?: "auto-width" | "excel-export" | "pdf-export" | "print" | ...;
    addClass?: string;           // extra classes for the cell
    addAttrs?: { [key: string]: string }; // extra attributes for the cell
    tooltip?: string;            // title attribute for the cell
}
```

### HTML Rendering and XSS Safety

By default `enableHtmlRendering` is `false`, which means a formatter should return plain text — the result is set via `textContent`, and `escape()` is a no-op. When `enableHtmlRendering` is `true`, a formatter may return HTML strings, but should use `ctx.escape()` to avoid script injection:

```ts
format(ctx) {
    return `<a href="${ctx.escape(ctx.value)}">${ctx.escape(ctx.value)}</a>`;
}
```

When writing formatters with JSX, values are escaped automatically, so you don't need `ctx.escape()`:

```tsx
format(ctx) {
    return <a href={ctx.value}>{ctx.value}</a>;
}
```

## Built-in Formatters (corelib)

These formatters are registered in `@serenity-is/corelib` and are typically applied via formatter attributes on columns:

| Formatter | Description |
| --- | --- |
| [UrlFormatter](../api/js/corelib/classes/UrlFormatter.md) | Renders a value as a hyperlink. |
| [DateFormatter](../api/js/corelib/classes/DateFormatter.md) | Formats a date value. |
| [DateTimeFormatter](../api/js/corelib/classes/DateTimeFormatter.md) | Formats a date-time value. |
| [EnumFormatter](../api/js/corelib/classes/EnumFormatter.md) | Renders an enum value as its localized text. |
| [NumberFormatter](../api/js/corelib/classes/NumberFormatter.md) | Formats a number with a display format. |
| [BooleanFormatter](../api/js/corelib/classes/BooleanFormatter.md) | Renders a boolean as localized true/false text. |
| [CheckboxFormatter](../api/js/corelib/classes/CheckboxFormatter.md) | Renders a boolean as a checkbox. |
| [FileDownloadFormatter](../api/js/corelib/classes/FileDownloadFormatter.md) | Renders a file download link. |
| [MinuteFormatter](../api/js/corelib/classes/MinuteFormatter.md) | Formats a minute value as hours:minutes. |

## Built-in Formatters (SleekGrid)

SleekGrid also ships function formatters that take a `FormatterContext` directly:

| Formatter | Description |
| --- | --- |
| [PercentCompleteFormatter](../api/js/sleekgrid/functions/PercentCompleteFormatter.md) | Renders a percent value as bold colored text. |
| [PercentCompleteBarFormatter](../api/js/sleekgrid/functions/PercentCompleteBarFormatter.md) | Renders a percent value as a colored bar. |
| [YesNoFormatter](../api/js/sleekgrid/functions/YesNoFormatter.md) | Renders a boolean as "Yes"/"No". |
| [CheckBoxFormatter](../api/js/sleekgrid/functions/CheckBoxFormatter.md) | Renders a boolean as a checkbox icon. |
| [CheckmarkFormatter](../api/js/sleekgrid/functions/CheckmarkFormatter.md) | Renders a boolean as a checkmark icon. |

## URLFormatter

This formatter lets you put a link with a URL to a grid column.

It takes optional arguments below:

<table>
<tr><th>Option Name</th><th>Description</th></tr>
<tr><td>UrlFormat</td><td><p>This is the format of URL. A sample would be "<i>http://www.site.com/{0}</i>" where <i>{0}</i> is the UrlProperty value.</p><p>If no format is specified, link will be the value of UrlProperty as is.</p><p>If your URL format starts with "~/", it will be resolved to application root. For example, if format is "~/upload/{0}" and your application runs at "localhost:3045/mysite", resulting URL will be "/mysite/upload/xyz.png".</p></td></tr>
<tr><td>UrlProperty</td><td><p>This is name of the property that will be used to determine link URL.</p>
<p>If not specified, it is the name of the column that this formatter is placed on.</p><p>If UrlProperty value starts with "~/" it will be resolved like UrlFormat.</p></td></tr>
<tr><td>DisplayFormat</td><td><p>This is the display text format of link. A sample would be "<i>click to open {0}</i>" where <i>{0}</i> is the DisplayProperty value.</p><p>If no format is specified, link will be the value of DisplayProperty as is.</p></td></tr>
<tr><td>DisplayProperty</td><td><p>This is name of the property that will be used to determine link text.</p>
<p>If not specified, it is the name of the column that this formatter is placed on.</p></td></tr>
<tr><td>Target</td><td><p>This is the target of the link. Use "_blank" to open links in a new tab.</p></td></tr>
</table>

## Custom Formatters

A custom formatter is a class that implements `Formatter` (a `format(ctx)` method) and registers with `formatterTypeInfo`:

```ts
import { FormatterContext, FormatterResult } from "@serenity-is/sleekgrid";
import { formatterTypeInfo, registerType } from "@serenity-is/corelib";

export class MyFormatter implements Formatter {
    static [Symbol.typeInfo] = formatterTypeInfo("MyApp.MyFormatter");
    static { registerType(this); }

    format(ctx: FormatterContext): FormatterResult {
        return ctx.value ? "Yes" : "No";
    }
}
```

See [Type Registration](../framework/ui/type-registration.md) for details.

You can also assign a formatter directly to a column in `createColumns()`:

```tsx
protected override createColumns() {
    let columns = new UserColumns(super.createColumns());
    columns.ImpersonationToken && (columns.ImpersonationToken.format = ctx => !ctx.value ? "" :
        <a target="_blank" href={resolveUrl(`~/Account/ImpersonateAs?token=${encodeURIComponent(ctx.value)}`)}>
            <i class={faIcon("user-secret", "primary")}></i>
        </a>);
    return columns.valueOf();
}
```

## See Also

- [FormatterContext (API reference)](../api/js/sleekgrid/interfaces/FormatterContext.md) — the formatter context.
- [FormatterBase (API reference)](../api/js/corelib/classes/FormatterBase.md) — the corelib formatter base class.
- [Type Registration](../framework/ui/type-registration.md) — registering formatter types.
- [Creating and Configuring Grids](creating-grids.md) — assigning formatters to columns.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.



