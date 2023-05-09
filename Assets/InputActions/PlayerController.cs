// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""keyboard"",
            ""id"": ""f75a894a-0029-432c-bc44-1ea7f100dd8c"",
            ""actions"": [
                {
                    ""name"": ""ActionForward"",
                    ""type"": ""Button"",
                    ""id"": ""01736991-5e50-4a5e-ab1d-25bb377ee9f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionBackwards"",
                    ""type"": ""Button"",
                    ""id"": ""e059b0bb-4b15-4327-a3d3-b73c6e031b5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionLeft"",
                    ""type"": ""Button"",
                    ""id"": ""a749b729-4ccb-4668-b7c6-0985db58bc9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionRight"",
                    ""type"": ""Button"",
                    ""id"": ""99799f3a-fe2e-42a7-ba40-020b777fd445"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""10054d91-d3f9-423c-a088-b8f0ab6a17ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""60b6598b-4ca9-40b3-8fdc-cff1d305d0fa"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""510e6f56-1681-4557-8ff2-30cf273a9e8e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1de2771e-f24f-4ec6-85b3-8d6af15264ae"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fc0a89d-0e7c-47a8-b2ea-5ccd809e5261"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9f5db72-4817-4585-afda-d14412554efc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // keyboard
        m_keyboard = asset.FindActionMap("keyboard", throwIfNotFound: true);
        m_keyboard_ActionForward = m_keyboard.FindAction("ActionForward", throwIfNotFound: true);
        m_keyboard_ActionBackwards = m_keyboard.FindAction("ActionBackwards", throwIfNotFound: true);
        m_keyboard_ActionLeft = m_keyboard.FindAction("ActionLeft", throwIfNotFound: true);
        m_keyboard_ActionRight = m_keyboard.FindAction("ActionRight", throwIfNotFound: true);
        m_keyboard_Fire = m_keyboard.FindAction("Fire", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // keyboard
    private readonly InputActionMap m_keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_keyboard_ActionForward;
    private readonly InputAction m_keyboard_ActionBackwards;
    private readonly InputAction m_keyboard_ActionLeft;
    private readonly InputAction m_keyboard_ActionRight;
    private readonly InputAction m_keyboard_Fire;
    public struct KeyboardActions
    {
        private @PlayerController m_Wrapper;
        public KeyboardActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @ActionForward => m_Wrapper.m_keyboard_ActionForward;
        public InputAction @ActionBackwards => m_Wrapper.m_keyboard_ActionBackwards;
        public InputAction @ActionLeft => m_Wrapper.m_keyboard_ActionLeft;
        public InputAction @ActionRight => m_Wrapper.m_keyboard_ActionRight;
        public InputAction @Fire => m_Wrapper.m_keyboard_Fire;
        public InputActionMap Get() { return m_Wrapper.m_keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @ActionForward.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionForward;
                @ActionForward.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionForward;
                @ActionForward.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionForward;
                @ActionBackwards.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionBackwards;
                @ActionBackwards.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionBackwards;
                @ActionBackwards.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionBackwards;
                @ActionLeft.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionLeft;
                @ActionLeft.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionLeft;
                @ActionLeft.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionLeft;
                @ActionRight.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionRight;
                @ActionRight.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionRight;
                @ActionRight.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnActionRight;
                @Fire.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ActionForward.started += instance.OnActionForward;
                @ActionForward.performed += instance.OnActionForward;
                @ActionForward.canceled += instance.OnActionForward;
                @ActionBackwards.started += instance.OnActionBackwards;
                @ActionBackwards.performed += instance.OnActionBackwards;
                @ActionBackwards.canceled += instance.OnActionBackwards;
                @ActionLeft.started += instance.OnActionLeft;
                @ActionLeft.performed += instance.OnActionLeft;
                @ActionLeft.canceled += instance.OnActionLeft;
                @ActionRight.started += instance.OnActionRight;
                @ActionRight.performed += instance.OnActionRight;
                @ActionRight.canceled += instance.OnActionRight;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public KeyboardActions @keyboard => new KeyboardActions(this);
    public interface IKeyboardActions
    {
        void OnActionForward(InputAction.CallbackContext context);
        void OnActionBackwards(InputAction.CallbackContext context);
        void OnActionLeft(InputAction.CallbackContext context);
        void OnActionRight(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
