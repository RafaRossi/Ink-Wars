using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualJoystick : MonoBehaviour
{
    [SerializeField]
    private VirtualJoystickAnalog leftAnalog;
    public VirtualJoystickAnalog LeftAnalog
    {
        get
        {
            return leftAnalog;
        }
    }
    
    [SerializeField]
    private VirtualJoystickFireButton fireButton;
    public VirtualJoystickFireButton FireButton
    {
        get
        {
            if(!fireButton)
                fireButton = GetComponentInParent<VirtualJoystickFireButton>();

            return fireButton;
        }
    }
    
    [SerializeField]
    private VirtualJoystickAnalog rightAnalog;
    public VirtualJoystickAnalog RightAnalog
    {
        get
        {
            return rightAnalog;
        }
    }
}
