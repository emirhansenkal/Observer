using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovementPanel : MonoBehaviour
{
//Subject

    public static event Action OnForwardButtonClicked;
    public static event Action OnBackButtonClicked;
    public static event Action OnRightButtonClicked;
    public static event Action OnLeftButtonClicked;

    public static event Action<Vector3> OnButtonClicked; 

    public void ForwardOnClick()
    {
        //OnForwardButtonClicked?.Invoke();
        OnButtonClicked?.Invoke(Vector3.forward);
    }
    public void BackOnClick()
    {
        //OnBackButtonClicked?.Invoke();
        OnButtonClicked?.Invoke(Vector3.back*2);
        
    }
    public void RightOnClick()
    {
        //OnRightButtonClicked?.Invoke();
        OnButtonClicked?.Invoke(Vector3.right);
    }
    public void LeftOnClick()
    {
        //OnLeftButtonClicked?.Invoke();
        OnButtonClicked?.Invoke(Vector3.left);
    }
}
