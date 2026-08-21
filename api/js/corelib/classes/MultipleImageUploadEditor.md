[@serenity-is/corelib](../README.md) / MultipleImageUploadEditor

# Class: MultipleImageUploadEditor\<P\>

Defined in: [src/ui/editors/uploadeditors.tsx:636](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L636)

An editor that uploads and displays multiple images.

## Extends

- [`MultipleFileUploadEditor`](MultipleFileUploadEditor.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) = [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md)

Widget props type.

## Constructors

### Constructor

> **new MultipleImageUploadEditor**\<`P`\>(`props`): `MultipleImageUploadEditor`\<`P`\>

Defined in: [src/ui/editors/uploadeditors.tsx:643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L643)

Creates a multiple image upload editor.

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

Widget props.

#### Returns

`MultipleImageUploadEditor`\<`P`\>

#### Overrides

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`constructor`](MultipleFileUploadEditor.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L24)

The DOM node this widget is bound to.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`domNode`](MultipleFileUploadEditor.md#domnode)

***

### hiddenInput

> `protected` **hiddenInput**: `HTMLInputElement`

Defined in: [src/ui/editors/uploadeditors.tsx:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L385)

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`hiddenInput`](MultipleFileUploadEditor.md#hiddeninput)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`idPrefix`](MultipleFileUploadEditor.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`options`](MultipleFileUploadEditor.md#options)

***

### progress

> `protected` **progress**: `HTMLElement`

Defined in: [src/ui/editors/uploadeditors.tsx:384](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L384)

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`progress`](MultipleFileUploadEditor.md#progress)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`uniqueName`](MultipleFileUploadEditor.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/uploadeditors.tsx:637](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L637)

#### Overrides

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`[typeInfo]`](MultipleFileUploadEditor.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`isComponent`](MultipleFileUploadEditor.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`element`](MultipleFileUploadEditor.md#element)

***

### jsonEncodeValue

#### Get Signature

> **get** **jsonEncodeValue**(): `boolean`

Defined in: [src/ui/editors/uploadeditors.tsx:626](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L626)

Whether the value is JSON-encoded.

##### Returns

`boolean`

True when JSON-encoded.

#### Set Signature

> **set** **jsonEncodeValue**(`value`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:629](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L629)

Sets whether the value is JSON-encoded.

##### Parameters

###### value

`boolean`

True to JSON-encode the value.

##### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`jsonEncodeValue`](MultipleFileUploadEditor.md#jsonencodevalue)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`props`](MultipleFileUploadEditor.md#props)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`readOnly`](MultipleFileUploadEditor.md#readonly)

***

### value

#### Get Signature

> **get** **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

Defined in: [src/ui/editors/uploadeditors.tsx:562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L562)

Returns the current uploaded files.

##### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

The uploaded files.

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:580](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L580)

Sets the uploaded files.

##### Parameters

###### v

[`UploadedFile`](../interfaces/UploadedFile.md)[]

The uploaded files to set.

##### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`value`](MultipleFileUploadEditor.md#value)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L89)

Adds the widget's CSS class to its DOM node.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`addCssClass`](MultipleFileUploadEditor.md#addcssclass)

***

### addFileButtonText()

> `protected` **addFileButtonText**(): `string`

Defined in: [src/ui/editors/uploadeditors.tsx:449](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L449)

Returns the text for the add-file button.

#### Returns

`string`

The button text.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`addFileButtonText`](MultipleFileUploadEditor.md#addfilebuttontext)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`addValidationRule`](MultipleFileUploadEditor.md#addvalidationrule)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`addValidationRule`](MultipleFileUploadEditor.md#addvalidationrule)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`afterRender`](MultipleFileUploadEditor.md#afterrender)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`byId`](MultipleFileUploadEditor.md#byid)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`change`](MultipleFileUploadEditor.md#change)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`changeSelect2`](MultipleFileUploadEditor.md#changeselect2)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`deferRender`](MultipleFileUploadEditor.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

Destroys the widget, removing its association with the DOM node, its CSS
classes and its event handlers.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`destroy`](MultipleFileUploadEditor.md#destroy)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`findById`](MultipleFileUploadEditor.md#findbyid)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/uploadeditors.tsx:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L502)

Returns whether the editor is read-only.

#### Returns

`boolean`

True when read-only.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`get_readOnly`](MultipleFileUploadEditor.md#get_readonly)

***

### get\_required()

> **get\_required**(): `boolean`

Defined in: [src/ui/editors/uploadeditors.tsx:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L536)

Returns whether the field is required.

#### Returns

`boolean`

True when required.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`get_required`](MultipleFileUploadEditor.md#get_required)

***

### get\_value()

> **get\_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

Defined in: [src/ui/editors/uploadeditors.tsx:552](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L552)

Returns the current uploaded files.

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

The uploaded files.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`get_value`](MultipleFileUploadEditor.md#get_value)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getCssClass`](MultipleFileUploadEditor.md#getcssclass)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getCustomAttribute`](MultipleFileUploadEditor.md#getcustomattribute)

***

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:589](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L589)

Gets the edit value into a target object.

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

The property item.

##### target

`any`

The target object.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getEditValue`](MultipleFileUploadEditor.md#geteditvalue)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getGridField`](MultipleFileUploadEditor.md#getgridfield)

***

### getToolButtons()

> `protected` **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/editors/uploadeditors.tsx:457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L457)

Returns the toolbar buttons for the editor.

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

Tool button definitions.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getToolButtons`](MultipleFileUploadEditor.md#gettoolbuttons)

***

### getUploadInputOptions()

> `protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

Defined in: [src/ui/editors/uploadeditors.tsx:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L419)

Returns the upload input options.

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

Upload input options.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getUploadInputOptions`](MultipleFileUploadEditor.md#getuploadinputoptions)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`init`](MultipleFileUploadEditor.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`internalRenderContents`](MultipleFileUploadEditor.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`legacyTemplateRender`](MultipleFileUploadEditor.md#legacytemplaterender)

***

### populate()

> `protected` **populate**(): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:470](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L470)

Populates the file symbols from the current entities.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`populate`](MultipleFileUploadEditor.md#populate)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`render`](MultipleFileUploadEditor.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`renderContents`](MultipleFileUploadEditor.md#rendercontents)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L510)

Sets whether the editor is read-only.

#### Parameters

##### value

`boolean`

True to enable read-only mode.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`set_readOnly`](MultipleFileUploadEditor.md#set_readonly)

***

### set\_required()

> **set\_required**(`value`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:544](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L544)

Sets whether the field is required.

#### Parameters

##### value

`boolean`

True when required.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`set_required`](MultipleFileUploadEditor.md#set_required)

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L570)

Sets the uploaded files.

#### Parameters

##### value

[`UploadedFile`](../interfaces/UploadedFile.md)[]

The uploaded files to set.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`set_value`](MultipleFileUploadEditor.md#set_value)

***

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:603](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L603)

Sets the edit value from a source object.

#### Parameters

##### source

`any`

The source object.

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

The property item.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`setEditValue`](MultipleFileUploadEditor.md#seteditvalue)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`syncOrAsyncThen`](MultipleFileUploadEditor.md#syncorasyncthen)

***

### updateInterface()

> `protected` **updateInterface**(): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:492](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L492)

Updates the interface to reflect the current state.

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`updateInterface`](MultipleFileUploadEditor.md#updateinterface)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`useIdPrefix`](MultipleFileUploadEditor.md#useidprefix)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`create`](MultipleFileUploadEditor.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

Creates the default DOM element for a widget.

#### Returns

`HTMLElement`

A new `div` element.

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`createDefaultElement`](MultipleFileUploadEditor.md#createdefaultelement)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getWidgetName`](MultipleFileUploadEditor.md#getwidgetname)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`registerClass`](MultipleFileUploadEditor.md#registerclass)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`registerEditor`](MultipleFileUploadEditor.md#registereditor)
