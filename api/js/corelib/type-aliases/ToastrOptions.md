[@serenity-is/corelib](../README.md) / ToastrOptions

# Type Alias: ToastrOptions

> **ToastrOptions**: [`ToastContainerOptions`](ToastContainerOptions.md) & `object`

## Type declaration

### closeButton?

> `optional` **closeButton**: `boolean`

Show a close button, default is false

### closeClass?

> `optional` **closeClass**: `string`

CSS class for close button

### closeHtml?

> `optional` **closeHtml**: `string`

Close button markup

### closeOnHover?

> `optional` **closeOnHover**: `boolean`

If true (default) toast keeps open when hovered, and closes after extendedTimeout when mouse leaves the toast

### escapeHtml?

> `optional` **escapeHtml**: `boolean`

Escape message html, default is true

### extendedTimeOut?

> `optional` **extendedTimeOut**: `number`

If closeOnHover is true, the toast closes in extendedTimeout duration after the mouse leaves the toast. Default is 1000

### iconClass?

> `optional` **iconClass**: `string`

CSS class for icon

### messageClass?

> `optional` **messageClass**: `string`

CSS class for message

### newestOnTop?

> `optional` **newestOnTop**: `boolean`

Show newest on top

### onclick()?

> `optional` **onclick**: (`event`) => `void`

#### Parameters

##### event

`MouseEvent`

#### Returns

`void`

### onCloseClick()?

> `optional` **onCloseClick**: (`event`) => `void`

#### Parameters

##### event

`Event`

#### Returns

`void`

### onHidden()?

> `optional` **onHidden**: () => `void`

#### Returns

`void`

### onShown()?

> `optional` **onShown**: () => `void`

#### Returns

`void`

### positionClass?

> `optional` **positionClass**: `string`

CSS class for toast positioning

### preventDuplicates?

> `optional` **preventDuplicates**: `boolean`

Prevent duplicates of the same toast, default is false

### rtl?

> `optional` **rtl**: `boolean`

Right to left

### tapToDismiss?

> `optional` **tapToDismiss**: `boolean`

Hides the notification when clicked, default is true

### target?

> `optional` **target**: `string`

The container element id

### timeOut?

> `optional` **timeOut**: `number`

The duration for the toast to stay in the page. Set to -1 to make the toast sticky, in that case extendedTimeout is ignored.

### titleClass?

> `optional` **titleClass**: `string`

CSS class for title

### toastClass?

> `optional` **toastClass**: `string`

CSS class for toast

## Defined in

[src/base/toastr2.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.ts#L10)
