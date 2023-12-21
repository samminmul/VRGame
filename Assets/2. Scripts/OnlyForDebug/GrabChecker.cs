using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GrabChecker : MonoBehaviour
{
    public SteamVR_Input_Sources handType;
    public SteamVR_Behaviour_Pose controllerPose;
    public SteamVR_Action_Boolean grabAction;

    void Update()
    {
        if (grabAction.GetLastStateDown(handType))
        {
            Debug.Log("down");
        }
        if (grabAction.GetLastState(handType))
        {
            Debug.Log("hold");
        }
        if (grabAction.GetLastStateUp(handType))
        {
            Debug.Log("up");
        }
    }
}
