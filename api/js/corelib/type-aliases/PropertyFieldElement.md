[@serenity-is/corelib](../README.md) / PropertyFieldElement

# Type Alias: PropertyFieldElement

> **PropertyFieldElement** = `HTMLElement` & `object`

Defined in: [src/ui/widgets/propertygrid.tsx:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L12)

A field element rendered by the property grid, augmented with the editor
widget, its loading promise and the associated [PropertyItem](../interfaces/PropertyItem.md).

## Type Declaration

### editorPromise?

> `optional` **editorPromise**: `PromiseLike`\<`void`\>

A promise that resolves when the editor type finishes loading.

### editorWidget?

> `optional` **editorWidget**: [`Widget`](../classes/Widget.md)\<`any`\>

The editor widget created for this field, once loaded.

### propertyItem?

> `optional` **propertyItem**: [`PropertyItem`](../interfaces/PropertyItem.md)

The property item this field was rendered from.
