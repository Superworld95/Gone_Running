//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Runner.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Runner: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Runner()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Runner"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""4cd4b78f-0b88-44aa-92ff-132bada37bbe"",
            ""actions"": [
                {
                    ""name"": ""Around"",
                    ""type"": ""Value"",
                    ""id"": ""c0b223a5-1dd9-4ec9-9c86-7d1be0d9ed7a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""60a7004a-6d37-4a84-95c0-200c9bda17c5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Around"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ab39ace4-783d-4ffe-b276-463bf8f74f8c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Around"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""954333ed-08c4-42d2-b5db-f8dd7e086498"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Around"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cd9db808-9be2-4bd7-b24a-a98dcd4e05fe"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Around"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2f2eb96a-e0cf-4dfb-8b57-6fccb06a994a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Around"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Jumping"",
            ""id"": ""165a0c54-cf9b-4e81-8977-4d8e9c53d2f6"",
            ""actions"": [
                {
                    ""name"": ""Rise"",
                    ""type"": ""Button"",
                    ""id"": ""2e15f810-5a8c-490a-a564-4a79c4f17ea3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6834cc2c-4753-4e84-a753-80cf0f525695"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Paused"",
            ""id"": ""e7db7be4-f1d6-4061-82f5-d2ef53c69fe2"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""3b6c0100-2258-4d68-bad4-d67285165aa3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f2939a75-4913-4472-9a73-3ba58b0f2026"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Basic"",
            ""bindingGroup"": ""Basic"",
            ""devices"": []
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Around = m_Movement.FindAction("Around", throwIfNotFound: true);
        // Jumping
        m_Jumping = asset.FindActionMap("Jumping", throwIfNotFound: true);
        m_Jumping_Rise = m_Jumping.FindAction("Rise", throwIfNotFound: true);
        // Paused
        m_Paused = asset.FindActionMap("Paused", throwIfNotFound: true);
        m_Paused_Pause = m_Paused.FindAction("Pause", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_Around;
    public struct MovementActions
    {
        private @Runner m_Wrapper;
        public MovementActions(@Runner wrapper) { m_Wrapper = wrapper; }
        public InputAction @Around => m_Wrapper.m_Movement_Around;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @Around.started += instance.OnAround;
            @Around.performed += instance.OnAround;
            @Around.canceled += instance.OnAround;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @Around.started -= instance.OnAround;
            @Around.performed -= instance.OnAround;
            @Around.canceled -= instance.OnAround;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Jumping
    private readonly InputActionMap m_Jumping;
    private List<IJumpingActions> m_JumpingActionsCallbackInterfaces = new List<IJumpingActions>();
    private readonly InputAction m_Jumping_Rise;
    public struct JumpingActions
    {
        private @Runner m_Wrapper;
        public JumpingActions(@Runner wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rise => m_Wrapper.m_Jumping_Rise;
        public InputActionMap Get() { return m_Wrapper.m_Jumping; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JumpingActions set) { return set.Get(); }
        public void AddCallbacks(IJumpingActions instance)
        {
            if (instance == null || m_Wrapper.m_JumpingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_JumpingActionsCallbackInterfaces.Add(instance);
            @Rise.started += instance.OnRise;
            @Rise.performed += instance.OnRise;
            @Rise.canceled += instance.OnRise;
        }

        private void UnregisterCallbacks(IJumpingActions instance)
        {
            @Rise.started -= instance.OnRise;
            @Rise.performed -= instance.OnRise;
            @Rise.canceled -= instance.OnRise;
        }

        public void RemoveCallbacks(IJumpingActions instance)
        {
            if (m_Wrapper.m_JumpingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IJumpingActions instance)
        {
            foreach (var item in m_Wrapper.m_JumpingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_JumpingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public JumpingActions @Jumping => new JumpingActions(this);

    // Paused
    private readonly InputActionMap m_Paused;
    private List<IPausedActions> m_PausedActionsCallbackInterfaces = new List<IPausedActions>();
    private readonly InputAction m_Paused_Pause;
    public struct PausedActions
    {
        private @Runner m_Wrapper;
        public PausedActions(@Runner wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Paused_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Paused; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PausedActions set) { return set.Get(); }
        public void AddCallbacks(IPausedActions instance)
        {
            if (instance == null || m_Wrapper.m_PausedActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PausedActionsCallbackInterfaces.Add(instance);
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IPausedActions instance)
        {
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IPausedActions instance)
        {
            if (m_Wrapper.m_PausedActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPausedActions instance)
        {
            foreach (var item in m_Wrapper.m_PausedActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PausedActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PausedActions @Paused => new PausedActions(this);
    private int m_BasicSchemeIndex = -1;
    public InputControlScheme BasicScheme
    {
        get
        {
            if (m_BasicSchemeIndex == -1) m_BasicSchemeIndex = asset.FindControlSchemeIndex("Basic");
            return asset.controlSchemes[m_BasicSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnAround(InputAction.CallbackContext context);
    }
    public interface IJumpingActions
    {
        void OnRise(InputAction.CallbackContext context);
    }
    public interface IPausedActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
