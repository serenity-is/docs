# Toolbar

The `Toolbar` widget renders a horizontal bar of buttons. It is used by grids (for actions like Add, Refresh, Column Picker) and dialogs (for Save, Delete, etc.).

## The ToolButton Definition

A toolbar button is a `ToolButton`:

```ts
interface ToolButton extends ToolButtonProps {
    hotkey?: string;            // e.g. "ctrl+s"
    hotkeyAllowDefault?: boolean;
    hotkeyContext?: any;
    separator?: false | true | 'left' | 'right' | 'both';
}
```

`ToolButtonProps` provides the button's appearance and behavior:

| Property | Description |
| --- | --- |
| `title` | The button's title (text or element). |
| `hint` | Tooltip shown on hover. |
| `cssClass` | CSS class(es) applied to the button. |
| `icon` | Icon class name displayed before the title. |
| `action` | Action name stored on the button's `data-action` attribute. |
| `onClick` | Handler invoked when the button is clicked. |
| `visible` | Whether the button is visible; may be a function evaluated on update. |
| `disabled` | Whether the button is disabled; may be a function evaluated on update. |
| `ref` | Callback invoked with the created button element. |

## Adding Buttons to a Grid

Override `getButtons()` to add toolbar buttons to a grid:

```ts
protected override getButtons(): ToolButton[] {
    const buttons = super.getButtons();

    buttons.push({
        title: "My Action",
        cssClass: "my-action-button",
        icon: faIcon("star"),
        onClick: () => {
            // handle click
        },
        disabled: () => !this.hasPermission("My:Action")
    });

    return buttons;
}
```

The `visible` and `disabled` properties can be functions that are re-evaluated when the interface updates (via the `updateInterface` event).

## Adding Buttons to a Dialog

Dialogs override `getToolbarButtons()`:

```ts
protected override getToolbarButtons(): ToolButton[] {
    const buttons = super.getToolbarButtons();

    buttons.push({
        title: "Custom Action",
        onClick: () => { /* ... */ }
    });

    return buttons;
}
```

## Hotkeys

Buttons can define a hotkey:

```ts
{
    title: "Save",
    hotkey: "ctrl+s",
    onClick: () => { /* ... */ }
}
```

The hotkey is bound to the toolbar's `hotkeyContext` (or the widget's DOM node).

## Separators

Use `separator` to render a divider before a button:

```ts
{
    title: "Save",
    separator: true,
    onClick: () => { /* ... */ }
}
```

## See Also

- [Toolbar (API reference)](../api/js/corelib/classes/Toolbar.md) — the toolbar widget.
- [ToolButton (API reference)](../api/js/corelib/interfaces/ToolButton.md) — the button definition.
- [ToolButtonProps (API reference)](../api/js/corelib/interfaces/ToolButtonProps.md) — button props.
- [ToolbarOptions (API reference)](../api/js/corelib/interfaces/ToolbarOptions.md) — toolbar options.
- [Creating and Configuring Grids](creating-grids.md) — adding buttons to grids.
- [EntityDialog and CRUD Workflows](../dialogs/entitydialog.md) — dialog toolbar buttons.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.