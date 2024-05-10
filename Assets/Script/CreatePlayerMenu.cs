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
        saved._NickName = PhotonNetwork.NickName;
        UIManager.instance.ActivateComponent(ComponentUI.MenuLobby);
        Guardado.namePlayer = _InputplayerName.text;

    }
    public TMP_Text GetNickName()
    {
        return _InputplayerName;
    }
}
