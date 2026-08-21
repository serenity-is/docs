[@serenity-is/corelib](../README.md) / HtmlContentEditor

# Class: HtmlContentEditor\<P\>

Defined in: [src/ui/editors/htmlcontenteditor.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L40)

An editor that renders rich HTML content using CKEditor or Tiptap.

## Extends

- [`EditorWidget`](EditorWidget.md)\<`P`\>

## Extended by

- [`HtmlNoteContentEditor`](HtmlNoteContentEditor.md)
- [`HtmlReportContentEditor`](HtmlReportContentEditor.md)

## Type Parameters

### P

`P` *extends* [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) = [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md)

Widget props type.

## Implements

- [`IStringValue`](IStringValue.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### Constructor

> **new HtmlContentEditor**\<`P`\>(`props`): `HtmlContentEditor`\<`P`\>

Defined in: [src/ui/editors/htmlcontenteditor.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L72)

Creates an HTML content editor.

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

Widget props.

#### Returns

`HtmlContentEditor`\<`P`\>

#### Overrides

[`EditorWidget`](EditorWidget.md).[`constructor`](EditorWidget.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLTextAreaElement`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L45)

The DOM node this widget is bound to.

#### Overrides

[`EditorWidget`](EditorWidget.md).[`domNode`](EditorWidget.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`idPrefix`](EditorWidget.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`options`](EditorWidget.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`uniqueName`](EditorWidget.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/htmlcontenteditor.tsx:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L42)

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`[typeInfo]`](IReadOnly.md#typeinfo)

#### Overrides

[`EditorWidget`](EditorWidget.md).[`[typeInfo]`](EditorWidget.md#typeinfo)

***

### CKEditorBasePath

> `static` **CKEditorBasePath**: `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:448](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L448)

Base path for CKEditor assets.

***

### CKEditorVer

> `static` **CKEditorVer**: `string` = `"4.22.1"`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L446)

CKEditor version to load.

***

### defaultEditorProvider

> `static` **defaultEditorProvider**: [`HtmlContentEditorProvider`](../type-aliases/HtmlContentEditorProvider.md)

Defined in: [src/ui/editors/htmlcontenteditor.tsx:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L62)

Default editor provider.

***

### defaultOptions

> `readonly` `static` **defaultOptions**: `Partial`\<[`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md)\> = `{}`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L65)

Default options for the editor.

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`isComponent`](EditorWidget.md#iscomponent)

***

### tiptapModule

> `static` **tiptapModule**: [`TiptapModule`](../interfaces/TiptapModule.md) \| () => [`TiptapModule`](../interfaces/TiptapModule.md) \| `Promise`\<[`TiptapModule`](../interfaces/TiptapModule.md)\>

Defined in: [src/ui/editors/htmlcontenteditor.tsx:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L48)

The Tiptap module loader.

## Accessors

### editorProvider

#### Get Signature

> **get** **editorProvider**(): [`HtmlContentEditorProvider`](../type-aliases/HtmlContentEditorProvider.md)

Defined in: [src/ui/editors/htmlcontenteditor.tsx:490](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L490)

Returns the active editor provider.

##### Returns

[`HtmlContentEditorProvider`](../type-aliases/HtmlContentEditorProvider.md)

The editor provider.

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`element`](EditorWidget.md#element)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`props`](EditorWidget.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/editors/editorwidget.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L42)

Returns whether the editor is read-only.

##### Returns

`boolean`

True when read-only.

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/editors/editorwidget.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L48)

Sets whether the editor is read-only.

##### Parameters

###### value

`boolean`

##### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`readOnly`](EditorWidget.md#readonly)

***

### value

#### Get Signature

> **get** **value**(): `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L380)

Returns the current HTML value.

##### Returns

`string`

The HTML value.

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:406](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L406)

Sets the HTML value.

##### Parameters

###### v

`string`

##### Returns

`void`

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L89)

Adds the widget's CSS class to its DOM node.

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`addCssClass`](EditorWidget.md#addcssclass)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName?`): `void`

Defined in: [src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

Adds a validation rule to the widget's DOM node.

##### Parameters

###### rule

(`input`) => `string`

The validation rule function, or a unique name when the
  two-argument overload is used.

###### uniqueName?

`string`

A unique name for the rule, or the rule function when
  the two-argument overload is used.

##### Returns

`void`

##### Inherited from

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

Defined in: [src/ui/widgets/widget.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L143)

Adds a validation rule to the widget's DOM node.

##### Parameters

###### uniqueName

`string`

A unique name for the rule, or the rule function when
  the two-argument overload is used.

###### rule

(`input`) => `string`

The validation rule function, or a unique name when the
  two-argument overload is used.

##### Returns

`void`

##### Inherited from

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

Defined in: [src/ui/widgets/widget.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L228)

Queues a callback to run after the widget's contents are rendered.

#### Parameters

##### callback

() => `void`

The callback to run after rendering.

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`afterRender`](EditorWidget.md#afterrender)

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

Defined in: [src/ui/widgets/widget.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L154)

Finds a child element by its prefix-relative id.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

The id relative to the widget's id prefix.

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

A [Fluent](../functions/Fluent.md) wrapper for the matching element.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`byId`](EditorWidget.md#byid)

***

### change()

> **change**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

Registers a `change` handler on the widget's DOM node.

#### Parameters

##### handler

(`e`) => `void`

The change event handler.

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`change`](EditorWidget.md#change)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

Registers a `change` handler that ignores changes originating from
combobox setting values.

#### Parameters

##### handler

(`e`) => `void`

The change event handler.

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`changeSelect2`](EditorWidget.md#changeselect2)

***

### configureTiptapExtension()

> `protected` **configureTiptapExtension**(`extension`): `any`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L298)

Configures a Tiptap extension.

#### Parameters

##### extension

`any`

The extension to configure.

#### Returns

`any`

The configured extension.

***

### createTiptapToolbar()

> `protected` **createTiptapToolbar**(`editor`, `hidden`): `HTMLElement`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:330](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L330)

Creates the Tiptap toolbar.

#### Parameters

##### editor

`any`

The Tiptap editor.

##### hidden

[`TiptapToolbarHiddenOption`](../interfaces/TiptapToolbarHiddenOption.md)

Hidden toolbar options.

#### Returns

`HTMLElement`

The toolbar element.

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L98)

Determines whether rendering should be deferred until [init](#init) is
called.

#### Returns

`boolean`

True to defer rendering.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`deferRender`](EditorWidget.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:347](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L347)

Cleans up the editor instance.

#### Returns

`void`

#### Overrides

[`EditorWidget`](EditorWidget.md).[`destroy`](EditorWidget.md#destroy)

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

Defined in: [src/ui/widgets/widget.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L163)

Finds a child element by its prefix-relative id.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

The id relative to the widget's id prefix.

#### Returns

`TElement`

The matching element, or null if not found.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`findById`](EditorWidget.md#findbyid)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L414)

Returns whether the editor is read-only.

#### Returns

`boolean`

True when read-only.

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L363)

Returns the current HTML value.

#### Returns

`string`

The HTML value.

#### Implementation of

[`IStringValue`](IStringValue.md).[`get_value`](IStringValue.md#get_value)

***

### getCKEditorConfig()

> `protected` **getCKEditorConfig**(): [`CKEditorConfig`](../interfaces/CKEditorConfig.md)

Defined in: [src/ui/editors/htmlcontenteditor.tsx:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L234)

Returns the CKEditor configuration.

#### Returns

[`CKEditorConfig`](../interfaces/CKEditorConfig.md)

The CKEditor config.

***

### getCKEditorInstance()

> `protected` **getCKEditorInstance**(): `any`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L288)

Returns the CKEditor instance for this editor.

#### Returns

`any`

The CKEditor instance.

***

### getCKEditorLanguage()

> `protected` **getCKEditorLanguage**(): `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L204)

Returns the CKEditor language code.

#### Returns

`string`

The language code.

***

### ~~getConfig()~~

> `protected` **getConfig**(): [`CKEditorConfig`](../interfaces/CKEditorConfig.md)

Defined in: [src/ui/editors/htmlcontenteditor.tsx:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L226)

#### Returns

[`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Deprecated

Override and use getCKEditorConfig()

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getCssClass`](EditorWidget.md#getcssclass)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

Defined in: [src/ui/widgets/widget.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L220)

Returns a custom attribute applied to the widget's type.

#### Type Parameters

##### TAttr

`TAttr` *extends* [`CustomAttribute`](CustomAttribute.md)

#### Parameters

##### attrType

(...`args`) => `TAttr`

The attribute type to look up.

##### inherit

`boolean` = `true`

Whether to search inherited types; defaults to true.

#### Returns

`TAttr`

The matching attribute, or null.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getCustomAttribute`](EditorWidget.md#getcustomattribute)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getGridField`](EditorWidget.md#getgridfield)

***

### getTiptapExtensions()

> `protected` **getTiptapExtensions**(`tiptap`): `any`[]

Defined in: [src/ui/editors/htmlcontenteditor.tsx:320](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L320)

Returns the Tiptap extensions for this editor.

#### Parameters

##### tiptap

[`TiptapModule`](../interfaces/TiptapModule.md)

The Tiptap module.

#### Returns

`any`[]

The extensions.

***

### getTiptapToolbarHidden()

> `protected` **getTiptapToolbarHidden**(`editor`): [`TiptapToolbarHiddenOption`](../interfaces/TiptapToolbarHiddenOption.md)

Defined in: [src/ui/editors/htmlcontenteditor.tsx:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L339)

Returns the hidden Tiptap toolbar options.

#### Parameters

##### editor

`any`

The Tiptap editor.

#### Returns

[`TiptapToolbarHiddenOption`](../interfaces/TiptapToolbarHiddenOption.md)

The hidden options.

***

### handleCKEditorChange()

> `protected` **handleCKEditorChange**(`e`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L178)

Handles the CKEditor change event.

#### Parameters

##### e

`any`

The CKEditor event.

#### Returns

`void`

***

### handleCKInstanceReady()

> `protected` **handleCKInstanceReady**(`x`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L161)

Handles the CKEditor instance-ready event.

#### Parameters

##### x

`any`

The CKEditor event.

#### Returns

`void`

***

### handleCKKey()

> `protected` **handleCKKey**(`e`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L196)

Handles the CKEditor key event.

#### Parameters

##### e

`any`

The CKEditor event.

#### Returns

`void`

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`init`](EditorWidget.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`internalRenderContents`](EditorWidget.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`legacyTemplateRender`](EditorWidget.md#legacytemplaterender)

***

### render()

> **render**(): `any`

Defined in: [src/ui/widgets/widget.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L253)

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`render`](EditorWidget.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`renderContents`](EditorWidget.md#rendercontents)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:422](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L422)

Sets whether the editor is read-only.

#### Parameters

##### value

`boolean`

True to enable read-only mode.

#### Returns

`void`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L388)

Sets the HTML value.

#### Parameters

##### value

`string`

The HTML value to set.

#### Returns

`void`

#### Implementation of

[`IStringValue`](IStringValue.md).[`set_value`](IStringValue.md#set_value)

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

Defined in: [src/ui/widgets/widget.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L318)

Runs a method synchronously or asynchronously depending on the widget's
`useAsync` flag, then invokes a continuation.

#### Type Parameters

##### T

`T`

#### Parameters

##### syncMethod

() => `T`

The synchronous method to run.

##### asyncMethod

() => `PromiseLike`\<`T`\>

The asynchronous method to run.

##### then

(`v`) => `void`

The continuation invoked with the result.

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`syncOrAsyncThen`](EditorWidget.md#syncorasyncthen)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`useIdPrefix`](EditorWidget.md#useidprefix)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

Defined in: [src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

Creates a widget instance from the given params, appending its element to
the container and invoking the init/init callbacks.

#### Type Parameters

##### TWidget

`TWidget` *extends* [`Widget`](Widget.md)\<`P`\>

##### P

`P`

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

The widget creation params.

#### Returns

`TWidget`

The created widget instance.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`create`](EditorWidget.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLTextAreaElement`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L59)

Creates the default DOM element for a widget.

#### Returns

`HTMLTextAreaElement`

A new `div` element.

#### Overrides

[`EditorWidget`](EditorWidget.md).[`createDefaultElement`](EditorWidget.md#createdefaultelement)

***

### getCKEditorBasePath()

> `static` **getCKEditorBasePath**(): `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:454](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L454)

Returns the base path for CKEditor assets.

#### Returns

`string`

The base path.

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

Defined in: [src/ui/widgets/widget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L131)

Returns the widget name for a type, used for association and unique names.

#### Parameters

##### type

`Function`

The widget type.

#### Returns

`string`

The widget name.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getWidgetName`](EditorWidget.md#getwidgetname)

***

### includeCKEditor()

> `static` **includeCKEditor**(`then`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L471)

Includes the CKEditor script and invokes the callback when loaded.

#### Parameters

##### then

() => `void`

Callback invoked when CKEditor is available.

#### Returns

`void`

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L342)

Registers this type as a class with the given type name.

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

The type name to register.

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes.

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

The class type info.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`registerClass`](EditorWidget.md#registerclass)

***

### registerEditor()

> `protected` `static` **registerEditor**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L357)

Registers this type as an editor with the given type name.

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

The type name to register.

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes.

#### Returns

[`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

The editor type info.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`registerEditor`](EditorWidget.md#registereditor)
