using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPanel : Subject
{
    public void ForwardOnClick()
    {
        Notify(NotificationType.ForwardButton);
    }
    public void BackOnClick()
    {
        Notify(NotificationType.BackButton);
    }
    public void RightOnClick()
    {
        Notify(NotificationType.RightButton);
    }
    public void LeftOnClick()
    {
        Notify(NotificationType.LeftButton);
    }
}
