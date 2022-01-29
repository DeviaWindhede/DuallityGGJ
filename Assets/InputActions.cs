//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/InputActions.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Block"",
            ""id"": ""da063ac7-79d5-47e5-9261-9c36fe103688"",
            ""actions"": [
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""0deb1aff-be4c-48d5-a56e-8f6d93fa4e49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateAnalog"",
                    ""type"": ""Value"",
                    ""id"": ""2f601fc4-d2a4-4542-9361-a4db5c1a996e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateDigitalLeft"",
                    ""type"": ""Button"",
                    ""id"": ""b3e3765b-324f-44c2-b084-0b0d59b23d35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateDigitalRight"",
                    ""type"": ""Button"",
                    ""id"": ""605f1e52-478f-4cc2-9833-cc1b3af93262"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""8a244261-acf7-4c70-968b-6af153804ec3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Cycle"",
                    ""type"": ""Value"",
                    ""id"": ""ee5bb6a6-4ac2-47d8-8166-8f2f09a17055"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3a15196b-e917-40f5-99b7-e90066998747"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""424c7285-0543-4bc4-b251-3c0c77fdbe43"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateDigitalLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2ced20b5-35de-4eed-b0d4-bb532a2e5d58"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateAnalog"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c1bc5df7-44b6-49c4-8c8a-18df18c0d656"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateAnalog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""61398843-6e24-4ff6-8453-423d3dbdac5e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateAnalog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""01c5905f-6e59-4945-9d2c-c679d9113513"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.08)"",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8bdf2dd1-4bd2-44c4-b53b-6aea6520952d"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bd294617-5029-436d-8802-84875a4b3b02"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ec44253f-52bc-434d-abec-cdc3ae599c87"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""59aca6d3-74d9-4278-94cf-8b5097283b19"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bdd266e8-5a7e-43c2-a366-3364d294451f"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateDigitalRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5b05fe8d-1f8c-4164-abba-6e0f3fd46a58"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cycle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e9321ddf-e4c8-4915-bc2e-cc8076ca73af"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3a7f5d6d-33b3-41ba-9f29-e874f57e7dac"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""e649852d-8872-4270-9e6d-b1a3d4fec108"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""839a7d43-bb04-4e55-a839-e24a402d87b9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9ca03c5b-d665-4b55-a187-96462c75bb13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""245ee72d-cd81-4d77-bb2f-a646377e1adb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cf74d16b-b2b0-4d34-84f1-34a0f05224d3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ae37957-2fb8-4074-97e0-cda30b93483b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""277c852a-00d6-4096-8a04-f0390e4fa800"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0247d8da-7909-4e77-b4cf-88f02230323e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""632ae982-ebe4-4808-a213-6cd80dce751d"",
            ""actions"": [
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""8fa325b1-68b8-4839-8a82-93fcfd4da6e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""f30c4b2a-77c0-4988-98f2-0a850a0ebe29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""faa3f45f-925b-42e7-83b8-48d932913c50"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4bb77fef-97f6-4296-b363-5f9d1b7ee863"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bc8a828-abcb-4e24-8ffc-89d9dc968a8e"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f10a767e-87fe-4147-9888-5bfa9252273f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""3d41d18d-7aaa-4324-9b03-566a8fb1a2d9"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""ef7b6a39-35f9-41a5-a234-57c06e0f422d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b90221b4-f40f-4274-b1f9-d125138b0db0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""a3138fca-6395-4638-a9bd-9eb843601142"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""ba0e9429-5da0-454d-866e-d247ae045780"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Block
        m_Block = asset.FindActionMap("Block", throwIfNotFound: true);
        m_Block_Accept = m_Block.FindAction("Accept", throwIfNotFound: true);
        m_Block_RotateAnalog = m_Block.FindAction("RotateAnalog", throwIfNotFound: true);
        m_Block_RotateDigitalLeft = m_Block.FindAction("RotateDigitalLeft", throwIfNotFound: true);
        m_Block_RotateDigitalRight = m_Block.FindAction("RotateDigitalRight", throwIfNotFound: true);
        m_Block_Direction = m_Block.FindAction("Direction", throwIfNotFound: true);
        m_Block_Cycle = m_Block.FindAction("Cycle", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Dash = m_Player.FindAction("Dash", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Accept = m_Menu.FindAction("Accept", throwIfNotFound: true);
        m_Menu_Back = m_Menu.FindAction("Back", throwIfNotFound: true);
        m_Menu_Direction = m_Menu.FindAction("Direction", throwIfNotFound: true);
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

    // Block
    private readonly InputActionMap m_Block;
    private IBlockActions m_BlockActionsCallbackInterface;
    private readonly InputAction m_Block_Accept;
    private readonly InputAction m_Block_RotateAnalog;
    private readonly InputAction m_Block_RotateDigitalLeft;
    private readonly InputAction m_Block_RotateDigitalRight;
    private readonly InputAction m_Block_Direction;
    private readonly InputAction m_Block_Cycle;
    public struct BlockActions
    {
        private @InputActions m_Wrapper;
        public BlockActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accept => m_Wrapper.m_Block_Accept;
        public InputAction @RotateAnalog => m_Wrapper.m_Block_RotateAnalog;
        public InputAction @RotateDigitalLeft => m_Wrapper.m_Block_RotateDigitalLeft;
        public InputAction @RotateDigitalRight => m_Wrapper.m_Block_RotateDigitalRight;
        public InputAction @Direction => m_Wrapper.m_Block_Direction;
        public InputAction @Cycle => m_Wrapper.m_Block_Cycle;
        public InputActionMap Get() { return m_Wrapper.m_Block; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BlockActions set) { return set.Get(); }
        public void SetCallbacks(IBlockActions instance)
        {
            if (m_Wrapper.m_BlockActionsCallbackInterface != null)
            {
                @Accept.started -= m_Wrapper.m_BlockActionsCallbackInterface.OnAccept;
                @Accept.performed -= m_Wrapper.m_BlockActionsCallbackInterface.OnAccept;
                @Accept.canceled -= m_Wrapper.m_BlockActionsCallbackInterface.OnAccept;
                @RotateAnalog.started -= m_Wrapper.m_BlockActionsCallbackInterface.OnRotateAnalog;
                @RotateAnalog.performed -= m_Wrapper.m_BlockActionsCallbackInterface.OnRotateAnalog;
                @RotateAnalog.canceled -= m_Wrapper.m_BlockActionsCallbackInterface.OnRotateAnalog;
                @RotateDigitalLeft.started -= m_Wrapper.m_BlockActionsCallbackInterface.OnRotateDigitalLeft;
                @RotateDigitalLeft.performed -= m_Wrapper.m_BlockActionsCallbackInterface.OnRotateDigitalLeft;
                @RotateDigitalLeft.canceled -= m_Wrapper.m_BlockActionsCallbackInterface.OnRotateDigitalLeft;
                @RotateDigitalRight.started -= m_Wrapper.m_BlockActionsCallbackInterface.OnRotateDigitalRight;
                @RotateDigitalRight.performed -= m_Wrapper.m_BlockActionsCallbackInterface.OnRotateDigitalRight;
                @RotateDigitalRight.canceled -= m_Wrapper.m_BlockActionsCallbackInterface.OnRotateDigitalRight;
                @Direction.started -= m_Wrapper.m_BlockActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_BlockActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_BlockActionsCallbackInterface.OnDirection;
                @Cycle.started -= m_Wrapper.m_BlockActionsCallbackInterface.OnCycle;
                @Cycle.performed -= m_Wrapper.m_BlockActionsCallbackInterface.OnCycle;
                @Cycle.canceled -= m_Wrapper.m_BlockActionsCallbackInterface.OnCycle;
            }
            m_Wrapper.m_BlockActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accept.started += instance.OnAccept;
                @Accept.performed += instance.OnAccept;
                @Accept.canceled += instance.OnAccept;
                @RotateAnalog.started += instance.OnRotateAnalog;
                @RotateAnalog.performed += instance.OnRotateAnalog;
                @RotateAnalog.canceled += instance.OnRotateAnalog;
                @RotateDigitalLeft.started += instance.OnRotateDigitalLeft;
                @RotateDigitalLeft.performed += instance.OnRotateDigitalLeft;
                @RotateDigitalLeft.canceled += instance.OnRotateDigitalLeft;
                @RotateDigitalRight.started += instance.OnRotateDigitalRight;
                @RotateDigitalRight.performed += instance.OnRotateDigitalRight;
                @RotateDigitalRight.canceled += instance.OnRotateDigitalRight;
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @Cycle.started += instance.OnCycle;
                @Cycle.performed += instance.OnCycle;
                @Cycle.canceled += instance.OnCycle;
            }
        }
    }
    public BlockActions @Block => new BlockActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Dash;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Dash => m_Wrapper.m_Player_Dash;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Dash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Accept;
    private readonly InputAction m_Menu_Back;
    private readonly InputAction m_Menu_Direction;
    public struct MenuActions
    {
        private @InputActions m_Wrapper;
        public MenuActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accept => m_Wrapper.m_Menu_Accept;
        public InputAction @Back => m_Wrapper.m_Menu_Back;
        public InputAction @Direction => m_Wrapper.m_Menu_Direction;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Accept.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnAccept;
                @Accept.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnAccept;
                @Accept.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnAccept;
                @Back.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnBack;
                @Direction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDirection;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accept.started += instance.OnAccept;
                @Accept.performed += instance.OnAccept;
                @Accept.canceled += instance.OnAccept;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IBlockActions
    {
        void OnAccept(InputAction.CallbackContext context);
        void OnRotateAnalog(InputAction.CallbackContext context);
        void OnRotateDigitalLeft(InputAction.CallbackContext context);
        void OnRotateDigitalRight(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
        void OnCycle(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnAccept(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
    }
}
