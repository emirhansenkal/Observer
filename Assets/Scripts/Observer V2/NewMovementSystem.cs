using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovementSystem : MonoBehaviour
{//Observer

    private void Start()
    {
        /*
        NewMovementPanel.OnForwardButtonClicked += MoveForward;
        NewMovementPanel.OnBackButtonClicked += MoveBack;
        NewMovementPanel.OnLeftButtonClicked += MoveLeft;
        NewMovementPanel.OnRightButtonClicked += MoveRight;
        */

        NewMovementPanel.OnButtonClicked += Move;
    }

    private void OnDestroy()
    {
        NewMovementPanel.OnButtonClicked -= Move;
    }

    public void MoveForward() => transform.Translate(Vector3.forward);
    public void MoveBack() => transform.Translate(Vector3.back);
    public void MoveLeft() => transform.Translate(Vector3.left);
    public void MoveRight() => transform.Translate(Vector3.right);

    public void Move(Vector3 direction) => transform.Translate(direction);
}
