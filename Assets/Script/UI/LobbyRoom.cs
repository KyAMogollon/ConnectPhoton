using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class LobbyRoom : MonoBehaviour
{
    [SerializeField] CreatePlayerMenu playerMenu;
    public TMP_Text namePlayer;
    [SerializeField] CharacterSelectionSO saved;
    public void CreateRoom()
    {
        saved.player = ChangeAvatar.instance.ListComponents[ChangeAvatar.instance.Index].gameObject;
        saved.currentType = (TypePath)ChangeAvatar.instance.ListComponents[ChangeAvatar.instance.Index].type;

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



