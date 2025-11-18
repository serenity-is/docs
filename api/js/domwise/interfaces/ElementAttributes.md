[@serenity-is/domwise](../README.md) / ElementAttributes

# Interface: ElementAttributes\<T\>

Defined in: [types/jsx-elements.d.ts:555](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L555)

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

> `optional` **aria-activedescendant**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L91)

Identifies the currently active element when DOM focus is on a composite widget, textbox,
group, or application.

#### Inherited from

`AriaAttributes.aria-activedescendant`

***

### aria-atomic?

> `optional` **aria-atomic**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L96)

Indicates whether assistive technologies will present all, or only parts of, the changed
region based on the change notifications defined by the aria-relevant attribute.

#### Inherited from

`AriaAttributes.aria-atomic`

***

### aria-autocomplete?

> `optional` **aria-autocomplete**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `"none"` \| `"inline"` \| `"list"` \| `"both"`\>

Defined in: [types/jsx-elements.d.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L123)

Indicates whether inputting text could trigger display of one or more predictions of the
user's intended value for an input and specifies how predictions would be presented if they
are made.

#### Inherited from

`AriaAttributes.aria-autocomplete`

***

### aria-braillelabel?

> `optional` **aria-braillelabel**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L103)

Similar to the global aria-label. Defines a string value that labels the current element,
which is intended to be converted into Braille.

#### See

aria-label.

#### Inherited from

`AriaAttributes.aria-braillelabel`

***

### aria-brailleroledescription?

> `optional` **aria-brailleroledescription**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L117)

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

#### Inherited from

`AriaAttributes.aria-brailleroledescription`

***

### aria-busy?

> `optional` **aria-busy**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L128)

Indicates an element is being modified and that assistive technologies MAY want to wait until
the modifications are complete before exposing them to the user.

#### Inherited from

`AriaAttributes.aria-busy`

***

### aria-checked?

> `optional` **aria-checked**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean` \| `"mixed"`\>

Defined in: [types/jsx-elements.d.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L134)

Indicates the current "checked" state of checkboxes, radio buttons, and other widgets.

#### See

 - aria-pressed
 - aria-selected.

#### Inherited from

`AriaAttributes.aria-checked`

***

### aria-colcount?

> `optional` **aria-colcount**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L140)

Defines the total number of columns in a table, grid, or treegrid.

#### See

aria-colindex.

#### Inherited from

`AriaAttributes.aria-colcount`

***

### aria-colindex?

> `optional` **aria-colindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L147)

Defines an element's column index or position with respect to the total number of columns
within a table, grid, or treegrid.

#### See

 - aria-colcount
 - aria-colspan.

#### Inherited from

`AriaAttributes.aria-colindex`

***

### aria-colindextext?

> `optional` **aria-colindextext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L149)

Defines a human-readable text alternative of the numeric aria-colindex.

#### Inherited from

`AriaAttributes.aria-colindextext`

***

### aria-colspan?

> `optional` **aria-colspan**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L156)

Defines the number of columns spanned by a cell or gridcell within a table, grid, or
treegrid.

#### See

 - aria-colindex
 - aria-rowspan.

#### Inherited from

`AriaAttributes.aria-colspan`

***

### aria-controls?

> `optional` **aria-controls**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L163)

Identifies the element (or elements) whose contents or presence are controlled by the current
element.

#### See

aria-owns.

#### Inherited from

`AriaAttributes.aria-controls`

***

### aria-current?

> `optional` **aria-current**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean` \| `"page"` \| `"step"` \| `"location"` \| `"date"` \| `"time"`\>

Defined in: [types/jsx-elements.d.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L168)

Indicates the element that represents the current item within a container or set of related
elements.

#### Inherited from

`AriaAttributes.aria-current`

***

### aria-describedby?

> `optional` **aria-describedby**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L174)

Identifies the element (or elements) that describes the object.

#### See

aria-labelledby

#### Inherited from

`AriaAttributes.aria-describedby`

***

### aria-description?

> `optional` **aria-description**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L180)

Defines a string value that describes or annotates the current element.

#### See

aria-describedby

#### Inherited from

`AriaAttributes.aria-description`

***

### aria-details?

> `optional` **aria-details**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L186)

Identifies the element that provides a detailed, extended description for the object.

#### See

aria-describedby.

#### Inherited from

`AriaAttributes.aria-details`

***

### aria-disabled?

> `optional` **aria-disabled**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L193)

Indicates that the element is perceivable but disabled, so it is not editable or otherwise
operable.

#### See

 - aria-hidden
 - aria-readonly.

#### Inherited from

`AriaAttributes.aria-disabled`

***

### ~~aria-dropeffect?~~

> `optional` **aria-dropeffect**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `"link"` \| `"none"` \| `"copy"` \| `"execute"` \| `"move"` \| `"popup"`\>

Defined in: [types/jsx-elements.d.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L200)

Indicates what functions can be performed when a dragged object is released on the drop
target.

#### Deprecated

In ARIA 1.1

#### Inherited from

`AriaAttributes.aria-dropeffect`

***

### aria-errormessage?

> `optional` **aria-errormessage**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L206)

Identifies the element that provides an error message for the object.

#### See

 - aria-invalid
 - aria-describedby.

#### Inherited from

`AriaAttributes.aria-errormessage`

***

### aria-expanded?

> `optional` **aria-expanded**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L211)

Indicates whether the element, or another grouping element it controls, is currently expanded
or collapsed.

#### Inherited from

`AriaAttributes.aria-expanded`

***

### aria-flowto?

> `optional` **aria-flowto**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L217)

Identifies the next element (or elements) in an alternate reading order of content which, at
the user's discretion, allows assistive technology to override the general default of reading
in document source order.

#### Inherited from

`AriaAttributes.aria-flowto`

***

### ~~aria-grabbed?~~

> `optional` **aria-grabbed**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L223)

Indicates an element's "grabbed" state in a drag-and-drop operation.

#### Deprecated

In ARIA 1.1

#### Inherited from

`AriaAttributes.aria-grabbed`

***

### aria-haspopup?

> `optional` **aria-haspopup**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean` \| `"grid"` \| `"menu"` \| `"listbox"` \| `"tree"` \| `"dialog"`\>

Defined in: [types/jsx-elements.d.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L228)

Indicates the availability and type of interactive popup element, such as menu or dialog,
that can be triggered by an element.

#### Inherited from

`AriaAttributes.aria-haspopup`

***

### aria-hidden?

> `optional` **aria-hidden**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L234)

Indicates whether the element is exposed to an accessibility API.

#### See

aria-disabled.

#### Inherited from

`AriaAttributes.aria-hidden`

***

### aria-invalid?

> `optional` **aria-invalid**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean` \| `"grammar"` \| `"spelling"`\>

Defined in: [types/jsx-elements.d.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L240)

Indicates the entered value does not conform to the format expected by the application.

#### See

aria-errormessage.

#### Inherited from

`AriaAttributes.aria-invalid`

***

### aria-keyshortcuts?

> `optional` **aria-keyshortcuts**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L245)

Indicates keyboard shortcuts that an author has implemented to activate or give focus to an
element.

#### Inherited from

`AriaAttributes.aria-keyshortcuts`

***

### aria-label?

> `optional` **aria-label**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L251)

Defines a string value that labels the current element.

#### See

aria-labelledby.

#### Inherited from

`AriaAttributes.aria-label`

***

### aria-labelledby?

> `optional` **aria-labelledby**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L257)

Identifies the element (or elements) that labels the current element.

#### See

aria-describedby.

#### Inherited from

`AriaAttributes.aria-labelledby`

***

### aria-level?

> `optional` **aria-level**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L259)

Defines the hierarchical level of an element within a structure.

#### Inherited from

`AriaAttributes.aria-level`

***

### aria-live?

> `optional` **aria-live**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `"off"` \| `"assertive"` \| `"polite"`\>

Defined in: [types/jsx-elements.d.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L264)

Indicates that an element will be updated, and describes the types of updates the user
agents, assistive technologies, and user can expect from the live region.

#### Inherited from

`AriaAttributes.aria-live`

***

### aria-modal?

> `optional` **aria-modal**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L266)

Indicates whether an element is modal when displayed.

#### Inherited from

`AriaAttributes.aria-modal`

***

### aria-multiline?

> `optional` **aria-multiline**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L268)

Indicates whether a text box accepts multiple lines of input or only a single line.

#### Inherited from

`AriaAttributes.aria-multiline`

***

### aria-multiselectable?

> `optional` **aria-multiselectable**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L273)

Indicates that the user may select more than one item from the current selectable
descendants.

#### Inherited from

`AriaAttributes.aria-multiselectable`

***

### aria-orientation?

> `optional` **aria-orientation**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `"horizontal"` \| `"vertical"`\>

Defined in: [types/jsx-elements.d.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L275)

Indicates whether the element's orientation is horizontal, vertical, or unknown/ambiguous.

#### Inherited from

`AriaAttributes.aria-orientation`

***

### aria-owns?

> `optional` **aria-owns**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L283)

Identifies an element (or elements) in order to define a visual, functional, or contextual
parent/child relationship between DOM elements where the DOM hierarchy cannot be used to
represent the relationship.

#### See

aria-controls.

#### Inherited from

`AriaAttributes.aria-owns`

***

### aria-placeholder?

> `optional` **aria-placeholder**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L289)

Defines a short hint (a word or short phrase) intended to aid the user with data entry when
the control has no value. A hint could be a sample value or a brief description of the
expected format.

#### Inherited from

`AriaAttributes.aria-placeholder`

***

### aria-posinset?

> `optional` **aria-posinset**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L296)

Defines an element's number or position in the current set of listitems or treeitems. Not
required if all elements in the set are present in the DOM.

#### See

aria-setsize.

#### Inherited from

`AriaAttributes.aria-posinset`

***

### aria-pressed?

> `optional` **aria-pressed**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean` \| `"mixed"`\>

Defined in: [types/jsx-elements.d.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L302)

Indicates the current "pressed" state of toggle buttons.

#### See

 - aria-checked
 - aria-selected.

#### Inherited from

`AriaAttributes.aria-pressed`

***

### aria-readonly?

> `optional` **aria-readonly**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L308)

Indicates that the element is not editable, but is otherwise operable.

#### See

aria-disabled.

#### Inherited from

`AriaAttributes.aria-readonly`

***

### aria-relevant?

> `optional` **aria-relevant**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `"all"` \| `"additions"` \| `"additions removals"` \| `"additions text"` \| `"removals"` \| `"removals additions"` \| `"removals text"` \| `"text"` \| `"text additions"` \| `"text removals"`\>

Defined in: [types/jsx-elements.d.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L315)

Indicates what notifications the user agent will trigger when the accessibility tree within a
live region is modified.

#### See

aria-atomic.

#### Inherited from

`AriaAttributes.aria-relevant`

***

### aria-required?

> `optional` **aria-required**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L317)

Indicates that user input is required on the element before a form may be submitted.

#### Inherited from

`AriaAttributes.aria-required`

***

### aria-roledescription?

> `optional` **aria-roledescription**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:319](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L319)

Defines a human-readable, author-localized description for the role of an element.

#### Inherited from

`AriaAttributes.aria-roledescription`

***

### aria-rowcount?

> `optional` **aria-rowcount**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:325](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L325)

Defines the total number of rows in a table, grid, or treegrid.

#### See

aria-rowindex.

#### Inherited from

`AriaAttributes.aria-rowcount`

***

### aria-rowindex?

> `optional` **aria-rowindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L332)

Defines an element's row index or position with respect to the total number of rows within a
table, grid, or treegrid.

#### See

 - aria-rowcount
 - aria-rowspan.

#### Inherited from

`AriaAttributes.aria-rowindex`

***

### aria-rowindextext?

> `optional` **aria-rowindextext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L334)

Defines a human-readable text alternative of aria-rowindex.

#### Inherited from

`AriaAttributes.aria-rowindextext`

***

### aria-rowspan?

> `optional` **aria-rowspan**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:340](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L340)

Defines the number of rows spanned by a cell or gridcell within a table, grid, or treegrid.

#### See

 - aria-rowindex
 - aria-colspan.

#### Inherited from

`AriaAttributes.aria-rowspan`

***

### aria-selected?

> `optional` **aria-selected**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `EnumeratedPseudoBoolean`\>

Defined in: [types/jsx-elements.d.ts:346](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L346)

Indicates the current "selected" state of various widgets.

#### See

 - aria-checked
 - aria-pressed.

#### Inherited from

`AriaAttributes.aria-selected`

***

### aria-setsize?

> `optional` **aria-setsize**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L353)

Defines the number of items in the current set of listitems or treeitems. Not required if all
elements in the set are present in the DOM.

#### See

aria-posinset.

#### Inherited from

`AriaAttributes.aria-setsize`

***

### aria-sort?

> `optional` **aria-sort**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `"none"` \| `"ascending"` \| `"descending"` \| `"other"`\>

Defined in: [types/jsx-elements.d.ts:355](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L355)

Indicates if items in a table or grid are sorted in ascending or descending order.

#### Inherited from

`AriaAttributes.aria-sort`

***

### aria-valuemax?

> `optional` **aria-valuemax**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L357)

Defines the maximum allowed value for a range widget.

#### Inherited from

`AriaAttributes.aria-valuemax`

***

### aria-valuemin?

> `optional` **aria-valuemin**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L359)

Defines the minimum allowed value for a range widget.

#### Inherited from

`AriaAttributes.aria-valuemin`

***

### aria-valuenow?

> `optional` **aria-valuenow**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L365)

Defines the current value for a range widget.

#### See

aria-valuetext.

#### Inherited from

`AriaAttributes.aria-valuenow`

***

### aria-valuetext?

> `optional` **aria-valuetext**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L367)

Defines the human readable text alternative of aria-valuenow for a range widget.

#### Inherited from

`AriaAttributes.aria-valuetext`

***

### autofocus?

> `optional` **autofocus**: [`PropValue`](../type-aliases/PropValue.md)\<`boolean` \| `""` \| `undefined`\>

Defined in: [types/jsx-elements.d.ts:569](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L569)

***

### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [types/custom-attributes.d.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L5)

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`children`](CustomDomAttributes.md#children)

***

### class?

> `optional` **class**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false` \| `DOMTokenList` \| \{\[`key`: `string`\]: `boolean`; \} \| [`ClassName`](../type-aliases/ClassName.md)[] \| `Iterable`\<`string`, `any`, `any`\> \| `null` \| `undefined`\> \| \{\[`key`: `string`\]: [`PropValue`](../type-aliases/PropValue.md)\<true \| RemoveAttribute\>; \}

Defined in: [types/jsx-elements.d.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L570)

***

### className?

> `optional` **className**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `false` \| `DOMTokenList` \| \{\[`key`: `string`\]: `boolean`; \} \| [`ClassName`](../type-aliases/ClassName.md)[] \| `Iterable`\<`string`, `any`, `any`\> \| `null` \| `undefined`\> \| \{\[`key`: `string`\]: [`PropValue`](../type-aliases/PropValue.md)\<true \| RemoveAttribute\>; \}

Defined in: [types/custom-attributes.d.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L16)

***

### dangerouslySetInnerHTML?

> `optional` **dangerouslySetInnerHTML**: `object`

Defined in: [types/custom-attributes.d.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L6)

#### \_\_html

> **\_\_html**: `string`

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`dangerouslySetInnerHTML`](CustomDomAttributes.md#dangerouslysetinnerhtml)

***

### elementtiming?

> `optional` **elementtiming**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:571](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L571)

***

### id?

> `optional` **id**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:572](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L572)

***

### namespaceURI?

> `optional` **namespaceURI**: `string`

Defined in: [types/custom-attributes.d.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L18)

***

### nonce?

> `optional` **nonce**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:573](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L573)

***

### on?

> `optional` **on**: `Record`\<`string`, `Function`\>

Defined in: [types/custom-attributes.d.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L10)

compat from jsx-dom/react

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`on`](CustomDomAttributes.md#on)

***

### onAbort?

> `optional` **onAbort**: `EventHandler`\<`T`, `UIEvent`\>

Defined in: [types/jsx-elements.d.ts:413](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L413)

#### Inherited from

`EventHandlersElement.onAbort`

***

### onAnimationCancel?

> `optional` **onAnimationCancel**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [types/jsx-elements.d.ts:414](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L414)

#### Inherited from

`EventHandlersElement.onAnimationCancel`

***

### onAnimationEnd?

> `optional` **onAnimationEnd**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [types/jsx-elements.d.ts:415](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L415)

#### Inherited from

`EventHandlersElement.onAnimationEnd`

***

### onAnimationIteration?

> `optional` **onAnimationIteration**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [types/jsx-elements.d.ts:416](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L416)

#### Inherited from

`EventHandlersElement.onAnimationIteration`

***

### onAnimationStart?

> `optional` **onAnimationStart**: `EventHandler`\<`T`, `AnimationEvent`\>

Defined in: [types/jsx-elements.d.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L417)

#### Inherited from

`EventHandlersElement.onAnimationStart`

***

### onAuxClick?

> `optional` **onAuxClick**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:418](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L418)

#### Inherited from

`EventHandlersElement.onAuxClick`

***

### onBeforeCopy?

> `optional` **onBeforeCopy**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [types/jsx-elements.d.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L419)

#### Inherited from

`EventHandlersElement.onBeforeCopy`

***

### onBeforeCut?

> `optional` **onBeforeCut**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [types/jsx-elements.d.ts:420](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L420)

#### Inherited from

`EventHandlersElement.onBeforeCut`

***

### onBeforeInput?

> `optional` **onBeforeInput**: `InputEventHandler`\<`T`, `InputEvent`\>

Defined in: [types/jsx-elements.d.ts:421](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L421)

#### Inherited from

`EventHandlersElement.onBeforeInput`

***

### onBeforeMatch?

> `optional` **onBeforeMatch**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:422](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L422)

#### Inherited from

`EventHandlersElement.onBeforeMatch`

***

### onBeforePaste?

> `optional` **onBeforePaste**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [types/jsx-elements.d.ts:423](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L423)

#### Inherited from

`EventHandlersElement.onBeforePaste`

***

### onBeforeToggle?

> `optional` **onBeforeToggle**: `EventHandler`\<`T`, `ToggleEvent`\>

Defined in: [types/jsx-elements.d.ts:424](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L424)

#### Inherited from

`EventHandlersElement.onBeforeToggle`

***

### onBeforeXRSelect?

> `optional` **onBeforeXRSelect**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:425](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L425)

#### Inherited from

`EventHandlersElement.onBeforeXRSelect`

***

### onBlur?

> `optional` **onBlur**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [types/jsx-elements.d.ts:426](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L426)

#### Inherited from

`EventHandlersElement.onBlur`

***

### onCancel?

> `optional` **onCancel**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:427](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L427)

#### Inherited from

`EventHandlersElement.onCancel`

***

### onCanPlay?

> `optional` **onCanPlay**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L428)

#### Inherited from

`EventHandlersElement.onCanPlay`

***

### onCanPlayThrough?

> `optional` **onCanPlayThrough**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:429](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L429)

#### Inherited from

`EventHandlersElement.onCanPlayThrough`

***

### onCapture?

> `optional` **onCapture**: `Record`\<`string`, `Function`\>

Defined in: [types/custom-attributes.d.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L11)

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`onCapture`](CustomDomAttributes.md#oncapture)

***

### onChange?

> `optional` **onChange**: `ChangeEventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:430](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L430)

#### Inherited from

`EventHandlersElement.onChange`

***

### onClick?

> `optional` **onClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/jsx-elements.d.ts:431](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L431)

#### Inherited from

`EventHandlersElement.onClick`

***

### onClickCapture?

> `optional` **onClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/custom-attributes.d.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L19)

***

### onClose?

> `optional` **onClose**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:432](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L432)

#### Inherited from

`EventHandlersElement.onClose`

***

### onCommand?

> `optional` **onCommand**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:434](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L434)

#### Inherited from

`EventHandlersElement.onCommand`

***

### onCompositionEnd?

> `optional` **onCompositionEnd**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [types/jsx-elements.d.ts:435](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L435)

#### Inherited from

`EventHandlersElement.onCompositionEnd`

***

### onCompositionStart?

> `optional` **onCompositionStart**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [types/jsx-elements.d.ts:436](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L436)

#### Inherited from

`EventHandlersElement.onCompositionStart`

***

### onCompositionUpdate?

> `optional` **onCompositionUpdate**: `EventHandler`\<`T`, `CompositionEvent`\>

Defined in: [types/jsx-elements.d.ts:437](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L437)

#### Inherited from

`EventHandlersElement.onCompositionUpdate`

***

### onContentVisibilityAutoStateChange?

> `optional` **onContentVisibilityAutoStateChange**: `EventHandler`\<`T`, `ContentVisibilityAutoStateChangeEvent`\>

Defined in: [types/jsx-elements.d.ts:438](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L438)

#### Inherited from

`EventHandlersElement.onContentVisibilityAutoStateChange`

***

### onContextLost?

> `optional` **onContextLost**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:441](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L441)

#### Inherited from

`EventHandlersElement.onContextLost`

***

### onContextMenu?

> `optional` **onContextMenu**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L442)

#### Inherited from

`EventHandlersElement.onContextMenu`

***

### onContextRestored?

> `optional` **onContextRestored**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L443)

#### Inherited from

`EventHandlersElement.onContextRestored`

***

### onCopy?

> `optional` **onCopy**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [types/jsx-elements.d.ts:444](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L444)

#### Inherited from

`EventHandlersElement.onCopy`

***

### onCueChange?

> `optional` **onCueChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:445](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L445)

#### Inherited from

`EventHandlersElement.onCueChange`

***

### onCut?

> `optional` **onCut**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [types/jsx-elements.d.ts:446](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L446)

#### Inherited from

`EventHandlersElement.onCut`

***

### onDblClick?

> `optional` **onDblClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/jsx-elements.d.ts:447](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L447)

#### Inherited from

`EventHandlersElement.onDblClick`

***

### onDblClickCapture?

> `optional` **onDblClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/custom-attributes.d.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L20)

***

### onDoubleClick?

> `optional` **onDoubleClick**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/custom-attributes.d.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L21)

***

### onDoubleClickCapture?

> `optional` **onDoubleClickCapture**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/custom-attributes.d.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L22)

***

### onDrag?

> `optional` **onDrag**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [types/jsx-elements.d.ts:448](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L448)

#### Inherited from

`EventHandlersElement.onDrag`

***

### onDragEnd?

> `optional` **onDragEnd**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [types/jsx-elements.d.ts:449](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L449)

#### Inherited from

`EventHandlersElement.onDragEnd`

***

### onDragEnter?

> `optional` **onDragEnter**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [types/jsx-elements.d.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L450)

#### Inherited from

`EventHandlersElement.onDragEnter`

***

### onDragExit?

> `optional` **onDragExit**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [types/jsx-elements.d.ts:451](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L451)

#### Inherited from

`EventHandlersElement.onDragExit`

***

### onDragLeave?

> `optional` **onDragLeave**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [types/jsx-elements.d.ts:452](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L452)

#### Inherited from

`EventHandlersElement.onDragLeave`

***

### onDragOver?

> `optional` **onDragOver**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [types/jsx-elements.d.ts:453](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L453)

#### Inherited from

`EventHandlersElement.onDragOver`

***

### onDragStart?

> `optional` **onDragStart**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [types/jsx-elements.d.ts:454](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L454)

#### Inherited from

`EventHandlersElement.onDragStart`

***

### onDrop?

> `optional` **onDrop**: `EventHandler`\<`T`, `DragEvent`\>

Defined in: [types/jsx-elements.d.ts:455](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L455)

#### Inherited from

`EventHandlersElement.onDrop`

***

### onDurationChange?

> `optional` **onDurationChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:456](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L456)

#### Inherited from

`EventHandlersElement.onDurationChange`

***

### onEmptied?

> `optional` **onEmptied**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:457](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L457)

#### Inherited from

`EventHandlersElement.onEmptied`

***

### onEnded?

> `optional` **onEnded**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:458](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L458)

#### Inherited from

`EventHandlersElement.onEnded`

***

### onError?

> `optional` **onError**: `EventHandler`\<`T`, `ErrorEvent`\>

Defined in: [types/jsx-elements.d.ts:459](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L459)

#### Inherited from

`EventHandlersElement.onError`

***

### onFocus?

> `optional` **onFocus**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [types/jsx-elements.d.ts:460](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L460)

#### Inherited from

`EventHandlersElement.onFocus`

***

### onFocusIn?

> `optional` **onFocusIn**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [types/jsx-elements.d.ts:461](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L461)

#### Inherited from

`EventHandlersElement.onFocusIn`

***

### onFocusOut?

> `optional` **onFocusOut**: `FocusEventHandler`\<`T`, `FocusEvent`\>

Defined in: [types/jsx-elements.d.ts:462](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L462)

#### Inherited from

`EventHandlersElement.onFocusOut`

***

### onFormData?

> `optional` **onFormData**: `EventHandler`\<`T`, `FormDataEvent`\>

Defined in: [types/jsx-elements.d.ts:463](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L463)

#### Inherited from

`EventHandlersElement.onFormData`

***

### onFullscreenChange?

> `optional` **onFullscreenChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:464](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L464)

#### Inherited from

`EventHandlersElement.onFullscreenChange`

***

### onFullscreenError?

> `optional` **onFullscreenError**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:465](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L465)

#### Inherited from

`EventHandlersElement.onFullscreenError`

***

### onGotPointerCapture?

> `optional` **onGotPointerCapture**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:466](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L466)

#### Inherited from

`EventHandlersElement.onGotPointerCapture`

***

### onInput?

> `optional` **onInput**: `InputEventHandler`\<`T`, `InputEvent`\>

Defined in: [types/jsx-elements.d.ts:467](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L467)

#### Inherited from

`EventHandlersElement.onInput`

***

### onInvalid?

> `optional` **onInvalid**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:468](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L468)

#### Inherited from

`EventHandlersElement.onInvalid`

***

### onKeyDown?

> `optional` **onKeyDown**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [types/jsx-elements.d.ts:469](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L469)

#### Inherited from

`EventHandlersElement.onKeyDown`

***

### onKeyPress?

> `optional` **onKeyPress**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [types/jsx-elements.d.ts:470](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L470)

#### Inherited from

`EventHandlersElement.onKeyPress`

***

### onKeyUp?

> `optional` **onKeyUp**: `EventHandler`\<`T`, `KeyboardEvent`\>

Defined in: [types/jsx-elements.d.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L471)

#### Inherited from

`EventHandlersElement.onKeyUp`

***

### onLoad?

> `optional` **onLoad**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:472](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L472)

#### Inherited from

`EventHandlersElement.onLoad`

***

### onLoadedData?

> `optional` **onLoadedData**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:473](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L473)

#### Inherited from

`EventHandlersElement.onLoadedData`

***

### onLoadedMetadata?

> `optional` **onLoadedMetadata**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:474](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L474)

#### Inherited from

`EventHandlersElement.onLoadedMetadata`

***

### onLoadStart?

> `optional` **onLoadStart**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:475](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L475)

#### Inherited from

`EventHandlersElement.onLoadStart`

***

### onLostPointerCapture?

> `optional` **onLostPointerCapture**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:476](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L476)

#### Inherited from

`EventHandlersElement.onLostPointerCapture`

***

### onMouseDown?

> `optional` **onMouseDown**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/jsx-elements.d.ts:477](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L477)

#### Inherited from

`EventHandlersElement.onMouseDown`

***

### onMouseEnter?

> `optional` **onMouseEnter**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/jsx-elements.d.ts:478](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L478)

#### Inherited from

`EventHandlersElement.onMouseEnter`

***

### onMouseLeave?

> `optional` **onMouseLeave**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/jsx-elements.d.ts:479](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L479)

#### Inherited from

`EventHandlersElement.onMouseLeave`

***

### onMouseMove?

> `optional` **onMouseMove**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/jsx-elements.d.ts:480](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L480)

#### Inherited from

`EventHandlersElement.onMouseMove`

***

### onMouseOut?

> `optional` **onMouseOut**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/jsx-elements.d.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L481)

#### Inherited from

`EventHandlersElement.onMouseOut`

***

### onMouseOver?

> `optional` **onMouseOver**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/jsx-elements.d.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L482)

#### Inherited from

`EventHandlersElement.onMouseOver`

***

### onMouseUp?

> `optional` **onMouseUp**: `EventHandler`\<`T`, `MouseEvent`\>

Defined in: [types/jsx-elements.d.ts:483](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L483)

#### Inherited from

`EventHandlersElement.onMouseUp`

***

### onPaste?

> `optional` **onPaste**: `EventHandler`\<`T`, `ClipboardEvent`\>

Defined in: [types/jsx-elements.d.ts:484](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L484)

#### Inherited from

`EventHandlersElement.onPaste`

***

### onPause?

> `optional` **onPause**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:485](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L485)

#### Inherited from

`EventHandlersElement.onPause`

***

### onPlay?

> `optional` **onPlay**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:486](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L486)

#### Inherited from

`EventHandlersElement.onPlay`

***

### onPlaying?

> `optional` **onPlaying**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:487](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L487)

#### Inherited from

`EventHandlersElement.onPlaying`

***

### onPointerCancel?

> `optional` **onPointerCancel**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:488](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L488)

#### Inherited from

`EventHandlersElement.onPointerCancel`

***

### onPointerDown?

> `optional` **onPointerDown**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:489](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L489)

#### Inherited from

`EventHandlersElement.onPointerDown`

***

### onPointerEnter?

> `optional` **onPointerEnter**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:490](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L490)

#### Inherited from

`EventHandlersElement.onPointerEnter`

***

### onPointerLeave?

> `optional` **onPointerLeave**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:491](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L491)

#### Inherited from

`EventHandlersElement.onPointerLeave`

***

### onPointerMove?

> `optional` **onPointerMove**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:492](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L492)

#### Inherited from

`EventHandlersElement.onPointerMove`

***

### onPointerOut?

> `optional` **onPointerOut**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L493)

#### Inherited from

`EventHandlersElement.onPointerOut`

***

### onPointerOver?

> `optional` **onPointerOver**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:494](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L494)

#### Inherited from

`EventHandlersElement.onPointerOver`

***

### onPointerRawUpdate?

> `optional` **onPointerRawUpdate**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L495)

#### Inherited from

`EventHandlersElement.onPointerRawUpdate`

***

### onPointerUp?

> `optional` **onPointerUp**: `EventHandler`\<`T`, `PointerEvent`\>

Defined in: [types/jsx-elements.d.ts:496](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L496)

#### Inherited from

`EventHandlersElement.onPointerUp`

***

### onProgress?

> `optional` **onProgress**: `EventHandler`\<`T`, `ProgressEvent`\<`EventTarget`\>\>

Defined in: [types/jsx-elements.d.ts:497](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L497)

#### Inherited from

`EventHandlersElement.onProgress`

***

### onRateChange?

> `optional` **onRateChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:498](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L498)

#### Inherited from

`EventHandlersElement.onRateChange`

***

### onReset?

> `optional` **onReset**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:499](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L499)

#### Inherited from

`EventHandlersElement.onReset`

***

### onResize?

> `optional` **onResize**: `EventHandler`\<`T`, `UIEvent`\>

Defined in: [types/jsx-elements.d.ts:500](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L500)

#### Inherited from

`EventHandlersElement.onResize`

***

### onScroll?

> `optional` **onScroll**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:501](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L501)

#### Inherited from

`EventHandlersElement.onScroll`

***

### onScrollEnd?

> `optional` **onScrollEnd**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L502)

#### Inherited from

`EventHandlersElement.onScrollEnd`

***

### onScrollSnapChange?

> `optional` **onScrollSnapChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:503](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L503)

#### Inherited from

`EventHandlersElement.onScrollSnapChange`

***

### onScrollSnapChanging?

> `optional` **onScrollSnapChanging**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:504](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L504)

#### Inherited from

`EventHandlersElement.onScrollSnapChanging`

***

### onSecurityPolicyViolation?

> `optional` **onSecurityPolicyViolation**: `EventHandler`\<`T`, `SecurityPolicyViolationEvent`\>

Defined in: [types/jsx-elements.d.ts:505](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L505)

#### Inherited from

`EventHandlersElement.onSecurityPolicyViolation`

***

### onSeeked?

> `optional` **onSeeked**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:506](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L506)

#### Inherited from

`EventHandlersElement.onSeeked`

***

### onSeeking?

> `optional` **onSeeking**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L507)

#### Inherited from

`EventHandlersElement.onSeeking`

***

### onSelect?

> `optional` **onSelect**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L508)

#### Inherited from

`EventHandlersElement.onSelect`

***

### onSelectionChange?

> `optional` **onSelectionChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:509](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L509)

#### Inherited from

`EventHandlersElement.onSelectionChange`

***

### onSelectStart?

> `optional` **onSelectStart**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L510)

#### Inherited from

`EventHandlersElement.onSelectStart`

***

### onSlotChange?

> `optional` **onSlotChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:511](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L511)

#### Inherited from

`EventHandlersElement.onSlotChange`

***

### onStalled?

> `optional` **onStalled**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:512](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L512)

#### Inherited from

`EventHandlersElement.onStalled`

***

### onSubmit?

> `optional` **onSubmit**: `EventHandler`\<`T`, `SubmitEvent`\>

Defined in: [types/jsx-elements.d.ts:513](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L513)

#### Inherited from

`EventHandlersElement.onSubmit`

***

### onSuspend?

> `optional` **onSuspend**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L514)

#### Inherited from

`EventHandlersElement.onSuspend`

***

### onTimeUpdate?

> `optional` **onTimeUpdate**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:515](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L515)

#### Inherited from

`EventHandlersElement.onTimeUpdate`

***

### onToggle?

> `optional` **onToggle**: `EventHandler`\<`T`, `ToggleEvent`\>

Defined in: [types/jsx-elements.d.ts:516](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L516)

#### Inherited from

`EventHandlersElement.onToggle`

***

### onTouchCancel?

> `optional` **onTouchCancel**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [types/jsx-elements.d.ts:517](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L517)

#### Inherited from

`EventHandlersElement.onTouchCancel`

***

### onTouchEnd?

> `optional` **onTouchEnd**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [types/jsx-elements.d.ts:518](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L518)

#### Inherited from

`EventHandlersElement.onTouchEnd`

***

### onTouchMove?

> `optional` **onTouchMove**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [types/jsx-elements.d.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L519)

#### Inherited from

`EventHandlersElement.onTouchMove`

***

### onTouchStart?

> `optional` **onTouchStart**: `EventHandler`\<`T`, `TouchEvent`\>

Defined in: [types/jsx-elements.d.ts:520](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L520)

#### Inherited from

`EventHandlersElement.onTouchStart`

***

### onTransitionCancel?

> `optional` **onTransitionCancel**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [types/jsx-elements.d.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L521)

#### Inherited from

`EventHandlersElement.onTransitionCancel`

***

### onTransitionEnd?

> `optional` **onTransitionEnd**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [types/jsx-elements.d.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L522)

#### Inherited from

`EventHandlersElement.onTransitionEnd`

***

### onTransitionRun?

> `optional` **onTransitionRun**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [types/jsx-elements.d.ts:523](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L523)

#### Inherited from

`EventHandlersElement.onTransitionRun`

***

### onTransitionStart?

> `optional` **onTransitionStart**: `EventHandler`\<`T`, `TransitionEvent`\>

Defined in: [types/jsx-elements.d.ts:524](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L524)

#### Inherited from

`EventHandlersElement.onTransitionStart`

***

### onVolumeChange?

> `optional` **onVolumeChange**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:525](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L525)

#### Inherited from

`EventHandlersElement.onVolumeChange`

***

### onWaiting?

> `optional` **onWaiting**: `EventHandler`\<`T`, `Event`\>

Defined in: [types/jsx-elements.d.ts:526](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L526)

#### Inherited from

`EventHandlersElement.onWaiting`

***

### onWheel?

> `optional` **onWheel**: `EventHandler`\<`T`, `WheelEvent`\>

Defined in: [types/jsx-elements.d.ts:527](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L527)

#### Inherited from

`EventHandlersElement.onWheel`

***

### part?

> `optional` **part**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L574)

***

### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`T`\>

Defined in: [types/custom-attributes.d.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L7)

#### Inherited from

[`CustomDomAttributes`](CustomDomAttributes.md).[`ref`](CustomDomAttributes.md#ref)

***

### role?

> `optional` **role**: [`PropValue`](../type-aliases/PropValue.md)\<`RemoveAttribute` \| `"grid"` \| `"search"` \| `"link"` \| `"none"` \| `"list"` \| `"menu"` \| `"listbox"` \| `"tree"` \| `"dialog"` \| `"alert"` \| `"alertdialog"` \| `"application"` \| `"article"` \| `"banner"` \| `"button"` \| `"cell"` \| `"checkbox"` \| `"columnheader"` \| `"combobox"` \| `"complementary"` \| `"contentinfo"` \| `"definition"` \| `"directory"` \| `"document"` \| `"feed"` \| `"figure"` \| `"form"` \| `"gridcell"` \| `"group"` \| `"heading"` \| `"img"` \| `"listitem"` \| `"log"` \| `"main"` \| `"marquee"` \| `"math"` \| `"menubar"` \| `"menuitem"` \| `"menuitemcheckbox"` \| `"menuitemradio"` \| `"meter"` \| `"navigation"` \| `"note"` \| `"option"` \| `"presentation"` \| `"progressbar"` \| `"radio"` \| `"radiogroup"` \| `"region"` \| `"row"` \| `"rowgroup"` \| `"rowheader"` \| `"scrollbar"` \| `"searchbox"` \| `"separator"` \| `"slider"` \| `"spinbutton"` \| `"status"` \| `"switch"` \| `"tab"` \| `"table"` \| `"tablist"` \| `"tabpanel"` \| `"term"` \| `"textbox"` \| `"timer"` \| `"toolbar"` \| `"tooltip"` \| `"treegrid"` \| `"treeitem"`\>

Defined in: [types/jsx-elements.d.ts:368](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L368)

#### Inherited from

`AriaAttributes.role`

***

### slot?

> `optional` **slot**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:575](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L575)

***

### style?

> `optional` **style**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `RemoveAttribute` \| [`StyleProperties`](../type-aliases/StyleProperties.md)\>

Defined in: [types/jsx-elements.d.ts:576](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L576)

***

### tabindex?

> `optional` **tabindex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/jsx-elements.d.ts:577](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L577)

***

### tabIndex?

> `optional` **tabIndex**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number` \| `RemoveAttribute`\>

Defined in: [types/custom-attributes.d.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L17)

***

### textContent?

> `optional` **textContent**: [`PropValue`](../type-aliases/PropValue.md)\<`string` \| `number`\>

Defined in: [types/jsx-elements.d.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-elements.d.ts#L566)
