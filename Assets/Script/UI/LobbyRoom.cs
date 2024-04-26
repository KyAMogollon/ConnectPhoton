using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LobbyRoom : MonoBehaviour
{
    [SerializeField] CreatePlayerMenu playerMenu;
    public TMP_Text namePlayer;
    public void CreateRoom()
    {
        UIManager.instance.ActivateComponent(ComponentUI.CreateRoom);
    }
    private void OnEnable()
    {
        namePlayer.text = "NickName: " + playerMenu.GetNickName().text;
    }
    public void OnMovementRight()
    {
        ChangeAvatar.instance.Move(1);
    }
    public void OnMovementLeft()
    {
        ChangeAvatar.instance.Move(-1);
    }
}
