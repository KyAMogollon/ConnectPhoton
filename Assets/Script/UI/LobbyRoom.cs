using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyRoom : MonoBehaviour
{
    public void CreateRoom()
    {
        UIManager.instance.ActivateComponent(ComponentUI.CreateRoom);
    }
}
