using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualJoystick : MonoBehaviour
{
    [SerializeField]
    private VirtualJoystickAnalog analog;
    public VirtualJoystickAnalog Analog
    {
        get
        {
            if(!analog)
            {
                analog = GetComponentInParent<VirtualJoystickAnalog>();
            }

            return analog;
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
    
}
