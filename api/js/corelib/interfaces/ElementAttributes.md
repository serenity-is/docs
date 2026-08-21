[@serenity-is/corelib](../README.md) / ElementAttributes

# Interface: ElementAttributes\<T\>

Defined in: [../domwise/dist/index.d.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L160)

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

Defined in: [../domwise/dist/index.d.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L297)

Identifies the currently active element when DOM focus is on a composite widget, textbox,
group, or application.

***

### aria-atomic?

> `optional` **aria-atomic**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L302)

Indicates whether assistive technologies will present all, or only parts of, the changed
region based on the change notifications defined by the aria-relevant attribute.

***

### aria-autocomplete?

> `optional` **aria-autocomplete**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"none"` \| `"list"` \| `"inline"` \| `"both"`\>

Defined in: [../domwise/dist/index.d.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L329)

Indicates whether inputting text could trigger display of one or more predictions of the
user's intended value for an input and specifies how predictions would be presented if they
are made.

***

### aria-braillelabel?

> `optional` **aria-braillelabel**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L309)

Similar to the global aria-label. Defines a string value that labels the current element,
which is intended to be converted into Braille.

#### See

aria-label.

***

### aria-brailleroledescription?

> `optional` **aria-brailleroledescription**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L323)

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

Defined in: [../domwise/dist/index.d.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L334)

Indicates an element is being modified and that assistive technologies MAY want to wait until
the modifications are complete before exposing them to the user.

***

### aria-checked?

> `optional` **aria-checked**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean` \| `"mixed"`\>

Defined in: [../domwise/dist/index.d.ts:340](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L340)

Indicates the current "checked" state of checkboxes, radio buttons, and other widgets.

#### See

 - aria-pressed
 - aria-selected.

***

### aria-colcount?

> `optional` **aria-colcount**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:346](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L346)

Defines the total number of columns in a table, grid, or treegrid.

#### See

aria-colindex.

***

### aria-colindex?

> `optional` **aria-colindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L353)

Defines an element's column index or position with respect to the total number of columns
within a table, grid, or treegrid.

#### See

 - aria-colcount
 - aria-colspan.

***

### aria-colindextext?

> `optional` **aria-colindextext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:355](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L355)

Defines a human-readable text alternative of the numeric aria-colindex.

***

### aria-colspan?

> `optional` **aria-colspan**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:362](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L362)

Defines the number of columns spanned by a cell or gridcell within a table, grid, or
treegrid.

#### See

 - aria-colindex
 - aria-rowspan.

***

### aria-controls?

> `optional` **aria-controls**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:369](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L369)

Identifies the element (or elements) whose contents or presence are controlled by the current
element.

#### See

aria-owns.

***

### aria-current?

> `optional` **aria-current**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"time"` \| `EnumeratedPseudoBoolean` \| `"page"` \| `"step"` \| `"date"` \| `"location"`\>

Defined in: [../domwise/dist/index.d.ts:374](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L374)

Indicates the element that represents the current item within a container or set of related
elements.

***

### aria-describedby?

> `optional` **aria-describedby**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:380](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L380)

Identifies the element (or elements) that describes the object.

#### See

aria-labelledby

***

### aria-description?

> `optional` **aria-description**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L386)

Defines a string value that describes or annotates the current element.

#### See

aria-describedby

***

### aria-details?

> `optional` **aria-details**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:392](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L392)

Identifies the element that provides a detailed, extended description for the object.

#### See

aria-describedby.

***

### aria-disabled?

> `optional` **aria-disabled**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:399](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L399)

Indicates that the element is perceivable but disabled, so it is not editable or otherwise
operable.

#### See

 - aria-hidden
 - aria-readonly.

***

### ~~aria-dropeffect?~~

> `optional` **aria-dropeffect**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"link"` \| `"copy"` \| `"none"` \| `"move"` \| `"execute"` \| `"popup"`\>

Defined in: [../domwise/dist/index.d.ts:406](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L406)

Indicates what functions can be performed when a dragged object is released on the drop
target.

#### Deprecated

In ARIA 1.1

***

### aria-errormessage?

> `optional` **aria-errormessage**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:412](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L412)

Identifies the element that provides an error message for the object.

#### See

 - aria-invalid
 - aria-describedby.

***

### aria-expanded?

> `optional` **aria-expanded**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L417)

Indicates whether the element, or another grouping element it controls, is currently expanded
or collapsed.

***

### aria-flowto?

> `optional` **aria-flowto**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:423](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L423)

Identifies the next element (or elements) in an alternate reading order of content which, at
the user's discretion, allows assistive technology to override the general default of reading
in document source order.

***

### ~~aria-grabbed?~~

> `optional` **aria-grabbed**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:429](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L429)

Indicates an element's "grabbed" state in a drag-and-drop operation.

#### Deprecated

In ARIA 1.1

***

### aria-haspopup?

> `optional` **aria-haspopup**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"dialog"` \| `"menu"` \| `"tree"` \| `EnumeratedPseudoBoolean` \| `"grid"` \| `"listbox"`\>

Defined in: [../domwise/dist/index.d.ts:434](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L434)

Indicates the availability and type of interactive popup element, such as menu or dialog,
that can be triggered by an element.

***

### aria-hidden?

> `optional` **aria-hidden**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:440](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L440)

Indicates whether the element is exposed to an accessibility API.

#### See

aria-disabled.

***

### aria-invalid?

> `optional` **aria-invalid**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean` \| `"grammar"` \| `"spelling"`\>

Defined in: [../domwise/dist/index.d.ts:446](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L446)

Indicates the entered value does not conform to the format expected by the application.

#### See

aria-errormessage.

***

### aria-keyshortcuts?

> `optional` **aria-keyshortcuts**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:451](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L451)

Indicates keyboard shortcuts that an author has implemented to activate or give focus to an
element.

***

### aria-label?

> `optional` **aria-label**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:457](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L457)

Defines a string value that labels the current element.

#### See

aria-labelledby.

***

### aria-labelledby?

> `optional` **aria-labelledby**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:463](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L463)

Identifies the element (or elements) that labels the current element.

#### See

aria-describedby.

***

### aria-level?

> `optional` **aria-level**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:465](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L465)

Defines the hierarchical level of an element within a structure.

***

### aria-live?

> `optional` **aria-live**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"polite"` \| `"assertive"` \| `"off"`\>

Defined in: [../domwise/dist/index.d.ts:470](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L470)

Indicates that an element will be updated, and describes the types of updates the user
agents, assistive technologies, and user can expect from the live region.

***

### aria-modal?

> `optional` **aria-modal**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:472](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L472)

Indicates whether an element is modal when displayed.

***

### aria-multiline?

> `optional` **aria-multiline**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:474](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L474)

Indicates whether a text box accepts multiple lines of input or only a single line.

***

### aria-multiselectable?

> `optional` **aria-multiselectable**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:479](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L479)

Indicates that the user may select more than one item from the current selectable
descendants.

***

### aria-orientation?

> `optional` **aria-orientation**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"horizontal"` \| `"vertical"`\>

Defined in: [../domwise/dist/index.d.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L481)

Indicates whether the element's orientation is horizontal, vertical, or unknown/ambiguous.

***

### aria-owns?

> `optional` **aria-owns**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:489](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L489)

Identifies an element (or elements) in order to define a visual, functional, or contextual
parent/child relationship between DOM elements where the DOM hierarchy cannot be used to
represent the relationship.

#### See

aria-controls.

***

### aria-placeholder?

> `optional` **aria-placeholder**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L495)

Defines a short hint (a word or short phrase) intended to aid the user with data entry when
the control has no value. A hint could be a sample value or a brief description of the
expected format.

***

### aria-posinset?

> `optional` **aria-posinset**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L502)

Defines an element's number or position in the current set of listitems or treeitems. Not
required if all elements in the set are present in the DOM.

#### See

aria-setsize.

***

### aria-pressed?

> `optional` **aria-pressed**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean` \| `"mixed"`\>

Defined in: [../domwise/dist/index.d.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L508)

Indicates the current "pressed" state of toggle buttons.

#### See

 - aria-checked
 - aria-selected.

***

### aria-readonly?

> `optional` **aria-readonly**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L514)

Indicates that the element is not editable, but is otherwise operable.

#### See

aria-disabled.

***

### aria-relevant?

> `optional` **aria-relevant**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"text"` \| `"all"` \| `"additions"` \| `"additions removals"` \| `"additions text"` \| `"removals"` \| `"removals additions"` \| `"removals text"` \| `"text additions"` \| `"text removals"`\>

Defined in: [../domwise/dist/index.d.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L521)

Indicates what notifications the user agent will trigger when the accessibility tree within a
live region is modified.

#### See

aria-atomic.

***

### aria-required?

> `optional` **aria-required**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:523](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L523)

Indicates that user input is required on the element before a form may be submitted.

***

### aria-roledescription?

> `optional` **aria-roledescription**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L525)

Defines a human-readable, author-localized description for the role of an element.

***

### aria-rowcount?

> `optional` **aria-rowcount**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:531](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L531)

Defines the total number of rows in a table, grid, or treegrid.

#### See

aria-rowindex.

***

### aria-rowindex?

> `optional` **aria-rowindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:538](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L538)

Defines an element's row index or position with respect to the total number of rows within a
table, grid, or treegrid.

#### See

 - aria-rowcount
 - aria-rowspan.

***

### aria-rowindextext?

> `optional` **aria-rowindextext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:540](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L540)

Defines a human-readable text alternative of aria-rowindex.

***

### aria-rowspan?

> `optional` **aria-rowspan**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:546](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L546)

Defines the number of rows spanned by a cell or gridcell within a table, grid, or treegrid.

#### See

 - aria-rowindex
 - aria-colspan.

***

### aria-selected?

> `optional` **aria-selected**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:552](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L552)

Indicates the current "selected" state of various widgets.

#### See

 - aria-checked
 - aria-pressed.

***

### aria-setsize?

> `optional` **aria-setsize**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:559](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L559)

Defines the number of items in the current set of listitems or treeitems. Not required if all
elements in the set are present in the DOM.

#### See

aria-posinset.

***

### aria-sort?

> `optional` **aria-sort**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"none"` \| `"descending"` \| `"ascending"` \| `"other"`\>

Defined in: [../domwise/dist/index.d.ts:561](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L561)

Indicates if items in a table or grid are sorted in ascending or descending order.

***

### aria-valuemax?

> `optional` **aria-valuemax**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:563](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L563)

Defines the maximum allowed value for a range widget.

***

### aria-valuemin?

> `optional` **aria-valuemin**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:565](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L565)

Defines the minimum allowed value for a range widget.

***

### aria-valuenow?

> `optional` **aria-valuenow**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:571](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L571)

Defines the current value for a range widget.

#### See

aria-valuetext.

***

### aria-valuetext?

> `optional` **aria-valuetext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:573](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L573)

Defines the human readable text alternative of aria-valuenow for a range widget.

***

### autofocus?

> `optional` **autofocus**: [`PropValue`](../type-aliases/PropValue.md)\<`BooleanAttribute`\>

Defined in: [../domwise/dist/index.d.ts:727](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L727)

***

### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [../domwise/dist/index.d.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L148)

Child nodes / JSX children for the element.

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`children`](CustomDomAttributes.md#children)

***

### class?

> `optional` **class**: [`PropValue`](../type-aliases/PropValue.md)\<[`ClassNames`](../type-aliases/ClassNames.md)\> \| \{\[`key`: `string`\]: [`PropValue`](../type-aliases/PropValue.md)\<`boolean`\>; \}

Defined in: [../domwise/dist/index.d.ts:728](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L728)

***

### className?

> `optional` **className**: [`PropValue`](../type-aliases/PropValue.md)\<[`ClassNames`](../type-aliases/ClassNames.md)\> \| \{\[`key`: `string`\]: [`PropValue`](../type-aliases/PropValue.md)\<`boolean`\>; \}

Defined in: [../domwise/dist/index.d.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L161)

***

### dangerouslySetInnerHTML?

> `optional` **dangerouslySetInnerHTML**: `object`

Defined in: [../domwise/dist/index.d.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L150)

Raw HTML to assign via `innerHTML`. Use with caution — content is not escaped.

#### \_\_html

> **\_\_html**: `string`

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`dangerouslySetInnerHTML`](CustomDomAttributes.md#dangerouslysetinnerhtml)

***

### elementtiming?

> `optional` **elementtiming**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:731](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L731)

***

### id?

> `optional` **id**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:732](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L732)

***

### namespaceURI?

> `optional` **namespaceURI**: `string`

Defined in: [../domwise/dist/index.d.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L163)

***

### nonce?

> `optional` **nonce**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:733](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L733)

***

### on?

> `optional` **on**: `Record`\<`string`, `Function`\>

Defined in: [../domwise/dist/index.d.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L156)

Compatibility event map for `on*` handlers (jsx-dom / React style).

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`on`](CustomDomAttributes.md#on)

***

### onAbort?

> `optional` **onAbort**: `EventHandler`\<`T`, `UIEvent`\>

Defined in: [../domwise/dist/index.d.ts:601](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L601)

***

### onAnimationCancel?

> `optional` **onAnimationCancel**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:602](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L602)

***

### onAnimationEnd?

> `optional` **onAnimationEnd**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:603](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L603)

***

### onAnimationIteration?

> `optional` **onAnimationIteration**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:604](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L604)

***

### onAnimationStart?

> `optional` **onAnimationStart**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:605](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L605)

***

### onAuxClick?

> `optional` **onAuxClick**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:606](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L606)

***

### onBeforeCopy?

> `optional` **onBeforeCopy**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:607](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L607)

***

### onBeforeCut?

> `optional` **onBeforeCut**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:608](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L608)

***

### onBeforeInput?

> `optional` **onBeforeInput**: `InputEventHandler`\<`T`, `InputEvent`\>

Defined in: [../domwise/dist/index.d.ts:609](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L609)

***

### onBeforeMatch?

> `optional` **onBeforeMatch**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:610](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L610)

***

### onBeforePaste?

> `optional` **onBeforePaste**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:611](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L611)

***

### onBeforeToggle?

> `optional` **onBeforeToggle**: `EventHandler`\<`T`, `ToggleEvent`\>

Defined in: [../domwise/dist/index.d.ts:612](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L612)

***

### onBeforeXRSelect?

> `optional` **onBeforeXRSelect**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:613](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L613)

***

### onBlur?

> `optional` **onBlur**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:614](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L614)

***

### onCancel?

> `optional` **onCancel**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:615](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L615)

***

### onCanPlay?

> `optional` **onCanPlay**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:616](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L616)

***

### onCanPlayThrough?

> `optional` **onCanPlayThrough**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:617](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L617)

***

### onCapture?

> `optional` **onCapture**: `Record`\<`string`, `Function`\>

Defined in: [../domwise/dist/index.d.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L158)

Compatibility event map for capture-phase handlers.

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`onCapture`](CustomDomAttributes.md#oncapture)

***

### onChange?

> `optional` **onChange**: `ChangeEventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:618](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L618)

***

### onClick?

> `optional` **onClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:619](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L619)

***

### onClickCapture?

> `optional` **onClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L164)

***

### onClose?

> `optional` **onClose**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:620](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L620)

***

### onCommand?

> `optional` **onCommand**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:622](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L622)

***

### onCompositionEnd?

> `optional` **onCompositionEnd**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [../domwise/dist/index.d.ts:623](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L623)

***

### onCompositionStart?

> `optional` **onCompositionStart**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [../domwise/dist/index.d.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L624)

***

### onCompositionUpdate?

> `optional` **onCompositionUpdate**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [../domwise/dist/index.d.ts:625](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L625)

***

### onContentVisibilityAutoStateChange?

> `optional` **onContentVisibilityAutoStateChange**: `EventHandler`\<`T`, `ContentVisibilityAutoStateChangeEvent`\>

Defined in: [../domwise/dist/index.d.ts:626](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L626)

***

### onContextLost?

> `optional` **onContextLost**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L627)

***

### onContextMenu?

> `optional` **onContextMenu**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L628)

***

### onContextRestored?

> `optional` **onContextRestored**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:629](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L629)

***

### onCopy?

> `optional` **onCopy**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:630](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L630)

***

### onCueChange?

> `optional` **onCueChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:631](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L631)

***

### onCut?

> `optional` **onCut**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:632](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L632)

***

### onDblClick?

> `optional` **onDblClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:633](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L633)

***

### onDblClickCapture?

> `optional` **onDblClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L165)

***

### onDoubleClick?

> `optional` **onDoubleClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L166)

***

### onDoubleClickCapture?

> `optional` **onDoubleClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L167)

***

### onDrag?

> `optional` **onDrag**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:634](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L634)

***

### onDragEnd?

> `optional` **onDragEnd**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:635](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L635)

***

### onDragEnter?

> `optional` **onDragEnter**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L636)

***

### onDragExit?

> `optional` **onDragExit**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:637](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L637)

***

### onDragLeave?

> `optional` **onDragLeave**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:638](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L638)

***

### onDragOver?

> `optional` **onDragOver**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:639](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L639)

***

### onDragStart?

> `optional` **onDragStart**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:640](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L640)

***

### onDrop?

> `optional` **onDrop**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:641](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L641)

***

### onDurationChange?

> `optional` **onDurationChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:642](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L642)

***

### onEmptied?

> `optional` **onEmptied**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:643](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L643)

***

### onEnded?

> `optional` **onEnded**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L644)

***

### onError?

> `optional` **onError**: `EventHandler`\<`T`, `ErrorEvent`\>

Defined in: [../domwise/dist/index.d.ts:645](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L645)

***

### onFocus?

> `optional` **onFocus**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L646)

***

### onFocusIn?

> `optional` **onFocusIn**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:647](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L647)

***

### onFocusOut?

> `optional` **onFocusOut**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L648)

***

### onFormData?

> `optional` **onFormData**: `EventHandler`\<`T`, `FormDataEvent`\>

Defined in: [../domwise/dist/index.d.ts:649](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L649)

***

### onFullscreenChange?

> `optional` **onFullscreenChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:650](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L650)

***

### onFullscreenError?

> `optional` **onFullscreenError**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:651](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L651)

***

### onGotPointerCapture?

> `optional` **onGotPointerCapture**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:652](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L652)

***

### onInput?

> `optional` **onInput**: `InputEventHandler`\<`T`, `InputEvent`\>

Defined in: [../domwise/dist/index.d.ts:653](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L653)

***

### onInvalid?

> `optional` **onInvalid**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:654](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L654)

***

### onKeyDown?

> `optional` **onKeyDown**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:655](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L655)

***

### onKeyPress?

> `optional` **onKeyPress**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:656](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L656)

***

### onKeyUp?

> `optional` **onKeyUp**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:657](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L657)

***

### onLoad?

> `optional` **onLoad**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:658](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L658)

***

### onLoadedData?

> `optional` **onLoadedData**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:659](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L659)

***

### onLoadedMetadata?

> `optional` **onLoadedMetadata**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L660)

***

### onLoadStart?

> `optional` **onLoadStart**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:661](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L661)

***

### onLostPointerCapture?

> `optional` **onLostPointerCapture**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L662)

***

### onMouseDown?

> `optional` **onMouseDown**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:663](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L663)

***

### onMouseEnter?

> `optional` **onMouseEnter**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L664)

***

### onMouseLeave?

> `optional` **onMouseLeave**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:665](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L665)

***

### onMouseMove?

> `optional` **onMouseMove**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:666](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L666)

***

### onMouseOut?

> `optional` **onMouseOut**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:667](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L667)

***

### onMouseOver?

> `optional` **onMouseOver**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L668)

***

### onMouseUp?

> `optional` **onMouseUp**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:669](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L669)

***

### onPaste?

> `optional` **onPaste**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:670](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L670)

***

### onPause?

> `optional` **onPause**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:671](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L671)

***

### onPlay?

> `optional` **onPlay**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L672)

***

### onPlaying?

> `optional` **onPlaying**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:673](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L673)

***

### onPointerCancel?

> `optional` **onPointerCancel**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:674](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L674)

***

### onPointerDown?

> `optional` **onPointerDown**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:675](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L675)

***

### onPointerEnter?

> `optional` **onPointerEnter**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:676](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L676)

***

### onPointerLeave?

> `optional` **onPointerLeave**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:677](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L677)

***

### onPointerMove?

> `optional` **onPointerMove**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:678](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L678)

***

### onPointerOut?

> `optional` **onPointerOut**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:679](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L679)

***

### onPointerOver?

> `optional` **onPointerOver**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L680)

***

### onPointerRawUpdate?

> `optional` **onPointerRawUpdate**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:681](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L681)

***

### onPointerUp?

> `optional` **onPointerUp**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:682](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L682)

***

### onProgress?

> `optional` **onProgress**: `EventHandler`\<`T`, `ProgressEvent`\<`EventTarget`\>\>

Defined in: [../domwise/dist/index.d.ts:683](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L683)

***

### onRateChange?

> `optional` **onRateChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:684](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L684)

***

### onReset?

> `optional` **onReset**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:685](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L685)

***

### onResize?

> `optional` **onResize**: `EventHandler`\<`T`, `UIEvent`\>

Defined in: [../domwise/dist/index.d.ts:686](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L686)

***

### onScroll?

> `optional` **onScroll**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:687](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L687)

***

### onScrollEnd?

> `optional` **onScrollEnd**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:688](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L688)

***

### onScrollSnapChange?

> `optional` **onScrollSnapChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:689](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L689)

***

### onScrollSnapChanging?

> `optional` **onScrollSnapChanging**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:690](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L690)

***

### onSecurityPolicyViolation?

> `optional` **onSecurityPolicyViolation**: `EventHandler`\<`T`, `SecurityPolicyViolationEvent`\>

Defined in: [../domwise/dist/index.d.ts:691](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L691)

***

### onSeeked?

> `optional` **onSeeked**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:692](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L692)

***

### onSeeking?

> `optional` **onSeeking**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:693](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L693)

***

### onSelect?

> `optional` **onSelect**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:694](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L694)

***

### onSelectionChange?

> `optional` **onSelectionChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:695](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L695)

***

### onSelectStart?

> `optional` **onSelectStart**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:696](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L696)

***

### onSlotChange?

> `optional` **onSlotChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:697](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L697)

***

### onStalled?

> `optional` **onStalled**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L698)

***

### onSubmit?

> `optional` **onSubmit**: `EventHandler`\<`T`, `SubmitEvent`\>

Defined in: [../domwise/dist/index.d.ts:699](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L699)

***

### onSuspend?

> `optional` **onSuspend**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:700](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L700)

***

### onTimeUpdate?

> `optional` **onTimeUpdate**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L701)

***

### onToggle?

> `optional` **onToggle**: `EventHandler`\<`T`, `ToggleEvent`\>

Defined in: [../domwise/dist/index.d.ts:702](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L702)

***

### onTouchCancel?

> `optional` **onTouchCancel**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:703](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L703)

***

### onTouchEnd?

> `optional` **onTouchEnd**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:704](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L704)

***

### onTouchMove?

> `optional` **onTouchMove**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:705](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L705)

***

### onTouchStart?

> `optional` **onTouchStart**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:706](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L706)

***

### onTransitionCancel?

> `optional` **onTransitionCancel**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:707](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L707)

***

### onTransitionEnd?

> `optional` **onTransitionEnd**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:708](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L708)

***

### onTransitionRun?

> `optional` **onTransitionRun**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:709](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L709)

***

### onTransitionStart?

> `optional` **onTransitionStart**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:710](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L710)

***

### onVolumeChange?

> `optional` **onVolumeChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:711](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L711)

***

### onWaiting?

> `optional` **onWaiting**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:712](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L712)

***

### onWheel?

> `optional` **onWheel**: `EventHandler`\<`T`, `WheelEvent`\>

Defined in: [../domwise/dist/index.d.ts:713](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L713)

***

### part?

> `optional` **part**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:734](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L734)

***

### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L154)

Ref object or callback that receives the created DOM node.

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`ref`](CustomDomAttributes.md#ref)

***

### role?

> `optional` **role**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"dialog"` \| `"article"` \| `"button"` \| `"figure"` \| `"form"` \| `"img"` \| `"link"` \| `"main"` \| `"menu"` \| `"meter"` \| `"option"` \| `"search"` \| `"table"` \| `"switch"` \| `"math"` \| `"marquee"` \| `"menuitem"` \| `"radio"` \| `"checkbox"` \| `"none"` \| `"heading"` \| `"list"` \| `"tree"` \| `"alert"` \| `"grid"` \| `"presentation"` \| `"alertdialog"` \| `"application"` \| `"banner"` \| `"cell"` \| `"columnheader"` \| `"combobox"` \| `"complementary"` \| `"contentinfo"` \| `"definition"` \| `"directory"` \| `"document"` \| `"feed"` \| `"gridcell"` \| `"group"` \| `"listbox"` \| `"listitem"` \| `"log"` \| `"menubar"` \| `"menuitemcheckbox"` \| `"menuitemradio"` \| `"navigation"` \| `"note"` \| `"progressbar"` \| `"radiogroup"` \| `"region"` \| `"row"` \| `"rowgroup"` \| `"rowheader"` \| `"scrollbar"` \| `"searchbox"` \| `"separator"` \| `"slider"` \| `"spinbutton"` \| `"status"` \| `"tab"` \| `"tablist"` \| `"tabpanel"` \| `"term"` \| `"textbox"` \| `"timer"` \| `"toolbar"` \| `"tooltip"` \| `"treegrid"` \| `"treeitem"`\>

Defined in: [../domwise/dist/index.d.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L574)

***

### slot?

> `optional` **slot**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:735](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L735)

***

### style?

> `optional` **style**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false` \| [`StyleProperties`](../type-aliases/StyleProperties.md)\>

Defined in: [../domwise/dist/index.d.ts:736](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L736)

***

### tabindex?

> `optional` **tabindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:737](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L737)

***

### tabIndex?

> `optional` **tabIndex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L162)

***

### textContent?

> `optional` **textContent**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number`\>

Defined in: [../domwise/dist/index.d.ts:725](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L725)
