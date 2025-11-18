# @serenity-is/domwise

## DomWise (@serenity-is/domwise)

TypeScript library for creating and managing DOM elements using JSX syntax with strong typing and IDE support.

- This is primarily based on  [alex-kinokon/jsx-dom](https://github.com/alex-kinokon/jsx-dom) with integrated signal support via [@preact/signals](https://github.com/preactjs/signals) and some extra types / ideas from [ryansolid/dom-expressions](https://github.com/ryansolid/dom-expressions) and [lusito/tsx-dom](https://github.com/Lusito/tsx-dom).
- Enables creating and manipulating DOM elements using JSX syntax with strong typing and IDE support.

## Namespaces

- [JSX](@serenity-is/namespaces/JSX/README.md)

## Classes

- [Component](classes/Component.md)

## Interfaces

- [BasicClassList](interfaces/BasicClassList.md)
- [ComponentClass](interfaces/ComponentClass.md)
- [Computed](interfaces/Computed.md)
- [CustomDomAttributes](interfaces/CustomDomAttributes.md)
- [EffectOptions](interfaces/EffectOptions.md)
- [ElementAttributes](interfaces/ElementAttributes.md)
- [HTMLElementTags](interfaces/HTMLElementTags.md)
- [MathMLElementTags](interfaces/MathMLElementTags.md)
- [PropBinding](interfaces/PropBinding.md)
- [PropHook](interfaces/PropHook.md)
- [Signal](interfaces/Signal.md)
- [SignalLike](interfaces/SignalLike.md)
- [SignalOptions](interfaces/SignalOptions.md)
- [SVGElementTags](interfaces/SVGElementTags.md)

## Type Aliases

- [ClassName](type-aliases/ClassName.md)
- [ClassNames](type-aliases/ClassNames.md)
- [ComponentChild](type-aliases/ComponentChild.md)
- [ComponentChildren](type-aliases/ComponentChildren.md)
- [ComponentType](type-aliases/ComponentType.md)
- [EffectDisposer](type-aliases/EffectDisposer.md)
- [ExcludeMethods](type-aliases/ExcludeMethods.md)
- [FunctionComponent](type-aliases/FunctionComponent.md)
- [JSXElement](type-aliases/JSXElement.md)
- [PropValue](type-aliases/PropValue.md)
- [Ref](type-aliases/Ref.md)
- [RefCallback](type-aliases/RefCallback.md)
- [RefObject](type-aliases/RefObject.md)
- [RemoveIndex](type-aliases/RemoveIndex.md)
- [ShadowRootContainer](type-aliases/ShadowRootContainer.md)
- [SignalOrValue](type-aliases/SignalOrValue.md)
- [StyleAttributes](type-aliases/StyleAttributes.md)
- [StyleProperties](type-aliases/StyleProperties.md)
- [StylePropertiesBase](type-aliases/StylePropertiesBase.md)

## Variables

- [batch](variables/batch.md)
- [computed](variables/computed.md)
- [effect](variables/effect.md)
- [initPropHookSymbol](variables/initPropHookSymbol.md)
- [MathMLNamespace](variables/MathMLNamespace.md)
- [signal](variables/signal.md)
- [SVGNamespace](variables/SVGNamespace.md)
- [untracked](variables/untracked.md)

## Functions

- [addDisposingListener](functions/addDisposingListener.md)
- [bindThis](functions/bindThis.md)
- [className](functions/className.md)
- [createElement](functions/createElement.md)
- [createRef](functions/createRef.md)
- [currentLifecycleRoot](functions/currentLifecycleRoot.md)
- [currentNamespaceURI](functions/currentNamespaceURI.md)
- [derivedSignal](functions/derivedSignal.md)
- [dispatchDisposingEvent](functions/dispatchDisposingEvent.md)
- [Fragment](functions/Fragment.md)
- [inHTMLNamespace](functions/inHTMLNamespace.md)
- [inMathMLNamespace](functions/inMathMLNamespace.md)
- [inNamespaceURI](functions/inNamespaceURI.md)
- [inSVGNamespace](functions/inSVGNamespace.md)
- [invokeDisposingListeners](functions/invokeDisposingListeners.md)
- [isSignalLike](functions/isSignalLike.md)
- [jsx](functions/jsx.md)
- [observeSignal](functions/observeSignal.md)
- [removeDisposingListener](functions/removeDisposingListener.md)
- [setRef](functions/setRef.md)
- [ShadowRootNode](functions/ShadowRootNode.md)
- [useClassList](functions/useClassList.md)
- [useImperativeHandle](functions/useImperativeHandle.md)
- [usePropBinding](functions/usePropBinding.md)
- [useSignal](functions/useSignal.md)
- [useText](functions/useText.md)

## References

### h

Renames and re-exports [createElement](functions/createElement.md)

***

### jsxs

Renames and re-exports [jsx](functions/jsx.md)

***

### useRef

Renames and re-exports [createRef](functions/createRef.md)
