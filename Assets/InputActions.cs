// GENERATED AUTOMATICALLY FROM 'Assets/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""8d85ff6d-151f-4908-bad8-3aee8e685991"",
            ""actions"": [
                {
                    ""name"": ""Steering"",
                    ""type"": ""Button"",
                    ""id"": ""9ecf1d58-0b93-4fd0-a2d0-f4e6021b3902"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Speed"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ad436e85-db4b-4616-a8e5-11dc5a7fe637"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""c1cf4fce-385a-45e4-9b7f-60c3f52c0b12"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""854ea582-fcf6-4728-b8fc-1cb5db41e4f0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ca387b58-a3c3-40d7-b325-7774ccec51e1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""a750c1f3-abc2-473a-863e-42348f4ee17f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b15237fe-51e7-4116-a971-545984d6e363"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6849da63-2e77-4c33-bfbe-baff1f30841b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""3eddc0cd-cb48-4111-beb0-c869996fdcc6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speed"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0691a18d-0ca3-458d-9980-59cc2f55ed18"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""42de23f7-b4be-4452-aee9-60a39ce5b4f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""ee26014a-c985-45b1-8c52-b2683522bf04"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Speed"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e1695a32-01af-4b1b-9859-b2b6d5532935"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f7969629-8302-4598-aba0-b0aca834091f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Phone"",
            ""id"": ""5b7eb2a5-6754-4a22-9204-3fb09c9edbdb"",
            ""actions"": [
                {
                    ""name"": ""TouchInput"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2a37bce9-0a8c-4c38-b486-f855c0e2b8f0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3a210783-96a8-49a3-929d-8f7f8aa0fd6e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPress"",
                    ""type"": ""Button"",
                    ""id"": ""8aa22a14-8647-4732-bf62-f0d16cec2ecb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cf950db7-8442-4949-876b-303cb8541990"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""TouchInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9a09f36-3460-4bc0-acc9-a24237225216"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25041b0f-f5d1-4d04-929a-86ae09c27e93"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""TouchPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Phone"",
            ""bindingGroup"": ""Phone"",
            ""devices"": [
                {
                    ""devicePath"": ""<Accelerometer>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gyroscope>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Steering = m_Driving.FindAction("Steering", throwIfNotFound: true);
        m_Driving_Speed = m_Driving.FindAction("Speed", throwIfNotFound: true);
        // Phone
        m_Phone = asset.FindActionMap("Phone", throwIfNotFound: true);
        m_Phone_TouchInput = m_Phone.FindAction("TouchInput", throwIfNotFound: true);
        m_Phone_TouchPosition = m_Phone.FindAction("TouchPosition", throwIfNotFound: true);
        m_Phone_TouchPress = m_Phone.FindAction("TouchPress", throwIfNotFound: true);
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

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Steering;
    private readonly InputAction m_Driving_Speed;
    public struct DrivingActions
    {
        private @InputActions m_Wrapper;
        public DrivingActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steering => m_Wrapper.m_Driving_Steering;
        public InputAction @Speed => m_Wrapper.m_Driving_Speed;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Steering.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Speed.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSpeed;
                @Speed.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSpeed;
                @Speed.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSpeed;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Speed.started += instance.OnSpeed;
                @Speed.performed += instance.OnSpeed;
                @Speed.canceled += instance.OnSpeed;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);

    // Phone
    private readonly InputActionMap m_Phone;
    private IPhoneActions m_PhoneActionsCallbackInterface;
    private readonly InputAction m_Phone_TouchInput;
    private readonly InputAction m_Phone_TouchPosition;
    private readonly InputAction m_Phone_TouchPress;
    public struct PhoneActions
    {
        private @InputActions m_Wrapper;
        public PhoneActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchInput => m_Wrapper.m_Phone_TouchInput;
        public InputAction @TouchPosition => m_Wrapper.m_Phone_TouchPosition;
        public InputAction @TouchPress => m_Wrapper.m_Phone_TouchPress;
        public InputActionMap Get() { return m_Wrapper.m_Phone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PhoneActions set) { return set.Get(); }
        public void SetCallbacks(IPhoneActions instance)
        {
            if (m_Wrapper.m_PhoneActionsCallbackInterface != null)
            {
                @TouchInput.started -= m_Wrapper.m_PhoneActionsCallbackInterface.OnTouchInput;
                @TouchInput.performed -= m_Wrapper.m_PhoneActionsCallbackInterface.OnTouchInput;
                @TouchInput.canceled -= m_Wrapper.m_PhoneActionsCallbackInterface.OnTouchInput;
                @TouchPosition.started -= m_Wrapper.m_PhoneActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_PhoneActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_PhoneActionsCallbackInterface.OnTouchPosition;
                @TouchPress.started -= m_Wrapper.m_PhoneActionsCallbackInterface.OnTouchPress;
                @TouchPress.performed -= m_Wrapper.m_PhoneActionsCallbackInterface.OnTouchPress;
                @TouchPress.canceled -= m_Wrapper.m_PhoneActionsCallbackInterface.OnTouchPress;
            }
            m_Wrapper.m_PhoneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchInput.started += instance.OnTouchInput;
                @TouchInput.performed += instance.OnTouchInput;
                @TouchInput.canceled += instance.OnTouchInput;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
                @TouchPress.started += instance.OnTouchPress;
                @TouchPress.performed += instance.OnTouchPress;
                @TouchPress.canceled += instance.OnTouchPress;
            }
        }
    }
    public PhoneActions @Phone => new PhoneActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    private int m_PhoneSchemeIndex = -1;
    public InputControlScheme PhoneScheme
    {
        get
        {
            if (m_PhoneSchemeIndex == -1) m_PhoneSchemeIndex = asset.FindControlSchemeIndex("Phone");
            return asset.controlSchemes[m_PhoneSchemeIndex];
        }
    }
    public interface IDrivingActions
    {
        void OnSteering(InputAction.CallbackContext context);
        void OnSpeed(InputAction.CallbackContext context);
    }
    public interface IPhoneActions
    {
        void OnTouchInput(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnTouchPress(InputAction.CallbackContext context);
    }
}
