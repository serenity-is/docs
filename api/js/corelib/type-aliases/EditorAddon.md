[@serenity-is/corelib](../README.md) / EditorAddon

# Type Alias: EditorAddon()

> **EditorAddon** = (`props`) => `void`

Defined in: [src/base/propertyitem.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L33)

Callback that augments an editor with additional UI alongside the editor element.
Used via [PropertyItem.editorAddons](../interfaces/PropertyItem.md#editoraddons) to inject buttons or custom fragments.

## Parameters

### props

Context supplied to the addon.

#### documentFragment?

`DocumentFragment`

Optional document fragment the addon can attach to when the editor is rendered inside a fragment.

#### editorElement

`HTMLElement`

Root DOM element of the editor.

#### propertyItem?

[`PropertyItem`](../interfaces/PropertyItem.md)

Metadata for the field the editor belongs to, if available.

## Returns

`void`

Void; the addon is expected to manipulate the DOM directly.
