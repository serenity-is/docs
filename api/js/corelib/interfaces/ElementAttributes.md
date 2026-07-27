[@serenity-is/corelib](../README.md) / ElementAttributes

# Interface: ElementAttributes\<T\>

Defined in: [../domwise/dist/index.d.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L48)

Global `Element` + `Node` interface keys, shared by all tags regardless of their namespace:

1. That's `keys` that are defined BY ALL `HTMLElement/SVGElement/MathMLElement` interfaces.
2. Includes `keys` defined by `Element` and `Node` interfaces.

## Extends

- [`CustomDomAttributes`](CustomDomAttributes.md)\<`T`\>.`DirectiveAttributes`.`DirectiveFunctionAttributes`\<`T`\>.`PropAttributes`.`OnAttributes`\<`T`\>.`EventHandlersElement`\<`T`\>.`AriaAttributes`

## Type Parameters

### T

`T`

## Properties

### aria-activedescendant?

> `optional` **aria-activedescendant**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L176)

Identifies the currently active element when DOM focus is on a composite widget, textbox,
group, or application.

***

### aria-atomic?

> `optional` **aria-atomic**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L181)

Indicates whether assistive technologies will present all, or only parts of, the changed
region based on the change notifications defined by the aria-relevant attribute.

***

### aria-autocomplete?

> `optional` **aria-autocomplete**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"none"` \| `"list"` \| `"both"` \| `"inline"`\>

Defined in: [../domwise/dist/index.d.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L208)

Indicates whether inputting text could trigger display of one or more predictions of the
user's intended value for an input and specifies how predictions would be presented if they
are made.

***

### aria-braillelabel?

> `optional` **aria-braillelabel**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L188)

Similar to the global aria-label. Defines a string value that labels the current element,
which is intended to be converted into Braille.

#### See

aria-label.

***

### aria-brailleroledescription?

> `optional` **aria-brailleroledescription**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L202)

Defines a human-readable, author-localized abbreviated description for the role of an element
intended to be converted into Braille. Braille is not a one-to-one transliteration of letters
and numbers, but rather it includes various abbreviations, contractions, and characters that
represent words (known as logograms).

Instead of converting long role descriptions to Braille, the aria-brailleroledescription
attribute allows for providing an abbreviated version of the aria-roledescription value,
which is a human-readable, author-localized description for the role of an element, for
improved user experience with braille interfaces.

#### See

aria-roledescription.

***

### aria-busy?

> `optional` **aria-busy**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:213](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L213)

Indicates an element is being modified and that assistive technologies MAY want to wait until
the modifications are complete before exposing them to the user.

***

### aria-checked?

> `optional` **aria-checked**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean` \| `"mixed"`\>

Defined in: [../domwise/dist/index.d.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L219)

Indicates the current "checked" state of checkboxes, radio buttons, and other widgets.

#### See

 - aria-pressed
 - aria-selected.

***

### aria-colcount?

> `optional` **aria-colcount**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:225](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L225)

Defines the total number of columns in a table, grid, or treegrid.

#### See

aria-colindex.

***

### aria-colindex?

> `optional` **aria-colindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:232](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L232)

Defines an element's column index or position with respect to the total number of columns
within a table, grid, or treegrid.

#### See

 - aria-colcount
 - aria-colspan.

***

### aria-colindextext?

> `optional` **aria-colindextext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L234)

Defines a human-readable text alternative of the numeric aria-colindex.

***

### aria-colspan?

> `optional` **aria-colspan**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L241)

Defines the number of columns spanned by a cell or gridcell within a table, grid, or
treegrid.

#### See

 - aria-colindex
 - aria-rowspan.

***

### aria-controls?

> `optional` **aria-controls**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L248)

Identifies the element (or elements) whose contents or presence are controlled by the current
element.

#### See

aria-owns.

***

### aria-current?

> `optional` **aria-current**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"time"` \| `EnumeratedPseudoBoolean` \| `"page"` \| `"step"` \| `"date"` \| `"location"`\>

Defined in: [../domwise/dist/index.d.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L253)

Indicates the element that represents the current item within a container or set of related
elements.

***

### aria-describedby?

> `optional` **aria-describedby**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L259)

Identifies the element (or elements) that describes the object.

#### See

aria-labelledby

***

### aria-description?

> `optional` **aria-description**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:265](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L265)

Defines a string value that describes or annotates the current element.

#### See

aria-describedby

***

### aria-details?

> `optional` **aria-details**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:271](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L271)

Identifies the element that provides a detailed, extended description for the object.

#### See

aria-describedby.

***

### aria-disabled?

> `optional` **aria-disabled**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L278)

Indicates that the element is perceivable but disabled, so it is not editable or otherwise
operable.

#### See

 - aria-hidden
 - aria-readonly.

***

### ~~aria-dropeffect?~~

> `optional` **aria-dropeffect**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"link"` \| `"copy"` \| `"none"` \| `"move"` \| `"execute"` \| `"popup"`\>

Defined in: [../domwise/dist/index.d.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L285)

Indicates what functions can be performed when a dragged object is released on the drop
target.

#### Deprecated

In ARIA 1.1

***

### aria-errormessage?

> `optional` **aria-errormessage**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L291)

Identifies the element that provides an error message for the object.

#### See

 - aria-invalid
 - aria-describedby.

***

### aria-expanded?

> `optional` **aria-expanded**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L296)

Indicates whether the element, or another grouping element it controls, is currently expanded
or collapsed.

***

### aria-flowto?

> `optional` **aria-flowto**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L302)

Identifies the next element (or elements) in an alternate reading order of content which, at
the user's discretion, allows assistive technology to override the general default of reading
in document source order.

***

### ~~aria-grabbed?~~

> `optional` **aria-grabbed**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L308)

Indicates an element's "grabbed" state in a drag-and-drop operation.

#### Deprecated

In ARIA 1.1

***

### aria-haspopup?

> `optional` **aria-haspopup**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"dialog"` \| `"menu"` \| `"tree"` \| `EnumeratedPseudoBoolean` \| `"grid"` \| `"listbox"`\>

Defined in: [../domwise/dist/index.d.ts:313](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L313)

Indicates the availability and type of interactive popup element, such as menu or dialog,
that can be triggered by an element.

***

### aria-hidden?

> `optional` **aria-hidden**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:319](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L319)

Indicates whether the element is exposed to an accessibility API.

#### See

aria-disabled.

***

### aria-invalid?

> `optional` **aria-invalid**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean` \| `"grammar"` \| `"spelling"`\>

Defined in: [../domwise/dist/index.d.ts:325](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L325)

Indicates the entered value does not conform to the format expected by the application.

#### See

aria-errormessage.

***

### aria-keyshortcuts?

> `optional` **aria-keyshortcuts**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:330](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L330)

Indicates keyboard shortcuts that an author has implemented to activate or give focus to an
element.

***

### aria-label?

> `optional` **aria-label**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:336](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L336)

Defines a string value that labels the current element.

#### See

aria-labelledby.

***

### aria-labelledby?

> `optional` **aria-labelledby**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L342)

Identifies the element (or elements) that labels the current element.

#### See

aria-describedby.

***

### aria-level?

> `optional` **aria-level**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:344](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L344)

Defines the hierarchical level of an element within a structure.

***

### aria-live?

> `optional` **aria-live**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"polite"` \| `"assertive"` \| `"off"`\>

Defined in: [../domwise/dist/index.d.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L349)

Indicates that an element will be updated, and describes the types of updates the user
agents, assistive technologies, and user can expect from the live region.

***

### aria-modal?

> `optional` **aria-modal**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L351)

Indicates whether an element is modal when displayed.

***

### aria-multiline?

> `optional` **aria-multiline**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L353)

Indicates whether a text box accepts multiple lines of input or only a single line.

***

### aria-multiselectable?

> `optional` **aria-multiselectable**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:358](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L358)

Indicates that the user may select more than one item from the current selectable
descendants.

***

### aria-orientation?

> `optional` **aria-orientation**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"horizontal"` \| `"vertical"`\>

Defined in: [../domwise/dist/index.d.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L360)

Indicates whether the element's orientation is horizontal, vertical, or unknown/ambiguous.

***

### aria-owns?

> `optional` **aria-owns**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:368](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L368)

Identifies an element (or elements) in order to define a visual, functional, or contextual
parent/child relationship between DOM elements where the DOM hierarchy cannot be used to
represent the relationship.

#### See

aria-controls.

***

### aria-placeholder?

> `optional` **aria-placeholder**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:374](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L374)

Defines a short hint (a word or short phrase) intended to aid the user with data entry when
the control has no value. A hint could be a sample value or a brief description of the
expected format.

***

### aria-posinset?

> `optional` **aria-posinset**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:381](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L381)

Defines an element's number or position in the current set of listitems or treeitems. Not
required if all elements in the set are present in the DOM.

#### See

aria-setsize.

***

### aria-pressed?

> `optional` **aria-pressed**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean` \| `"mixed"`\>

Defined in: [../domwise/dist/index.d.ts:387](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L387)

Indicates the current "pressed" state of toggle buttons.

#### See

 - aria-checked
 - aria-selected.

***

### aria-readonly?

> `optional` **aria-readonly**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L393)

Indicates that the element is not editable, but is otherwise operable.

#### See

aria-disabled.

***

### aria-relevant?

> `optional` **aria-relevant**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"text"` \| `"all"` \| `"additions"` \| `"additions removals"` \| `"additions text"` \| `"removals"` \| `"removals additions"` \| `"removals text"` \| `"text additions"` \| `"text removals"`\>

Defined in: [../domwise/dist/index.d.ts:400](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L400)

Indicates what notifications the user agent will trigger when the accessibility tree within a
live region is modified.

#### See

aria-atomic.

***

### aria-required?

> `optional` **aria-required**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:402](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L402)

Indicates that user input is required on the element before a form may be submitted.

***

### aria-roledescription?

> `optional` **aria-roledescription**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:404](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L404)

Defines a human-readable, author-localized description for the role of an element.

***

### aria-rowcount?

> `optional` **aria-rowcount**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:410](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L410)

Defines the total number of rows in a table, grid, or treegrid.

#### See

aria-rowindex.

***

### aria-rowindex?

> `optional` **aria-rowindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L417)

Defines an element's row index or position with respect to the total number of rows within a
table, grid, or treegrid.

#### See

 - aria-rowcount
 - aria-rowspan.

***

### aria-rowindextext?

> `optional` **aria-rowindextext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L419)

Defines a human-readable text alternative of aria-rowindex.

***

### aria-rowspan?

> `optional` **aria-rowspan**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:425](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L425)

Defines the number of rows spanned by a cell or gridcell within a table, grid, or treegrid.

#### See

 - aria-rowindex
 - aria-colspan.

***

### aria-selected?

> `optional` **aria-selected**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:431](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L431)

Indicates the current "selected" state of various widgets.

#### See

 - aria-checked
 - aria-pressed.

***

### aria-setsize?

> `optional` **aria-setsize**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:438](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L438)

Defines the number of items in the current set of listitems or treeitems. Not required if all
elements in the set are present in the DOM.

#### See

aria-posinset.

***

### aria-sort?

> `optional` **aria-sort**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"none"` \| `"descending"` \| `"ascending"` \| `"other"`\>

Defined in: [../domwise/dist/index.d.ts:440](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L440)

Indicates if items in a table or grid are sorted in ascending or descending order.

***

### aria-valuemax?

> `optional` **aria-valuemax**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L442)

Defines the maximum allowed value for a range widget.

***

### aria-valuemin?

> `optional` **aria-valuemin**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:444](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L444)

Defines the minimum allowed value for a range widget.

***

### aria-valuenow?

> `optional` **aria-valuenow**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L450)

Defines the current value for a range widget.

#### See

aria-valuetext.

***

### aria-valuetext?

> `optional` **aria-valuetext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:452](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L452)

Defines the human readable text alternative of aria-valuenow for a range widget.

***

### autofocus?

> `optional` **autofocus**: [`PropValue`](../type-aliases/PropValue.md)\<`BooleanAttribute`\>

Defined in: [../domwise/dist/index.d.ts:606](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L606)

***

### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [../domwise/dist/index.d.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L39)

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`children`](CustomDomAttributes.md#children)

***

### class?

> `optional` **class**: [`PropValue`](../type-aliases/PropValue.md)\<[`ClassNames`](../type-aliases/ClassNames.md)\> \| \{\[`key`: `string`\]: [`PropValue`](../type-aliases/PropValue.md)\<`boolean`\>; \}

Defined in: [../domwise/dist/index.d.ts:607](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L607)

***

### className?

> `optional` **className**: [`PropValue`](../type-aliases/PropValue.md)\<[`ClassNames`](../type-aliases/ClassNames.md)\> \| \{\[`key`: `string`\]: [`PropValue`](../type-aliases/PropValue.md)\<`boolean`\>; \}

Defined in: [../domwise/dist/index.d.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L49)

***

### dangerouslySetInnerHTML?

> `optional` **dangerouslySetInnerHTML**: `object`

Defined in: [../domwise/dist/index.d.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L40)

#### \_\_html

> **\_\_html**: `string`

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`dangerouslySetInnerHTML`](CustomDomAttributes.md#dangerouslysetinnerhtml)

***

### elementtiming?

> `optional` **elementtiming**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:610](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L610)

***

### id?

> `optional` **id**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:611](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L611)

***

### namespaceURI?

> `optional` **namespaceURI**: `string`

Defined in: [../domwise/dist/index.d.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L51)

***

### nonce?

> `optional` **nonce**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:612](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L612)

***

### on?

> `optional` **on**: `Record`\<`string`, `Function`\>

Defined in: [../domwise/dist/index.d.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L45)

compat from jsx-dom/react

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`on`](CustomDomAttributes.md#on)

***

### onAbort?

> `optional` **onAbort**: `EventHandler`\<`T`, `UIEvent`\>

Defined in: [../domwise/dist/index.d.ts:480](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L480)

***

### onAnimationCancel?

> `optional` **onAnimationCancel**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L481)

***

### onAnimationEnd?

> `optional` **onAnimationEnd**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L482)

***

### onAnimationIteration?

> `optional` **onAnimationIteration**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:483](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L483)

***

### onAnimationStart?

> `optional` **onAnimationStart**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:484](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L484)

***

### onAuxClick?

> `optional` **onAuxClick**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:485](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L485)

***

### onBeforeCopy?

> `optional` **onBeforeCopy**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:486](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L486)

***

### onBeforeCut?

> `optional` **onBeforeCut**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:487](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L487)

***

### onBeforeInput?

> `optional` **onBeforeInput**: `InputEventHandler`\<`T`, `InputEvent`\>

Defined in: [../domwise/dist/index.d.ts:488](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L488)

***

### onBeforeMatch?

> `optional` **onBeforeMatch**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:489](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L489)

***

### onBeforePaste?

> `optional` **onBeforePaste**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:490](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L490)

***

### onBeforeToggle?

> `optional` **onBeforeToggle**: `EventHandler`\<`T`, `ToggleEvent`\>

Defined in: [../domwise/dist/index.d.ts:491](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L491)

***

### onBeforeXRSelect?

> `optional` **onBeforeXRSelect**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:492](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L492)

***

### onBlur?

> `optional` **onBlur**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L493)

***

### onCancel?

> `optional` **onCancel**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:494](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L494)

***

### onCanPlay?

> `optional` **onCanPlay**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L495)

***

### onCanPlayThrough?

> `optional` **onCanPlayThrough**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:496](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L496)

***

### onCapture?

> `optional` **onCapture**: `Record`\<`string`, `Function`\>

Defined in: [../domwise/dist/index.d.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L46)

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`onCapture`](CustomDomAttributes.md#oncapture)

***

### onChange?

> `optional` **onChange**: `ChangeEventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:497](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L497)

***

### onClick?

> `optional` **onClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:498](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L498)

***

### onClickCapture?

> `optional` **onClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L52)

***

### onClose?

> `optional` **onClose**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:499](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L499)

***

### onCommand?

> `optional` **onCommand**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:501](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L501)

***

### onCompositionEnd?

> `optional` **onCompositionEnd**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [../domwise/dist/index.d.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L502)

***

### onCompositionStart?

> `optional` **onCompositionStart**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [../domwise/dist/index.d.ts:503](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L503)

***

### onCompositionUpdate?

> `optional` **onCompositionUpdate**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [../domwise/dist/index.d.ts:504](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L504)

***

### onContentVisibilityAutoStateChange?

> `optional` **onContentVisibilityAutoStateChange**: `EventHandler`\<`T`, `ContentVisibilityAutoStateChangeEvent`\>

Defined in: [../domwise/dist/index.d.ts:505](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L505)

***

### onContextLost?

> `optional` **onContextLost**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:506](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L506)

***

### onContextMenu?

> `optional` **onContextMenu**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L507)

***

### onContextRestored?

> `optional` **onContextRestored**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L508)

***

### onCopy?

> `optional` **onCopy**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:509](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L509)

***

### onCueChange?

> `optional` **onCueChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L510)

***

### onCut?

> `optional` **onCut**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:511](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L511)

***

### onDblClick?

> `optional` **onDblClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:512](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L512)

***

### onDblClickCapture?

> `optional` **onDblClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L53)

***

### onDoubleClick?

> `optional` **onDoubleClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L54)

***

### onDoubleClickCapture?

> `optional` **onDoubleClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L55)

***

### onDrag?

> `optional` **onDrag**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:513](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L513)

***

### onDragEnd?

> `optional` **onDragEnd**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L514)

***

### onDragEnter?

> `optional` **onDragEnter**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:515](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L515)

***

### onDragExit?

> `optional` **onDragExit**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:516](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L516)

***

### onDragLeave?

> `optional` **onDragLeave**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:517](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L517)

***

### onDragOver?

> `optional` **onDragOver**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:518](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L518)

***

### onDragStart?

> `optional` **onDragStart**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L519)

***

### onDrop?

> `optional` **onDrop**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:520](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L520)

***

### onDurationChange?

> `optional` **onDurationChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L521)

***

### onEmptied?

> `optional` **onEmptied**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L522)

***

### onEnded?

> `optional` **onEnded**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:523](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L523)

***

### onError?

> `optional` **onError**: `EventHandler`\<`T`, `ErrorEvent`\>

Defined in: [../domwise/dist/index.d.ts:524](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L524)

***

### onFocus?

> `optional` **onFocus**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L525)

***

### onFocusIn?

> `optional` **onFocusIn**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:526](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L526)

***

### onFocusOut?

> `optional` **onFocusOut**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:527](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L527)

***

### onFormData?

> `optional` **onFormData**: `EventHandler`\<`T`, `FormDataEvent`\>

Defined in: [../domwise/dist/index.d.ts:528](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L528)

***

### onFullscreenChange?

> `optional` **onFullscreenChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:529](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L529)

***

### onFullscreenError?

> `optional` **onFullscreenError**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:530](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L530)

***

### onGotPointerCapture?

> `optional` **onGotPointerCapture**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:531](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L531)

***

### onInput?

> `optional` **onInput**: `InputEventHandler`\<`T`, `InputEvent`\>

Defined in: [../domwise/dist/index.d.ts:532](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L532)

***

### onInvalid?

> `optional` **onInvalid**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:533](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L533)

***

### onKeyDown?

> `optional` **onKeyDown**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:534](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L534)

***

### onKeyPress?

> `optional` **onKeyPress**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:535](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L535)

***

### onKeyUp?

> `optional` **onKeyUp**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:536](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L536)

***

### onLoad?

> `optional` **onLoad**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:537](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L537)

***

### onLoadedData?

> `optional` **onLoadedData**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:538](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L538)

***

### onLoadedMetadata?

> `optional` **onLoadedMetadata**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:539](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L539)

***

### onLoadStart?

> `optional` **onLoadStart**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:540](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L540)

***

### onLostPointerCapture?

> `optional` **onLostPointerCapture**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:541](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L541)

***

### onMouseDown?

> `optional` **onMouseDown**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:542](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L542)

***

### onMouseEnter?

> `optional` **onMouseEnter**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:543](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L543)

***

### onMouseLeave?

> `optional` **onMouseLeave**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:544](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L544)

***

### onMouseMove?

> `optional` **onMouseMove**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:545](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L545)

***

### onMouseOut?

> `optional` **onMouseOut**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:546](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L546)

***

### onMouseOver?

> `optional` **onMouseOver**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:547](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L547)

***

### onMouseUp?

> `optional` **onMouseUp**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:548](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L548)

***

### onPaste?

> `optional` **onPaste**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:549](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L549)

***

### onPause?

> `optional` **onPause**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:550](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L550)

***

### onPlay?

> `optional` **onPlay**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L551)

***

### onPlaying?

> `optional` **onPlaying**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:552](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L552)

***

### onPointerCancel?

> `optional` **onPointerCancel**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:553](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L553)

***

### onPointerDown?

> `optional` **onPointerDown**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:554](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L554)

***

### onPointerEnter?

> `optional` **onPointerEnter**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:555](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L555)

***

### onPointerLeave?

> `optional` **onPointerLeave**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:556](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L556)

***

### onPointerMove?

> `optional` **onPointerMove**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:557](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L557)

***

### onPointerOut?

> `optional` **onPointerOut**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:558](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L558)

***

### onPointerOver?

> `optional` **onPointerOver**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:559](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L559)

***

### onPointerRawUpdate?

> `optional` **onPointerRawUpdate**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:560](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L560)

***

### onPointerUp?

> `optional` **onPointerUp**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:561](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L561)

***

### onProgress?

> `optional` **onProgress**: `EventHandler`\<`T`, `ProgressEvent`\<`EventTarget`\>\>

Defined in: [../domwise/dist/index.d.ts:562](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L562)

***

### onRateChange?

> `optional` **onRateChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:563](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L563)

***

### onReset?

> `optional` **onReset**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:564](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L564)

***

### onResize?

> `optional` **onResize**: `EventHandler`\<`T`, `UIEvent`\>

Defined in: [../domwise/dist/index.d.ts:565](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L565)

***

### onScroll?

> `optional` **onScroll**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L566)

***

### onScrollEnd?

> `optional` **onScrollEnd**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:567](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L567)

***

### onScrollSnapChange?

> `optional` **onScrollSnapChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:568](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L568)

***

### onScrollSnapChanging?

> `optional` **onScrollSnapChanging**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L569)

***

### onSecurityPolicyViolation?

> `optional` **onSecurityPolicyViolation**: `EventHandler`\<`T`, `SecurityPolicyViolationEvent`\>

Defined in: [../domwise/dist/index.d.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L570)

***

### onSeeked?

> `optional` **onSeeked**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:571](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L571)

***

### onSeeking?

> `optional` **onSeeking**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:572](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L572)

***

### onSelect?

> `optional` **onSelect**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:573](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L573)

***

### onSelectionChange?

> `optional` **onSelectionChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L574)

***

### onSelectStart?

> `optional` **onSelectStart**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:575](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L575)

***

### onSlotChange?

> `optional` **onSlotChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:576](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L576)

***

### onStalled?

> `optional` **onStalled**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:577](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L577)

***

### onSubmit?

> `optional` **onSubmit**: `EventHandler`\<`T`, `SubmitEvent`\>

Defined in: [../domwise/dist/index.d.ts:578](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L578)

***

### onSuspend?

> `optional` **onSuspend**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:579](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L579)

***

### onTimeUpdate?

> `optional` **onTimeUpdate**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:580](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L580)

***

### onToggle?

> `optional` **onToggle**: `EventHandler`\<`T`, `ToggleEvent`\>

Defined in: [../domwise/dist/index.d.ts:581](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L581)

***

### onTouchCancel?

> `optional` **onTouchCancel**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:582](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L582)

***

### onTouchEnd?

> `optional` **onTouchEnd**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:583](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L583)

***

### onTouchMove?

> `optional` **onTouchMove**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:584](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L584)

***

### onTouchStart?

> `optional` **onTouchStart**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:585](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L585)

***

### onTransitionCancel?

> `optional` **onTransitionCancel**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:586](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L586)

***

### onTransitionEnd?

> `optional` **onTransitionEnd**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:587](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L587)

***

### onTransitionRun?

> `optional` **onTransitionRun**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:588](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L588)

***

### onTransitionStart?

> `optional` **onTransitionStart**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:589](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L589)

***

### onVolumeChange?

> `optional` **onVolumeChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:590](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L590)

***

### onWaiting?

> `optional` **onWaiting**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:591](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L591)

***

### onWheel?

> `optional` **onWheel**: `EventHandler`\<`T`, `WheelEvent`\>

Defined in: [../domwise/dist/index.d.ts:592](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L592)

***

### part?

> `optional` **part**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:613](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L613)

***

### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L43)

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`ref`](CustomDomAttributes.md#ref)

***

### role?

> `optional` **role**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"dialog"` \| `"article"` \| `"button"` \| `"figure"` \| `"form"` \| `"img"` \| `"link"` \| `"main"` \| `"menu"` \| `"meter"` \| `"option"` \| `"search"` \| `"table"` \| `"switch"` \| `"math"` \| `"marquee"` \| `"menuitem"` \| `"radio"` \| `"checkbox"` \| `"none"` \| `"heading"` \| `"list"` \| `"tree"` \| `"alert"` \| `"grid"` \| `"presentation"` \| `"tooltip"` \| `"row"` \| `"cell"` \| `"tab"` \| `"separator"` \| `"alertdialog"` \| `"application"` \| `"banner"` \| `"columnheader"` \| `"combobox"` \| `"complementary"` \| `"contentinfo"` \| `"definition"` \| `"directory"` \| `"document"` \| `"feed"` \| `"gridcell"` \| `"group"` \| `"listbox"` \| `"listitem"` \| `"log"` \| `"menubar"` \| `"menuitemcheckbox"` \| `"menuitemradio"` \| `"navigation"` \| `"note"` \| `"progressbar"` \| `"radiogroup"` \| `"region"` \| `"rowgroup"` \| `"rowheader"` \| `"scrollbar"` \| `"searchbox"` \| `"slider"` \| `"spinbutton"` \| `"status"` \| `"tablist"` \| `"tabpanel"` \| `"term"` \| `"textbox"` \| `"timer"` \| `"toolbar"` \| `"treegrid"` \| `"treeitem"`\>

Defined in: [../domwise/dist/index.d.ts:453](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L453)

***

### slot?

> `optional` **slot**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:614](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L614)

***

### style?

> `optional` **style**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false` \| [`StyleProperties`](../type-aliases/StyleProperties.md)\>

Defined in: [../domwise/dist/index.d.ts:615](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L615)

***

### tabindex?

> `optional` **tabindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:616](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L616)

***

### tabIndex?

> `optional` **tabIndex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L50)

***

### textContent?

> `optional` **textContent**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number`\>

Defined in: [../domwise/dist/index.d.ts:604](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L604)
