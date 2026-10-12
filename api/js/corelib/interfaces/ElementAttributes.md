[@serenity-is/corelib](../README.md) / ElementAttributes

# Interface: ElementAttributes\<T\>

Defined in: [../domwise/dist/index.d.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L165)

Global `Element` + `Node` interface keys, shared by all tags regardless of their namespace:

1. That's `keys` that are defined BY ALL `HTMLElement/SVGElement/MathMLElement` interfaces.
2. Includes `keys` defined by `Element` and `Node` interfaces.

## Extends

- `CapturePhaseEventHandlers`\<`T`\>.[`CustomDomAttributes`](CustomDomAttributes.md)\<`T`\>.`DirectiveAttributes`.`DirectiveFunctionAttributes`\<`T`\>.`PropAttributes`.`OnAttributes`\<`T`\>.`EventHandlersElement`\<`T`\>.`AriaAttributes`

## Type Parameters

### T

`T`

## Properties

### aria-activedescendant?

> `optional` **aria-activedescendant**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L309)

Identifies the currently active element when DOM focus is on a composite widget, textbox,
group, or application.

***

### aria-atomic?

> `optional` **aria-atomic**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:314](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L314)

Indicates whether assistive technologies will present all, or only parts of, the changed
region based on the change notifications defined by the aria-relevant attribute.

***

### aria-autocomplete?

> `optional` **aria-autocomplete**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"none"` \| `"list"` \| `"inline"` \| `"both"`\>

Defined in: [../domwise/dist/index.d.ts:341](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L341)

Indicates whether inputting text could trigger display of one or more predictions of the
user's intended value for an input and specifies how predictions would be presented if they
are made.

***

### aria-braillelabel?

> `optional` **aria-braillelabel**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:321](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L321)

Similar to the global aria-label. Defines a string value that labels the current element,
which is intended to be converted into Braille.

#### See

aria-label.

***

### aria-brailleroledescription?

> `optional` **aria-brailleroledescription**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L335)

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

Defined in: [../domwise/dist/index.d.ts:346](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L346)

Indicates an element is being modified and that assistive technologies MAY want to wait until
the modifications are complete before exposing them to the user.

***

### aria-checked?

> `optional` **aria-checked**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean` \| `"mixed"`\>

Defined in: [../domwise/dist/index.d.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L352)

Indicates the current "checked" state of checkboxes, radio buttons, and other widgets.

#### See

 - aria-pressed
 - aria-selected.

***

### aria-colcount?

> `optional` **aria-colcount**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:358](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L358)

Defines the total number of columns in a table, grid, or treegrid.

#### See

aria-colindex.

***

### aria-colindex?

> `optional` **aria-colindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L365)

Defines an element's column index or position with respect to the total number of columns
within a table, grid, or treegrid.

#### See

 - aria-colcount
 - aria-colspan.

***

### aria-colindextext?

> `optional` **aria-colindextext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L367)

Defines a human-readable text alternative of the numeric aria-colindex.

***

### aria-colspan?

> `optional` **aria-colspan**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:374](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L374)

Defines the number of columns spanned by a cell or gridcell within a table, grid, or
treegrid.

#### See

 - aria-colindex
 - aria-rowspan.

***

### aria-controls?

> `optional` **aria-controls**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:381](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L381)

Identifies the element (or elements) whose contents or presence are controlled by the current
element.

#### See

aria-owns.

***

### aria-current?

> `optional` **aria-current**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"time"` \| `EnumeratedPseudoBoolean` \| `"page"` \| `"step"` \| `"date"` \| `"location"`\>

Defined in: [../domwise/dist/index.d.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L386)

Indicates the element that represents the current item within a container or set of related
elements.

***

### aria-describedby?

> `optional` **aria-describedby**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:392](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L392)

Identifies the element (or elements) that describes the object.

#### See

aria-labelledby

***

### aria-description?

> `optional` **aria-description**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:398](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L398)

Defines a string value that describes or annotates the current element.

#### See

aria-describedby

***

### aria-details?

> `optional` **aria-details**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:404](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L404)

Identifies the element that provides a detailed, extended description for the object.

#### See

aria-describedby.

***

### aria-disabled?

> `optional` **aria-disabled**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:411](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L411)

Indicates that the element is perceivable but disabled, so it is not editable or otherwise
operable.

#### See

 - aria-hidden
 - aria-readonly.

***

### ~~aria-dropeffect?~~

> `optional` **aria-dropeffect**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"link"` \| `"copy"` \| `"none"` \| `"move"` \| `"execute"` \| `"popup"`\>

Defined in: [../domwise/dist/index.d.ts:418](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L418)

Indicates what functions can be performed when a dragged object is released on the drop
target.

#### Deprecated

In ARIA 1.1

***

### aria-errormessage?

> `optional` **aria-errormessage**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:424](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L424)

Identifies the element that provides an error message for the object.

#### See

 - aria-invalid
 - aria-describedby.

***

### aria-expanded?

> `optional` **aria-expanded**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:429](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L429)

Indicates whether the element, or another grouping element it controls, is currently expanded
or collapsed.

***

### aria-flowto?

> `optional` **aria-flowto**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:435](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L435)

Identifies the next element (or elements) in an alternate reading order of content which, at
the user's discretion, allows assistive technology to override the general default of reading
in document source order.

***

### ~~aria-grabbed?~~

> `optional` **aria-grabbed**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:441](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L441)

Indicates an element's "grabbed" state in a drag-and-drop operation.

#### Deprecated

In ARIA 1.1

***

### aria-haspopup?

> `optional` **aria-haspopup**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"dialog"` \| `"menu"` \| `"tree"` \| `EnumeratedPseudoBoolean` \| `"grid"` \| `"listbox"`\>

Defined in: [../domwise/dist/index.d.ts:446](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L446)

Indicates the availability and type of interactive popup element, such as menu or dialog,
that can be triggered by an element.

***

### aria-hidden?

> `optional` **aria-hidden**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:452](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L452)

Indicates whether the element is exposed to an accessibility API.

#### See

aria-disabled.

***

### aria-invalid?

> `optional` **aria-invalid**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean` \| `"grammar"` \| `"spelling"`\>

Defined in: [../domwise/dist/index.d.ts:458](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L458)

Indicates the entered value does not conform to the format expected by the application.

#### See

aria-errormessage.

***

### aria-keyshortcuts?

> `optional` **aria-keyshortcuts**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:463](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L463)

Indicates keyboard shortcuts that an author has implemented to activate or give focus to an
element.

***

### aria-label?

> `optional` **aria-label**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:469](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L469)

Defines a string value that labels the current element.

#### See

aria-labelledby.

***

### aria-labelledby?

> `optional` **aria-labelledby**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:475](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L475)

Identifies the element (or elements) that labels the current element.

#### See

aria-describedby.

***

### aria-level?

> `optional` **aria-level**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:477](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L477)

Defines the hierarchical level of an element within a structure.

***

### aria-live?

> `optional` **aria-live**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"polite"` \| `"assertive"` \| `"off"`\>

Defined in: [../domwise/dist/index.d.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L482)

Indicates that an element will be updated, and describes the types of updates the user
agents, assistive technologies, and user can expect from the live region.

***

### aria-modal?

> `optional` **aria-modal**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:484](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L484)

Indicates whether an element is modal when displayed.

***

### aria-multiline?

> `optional` **aria-multiline**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:486](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L486)

Indicates whether a text box accepts multiple lines of input or only a single line.

***

### aria-multiselectable?

> `optional` **aria-multiselectable**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:491](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L491)

Indicates that the user may select more than one item from the current selectable
descendants.

***

### aria-orientation?

> `optional` **aria-orientation**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"horizontal"` \| `"vertical"`\>

Defined in: [../domwise/dist/index.d.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L493)

Indicates whether the element's orientation is horizontal, vertical, or unknown/ambiguous.

***

### aria-owns?

> `optional` **aria-owns**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:501](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L501)

Identifies an element (or elements) in order to define a visual, functional, or contextual
parent/child relationship between DOM elements where the DOM hierarchy cannot be used to
represent the relationship.

#### See

aria-controls.

***

### aria-placeholder?

> `optional` **aria-placeholder**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L507)

Defines a short hint (a word or short phrase) intended to aid the user with data entry when
the control has no value. A hint could be a sample value or a brief description of the
expected format.

***

### aria-posinset?

> `optional` **aria-posinset**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L514)

Defines an element's number or position in the current set of listitems or treeitems. Not
required if all elements in the set are present in the DOM.

#### See

aria-setsize.

***

### aria-pressed?

> `optional` **aria-pressed**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean` \| `"mixed"`\>

Defined in: [../domwise/dist/index.d.ts:520](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L520)

Indicates the current "pressed" state of toggle buttons.

#### See

 - aria-checked
 - aria-selected.

***

### aria-readonly?

> `optional` **aria-readonly**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:526](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L526)

Indicates that the element is not editable, but is otherwise operable.

#### See

aria-disabled.

***

### aria-relevant?

> `optional` **aria-relevant**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"text"` \| `"all"` \| `"additions"` \| `"additions removals"` \| `"additions text"` \| `"removals"` \| `"removals additions"` \| `"removals text"` \| `"text additions"` \| `"text removals"`\>

Defined in: [../domwise/dist/index.d.ts:533](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L533)

Indicates what notifications the user agent will trigger when the accessibility tree within a
live region is modified.

#### See

aria-atomic.

***

### aria-required?

> `optional` **aria-required**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:535](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L535)

Indicates that user input is required on the element before a form may be submitted.

***

### aria-roledescription?

> `optional` **aria-roledescription**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:537](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L537)

Defines a human-readable, author-localized description for the role of an element.

***

### aria-rowcount?

> `optional` **aria-rowcount**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:543](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L543)

Defines the total number of rows in a table, grid, or treegrid.

#### See

aria-rowindex.

***

### aria-rowindex?

> `optional` **aria-rowindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:550](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L550)

Defines an element's row index or position with respect to the total number of rows within a
table, grid, or treegrid.

#### See

 - aria-rowcount
 - aria-rowspan.

***

### aria-rowindextext?

> `optional` **aria-rowindextext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:552](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L552)

Defines a human-readable text alternative of aria-rowindex.

***

### aria-rowspan?

> `optional` **aria-rowspan**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:558](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L558)

Defines the number of rows spanned by a cell or gridcell within a table, grid, or treegrid.

#### See

 - aria-rowindex
 - aria-colspan.

***

### aria-selected?

> `optional` **aria-selected**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `EnumeratedPseudoBoolean`\>

Defined in: [../domwise/dist/index.d.ts:564](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L564)

Indicates the current "selected" state of various widgets.

#### See

 - aria-checked
 - aria-pressed.

***

### aria-setsize?

> `optional` **aria-setsize**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:571](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L571)

Defines the number of items in the current set of listitems or treeitems. Not required if all
elements in the set are present in the DOM.

#### See

aria-posinset.

***

### aria-sort?

> `optional` **aria-sort**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"none"` \| `"descending"` \| `"ascending"` \| `"other"`\>

Defined in: [../domwise/dist/index.d.ts:573](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L573)

Indicates if items in a table or grid are sorted in ascending or descending order.

***

### aria-valuemax?

> `optional` **aria-valuemax**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:575](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L575)

Defines the maximum allowed value for a range widget.

***

### aria-valuemin?

> `optional` **aria-valuemin**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:577](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L577)

Defines the minimum allowed value for a range widget.

***

### aria-valuenow?

> `optional` **aria-valuenow**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:583](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L583)

Defines the current value for a range widget.

#### See

aria-valuetext.

***

### aria-valuetext?

> `optional` **aria-valuetext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:585](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L585)

Defines the human readable text alternative of aria-valuenow for a range widget.

***

### autofocus?

> `optional` **autofocus**: [`PropValue`](../type-aliases/PropValue.md)\<`BooleanAttribute`\>

Defined in: [../domwise/dist/index.d.ts:739](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L739)

***

### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [../domwise/dist/index.d.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L150)

Child nodes / JSX children for the element.

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`children`](CustomDomAttributes.md#children)

***

### class?

> `optional` **class**: [`PropValue`](../type-aliases/PropValue.md)\<[`ClassNames`](../type-aliases/ClassNames.md)\> \| \{\[`key`: `string`\]: [`PropValue`](../type-aliases/PropValue.md)\<`boolean`\>; \}

Defined in: [../domwise/dist/index.d.ts:740](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L740)

***

### className?

> `optional` **className**: [`PropValue`](../type-aliases/PropValue.md)\<[`ClassNames`](../type-aliases/ClassNames.md)\> \| \{\[`key`: `string`\]: [`PropValue`](../type-aliases/PropValue.md)\<`boolean`\>; \}

Defined in: [../domwise/dist/index.d.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L166)

***

### dangerouslySetInnerHTML?

> `optional` **dangerouslySetInnerHTML**: `object`

Defined in: [../domwise/dist/index.d.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L152)

Raw HTML to assign via `innerHTML`. Use with caution — content is not escaped.

#### \_\_html

> **\_\_html**: `string`

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`dangerouslySetInnerHTML`](CustomDomAttributes.md#dangerouslysetinnerhtml)

***

### elementtiming?

> `optional` **elementtiming**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:743](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L743)

***

### id?

> `optional` **id**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:744](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L744)

***

### namespaceURI?

> `optional` **namespaceURI**: `string`

Defined in: [../domwise/dist/index.d.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L168)

***

### nonce?

> `optional` **nonce**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:745](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L745)

***

### on?

> `optional` **on**: `Record`\<`string`, `Function`\>

Defined in: [../domwise/dist/index.d.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L158)

Compatibility event map for `on*` handlers (jsx-dom / React style).

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`on`](CustomDomAttributes.md#on)

***

### onAbort?

> `optional` **onAbort**: `EventHandler`\<`T`, `UIEvent`\>

Defined in: [../domwise/dist/index.d.ts:613](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L613)

***

### onAbortCapture?

> `optional` **onAbortCapture**: `EventHandler`\<`T`, `UIEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onAbortCapture`

***

### onAnimationCancel?

> `optional` **onAnimationCancel**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:614](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L614)

***

### onAnimationCancelCapture?

> `optional` **onAnimationCancelCapture**: `EventHandler`\<`T`, `AnimationEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onAnimationCancelCapture`

***

### onAnimationEnd?

> `optional` **onAnimationEnd**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:615](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L615)

***

### onAnimationEndCapture?

> `optional` **onAnimationEndCapture**: `EventHandler`\<`T`, `AnimationEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onAnimationEndCapture`

***

### onAnimationIteration?

> `optional` **onAnimationIteration**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:616](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L616)

***

### onAnimationIterationCapture?

> `optional` **onAnimationIterationCapture**: `EventHandler`\<`T`, `AnimationEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onAnimationIterationCapture`

***

### onAnimationStart?

> `optional` **onAnimationStart**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [../domwise/dist/index.d.ts:617](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L617)

***

### onAnimationStartCapture?

> `optional` **onAnimationStartCapture**: `EventHandler`\<`T`, `AnimationEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onAnimationStartCapture`

***

### onAuxClick?

> `optional` **onAuxClick**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:618](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L618)

***

### onAuxClickCapture?

> `optional` **onAuxClickCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onAuxClickCapture`

***

### onBeforeCopy?

> `optional` **onBeforeCopy**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:619](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L619)

***

### onBeforeCopyCapture?

> `optional` **onBeforeCopyCapture**: `EventHandler`\<`T`, `ClipboardEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onBeforeCopyCapture`

***

### onBeforeCut?

> `optional` **onBeforeCut**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:620](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L620)

***

### onBeforeCutCapture?

> `optional` **onBeforeCutCapture**: `EventHandler`\<`T`, `ClipboardEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onBeforeCutCapture`

***

### onBeforeInput?

> `optional` **onBeforeInput**: `InputEventHandler`\<`T`, `InputEvent`\>

Defined in: [../domwise/dist/index.d.ts:621](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L621)

***

### onBeforeInputCapture?

> `optional` **onBeforeInputCapture**: `InputEventHandler`\<`T`, `InputEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onBeforeInputCapture`

***

### onBeforeMatch?

> `optional` **onBeforeMatch**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:622](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L622)

***

### onBeforeMatchCapture?

> `optional` **onBeforeMatchCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onBeforeMatchCapture`

***

### onBeforePaste?

> `optional` **onBeforePaste**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:623](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L623)

***

### onBeforePasteCapture?

> `optional` **onBeforePasteCapture**: `EventHandler`\<`T`, `ClipboardEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onBeforePasteCapture`

***

### onBeforeToggle?

> `optional` **onBeforeToggle**: `EventHandler`\<`T`, `ToggleEvent`\>

Defined in: [../domwise/dist/index.d.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L624)

***

### onBeforeToggleCapture?

> `optional` **onBeforeToggleCapture**: `EventHandler`\<`T`, `ToggleEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onBeforeToggleCapture`

***

### onBeforeXRSelect?

> `optional` **onBeforeXRSelect**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:625](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L625)

***

### onBeforeXRSelectCapture?

> `optional` **onBeforeXRSelectCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onBeforeXRSelectCapture`

***

### onBlur?

> `optional` **onBlur**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:626](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L626)

***

### onBlurCapture?

> `optional` **onBlurCapture**: `FocusEventHandler`\<`T`, `FocusEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onBlurCapture`

***

### onCancel?

> `optional` **onCancel**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L627)

***

### onCancelCapture?

> `optional` **onCancelCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onCancelCapture`

***

### onCanPlay?

> `optional` **onCanPlay**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L628)

***

### onCanPlayCapture?

> `optional` **onCanPlayCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onCanPlayCapture`

***

### onCanPlayThrough?

> `optional` **onCanPlayThrough**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:629](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L629)

***

### onCanPlayThroughCapture?

> `optional` **onCanPlayThroughCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onCanPlayThroughCapture`

***

### onCapture?

> `optional` **onCapture**: `Record`\<`string`, `Function`\>

Defined in: [../domwise/dist/index.d.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L160)

Compatibility event map for capture-phase handlers.

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`onCapture`](CustomDomAttributes.md#oncapture)

***

### onChange?

> `optional` **onChange**: `ChangeEventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:630](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L630)

***

### onChangeCapture?

> `optional` **onChangeCapture**: `ChangeEventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onChangeCapture`

***

### onClick?

> `optional` **onClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:631](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L631)

***

### onClickCapture?

> `optional` **onClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L169)

#### Overrides

`CapturePhaseEventHandlers.onClickCapture`

***

### onClose?

> `optional` **onClose**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:632](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L632)

***

### onCloseCapture?

> `optional` **onCloseCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onCloseCapture`

***

### onCommand?

> `optional` **onCommand**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:634](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L634)

***

### onCommandCapture?

> `optional` **onCommandCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onCommandCapture`

***

### onCompositionEnd?

> `optional` **onCompositionEnd**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [../domwise/dist/index.d.ts:635](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L635)

***

### onCompositionEndCapture?

> `optional` **onCompositionEndCapture**: `EventHandler`\<`T`, `CompositionEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onCompositionEndCapture`

***

### onCompositionStart?

> `optional` **onCompositionStart**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [../domwise/dist/index.d.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L636)

***

### onCompositionStartCapture?

> `optional` **onCompositionStartCapture**: `EventHandler`\<`T`, `CompositionEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onCompositionStartCapture`

***

### onCompositionUpdate?

> `optional` **onCompositionUpdate**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [../domwise/dist/index.d.ts:637](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L637)

***

### onCompositionUpdateCapture?

> `optional` **onCompositionUpdateCapture**: `EventHandler`\<`T`, `CompositionEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onCompositionUpdateCapture`

***

### onContentVisibilityAutoStateChange?

> `optional` **onContentVisibilityAutoStateChange**: `EventHandler`\<`T`, `ContentVisibilityAutoStateChangeEvent`\>

Defined in: [../domwise/dist/index.d.ts:638](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L638)

***

### onContentVisibilityAutoStateChangeCapture?

> `optional` **onContentVisibilityAutoStateChangeCapture**: `EventHandler`\<`T`, `ContentVisibilityAutoStateChangeEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onContentVisibilityAutoStateChangeCapture`

***

### onContextLost?

> `optional` **onContextLost**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:639](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L639)

***

### onContextLostCapture?

> `optional` **onContextLostCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onContextLostCapture`

***

### onContextMenu?

> `optional` **onContextMenu**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:640](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L640)

***

### onContextMenuCapture?

> `optional` **onContextMenuCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onContextMenuCapture`

***

### onContextRestored?

> `optional` **onContextRestored**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:641](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L641)

***

### onContextRestoredCapture?

> `optional` **onContextRestoredCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onContextRestoredCapture`

***

### onCopy?

> `optional` **onCopy**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:642](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L642)

***

### onCopyCapture?

> `optional` **onCopyCapture**: `EventHandler`\<`T`, `ClipboardEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onCopyCapture`

***

### onCueChange?

> `optional` **onCueChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:643](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L643)

***

### onCueChangeCapture?

> `optional` **onCueChangeCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onCueChangeCapture`

***

### onCut?

> `optional` **onCut**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L644)

***

### onCutCapture?

> `optional` **onCutCapture**: `EventHandler`\<`T`, `ClipboardEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onCutCapture`

***

### onDblClick?

> `optional` **onDblClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:645](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L645)

***

### onDblClickCapture?

> `optional` **onDblClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L170)

#### Overrides

`CapturePhaseEventHandlers.onDblClickCapture`

***

### onDoubleClick?

> `optional` **onDoubleClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L171)

***

### onDoubleClickCapture?

> `optional` **onDoubleClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L172)

***

### onDrag?

> `optional` **onDrag**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L646)

***

### onDragCapture?

> `optional` **onDragCapture**: `EventHandler`\<`T`, `DragEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onDragCapture`

***

### onDragEnd?

> `optional` **onDragEnd**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:647](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L647)

***

### onDragEndCapture?

> `optional` **onDragEndCapture**: `EventHandler`\<`T`, `DragEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onDragEndCapture`

***

### onDragEnter?

> `optional` **onDragEnter**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L648)

***

### onDragEnterCapture?

> `optional` **onDragEnterCapture**: `EventHandler`\<`T`, `DragEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onDragEnterCapture`

***

### onDragExit?

> `optional` **onDragExit**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:649](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L649)

***

### onDragExitCapture?

> `optional` **onDragExitCapture**: `EventHandler`\<`T`, `DragEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onDragExitCapture`

***

### onDragLeave?

> `optional` **onDragLeave**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:650](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L650)

***

### onDragLeaveCapture?

> `optional` **onDragLeaveCapture**: `EventHandler`\<`T`, `DragEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onDragLeaveCapture`

***

### onDragOver?

> `optional` **onDragOver**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:651](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L651)

***

### onDragOverCapture?

> `optional` **onDragOverCapture**: `EventHandler`\<`T`, `DragEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onDragOverCapture`

***

### onDragStart?

> `optional` **onDragStart**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:652](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L652)

***

### onDragStartCapture?

> `optional` **onDragStartCapture**: `EventHandler`\<`T`, `DragEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onDragStartCapture`

***

### onDrop?

> `optional` **onDrop**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [../domwise/dist/index.d.ts:653](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L653)

***

### onDropCapture?

> `optional` **onDropCapture**: `EventHandler`\<`T`, `DragEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onDropCapture`

***

### onDurationChange?

> `optional` **onDurationChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:654](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L654)

***

### onDurationChangeCapture?

> `optional` **onDurationChangeCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onDurationChangeCapture`

***

### onEmptied?

> `optional` **onEmptied**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:655](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L655)

***

### onEmptiedCapture?

> `optional` **onEmptiedCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onEmptiedCapture`

***

### onEnded?

> `optional` **onEnded**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:656](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L656)

***

### onEndedCapture?

> `optional` **onEndedCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onEndedCapture`

***

### onError?

> `optional` **onError**: `EventHandler`\<`T`, `ErrorEvent`\>

Defined in: [../domwise/dist/index.d.ts:657](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L657)

***

### onErrorCapture?

> `optional` **onErrorCapture**: `EventHandler`\<`T`, `ErrorEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onErrorCapture`

***

### onFocus?

> `optional` **onFocus**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:658](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L658)

***

### onFocusCapture?

> `optional` **onFocusCapture**: `FocusEventHandler`\<`T`, `FocusEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onFocusCapture`

***

### onFocusIn?

> `optional` **onFocusIn**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:659](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L659)

***

### onFocusInCapture?

> `optional` **onFocusInCapture**: `FocusEventHandler`\<`T`, `FocusEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onFocusInCapture`

***

### onFocusOut?

> `optional` **onFocusOut**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [../domwise/dist/index.d.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L660)

***

### onFocusOutCapture?

> `optional` **onFocusOutCapture**: `FocusEventHandler`\<`T`, `FocusEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onFocusOutCapture`

***

### onFormData?

> `optional` **onFormData**: `EventHandler`\<`T`, `FormDataEvent`\>

Defined in: [../domwise/dist/index.d.ts:661](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L661)

***

### onFormDataCapture?

> `optional` **onFormDataCapture**: `EventHandler`\<`T`, `FormDataEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onFormDataCapture`

***

### onFullscreenChange?

> `optional` **onFullscreenChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L662)

***

### onFullscreenChangeCapture?

> `optional` **onFullscreenChangeCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onFullscreenChangeCapture`

***

### onFullscreenError?

> `optional` **onFullscreenError**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:663](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L663)

***

### onFullscreenErrorCapture?

> `optional` **onFullscreenErrorCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onFullscreenErrorCapture`

***

### onGotPointerCapture?

> `optional` **onGotPointerCapture**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L664)

***

### onGotPointerCaptureCapture?

> `optional` **onGotPointerCaptureCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onGotPointerCaptureCapture`

***

### onInput?

> `optional` **onInput**: `InputEventHandler`\<`T`, `InputEvent`\>

Defined in: [../domwise/dist/index.d.ts:665](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L665)

***

### onInputCapture?

> `optional` **onInputCapture**: `InputEventHandler`\<`T`, `InputEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onInputCapture`

***

### onInvalid?

> `optional` **onInvalid**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:666](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L666)

***

### onInvalidCapture?

> `optional` **onInvalidCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onInvalidCapture`

***

### onKeyDown?

> `optional` **onKeyDown**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:667](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L667)

***

### onKeyDownCapture?

> `optional` **onKeyDownCapture**: `EventHandler`\<`T`, `KeyboardEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onKeyDownCapture`

***

### onKeyPress?

> `optional` **onKeyPress**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L668)

***

### onKeyPressCapture?

> `optional` **onKeyPressCapture**: `EventHandler`\<`T`, `KeyboardEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onKeyPressCapture`

***

### onKeyUp?

> `optional` **onKeyUp**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:669](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L669)

***

### onKeyUpCapture?

> `optional` **onKeyUpCapture**: `EventHandler`\<`T`, `KeyboardEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onKeyUpCapture`

***

### onLoad?

> `optional` **onLoad**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:670](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L670)

***

### onLoadCapture?

> `optional` **onLoadCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onLoadCapture`

***

### onLoadedData?

> `optional` **onLoadedData**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:671](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L671)

***

### onLoadedDataCapture?

> `optional` **onLoadedDataCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onLoadedDataCapture`

***

### onLoadedMetadata?

> `optional` **onLoadedMetadata**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L672)

***

### onLoadedMetadataCapture?

> `optional` **onLoadedMetadataCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onLoadedMetadataCapture`

***

### onLoadStart?

> `optional` **onLoadStart**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:673](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L673)

***

### onLoadStartCapture?

> `optional` **onLoadStartCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onLoadStartCapture`

***

### onLostPointerCapture?

> `optional` **onLostPointerCapture**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:674](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L674)

***

### onLostPointerCaptureCapture?

> `optional` **onLostPointerCaptureCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onLostPointerCaptureCapture`

***

### onMouseDown?

> `optional` **onMouseDown**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:675](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L675)

***

### onMouseDownCapture?

> `optional` **onMouseDownCapture**: `EventHandler`\<`T`, `MouseEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onMouseDownCapture`

***

### onMouseEnter?

> `optional` **onMouseEnter**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:676](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L676)

***

### onMouseEnterCapture?

> `optional` **onMouseEnterCapture**: `EventHandler`\<`T`, `MouseEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onMouseEnterCapture`

***

### onMouseLeave?

> `optional` **onMouseLeave**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:677](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L677)

***

### onMouseLeaveCapture?

> `optional` **onMouseLeaveCapture**: `EventHandler`\<`T`, `MouseEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onMouseLeaveCapture`

***

### onMouseMove?

> `optional` **onMouseMove**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:678](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L678)

***

### onMouseMoveCapture?

> `optional` **onMouseMoveCapture**: `EventHandler`\<`T`, `MouseEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onMouseMoveCapture`

***

### onMouseOut?

> `optional` **onMouseOut**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:679](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L679)

***

### onMouseOutCapture?

> `optional` **onMouseOutCapture**: `EventHandler`\<`T`, `MouseEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onMouseOutCapture`

***

### onMouseOver?

> `optional` **onMouseOver**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L680)

***

### onMouseOverCapture?

> `optional` **onMouseOverCapture**: `EventHandler`\<`T`, `MouseEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onMouseOverCapture`

***

### onMouseUp?

> `optional` **onMouseUp**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [../domwise/dist/index.d.ts:681](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L681)

***

### onMouseUpCapture?

> `optional` **onMouseUpCapture**: `EventHandler`\<`T`, `MouseEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onMouseUpCapture`

***

### onPaste?

> `optional` **onPaste**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [../domwise/dist/index.d.ts:682](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L682)

***

### onPasteCapture?

> `optional` **onPasteCapture**: `EventHandler`\<`T`, `ClipboardEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPasteCapture`

***

### onPause?

> `optional` **onPause**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:683](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L683)

***

### onPauseCapture?

> `optional` **onPauseCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onPauseCapture`

***

### onPlay?

> `optional` **onPlay**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:684](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L684)

***

### onPlayCapture?

> `optional` **onPlayCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onPlayCapture`

***

### onPlaying?

> `optional` **onPlaying**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:685](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L685)

***

### onPlayingCapture?

> `optional` **onPlayingCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onPlayingCapture`

***

### onPointerCancel?

> `optional` **onPointerCancel**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:686](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L686)

***

### onPointerCancelCapture?

> `optional` **onPointerCancelCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPointerCancelCapture`

***

### onPointerDown?

> `optional` **onPointerDown**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:687](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L687)

***

### onPointerDownCapture?

> `optional` **onPointerDownCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPointerDownCapture`

***

### onPointerEnter?

> `optional` **onPointerEnter**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:688](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L688)

***

### onPointerEnterCapture?

> `optional` **onPointerEnterCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPointerEnterCapture`

***

### onPointerLeave?

> `optional` **onPointerLeave**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:689](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L689)

***

### onPointerLeaveCapture?

> `optional` **onPointerLeaveCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPointerLeaveCapture`

***

### onPointerMove?

> `optional` **onPointerMove**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:690](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L690)

***

### onPointerMoveCapture?

> `optional` **onPointerMoveCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPointerMoveCapture`

***

### onPointerOut?

> `optional` **onPointerOut**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:691](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L691)

***

### onPointerOutCapture?

> `optional` **onPointerOutCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPointerOutCapture`

***

### onPointerOver?

> `optional` **onPointerOver**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:692](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L692)

***

### onPointerOverCapture?

> `optional` **onPointerOverCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPointerOverCapture`

***

### onPointerRawUpdate?

> `optional` **onPointerRawUpdate**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:693](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L693)

***

### onPointerRawUpdateCapture?

> `optional` **onPointerRawUpdateCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPointerRawUpdateCapture`

***

### onPointerUp?

> `optional` **onPointerUp**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [../domwise/dist/index.d.ts:694](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L694)

***

### onPointerUpCapture?

> `optional` **onPointerUpCapture**: `EventHandler`\<`T`, `PointerEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onPointerUpCapture`

***

### onProgress?

> `optional` **onProgress**: `EventHandler`\<`T`, `ProgressEvent`\<`EventTarget`\>\>

Defined in: [../domwise/dist/index.d.ts:695](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L695)

***

### onProgressCapture?

> `optional` **onProgressCapture**: `EventHandler`\<`T`, `ProgressEvent`\<`EventTarget`\>\>

#### Inherited from

`CapturePhaseEventHandlers.onProgressCapture`

***

### onRateChange?

> `optional` **onRateChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:696](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L696)

***

### onRateChangeCapture?

> `optional` **onRateChangeCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onRateChangeCapture`

***

### onReset?

> `optional` **onReset**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:697](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L697)

***

### onResetCapture?

> `optional` **onResetCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onResetCapture`

***

### onResize?

> `optional` **onResize**: `EventHandler`\<`T`, `UIEvent`\>

Defined in: [../domwise/dist/index.d.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L698)

***

### onResizeCapture?

> `optional` **onResizeCapture**: `EventHandler`\<`T`, `UIEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onResizeCapture`

***

### onScroll?

> `optional` **onScroll**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:699](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L699)

***

### onScrollCapture?

> `optional` **onScrollCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onScrollCapture`

***

### onScrollEnd?

> `optional` **onScrollEnd**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:700](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L700)

***

### onScrollEndCapture?

> `optional` **onScrollEndCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onScrollEndCapture`

***

### onScrollSnapChange?

> `optional` **onScrollSnapChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L701)

***

### onScrollSnapChangeCapture?

> `optional` **onScrollSnapChangeCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onScrollSnapChangeCapture`

***

### onScrollSnapChanging?

> `optional` **onScrollSnapChanging**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:702](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L702)

***

### onScrollSnapChangingCapture?

> `optional` **onScrollSnapChangingCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onScrollSnapChangingCapture`

***

### onSecurityPolicyViolation?

> `optional` **onSecurityPolicyViolation**: `EventHandler`\<`T`, `SecurityPolicyViolationEvent`\>

Defined in: [../domwise/dist/index.d.ts:703](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L703)

***

### onSecurityPolicyViolationCapture?

> `optional` **onSecurityPolicyViolationCapture**: `EventHandler`\<`T`, `SecurityPolicyViolationEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onSecurityPolicyViolationCapture`

***

### onSeeked?

> `optional` **onSeeked**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:704](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L704)

***

### onSeekedCapture?

> `optional` **onSeekedCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onSeekedCapture`

***

### onSeeking?

> `optional` **onSeeking**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:705](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L705)

***

### onSeekingCapture?

> `optional` **onSeekingCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onSeekingCapture`

***

### onSelect?

> `optional` **onSelect**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:706](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L706)

***

### onSelectCapture?

> `optional` **onSelectCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onSelectCapture`

***

### onSelectionChange?

> `optional` **onSelectionChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:707](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L707)

***

### onSelectionChangeCapture?

> `optional` **onSelectionChangeCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onSelectionChangeCapture`

***

### onSelectStart?

> `optional` **onSelectStart**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:708](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L708)

***

### onSelectStartCapture?

> `optional` **onSelectStartCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onSelectStartCapture`

***

### onSlotChange?

> `optional` **onSlotChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:709](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L709)

***

### onSlotChangeCapture?

> `optional` **onSlotChangeCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onSlotChangeCapture`

***

### onStalled?

> `optional` **onStalled**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:710](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L710)

***

### onStalledCapture?

> `optional` **onStalledCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onStalledCapture`

***

### onSubmit?

> `optional` **onSubmit**: `EventHandler`\<`T`, `SubmitEvent`\>

Defined in: [../domwise/dist/index.d.ts:711](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L711)

***

### onSubmitCapture?

> `optional` **onSubmitCapture**: `EventHandler`\<`T`, `SubmitEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onSubmitCapture`

***

### onSuspend?

> `optional` **onSuspend**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:712](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L712)

***

### onSuspendCapture?

> `optional` **onSuspendCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onSuspendCapture`

***

### onTimeUpdate?

> `optional` **onTimeUpdate**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:713](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L713)

***

### onTimeUpdateCapture?

> `optional` **onTimeUpdateCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onTimeUpdateCapture`

***

### onToggle?

> `optional` **onToggle**: `EventHandler`\<`T`, `ToggleEvent`\>

Defined in: [../domwise/dist/index.d.ts:714](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L714)

***

### onToggleCapture?

> `optional` **onToggleCapture**: `EventHandler`\<`T`, `ToggleEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onToggleCapture`

***

### onTouchCancel?

> `optional` **onTouchCancel**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:715](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L715)

***

### onTouchCancelCapture?

> `optional` **onTouchCancelCapture**: `EventHandler`\<`T`, `TouchEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onTouchCancelCapture`

***

### onTouchEnd?

> `optional` **onTouchEnd**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:716](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L716)

***

### onTouchEndCapture?

> `optional` **onTouchEndCapture**: `EventHandler`\<`T`, `TouchEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onTouchEndCapture`

***

### onTouchMove?

> `optional` **onTouchMove**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:717](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L717)

***

### onTouchMoveCapture?

> `optional` **onTouchMoveCapture**: `EventHandler`\<`T`, `TouchEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onTouchMoveCapture`

***

### onTouchStart?

> `optional` **onTouchStart**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [../domwise/dist/index.d.ts:718](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L718)

***

### onTouchStartCapture?

> `optional` **onTouchStartCapture**: `EventHandler`\<`T`, `TouchEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onTouchStartCapture`

***

### onTransitionCancel?

> `optional` **onTransitionCancel**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:719](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L719)

***

### onTransitionCancelCapture?

> `optional` **onTransitionCancelCapture**: `EventHandler`\<`T`, `TransitionEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onTransitionCancelCapture`

***

### onTransitionEnd?

> `optional` **onTransitionEnd**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:720](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L720)

***

### onTransitionEndCapture?

> `optional` **onTransitionEndCapture**: `EventHandler`\<`T`, `TransitionEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onTransitionEndCapture`

***

### onTransitionRun?

> `optional` **onTransitionRun**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:721](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L721)

***

### onTransitionRunCapture?

> `optional` **onTransitionRunCapture**: `EventHandler`\<`T`, `TransitionEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onTransitionRunCapture`

***

### onTransitionStart?

> `optional` **onTransitionStart**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [../domwise/dist/index.d.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L722)

***

### onTransitionStartCapture?

> `optional` **onTransitionStartCapture**: `EventHandler`\<`T`, `TransitionEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onTransitionStartCapture`

***

### onVolumeChange?

> `optional` **onVolumeChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:723](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L723)

***

### onVolumeChangeCapture?

> `optional` **onVolumeChangeCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onVolumeChangeCapture`

***

### onWaiting?

> `optional` **onWaiting**: `EventHandler`\<`T`, `Event`\>

Defined in: [../domwise/dist/index.d.ts:724](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L724)

***

### onWaitingCapture?

> `optional` **onWaitingCapture**: `EventHandler`\<`T`, `Event`\>

#### Inherited from

`CapturePhaseEventHandlers.onWaitingCapture`

***

### onWheel?

> `optional` **onWheel**: `EventHandler`\<`T`, `WheelEvent`\>

Defined in: [../domwise/dist/index.d.ts:725](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L725)

***

### onWheelCapture?

> `optional` **onWheelCapture**: `EventHandler`\<`T`, `WheelEvent`\>

#### Inherited from

`CapturePhaseEventHandlers.onWheelCapture`

***

### part?

> `optional` **part**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:746](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L746)

***

### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L156)

Ref object or callback that receives the created DOM node.

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`ref`](CustomDomAttributes.md#ref)

***

### role?

> `optional` **role**: [`PropValue`](../type-aliases/PropValue.md)\<`false` \| `"dialog"` \| `"article"` \| `"button"` \| `"figure"` \| `"form"` \| `"img"` \| `"link"` \| `"main"` \| `"menu"` \| `"meter"` \| `"option"` \| `"search"` \| `"table"` \| `"switch"` \| `"math"` \| `"marquee"` \| `"menuitem"` \| `"radio"` \| `"checkbox"` \| `"none"` \| `"heading"` \| `"list"` \| `"tree"` \| `"alert"` \| `"grid"` \| `"presentation"` \| `"alertdialog"` \| `"application"` \| `"banner"` \| `"cell"` \| `"columnheader"` \| `"combobox"` \| `"complementary"` \| `"contentinfo"` \| `"definition"` \| `"directory"` \| `"document"` \| `"feed"` \| `"gridcell"` \| `"group"` \| `"listbox"` \| `"listitem"` \| `"log"` \| `"menubar"` \| `"menuitemcheckbox"` \| `"menuitemradio"` \| `"navigation"` \| `"note"` \| `"progressbar"` \| `"radiogroup"` \| `"region"` \| `"row"` \| `"rowgroup"` \| `"rowheader"` \| `"scrollbar"` \| `"searchbox"` \| `"separator"` \| `"slider"` \| `"spinbutton"` \| `"status"` \| `"tab"` \| `"tablist"` \| `"tabpanel"` \| `"term"` \| `"textbox"` \| `"timer"` \| `"toolbar"` \| `"tooltip"` \| `"treegrid"` \| `"treeitem"`\>

Defined in: [../domwise/dist/index.d.ts:586](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L586)

***

### slot?

> `optional` **slot**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:747](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L747)

***

### style?

> `optional` **style**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false` \| [`StyleProperties`](../type-aliases/StyleProperties.md) \| [`StyleProperties`](../type-aliases/StyleProperties.md)[]\>

Defined in: [../domwise/dist/index.d.ts:748](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L748)

***

### tabindex?

> `optional` **tabindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:749](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L749)

***

### tabIndex?

> `optional` **tabIndex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `false`\>

Defined in: [../domwise/dist/index.d.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L167)

***

### textContent?

> `optional` **textContent**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number`\>

Defined in: [../domwise/dist/index.d.ts:737](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L737)
