using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class CreatePlayerMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _InputplayerName;
    [SerializeField] private SOSkin Guardado;
    [SerializeField] private CharacterSelectionSO saved;

    public void SetNickName()
    {
        PhotonNetwork.NickName = _InputplayerName.text;
        UIManager.instance.ActivateComponent(ComponentUI.MenuLobby);
        saved.name = _InputplayerName.text;
        Guardado.name = _InputplayerName.text;

    }
    public TMP_Text GetNickName()
    {
        return _InputplayerName;
    }
}
